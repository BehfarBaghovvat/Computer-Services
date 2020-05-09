namespace Models
{
	public class ServiceComputer : BaseEntity
	{
		public ServiceComputer() : base()
		{

		}

		#region Register_Date
		//--Uniq Username
		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = true)]
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
			(maximumLength: 24)]
		public string Invoice_Number { get; set; }
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
			(maximumLength: 63)]
		public string Order_Service { get; set; }
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
			(maximumLength: 13)]
		public string Request_Status { get; set; }
		#endregion /Request_Status
	}
}
