using System;
using System.IO;
using System.Windows.Forms;
using Ookii.Dialogs;

namespace DDS4KSPcs
{
	public partial class MainForm
	{
		public static MainForm Instance { get; private set; }

		//keeping tracks of loading state
		private enum LoadingState
		{
			None = 0,
			File = 1,
			Folder = 2
		}

		private LoadingState currentLoadingState;
		private string loadedFile = "";
		private string loadedFolder = "";

		private readonly string logFile = Directory.GetCurrentDirectory() + "\\log.txt";

		public MainForm()
		{
			Instance = this;
			InitializeComponent();
		}

		//Form loading
		private void MainForm_Load(Object sender, EventArgs e)
		{
			//create an emty log file if none exist
			if(File.Exists(logFile))
				File.Delete(logFile);
			//startup function (refresh controls)
			StartupCheckControls();
			//initialize IMG manager        
			ImageManager.Init();
		}

		//check controls at startup
		private void StartupCheckControls()
		{
			//set label to corecct positions
			//TB_Log.Top = lbl_infos_1.Bottom + 10;
			lbl_PBInfos.Top = TB_Log.Bottom + 10;
			PB_main.Top = lbl_PBInfos.Bottom + 10;
			GB_frm_main.Height = PB_main.Bottom + 10;
			Height = GB_frm_main.Bottom + MS_frm_main.Bottom + 10;
			TB_Log.WordWrap = false;
			//set the loading state to None
			currentLoadingState = LoadingState.None;
			//enable/disable controls
			CheckToolStripItems();
		}

		//refresh ToolStripMenu items
		private void CheckToolStripItems()
		{
			//No file or folder loaded
			if(currentLoadingState == LoadingState.None)
			{
				OpenToolStripMenuItem.Enabled = true;
				ExportToDDSToolStripMenuItem.Enabled = false;
				OpenToolStripMenuItem1.Enabled = true;
				ExportAllToDDSToolStripMenuItem.Enabled = false;
				RevertFromBackupToolStripMenuItem.Enabled = false;
				lbl_infos_1.Visible = false;
				GB_frm_main.Text = "Infos : Nothing's loaded";
				//File loaded
			}
			else if(currentLoadingState == LoadingState.File)
			{
				OpenToolStripMenuItem.Enabled = true;
				ExportToDDSToolStripMenuItem.Enabled = true;
				OpenToolStripMenuItem1.Enabled = true;
				ExportAllToDDSToolStripMenuItem.Enabled = false;
				RevertFromBackupToolStripMenuItem.Enabled = false;
				lbl_infos_1.Visible = true;
				GB_frm_main.Text = "Infos : File loaded";
				//Folder loaded
			}
			else if(currentLoadingState == LoadingState.Folder)
			{
				OpenToolStripMenuItem.Enabled = true;
				ExportToDDSToolStripMenuItem.Enabled = false;
				OpenToolStripMenuItem1.Enabled = true;
				ExportAllToDDSToolStripMenuItem.Enabled = true;
				RevertFromBackupToolStripMenuItem.Enabled = true;
				GB_frm_main.Text = "Infos : Folder loaded";
				lbl_infos_1.Visible = true;
			}
		}

		//Infos groupbox content refresh
		private void CheckGroupBoxItems()
		{
			if(currentLoadingState == LoadingState.None)
				lbl_infos_1.Text = "";
			else if(currentLoadingState == LoadingState.File)
				lbl_infos_1.Text = "File : " + Path.GetFileName(loadedFile);
			else if(currentLoadingState == LoadingState.Folder)
			{
				//lbl_infos_1.Text = "Folder : " & fp_LoadedFolder.Split("\").Last
				//handled in FolderLoader.vb, "refreshInfos" function
			}
		}

		//File/Open
		private void OpenToolStripMenuItem_Click(Object sender, EventArgs e)
		{
			//var folderCFG = new FolderProcessingParams(); //Not sure what this is for, doesn't do anything

			var ofd = new OpenFileDialog {Title = "Open file", Filter = "Common KSP's image format | *.mbm; *.tga; *.png"};

			if(ofd.ShowDialog() == DialogResult.OK)
			{
				//switch the loading state to "file"
				currentLoadingState = LoadingState.File;
				//refresh the "path" container
				loadedFile = ofd.FileName;
				//refresh controls
				CheckToolStripItems();
				CheckGroupBoxItems();
				Log_WriteLine("LOG : Opening file : " + loadedFile);
			}
		}

