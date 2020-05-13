namespace Models
{
	public class CellphoneService : BaseEntity
	{
		public CellphoneService() : base()
		{

		}

		#region Register_Date
		//--Not allowed to be empty Username
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//--Lenght Username
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 10)]
		public string Register_Date { get; set; }
		#endregion /Register_Date
		//------
		#region Invoice_Number
		//--Uniq Invoice_Number
		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = true)]

		//--Not allowed to be empty Invoice_Number
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		//--Lenght Invoice_Number
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 25)]
		public string Invoice_Serial { get; set; }
		#endregion Invoice_Number
		//------
		#region Client_Name
		//--Not allowed to be empty Client_Name
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		//--Lenght Client_Name
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 45)]
		public string Client_Name { get; set; }
		#endregion /Client_Name
		//------
		public bool LCD_Service { get; set; }
		public bool RAM_Service { get; set; }
		public bool ROM_Service { get; set; }
		public bool Board_Service { get; set; }
		public bool Camera_Service { get; set; }
		public bool Battery_Service { get; set; }
		public bool Other_Hardware_Service { get; set; }
		//-----------------------------------------------------
		public bool Samsung_ID { get; set; }
		public bool Apple_ID { get; set; }
		public bool Dowanlod_OS_Android { get; set; }
		public bool DowanLoad_OS_IOS { get; set; }
		public bool Setup_APK { get; set; }
		public bool Setup_IPA { get; set; }
		public bool Reset_Factory { get; set; }
		public bool Other_Software_Service { get; set; }
		//------
		#region Description
		//--Lenght Description
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 1000)]
		public string Description { get; set; }
		#endregion /Description
		//------
		#region Request_Status
		//--Not allowed to be empty Invoice_Number
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		//--Lenght Invoice_Number
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 15)]
		public string Request_Status { get; set; }
		#endregion /Request_Status
	}
}
