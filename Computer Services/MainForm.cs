using BunifuAnimatorNS;
using System.Linq;

namespace ComputerServices
{
	public partial class MainForm : Infrastructure.BaseForm
	{
		public MainForm()
		{
			InitializeComponent();
		}

		[System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

		//----------------------------------------------------------------------------------------------------------------------------------------------------------------------
		#region Properties
		public int LX { get; set; }
		public int LY { get; set; }
		public bool MaximumSize { get; set; }
		public bool MinimumSize { get; set; }
		public bool ComputerServiceButton { get; set; }
		public bool CellPhoneServiceButton { get; set; }
		public bool Service { get; set; }
		public bool Client { get; set; }
		public bool Dashboard { get; set; }
		public bool Product { get; set; }
		public bool Deliver { get; set; }
		public bool AdminTools { get; set; }
		public bool CafeNet { get; set; }

		#region Properties_Service
		public bool ComputerService { get; set; }
		public bool CellPhoneService { get; set; }
		public string RegisterDate { get; set; }
		public string InvoiceSerial { get; set; }
		public string ClientName { get; set; }
		public string ServiceType { get; set; }
		public string Description { get; set; }
		public string SearchInvoiceSerial { get; set; }
		public string RequestStatus { get; set; }

		//------------------------Cellphone Hardware-----------------------------
		public bool LCDService { get; set; }
		public bool RAMService { get; set; }
		public bool ROMService { get; set; }
		public bool BatteryService { get; set; }
		public bool BoardService { get; set; }
		public bool CameraService { get; set; }
		public bool OtherHardwareService { get; set; }

		//------------------------Cellphone Software-----------------------------
		public bool SamsungID { get; set; }
		public bool AppleID { get; set; }
		public bool OS_Android { get; set; }
		public bool SetupAPK { get; set; }
		public bool OS_IOS { get; set; }
		public bool SetupIPA { get; set; }
		public bool ResetFactory { get; set; }
		public bool OtherSoftwaareService { get; set; }
		#endregion /Properties_Service

		#endregion /Properties

		//-----The beginning of the coding line.

		#region MainForm_Load
		private void MainForm_Load(object sender, System.EventArgs e)
		{
			FormLoad();
		}
		#endregion /MainForm_Load

		#region MainForm_SizeChanged
		private void MainForm_SizeChanged(object sender, System.EventArgs e)
		{
			mainPanel.Width = this.Width - 250;
			mainPanel.Height = this.Height - 150;
		}
		#endregion /MainForm_SizeChanged

		#region CloseButton_Click
		private void CloseButton_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.DialogResult dialogResult = 
				Mbb.Windows.Forms.MessageBox.Show(text: "قصد خروج دارید؟", caption: "خروج از برنامه", icon: Mbb.Windows.Forms.MessageBoxIcon.Question, button: Mbb.Windows.Forms.MessageBoxButtons.YesNo);

			if (dialogResult == System.Windows.Forms.DialogResult.Yes)
			{
				System.Windows.Forms.Application.Exit();
			}
		}
		#endregion /CloseButton_Click

		#region MaximizeButton_Click
		private void MaximizeButton_Click(object sender, System.EventArgs e)
		{
			MaximumSize = true;
			MinimumSize = false;
			LX = Location.X;
			LY = Location.Y;
			this.Size = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Size;
			this.Location = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Location;

			maximizeButton.SendToBack();
			restoreButton.BringToFront();
		}
		#endregion /MaximizeButton_Click

		#region RestoreButton_Click
		private void RestoreButton_Click(object sender, System.EventArgs e)
		{
			MinimumSize = true;
			MaximumSize = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Size = new System.Drawing.Size(1400, 900);
			this.Location = new System.Drawing.Point(LX, LY);
			restoreButton.SendToBack();
			maximizeButton.BringToFront();
		}
		#endregion /RestoreButton_Click

		#region MinimizeButton_Click
		private void MinimizeButton_Click(object sender, System.EventArgs e)
		{
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
		}
		#endregion /MinimizeButton_Click

		#region MainPanel_SizeChanged
		private void MainPanel_SizeChanged(object sender, System.EventArgs e)
		{
			if (Service == true)
			{
				servicePanel.Width = mainPanel.Size.Width - 50;
				servicePanel.Height = mainPanel.Size.Height - 50;
				servicePanel.Location = new System.Drawing.Point(x: 25, y: 25);
			}
			if (Client == true)
			{
				
			}
			if (Dashboard == true)
			{
				
			}
			if (Product == true)
			{
				
			}
			if (Deliver == true)
			{
				
			}
			if (AdminTools == true)
			{
				
			}
			if (CafeNet == true)
			{
				
			}

		}
		#endregion /MainPanel_SizeChanged

		#region FirstSizeButton_Click
		private void FirstSizeButton_Click(object sender, System.EventArgs e)
		{
			if (rightSidePanel.Width == 250)
			{
				menuPanel.Visible = false;
				
				logputButton.Location = new System.Drawing.Point(x: 182, y: 756);
				menuPanel.Width = 50;
				rightSidePanel.Width = 80;
				menuTransition1.Show(menuPanel);
			}
			else
			{
				menuPanel.Visible = false;
				
				rightSidePanel.Width = 250;
				menuPanel.Width = 220;
				logputButton.Location = new System.Drawing.Point(x: 150, y: 789);
				menuTransition2.Show(menuPanel);
			}
		}
		#endregion /FirstSizeButton_Click

		#region HomeButton_Click
		private void HomeButton_Click(object sender, System.EventArgs e)
		{
			focusPanel.Height = homeButton.Height;
			focusPanel.Top = homeButton.Top;

			mainPanel.Controls.Clear();

			Service = false;
			Client = false;
			Dashboard = false;
			Product = false;
			Deliver = false;
			AdminTools = false;
			CafeNet = false;
		}
		#endregion /HomeButton_Click

		#region Service

		#region ServicesButton_Click
		private void ServicesButton_Click(object sender, System.EventArgs e)
		{
			this.mainPanel.Controls.Clear();
			servicePanel.Visible = false;
			this.mainPanel.Controls.Add(servicePanel);
			showPageTransition1.Show(servicePanel);

			RegisterDate = Infrastructure.Utility.PersianCalendar(System.DateTime.Now);
			registerDateLabel1.Text = RegisterDate;

			focusPanel.Height = servicesButton.Height;
			focusPanel.Top = servicesButton.Top;
			ComputerServiceButton = true;
			CellPhoneServiceButton = false;

			currentPageLabel.Text = servicesButton.Text;
			iconPagePicturBox.Image = Properties.Resources.computer_support_512;

			Service = true;
			Client = false;
			Dashboard = false;
			Product = false;
			Deliver = false;
			AdminTools = false;
			CafeNet = false;
		}
		#endregion /ServicesButton_Click

