using System.Linq;
using System.Runtime.InteropServices;

namespace ComputerServices
{
	public partial class RegisterForm : Infrastructure.BaseForm
	{
		public RegisterForm()
		{
			InitializeComponent();
		}

		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

		#region Properties

		public string Username { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string PasswordConfirm { get; set; }
		public string Description { get; set; }
		public string UserImage { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Tel { get; set; }
		public string NationalCode { get; set; }
		public string Address { get; set; }
		public string Marride { get; set; }
		public string RegisterDate { get; set; }
		public string RegisterTime { get; set; }
		#endregion /Properties

		//-----The beginning of the coding line.

		#region RegisterForm_MouseDown
		private void RegisterForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		#endregion /RegisterForm_MouseDown

		#region TitlePanel_MouseDown
		private void TitlePanel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		#endregion TitlePanel_MouseDown

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

		#region UsernameTextBox
		//-----
		#region UsernameTextBox_Enter
		private void UsernameTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.EnglishLanguage();

			usernameTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			usernameTextBox.Font =
				Infrastructure.Utility.CenturyGothicFont(usernameTextBox.Font.Size);
			usernameTextBox.RightToLeft =
				System.Windows.Forms.RightToLeft.No;
			usernameTextBox.TextAlign =
				System.Windows.Forms.HorizontalAlignment.Left;
			usernamePanel.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(usernameTextBox.Text, "نام کاربری") == 0)
			{
				usernameTextBox.Clear();
			}
		}

		#endregion /UsernameTextBox_Enter

		#region UsernameTextBox_KeyPress
		private void UsernameTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.EnglishAndNumberTyping(e);
		}

		#endregion /UsernameTextBox_KeyPress

