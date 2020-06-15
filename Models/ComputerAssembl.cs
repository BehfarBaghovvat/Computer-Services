namespace Models
{
	public class ComputerAssembl : BaseEntity
	{
		public  ComputerAssembl(): base()
		{

		}

		#region Client_Name
		//--Not allowed to be empty ClientName
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//--Lenght ClientName
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 25)]
		public string Client_Name { get; set; }
		#endregion /Client_Name
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
		//-------------------------------------------------Mainboard
		#region Mainboard
		//-----
		#region Name_Mainboard
		//--Lenght Name_Mainboard
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Name_Mainboard { get; set; }
		#endregion /Name_Mainboard

		#region Number_Mainboard
		public int Number_Mainboard { get; set; }
		#endregion /Number_Mainboard

		#region UnitPrice_Mainboard
		//--Lenght Name_Mainboard
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 80)]
		public string UnitPrice_Mainboard { get; set; }
		#endregion /UnitPrice_Mainboard

		#region TotalPrice_Mainboard
		//--Lenght Name_Mainboard
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 90)]
		public string TotalPrice_Mainboard { get; set; }
		#endregion /TotalPrice_Mainboard
		//-----
		#endregion Mainboard
		//-------------------------------------------------Processor
		#region Processor
		//-----
		#region Name_Processor
		//--Lenght Name_Processor
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Name_Processor { get; set; }
		#endregion /Name_Mainboard

		#region Number_Processor
		public int Number_Processor { get; set; }
		#endregion /Number_Mainboard

		#region UnitPrice_Processor
		//--Lenght Name_Processor
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 80)]
		public string UnitPrice_Processor { get; set; }
		#endregion /UnitPrice_Mainboard

		#region TotalPrice_Processor
		//--Lenght Name_Processor
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 90)]
		public string TotalPrice_Processor { get; set; }
		#endregion /TotalPrice_Processor
		//-----
		#endregion Mainboard
		//-------------------------------------------------RAM
		#region RAM
		//-----
		#region Name_Ram
		//--Lenght Name_RAM
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Name_RAM { get; set; }
		#endregion /Name_RAM

		#region Number_RAM
		public int Number_RAM { get; set; }
		#endregion /Number_RAM

		#region UnitPrice_RAM
		//--Lenght UnitPrice_RAM
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 80)]
		public string UnitPrice_RAM { get; set; }
		#endregion /UnitPrice_RAM

		#region TotalPrice_RAM
		//--Lenght TotalPrice_RAM
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 90)]
		public string TotalPrice_RAM { get; set; }
		#endregion /TotalPrice_RAM
		//-----
		#endregion /RAM
		//-------------------------------------------------H.D.D
		#region H.D.D
		//-----
		#region Name_HDD
		//--Lenght Name_RAM
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Name_HDD { get; set; }
		#endregion /Name_HDD

		#region Number_HDD
		public int Number_HDD { get; set; }
		#endregion /Number_HDD

		#region UnitPrice_HDD
		//--Lenght Name_HDD
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 80)]
		public string UnitPrice_HDD { get; set; }
		#endregion /UnitPrice_HDD

		#region TotalPrice_HDD
		//--Lenght Name_HDD
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 90)]
		public string TotalPrice_HDD { get; set; }
		#endregion /TotalPrice_HDD
		//-----
		#endregion /H.D.D
		//-------------------------------------------------DVD-ROM
		#region DVD-ROM
		//-----
		#region Name_DVDROM
		//--Lenght Name_DVDROM
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Name_DVDROM { get; set; }
		#endregion /Name_DVDROM

		#region Number_DVDROM
		public int Number_DVDROM { get; set; }
		#endregion /Number_DVDROM

		#region UnitPrice_DVDROM
		//--Lenght Name_DVDROM
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 80)]
		public string UnitPrice_DVDROM { get; set; }
		#endregion /UnitPrice_DVDROM

		#region TotalPrice_DVDROM
		//--Lenght Name_DVDROM
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 90)]
		public string TotalPrice_DVDROM { get; set; }
		#endregion /TotalPrice_DVDROM
		//-----
		#endregion DVD-ROM
		//-------------------------------------------------Graphic Card
		#region Graphic_Card
		//-----
		#region Name_Graphic_Card
		//--Lenght Name_Graphic_Card
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Name_Graphic_Card { get; set; }
		#endregion /Name_Graphic_Card

		#region Number_Graphic_Card
		public int Number_Graphic_Card { get; set; }
		#endregion /Number_Graphic_Card

		#region UnitPrice_Graphic_Card
		//--Lenght Name_Graphic_Card
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 80)]
		public string UnitPrice_Graphic_Card { get; set; }
		#endregion /UnitPrice_Graphic_Card

		#region TotalPrice_Graphic_Card
		//--Lenght Name_Graphic_Card
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 90)]
		public string TotalPrice_Graphic_Card { get; set; }
		#endregion /TotalPrice_Graphic_Card
		//-----
		#endregion Graphic Card
		//-------------------------------------------------Keyboard
		#region Keyboard
		//-----
		#region Name_Keyboard
		//--Lenght Name_Keyboard
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Name_Keyboard { get; set; }
		#endregion /Name_Keyboard

		#region Number_Keyboard
		public int Number_Keyboard { get; set; }
		#endregion /Number_Keyboard

		#region UnitPrice_Keyboard
		//--Lenght Name_Keyboard
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 80)]
		public string UnitPrice_Keyboard { get; set; }
		#endregion /UnitPrice_Keyboard

		#region TotalPrice_Keyboard
		//--Lenght Name_Keyboard
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 90)]
		public string TotalPrice_Keyboard { get; set; }
		#endregion /TotalPrice_Keyboard
		//-----
		#endregion Keyboard
		//-------------------------------------------------Mouse
		#region Mouse
		//-----
		#region Name_Mouse
		//--Lenght Name_Mouse
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Name_Mouse { get; set; }
		#endregion /Name_Mouse

		#region Number_Mouse
		public int Number_Mouse { get; set; }
		#endregion /Number_Mouse

		#region UnitPrice_Mouse
		//--Lenght Name_Mouse
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 80)]
		public string UnitPrice_Mouse { get; set; }
		#endregion /UnitPrice_Mouse

		#region TotalPrice_Mouse
		//--Lenght Name_Mouse
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 90)]
		public string TotalPrice_Mouse { get; set; }
		#endregion /TotalPrice_Mouse
		//-----
		#endregion Mouse
		//-------------------------------------------------Speaker
		#region Speaker
		//-----
		#region Name_Speaker
		//--Lenght Name_Speaker
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Name_Speaker { get; set; }
		#endregion /Name_Speaker

		#region Number_Speaker
		public int Number_Speaker { get; set; }
		#endregion /Number_Speaker

		#region UnitPrice_Speaker
		//--Lenght Name_Speaker
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 80)]
		public string UnitPrice_Speaker { get; set; }
		#endregion /UnitPrice_Speaker

		#region TotalPrice_Speaker
		//--Lenght Name_Speaker
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 90)]
		public string TotalPrice_Speaker { get; set; }
		#endregion /TotalPrice_Speaker
		//-----
		#endregion Speaker
		//-------------------------------------------------Monitor
		#region Monitor
		//-----
		#region Name_Monitor
		//--Lenght Name_Monitor
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Name_Monitor { get; set; }
		#endregion /Name_Monitor

		#region Number_Monitor
		public int Number_Monitor { get; set; }
		#endregion /Number_Monitor

		#region UnitPrice_Monitor
		//--Lenght Name_Monitor
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 80)]
		public string UnitPrice_Monitor { get; set; }
		#endregion /UnitPrice_Monitor

		#region TotalPrice_Monitor
		//--Lenght Name_Monitor
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 90)]
		public string TotalPrice_Monitor { get; set; }
		#endregion /TotalPrice_Monitor
		//-----
		#endregion Monitor
		//-------------------------------------------------Other Device1
		#region Other Device1
		//-----
		#region Name_Other_Device1
		//--Lenght Name_Other_Device1
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Name_Other_Device1 { get; set; }
		#endregion /Name_Other_Device1

		#region Number_Other_Device1
		public int Number_Other_Device1 { get; set; }
		#endregion /Number_Other_Device1

		#region UnitPrice_Other_Device1
		//--Lenght Name_Other_Device1
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 80)]
		public string UnitPrice_Other_Device1 { get; set; }
		#endregion /UnitPrice_Other_Device1

		#region TotalPrice_Other_Device1
		//--Lenght Name_Other_Device1
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 90)]
		public string TotalPrice_Other_Device1 { get; set; }
		#endregion /TotalPriceOther_Device1
		//-----
		#endregion Other Device1
		//-------------------------------------------------Other Device2
		#region Other Device2
		//-----
		#region Name_Other_Device2
		//--Lenght Name_Other_Device2
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Name_Other_Device2 { get; set; }
		#endregion /Name_Other_Device2

		#region Number_Other_Device2
		public int Number_Other_Device2 { get; set; }
		#endregion /Number_Other_Device2

		#region UnitPrice_Other_Device2
		//--Lenght Name_Other_Device2
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 80)]
		public string UnitPrice_Other_Device2 { get; set; }
		#endregion /UnitPrice_Other_Device2

		#region TotalPrice_Other_Device2
		//--Lenght Name_Other_Device2
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 90)]
		public string TotalPrice_Other_Device2 { get; set; }
		#endregion /TotalPriceOther_Device2
		//-----
		#endregion Other Device2
		//-------------------------------------------------Other Device3
		#region Other Device3
		//-----
		#region Name_Other_Device3
		//--Lenght Name_Other_Device3
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Name_Other_Device3 { get; set; }
		#endregion /Name_Other_Device3

		#region Number_Other_Device3
		public int Number_Other_Device3 { get; set; }
		#endregion /Number_Other_Device3

		#region UnitPrice_Other_Device3
		//--Lenght Name_Other_Device3
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 80)]
		public string UnitPrice_Other_Device3 { get; set; }
		#endregion /UnitPrice_Other_Device3

		#region TotalPrice_Other_Device3
		//--Lenght Name_Other_Device3
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 90)]
		public string TotalPrice_Other_Device3 { get; set; }
		#endregion /TotalPriceOther_Device3
		//-----
		#endregion Other Device3
		//-------------------------------------------------Other Device4
		#region Other Device4
		//-----
		#region Name_Other_Device4
		//--Lenght Name_Other_Device4
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Name_Other_Device4 { get; set; }
		#endregion /Name_Other_Device4

		#region Number_Other_Device4
		public int Number_Other_Device4 { get; set; }
		#endregion /Number_Other_Device4

		#region UnitPrice_Other_Device4
		//--Lenght Name_Other_Device4
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 80)]
		public string UnitPrice_Other_Device4 { get; set; }
		#endregion /UnitPrice_Other_Device4

		#region TotalPrice_Other_Device4
		//--Lenght Name_Other_Device1
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 90)]
		public string TotalPrice_Other_Device4 { get; set; }
		#endregion /TotalPrice_Other_Device4
		//-----
		#endregion Other Device4
		//-------------------------------------------------Other Device5
		#region Other Device5
		//-----
		#region Name_Other_Device5
		//--Lenght Name_Other_Device5
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Name_Other_Device5 { get; set; }
		#endregion /Name_Other_Device5

		#region Number_Other_Device5
		public int Number_Other_Device5{ get; set; }
		#endregion /Number_Other_Device5

		#region UnitPrice_Other_Device5
		//--Lenght Name_Other_Device5
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 80)]
		public string UnitPrice_Other_Device5 { get; set; }
		#endregion /UnitPrice_Other_Device5

		#region TotalPrice_Other_Device5
		//--Lenght Name_Other_Device5
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 90)]
		public string TotalPrice_Other_Device5 { get; set; }
		#endregion /TotalPrice_Other_Device5
		//-----
		#endregion Other Device5
		//-------------------------------------------------Sum Total Price
		#region Sum_Total_Price
		public string Sum_Total_Price { get; set; }
		#endregion /Sum_Total_Price

	}
}
