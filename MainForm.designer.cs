namespace DDS4KSPcs
{
	partial class MainForm : System.Windows.Forms.Form
	{

		//Form remplace la méthode Dispose pour nettoyer la liste des composants.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			try {
				if (disposing && components != null) {
					components.Dispose();
				}
			} finally {
				base.Dispose(disposing);
			}
		}

		//Requise par le Concepteur Windows Form

		private System.ComponentModel.IContainer components;
		//REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
		//Elle peut être modifiée à l'aide du Concepteur Windows Form.  
		//Ne la modifiez pas à l'aide de l'éditeur de code.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.MS_frm_main = new System.Windows.Forms.MenuStrip();
			this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ExportToDDSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.QuitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.FolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OpenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.ExportAllToDDSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RevertFromBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.GB_frm_main = new System.Windows.Forms.GroupBox();
			this.TB_Log = new System.Windows.Forms.TextBox();
			this.lbl_PBInfos = new System.Windows.Forms.Label();
			this.PB_main = new System.Windows.Forms.ProgressBar();
			this.lbl_infos_1 = new System.Windows.Forms.Label();
			this.MS_frm_main.SuspendLayout();
			this.GB_frm_main.SuspendLayout();
			this.SuspendLayout();
			// 
			// MS_frm_main
			// 
			this.MS_frm_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.FolderToolStripMenuItem});
			this.MS_frm_main.Location = new System.Drawing.Point(0, 0);
			this.MS_frm_main.Name = "MS_frm_main";
			this.MS_frm_main.Size = new System.Drawing.Size(449, 24);
			this.MS_frm_main.TabIndex = 0;
			this.MS_frm_main.Text = "MenuStrip1";
			// 
			// FileToolStripMenuItem
			// 
			this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.ExportToDDSToolStripMenuItem,
            this.ToolStripSeparator1,
            this.QuitToolStripMenuItem});
			this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
			this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.FileToolStripMenuItem.Text = "File";
			// 
			// OpenToolStripMenuItem
			// 
			this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
			this.OpenToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.OpenToolStripMenuItem.Text = "Open";
			this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
			// 
			// ExportToDDSToolStripMenuItem
			// 
			this.ExportToDDSToolStripMenuItem.Name = "ExportToDDSToolStripMenuItem";
			this.ExportToDDSToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.ExportToDDSToolStripMenuItem.Text = "Export to DDS";
			this.ExportToDDSToolStripMenuItem.Click += new System.EventHandler(this.ExportToDDSToolStripMenuItem_Click);
			// 
			// ToolStripSeparator1
			// 
			this.ToolStripSeparator1.Name = "ToolStripSeparator1";
			this.ToolStripSeparator1.Size = new System.Drawing.Size(143, 6);
			// 
			// QuitToolStripMenuItem
			// 
			this.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem";
			this.QuitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.QuitToolStripMenuItem.Text = "Quit";
			this.QuitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
			// 
			// FolderToolStripMenuItem
			// 
			this.FolderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem1,
            this.ExportAllToDDSToolStripMenuItem,
            this.RevertFromBackupToolStripMenuItem});
			this.FolderToolStripMenuItem.Name = "FolderToolStripMenuItem";
			this.FolderToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.FolderToolStripMenuItem.Text = "Folder";
			// 
			// OpenToolStripMenuItem1
			// 
			this.OpenToolStripMenuItem1.Name = "OpenToolStripMenuItem1";
			this.OpenToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
			this.OpenToolStripMenuItem1.Text = "Open";
			this.OpenToolStripMenuItem1.Click += new System.EventHandler(this.OpenToolStripMenuItem1_Click);
			// 
			// ExportAllToDDSToolStripMenuItem
			// 
			this.ExportAllToDDSToolStripMenuItem.Name = "ExportAllToDDSToolStripMenuItem";
			this.ExportAllToDDSToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
			this.ExportAllToDDSToolStripMenuItem.Text = "Export all to DDS";
			this.ExportAllToDDSToolStripMenuItem.Click += new System.EventHandler(this.ExportAllToDDSToolStripMenuItem_Click);
			// 
			// RevertFromBackupToolStripMenuItem
			// 
			this.RevertFromBackupToolStripMenuItem.Name = "RevertFromBackupToolStripMenuItem";
			this.RevertFromBackupToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
			this.RevertFromBackupToolStripMenuItem.Text = "Revert from backup";
			this.RevertFromBackupToolStripMenuItem.Click += new System.EventHandler(this.RevertFromBackupToolStripMenuItem_Click);
			// 
			// GB_frm_main
			// 
			this.GB_frm_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.GB_frm_main.Controls.Add(this.TB_Log);
			this.GB_frm_main.Controls.Add(this.lbl_PBInfos);
			this.GB_frm_main.Controls.Add(this.PB_main);
			this.GB_frm_main.Controls.Add(this.lbl_infos_1);
			this.GB_frm_main.Location = new System.Drawing.Point(12, 27);
			this.GB_frm_main.Name = "GB_frm_main";
			this.GB_frm_main.Size = new System.Drawing.Size(430, 234);
			this.GB_frm_main.TabIndex = 1;
			this.GB_frm_main.TabStop = false;
			this.GB_frm_main.Text = "Info : Nothing\'s loaded";
			// 
			// TB_Log
			// 
			this.TB_Log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TB_Log.Location = new System.Drawing.Point(9, 42);
			this.TB_Log.Multiline = true;
			this.TB_Log.Name = "TB_Log";
			this.TB_Log.ReadOnly = true;
			this.TB_Log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.TB_Log.Size = new System.Drawing.Size(408, 134);
			this.TB_Log.TabIndex = 6;
			// 
			// lbl_PBInfos
			// 
			this.lbl_PBInfos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbl_PBInfos.AutoSize = true;
			this.lbl_PBInfos.Location = new System.Drawing.Point(6, 189);
			this.lbl_PBInfos.Name = "lbl_PBInfos";
			this.lbl_PBInfos.Size = new System.Drawing.Size(39, 13);
			this.lbl_PBInfos.TabIndex = 5;
			this.lbl_PBInfos.Text = "Label1";
			this.lbl_PBInfos.Visible = false;
			// 
			// PB_main
			// 
			this.PB_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PB_main.Location = new System.Drawing.Point(9, 205);
			this.PB_main.Name = "PB_main";
			this.PB_main.Size = new System.Drawing.Size(408, 23);
			this.PB_main.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.PB_main.TabIndex = 4;
			this.PB_main.Visible = false;
			// 
			// lbl_infos_1
			// 
			this.lbl_infos_1.AutoSize = true;
			this.lbl_infos_1.Location = new System.Drawing.Point(6, 26);
			this.lbl_infos_1.Name = "lbl_infos_1";
			this.lbl_infos_1.Size = new System.Drawing.Size(39, 13);
			this.lbl_infos_1.TabIndex = 0;
			this.lbl_infos_1.Text = "Label1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(449, 273);
			this.Controls.Add(this.GB_frm_main);
			this.Controls.Add(this.MS_frm_main);
			this.MainMenuStrip = this.MS_frm_main;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "KSP Texture Converter";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.MS_frm_main.ResumeLayout(false);
			this.MS_frm_main.PerformLayout();
			this.GB_frm_main.ResumeLayout(false);
			this.GB_frm_main.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		internal System.Windows.Forms.MenuStrip MS_frm_main;
		internal System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ExportToDDSToolStripMenuItem;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
		internal System.Windows.Forms.ToolStripMenuItem QuitToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem FolderToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem1;
		internal System.Windows.Forms.ToolStripMenuItem ExportAllToDDSToolStripMenuItem;
		internal System.Windows.Forms.GroupBox GB_frm_main;
		internal System.Windows.Forms.Label lbl_infos_1;
		internal System.Windows.Forms.ProgressBar PB_main;
		internal System.Windows.Forms.Label lbl_PBInfos;
		internal System.Windows.Forms.TextBox TB_Log;

		internal System.Windows.Forms.ToolStripMenuItem RevertFromBackupToolStripMenuItem;
	}
}

//=======================================================
//Service provided by Telerik (www.telerik.com)
//Conversion powered by NRefactory.
//Twitter: @telerik
//Facebook: facebook.com/telerik
//=======================================================
