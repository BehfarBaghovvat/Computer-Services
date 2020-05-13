namespace Models
{
	public class DataBaseContext : System.Data.Entity.DbContext
	{
		static DataBaseContext()
		{
			System.Data.Entity.Database.SetInitializer
				(new System.Data.Entity.DropCreateDatabaseIfModelChanges<DataBaseContext>());
		}

		public DataBaseContext() : base()
		{

		}

		/// <summary>
		/// Table of User
		/// </summary>
		public System.Data.Entity.DbSet<User> Users { get; set; }

		//public System.Data.Entity.DbSet<Client> Clients { get; set; }

		/// <summary>
		/// Table of LogHistory
		/// </summary>
		public System.Data.Entity.DbSet<LogHistory> LogHistories { get; set; }

		/// <summary>
		///  Table of ComputerServices
		/// </summary>
		public System.Data.Entity.DbSet<ComputerService> ComputerServices { get; set; }

		/// <summary>
		/// Table of CellphoneServices
		/// </summary>
		public System.Data.Entity.DbSet<CellphoneService> CellphoneServices { get; set; }

		//public System.Data.Entity.DbSet<ActivityHistory> ActivityHistories { get; set; }


	}
}
