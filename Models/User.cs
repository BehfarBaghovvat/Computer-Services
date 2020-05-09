namespace Models
{
    public class User : BaseEntity
    {
        public User() : base()
        {

        }

		#region IsAdministrator
		public bool IsAdministrator { get; set; }
		#endregion /IsAdministrator
		//------
		#region IsActive
		public bool IsActive { get; set; }
		#endregion /IsActive
		//-----
		#region Username
		//--Uniq Username
		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = true)]
		//--Not allowed to be empty Username
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//--Lenght Username
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 25)]
		public string Username { get; set; }
		#endregion /Username
		//------
		#region Email
		//--Uniq Email
		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = true)]
		//--Not allowed to be empty Email
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//--Lenght Email
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 100)]
		public string Email { get; set; }
		#endregion /Email
		//------
		#region Password
		//--Not allowed to be empty Password
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//--Lenght Password
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 40)]
		public string Password { get; set; }
		#endregion /Password
		//------
		#region UserImage
		//--Empty UserImage
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		public byte[] User_Image { get; set; }
		#endregion /UserImage
		//------
		#region Description
		//--Length Description
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 3200)]
		public string Description { get; set; }
		#endregion /Description
		//------
		#region FirstName
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 20)]
		public string First_Name { get; set; }
		#endregion /FirstName
		//-----
		#region LastName
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 25)]
		public string Last_Name { get; set; }
		#endregion /LastName
		//-----
		#region Telephone
		//--Uniq Telephone
		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = true)]
		//--Not allowed to be empty Telephone
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//--Length Telephone
		[System.ComponentModel.DataAnnotations.StringLength
		(maximumLength: 11)]
		public string Telephone { get; set; }
		#endregion /Telephone
		//-----
		#region NationalCode
		//--Uniq NationaCode
		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = true)]
		//--Length Telephone
		[System.ComponentModel.DataAnnotations.StringLength
		(maximumLength: 12)]
		public string National_Code { get; set; }
		#endregion /NationalCode
		//-----
		#region MaritalStatus
		//--Length MaritalStatus
		[System.ComponentModel.DataAnnotations.StringLength
		(maximumLength: 5)]
		public string Marital_Status { get; set; }
		#endregion /MaritalStatus
		//-----
		#region Address
		//--Uniq Address
		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = true)]
		//--Length Address
		[System.ComponentModel.DataAnnotations.StringLength
		(maximumLength: 500)]
		public string Address { get; set; }
		#endregion /Address
		//-----
		#region RegistrationTime
		//--Not allowed to be empty RegistrationTime
		[System.ComponentModel.DataAnnotations.Required
		(AllowEmptyStrings = false)]
		//--Length RegistrationTime
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 8)]
		public string Registration_Time { get; set; }
		#endregion /RegistrationTime
		//-----
		#region Registration_Date
		//--Not allowed to be empty RegistrationDate
		[System.ComponentModel.DataAnnotations.Required
		(AllowEmptyStrings = false)]
		//--Length RegistrationDate
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 10)]
		public string Registration_Date { get; set; }
		#endregion /Registration_Date

	}
}