		#region ServicePanel_SizeChanged
		private void ServicePanel_SizeChanged(object sender, System.EventArgs e)
		{
			if (servicePanel.Width == 1790)
			{
				if (ComputerServiceButton == true)
				{
					currentPagePanel.Location = new System.Drawing.Point(x: 1780, y: 0);
				}
				else
				{
					currentPagePanel.Location = new System.Drawing.Point(x: 885, y: 0);
				}
				computerServiceButton.Size = new System.Drawing.Size(width: 895, height: 50);
				cellphoneServiceButton.Size = new System.Drawing.Size(width: 895, height: 50);

				computerServiceButton.Location = new System.Drawing.Point(x: 895, y: 0);
				return;
			}
			if (servicePanel.Width == 1620)
			{
				if (ComputerServiceButton == true)
				{
					currentPagePanel.Location = new System.Drawing.Point(x: 1610, y: 0);
				}
				else
				{
					currentPagePanel.Location = new System.Drawing.Point(x: 800, y: 0);
				}
				computerServiceButton.Size = new System.Drawing.Size(width: 810, height: 50);
				cellphoneServiceButton.Size = new System.Drawing.Size(width: 810, height: 50);

				computerServiceButton.Location = new System.Drawing.Point(x: 810, y: 0);
				return;
			}
			if (servicePanel.Width == 1270)
			{

				if (ComputerServiceButton == true)
				{
					currentPagePanel.Location = new System.Drawing.Point(x: 1260, y: 0);
				}
				else if (ComputerServiceButton == false)
				{
					currentPagePanel.Location = new System.Drawing.Point(x: 625, y: 0);
				}
				computerServiceButton.Size = new System.Drawing.Size(width: 635, height: 50);
				cellphoneServiceButton.Size = new System.Drawing.Size(width: 635, height: 50);

				computerServiceButton.Location = new System.Drawing.Point(x: 635, y: 0);
				return;
			}
			if (servicePanel.Width == 1100)
			{
				if (ComputerServiceButton == true)
				{
					currentPagePanel.Location = new System.Drawing.Point(x: 1090, y: 0);
				}
				else if (ComputerServiceButton == false)
				{
					currentPagePanel.Location = new System.Drawing.Point(x: 540, y: 0);
				}
				computerServiceButton.Size = new System.Drawing.Size(width: 550, height: 50);
				cellphoneServiceButton.Size = new System.Drawing.Size(width: 550, height: 50);

				computerServiceButton.Location = new System.Drawing.Point(x: 550, y: 0);
				return;
			}
		}
		#endregion /ServicePanel_SizeChanged 

		#region ComputerService
		//===============================================================================================
		#region ComputerServiceButton_Click
		private void ComputerServiceButton_Click(object sender, System.EventArgs e)
		{
			mainElipse.TargetControl = computerServicePanel;
			mainElipse.ElipseRadius = 25;
			mainElipse.TargetControl = computerServiceDataGridView;
			mainElipse.ElipseRadius = 25;

			RegisterDate = Infrastructure.Utility.PersianCalendar(System.DateTime.Now);
			registerDateLabel1.Text = RegisterDate;

			ComputerServiceButton = true;
			CellPhoneServiceButton = false;
			if (servicePanel.Width == 1100)
			{
				if (ComputerServiceButton == true)
				{
					currentPagePanel.Location = new System.Drawing.Point(x: 1090, y: 0);
				}
			}
			if (servicePanel.Width == 1270)
			{
				if (ComputerServiceButton == true)
				{
					currentPagePanel.Location = new System.Drawing.Point(x: 1260, y: 0);
				}
			}
			if (servicePanel.Width == 1620)
			{
				if (ComputerServiceButton == true)
				{
					currentPagePanel.Location = new System.Drawing.Point(x: 1610, y: 0);
				}
			}
			if (servicePanel.Width == 1790)
			{
				if (ComputerServiceButton == true)
				{
					currentPagePanel.Location = new System.Drawing.Point(x: 1780, y: 0);
				}
			}

			computerServicePanel.Visible = true;
			cellphoneServicePanel.Visible = false;
		}
		#endregion /ComputerServiceButton_Click

		#region SearchInvoiceSerialTextBox1
		//-----
		#region SearchInvoiceSerialTextBox1_Enter
		private void SearchInvoiceSerialTextBox1_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.EnglishLanguage();
			searchInvoiceSerialTextBox1.Select(0, 0);
		}
		#endregion /SearchInvoiceSerialTextBox1_Enter

		#region SearchInvoiceSerialTextBox1_KeyPress
		private void SearchInvoiceSerialTextBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.EnglishAndNumberTyping(e);

