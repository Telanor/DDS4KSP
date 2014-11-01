using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;

namespace DDS4KSPcs
{
	internal static class MBMLoader
	{
		//mbm file container (header and raw image)
		public class MBMFile
		{
			//containers
			private Int32 h_3KSP;
			private Int32 width;
			private Int32 height;
			private Int32 normal;
			private Int32 colorDepth;

			public int Width
			{
				get { return width; }
			}

			public int Height
			{
				get { return height; }
			}

			public bool IsNormal
			{
				get { return (normal == 1); }
			}

			public int ColorDepth
			{
				get { return colorDepth; }
			}

			private byte[] imgRaw;
			//load a mbm from file
			public MBMFile(string sFilePath)
			{
				//load file
				var b = File.ReadAllBytes(sFilePath);
				//get infos from header
				ReadFromRaw(ref b, 0, out h_3KSP);
				ReadFromRaw(ref b, 4, out width);
				ReadFromRaw(ref b, 8, out height);
				ReadFromRaw(ref b, 12, out normal);
				ReadFromRaw(ref b, 16, out colorDepth);
				//copy image from raw data
				var img = new byte[b.Length - 20];
				for(var i = 20; i <= b.Length - 1; i++)
					img[i - 20] = b[i];
				imgRaw = img;
			}

			//old version. Working but slow, I keep it here just in case
			[Obsolete]
			public Bitmap AsBitmap_()
			{
				var bit = new Bitmap(Width, Height, PixelFormat.Format32bppArgb);

				for(var y = 0; y <= height - 1; y++)
				{
					for(var x = 0; x <= width - 1; x++)
					{
						byte a, r, g, b;

						ReadRGBA(x, y, out r, out g, out b, out a);
						bit.SetPixel(x, y, Color.FromArgb(a, r, g, b));
					}
				}
				return bit;
			}

			//new version, working and faster, but could probably be improved...(at the moment, the raw data are stored to a bitmap, then a stream is created from it to create the final texture)
			public Bitmap AsBitmap()
			{
				var bit = new Bitmap(Width, Height, PixelFormat.Format32bppArgb);
				var data = bit.LockBits(new Rectangle(0, 0, bit.Width, bit.Height), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
				var ptr = data.Scan0;
				var @by = new byte[(bit.Width * bit.Height * 4)];

				for(var y = 0; y <= height - 1; y++)
				{
					for(var x = 0; x <= width - 1; x++)
					{
						byte a, r, g, b;

						ReadRGBA(x, y, out r, out g, out b, out a);

						@by[((y * width) + x) * 4] = b;
						@by[(((y * width) + x) * 4) + 1] = g;
						@by[(((y * width) + x) * 4) + 2] = r;
						@by[(((y * width) + x) * 4) + 3] = a;
					}
				}
				Marshal.Copy(@by, 0, ptr, @by.Length);
				bit.UnlockBits(data);
				return bit;
			}

			//function to convert a raw byte array to a bitmap, handling swizzling
			private void ReadRGBA(int x, int y, out byte red, out byte green, out byte blue, out byte alpha)
			{
				var start = (y * width) + x;
				//24 bits (DXT1)
				if(colorDepth != 32)
				{
					start *= 3;
					alpha = 255;
					//irrelevant here, but set to 255 anyway, just in case
					blue = imgRaw[2 + start];
					green = imgRaw[1 + start];
					red = imgRaw[start];
					//32 bits(standard DXT5)
				}
				else
				{
					start *= 4;
					alpha = imgRaw[3 + start];
					blue = imgRaw[2 + start];
					green = imgRaw[1 + start];
					red = imgRaw[start];
				}
			}


			//attempt to free memory, I don't really trust the GarbageCollector. Honestly, I don't really trust this function either...
			public void Flush()
			{
				h_3KSP = 0;
				width = 0;
				height = 0;
				normal = 0;
				colorDepth = 0;
				imgRaw = null;
			}
		}

		//function to get only some infos from the header
		public static void GetInfo(string sFilePath, out int iWidth, out int iHeight, out bool isNormal, out string sFormat)
		{
			int i;
			int iBPP;
			var b = File.ReadAllBytes(sFilePath);

			ReadFromRaw(ref b, 4, out iWidth);
			ReadFromRaw(ref b, 8, out iHeight);
			ReadFromRaw(ref b, 12, out i);
			ReadFromRaw(ref b, 16, out iBPP);

			isNormal = (i == 1);
			sFormat = iBPP + "BPP (";

			if(iBPP == 24)
				sFormat += "R8G8B8)";
			else
				sFormat += "A8R8G8B8)";
		}

		//function to read from header/raw data
		private static void ReadFromRaw(ref byte[] b, int offset, out Int32 result)
		{
			result = 0;
			result += Convert.ToInt32(b[offset + 3]) << 24;
			result += Convert.ToInt32(b[offset + 2]) << 16;
			result += Convert.ToInt32(b[offset + 1]) << 8;
			result += Convert.ToInt32(b[offset]);
		}
	}
}