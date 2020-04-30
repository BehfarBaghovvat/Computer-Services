using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerServices
{
	static class Program
	{
		public static Models.User AuthenticatedUser { get; set; }

		#region Administrator
		public static void Administrator()
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				bool isAdmin = true;
				bool isActive = true;
				
				string username =
					"Administrator";
				string email =
					"null";
				string password =
					"admin";
				string description =
					"null";
				string adminPic =
				"D:\\Visual Studio Project\\C# Project\\ComputerServices\\Computer Services\\Resources\\AdminUser.png";
				string firstName =
					"null";
				string lastName =
					"null";
				int tel =
					0;
				int nationalCode =
					0;
				string address =
					"null";
				string married =
					"null";
				Models.User adminUser =
					dataBaseContext.Users
					.Where(admin => string.Compare(username, admin.Username, true) == 0)
					.FirstOrDefault();

				if (adminUser == null)
				{
					adminUser =
						new Models.User
						{
							IsActive = isActive,
							IsAdministrator = isAdmin,
							Username = username,
							Email = email,
							Password = password,
							Description = description,
							User_Image = System.IO.File.ReadAllBytes(adminPic),
							First_Name = firstName,
							Last_Name = lastName,
							Telephone = tel.ToString(),
							National_Code = nationalCode.ToString(),
							Address = address,
							Marital_Status = married,
							Registration_Time = "00:00:00 ",
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

		#region StartUpProgramForm
		private static StartUpProgramForm startUpProgramForm;
		public static StartUpProgramForm  StartUpProgramForm
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
			//LoginForm.Initialize();
			StartUpProgramForm.ShowDialog();
		}
		#endregion /StartUpShow
		#endregion /StartUpProgramForm

		//-----
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
			//LoginForm.Initialize();
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
			//MainForm.Initialize();
			MainForm.Show();
		}
		#endregion /MainShow
		#endregion /MainForm
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			//Administrator();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new RegisterForm());
		}
	}
}
