using System.Linq;
using System.Windows.Forms;

namespace ComputerServices
{
	static class Program
	{
		public static Models.User AuthenticatedUser { get; set; }
		public static Models.LogHistory AutenticatLogHistory { get; set; }
		
		//------------------------------------------------------------------

		
		#region LoginForm
		private static LoginForm loginForm;
		public static LoginForm LoginForm
		{
			get
			{
				if (loginForm == null)
				{
					loginForm =
						new LoginForm();
				}
				return loginForm;
			}
		}
		#region LoginShow
		public static void LoginShow()
		{
			AuthenticatedUser = null;
			LoginForm.Initialize();
			LoginForm.Show();
		}
		#endregion /LoginShow

		public static void LogIn(object sender,System.Windows.Forms.FormClosedEventArgs e)
		{
			
			LoginForm.Show();
		}
		#endregion /LoginForm
		//-----
		#region RegisterForm
		private static RegisterForm registerForm;
		public static RegisterForm RegistrForm
		{
			get
			{
				if (registerForm == null)
				{
					registerForm =
						new RegisterForm();
				}
				return registerForm;
			}
		}
		#region RegistrShow
		public static void RegistrShow()
		{
			RegistrForm.Show();
		}
		#endregion /RegistrShow
		#endregion /RegisterForm
		//-----
		#region MainForm
		private static MainForm mainForm = null;
		public static MainForm MainForm
		{
			get
			{
				if (mainForm == null || mainForm.IsDisposed == true)
				{
					mainForm =
						new MainForm();
				}
				return mainForm;
			}
		}

		#region MainShow
		public static void MainShow()
		{
			MainForm.Initialize();
			MainForm.Show();
		}
		#endregion /MainShow

		#endregion /MainForm
		//-----
		#region StartUpProgramForm
		private static StartUpProgramForm startUpProgramForm;
		public static StartUpProgramForm StartUpProgramForm
		{
			get
			{
				if (startUpProgramForm == null)
				{
					startUpProgramForm =
						new StartUpProgramForm();
				}
				return startUpProgramForm;
			}
		}

		#region StartUpShow
		public static void StartUpShow()
		{
			AuthenticatedUser = null;
			LoginForm.Initialize();
			StartUpProgramForm.ShowDialog();
		}
		#endregion /StartUpShow
		#endregion /StartUpProgramForm
		//-----
		#region Administrator
		public static void Administrator()
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();
				string adminPic =
				"D:\\Visual Studio Project\\C# Project\\ComputerServices\\Computer Services\\Resources\\AdminUser.png";
				Models.User adminUser =
					dataBaseContext.Users
					.Where(current => string.Compare(current.Username, "administrator", true) == 0)
					.FirstOrDefault();

				if (adminUser == null)
				{
					adminUser =
						new Models.User
						{
							IsActive = true,
							IsAdministrator = true,
							Username = "administrator",
							Email = "null",
							Password = "administrator",
							Description = "null",
							User_Image = System.IO.File.ReadAllBytes(adminPic),
							First_Name = "null",
							Last_Name = "null",
							Telephone = "null",
							National_Code = "null",
							Address = "null",
							Marital_Status = "null",
							Registration_Time = "00:00:00",
							Registration_Date = "0000/00/00",
						};
					dataBaseContext.Users.Add(adminUser);
				}

				else
				{
					if (adminUser.IsActive == false)
					{
						adminUser.IsActive = true;
					}

					if (adminUser.IsAdministrator == false)
					{
						adminUser.IsAdministrator = true;
					}
				}
				dataBaseContext.SaveChanges();
			}
			catch (System.Exception ex)
			{

				Infrastructure.Utility.PopupNotification(ex);
			}
			finally
			{
				if (dataBaseContext != null)
				{
					dataBaseContext.Dispose();
					dataBaseContext = null;
				}
			}
		}
		#endregion /Administrator

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[System.STAThread]
		static void Main()
		{
			
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Administrator();
			Application.Run(new StartUpProgramForm());
		}
	}
}
