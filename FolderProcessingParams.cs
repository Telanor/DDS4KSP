namespace DDS4KSPcs
{
	public class FolderProcessingParams
	{
		public double ResizeRatio { get; set; }
		public bool ProcessTGAs { get; set; }
		public bool ProcessPNGs { get; set; }
		public bool ProcessMBMs { get; set; }
		public bool Compressed { get; set; }
		public bool DeleteFilesOnSuccess { get; set; }
		public bool BackupFile { get; set; }
		public bool GenerateMipmaps { get; set; }
		public int NormalsManagement { get; set; }
		public int MinRes_Resize_Width { get; set; }
		public int MinRes_Resize_Height { get; set; }
		public int MinRes_Process_Width { get; set; }
		public int MinRes_Process_Height { get; set; }
		public bool IgnoreExceptions { get; set; }
		public bool FlipImages { get; set; }	//for pre-KSP 1.0

		//constructor, all default parameters are set from here
		public FolderProcessingParams()
		{
			ResizeRatio = 1;
			ProcessMBMs = true;
			ProcessPNGs = true;
			ProcessTGAs = true;
			Compressed = true;
			GenerateMipmaps = true;
			DeleteFilesOnSuccess = false;
			BackupFile = true;
			IgnoreExceptions = false;
			FlipImages = false;
			MinRes_Resize_Height = 64;
			MinRes_Resize_Width = 64;
			MinRes_Process_Width = 8;
			MinRes_Process_Height = 8;
			NormalsManagement = (int)ImageManager.NormalMapConversion.Automatic;
		}
	}
}
