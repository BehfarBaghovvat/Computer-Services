using System.Linq;
using System.Windows.Forms;

namespace ComputerServices
{
	public partial class LoginForm : Infrastructure.BaseForm
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		#region Properties

		private ForgetPasswordForm forgetPasswordForm;

		public ForgetPasswordForm ForgetPasswordForm
		{
			get
			{
				if (forgetPasswordForm == null || forgetPasswordForm.IsDisposed == true)
				{
					forgetPasswordForm =
						new ForgetPasswordForm();
				}
				return forgetPasswordForm;
			}
		}

		private static int i;
		public static int I
		{
			get { return i; }
			set { i = value; }
		}
		public string UsernameEmail { get; set; }
		public string Password { get; set; }

		#endregion /Properties

		//-----The beginning of the coding line.

		#region CloseButton_Click
		private void CloseButton_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}
		#endregion /CloseButton_Click

		#region MinimizeButton_Click
		private void MinimizeButton_Click(object sender, System.EventArgs e)
		{
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
		}

		#endregion /MinimizeButton_Click

		#region UsernameTextBox_Enter
		private void UsernameEmailTextBox_Enter(object sender, System.EventArgs e)
		{
			i = 0;
			Infrastructure.Utility.EnglishLanguage();

			usernameEmailTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			usernameEmailPanel.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(usernameEmailTextBox.Text, "Username\\Email") == 0)
			{
				usernameEmailTextBox.Clear();
			}
		}
		#endregion /UsernameTextBox_Enter

		#region UsernameTextBox_KeyPress
		private void UsernameEmailTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.EnglishAndNumberTyping(e);
		}
		#endregion /UsernameTextBox_KeyPress

		#region UsernameTextBox_Leave
		private void UsernameEmailTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(usernameEmailTextBox.Text) || string.Compare(usernameEmailTextBox.Text, "Username\\Email") == 0)
			{
				usernameEmailTextBox.ForeColor =
				Infrastructure.Utility.GrayColor();
				usernameEmailPanel.BackColor =
					Infrastructure.Utility.GrayColor();

				usernameEmailTextBox.Text = "Username\\Email";
				UsernameEmail = string.Empty;
			}
			else
			{
				usernameEmailTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
				usernameEmailPanel.BackColor =
					Infrastructure.Utility.WhiteColor();
				UsernameEmail = usernameEmailTextBox.Text;
			}
		}
		#endregion /UsernameTextBox_Leave

		#region PasswordTextBox_Enter
		private void PasswordTextBox_Enter(object sender, System.EventArgs e)
		{
			passwordTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			passwordPanel.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(passwordTextBox.Text, "Password") == 0)
			{
				passwordTextBox.Clear();
				passwordTextBox.UseSystemPasswordChar = false;
			}
		}
		#endregion /PasswordTextBox_Enter

		#region PasswordTextBox_Leave
		private void PasswordTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(passwordTextBox.Text) || string.Compare(usernameEmailTextBox.Text, "Password") == 0)
			{
				passwordTextBox.ForeColor =
					Infrastructure.Utility.GrayColor();
				passwordPanel.BackColor =
					Infrastructure.Utility.GrayColor();

				passwordTextBox.Text = "Password";
				Password = string.Empty;
			}
			else
			{
				passwordTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				passwordPanel.BackColor =
					Infrastructure.Utility.WhiteColor();
				Password = passwordTextBox.Text;
			}
		}
		#endregion /PasswordTextBox_Leave

		#region LoginButton_Click
		private void LoginButton_Click(object sender, System.EventArgs e)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				string errorMessage = string.Empty;

				if (string.IsNullOrEmpty(UsernameEmail))
				{
					errorMessage =
						"نام کاربری یا پست الکترونیکی را وارد کنید!!";
				}
				if (string.IsNullOrEmpty(Password))
				{
					if (string.IsNullOrEmpty(errorMessage) == false)
					{
						errorMessage +=
							System.Environment.NewLine;
					}
					errorMessage +=
						"رمز عبور را وارد نمایید.";
				}

				if (string.IsNullOrEmpty(errorMessage) == false)
				{
					if (string.IsNullOrEmpty(UsernameEmail))
					{
						usernameEmailTextBox.Focus();
					}
					else if (string.IsNullOrEmpty(Password) == false)
					{
						passwordTextBox.Focus();
					}

					Mbb.Windows.Forms.MessageBox.Show
						(text: errorMessage,
						caption: "خطای ورودی",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
						button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
					return;
				}

				if (ApprovalUsername(text: UsernameEmail) == false && ApprovalEmail(text: UsernameEmail) == false)
				{
					i++;
					errorMessage =
								"شناسه کاربری و/یا رمز عبور صحیح نمی باشد!";
					Mbb.Windows.Forms.MessageBox.Show
						(text: errorMessage,
						caption: "خطای ورودی",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
						button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
					//usernameEmailTextBox.Focus();
					//UsernameEmail = string.Empty;
					if (i >= 2)
					{
						forgetPasswordLinkLabel.Visible = true;
					}
					return;
				}
				else if (ApprovalUsername(text: UsernameEmail) == true && ApprovalEmail(text: UsernameEmail) == false)
				{
					Models.User user =
						dataBaseContext.Users
						.Where(current => string.Compare(current.Username, UsernameEmail, true) == 0)
						.FirstOrDefault();


					if (string.Compare(user.Password, Password, true) != 0)
					{
						i++;
						errorMessage =
							"شناسه کاربری و/یا رمز عبور صحیح نمی باشد!";
						Mbb.Windows.Forms.MessageBox.Show
							(text: errorMessage, caption: "خطای ورودی",
							icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
							button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
						
						if (i >= 2)
						{

							forgetPasswordLinkLabel.Visible = true;
						}
						return;
					}
					else
					{
						errorMessage = string.Empty;
						errorMessage =
								"خوش آمدید!";
						Mbb.Windows.Forms.MessageBox.Show
							(text: errorMessage, caption: "ورودی",
							icon: Mbb.Windows.Forms.MessageBoxIcon.Success,
							button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
					}

					this.Hide();
					//Program.AuthenticatedUser = foundUser;
					//SaveLoginHistory(foundUser);

					//WelcomeForm welcomeForm =
					//	new WelcomeForm();

					//welcomeForm.ShowDialog();

					//Program.MainForm.FormClosed += LogOut;
				}

				else if (ApprovalUsername(text: UsernameEmail) == false && ApprovalEmail(text: UsernameEmail) == true)
				{
					Models.User user =
						dataBaseContext.Users
						.Where(current => string.Compare(current.Email, UsernameEmail, false) == 0)
						.FirstOrDefault();

					if (string.Compare(user.Password, Password, true) != 0)
					{
						i++;
						errorMessage =
							"شناسه کاربری و/یا رمز عبور صحیح نمی باشد!";
						Mbb.Windows.Forms.MessageBox.Show
							(text: errorMessage, caption: "خطای ورودی",
							icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
							button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
						//usernameEmailTextBox.Focus();
						if (i >= 2)
						{
							forgetPasswordLinkLabel.Visible = true;
						}
					}

					else
					{
						errorMessage =
										"خوش آمدید!";
						Mbb.Windows.Forms.MessageBox.Show
							(text: errorMessage, caption: "ورودی",
							icon: Mbb.Windows.Forms.MessageBoxIcon.Success,
							button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
					}
					//usernameEmailTextBox.Focus();

					//this.Hide();
					//Program.AuthenticatedUser = foundUser;
					//SaveLoginHistory(foundUser);

					//WelcomeForm welcomeForm =
					//	new WelcomeForm();

					//welcomeForm.ShowDialog();

					//Program.MainForm.FormClosed += LogOut;
				}
			}
			catch (System.Exception ex)
			{

				Infrastructure.Utility.ExceptionShow(ex);
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
		#endregion /LoginButton_Click

		#region ForgetPasswordLinkLabel_LinkClicked
		private void ForgetPasswordLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Hide();
			ForgetPasswordForm.Show();

			ForgetPasswordForm.FormClosed += LogOut;
		}
		#endregion /ForgetPasswordLinkLabel_LinkClicked

		#region NewAccountLinkLabel_LinkClicked
		private void NewAccountLinkLabel_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			this.Hide();
			Program.RegistrShow();
		}
		#endregion /NewAccountLinkLabel_LinkClicked


		//-----End of coding line

		#region Functions
		//------
		#region ApprovalUsername
		private bool ApprovalUsername(string text)
		{
			Models.DataBaseContext dataBaseContext = null;
			dataBaseContext =
				new Models.DataBaseContext();

			Models.User user =
				dataBaseContext.Users
				.Where(current => string.Compare(current.Username, text, true) == 0)
				.FirstOrDefault();

			if (user != null)
			{
				return true;

			}
			else
			{
				return false;
			}
		}
		#endregion /ApprovalUsername

		#region ApprovalEmail
		private bool ApprovalEmail(string text)
		{
			Models.DataBaseContext dataBaseContext = null;
			dataBaseContext =
				new Models.DataBaseContext();

			Models.User user =
				dataBaseContext.Users
				.Where(current => string.Compare(current.Email, text, true) == 0)
				.FirstOrDefault();

			if (user != null)
			{
				return true;
			}
			else
			{
				return false;
			}
		}










		#endregion /ApprovalEmail

		#region LogOut
		public void LogOut(object sender, System.Windows.Forms.FormClosedEventArgs e)
		{
			Program.AuthenticatedUser = null;
			usernameEmailTextBox.Text = "Username\\Email";

			passwordTextBox.Text = "Password";
			passwordTextBox.UseSystemPasswordChar = false;
			this.Show();
		}
		#endregion LogOut
		//-----
		#endregion /Functions

		private void LoginForm_Load(object sender, System.EventArgs e)
		{

		}

		
	}
}
