using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DDS4KSPcs
{
	internal static class FolderLoader
	{
		//will handle the logic behind folder conversion
		//containers
		private static readonly List<string> fileList = new List<string>();
		private static readonly List<string> backupList = new List<string>();
		public static readonly string ModExceptionPath = Directory.GetCurrentDirectory() + "\\ModsExceptions.txt";

		public static int FileSkipCount;
		//check if the folder is or is contained in a GameData folder, to show a warning.
		public static bool ValidDirectory(string sFolderPath)
		{
			return (sFolderPath.Contains("\\GameData"));
		}

		//refresh infos before processing
		public static void RefreshInfo(string sFolderPath, bool bUpdateLog, bool updateForm)
		{
			if(updateForm)
			{
				MainForm.SetTitleAppend("-creating files lists");
				Application.DoEvents();
			}

			fileList.Clear();
			backupList.Clear();

			//MBMs
			var sT = Directory.GetFiles(sFolderPath, "*.mbm", SearchOption.AllDirectories);
			var iMBMCount = sT.Length;
			fileList.AddRange(sT);
			//TGAs
			sT = Directory.GetFiles(sFolderPath, "*.tga", SearchOption.AllDirectories);
			var iTGACount = sT.Length;
			fileList.AddRange(sT);
			//mbms
			sT = Directory.GetFiles(sFolderPath, "*.png", SearchOption.AllDirectories);
			var iPNGCount = sT.Length;
			fileList.AddRange(sT);
			//backups
			sT = Directory.GetFiles(sFolderPath, "*.ddsified", SearchOption.AllDirectories);
			var iBackupCount = sT.Length;
			backupList.AddRange(sT);

			//refresh labels
			if(updateForm)
			{
				var pathSplit = sFolderPath.Split('\\');
				MainForm.DisplaySelectedFolder(pathSplit[pathSplit.Length - 2] + "\\" + pathSplit.Last());
			}

			if(bUpdateLog)
			{
				MainForm.Log_WriteLine("-----");
				MainForm.Log_WriteLine("Folder infos : ");
				MainForm.Log_WriteLine("MBM files count : " + iMBMCount);
				MainForm.Log_WriteLine("TGA files count : " + iTGACount);
				MainForm.Log_WriteLine("PNG files count : " + iPNGCount);
				MainForm.Log_WriteLine("Backup files count : " + iBackupCount);
				MainForm.Log_WriteLine("-----");
			}
			
			if(updateForm)
				MainForm.SetTitleAppend("");
		}

		//processing files lists
		public static void ProcessFileLists(string sFolderPath, FolderProcessingParams cfg)
		{
			RefreshInfo(sFolderPath, false, false);
			FileSkipCount = 0;
			
			var iExcludeCount = 0;
			var argHandler = new ArgumentsHandler();
			var lConvParms = new List<ImageManager.ConversionParameters>();
			
			foreach(var s in fileList)
			{
				if(!argHandler.IsFileExcluded(s, cfg))
					lConvParms.Add(argHandler.GetConversionParameters(s, cfg));
				else
					iExcludeCount += 1;
			}
			
			var iStep = 0;

			MainForm.Log_WriteLine("-----");
			MainForm.Log_WriteLine("Starting conversion of " + fileList.Count + " files.");
			MainForm.Log_WriteLine("    MBM count : " + argHandler.Count_MBM + ".");
			MainForm.Log_WriteLine("    TGA count : " + argHandler.Count_TGA + ".");
			MainForm.Log_WriteLine("    PNG count : " + argHandler.Count_PNG + ".");
			MainForm.Log_WriteLine(iExcludeCount + " files excluded, " + argHandler.Count_NoMipmaps + " files without mipmaps. " + (argHandler.Count_ForceNormal + argHandler.Count_ForceNotNormal) + " files will skip normal detection." + argHandler.Count_NoResize + " files will not be resized.");
			MainForm.Log_WriteLine("-----");

			var sw = Stopwatch.StartNew();
			//processing
			foreach(var c in lConvParms)
			{
				if(c.FileType == ImageManager.FileType.MBM)
					ImageManager.ConvertMBMtoDDS(c, cfg);
				else
					ImageManager.ConvertFileToDDS(c, cfg);

				iStep += 1;

				MainForm.ReportProgress(Convert.ToInt32((iStep / lConvParms.Count) * 100), "Processing " + Path.GetFileName(c.FilePath) + ", file " + iStep + "\\" + lConvParms.Count);
				MainForm.Log_WriteLine("---");
				Application.DoEvents();
			}

			sw.Stop();
			MainForm.Log_WriteLine("-----");
			MainForm.Log_WriteLine(String.Format("Conversion done! {0} files processed in {1}ms.", lConvParms.Count, sw.Elapsed.TotalMilliseconds));
			if(FileSkipCount > 0)
				MainForm.Log_WriteLine(FileSkipCount + " files skipped, check log.txt for more informations.");
			MainForm.Log_WriteLine("-----");
		}

		//backup files
		public static void BackupFiles(string sFolderPath)
		{
			var dontAskAgain = false;
			var yesNo = false;
			var deleteBackups = false;
			var iStep = 0;

			RefreshInfo(sFolderPath, false, false);
			
			MainForm.Log_WriteLine("-----");
			MainForm.Log_WriteLine("Starting backup of " + backupList.Count + " files");
			MainForm.Log_WriteLine("-----");
			
			foreach(var s in backupList)
			{
				var sBackupFile = s.Replace(".ddsified", "");
				var sDDSToDelete = Path.ChangeExtension(sBackupFile, "dds");

				if(File.Exists(sDDSToDelete))
					File.Delete(sDDSToDelete);

				if(File.Exists(sBackupFile))
				{
					if(!dontAskAgain)
					{
						var dialog = new OverwriteFileDialog();

						yesNo = (dialog.CustomShowDialog(sBackupFile, out dontAskAgain, ref deleteBackups) == DialogResult.Yes);
					}

					if(yesNo)
					{
						File.Delete(sBackupFile);
						File.Move(s, sBackupFile);

						MainForm.Log_WriteLine("Reverting " + sDDSToDelete + " to " + sBackupFile);
					}
					else
					{
						if(deleteBackups)
							File.Delete(s);

						MainForm.Log_WriteLine("Skipping backup of " + sBackupFile);
					}
				}
				else
				{
					File.Move(s, sBackupFile);
					MainForm.Log_WriteLine("Reverting " + sDDSToDelete + " to " + sBackupFile);
				}

				iStep += 1;
				
				MainForm.ReportProgress(Convert.ToInt32((iStep / backupList.Count) * 100), "Reverting " + Path.GetFileName(sBackupFile) + ", file " + iStep + "\\" + backupList.Count);
				MainForm.Log_WriteLine("---");
				Application.DoEvents();
			}

			MainForm.Log_WriteLine("-----");
			MainForm.Log_WriteLine("Backup done! " + backupList.Count + " files processed.");
			MainForm.Log_WriteLine("-----");
		}

		//novelty! a new, shiny class to handle arguments properly, instead of putting them in some lists (well, there are still lists, but with some better management)
		public class ArgumentsHandler
		{
			//containers for arguments, each list will contains part of filepath
			private readonly List<string> excludedList = new List<string>();
			private readonly List<string> forceNormalList = new List<string>();
			private readonly List<string> forceNotNormalList = new List<string>();
			private readonly List<string> noMipmapList = new List<string>();
			private readonly List<string> noResizeList = new List<string>();

			public int Count_MBM { get; private set; }
			public int Count_TGA { get; private set; }
			public int Count_PNG { get; private set; }
			public int Count_ForceNormal { get; private set; }
			public int Count_ForceNotNormal { get; private set; }
			public int Count_NoMipmaps { get; private set; }
			public int Count_NoResize { get; private set; }

			public ArgumentsHandler()
			{
				ResetCounts();
				forceNormalList.Clear();
				forceNotNormalList.Clear();
				noMipmapList.Clear();
				noResizeList.Clear();
				excludedList.Clear();
				RefreshArgumentsFromFile();
			}

			//will parse arguments from the ModsExceptions.txt file
			private void RefreshArgumentsFromFile()
			{
				var aA = File.ReadAllLines(ModExceptionPath);
				var lA = new List<string>();
				//get all lines without comments
				for(var i = 0; i <= aA.Length - 1; i++)
				{
					if(!aA[i].StartsWith("//"))
						lA.Add(aA[i]);
				}
				//cleaning all da stuff, I don't trust the GarbageCollector anymore...
				Array.Clear(aA, 0, aA.Length);
				//parsing arguments
				foreach(var s in lA)
				{
					var fn = false;
					var nn = false;
					var nm = false;
					var nr = false;

					//exclude file if no arguments
					if(!s.Contains(" -"))
						excludedList.Add(s);
					else
					{
						//force not normals
						if(s.Contains(" -nn"))
						{
							nn = true;
							//s = s.Replace(" -nn", "");
						}
						//force normals
						if(s.Contains(" -fn"))
						{
							fn = true;
							nn = false;
							//s = s.Replace(" -fn", "");
						}
						//force no mipmaps
						if(s.Contains(" -nm"))
						{
							nm = true;
							//s = s.Replace(" -nm", "");
						}
						//force no resize
						if(s.Contains(" -nr"))
						{
							nr = true;
							//s = s.Replace(" -nr", "");
						}
						if(nn)
							forceNotNormalList.Add(s);
						if(fn)
							forceNormalList.Add(s);
						if(nm)
							noMipmapList.Add(s);
						if(nr)
							noResizeList.Add(s);
					}
				}
			}

			//Return a boolean, test if the file should be excluded
			public bool IsFileExcluded(string sFilePath, FolderProcessingParams cfg)
			{
				var extension = Path.GetExtension(sFilePath);

				if(!cfg.ProcessMBMs && extension == ".mbm")
					return true;
				if(!cfg.ProcessTGAs && extension == ".tga")
					return true;
				if(!cfg.ProcessPNGs && extension == ".png")
					return true;

				var b = false;

				//No idea what this does
				for(var i = 0; i <= excludedList.Count - 1; i++)
				{
                    if(sFilePath.Contains(excludedList[i]))
                    {
                        i = excludedList.Count - 1;
                        b = true;
                        // performance optimization with long exclude lists:
                        // after first match dont check rest of exclusions
                        return b;
                    }

				}
				return b;
			}

			//return a conversion parameter for a single file, according to modsExceptions.txt
			public ImageManager.ConversionParameters GetConversionParameters(string sFilePath, FolderProcessingParams folderParams)
			{
				//resfresh counts
				var extension = Path.GetExtension(sFilePath);

				switch(extension)
				{
					case ".mbm":
						Count_MBM += 1;
						break;
					case ".tga":
						Count_TGA += 1;
						break;
					case ".png":
						Count_PNG += 1;
						break;
				}
				//resfresh parameters
				var cpRet = new ImageManager.ConversionParameters(sFilePath);
				if(folderParams.IgnoreExceptions)
				{
					//normals flag
					switch(folderParams.NormalsManagement)
					{
						case 0:
							cpRet.NormalMapConversion = ImageManager.NormalMapConversion.Automatic;
							break;
						case 1:
							cpRet.NormalMapConversion = ImageManager.NormalMapConversion.ForceNormal;
							Count_ForceNormal += 1;
							break;
						case 2:
							cpRet.NormalMapConversion = ImageManager.NormalMapConversion.ForceNotNormal;
							Count_ForceNotNormal += 1;
							break;
					}
					//mipmaps flag
					cpRet.MipmapSetting = folderParams.GenerateMipmaps ? ImageManager.MipmapSetting.Generate : ImageManager.MipmapSetting.DontGenerate;
					cpRet.ResizeSetting = ImageManager.ResizeSetting.AllowResize;
				}
				else
				{
					//normals flag
					var bB = false;
					for(var i = 0; i <= forceNormalList.Count - 1; i++)
					{
						if(sFilePath.Contains(forceNormalList[i]))
						{
							cpRet.NormalMapConversion = ImageManager.NormalMapConversion.ForceNormal;
							Count_ForceNormal += 1;
							i = forceNormalList.Count - 1;
							bB = true;
						}
					}
					if(!bB)
					{
						for(var i = 0; i <= forceNotNormalList.Count - 1; i++)
						{
							if(sFilePath.Contains(forceNotNormalList[i]))
							{
								cpRet.NormalMapConversion = ImageManager.NormalMapConversion.ForceNotNormal;
								Count_ForceNotNormal += 1;
								i = forceNotNormalList.Count - 1;
								bB = true;
							}
						}
					}
					if(!bB)
					{
						switch(folderParams.NormalsManagement)
						{
							case 0:
								cpRet.NormalMapConversion = ImageManager.NormalMapConversion.Automatic;
								break;
							case 1:
								cpRet.NormalMapConversion = ImageManager.NormalMapConversion.ForceNormal;
								Count_ForceNormal += 1;
								break;
							case 2:
								cpRet.NormalMapConversion = ImageManager.NormalMapConversion.ForceNotNormal;
								Count_ForceNotNormal += 1;
								break;
						}
					}
					//no mipmaps flag
					bB = false;
					for(var i = 0; i <= noMipmapList.Count - 1; i++)
					{
						if(sFilePath.Contains(noMipmapList[i]))
						{
							cpRet.MipmapSetting = ImageManager.MipmapSetting.DontGenerate;
							Count_NoMipmaps += 1;
							i = noMipmapList.Count - 1;
							bB = true;
						}
					}
					if(!bB)
					{
						if(folderParams.GenerateMipmaps)
							cpRet.MipmapSetting = ImageManager.MipmapSetting.Generate;
						else
						{
							cpRet.MipmapSetting = ImageManager.MipmapSetting.DontGenerate;
							Count_NoMipmaps += 1;
						}
					}
					//resize flag
					cpRet.ResizeSetting = ImageManager.ResizeSetting.AllowResize;
					for(var i = 0; i <= noResizeList.Count - 1; i++)
					{
						if(sFilePath.Contains(noResizeList[i]))
						{
							cpRet.ResizeSetting = ImageManager.ResizeSetting.DontAllowResize;
							Count_NoResize += 1;
						}
					}
				}
				return cpRet;
			}

			//reset files counting
			public void ResetCounts()
			{
				Count_MBM = 0;
				Count_TGA = 0;
				Count_PNG = 0;
				Count_ForceNormal = 0;
				Count_ForceNotNormal = 0;
				Count_NoMipmaps = 0;
				Count_NoResize = 0;
			}
		}
	}
}

