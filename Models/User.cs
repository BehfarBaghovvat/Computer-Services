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
		//------
		#region FullName
		//--Lenght FirstName
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 55)]
		public string FullName { get; set; }
		#endregion /FullName
		//------
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

		//--Lenght Email
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]

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
		#region UserPicture
		//--Empty User Picture
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		public byte[] UserPicture { get; set; }
		#endregion /UserPicture
		//------
		#region RegistrationTime
		//--Not allowed to be empty RegistrationTime
		[System.ComponentModel.DataAnnotations.Required
		(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 20)]

		public string RegistrationTime { get; set; }
		#endregion /RegistrationTime
	}
}
