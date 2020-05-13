namespace Models
{
	public class ComputerService : BaseEntity
	{
		public ComputerService() : base()
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
		#region Order_Service
		//--Not allowed to be empty Order_Service
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		//--Lenght Order_Service
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 65)]
		public string Service_Type { get; set; }
		#endregion /Order_Service
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