		#region UsernameTextBox_Leave
		private void UsernameTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(usernameTextBox.Text) || string.Compare(usernameTextBox.Text, "نام کاربری") == 0)
			{
				usernameTextBox.ForeColor =
				Infrastructure.Utility.DimGrayColor();
				usernamePanel.BackColor =
				Infrastructure.Utility.DimGrayColor();
				usernameTextBox.Text = "نام کاربری";
				usernameTextBox.Font =
					Infrastructure.Utility.IranSansFont(12);
				usernameTextBox.RightToLeft =
					System.Windows.Forms.RightToLeft.Yes;
				usernameTextBox.TextAlign =
					System.Windows.Forms.HorizontalAlignment.Left;
				confirmUsernameTickPicturBox.Visible = false;
				Username = string.Empty;
				return;
			}
			else
			{
				if (Infrastructure.Utility.UserCheck(usernameTextBox.Text) == true)
				{
					usernameTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
					usernamePanel.BackColor =
					Infrastructure.Utility.WhiteColor();
					confirmUsernameTickPicturBox.Image = Properties.Resources.Tik_True;
					confirmUsernameTickPicturBox.Visible = true;
					Username = usernameTextBox.Text;
					return;
				}
				else
				{
					confirmUsernameTickPicturBox.Image = Properties.Resources.Tik_False;
					confirmUsernameTickPicturBox.Visible = true;
					Username = string.Empty;
					return;
				}
			}
		}

		#endregion /UsernameTextBox_Leave
		//-----
		#endregion /UsernameTextBox

		#region  EmailTextBox
		//-----
		#region EmailTextBox_Enter
		private void EmailTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.EnglishLanguage();

			emailTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			emailTextBox.RightToLeft =
				System.Windows.Forms.RightToLeft.No;
			emailTextBox.TextAlign =
				System.Windows.Forms.HorizontalAlignment.Left;
			emailTextBox.Font =
				Infrastructure.Utility.CenturyGothicFont(emailTextBox.Font.Size);
			emailPanel.BackColor =
				Infrastructure.Utility.LimeColor();


			if (string.Compare(emailTextBox.Text, "پست الکترونیکی") == 0)
			{
				emailTextBox.Clear();
			}
		}
		#endregion /EmailTextBox_Enter

		#region EmailTextBox_KeyPress
		private void EmailTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.EnglishAndNumberTyping(e);
		}
		#endregion /EmailTextBox_KeyPress

		#region EmailTextBox_Leave
		private void EmailTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(emailTextBox.Text) || string.Compare(emailTextBox.Text, "پست الکترونیکی") == 0)
			{
				emailTextBox.ForeColor =
				Infrastructure.Utility.DimGrayColor();
				emailPanel.BackColor =
					Infrastructure.Utility.DimGrayColor();

				emailTextBox.Font =
					Infrastructure.Utility.IranSansFont(12);

				emailTextBox.RightToLeft =
				System.Windows.Forms.RightToLeft.Yes;
				emailTextBox.TextAlign =
					System.Windows.Forms.HorizontalAlignment.Left;

				emailTextBox.Text = "پست الکترونیکی";
				confirmEmailTickPicturBox.Visible = false;
				Email = string.Empty;
			}
			else
			{
				if (Infrastructure.Utility.EmailChecker(email: emailTextBox.Text) == true)
				{
					if (EmailConfirmation(emailTextBox.Text) == true)
					{
						emailTextBox.ForeColor =
						Infrastructure.Utility.WhiteColor();
						emailPanel.BackColor =
							Infrastructure.Utility.WhiteColor();
						confirmEmailTickPicturBox.Image = Properties.Resources.Tik_True;
						confirmEmailTickPicturBox.Visible = true;
						Email = emailTextBox.Text;
					}
					else
					{
						Mbb.Windows.Forms.MessageBox.Show
							(text: "پست الکترونیک وارد شده در سیستم موجود می باشد. \n لطفا یک پست الکترونیکی دیگر وارد کنید.",
							caption: "خطای ورودی",
							icon: Mbb.Windows.Forms.MessageBoxIcon.Warning,
							button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
						emailTextBox.Focus();
					}
					return;
				}
				else
				{
					confirmEmailTickPicturBox.Image = Properties.Resources.Tik_False;
					confirmEmailTickPicturBox.Visible = true;
					Email = string.Empty;
					return;
				}
			}
		}
		#endregion /EmailTextBox_Leave 
		//-----
		#endregion / EmailTextBox

		#region PasswordTextBox
		//-----
		#region PasswordTextBox_Enter
		private void PasswordTextBox_Enter(object sender, System.EventArgs e)
		{
			passwordTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			passwordPanel.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(passwordTextBox.Text, "رمز عبور") == 0)
			{
				passwordTextBox.Clear();
				passwordTextBox.UseSystemPasswordChar = true;
			}
		}
		#endregion /PasswordTextBox_Enter

		#region PasswordTextBox_Leave
		private void PasswordTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(passwordTextBox.Text) || string.Compare(passwordTextBox.Text, "رمز عبور") == 0)
			{
				passwordTextBox.ForeColor =
					Infrastructure.Utility.DimGrayColor();
				passwordPanel.BackColor =
					Infrastructure.Utility.DimGrayColor();

				passwordTextBox.Text = "رمز عبور";
				passwordTextBox.UseSystemPasswordChar = false;

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

		#region ShowPasswordPicturBox1_MouseDown
		private void ShowPasswordPicturBox1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			passwordShowPicturBox1.Image =
				Properties.Resources.hide_512;

			if (string.Compare(passwordTextBox.Text, "رمز عبور") != 0)
			{
				passwordTextBox.UseSystemPasswordChar = false;
			}
		}
		#endregion /ShowPasswordPicturBox1_MouseDown

		#region ShowPasswordPicturBox1_MouseUp
		private void ShowPasswordPicturBox1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			passwordShowPicturBox1.Image =
			Properties.Resources.show_512;
			if (string.Compare(passwordTextBox.Text, "رمز عبور") != 0)
			{
				passwordTextBox.UseSystemPasswordChar = true;
			}
		}
		#endregion /ShowPasswordPicturBox1_MouseUp 
		//-----
		#endregion

		#region PasswordConfirmTextBox
		//-----
		#region PasswordConfirmTextBox_Enter
		private void PasswordConfirmTextBox_Enter(object sender, System.EventArgs e)
		{
			passwordConfirmTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			passwordConfirmPanel.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(passwordConfirmTextBox.Text, "تایید رمز عبور") == 0)
			{
				passwordConfirmTextBox.Clear();
				passwordConfirmTextBox.UseSystemPasswordChar = true;
			}
		}
		#endregion /PasswordConfirmTextBox_Enter

		#region PasswordConfirmTextBox_Leave
		private void PasswordConfirmTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(passwordConfirmTextBox.Text) || string.Compare(passwordConfirmTextBox.Text, "تایید رمز عبور") == 0)
			{
				passwordConfirmTextBox.ForeColor =
				Infrastructure.Utility.DimGrayColor();

				passwordConfirmPanel.BackColor =
					Infrastructure.Utility.DimGrayColor();
				passwordConfirmTextBox.Text = "تایید رمز عبور";

				passwordConfirmTextBox.UseSystemPasswordChar = false;
				PasswordConfirm = string.Empty;
			}
			else
			{
				passwordConfirmTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();

				passwordConfirmPanel.BackColor =
					Infrastructure.Utility.WhiteColor();
				PasswordConfirm = passwordConfirmTextBox.Text;
			}
		}
		#endregion /PasswordConfirmTextBox_Leave

		#region ShowPasswordPicturBox2_MouseDown
		private void ShowPasswordPicturBox2_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			passwordShowPicturBox2.Image =
				Properties.Resources.hide_512;

			if (string.Compare(passwordConfirmTextBox.Text, "تایید رمز عبور") != 0)
			{
				passwordConfirmTextBox.UseSystemPasswordChar = false;
			}
		}
		#endregion /ShowPasswordPicturBox2_MouseDown

		#region ShowPasswordPicturBox2_MouseUp
		private void ShowPasswordPicturBox2_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			passwordShowPicturBox2.Image =
				Properties.Resources.show_512;
			if (string.Compare(passwordConfirmTextBox.Text, "تایید رمز عبور") != 0)
			{
				passwordConfirmTextBox.UseSystemPasswordChar = true;
			}
		}
		#endregion /ShowPasswordPicturBox2_MouseUp 
		//-----
		#endregion /PasswordConfirmTextBox

		#region DescriptionTextBox
		//-----
		#region DescriptionTextBox_Enter
		private void DescriptionTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();

			descriptionTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			descriptionPanel.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(descriptionTextBox.Text, "توضیحات") == 0)
			{
				descriptionTextBox.Clear();
			}
		}

		#endregion /DescriptionTextBox_Enter

		#region DescriptionTextBox_KeyPress
		private void DescriptionTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianAndNumberTyping(e);
		}

		#endregion /DescriptionTextBox_KeyPress

		#region DescriptionTextBox_Leave
		private void DescriptionTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(descriptionTextBox.Text) || string.Compare(descriptionTextBox.Text, "توضیحات") == 0)
			{
				descriptionTextBox.ForeColor =
				Infrastructure.Utility.DimGrayColor();
				descriptionPanel.BackColor =
					Infrastructure.Utility.DimGrayColor();

				descriptionTextBox.Text = "توضیحات";

				Description = string.Empty;
			}
			else
			{
				descriptionTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
				descriptionPanel.BackColor =
					Infrastructure.Utility.WhiteColor();

				Description = descriptionTextBox.Text;
			}
		}

		#endregion /DescriptionTextBox_Leave 
		//------
		#endregion /DescriptionTextBox

		#region AddPictureLinkLabel_LinkClicked
		private void AddPictureLinkLabel_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			System.Windows.Forms.OpenFileDialog openFileDialog =
				new System.Windows.Forms.OpenFileDialog
				{
					Filter = "JPG (*.jpg)|*.jpg|" +
							"PNG (*.png)|*.png|" +
							"BMP (*.bmp)|*.bmp",
					Title = "Load user picture ",
				};

			if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				UserImage = openFileDialog.FileName;
				userImagePicturBox.BackgroundImage =
				System.Drawing.Image.FromFile(UserImage);
			}
			if (UserImage != string.Empty)
			{
				deleteImageButton.Visible = true;
			}
			else
			{
				deleteImageButton.Visible = false;
			}
		}

		#endregion /AddPictureLinkLabel_LinkClicked

		#region DeleteImageButton_Click
		private void DeleteImageButton_Click(object sender, System.EventArgs e)
		{
			UserImage = string.Empty;
			userImagePicturBox.BackgroundImage =
				Properties.Resources.user_1024;
			deleteImageButton.Visible = false;
		}

		#endregion /DeleteImageButton_Click

		#region FirstNameTextBox
		//-----
		#region FirstNameTextBox_Enter
		private void FirstNameTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();

			firstNameTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			firstNamePanel.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(firstNameTextBox.Text, "نام") == 0)
			{
				firstNameTextBox.Clear();
			}
		}

		#endregion /FirstNameTextBox_Enter

		#region FirstNameTextBox_KeyPress
		private void FirstNameTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
		}

		#endregion /FirstNameTextBox_KeyPress

		#region FirstNameTextBox_Leave
		private void FirstNameTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(firstNameTextBox.Text) || string.Compare(firstNameTextBox.Text, "نام") == 0)
			{
				firstNameTextBox.ForeColor =
				Infrastructure.Utility.DimGrayColor();
				firstNamePanel.BackColor =
					Infrastructure.Utility.DimGrayColor();

				firstNameTextBox.Text = "نام";
				FirstName = string.Empty;
			}
			else
			{
				firstNameTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
				firstNamePanel.BackColor =
					Infrastructure.Utility.WhiteColor();
				FirstName = firstNameTextBox.Text;
			}
		}

		#endregion /FirstNameTextBox_Leave 
		//-----
		#endregion /FirstNameTextBox

		#region LastNameTextBox
		//-----
		#region LastNameTextBox_Enter
		private void LastNameTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();

			lastNameTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			lastNamePanel.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(lastNameTextBox.Text, "نام خانوادگی") == 0)
			{
				lastNameTextBox.Clear();
			}
		}

		#endregion /LastNameTextBox_Enter

		#region LastNameTextBox_KeyPress
		private void LastNameTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
		}

		#endregion /LastNameTextBox_KeyPress

		#region LastNameTextBox_Leave
		private void LastNameTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(lastNameTextBox.Text) || string.Compare(lastNameTextBox.Text, "نام خانوادگی") == 0)
			{
				lastNameTextBox.ForeColor =
					Infrastructure.Utility.DimGrayColor();
				lastNamePanel.BackColor =
					Infrastructure.Utility.DimGrayColor();
				lastNameTextBox.Text = "نام خانوادگی";
				LastName = string.Empty;
			}
			else
			{
				lastNameTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				lastNamePanel.BackColor =
					Infrastructure.Utility.WhiteColor();

				LastName = lastNameTextBox.Text;
			}
		}

		#endregion /LastNameTextBox_Leave 
		//-----
		#endregion /LastNameTextBox

		#region TelTextBox
		//-----
		#region TelTextBox_Enter
		private void TelTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();

			telTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			telPanel.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(telTextBox.Text, "شماره تماس") == 0)
			{
				telTextBox.Clear();
			}
		}

		#endregion /TelTextBox_Enter

		#region TelTextBox_KeyPress
		private void TelTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}

		#endregion /TelTextBox_KeyPress

		#region TelTextBox_Leave
		private void TelTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(telTextBox.Text) || string.Compare(telTextBox.Text, "شماره تماس") == 0)
			{
				telTextBox.ForeColor =
					Infrastructure.Utility.DimGrayColor();
				telPanel.BackColor =
					Infrastructure.Utility.DimGrayColor();
				telTextBox.Text = "شماره تماس";
				Tel = string.Empty;
			}
			else
			{


				if (TelConfirmation(telTextBox.Text) == true)
				{
					telTextBox.ForeColor =
								Infrastructure.Utility.WhiteColor();
					telPanel.BackColor =
						Infrastructure.Utility.WhiteColor();

					if (telTextBox.Text.StartsWith("09"))
					{
						telTextBox.Text = telTextBox.Text.Insert(4, "-");
					}
					else
					{
						telTextBox.Text = telTextBox.Text.Insert(3, "-");
					}

					Tel = telTextBox.Text;
					return;
				}

				else
				{
					Mbb.Windows.Forms.MessageBox.Show
							(text: "شماره تماس وارد شده در سیستم موجود می باشد. \n لطفا یک شماره تماس دیگر وارد کنید.",
							caption: "خطای ورودی",
							icon: Mbb.Windows.Forms.MessageBoxIcon.Warning,
							button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
					telTextBox.Focus();
					return;
				}
			}
		}

		#endregion /TelTextBox_Leave 
		//-----
		#endregion TelTextBox

		#region NationalCodeTextBox
		//-----
		#region NationalCodeTextBox_Enter
		private void NationalCodeTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();

			nationalCodeTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			nationalCodePanel.BackColor =
				Infrastructure.Utility.LimeColor();
			nationalCodeTextBox.TextAlign =
				System.Windows.Forms.HorizontalAlignment.Right;

			if (string.Compare(nationalCodeTextBox.Text, "کد ملی") == 0)
			{
				nationalCodeTextBox.Clear();
			}
		}

		#endregion /NationalCodeTextBox_Enter

		#region NationalCodeTextBox_KeyPress
		private void NationalCodeTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}

		#endregion /NationalCodeTextBox_KeyPress

		#region NationalCodeTextBox_Leave
		private void NationalCodeTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(nationalCodeTextBox.Text) || string.Compare(nationalCodeTextBox.Text, "کد ملی") == 0)
			{
				nationalCodeTextBox.ForeColor =
					Infrastructure.Utility.DimGrayColor();
				nationalCodePanel.BackColor =
					Infrastructure.Utility.DimGrayColor();
				nationalCodeTextBox.TextAlign =
					System.Windows.Forms.HorizontalAlignment.Left;
				nationalCodeTextBox.Text = "کد ملی";
				NationalCode = string.Empty;
			}
			else
			{
				if (NationalCodeConfirmation(nationalCodeTextBox.Text) == true)
				{
					nationalCodeTextBox.ForeColor =
								Infrastructure.Utility.WhiteColor();
					nationalCodePanel.BackColor =
						Infrastructure.Utility.WhiteColor();

					nationalCodeTextBox.Text = nationalCodeTextBox.Text.Insert(3, "-").Insert(10, "-");
					NationalCode = nationalCodeTextBox.Text;
					return;
				}
				else
				{
					Mbb.Windows.Forms.MessageBox.Show
							(text: "کد ملی وارد شده در سیستم موجود می باشد. \n لطفا کد ملی صحیح را وارد کنید.",
							caption: "خطای ورودی",
							icon: Mbb.Windows.Forms.MessageBoxIcon.Warning,
							button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
					nationalCodeTextBox.Focus();
					return;
				}
			}
		}

		#endregion /NationalCodeTextBox_Leave
		//-----
		#endregion /NationalCodeTextBox

		#region AddressTextBox
		//-----
		#region AddressTextBox_Enter
		private void AddressTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();

			addressTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			addressPanel.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(addressTextBox.Text, "آدرس") == 0)
			{
				addressTextBox.Clear();
			}
		}

		#endregion /AddressTextBox_Enter

		#region AddressTextBox_KeyPress
		private void AddressTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianAndNumberTyping(e);
		}

		#endregion /AddressTextBox_KeyPress

		#region AddressTextBox_Leave
		private void AddressTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(addressTextBox.Text) || string.Compare(addressTextBox.Text, "آدرس") == 0)
			{
				addressTextBox.ForeColor =
					Infrastructure.Utility.DimGrayColor();
				addressPanel.BackColor =
					Infrastructure.Utility.DimGrayColor();
				addressTextBox.Text = "آدرس";
				Address = string.Empty;
			}
			else
			{
				if (AddressConfimation(addressTextBox.Text) == true)
				{
					addressTextBox.ForeColor =
								Infrastructure.Utility.WhiteColor();
					addressPanel.BackColor =
						Infrastructure.Utility.WhiteColor();

					Address = addressTextBox.Text;
					return;
				}
				else
				{
					Mbb.Windows.Forms.MessageBox.Show
							(text: "آدرس وارد شده در سیستم موجود می باشد. \n لطفا آدرس صحیح را وارد کنید.",
							caption: "خطای ورودی",
							icon: Mbb.Windows.Forms.MessageBoxIcon.Warning,
							button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
					addressTextBox.Focus();
					return;
				}
			}
		}

		#endregion /AddressTextBox_Leave
		//-----
		#endregion /AddressTextBox

		#region MarriedRadioButton_Click
		private void MarriedRadioButton_Click(object sender, System.EventArgs e)
		{
			Marride = string.Empty;
			Marride = "متاهل";
		}

		#endregion /MarriedRadioButton_Click

		#region SingleRadioButton_Click
		private void SingleRadioButton_Click(object sender, System.EventArgs e)
		{
			Marride = string.Empty;
			Marride = "مجرد";
		}

		#endregion /SingleRadioButton_Click

		#region ResetButton_Click
		private void ResetButton_Click(object sender, System.EventArgs e)
		{
			AllClear();
		}
		#endregion /ResetButton_Click

		#region SaveButton_Click
		private void SaveButton_Click(object sender, System.EventArgs e)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				string inputError = string.Empty;

				#region Validation
				if (string.IsNullOrEmpty(Username))
				{
					inputError =
						"مشخصه شناسه کاربری را تکمیل کنید!";
				}
				if (string.IsNullOrEmpty(Email))
				{
					if (string.IsNullOrEmpty(inputError) == false)
					{
						inputError +=
							System.Environment.NewLine;
					}
					inputError +=
						"مشخصه پست الکترونیکی را تکمیل کنید!";
				}
				if (string.IsNullOrEmpty(Password))
				{
					if (string.IsNullOrEmpty(inputError) == false)
					{
						inputError +=
							System.Environment.NewLine;
					}
					inputError +=
						"مشخصه رمز عبور را تکمیل کنید!";
				}
				if (string.IsNullOrEmpty(PasswordConfirm))
				{
					if (string.IsNullOrEmpty(inputError) == false)
					{
						inputError +=
							System.Environment.NewLine;
					}
					inputError +=
						"مشخصه تایید رمز عبور را تکمیل کنید!";
				}
				if (string.IsNullOrEmpty(UserImage))
				{
					if (string.IsNullOrEmpty(inputError) == false)
					{
						inputError +=
							System.Environment.NewLine;
					}
					inputError +=
						"مشخصه تصویر کاربری را تکمیل کنید!";
				}
				if (string.IsNullOrEmpty(FirstName))
				{
					if (string.IsNullOrEmpty(inputError) == false)
					{
						inputError +=
							System.Environment.NewLine;
					}
					inputError +=
						"مشخصه نام را تکمیل کنید!";
				}
				if (string.IsNullOrEmpty(LastName))
				{
					if (string.IsNullOrEmpty(inputError) == false)
					{
						inputError +=
							System.Environment.NewLine;
					}
					inputError +=
						"مشخصه نام خانوادگی را تکمیل کنید!";
				}
				if (string.IsNullOrEmpty(Tel))
				{
					if (string.IsNullOrEmpty(inputError) == false)
					{
						inputError +=
							System.Environment.NewLine;
					}
					inputError +=
						"مشخصه شماره تماس را تکمیل کنید!";
				}
				//------------------------------------------------
				if (string.IsNullOrEmpty(inputError) != true)
				{
					if (string.IsNullOrEmpty(Username))
					{
						usernameTextBox.Focus();
					}
					else if (string.IsNullOrEmpty(Email))
					{
						emailTextBox.Focus();
					}
					else if (string.IsNullOrEmpty(Password))
					{
						passwordTextBox.Focus();
					}
					else if (string.IsNullOrEmpty(PasswordConfirm))
					{
						passwordConfirmTextBox.Focus();
					}
					else if (string.IsNullOrEmpty(UserImage))
					{
						System.Windows.Forms.OpenFileDialog openFileDialog =
							new System.Windows.Forms.OpenFileDialog
							{
								Filter =
								"JPG (*.jpg)|*.jpg|" +
								"PNG (*.png)|*.png|" +
								"BMP (*.bmp)|*.bmp",
								Title = "Load user picture ",
							};

						if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
						{
							UserImage = openFileDialog.FileName;
							userImagePicturBox.BackgroundImage =
							System.Drawing.Image.FromFile(UserImage);
						}
						if (UserImage != string.Empty)
						{
							deleteImageButton.Visible = true;
						}
						else
						{
							deleteImageButton.Visible = false;
						}
					}
					else if (string.IsNullOrEmpty(FirstName))
					{
						firstNameTextBox.Focus();
					}
					else if (string.IsNullOrEmpty(LastName))
					{
						lastNameTextBox.Focus();
					}
					else if (string.IsNullOrEmpty(Tel))
					{
						telTextBox.Focus();
					}

					Mbb.Windows.Forms.MessageBox.Show
						(text: inputError,
						caption: "خطای ورودی",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
						button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
					return;
				}

				if (Infrastructure.Utility.PasswordSet(password: Password, passwordConfirm: PasswordConfirm) == false)
				{
					Mbb.Windows.Forms.MessageBox.Show
						(text: "عدم تطابق پسوردها",
						caption: "خطای ورودی",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
						button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
					passwordTextBox.Focus();
					return;
				}
				#endregion/Validation

				System.Windows.Forms.DialogResult dialogResult;
				string message = $"نام کاربری {Username} ذخیره گردد؟.";

				dialogResult = Mbb.Windows.Forms.MessageBox.Show
					(text: message,
						caption: "ذخیره اطلاعات",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Question,
						button: Mbb.Windows.Forms.MessageBoxButtons.YesNo);

				if (dialogResult == System.Windows.Forms.DialogResult.Yes)
				{
					Models.User username =
								dataBaseContext.Users
								.Where(current => string.Compare(current.Username, Username) == 0)
								.FirstOrDefault();

					if (username != null)
					{
						Mbb.Windows.Forms.MessageBox.Show
						(text: $"نام کاربری {Username} در سیستم موجود میباشد. لطفا از نام دیگری استفاده نمایید.",
						caption: "اطلاعات مشابه",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Information,
						button: Mbb.Windows.Forms.MessageBoxButtons.Ok);

						usernameTextBox.Focus();
						return;
					}
					else
					{
						RegisterDate = Infrastructure.Utility.PersianCalendar(System.DateTime.Now);
						RegisterTime = Infrastructure.Utility.ShowTime();

						username =
							new Models.User
							{
								IsActive = true,
								IsAdministrator = false,
								Username = Username,
								Email = Email,
								Password = Password,
								Description = Description,
								First_Name = FirstName,
								Last_Name = LastName,
								Telephone = Tel.Replace("-",""),
								National_Code = NationalCode,
								Marital_Status = Marride,
								Address = Address,
								Registration_Date = RegisterDate,
								Registration_Time = RegisterTime,

								User_Image = System.IO.File.ReadAllBytes(UserImage),
							};
						
						dataBaseContext.Users.Add(username);
						dataBaseContext.SaveChanges();
					}
				}
				else
				{
					return;
				}

				string successMessage =
					$"اطلاعات کاربر {Username} با موفقیت ذخیره گرید!";

				Infrastructure.Utility.WindowsNotification
					(message: successMessage,
					caption: Infrastructure.PopupNotificationForm.Caption.موفقیت,
					picture: UserImage);

				AllClear();
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
		#endregion /SaveButton_Click

		#region LoginButton_Click
		private void LoginButton_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.DialogResult dialogResult;

			if (string.IsNullOrEmpty(Username) != true ||
				string.IsNullOrEmpty(Email) != true ||
				string.IsNullOrEmpty(Password) != true ||
				string.IsNullOrEmpty(PasswordConfirm) != true ||
				string.IsNullOrEmpty(Description) != true ||
				string.IsNullOrEmpty(UserImage) != true ||
				string.IsNullOrEmpty(FirstName) != true ||
				string.IsNullOrEmpty(LastName) != true ||
				string.IsNullOrEmpty (Tel) != true||
				string.IsNullOrEmpty(NationalCode) != true ||
				string.IsNullOrEmpty(Address) != true)
			{
				dialogResult = Mbb.Windows.Forms.MessageBox.Show
					(text: "آیا از ادامه ثبت نام صرفه نظر کردید؟",
					caption: "انصراف از ثبت نام",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Question,
					button: Mbb.Windows.Forms.MessageBoxButtons.YesNo);

				if (dialogResult == System.Windows.Forms.DialogResult.Yes)
				{
					this.Hide();
					Program.LoginShow();
				}
			}
			else
			{
				this.Hide();
				Program.LoginShow();
				return;
			}

		}
		#endregion

		//-----End of coding line

		#region Functions
		//*****
		#region EmailConfirmation
		private bool EmailConfirmation(string email)
		{
			bool status;

			Models.DataBaseContext dataBaseContext = null;
			dataBaseContext =
					new Models.DataBaseContext();

			Models.User user =
				dataBaseContext.Users
				.Where(current => string.Compare(current.Email, email) == 0)
				.FirstOrDefault();

			if (user == null)
			{
				status = true;
			}
			else
			{
				status = false;
			}

			return status;

		}
		#endregion /EmailConfirmation

		#region TelConfirmation
		private static bool TelConfirmation(string tel)
		{
			bool status;

			Models.DataBaseContext dataBaseContext = null;
			dataBaseContext =
					new Models.DataBaseContext();

			Models.User user =
				dataBaseContext.Users
				.Where(current => string.Compare(current.Telephone, tel) == 0)
				.FirstOrDefault();

			if (user == null)
			{
				status = true;
			}
			else
			{
				status = false;
			}

			return status;
		}
		#endregion /TelConfirmation

		#region NationalCodeConfirmation
		private static bool NationalCodeConfirmation(string nationalCode)
		{
			bool status;

			Models.DataBaseContext dataBaseContext = null;
			dataBaseContext =
					new Models.DataBaseContext();

			Models.User user =
				dataBaseContext.Users
				.Where(current => string.Compare(current.National_Code, nationalCode) == 0)
				.FirstOrDefault();

			if (user == null)
			{
				status = true;
			}
			else
			{
				status = false;
			}

			return status;
		}
		#endregion /NationalCodeConfirmation

		#region AddressConfimation
		private static bool AddressConfimation(string address)
		{
			bool status;

			Models.DataBaseContext dataBaseContext = null;
			dataBaseContext =
					new Models.DataBaseContext();

			Models.User user =
				dataBaseContext.Users
				.Where(current => string.Compare(current.Address, address) == 0)
				.FirstOrDefault();

			if (user == null)
			{
				status = true;
			}
			else
			{
				status = false;
			}

			return status;
		}
		#endregion /AddressConfimation

		#region AllClear
		private void AllClear()
		{
			Username = string.Empty;
			usernameTextBox.Text =
				"شناسه کاربری";
			usernameTextBox.ForeColor =
				Infrastructure.Utility.DimGrayColor();
			usernameTextBox.Font =
				Infrastructure.Utility.IranSansFont(usernameTextBox.Font.Size);
			usernameTextBox.TextAlign =
				System.Windows.Forms.HorizontalAlignment.Left;
			usernamePanel.BackColor =
				Infrastructure.Utility.DimGrayColor();
			confirmUsernameTickPicturBox.Visible = false;

			Email = string.Empty;
			emailTextBox.Text =
				"پست الکترونیکی";
			emailTextBox.ForeColor =
				Infrastructure.Utility.DimGrayColor();
			emailTextBox.Font =
				Infrastructure.Utility.IranSansFont(emailTextBox.Font.Size);
			emailTextBox.TextAlign =
				System.Windows.Forms.HorizontalAlignment.Left;
			emailPanel.BackColor =
				Infrastructure.Utility.DimGrayColor();
			confirmEmailTickPicturBox.Visible = false;

			Password = string.Empty;
			passwordTextBox.Text =
				"رمز عبور";
			passwordTextBox.ForeColor =
				Infrastructure.Utility.DimGrayColor();
			passwordTextBox.TextAlign =
				System.Windows.Forms.HorizontalAlignment.Left;
			passwordPanel.BackColor =
				Infrastructure.Utility.DimGrayColor();
			passwordTextBox.UseSystemPasswordChar = false;

			PasswordConfirm = string.Empty;
			passwordConfirmTextBox.Text =
				"تایید رمز عبور";
			passwordConfirmTextBox.ForeColor =
				Infrastructure.Utility.DimGrayColor();
			passwordConfirmTextBox.TextAlign =
				System.Windows.Forms.HorizontalAlignment.Left;
			passwordConfirmPanel.BackColor =
				Infrastructure.Utility.DimGrayColor();
			passwordConfirmTextBox.UseSystemPasswordChar = false;

			UserImage = string.Empty;
			userImagePicturBox.BackgroundImage =
				Properties.Resources.user_1024;
			deleteImageButton.Visible = false;

			FirstName = string.Empty;
			firstNameTextBox.Text =
				"نام";
			firstNameTextBox.ForeColor =
				Infrastructure.Utility.DimGrayColor();
			firstNameTextBox.TextAlign =
				System.Windows.Forms.HorizontalAlignment.Left;
			firstNamePanel.BackColor =
				Infrastructure.Utility.DimGrayColor();

			LastName = string.Empty;
			lastNameTextBox.Text =
				"نام خانوادگی";
			lastNameTextBox.ForeColor =
				Infrastructure.Utility.DimGrayColor();
			lastNameTextBox.TextAlign =
				System.Windows.Forms.HorizontalAlignment.Left;
			lastNamePanel.BackColor =
				Infrastructure.Utility.DimGrayColor();

			Tel = string.Empty;
			telTextBox.Text =
				"نام خانوادگی";
			telTextBox.ForeColor =
				Infrastructure.Utility.DimGrayColor();
			telTextBox.TextAlign =
				System.Windows.Forms.HorizontalAlignment.Left;
			telPanel.BackColor =
				Infrastructure.Utility.DimGrayColor();

			NationalCode = string.Empty;
			nationalCodeTextBox.Text =
				"نام خانوادگی";
			nationalCodeTextBox.ForeColor =
				Infrastructure.Utility.DimGrayColor();
			nationalCodeTextBox.TextAlign =
				System.Windows.Forms.HorizontalAlignment.Left;
			nationalCodePanel.BackColor =
				Infrastructure.Utility.DimGrayColor();

			Address = string.Empty;
			addressTextBox.Text =
				"نام خانوادگی";
			addressTextBox.ForeColor =
				Infrastructure.Utility.DimGrayColor();
			addressTextBox.TextAlign =
				System.Windows.Forms.HorizontalAlignment.Left;
			addressPanel.BackColor =
				Infrastructure.Utility.DimGrayColor();
		}
		#endregion /AllClear
		//*****
		#endregion /Functions
	}
}
