namespace Models
{
	public class LogHistory : BaseEntity
	{
		public LogHistory() : base()
		{

		}

		#region FullName
		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = false)]

		//--Not allowed to be empty Username
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		//--Lenght Username
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 55)]
		public string FullName { get; set; }
		#endregion /FullName
		//-----
		#region Username
		//--Username is not Unique
		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = false)]

		//--Not allowed to be empty Username
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		//--Lenght Username
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 25)]
		public string Username { get; set; }
		#endregion /Username
		//-----
		#region UserPicture
		//--Empty User Picture
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		public byte[] UserPicture { get; set; }

		#endregion /UserPicture
		//-----
		#region LoginTime
		//--Not allowed to be empty LoginTime
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = true)]

		//--Lenght LoginTime
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 20)]

		public string LoginTime { get; set; }
		#endregion /LoginTime
		//-----
		#region LogoutTime
		//--Not allowed to be empty LogoutTime
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = true)]

		//--Lenght LogoutTime
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 20)]

		public string LogoutTime { get; set; }
		#endregion /LogoutTime
	}
}
