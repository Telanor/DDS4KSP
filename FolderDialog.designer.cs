using System.Windows.Forms;

namespace DDS4KSPcs
{
	partial class FolderDialog : System.Windows.Forms.Form
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
            this.components = new System.ComponentModel.Container();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OK_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.CB_misc_IgnoreExceptions = new System.Windows.Forms.CheckBox();
            this.LinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Label1 = new System.Windows.Forms.Label();
            this.NUD_misc_MinWidth = new System.Windows.Forms.NumericUpDown();
            this.NUD_misc_MinHeight = new System.Windows.Forms.NumericUpDown();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.NUD_resize_MinWidth = new System.Windows.Forms.NumericUpDown();
            this.NUD_resize_MinHeight = new System.Windows.Forms.NumericUpDown();
            this.CB_resize_MinResolution = new System.Windows.Forms.CheckBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.CB_resize_Ratio = new System.Windows.Forms.ComboBox();
            this.GB_format = new System.Windows.Forms.GroupBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.CB_format_incPNG = new System.Windows.Forms.CheckBox();
            this.CB_format_incTGA = new System.Windows.Forms.CheckBox();
            this.CB_format_incMBM = new System.Windows.Forms.CheckBox();
            this.RB_format_uncompressed = new System.Windows.Forms.RadioButton();
            this.RB_format_compressed = new System.Windows.Forms.RadioButton();
            this.GB_resize = new System.Windows.Forms.GroupBox();
            this.GB_misc = new System.Windows.Forms.GroupBox();
            this.RB_misc_KeepBackups = new System.Windows.Forms.RadioButton();
            this.RB_misc_DeleteFiles = new System.Windows.Forms.RadioButton();
            this.Button1 = new System.Windows.Forms.Button();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.GB_mipmap = new System.Windows.Forms.GroupBox();
            this.CB_mipmap_Generate = new System.Windows.Forms.CheckBox();
            this.GB_normal = new System.Windows.Forms.GroupBox();
            this.CB_normal_ConvSelect = new System.Windows.Forms.ComboBox();
            this.CB_format_FLIPImages = new System.Windows.Forms.CheckBox();
            this.TableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_misc_MinWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_misc_MinHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_resize_MinWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_resize_MinHeight)).BeginInit();
            this.GB_format.SuspendLayout();
            this.GB_resize.SuspendLayout();
            this.GB_misc.SuspendLayout();
            this.GB_mipmap.SuspendLayout();
            this.GB_normal.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(5, 559);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(146, 29);
            this.TableLayoutPanel1.TabIndex = 0;
            // 
            // OK_Button
            // 
            this.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.OK_Button.Location = new System.Drawing.Point(3, 3);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(67, 23);
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "Convert";
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Cancel_Button.Location = new System.Drawing.Point(76, 3);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(67, 23);
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // CB_misc_IgnoreExceptions
            // 
            this.CB_misc_IgnoreExceptions.AutoSize = true;
            this.CB_misc_IgnoreExceptions.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CB_misc_IgnoreExceptions.Location = new System.Drawing.Point(6, 104);
            this.CB_misc_IgnoreExceptions.Name = "CB_misc_IgnoreExceptions";
            this.CB_misc_IgnoreExceptions.Size = new System.Drawing.Size(157, 18);
            this.CB_misc_IgnoreExceptions.TabIndex = 1;
            this.CB_misc_IgnoreExceptions.Text = "Ignore ModsExceptions.txt";
            this.CB_misc_IgnoreExceptions.UseVisualStyleBackColor = true;
            // 
            // LinkLabel1
            // 
            this.LinkLabel1.AutoSize = true;
            this.LinkLabel1.Location = new System.Drawing.Point(6, 124);
            this.LinkLabel1.Name = "LinkLabel1";
            this.LinkLabel1.Size = new System.Drawing.Size(128, 13);
            this.LinkLabel1.TabIndex = 2;
            this.LinkLabel1.TabStop = true;
            this.LinkLabel1.Text = "Open ModsExceptions.txt";
            this.LinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(6, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(138, 13);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Minimal res for conversion : ";
            // 
            // NUD_misc_MinWidth
            // 
            this.NUD_misc_MinWidth.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NUD_misc_MinWidth.Location = new System.Drawing.Point(11, 32);
            this.NUD_misc_MinWidth.Maximum = new decimal(new int[] {
            8192,
            0,
            0,
            0});
            this.NUD_misc_MinWidth.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.NUD_misc_MinWidth.Name = "NUD_misc_MinWidth";
            this.NUD_misc_MinWidth.Size = new System.Drawing.Size(80, 20);
            this.NUD_misc_MinWidth.TabIndex = 4;
            this.NUD_misc_MinWidth.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // NUD_misc_MinHeight
            // 
            this.NUD_misc_MinHeight.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NUD_misc_MinHeight.Location = new System.Drawing.Point(112, 32);
            this.NUD_misc_MinHeight.Maximum = new decimal(new int[] {
            8192,
            0,
            0,
            0});
            this.NUD_misc_MinHeight.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.NUD_misc_MinHeight.Name = "NUD_misc_MinHeight";
            this.NUD_misc_MinHeight.Size = new System.Drawing.Size(80, 20);
            this.NUD_misc_MinHeight.TabIndex = 5;
            this.NUD_misc_MinHeight.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(94, 34);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(12, 13);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "x";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(94, 71);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(12, 13);
            this.Label3.TabIndex = 10;
            this.Label3.Text = "x";
            // 
            // NUD_resize_MinWidth
            // 
            this.NUD_resize_MinWidth.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NUD_resize_MinWidth.Location = new System.Drawing.Point(11, 69);
            this.NUD_resize_MinWidth.Maximum = new decimal(new int[] {
            8192,
            0,
            0,
            0});
            this.NUD_resize_MinWidth.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.NUD_resize_MinWidth.Name = "NUD_resize_MinWidth";
            this.NUD_resize_MinWidth.Size = new System.Drawing.Size(80, 20);
            this.NUD_resize_MinWidth.TabIndex = 9;
            this.NUD_resize_MinWidth.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // NUD_resize_MinHeight
            // 
            this.NUD_resize_MinHeight.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NUD_resize_MinHeight.Location = new System.Drawing.Point(112, 69);
            this.NUD_resize_MinHeight.Maximum = new decimal(new int[] {
            8192,
            0,
            0,
            0});
            this.NUD_resize_MinHeight.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.NUD_resize_MinHeight.Name = "NUD_resize_MinHeight";
            this.NUD_resize_MinHeight.Size = new System.Drawing.Size(80, 20);
            this.NUD_resize_MinHeight.TabIndex = 8;
            this.NUD_resize_MinHeight.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // CB_resize_MinResolution
            // 
            this.CB_resize_MinResolution.AutoSize = true;
            this.CB_resize_MinResolution.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CB_resize_MinResolution.Location = new System.Drawing.Point(9, 46);
            this.CB_resize_MinResolution.Name = "CB_resize_MinResolution";
            this.CB_resize_MinResolution.Size = new System.Drawing.Size(169, 18);
            this.CB_resize_MinResolution.TabIndex = 11;
            this.CB_resize_MinResolution.Text = "Minimal resolution for resize : ";
            this.CB_resize_MinResolution.UseVisualStyleBackColor = true;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(6, 22);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(71, 13);
            this.Label4.TabIndex = 12;
            this.Label4.Text = "Resize ratio : ";
            // 
            // CB_resize_Ratio
            // 
            this.CB_resize_Ratio.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CB_resize_Ratio.FormattingEnabled = true;
            this.CB_resize_Ratio.Items.AddRange(new object[] {
            "x1",
            "x3/4",
            "x1/2",
            "x1/4"});
            this.CB_resize_Ratio.Location = new System.Drawing.Point(83, 19);
            this.CB_resize_Ratio.Name = "CB_resize_Ratio";
            this.CB_resize_Ratio.Size = new System.Drawing.Size(111, 21);
            this.CB_resize_Ratio.TabIndex = 13;
            // 
            // GB_format
            // 
            this.GB_format.Controls.Add(this.CB_format_FLIPImages);
            this.GB_format.Controls.Add(this.Label5);
            this.GB_format.Controls.Add(this.CB_format_incPNG);
            this.GB_format.Controls.Add(this.CB_format_incTGA);
            this.GB_format.Controls.Add(this.CB_format_incMBM);
            this.GB_format.Controls.Add(this.RB_format_uncompressed);
            this.GB_format.Controls.Add(this.RB_format_compressed);
            this.GB_format.Location = new System.Drawing.Point(15, 12);
            this.GB_format.Name = "GB_format";
            this.GB_format.Size = new System.Drawing.Size(200, 133);
            this.GB_format.TabIndex = 14;
            this.GB_format.TabStop = false;
            this.GB_format.Text = "Format";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(8, 61);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(64, 13);
            this.Label5.TabIndex = 5;
            this.Label5.Text = "Extensions :";
            // 
            // CB_format_incPNG
            // 
            this.CB_format_incPNG.AutoSize = true;
            this.CB_format_incPNG.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CB_format_incPNG.Location = new System.Drawing.Point(127, 77);
            this.CB_format_incPNG.Name = "CB_format_incPNG";
            this.CB_format_incPNG.Size = new System.Drawing.Size(57, 18);
            this.CB_format_incPNG.TabIndex = 4;
            this.CB_format_incPNG.Text = "*.png";
            this.CB_format_incPNG.UseVisualStyleBackColor = true;
            // 
            // CB_format_incTGA
            // 
            this.CB_format_incTGA.AutoSize = true;
            this.CB_format_incTGA.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CB_format_incTGA.Location = new System.Drawing.Point(66, 77);
            this.CB_format_incTGA.Name = "CB_format_incTGA";
            this.CB_format_incTGA.Size = new System.Drawing.Size(54, 18);
            this.CB_format_incTGA.TabIndex = 3;
            this.CB_format_incTGA.Text = "*.tga";
            this.CB_format_incTGA.UseVisualStyleBackColor = true;
            // 
            // CB_format_incMBM
            // 
            this.CB_format_incMBM.AutoSize = true;
            this.CB_format_incMBM.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CB_format_incMBM.Location = new System.Drawing.Point(8, 77);
            this.CB_format_incMBM.Name = "CB_format_incMBM";
            this.CB_format_incMBM.Size = new System.Drawing.Size(61, 18);
            this.CB_format_incMBM.TabIndex = 2;
            this.CB_format_incMBM.Text = "*.mbm";
            this.CB_format_incMBM.UseVisualStyleBackColor = true;
            // 
            // RB_format_uncompressed
            // 
            this.RB_format_uncompressed.AutoSize = true;
            this.RB_format_uncompressed.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RB_format_uncompressed.Location = new System.Drawing.Point(6, 41);
            this.RB_format_uncompressed.Name = "RB_format_uncompressed";
            this.RB_format_uncompressed.Size = new System.Drawing.Size(195, 18);
            this.RB_format_uncompressed.TabIndex = 1;
            this.RB_format_uncompressed.TabStop = true;
            this.RB_format_uncompressed.Text = "Auto, uncompressed (RGB/RGBA)";
            this.RB_format_uncompressed.UseVisualStyleBackColor = true;
            // 
            // RB_format_compressed
            // 
            this.RB_format_compressed.AutoSize = true;
            this.RB_format_compressed.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RB_format_compressed.Location = new System.Drawing.Point(6, 19);
            this.RB_format_compressed.Name = "RB_format_compressed";
            this.RB_format_compressed.Size = new System.Drawing.Size(186, 18);
            this.RB_format_compressed.TabIndex = 0;
            this.RB_format_compressed.TabStop = true;
            this.RB_format_compressed.Text = "Auto, compressed (DXT1/DXT5)";
            this.RB_format_compressed.UseVisualStyleBackColor = true;
            // 
            // GB_resize
            // 
            this.GB_resize.Controls.Add(this.Label4);
            this.GB_resize.Controls.Add(this.CB_resize_Ratio);
            this.GB_resize.Controls.Add(this.NUD_resize_MinWidth);
            this.GB_resize.Controls.Add(this.Label3);
            this.GB_resize.Controls.Add(this.CB_resize_MinResolution);
            this.GB_resize.Controls.Add(this.NUD_resize_MinHeight);
            this.GB_resize.Location = new System.Drawing.Point(15, 266);
            this.GB_resize.Name = "GB_resize";
            this.GB_resize.Size = new System.Drawing.Size(200, 100);
            this.GB_resize.TabIndex = 15;
            this.GB_resize.TabStop = false;
            this.GB_resize.Text = "Resize options";
            // 
            // GB_misc
            // 
            this.GB_misc.Controls.Add(this.RB_misc_KeepBackups);
            this.GB_misc.Controls.Add(this.RB_misc_DeleteFiles);
            this.GB_misc.Controls.Add(this.CB_misc_IgnoreExceptions);
            this.GB_misc.Controls.Add(this.Label1);
            this.GB_misc.Controls.Add(this.NUD_misc_MinWidth);
            this.GB_misc.Controls.Add(this.LinkLabel1);
            this.GB_misc.Controls.Add(this.Label2);
            this.GB_misc.Controls.Add(this.NUD_misc_MinHeight);
            this.GB_misc.Location = new System.Drawing.Point(15, 372);
            this.GB_misc.Name = "GB_misc";
            this.GB_misc.Size = new System.Drawing.Size(200, 145);
            this.GB_misc.TabIndex = 16;
            this.GB_misc.TabStop = false;
            this.GB_misc.Text = "Misc.";
            // 
            // RB_misc_KeepBackups
            // 
            this.RB_misc_KeepBackups.AutoSize = true;
            this.RB_misc_KeepBackups.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RB_misc_KeepBackups.Location = new System.Drawing.Point(6, 58);
            this.RB_misc_KeepBackups.Name = "RB_misc_KeepBackups";
            this.RB_misc_KeepBackups.Size = new System.Drawing.Size(120, 18);
            this.RB_misc_KeepBackups.TabIndex = 9;
            this.RB_misc_KeepBackups.TabStop = true;
            this.RB_misc_KeepBackups.Text = "Keep a backup file";
            this.RB_misc_KeepBackups.UseVisualStyleBackColor = true;
            // 
            // RB_misc_DeleteFiles
            // 
            this.RB_misc_DeleteFiles.AutoSize = true;
            this.RB_misc_DeleteFiles.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RB_misc_DeleteFiles.Location = new System.Drawing.Point(6, 81);
            this.RB_misc_DeleteFiles.Name = "RB_misc_DeleteFiles";
            this.RB_misc_DeleteFiles.Size = new System.Drawing.Size(198, 18);
            this.RB_misc_DeleteFiles.TabIndex = 8;
            this.RB_misc_DeleteFiles.TabStop = true;
            this.RB_misc_DeleteFiles.Text = "Delete original files after conversion";
            this.RB_misc_DeleteFiles.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Button1.Location = new System.Drawing.Point(157, 523);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(61, 23);
            this.Button1.TabIndex = 17;
            this.Button1.Text = "Reset";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // GB_mipmap
            // 
            this.GB_mipmap.Controls.Add(this.CB_mipmap_Generate);
            this.GB_mipmap.Location = new System.Drawing.Point(15, 209);
            this.GB_mipmap.Name = "GB_mipmap";
            this.GB_mipmap.Size = new System.Drawing.Size(200, 51);
            this.GB_mipmap.TabIndex = 18;
            this.GB_mipmap.TabStop = false;
            this.GB_mipmap.Text = "Mipmaps";
            // 
            // CB_mipmap_Generate
            // 
            this.CB_mipmap_Generate.AutoSize = true;
            this.CB_mipmap_Generate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CB_mipmap_Generate.Location = new System.Drawing.Point(8, 19);
            this.CB_mipmap_Generate.Name = "CB_mipmap_Generate";
            this.CB_mipmap_Generate.Size = new System.Drawing.Size(121, 18);
            this.CB_mipmap_Generate.TabIndex = 0;
            this.CB_mipmap_Generate.Text = "Generate Mipmaps";
            this.CB_mipmap_Generate.UseVisualStyleBackColor = true;
            // 
            // GB_normal
            // 
            this.GB_normal.Controls.Add(this.CB_normal_ConvSelect);
            this.GB_normal.Location = new System.Drawing.Point(15, 151);
            this.GB_normal.Name = "GB_normal";
            this.GB_normal.Size = new System.Drawing.Size(200, 52);
            this.GB_normal.TabIndex = 19;
            this.GB_normal.TabStop = false;
            this.GB_normal.Text = "Normalmaps";
            // 
            // CB_normal_ConvSelect
            // 
            this.CB_normal_ConvSelect.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CB_normal_ConvSelect.FormattingEnabled = true;
            this.CB_normal_ConvSelect.Items.AddRange(new object[] {
            "Automatic",
            "Force normal (swizzle + flag)",
            "Force not normal"});
            this.CB_normal_ConvSelect.Location = new System.Drawing.Point(10, 19);
            this.CB_normal_ConvSelect.Name = "CB_normal_ConvSelect";
            this.CB_normal_ConvSelect.Size = new System.Drawing.Size(181, 21);
            this.CB_normal_ConvSelect.TabIndex = 0;
            // 
            // CB_format_FLIPImages
            // 
            this.CB_format_FLIPImages.AutoSize = true;
            this.CB_format_FLIPImages.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CB_format_FLIPImages.Location = new System.Drawing.Point(9, 108);
            this.CB_format_FLIPImages.Name = "CB_format_FLIPImages";
            this.CB_format_FLIPImages.Size = new System.Drawing.Size(182, 18);
            this.CB_format_FLIPImages.TabIndex = 6;
            this.CB_format_FLIPImages.Text = "Flip png/tag? (no for KSP 1.0+!)";
            this.CB_format_FLIPImages.UseVisualStyleBackColor = true;
            // 
            // FolderDialog
            // 
            this.AcceptButton = this.OK_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_Button;
            this.ClientSize = new System.Drawing.Size(227, 600);
            this.Controls.Add(this.GB_normal);
            this.Controls.Add(this.GB_mipmap);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.GB_misc);
            this.Controls.Add(this.GB_resize);
            this.Controls.Add(this.GB_format);
            this.Controls.Add(this.TableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FolderDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Folder conversion options";
            this.Load += new System.EventHandler(this.dlg_Folder_Load);
            this.TableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_misc_MinWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_misc_MinHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_resize_MinWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_resize_MinHeight)).EndInit();
            this.GB_format.ResumeLayout(false);
            this.GB_format.PerformLayout();
            this.GB_resize.ResumeLayout(false);
            this.GB_resize.PerformLayout();
            this.GB_misc.ResumeLayout(false);
            this.GB_misc.PerformLayout();
            this.GB_mipmap.ResumeLayout(false);
            this.GB_mipmap.PerformLayout();
            this.GB_normal.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
		internal System.Windows.Forms.Button OK_Button;
		internal System.Windows.Forms.Button Cancel_Button;
		internal System.Windows.Forms.CheckBox CB_misc_IgnoreExceptions;
		internal System.Windows.Forms.LinkLabel LinkLabel1;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.NumericUpDown NUD_misc_MinWidth;
		internal System.Windows.Forms.NumericUpDown NUD_misc_MinHeight;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.NumericUpDown NUD_resize_MinWidth;
		internal System.Windows.Forms.NumericUpDown NUD_resize_MinHeight;
		internal System.Windows.Forms.CheckBox CB_resize_MinResolution;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.ComboBox CB_resize_Ratio;
		internal System.Windows.Forms.GroupBox GB_format;
		internal System.Windows.Forms.RadioButton RB_format_uncompressed;
		internal System.Windows.Forms.RadioButton RB_format_compressed;
		internal System.Windows.Forms.GroupBox GB_resize;
		internal System.Windows.Forms.GroupBox GB_misc;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.CheckBox CB_format_incPNG;
		internal System.Windows.Forms.CheckBox CB_format_incTGA;
		internal System.Windows.Forms.CheckBox CB_format_incMBM;
		internal System.Windows.Forms.ToolTip ToolTip1;
		internal System.Windows.Forms.GroupBox GB_mipmap;
		internal System.Windows.Forms.GroupBox GB_normal;
		internal System.Windows.Forms.ComboBox CB_normal_ConvSelect;
		internal System.Windows.Forms.CheckBox CB_mipmap_Generate;
		internal System.Windows.Forms.RadioButton RB_misc_KeepBackups;

		internal System.Windows.Forms.RadioButton RB_misc_DeleteFiles;
        internal System.Windows.Forms.CheckBox CB_format_FLIPImages;
	}
}

//=======================================================
//Service provided by Telerik (www.telerik.com)
//Conversion powered by NRefactory.
//Twitter: @telerik
//Facebook: facebook.com/telerik
//=======================================================
