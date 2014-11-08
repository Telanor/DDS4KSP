using System;
using System.Windows.Forms;

public partial class OverwriteFileDialog
{
	public OverwriteFileDialog()
	{
		InitializeComponent();
	}

	private void OK_Button_Click(Object sender, EventArgs e)
	{
		DialogResult = DialogResult.Yes;
		Close();
	}

	private void Cancel_Button_Click(Object sender, EventArgs e)
	{
		DialogResult = DialogResult.No;
		Close();
	}

	//argument is the filepath of the original file, not the backup
	public DialogResult CustomShowDialog(string sFilePath, out bool bDontAskAgain, ref bool bDeleteBackups)
	{
		Label1.Text = "The file " + sFilePath + " already exists.";
		Label2.Text = "Overwrite it with the backup from " + sFilePath.Remove(sFilePath.Length - 4, 4) + ".ddsified ?";

		//refresh controls     
		Label1.Left = 10;
		Label2.Left = 10;
		Width = Label2.Width + 20;
		Label2.Top = Label1.Bottom + 10;
		CheckBox1.Top = Label2.Bottom + 10;
		OK_Button.Top = CheckBox1.Bottom + 10;
		Cancel_Button.Top = OK_Button.Top;
		Height = CheckBox1.Bottom + 73;
		Cancel_Button.Left = Width - 10 - Cancel_Button.Width;
		OK_Button.Left = Cancel_Button.Left - 10 - OK_Button.Width;
		CheckBox1.Left = Width - 10 - CheckBox1.Width;

		if(ShowDialog() == DialogResult.Yes)
		{
			bDontAskAgain = CheckBox1.Checked;

			return DialogResult.Yes;
		}
		else
		{
			bDontAskAgain = CheckBox1.Checked;
			
			if(bDontAskAgain)
				bDeleteBackups = MessageBox.Show("Delete unused backup files in the process?", "Delete backups?", MessageBoxButtons.YesNo) == DialogResult.Yes;

			return DialogResult.No;
		}
	}
}