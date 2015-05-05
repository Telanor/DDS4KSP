using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace DDS4KSPcs
{
	public partial class FolderDialog
	{
		public FolderDialog()
		{
			InitializeComponent();
		}

		//Button/OK
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
		//Button/Reset
		private void Button1_Click(Object sender, EventArgs e)
		{
			ResetWindow();
		}
		//loading the window
		private void dlg_Folder_Load(Object sender, EventArgs e)
		{
			ResetWindow();
		}

		//a custom function to call ShowDialog(), so parameters can be updated before the window is closed
		public DialogResult CustomShowDialog(string sPath, FolderProcessingParams CFG)
		{
			if (ShowDialog() == DialogResult.OK) {
				//(assume CFG is already instantiated)
				//Format
				CFG.Compressed = RB_format_compressed.Checked;
				CFG.ProcessMBMs = CB_format_incMBM.Checked;
				CFG.ProcessTGAs = CB_format_incTGA.Checked;
				CFG.ProcessPNGs = CB_format_incPNG.Checked;
				CFG.FlipImages  = CB_format_FLIP.Checked;
				//normals
				CFG.NormalsManagement = CB_normal_ConvSelect.SelectedIndex;
				//mipmaps
				CFG.GenerateMipmaps = CB_mipmap_Generate.Checked;
				//resize
				if (CB_resize_MinResolution.Checked)
				{
					CFG.MinRes_Resize_Width = Convert.ToInt32(NUD_resize_MinWidth.Value);
					CFG.MinRes_Resize_Height = Convert.ToInt32(NUD_resize_MinHeight.Value);
				} else {
					CFG.MinRes_Resize_Width = 1;
					CFG.MinRes_Resize_Height = 1;
				}
				switch (CB_resize_Ratio.SelectedIndex) {
					case 0:
						CFG.ResizeRatio = 1;
						break;
					case 1:
						CFG.ResizeRatio = 0.75;
						break;
					case 2:
						CFG.ResizeRatio = 0.5;
						break;
					case 3:
						CFG.ResizeRatio = 0.25;
						break;
					default:
						CFG.ResizeRatio = 1;
						break;
				}
				//misc
				CFG.MinRes_Process_Width = Convert.ToInt32(NUD_misc_MinWidth.Value);
				CFG.MinRes_Process_Height = Convert.ToInt32(NUD_misc_MinHeight.Value);
				CFG.DeleteFilesOnSuccess = RB_misc_DeleteFiles.Checked;
				CFG.BackupFile = RB_misc_KeepBackups.Checked;
				CFG.IgnoreExceptions = CB_misc_IgnoreExceptions.Checked;
				return DialogResult.OK;
			} else {
				return DialogResult.Cancel;
			}
		}

		//LinkLabel to ModsExceptions.txt
		private void LinkLabel1_LinkClicked(Object sender, LinkLabelLinkClickedEventArgs e)
		{
			//if the files doesn't exist, an empty one is created...
			if (!File.Exists(FolderLoader.ModExceptionPath)) {
				var st = File.Create(FolderLoader.ModExceptionPath);
				st.Close();
			}
			//...and launched 
			Process.Start(FolderLoader.ModExceptionPath);
		}

		//resetting the controls to something accurate
		private void ResetWindow()
		{
			//create a new cfg to reset automatic parameters
			var folderCFG = new FolderProcessingParams();
			//Format
			RB_format_compressed.Checked = folderCFG.Compressed;
			CB_format_incMBM.Checked = folderCFG.ProcessMBMs;
			CB_format_incTGA.Checked = folderCFG.ProcessTGAs;
			CB_format_incPNG.Checked = folderCFG.ProcessPNGs;
			CB_format_FLIP.Checked = folderCFG.FlipImages;
			//normals
			CB_normal_ConvSelect.SelectedIndex = folderCFG.NormalsManagement;
			//mipmaps
			CB_mipmap_Generate.Checked = folderCFG.GenerateMipmaps;
			//resize
			CB_resize_Ratio.SelectedIndex = 0;
			CB_resize_MinResolution.Checked = true;
			NUD_resize_MinWidth.Value = folderCFG.MinRes_Resize_Width;
			NUD_resize_MinHeight.Value = folderCFG.MinRes_Resize_Height;
			//misc
			NUD_misc_MinWidth.Value = folderCFG.MinRes_Process_Height;
			NUD_misc_MinHeight.Value = folderCFG.MinRes_Process_Width;
			RB_misc_DeleteFiles.Checked = folderCFG.DeleteFilesOnSuccess;
			RB_misc_KeepBackups.Checked = folderCFG.BackupFile;
			CB_misc_IgnoreExceptions.Checked = folderCFG.IgnoreExceptions;
		}
	}
}