		//File/export
		private void ExportToDDSToolStripMenuItem_Click(Object sender, EventArgs e)
		{
			//Not sure what these are for, they dont do anything
			/*
			var bNormal = false;
			var bMipMap = true;
			var bUncompressed = false;
			var bDeleteOnSuccess = true;
			double dResizeRatio = 1;
			*/
			var dlgSingleFile = new SingleFileDialog();
			if(dlgSingleFile.CustomShowDialog(loadedFile) == DialogResult.OK)
			{
				//conversion is launched from dialog window
			}
		}

		//File/Quit
		private void QuitToolStripMenuItem_Click(Object sender, EventArgs e)
		{
			Close();
		}

		//Folder/Open
		private void OpenToolStripMenuItem1_Click(Object sender, EventArgs e)
		{
			var openFileDialog = new VistaFolderBrowserDialog();
			var bLaunch = false;

			openFileDialog.Description = "Select a folder to convert";

			if(openFileDialog.ShowDialog() == DialogResult.OK)
			{
				//check if we are inside a GameData folder
				if(FolderLoader.ValidDirectory(openFileDialog.SelectedPath))
					bLaunch = true;
				else
				{
					if(MessageBox.Show("This folder does not seems to be inside a GameData folder. Proceed anyway?", "Invalid Directory?", MessageBoxButtons.YesNo) == DialogResult.Yes)
						bLaunch = true;
				}
			}
			if(bLaunch)
			{
				//switch the loading state to "folder"
				currentLoadingState = LoadingState.Folder;
				//refresh the "folder" container
				loadedFolder = openFileDialog.SelectedPath;
				//show informations about folder
				FolderLoader.RefreshInfo(openFileDialog.SelectedPath, true, true);
			}
			CheckToolStripItems();
			CheckGroupBoxItems();
		}

		//Folder/export all
		private void ExportAllToDDSToolStripMenuItem_Click(Object sender, EventArgs e)
		{
			var folderCFG = new FolderProcessingParams();
			var dlgFolder = new FolderDialog();

			if(dlgFolder.CustomShowDialog(loadedFolder, folderCFG) == DialogResult.OK)
			{
				PB_main.Visible = true;
				lbl_PBInfos.Visible = true;
				lbl_PBInfos.Text = "";
				PB_main.Value = 0;
				FolderLoader.ProcessFileLists(loadedFolder, folderCFG);
				PB_main.Visible = false;
				lbl_PBInfos.Visible = false;
			}
		}

		//Folder/revert from backup
		private void RevertFromBackupToolStripMenuItem_Click(Object sender, EventArgs e)
		{
			if(MessageBox.Show("This option will revert all converted DDS to their original format in the selected folder, if a backup file is available. Continue?", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				PB_main.Visible = true;
				lbl_PBInfos.Visible = true;
				lbl_PBInfos.Text = "";
				PB_main.Value = 0;
				FolderLoader.BackupFiles(loadedFolder);
				PB_main.Visible = false;
				lbl_PBInfos.Visible = false;
			}
		}

		//function to write something in the log. No particular reason to have it here, I just don't really know where to put it...
		public static void Log_WriteLine(string sLine)
		{
			if(Instance.TB_Log.InvokeRequired)
				Instance.TB_Log.Invoke((Action<string>)Log_WriteLine, sLine);
			else
			{
				Instance.TB_Log.AppendText(Environment.NewLine + sLine);

				using(var writer = File.AppendText(Instance.logFile))
					writer.WriteLine(sLine);
			}
		}

		public static void ReportProgress(int progressValue, string progressText)
		{
			if(Instance.PB_main.InvokeRequired)
				Instance.PB_main.Invoke((Action<int, string>)ReportProgress, progressValue, progressText);
			else
			{
				Instance.PB_main.Value = progressValue;
				Instance.lbl_PBInfos.Text = progressText;
			}
		}

		private string originalTitle;

		public static void SetTitleAppend(string title)
		{
			if(Instance.InvokeRequired)
				Instance.Invoke((Action<string>) SetTitleAppend, title);
			else
			{
				if(Instance.originalTitle == null)
					Instance.originalTitle = Instance.Text;

				Instance.Text = Instance.originalTitle + title;
			}
		}

		public static void DisplaySelectedFolder(string folder)
		{
			if(Instance.lbl_infos_1.InvokeRequired)
				Instance.lbl_infos_1.Invoke((Action<string>) DisplaySelectedFolder, folder);
			else
				Instance.lbl_infos_1.Text = folder;
		}
	}
}