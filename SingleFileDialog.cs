using System;
using System.IO;
using System.Windows.Forms;

namespace DDS4KSPcs
{
	public partial class SingleFileDialog
	{
		private string sLoadedFile;
		private ImageManager.AutoParameters autoParameters;
		//enum for the format combobox. Not really necessary, but easier to read
		private enum Formats
		{
			DXT1 = 0,
			DXT5 = 1,
			R8G8B8 = 2,
			A8R8G8B8 = 3
		}

		public SingleFileDialog()
		{
			InitializeComponent();
		}

		//Button/Convert
		private void OK_Button_Click(Object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Close();
		}

		//Button/Cancel
		private void Cancel_Button_Click(Object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		//Custom function to call ShowDialog
		public DialogResult CustomShowDialog(string sFilePath)
		{
			sLoadedFile = sFilePath;
			AutomaticDetection(sFilePath);
			if(ShowDialog() == DialogResult.OK)
			{
				var imgCFG = new ImageManager.ConversionParameters(sFilePath);
				var folderCFG = new FolderProcessingParams();

				if(CheckBox1.Checked)
				{
					imgCFG.MipmapSetting = ImageManager.MipmapSetting.Generate;
					folderCFG.GenerateMipmaps = true;
				}
				else
				{
					imgCFG.MipmapSetting = ImageManager.MipmapSetting.DontGenerate;
					folderCFG.GenerateMipmaps = false;
				}

				if(CheckBox2.Checked)
				{
					imgCFG.NormalMapConversion = ImageManager.NormalMapConversion.ForceNormal;
					folderCFG.NormalsManagement = 1;
				}
				else
				{
					imgCFG.NormalMapConversion = ImageManager.NormalMapConversion.ForceNotNormal;
					folderCFG.NormalsManagement = 2;
				}
				switch((Formats)ComboBox1.SelectedIndex)
				{
					case Formats.DXT1:
						imgCFG.OutputFormat = ImageManager.OutputFormat.ForceDXT1;
						folderCFG.Compressed = true;
						break;
					case Formats.DXT5:
						imgCFG.OutputFormat = ImageManager.OutputFormat.ForceDXT5;
						folderCFG.Compressed = true;
						break;
					case Formats.R8G8B8:
						imgCFG.OutputFormat = ImageManager.OutputFormat.ForceRgb8;
						folderCFG.Compressed = false;
						break;
					case Formats.A8R8G8B8:
						imgCFG.OutputFormat = ImageManager.OutputFormat.ForceArgb8;
						folderCFG.Compressed = false;
						break;
				}
				imgCFG.ResizeSetting = ImageManager.ResizeSetting.AllowResize;

				switch(ComboBox2.SelectedIndex)
				{
					case 0:
						folderCFG.ResizeRatio = 1;
						break;
					case 1:
						folderCFG.ResizeRatio = 0.75;
						break;
					case 2:
						folderCFG.ResizeRatio = 0.5;
						break;
					case 3:
						folderCFG.ResizeRatio = 0.25;
						break;
					default:
						folderCFG.ResizeRatio = 1;
						break;
				}
				folderCFG.DeleteFilesOnSuccess = CheckBox3.Checked;
				folderCFG.BackupFile = false;

				if(imgCFG.FileType == ImageManager.FileType.MBM)
					ImageManager.ConvertMbmtoDDS(imgCFG, folderCFG);
				else
					ImageManager.ConvertFileToDDS(imgCFG, folderCFG);

				return DialogResult.OK;
			}

			return DialogResult.Cancel;
		}

		//Button/Detect, reset all controls according to automatic detection.
		private void Button1_Click(Object sender, EventArgs e)
		{
			AutomaticDetection(sLoadedFile);
		}

		//Function to reset automatic file parameters detection, and controls
		private void AutomaticDetection(string sFilePath)
		{
			autoParameters = new ImageManager.AutoParameters(sFilePath);
			//Input
			Label1.Text = "File name : " + Path.GetFileName(sFilePath);
			Label2.Text = "Resolution : " + autoParameters.Resolution.Width + "x" + autoParameters.Resolution.Height;
			Label3.Text = "Format : " + autoParameters.Format;
			Label4.Text = "NormalMap : " + autoParameters.NormalMap;
			//Output
			switch(autoParameters.Format)
			{
				case "32BPP (A8R8G8B8)":
					ComboBox1.SelectedIndex = (int) Formats.DXT5;
					break;
				case "24BPP (R8G8B8)":
					if(autoParameters.NormalMap)
						ComboBox1.SelectedIndex = (int) Formats.DXT5;
					else
						ComboBox1.SelectedIndex = (int) Formats.DXT1;
					break;
				case "A8R8G8B8":
					ComboBox1.SelectedIndex = (int) Formats.DXT5;
					break;
				case "R8G8B8":
					if(autoParameters.NormalMap)
						ComboBox1.SelectedIndex = (int) Formats.DXT5;
					else
						ComboBox1.SelectedIndex = (int) Formats.DXT1;
					break;
				case "X8R8G8B8":
					if(autoParameters.NormalMap)
						ComboBox1.SelectedIndex = (int) Formats.DXT5;
					else
						ComboBox1.SelectedIndex = (int) Formats.DXT1;
					break;
				case "P8":
					ComboBox1.SelectedIndex = (int) Formats.DXT1;
					break;
				default:
					ComboBox1.SelectedIndex = (int) Formats.A8R8G8B8;

					break;
			}
			CheckBox1.Checked = true;
			CheckBox2.Checked = autoParameters.NormalMap;
			CheckBox3.Checked = false;
			ComboBox2.SelectedIndex = 0;
			Label6.Text = "Output resolution : " + autoParameters.Resolution.Width + "x" + autoParameters.Resolution.Height;
		}

		//window loading
		private void dlg_SingleFile_Load(Object sender, EventArgs e)
		{
			AutomaticDetection(sLoadedFile);
		}

		//Combobox/resolution
		private void ComboBox2_SelectedIndexChanged(Object sender, EventArgs e)
		{
			double dRatio;

			switch(ComboBox2.SelectedIndex)
			{
				case 0:
					dRatio = 1;
					break;
				case 1:
					dRatio = 0.75;
					break;
				case 2:
					dRatio = 0.5;
					break;
				case 3:
					dRatio = 0.25;
					break;
				default:
					dRatio = 1;
					break;
			}
			Label6.Text = "Output resolution : " + Convert.ToInt32(autoParameters.Resolution.Width * dRatio) + "x" + Convert.ToInt32(autoParameters.Resolution.Height * dRatio);
		}
	}
}