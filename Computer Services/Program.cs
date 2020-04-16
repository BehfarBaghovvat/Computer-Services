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

				//string adminPic =
				//"D:\\Visual Studio Project\\C# Project\\Resturant\\Resturant\\Resources\\AdminUser.png";

				string user =
					"admin";

				string password =
					"admin";

				string email =
					"admin@admin.com";
				bool isAdmin = true;
				bool isActive = true;

				Models.User adminUser =
					dataBaseContext.Users
					.Where(admin => string.Compare(user, admin.Username, true) == 0)
					.FirstOrDefault();

				if (adminUser == null)
				{
					adminUser =
						new Models.User
						{
							IsActive = isActive,
							IsAdministrator = isAdmin,

							Username = user,
							Password = password,
							Email = email,
							//UserPicture = System.IO.File.ReadAllBytes(adminPic),
							RegistrationTime = "00:00:00 " + "0000/00/00",
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

				Mbb.Windows.Forms.MessageBox.ErrorMessage(ex.Message);
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
			LoginForm.ShowDialog();
		}
		#endregion /LoginShow
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

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new RegisterForm());
		}
	}
}
