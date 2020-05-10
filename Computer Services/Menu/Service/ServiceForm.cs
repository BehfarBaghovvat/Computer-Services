using System.Linq;

namespace ComputerServices.Menu.Service
{
	public partial class ServiceForm : Infrastructure.BaseForm
	{
		public ServiceForm()
		{
			InitializeComponent();
		}

		#region Properties
		public string RegisterDate { get; set; }
		public string InvoiceSerial { get; set; }
		public string ClientName { get; set; }
		public string ServiceType { get; set; }
		public string Description { get; set; }
		public string SearchInvoiceSerial { get; set; }
		public string RequestStatus { get; set; }
		#endregion /Properties

		//-----The beginning of the coding line.

		#region ServiceForm_Load
		private void ServiceForm_Load(object sender, System.EventArgs e)
		{
			OrderLoader();
			RegisterDate = Infrastructure.Utility.PersianCalendar(System.DateTime.Now);
			dateLabel.Text = RegisterDate;
			RequestStatus = "در حال بررسی";
		}
		#endregion /ServiceForm_Load

		


























		#region InvoiceNumberDeletedButton_Click
		private void InvoiceNumberDeletedButton_Click(object sender, System.EventArgs e)
		{
			InvoiceSerial = string.Empty;
			invoiceSerialLabel.Text = "سریال فاکتور";
			invoiceNumberDeletedButton.Visible = false;
			confirmStatusPicturBox.Visible = false;
		}
		#endregion /InvoiceNumberDeletedButton_Click

		#region NewCodeButton_Click
		private void NewCodeButton_Click(object sender, System.EventArgs e)
		{
			invoiceSerialLabel.Text =GeneratInvoiceNumber();
			InvoiceSerial = GeneratInvoiceNumber();
			invoiceNumberDeletedButton.Visible = true;
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();
				Models.ServiceComputer serviceComputer =
					dataBaseContext.ServiceComputers
					.Where(current => string.Compare(current.Invoice_Serial, InvoiceSerial) == 0)
					.FirstOrDefault();
				if (serviceComputer != null)
				{
					confirmStatusPicturBox.Visible = true;
					InvoiceSerial = string.Empty;
					confirmStatusPicturBox.Image =
						Properties.Resources.Tik_False;
					saveOrderButton.Enabled = false;
					invoicePrintButton.Enabled = false;
				}
				else
				{
					confirmStatusPicturBox.Visible = true;
					confirmStatusPicturBox.Image =
						Properties.Resources.Tik_True;
					saveOrderButton.Enabled = true;
					invoicePrintButton.Enabled = true;
				}
			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
			}
		}
		#endregion /NewCodeButton_Click

		#region InvoiceNumberLabel_TextChanged
		private void InvoiceNumberLabel_TextChanged(object sender, System.EventArgs e)
		{
			if (string.Compare(invoiceSerialLabel.Text, "سریال فاکتور") == 0)
			{
				invoiceSerialLabel.ForeColor =
					Infrastructure.Utility.WhiteColor();
				InvoiceSerial = string.Empty;
				return;
			}
			else
			{
				invoiceSerialLabel.ForeColor =
					Infrastructure.Utility.WhiteColor();
			}
		}
		#endregion /InvoiceNumberLabel_TextChanged

		#region ClientNameTextBox
		//-----
		#region ClientNameTextBox_Enter
		private void ClientNameTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();

			clientNameTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			clientNamePanel.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(clientNameTextBox.Text, "نام مشتری") == 0)
			{
				clientNameTextBox.Clear();
			}
		}
		#endregion /ClientNameTextBox_Enter

		#region ClientNameTextBox_KeyPress
		private void ClientNameTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
		}
		#endregion /ClientNameTextBox_KeyPress

		#region ClientNameTextBox_Leave
		private void ClientNameTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(clientNameTextBox.Text) || string.Compare(clientNameTextBox.Text, "نام مشتری") == 0)
			{
				clientNameTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				clientNamePanel.BackColor =
					Infrastructure.Utility.PurpleColor();
				clientNameTextBox.Text = "نام مشتری";
				ClientName = string.Empty;
			}
			else
			{
				clientNameTextBox.ForeColor =
					Infrastructure.Utility.PurpleColor();
				clientNamePanel.BackColor =
					Infrastructure.Utility.PurpleColor();
				ClientName = clientNameTextBox.Text;
			}
		}
		#endregion /ClientNameTextBox_Leave 
		//-----
		#endregion /ClientNameTextBox

		#region ServiceTypeComboBox_SelectedIndexChanged
		private void ServiceTypeComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (serviceTypeComboBox.SelectedIndex == 11)
			{
				serviceTypeComboBox.ForeColor =
					Infrastructure.Utility.DimGrayColor();
				ServiceType = string.Empty;
				return;
			}
			else
			{
				ServiceType = serviceTypeComboBox.Text;
				serviceTypeComboBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
			}
		}
		#endregion /ServiceTypeComboBox_SelectedIndexChanged

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

			if (string.Compare(descriptionTextBox.Text, "توضیحات مشتری") == 0)
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
			if (string.IsNullOrWhiteSpace(descriptionTextBox.Text) || string.Compare(descriptionTextBox.Text, "توضیحات مشتری") == 0)
			{
				descriptionTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				descriptionPanel.BackColor =
					Infrastructure.Utility.PurpleColor();
				descriptionTextBox.Text = "توضیحات مشتری";
				Description = string.Empty;
			}
			else
			{
				descriptionTextBox.ForeColor =
					Infrastructure.Utility.PurpleColor();
				descriptionPanel.BackColor =
					Infrastructure.Utility.PurpleColor();
				Description = descriptionTextBox.Text;
			}
		}
		#endregion /DescriptionTextBox_Leave
		//-----
		#endregion /DescriptionTextBox

		#region InvoicePrintButton_Click
		private void InvoicePrintButton_Click(object sender, System.EventArgs e)
		{
		}
		#endregion /InvoicePrintButton_Click

		#region SaveOrderButton_Click
		private void SaveOrderButton_Click(object sender, System.EventArgs e)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				string errorMessage = string.Empty;

				if (string.IsNullOrWhiteSpace(clientNameTextBox.Text))
				{
					errorMessage =
						"لطفا نام مشتری را وارد نمایید!";
				}
				if (serviceTypeComboBox.SelectedIndex == 11)
				{
					if (string.IsNullOrEmpty(errorMessage) == false)
					{
						errorMessage +=
							System.Environment.NewLine;
					}
					errorMessage +=
						"لطفا نوع خدمات را تعیین نمایید!";
				}

				if (string.IsNullOrEmpty(errorMessage) != true)
				{
					if (string.IsNullOrWhiteSpace(clientNameTextBox.Text) || string.Compare(clientNameTextBox.Text, "نام مشتری") == 0)
					{
						clientNameTextBox.Focus();
					}
					else if (serviceTypeComboBox.SelectedIndex == 11)
					{
						serviceTypeComboBox.Focus();
					}

					Mbb.Windows.Forms.MessageBox.Show
						(text: errorMessage,
						caption: "خطای ورودی",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
						button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
					return;
				}

				Models.ServiceComputer serviceComputer =
					new Models.ServiceComputer
					{
						Register_Date = RegisterDate,
						Invoice_Serial = InvoiceSerial,
						Client_Name = ClientName,
						Service_Type = ServiceType,
						Description = Description,
						Request_Status = RequestStatus,
					};

				dataBaseContext.ServiceComputers.Add(serviceComputer);
				dataBaseContext.SaveChanges();

				string successMessage =
					$"سفارش با کد {InvoiceSerial}" + "\n" + "با موفقیت ثبت گردید!";

				Infrastructure.Utility.WindowsNotification
					(message: successMessage,
					caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);

				OrderLoader();
				Clear();
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
		#endregion /SaveOrderButton_Click
























		//-----End of coding line

		#region Functions
		//------
		#region InvoiceNumber
		/// <summary>
		/// تابعی که یه تعداد 7 کاراکتر حروف و عدد به صورت تصادوفی
		///  و ترکیبی ایجاد کرده و به ما بر میگرداند.
		/// </summary>
		/// <returns>ممبر letter که حاصل دریافت ترکیبی عدد و حرف میباشد نتیجه این تابع میباشد. </returns>
		private string GeneratInvoiceNumber()
		{
			int count, number1, number2;

			string[] text = new string[3];
			string letter = string.Empty;

			System.Random randomCount = new System.Random();
			System.Random randomNumber = new System.Random();
			System.Random random = new System.Random();

			for (int i= 1; i <= 20; i++)
			{
				count = randomCount.Next(0,2);

				if (count == 0)
				{
						number1 = randomNumber.Next(0, 10);
						letter += number1.ToString();
				}
				else if (count == 1)
				{
					for (int k = 0; k < 1; k++)
					{
						number2 = random.Next(65, 91);
						text[k] = System.Convert.ToChar(number2).ToString();
						letter += text[k];
					}
				}
			}

			for (int i = 1; i < 21; i++)
			{
				if (i % 6 == 0)
				{
					letter = letter.Insert(i-1, "-");
				}
			}

			return letter;
		}

		#endregion /InvoiceNumber

		#region OrderLoader
		private void OrderLoader()
		{
			Models.DataBaseContext databaseContext = null;
			try
			{
				databaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.ServiceComputer> serviceComputers = null;

				serviceComputers =
					databaseContext.ServiceComputers
					.OrderBy(current => current.Register_Date)
					.ToList();

				computerServiceDataGridView.DataSource = serviceComputers;
			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					databaseContext = null;
				}
			}
		}
		#endregion /OrderLoader

		#region SearchInvoce
		private void SearchInvoce(string invoceSerial)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.ServiceComputer> serviceComputers = null;

				if (string.IsNullOrEmpty(invoceSerial))
				{
					serviceComputers =
						dataBaseContext.ServiceComputers
						.OrderBy(current => current.Register_Date)
						.ToList();
				}
				else
				{
					serviceComputers =
						dataBaseContext.ServiceComputers
						.Where(current => current.Invoice_Serial.Contains(invoceSerial))
						.OrderBy(current => current.Register_Date)
						.ToList();
				}

				computerServiceDataGridView.DataSource = serviceComputers;

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
		#endregion /SearchInvoce

		#region Clear
		private void Clear()
		{
			invoiceNumberDeletedButton.Visible = false;
			confirmStatusPicturBox.Visible = false;
			//-----
			invoiceSerialLabel.Text = "سریال فاکتور";
			invoiceSerialLabel.ForeColor =
				Infrastructure.Utility.WhiteColor();
			invoiceSerialPanel.BackColor =
				Infrastructure.Utility.PurpleColor();
			InvoiceSerial = string.Empty;
			//-----
			clientNameTextBox.Text = "نام مشتری";
			clientNameTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
			clientNamePanel.BackColor =
				Infrastructure.Utility.PurpleColor();
			ClientName = string.Empty;
			//-----
			serviceTypeComboBox.Text = "نوع خدمات را تعیین کنید...";
			serviceTypeComboBox.ForeColor =
				Infrastructure.Utility.DimGrayColor();
			serviceTypePanel.BackColor =
				Infrastructure.Utility.PurpleColor();
			ServiceType = string.Empty;
			//------
			descriptionTextBox.Text = "توضیحات مشتری";
			descriptionTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
			descriptionPanel.BackColor =
				Infrastructure.Utility.PurpleColor();
			Description = string.Empty;
			//-----
			invoicePrintButton.Enabled = false;
			saveOrderButton.Enabled = false;
		}
		#endregion /Clear

		//-----
		#endregion /Functions

		#region SearchInvoiceSerialTextBox
		//-----
		#region SearchInvoiceSerialTextBox_Enter
		private void SearchInvoiceSerialTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.EnglishLanguage();
			searchInvoiceSerialTextBox.Select(0,0);
		}
		#endregion /SearchInvoiceSerialTextBox_Enter

		#region SearchInvoiceSerialTextBox_KeyPress
		private void SearchInvoiceSerialTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.EnglishAndNumberTyping(e);

			if (string.Compare(searchInvoiceSerialTextBox.Text,"سریال فاکتور را وارد نمایید...")==0)
			{
				searchInvoiceSerialTextBox.Clear();
			}
		}
		#endregion /SearchInvoiceSerialTextBox_KeyPress

		#region SearchInvoiceSerialTextBox_Leave
		private void SearchInvoiceSerialTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(searchInvoiceSerialTextBox.Text)||string.Compare(searchInvoiceSerialTextBox.Text,"سریال فاکتور را وارد نمایید...")==0)
			{
				searchInvoiceSerialTextBox.Font =
					Infrastructure.Utility.IranSansFont(searchInvoiceSerialTextBox.Font.Size);
				searchInvoiceSerialTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				searchInvoiceSerialPanel.BackColor =
					Infrastructure.Utility.PurpleColor();

				searchInvoiceSerialTextBox.Text = "سریال فاکتور را وارد نمایید...";
				SearchInvoiceSerial = string.Empty;
			}
		}
		#endregion /SearchInvoiceSerialTextBox_Leave

		#region SearchInvoiceSerialTextBox_TextChanged
		private void SearchInvoiceSerialTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(searchInvoiceSerialTextBox.Text))
			{
				searchInvoiceSerialTextBox.Font =
					Infrastructure.Utility.IranSansFont(searchInvoiceSerialTextBox.Font.Size);
				searchInvoiceSerialTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				searchInvoiceSerialPanel.BackColor =
					Infrastructure.Utility.PurpleColor();

				searchInvoiceSerialTextBox.Text = "سریال فاکتور را وارد نمایید...";
				SearchInvoiceSerial = string.Empty;
			}
			else
			{
				searchInvoiceSerialTextBox.Font =
					Infrastructure.Utility.CenturyGothicFont(searchInvoiceSerialTextBox.Font.Size);
				searchInvoiceSerialTextBox.ForeColor =
					Infrastructure.Utility.LimeColor();
				searchInvoiceSerialPanel.BackColor =
					Infrastructure.Utility.LimeColor();

				SearchInvoiceSerial = searchInvoiceSerialTextBox.Text;

				SearchInvoce(SearchInvoiceSerial);
			}
			
			

		}
		#endregion /SearchInvoiceSerialTextBox_TextChanged
		//-----
		#endregion /SearchInvoiceSerialTextBox
	}
}