			if (string.Compare(searchInvoiceSerialTextBox1.Text, "سریال فاکتور را وارد نمایید...") == 0)
			{
				searchInvoiceSerialTextBox1.Clear();
			}
		}
		#endregion /SearchInvoiceSerialTextBox1_KeyPress

		#region SearchInvoiceSerialTextBox1_Leave
		private void SearchInvoiceSerialTextBox1_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(searchInvoiceSerialTextBox1.Text) || string.Compare(searchInvoiceSerialTextBox1.Text, "سریال فاکتور را وارد نمایید...") == 0)
			{
				searchInvoiceSerialTextBox1.Font =
					Infrastructure.Utility.IranSansFont(searchInvoiceSerialTextBox1.Font.Size);
				searchInvoiceSerialTextBox1.ForeColor =
					Infrastructure.Utility.WhiteColor();
				searchInvoiceSerialPanel1.BackColor =
					Infrastructure.Utility.PurpleColor();

				searchInvoiceSerialTextBox1.Text = "سریال فاکتور را وارد نمایید...";
				SearchInvoiceSerial = string.Empty;
			}
		}
		#endregion /SearchInvoiceSerialTextBox1_Leave

		#region SearchInvoiceSerialTextBox1_TextChanged
		private void SearchInvoiceSerialTextBox1_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(searchInvoiceSerialTextBox1.Text))
			{
				SearchInvoiceSerial = string.Empty;
				return;
			}
			else
			{
				searchInvoiceSerialTextBox1.Font =
					Infrastructure.Utility.CenturyGothicFont(searchInvoiceSerialTextBox1.Font.Size);
				searchInvoiceSerialTextBox1.ForeColor =
					Infrastructure.Utility.LimeColor();
				searchInvoiceSerialPanel1.BackColor =
					Infrastructure.Utility.LimeColor();

				SearchInvoiceSerial = searchInvoiceSerialTextBox1.Text;

				SearchComputerServiceInvoce(SearchInvoiceSerial);
			}
		}
		#endregion /SearchInvoiceSerialTextBox1_TextChanged
		//-----
		#endregion /SearchInvoiceSerialTextBox1		

		#region InvoiceSerialDeleteButton1_Click
		private void InvoiceSerialDeleteButton1_Click(object sender, System.EventArgs e)
		{
			InvoiceSerial = string.Empty;
			invoiceSerialLabel1.Text = "سریال فاکتور";
			invoiceSerialDeleteButton1.Visible = false;
			confirmStatusPicturBox1.Visible = false;
			saveOrderButton1.Enabled = false;
			allClearButton1.Visible = false;
		}
		#endregion /InvoiceSerialDeleteButton1_Click

		#region NewSerialButton1_Click
		private void NewSerialButton1_Click(object sender, System.EventArgs e)
		{
			invoiceSerialLabel1.Text = GeneratInvoiceNumber();
			InvoiceSerial = GeneratInvoiceNumber();
			invoiceSerialDeleteButton1.Visible = true;
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();
				Models.ComputerService computerService =
					dataBaseContext.ComputerServices
					.Where(current => string.Compare(current.Invoice_Serial, InvoiceSerial) == 0)
					.FirstOrDefault();
				if (computerService != null)
				{
					confirmStatusPicturBox1.Visible = true;
					InvoiceSerial = string.Empty;
					confirmStatusPicturBox1.Image =
						ComputerServices.Properties.Resources.Tik_False;
					saveOrderButton1.Enabled = false;
					allClearButton1.Visible = false;
				}
				else
				{
					confirmStatusPicturBox1.Visible = true;
					confirmStatusPicturBox1.Image =
						ComputerServices.Properties.Resources.Tik_True;
					saveOrderButton1.Enabled = true;
					allClearButton1.Visible = true;
				}
			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
			}
			finally
			{
				dataBaseContext.Dispose();
				dataBaseContext = null;
			}
		}
		#endregion /NewSerialButton1_Click

		#region InvoiceSerialLabel1_TextChanged
		private void InvoiceSerialLabel1_TextChanged(object sender, System.EventArgs e)
		{
			if (string.Compare(invoiceSerialLabel1.Text, "سریال فاکتور") == 0)
			{
				invoiceSerialLabel1.ForeColor =
					Infrastructure.Utility.WhiteColor();
				InvoiceSerial = string.Empty;
				return;
			}
			else
			{
				invoiceSerialLabel1.ForeColor =
					Infrastructure.Utility.PurpleColor();
			}
		}
		#endregion /InvoiceSerialLabel1_TextChanged

		#region ClientNameTextBox1
		//-----
		#region ClientNameTextBox1_Enter
		private void ClientNameTextBox1_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();

			clientNameTextBox1.ForeColor =
				Infrastructure.Utility.LimeColor();
			clientNamePanel1.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(clientNameTextBox1.Text, "نام مشتری") == 0)
			{
				clientNameTextBox1.Clear();
			}
		}
		#endregion /ClientNameTextBox1_Enter

		#region ClientNameTextBox1_KeyPress
		private void ClientNameTextBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
		}
		#endregion /ClientNameTextBox1_KeyPress

		#region ClientNameTextBox1_Leave
		private void ClientNameTextBox1_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(clientNameTextBox1.Text) || string.Compare(clientNameTextBox1.Text, "نام مشتری") == 0)
			{
				clientNameTextBox1.ForeColor =
					Infrastructure.Utility.WhiteColor();
				clientNamePanel1.BackColor =
					Infrastructure.Utility.PurpleColor();
				clientNameTextBox1.Text = "نام مشتری";
				ClientName = string.Empty;
			}
			else
			{
				clientNameTextBox1.ForeColor =
					Infrastructure.Utility.PurpleColor();
				clientNamePanel1.BackColor =
					Infrastructure.Utility.PurpleColor();
				ClientName = clientNameTextBox1.Text;
			}
		}
		#endregion /ClientNameTextBox1_Leave
		//-----
		#endregion /ClientNameTextBox1

		#region AssemblePCButton_Click
		private void AssemblePCButton_Click(object sender, System.EventArgs e)
		{

		}
		#endregion /AssemblePCButton_Click

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

		#region DescriptionTextBox1
		//-----
		#region DescriptionTextBox1_Enter
		private void DescriptionTextBox1_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();

			descriptionTextBox1.ForeColor =
				Infrastructure.Utility.LimeColor();
			descriptionPanel1.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(descriptionTextBox1.Text, "توضیحات") == 0)
			{
				descriptionTextBox1.Clear();
			}
		}
		#endregion /DescriptionTextBox1_Enter

		#region DescriptionTextBox1_KeyPress
		private void DescriptionTextBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianAndNumberTyping(e);
		}
		#endregion /DescriptionTextBox1_KeyPress

		#region DescriptionTextBox1_Leave
		private void DescriptionTextBox1_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(descriptionTextBox1.Text) || string.Compare(descriptionTextBox1.Text, "توضیحات") == 0)
			{
				descriptionTextBox1.ForeColor =
					Infrastructure.Utility.WhiteColor();
				descriptionPanel1.BackColor =
					Infrastructure.Utility.PurpleColor();
				descriptionTextBox1.Text = "توضیحات";
				Description = string.Empty;
			}
			else
			{
				descriptionTextBox1.ForeColor =
					Infrastructure.Utility.PurpleColor();
				descriptionPanel1.BackColor =
					Infrastructure.Utility.PurpleColor();
				Description = descriptionTextBox1.Text;
			}
		}
		#endregion /DescriptionTextBox1_Leave
		//-----
		#endregion /DescriptionTextBox1

		#region SaveOrderButton1_Click
		private void SaveOrderButton1_Click(object sender, System.EventArgs e)
		{
			RequestStatus = "در حال بررسی";
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				string errorMessage = string.Empty;

				if (string.IsNullOrWhiteSpace(clientNameTextBox1.Text))
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
					if (string.IsNullOrWhiteSpace(clientNameTextBox1.Text) || string.Compare(clientNameTextBox1.Text, "نام مشتری") == 0)
					{
						clientNameTextBox1.Focus();
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

				Models.ComputerService computerService =
					new Models.ComputerService
					{
						Register_Date = RegisterDate,
						Invoice_Serial = InvoiceSerial,
						Client_Name = ClientName,
						Service_Type = ServiceType,
						Description = Description,
						Request_Status = RequestStatus,
					};

				dataBaseContext.ComputerServices.Add(computerService);
				dataBaseContext.SaveChanges();

				string successMessage =
					$"سفارش با کد {InvoiceSerial}" + "\n" + "با موفقیت ثبت گردید!";

				Infrastructure.Utility.WindowsNotification
					(message: successMessage,
					caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);

				ComputerServicesLoader();
				ComputerServiceClear();
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
		#endregion /SaveOrderButton1_Click

		#region AllClearButton1_Click
		private void AllClearButton1_Click(object sender, System.EventArgs e)
		{
			ComputerServiceClear();
			allClearButton1.Visible = false;
		}
		#endregion /AllClearButton1_Click
		//===============================================================================================
		#endregion /ComputerService

		#region Cellphone_Service
		//===============================================================================================
		#region CellphoneServiceButton_Click
		private void CellphoneServiceButton_Click(object sender, System.EventArgs e)
		{
			mainElipse.TargetControl = cellphoneServicePanel;
			mainElipse.ElipseRadius = 25;
			mainElipse.TargetControl = cellphoneServiceDataGridView;
			mainElipse.ElipseRadius = 25;

			RegisterDate = Infrastructure.Utility.PersianCalendar(System.DateTime.Now);
			registerDateLabel2.Text = RegisterDate;

			ComputerServiceButton = false;
			CellPhoneServiceButton = true;

			if (servicePanel.Width == 1100)
			{
				currentPagePanel.Location = new System.Drawing.Point(x: 540, y: 0);
			}
			if (servicePanel.Width == 1270)
			{
				currentPagePanel.Location = new System.Drawing.Point(x: 625, y: 0);
			}
			if (servicePanel.Width == 1620)
			{
				if (ComputerServiceButton == true)
				{
					currentPagePanel.Location = new System.Drawing.Point(x: 800, y: 0);
				}
			}
			if (servicePanel.Width == 1790)
			{
				if (ComputerServiceButton == true)
				{
					currentPagePanel.Location = new System.Drawing.Point(x: 885, y: 0);
				}
			}
			cellphoneServicePanel.Visible = true;
			computerServicePanel.Visible = false;
		}

		#endregion /CellphoneServiceButton_Click

		#region SearchInvoiceSerialTextBox2
		//-----
		#region SearchInvoiceSerialTextBox2_Enter
		private void SearchInvoiceSerialTextBox2_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.EnglishLanguage();
			searchInvoiceSerialTextBox2.Select(0, 0);
		}
		#endregion /SearchInvoiceSerialTextBox2_Enter

		#region SearchInvoiceSerialTextBox2_KeyPress
		private void SearchInvoiceSerialTextBox2_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.EnglishAndNumberTyping(e);

			if (string.Compare(searchInvoiceSerialTextBox2.Text, "سریال فاکتور را وارد نمایید...") == 0)
			{
				searchInvoiceSerialTextBox2.Clear();
			}
		}
		#endregion /SearchInvoiceSerialTextBox2_KeyPress

		#region SearchInvoiceSerialTextBox2_Leave
		private void SearchInvoiceSerialTextBox2_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(searchInvoiceSerialTextBox2.Text) || string.Compare(searchInvoiceSerialTextBox2.Text, "سریال فاکتور را وارد نمایید...") == 0)
			{
				searchInvoiceSerialTextBox2.ForeColor =
					Infrastructure.Utility.WhiteColor();
				searchInvoiceSerialPanel2.BackColor =
					Infrastructure.Utility.PurpleColor();
				searchInvoiceSerialTextBox2.Font =
					Infrastructure.Utility.IranSansFont(searchInvoiceSerialTextBox2.Font.Size);
				searchInvoiceSerialTextBox2.Text = "سریال فاکتور را وارد نمایید...";
				SearchInvoiceSerial = string.Empty;
			}
			else
			{
				searchInvoiceSerialTextBox2.ForeColor =
					Infrastructure.Utility.PurpleColor();
				searchInvoiceSerialPanel2.BackColor =
					Infrastructure.Utility.PurpleColor();
			}
		}
		#endregion /SearchInvoiceSerialTextBox2_Leave

		#region SearchInvoiceSerialTextBox2_TextChanged
		private void SearchInvoiceSerialTextBox2_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(searchInvoiceSerialTextBox2.Text))
			{
				SearchInvoiceSerial = string.Empty;
				return;
			}
			else
			{
				searchInvoiceSerialTextBox2.Font =
					Infrastructure.Utility.CenturyGothicFont(searchInvoiceSerialTextBox2.Font.Size);
				searchInvoiceSerialTextBox2.ForeColor =
					Infrastructure.Utility.LimeColor();
				searchInvoiceSerialPanel2.BackColor =
					Infrastructure.Utility.LimeColor();

				SearchInvoiceSerial = searchInvoiceSerialTextBox2.Text;

				SearchCellphoneServiceInvoce(SearchInvoiceSerial);
			}

		}
		#endregion /SearchInvoiceSerialTextBox2_TextChanged
		//-----
		#endregion /SearchInvoiceSerialTextBox2

		#region InvoiceSerialDeleteButton2_Click
		private void InvoiceSerialDeleteButton2_Click(object sender, System.EventArgs e)
		{
			InvoiceSerial = string.Empty;
			invoiceSerialLabel2.Text = "سریال فاکتور";
			invoiceSerialDeleteButton2.Visible = false;
			confirmStatusPicturBox2.Visible = false;
			saveOrderButton2.Enabled = false;
		}
		#endregion /InvoiceSerialDeleteButton2_Click

		#region NewSerialButton2_Click
		private void NewSerialButton2_Click(object sender, System.EventArgs e)
		{
			invoiceSerialLabel2.Text = GeneratInvoiceNumber();
			InvoiceSerial = GeneratInvoiceNumber();
			invoiceSerialDeleteButton2.Visible = true;
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();
				Models.CellphoneService cellphoneService =
					dataBaseContext.CellphoneServices
					.Where(current => string.Compare(current.Invoice_Serial, InvoiceSerial) == 0)
					.FirstOrDefault();
				if (cellphoneService != null)
				{
					confirmStatusPicturBox2.Visible = true;
					InvoiceSerial = string.Empty;
					confirmStatusPicturBox2.Image =
						ComputerServices.Properties.Resources.Tik_False;
					saveOrderButton2.Enabled = false;
					allClearButton2.Visible = false;
				}
				else
				{
					confirmStatusPicturBox2.Visible = true;
					confirmStatusPicturBox2.Image =
						ComputerServices.Properties.Resources.Tik_True;
					saveOrderButton2.Enabled = true;
					allClearButton2.Visible = true;
				}
			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
			}
		}

		#endregion /NewSerialButton2_Click

		#region InvoiceSerialLabel2_TextChanged
		private void InvoiceSerialLabel2_TextChanged(object sender, System.EventArgs e)
		{
			if (string.Compare(invoiceSerialLabel2.Text, "سریال فاکتور") == 0)
			{
				invoiceSerialLabel2.ForeColor =
					Infrastructure.Utility.WhiteColor();
				InvoiceSerial = string.Empty;
			}
			else
			{
				invoiceSerialLabel2.ForeColor =
					Infrastructure.Utility.PurpleColor();
			}
		}
		#endregion /InvoiceSerialLabel2_TextChanged

		#region ClientNametextBox2
		//-----
		#region ClientNametextBox2_Enter
		private void ClientNametextBox2_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();

			clientNametextBox2.ForeColor =
				Infrastructure.Utility.LimeColor();
			clientNamePanel2.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(clientNametextBox2.Text, "نام مشتری") == 0)
			{
				clientNametextBox2.Clear();
			}

		}
		#endregion /ClientNametextBox2_Enter

		#region ClientNametextBox2_KeyPress
		private void ClientNametextBox2_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
		}
		#endregion /ClientNametextBox2_KeyPress

		#region ClientNametextBox2_Leave
		private void ClientNametextBox2_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(clientNametextBox2.Text) || string.Compare(clientNametextBox2.Text, "نام مشتری") == 0)
			{
				clientNametextBox2.ForeColor =
				Infrastructure.Utility.WhiteColor();
				clientNamePanel2.BackColor =
					Infrastructure.Utility.PurpleColor();

				clientNametextBox2.Text = "نام مشتری";
				ClientName = string.Empty;
			}
			else
			{
				clientNametextBox2.ForeColor =
				Infrastructure.Utility.PurpleColor();
				clientNamePanel2.BackColor =
					Infrastructure.Utility.PurpleColor();
				ClientName = clientNametextBox2.Text;
			}
		}
		#endregion /ClientNametextBox2_Leave 
		//-----
		#endregion /ClientNametextBox2

		//------------------------------------------------------------//Hardware Service------------------------------------------------------------
		#region HardwareServiceRadioButton_CheckedChanged
		private void HardwareServiceRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			softwareServivePanel.Visible = false;
			hardwaewServicePanel.Visible = true;

			descriptionTextBox2.Location = new System.Drawing.Point(x: descriptionTextBox2.Location.X, y: 293);
			descriptionPanel2.Location = new System.Drawing.Point(x: descriptionPanel2.Location.X, y: 570);
			saveOrderButton2.Location = new System.Drawing.Point(x: saveOrderButton2.Location.X, y: 577);

		}
		#endregion /HardwareServiceRadioButton_CheckedChanged

		#region LcdCheckBox_CheckedChanged
		private void LcdCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{
			if (lcdCheckBox.Checked == true)
			{
				LCDService = true;
			}
			else
				LCDService = false;
		}
		#endregion /LcdCheckBox_CheckedChanged

		#region RamCheckBox_CheckedChanged
		private void RamCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{
			if (ramCheckBox.Checked == true)
			{
				RAMService = true;
			}
			else
				RAMService = false;
		}
		#endregion /RamCheckBox_CheckedChanged

		#region BoardCheckBox_CheckedChanged
		private void BoardCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{
			if (boardCheckBox.Checked == true)
			{

			}
		}
		#endregion /BoardCheckBox_CheckedChanged

		#region CameraCheckBox_CheckedChanged
		private void CameraCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{
			if (ramCheckBox.Checked == true)
			{
				RAMService = true;
			}
			else
				RAMService = false;
		}
		#endregion /CameraCheckBox_CheckedChanged

		#region RomCheckBox_CheckedChanged
		private void RomCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{
			if (romCheckBox.Checked == true)
			{
				ROMService = true;
			}
			else
				ROMService = false;
		}
		#endregion /RomCheckBox_CheckedChanged

		#region BatteryCheckBox_CheckedChanged
		private void BatteryCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{
			if (batteryCheckBox.Checked == true)
			{
				BatteryService = true;
			}
			else
				BatteryService = false;
		}
		#endregion /BatteryCheckBox_CheckedChanged

		#region OtherCheckBox_CheckedChanged
		private void OtherHardwareServiceCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{
			if (otherHardwareServiceCheckBox.Checked == true)
			{
				OtherHardwareService = true;
			}
			else
				OtherHardwareService = false;
		}
		#endregion /OtherCheckBox_CheckedChanged
		//------------------------------------------------------------Hardware Service\\------------------------------------------------------------

		//------------------------------------------------------------//Software Service------------------------------------------------------------
		#region SoftwareServiceRadioButton_CheckedChanged
		private void SoftwareServiceRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			softwareServivePanel.Visible = true;
			hardwaewServicePanel.Visible = false;

			descriptionTextBox2.Location = new System.Drawing.Point(x: descriptionTextBox2.Location.X, y: 268);
			descriptionPanel2.Location = new System.Drawing.Point(x: descriptionPanel2.Location.X, y: 575);
			saveOrderButton2.Location = new System.Drawing.Point(x: saveOrderButton2.Location.X, y: 552);
		}
		#endregion /SoftwareServiceRadioButton_CheckedChanged

		#region SamsungIDCheckBox_CheckedChanged
		private void SamsungIDCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{
			if (samsungIDCheckBox.Checked == true)
			{
				SamsungID = true;
			}
			else
				SamsungID = false;
		}
		#endregion /SamsungIDCheckBox_CheckedChanged

		#region DownloadOSAndroidCheckBox_CheckedChanged
		private void DownloadOSAndroidCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{
			if (downloadOSAndroidCheckBox.Checked == true)
			{
				OS_Android = true;
			}
			else
				OS_Android = false;
		}
		#endregion /DownloadOSAndroidCheckBox_CheckedChanged

		#region SetupAPKCheckBox_CheckedChanged
		private void SetupAPKCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{
			if (setupAPKCheckBox.Checked == true)
			{
				SetupAPK = true;
			}
			else
				SetupAPK = false;
		}
		#endregion /SetupAPKCheckBox_CheckedChanged

		#region ResetFactoriFlashCheckBox_CheckedChanged
		private void ResetFactoriFlashCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{
			if (resetFactoriFlashCheckBox.Checked == true)
			{
				ResetFactory = true;
			}
			else
				ResetFactory = false;
		}
		#endregion /ResetFactoriFlashCheckBox_CheckedChanged

		#region AppleIDcheckBox_CheckedChanged
		private void AppleIDcheckBox_CheckedChanged(object sender, System.EventArgs e)
		{
			if (appleIDcheckBox.Checked == true)
			{
				AppleID = true;
			}
			else
				AppleID = false;
		}
		#endregion /AppleIDcheckBox_CheckedChanged

		#region DownloadOSIOSCheckBox_CheckedChanged
		private void DownloadOSIOSCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{
			if (downloadOSIOSCheckBox.Checked == true)
			{
				OS_IOS = true;
			}
			else
				OS_IOS = false;
		}
		#endregion /DownloadOSIOSCheckBox_CheckedChanged

		#region SetupIPACheckBox_CheckedChanged
		private void SetupIPACheckBox_CheckedChanged(object sender, System.EventArgs e)
		{
			if (setupIPACheckBox.Checked == true)
			{
				SetupIPA = true;
			}
			else
				SetupIPA = false;
		}
		#endregion /SetupIPACheckBox_CheckedChanged

		#region OtherSoftwareServiceCheckBox_CheckedChanged
		private void OtherSoftwareServiceCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{
			if (otherSoftwareServiceCheckBox.Checked == true)
			{
				OtherSoftwaareService = true;
			}
			else
				OtherSoftwaareService = false;
		}
		#endregion /OtherSoftwareServiceCheckBox_CheckedChanged
		//------------------------------------------------------------Software Service\\------------------------------------------------------------

		#region DescriptionTextBox2
		//-----
		#region DescriptionTextBox2_Enter
		private void DescriptionTextBox2_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();

			descriptionTextBox2.ForeColor =
				Infrastructure.Utility.LimeColor();
			descriptionPanel2.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(descriptionTextBox2.Text, "توضیحات") == 0)
			{
				descriptionTextBox2.Clear();
			}
		}
		#endregion /DescriptionTextBox2_Enter

		#region DescriptionTextBox2_KeyPress
		private void DescriptionTextBox2_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianAndNumberTyping(e);
		}
		#endregion /DescriptionTextBox2_KeyPress

		#region DescriptionTextBox2_Leave
		private void DescriptionTextBox2_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(descriptionTextBox2.Text) || string.Compare(descriptionTextBox2.Text, "توضیحات") == 0)
			{
				descriptionTextBox2.ForeColor =
					Infrastructure.Utility.WhiteColor();
				descriptionPanel2.BackColor =
					Infrastructure.Utility.PurpleColor();

				descriptionTextBox2.Text = "توضیحات";
				Description = string.Empty;
			}
			else
			{
				descriptionTextBox2.ForeColor =
					Infrastructure.Utility.PurpleColor();
				descriptionPanel2.BackColor =
					Infrastructure.Utility.PurpleColor();

				Description = descriptionTextBox2.Text;
			}
		}
		#endregion /DescriptionTextBox2_Leave 
		//-----
		#endregion /DescriptionTextBox2 

		#region SaveOrderButton2_Click
		private void SaveOrderButton2_Click(object sender, System.EventArgs e)
		{
			RequestStatus = "در حال بررسی";
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				string errorMessage = string.Empty;

				if (string.Compare(clientNametextBox2.Text, "نام مشتری") == 0)
				{
					errorMessage = "لطفا نام مشتری را وارد نمایید!";
				}
				if (lcdCheckBox.Checked == false &&
					ramCheckBox.Checked == false &&
					romCheckBox.Checked == false &&
					batteryCheckBox.Checked == false &&
					cameraCheckBox.Checked == false &&
					boardCheckBox.Checked == false &&
					otherHardwareServiceCheckBox.Checked == false &&
					samsungIDCheckBox.Checked == false &&
					downloadOSAndroidCheckBox.Checked == false &&
					setupAPKCheckBox.Checked == false &&
					appleIDcheckBox.Checked == false &&
					downloadOSIOSCheckBox.Checked == false &&
					setupIPACheckBox.Checked == false &&
					resetFactoriFlashCheckBox.Checked == false &&
					otherSoftwareServiceCheckBox.Checked == false)
				{
					if (string.IsNullOrEmpty(errorMessage) != true)
					{
						errorMessage +=
							System.Environment.NewLine;
					}

					errorMessage += "لطفا یکی از سرویس ها را انتخاب نمایید!";
				}

				if (string.IsNullOrEmpty(errorMessage) != true)
				{
					if (string.Compare(clientNametextBox2.Text, "نام مشتری") == 0)
					{
						clientNametextBox2.Focus();
					}
					else if (lcdCheckBox.Checked == false &&
					ramCheckBox.Checked == false &&
					romCheckBox.Checked == false &&
					batteryCheckBox.Checked == false &&
					cameraCheckBox.Checked == false &&
					boardCheckBox.Checked == false &&
					otherHardwareServiceCheckBox.Checked == false &&
					samsungIDCheckBox.Checked == false &&
					downloadOSAndroidCheckBox.Checked == false &&
					setupAPKCheckBox.Checked == false &&
					appleIDcheckBox.Checked == false &&
					downloadOSIOSCheckBox.Checked == false &&
					setupIPACheckBox.Checked == false &&
					resetFactoriFlashCheckBox.Checked == false &&
					otherSoftwareServiceCheckBox.Checked == false)
					{
						hardwareServiceRadioButton.Checked = true;
						hardwareServiceRadioButton.Focus();
						hardwaewServicePanel.Visible = true;
						softwareServivePanel.Visible = false;

						descriptionTextBox2.Location = new System.Drawing.Point(x: descriptionTextBox2.Location.X, y: 293);
						descriptionPanel2.Location = new System.Drawing.Point(x: descriptionPanel2.Location.X, y: 379);
						saveOrderButton2.Location = new System.Drawing.Point(x: saveOrderButton2.Location.X, y: 386);
					}

					Mbb.Windows.Forms.MessageBox.Show(
						text: errorMessage,
						caption: "خطای ورودی",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
						button: Mbb.Windows.Forms.MessageBoxButtons.Ok
						);
					return;
				}

				Models.CellphoneService cellphoneService =
					new Models.CellphoneService
					{
						Register_Date = RegisterDate,
						Invoice_Serial = InvoiceSerial,
						Client_Name = ClientName,
						//------Hardware Service
						LCD_Service = LCDService,
						RAM_Service = RAMService,
						ROM_Service = ROMService,
						Battery_Service = BatteryService,
						Board_Service = BoardService,
						Camera_Service = CameraService,
						Other_Hardware_Service = OtherHardwareService,
						//------Software Service
						Samsung_ID = SamsungID,
						Dowanlod_OS_Android = OS_Android,
						Setup_APK = SetupAPK,
						Apple_ID = AppleID,
						DowanLoad_OS_IOS = OS_IOS,
						Setup_IPA = SetupIPA,
						Reset_Factory = ResetFactory,
						Other_Software_Service = OtherSoftwaareService,

						Description = Description,
						Request_Status = RequestStatus,
					};

				dataBaseContext.CellphoneServices.Add(cellphoneService);
				dataBaseContext.SaveChanges();

				string successMessage =
					$"سفارش با کد {InvoiceSerial}" + "\n" + "با موفقیت ثبت گردید!";

				Infrastructure.Utility.WindowsNotification
					(message: successMessage,
					caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);

				CellphoneServicesLoader();
				CellPhoneServiceClear();

			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
			}
			finally
			{
				dataBaseContext.Dispose();
				dataBaseContext = null;
			}
		}
		#endregion /SaveOrderButton2_Click

		#region AllClearButton2_Click
		private void AllClearButton2_Click(object sender, System.EventArgs e)
		{
			CellPhoneServiceClear();
			allClearButton2.Visible = false;
		}
		#endregion /AllClearButton2_Click
		//===============================================================================================
		#endregion /Cellphone_Service 

		#endregion /Service

		#region ClientButton_Click
		private void ClientButton_Click(object sender, System.EventArgs e)
		{
			focusPanel.Height = clientButton.Height;
			focusPanel.Top = clientButton.Top;

			currentPageLabel.Text = clientButton.Text;
			iconPagePicturBox.Image = Properties.Resources.client_512;

			Service = false;
			Client = true;
			Dashboard = false;
			Product = false;
			Deliver = false;
			AdminTools = false;
			CafeNet = false;
		}
		#endregion /ClientButton_Click

		#region DashboardReportButton_Click
		private void DashboardReportButton_Click(object sender, System.EventArgs e)
		{
			focusPanel.Height = dashboardReportButton.Height;
			focusPanel.Top = dashboardReportButton.Top;
			currentPageLabel.Text = dashboardReportButton.Text;
			iconPagePicturBox.Image = Properties.Resources.combo_chart_512;

			Service = false;
			Client = false;
			Dashboard = true;
			Product = false;
			Deliver = false;
			AdminTools = false;
			CafeNet = false;
		}
		#endregion /DashboardReportButton_Click

		#region ProductButton_Click
		private void ProductButton_Click(object sender, System.EventArgs e)
		{
			focusPanel.Height = productButton.Height;
			focusPanel.Top = productButton.Top;
			currentPageLabel.Text = productButton.Text;
			iconPagePicturBox.Image = Properties.Resources.box_512;

			Service = false;
			Client = false;
			Dashboard = false;
			Product = true;
			Deliver = false;
			AdminTools = false;
			CafeNet = false;
		}
		#endregion /ProductButton_Click

		#region DeliveryButton_Click
		private void DeliveryButton_Click(object sender, System.EventArgs e)
		{
			focusPanel.Height = deliveryButton.Height;
			focusPanel.Top = deliveryButton.Top;
			currentPageLabel.Text = deliveryButton.Text;
			iconPagePicturBox.Image = Properties.Resources.delivery_512;

			Service = false;
			Client = false;
			Dashboard = false;
			Product = false;
			Deliver = true;
			AdminTools = false;
			CafeNet = false;
		}
		#endregion /DeliveryButton_Click

		#region AdministratorToolsButton_Click
		private void AdministratorToolsButton_Click(object sender, System.EventArgs e)
		{
			focusPanel.Height = administratorToolsButton.Height;
			focusPanel.Top = administratorToolsButton.Top;
			currentPageLabel.Text = administratorToolsButton.Text;
			iconPagePicturBox.Image = Properties.Resources.administrative_tools_512;

			Service = false;
			Client = false;
			Dashboard = false;
			Product = false;
			Deliver = false;
			AdminTools = true;
			CafeNet = false;
		}
		#endregion /AdministratorToolsButton_Click

		#region CafeNetButton_Click
		private void CafeNetButton_Click(object sender, System.EventArgs e)
		{
			focusPanel.Height = cafeNetButton.Height;
			focusPanel.Top = cafeNetButton.Top;
			currentPageLabel.Text = cafeNetButton.Text;
			iconPagePicturBox.Image = Properties.Resources.cafe_net_512;

			Service = false;
			Client = false;
			Dashboard = false;
			Product = false;
			Deliver = false;
			AdminTools = false;
			CafeNet = true;
		}
		#endregion /CafeNetButton_Click

		#region ShutDownButton_Click
		private void ShutDownButton_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.DialogResult dialogResult =
				Mbb.Windows.Forms.MessageBox.Show(text: "قصد خروج دارید؟", caption: "خروج از برنامه", icon: Mbb.Windows.Forms.MessageBoxIcon.Question, button: Mbb.Windows.Forms.MessageBoxButtons.YesNo);

			if (dialogResult == System.Windows.Forms.DialogResult.Yes)
			{
				System.Windows.Forms.Application.Exit();
			}
		}
		#endregion /ShutDownButton_Click

		#region LogputButton_Click
		private void LogputButton_Click(object sender, System.EventArgs e)
		{
			if (Mbb.Windows.Forms.MessageBox.Show(
				text: "آیا قصد خروج از حساب کاربری خود را دارید؟",
				caption: "خروج از حساب کاربری",
				icon: Mbb.Windows.Forms.MessageBoxIcon.Question,
				button: Mbb.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
			{
				this.Close();
			}
		}
		#endregion /LogputButton_Click

		#region ClockTimer_Tick
		private void ClockTimer_Tick(object sender, System.EventArgs e)
		{
			secondLabel.Text = System.DateTime.Now.Second.ToString().PadLeft(2, '0');

			if (string.Compare(secondLabel.Text, "00") == 0)
			{
				minuteLabel.Text = System.DateTime.Now.Minute.ToString().PadLeft(2, '0');
			}

			if (string.Compare(minuteLabel.Text, "00") == 0)
			{
				hourLabel.Text = System.DateTime.Now.Hour.ToString().PadLeft(2, '0');
			}
		}
		#endregion /ClockTimer_Tick

		#region Panel_MouseDown

		#region TitlePanel_MouseDown
		private void TitlePanel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		#endregion /TitlePanel_MouseDown

		#region MenuPanel_MouseDown
		private void MenuPanel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		#endregion /MenuPanel_MouseDown

		#region NotificationPanel_MouseDown
		private void NotificationPanel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}







		#endregion /NotificationPanel_MouseDown

		#endregion /Panel_MouseDown

		//-----End of coding line

		#region Functions
		//-----
		#region Initialize
		public void Initialize()
		{

			if (Program.AuthenticatedUser.IsAdministrator == false)
			{
				administratorToolsButton.Enabled = false;
			}
			else
			{
				administratorToolsButton.Enabled = true;
			}

			string name =
				$"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";

			if (string.IsNullOrEmpty(Program.AuthenticatedUser.First_Name) || string.IsNullOrEmpty(Program.AuthenticatedUser.Last_Name) || Program.AuthenticatedUser.First_Name == "null" || Program.AuthenticatedUser.Last_Name == "null")
			{
				name =
					Program.AuthenticatedUser.Username;
			}

			usernameLoginLabel.Text = name;

			
			var byteImage = Program.AuthenticatedUser.User_Image;
			using (System.IO.MemoryStream ms = new System.IO.MemoryStream(byteImage))
			{
				userImagePicturBox.BackgroundImage = System.Drawing.Image.FromStream(ms);
			}


		}



		#endregion /Initialize

		#region FormLoad
		private void FormLoad()
		{
			mainPanel.Controls.Clear();
			focusPanel.Height = homeButton.Height;
			focusPanel.Top = homeButton.Top;

			Service = true;
			Client = false;
			Dashboard = false;
			Product = false;
			Deliver = false;
			AdminTools = false;
			CafeNet = false;

			secondLabel.Text = System.DateTime.Now.Second.ToString().PadLeft(2, '0');
			minuteLabel.Text = System.DateTime.Now.Minute.ToString().PadLeft(2, '0');
			hourLabel.Text = System.DateTime.Now.Hour.ToString().PadLeft(2, '0');
			clockTimer.Start();
			MaximumSize = false;
			MinimumSize = true;

			

			solarDateLabel.Text = Infrastructure.Utility.PersianCalendar();
			adDateLabel.Text = Infrastructure.Utility.ADCalendar();
		}

		#endregion /FormLoad

		#region Service_Founctions
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

			for (int i = 1; i <= 20; i++)
			{
				count = randomCount.Next(0, 2);

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
					letter = letter.Insert(i - 1, "-");
				}
			}
			return letter;
		}
		#endregion /InvoiceNumber

		#region ComputerServicesLoader
		private void ComputerServicesLoader()
		{
			Models.DataBaseContext databaseContext = null;
			try
			{
				databaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.ComputerService> computerServices = null;

				computerServices =
					databaseContext.ComputerServices
					.OrderBy(current => current.Register_Date)
					.ToList();

				computerServiceDataGridView.DataSource = computerServices;
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
		#endregion /ComputerServicesLoader

		#region CellphoneServicesLoader
		private void CellphoneServicesLoader()
		{
			Models.DataBaseContext databaseContext = null;
			try
			{
				databaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.CellphoneService> cellphoneServices = null;

				cellphoneServices =
					databaseContext.CellphoneServices
					.OrderBy(current => current.Register_Date)
					.ToList();

				cellphoneServiceDataGridView.DataSource = cellphoneServices;
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
		#endregion /CellphoneServicesLoader

		#region SearchComputerServiceInvoce
		private void SearchComputerServiceInvoce(string invoceSerial)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.ComputerService> computerServices = null;

				if (string.IsNullOrEmpty(invoceSerial))
				{
					computerServices =
						dataBaseContext.ComputerServices
						.OrderBy(current => current.Register_Date)
						.ToList();
				}
				else
				{
					computerServices =
						dataBaseContext.ComputerServices
						.Where(current => current.Invoice_Serial.Contains(invoceSerial))
						.OrderBy(current => current.Register_Date)
						.ToList();
				}
				computerServiceDataGridView.DataSource = computerServices;
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
		#endregion /SearchComputerServiceInvoce

		#region SearchCellphoneServiceInvoce
		private void SearchCellphoneServiceInvoce(string invoceSerial)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.CellphoneService> cellphoneServices = null;

				if (string.IsNullOrEmpty(invoceSerial))
				{
					cellphoneServices =
						dataBaseContext.CellphoneServices
						.OrderBy(current => current.Register_Date)
						.ToList();
				}
				else
				{
					cellphoneServices =
						dataBaseContext.CellphoneServices
						.Where(current => current.Invoice_Serial.Contains(invoceSerial))
						.OrderBy(current => current.Register_Date)
						.ToList();
				}

				computerServiceDataGridView.DataSource = cellphoneServices;

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
		#endregion /SearchCellphoneServiceInvoce

		#region ComputerServiceClear
		/// <summary>
		/// All input data for the computer service department is lost...
		/// </summary>
		private void ComputerServiceClear()
		{
			invoiceSerialDeleteButton1.Visible = false;
			confirmStatusPicturBox1.Visible = false;
			//-----
			invoiceSerialLabel1.Text = "سریال فاکتور";
			invoiceSerialLabel1.ForeColor =
				Infrastructure.Utility.WhiteColor();
			invoiceSerialPanel1.BackColor =
				Infrastructure.Utility.PurpleColor();
			InvoiceSerial = string.Empty;
			//-----
			clientNameTextBox1.Text = "نام مشتری";
			clientNameTextBox1.ForeColor =
				Infrastructure.Utility.WhiteColor();
			clientNamePanel1.BackColor =
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
			descriptionTextBox1.Text = "توضیحات مشتری";
			descriptionTextBox1.ForeColor =
				Infrastructure.Utility.WhiteColor();
			descriptionPanel1.BackColor =
				Infrastructure.Utility.PurpleColor();
			Description = string.Empty;
			//-----
			saveOrderButton1.Enabled = false;
		}

		#endregion /ComputerServiceClear

		#region CellPhoneServiceClear
		private void CellPhoneServiceClear()
		{
			invoiceSerialDeleteButton2.Visible = false;
			invoiceSerialLabel2.Text = "سریال فاکتور";
			invoiceSerialLabel2.Font =
				Infrastructure.Utility.IranSansFont(invoiceSerialLabel2.Font.Size);
			invoiceSerialLabel2.ForeColor =
				Infrastructure.Utility.WhiteColor();
			invoiceSerialPanel2.BackColor =
				Infrastructure.Utility.PurpleColor();
			InvoiceSerial = string.Empty;
			confirmStatusPicturBox2.Visible = false;

			clientNametextBox2.Text = "نام مشتری";
			clientNametextBox2.ForeColor =
				Infrastructure.Utility.WhiteColor();
			clientNamePanel2.BackColor =
				Infrastructure.Utility.PurpleColor();
			ClientName = string.Empty;

			hardwareServiceRadioButton.Checked = false;
			CheckBoxFalse();

			descriptionTextBox2.Text = "توضیحات";
			descriptionTextBox2.ForeColor =
				Infrastructure.Utility.WhiteColor();
			descriptionPanel2.BackColor =
				Infrastructure.Utility.PurpleColor();
		}
		#endregion /CellPhoneServiceClear

		#region CheckBoxFalse
		private void CheckBoxFalse()
		{
			//--------------------Software CheckBoxs
			samsungIDCheckBox.Checked = false;
			SamsungID = false;
			downloadOSAndroidCheckBox.Checked = false;
			OS_Android = false;
			setupAPKCheckBox.Checked = false;
			SetupAPK = false;
			appleIDcheckBox.Checked = false;
			AppleID = false;
			downloadOSIOSCheckBox.Checked = false;
			OS_IOS = false;
			setupIPACheckBox.Checked = false;
			SetupIPA = false;
			resetFactoriFlashCheckBox.Checked = false;
			ResetFactory = false;
			otherSoftwareServiceCheckBox.Checked = false;
			OtherSoftwaareService = false;
			//--------------------Hardware CheckBoxs
			lcdCheckBox.Checked = false;
			LCDService = false;
			ramCheckBox.Checked = false;
			RAMService = false;
			romCheckBox.Checked = false;
			ROMService = false;
			batteryCheckBox.Checked = false;
			BatteryService = false;
			cameraCheckBox.Checked = false;
			CameraService = false;
			boardCheckBox.Checked = false;
			BoardService = false;
			otherHardwareServiceCheckBox.Checked = false;
			OtherHardwareService = false;
		}




		#endregion /CheckBoxFalse

		#endregion /Service_Founctions
		//-----
		#endregion /Functions

		
	}
}
