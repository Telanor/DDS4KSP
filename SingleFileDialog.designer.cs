
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace DDS4KSPcs
{
	partial class SingleFileDialog : System.Windows.Forms.Form
	{

		//Form remplace la méthode Dispose pour nettoyer la liste des composants.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if(disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
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
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.OK_Button = new System.Windows.Forms.Button();
			this.Cancel_Button = new System.Windows.Forms.Button();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.CheckBox3 = new System.Windows.Forms.CheckBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.ComboBox2 = new System.Windows.Forms.ComboBox();
			this.CheckBox2 = new System.Windows.Forms.CheckBox();
			this.CheckBox1 = new System.Windows.Forms.CheckBox();
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			this.Button1 = new System.Windows.Forms.Button();
			this.TableLayoutPanel1.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
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
			this.TableLayoutPanel1.Location = new System.Drawing.Point(38, 264);
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
			// GroupBox1
			// 
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Location = new System.Drawing.Point(12, 12);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(200, 75);
			this.GroupBox1.TabIndex = 1;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Input";
			// 
			// Label4
			// 
			this.Label4.AutoSize = true;
			this.Label4.Location = new System.Drawing.Point(6, 55);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(72, 13);
			this.Label4.TabIndex = 3;
			this.Label4.Text = "Normal map : ";
			// 
			// Label3
			// 
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(6, 42);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(39, 13);
			this.Label3.TabIndex = 2;
			this.Label3.Text = "Format";
			// 
			// Label2
			// 
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(6, 29);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(57, 13);
			this.Label2.TabIndex = 1;
			this.Label2.Text = "Resolution";
			// 
			// Label1
			// 
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(6, 16);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(61, 13);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "File name : ";
			// 
			// GroupBox2
			// 
			this.GroupBox2.Controls.Add(this.CheckBox3);
			this.GroupBox2.Controls.Add(this.Label6);
			this.GroupBox2.Controls.Add(this.Label5);
			this.GroupBox2.Controls.Add(this.ComboBox2);
			this.GroupBox2.Controls.Add(this.CheckBox2);
			this.GroupBox2.Controls.Add(this.CheckBox1);
			this.GroupBox2.Controls.Add(this.ComboBox1);
			this.GroupBox2.Controls.Add(this.Button1);
			this.GroupBox2.Location = new System.Drawing.Point(12, 93);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new System.Drawing.Size(200, 160);
			this.GroupBox2.TabIndex = 2;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Output";
			// 
			// CheckBox3
			// 
			this.CheckBox3.AutoSize = true;
			this.CheckBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.CheckBox3.Location = new System.Drawing.Point(6, 134);
			this.CheckBox3.Name = "CheckBox3";
			this.CheckBox3.Size = new System.Drawing.Size(194, 18);
			this.CheckBox3.TabIndex = 7;
			this.CheckBox3.Text = "Delete original file after conversion";
			this.CheckBox3.UseVisualStyleBackColor = true;
			// 
			// Label6
			// 
			this.Label6.AutoSize = true;
			this.Label6.Location = new System.Drawing.Point(6, 118);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(81, 13);
			this.Label6.TabIndex = 6;
			this.Label6.Text = "Out resolution : ";
			// 
			// Label5
			// 
			this.Label5.AutoSize = true;
			this.Label5.Location = new System.Drawing.Point(6, 97);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(48, 13);
			this.Label5.TabIndex = 5;
			this.Label5.Text = "Resize : ";
			// 
			// ComboBox2
			// 
			this.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ComboBox2.FormattingEnabled = true;
			this.ComboBox2.Items.AddRange(new object[] {
            "x1",
            "x3/4",
            "x1/2",
            "x1/4"});
			this.ComboBox2.Location = new System.Drawing.Point(73, 94);
			this.ComboBox2.Name = "ComboBox2";
			this.ComboBox2.Size = new System.Drawing.Size(121, 21);
			this.ComboBox2.TabIndex = 4;
			this.ComboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
			// 
			// CheckBox2
			// 
			this.CheckBox2.AutoSize = true;
			this.CheckBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.CheckBox2.Location = new System.Drawing.Point(6, 71);
			this.CheckBox2.Name = "CheckBox2";
			this.CheckBox2.Size = new System.Drawing.Size(100, 18);
			this.CheckBox2.TabIndex = 3;
			this.CheckBox2.Text = "Flag as normal";
			this.CheckBox2.UseVisualStyleBackColor = true;
			// 
			// CheckBox1
			// 
			this.CheckBox1.AutoSize = true;
			this.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.CheckBox1.Location = new System.Drawing.Point(6, 48);
			this.CheckBox1.Name = "CheckBox1";
			this.CheckBox1.Size = new System.Drawing.Size(121, 18);
			this.CheckBox1.TabIndex = 2;
			this.CheckBox1.Text = "Generate Mipmaps";
			this.CheckBox1.UseVisualStyleBackColor = true;
			// 
			// ComboBox1
			// 
			this.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ComboBox1.FormattingEnabled = true;
			this.ComboBox1.Items.AddRange(new object[] {
            "DXT1",
            "DXT5 / DXT5nm",
            "RGB (Uncompressed)",
            "RGBA (Uncompressed)"});
			this.ComboBox1.Location = new System.Drawing.Point(87, 19);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new System.Drawing.Size(107, 21);
			this.ComboBox1.TabIndex = 1;
			// 
			// Button1
			// 
			this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Button1.Location = new System.Drawing.Point(6, 19);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(75, 23);
			this.Button1.TabIndex = 0;
			this.Button1.Text = "Detect";
			this.Button1.UseVisualStyleBackColor = true;
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// SingleFileDialog
			// 
			this.AcceptButton = this.OK_Button;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.Cancel_Button;
			this.ClientSize = new System.Drawing.Size(223, 305);
			this.Controls.Add(this.GroupBox2);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.TableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SingleFileDialog";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "File conversion options";
			this.Load += new System.EventHandler(this.dlg_SingleFile_Load);
			this.TableLayoutPanel1.ResumeLayout(false);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
		internal System.Windows.Forms.Button OK_Button;
		internal System.Windows.Forms.Button Cancel_Button;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.GroupBox GroupBox2;
		internal System.Windows.Forms.ComboBox ComboBox1;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.ComboBox ComboBox2;
		internal System.Windows.Forms.CheckBox CheckBox2;
		internal System.Windows.Forms.CheckBox CheckBox1;

		internal System.Windows.Forms.CheckBox CheckBox3;
	}
}