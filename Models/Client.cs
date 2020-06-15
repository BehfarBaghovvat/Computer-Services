using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
	public class Client : BaseEntity
	{
		public Client() : base()
		{

		}

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
	}
}
