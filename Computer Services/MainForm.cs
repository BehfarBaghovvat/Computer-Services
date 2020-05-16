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

		}
		#endregion /MinimizeButton_Click

		#region FirstSizeButton_Click
		private void FirstSizeButton_Click(object sender, System.EventArgs e)
		{
			if (rightSidePanel.Width == 250)
			{
				menuPanel.Visible = false;
				logputButton.Location = new System.Drawing.Point(x: 182, y: 756);
				menuPanel.Width = 50;
				rightSidePanel.Width = 80;
				menuTransition2.Show(menuPanel);

			}
			else
			{
				menuPanel.Visible = false;
				rightSidePanel.Width = 250;
				menuPanel.Width = 220;
				logputButton.Location = new System.Drawing.Point(x: 150, y: 789);
				menuTransition1.Show(menuPanel);
			}

		}
		#endregion /FirstSizeButton_Click

		private void MainPanel_SizeChanged(object sender, System.EventArgs e)
		{
			//label1.Text = this.Size.Height.ToString();
			//label5.Text = this.Size.Width.ToString();

			//label7.Text = mainPanel.Size.Height.ToString();
			//label3.Text = mainPanel.Size.Width.ToString();

		}

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

		#region ServicesButton_Click
		private void ServicesButton_Click(object sender, System.EventArgs e)
		{
			focusPanel.Height = servicesButton.Height;
			focusPanel.Top = servicesButton.Top;
			ComputerServiceButton = true;
			CellPhoneServiceButton = false;

			mainElipse.TargetControl = computerServicePanel;
			mainElipse.ElipseRadius = 25;
			mainElipse.TargetControl = computerServiceDataGridView;
			mainElipse.ElipseRadius = 25;

			currentPageLabel.Text = servicesButton.Text;
			iconPagePicturBox.Image = Properties.Resources.computer_support_512;

			mainPanel.Controls.Clear();
			mainPanel.Controls.Add(servicePanel);
			servicePanel.BringToFront();

			computerServicePanel.Visible = true;
			cellphoneServicePanel.Visible = false;

			ComputerServicesLoader();
			CellphoneServicesLoader();

			RegisterDate = Infrastructure.Utility.PersianCalendar(System.DateTime.Now);
			registerDateLabel1.Text = RegisterDate;

			Service = true;
			Client = false;
			Dashboard = false;
			Product = false;
			Deliver = false;
			AdminTools = false;
			CafeNet = false;

		}
		#endregion /ServicesButton_Click

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

		#region Function
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
		//-----
		#endregion /Function

		private void MainForm_SizeChanged(object sender, System.EventArgs e)
		{
			mainPanel.Width = this.Width - 250;
			mainPanel.Height = this.Height - 150;
		}

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
					currentPageLabel.Location = new System.Drawing.Point(x: 800, y: 0);
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
		//----------
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
		}
		#endregion /InvoiceSerialDeleteButton1_Click

		#region MyRegion
		private void NewSerialButton1_Click(object sender, System.EventArgs e)
		{

		}
		#endregion

		#region MyRegion
		private void InvoiceSerialLabel1_TextChanged(object sender, System.EventArgs e)
		{

		}
		#endregion

		#region MyRegion
		private void ClientNameTextBox1_Enter(object sender, System.EventArgs e)
		{

		}
		#endregion

		#region MyRegion
		private void ClientNameTextBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{

		}
		#endregion

		#region MyRegion
		private void ClientNameTextBox1_Leave(object sender, System.EventArgs e)
		{

		}
		#endregion

		#region MyRegion
		private void ServiceTypeComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
		{

		}
		#endregion

		#region MyRegion
		private void DescriptionTextBox1_Enter(object sender, System.EventArgs e)
		{

		}
		#endregion

		#region MyRegion
		private void DescriptionTextBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{

		}
		#endregion

		#region MyRegion
		private void DescriptionTextBox1_Leave(object sender, System.EventArgs e)
		{

		}
		#endregion

		#region MyRegion
		private void SaveOrderButton1_Click(object sender, System.EventArgs e)
		{

		}
		#endregion

		#region MyRegion
		private void AllClearButton1_Click(object sender, System.EventArgs e)
		{

		}
		#endregion
		//----------
		#endregion

		//===============================================================================================

		private void CellphoneServiceButton_Click(object sender, System.EventArgs e)
		{
			mainElipse.TargetControl = cellphoneServicePanel;
			mainElipse.ElipseRadius = 25;
			mainElipse.TargetControl = cellphoneServiceDataGridView;
			mainElipse.ElipseRadius = 25;

			RegisterDate = Infrastructure.Utility.PersianCalendar(System.DateTime.Now);
			registerDateLabel1.Text = RegisterDate;

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

		private void SearchInvoiceSerialTextBox2_Enter(object sender, System.EventArgs e)
		{

		}

		private void SearchInvoiceSerialTextBox2_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{

		}

		private void SearchInvoiceSerialTextBox2_Leave(object sender, System.EventArgs e)
		{

		}

		private void SearchInvoiceSerialTextBox2_TextChanged(object sender, System.EventArgs e)
		{

		}
		private void InvoiceSerialDeleteButton2_Click(object sender, System.EventArgs e)
		{

		}

		private void NewSerialButton2_Click(object sender, System.EventArgs e)
		{

		}

		private void InvoiceSerialLabel2_TextChanged(object sender, System.EventArgs e)
		{

		}

		private void ClientNametextBox2_Enter(object sender, System.EventArgs e)
		{

		}

		private void ClientNametextBox2_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{

		}

		private void ClientNametextBox2_Leave(object sender, System.EventArgs e)
		{

		}

		private void HardwareServiceRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{

		}

		private void SoftwareServiceRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{

		}

		private void LcdCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{

		}

		private void RamCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{

		}

		private void RomCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{

		}

		private void BatteryCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{

		}

		private void CameraCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{

		}

		private void BoardCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{

		}

		private void OtherHardwareServiceCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{

		}

		private void SamsungIDCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{

		}

		private void DownloadOSAndroidCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{

		}

		private void SetupAPKCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{

		}

		private void ResetFactoriFlashCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{

		}

		private void AppleIDcheckBox_CheckedChanged(object sender, System.EventArgs e)
		{

		}

		private void DownloadOSIOSCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{

		}

		private void SetupIPACheckBox_CheckedChanged(object sender, System.EventArgs e)
		{

		}

		private void OtherSoftwareServiceCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{

		}

		private void DescriptionTextBox2_Enter(object sender, System.EventArgs e)
		{

		}

		private void DescriptionTextBox2_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{

		}

		private void DescriptionTextBox2_Leave(object sender, System.EventArgs e)
		{

		}

		private void SaveOrderButton2_Click(object sender, System.EventArgs e)
		{

		}

		private void AllClearButton2_Click(object sender, System.EventArgs e)
		{

		}










		//----------

		#region Founctions
		//-----
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

			currentPagePanel.Location = new System.Drawing.Point(x: 1090, y: 0);

			solarDateLabel.Text = Infrastructure.Utility.PersianCalendar();
			adDateLabel.Text = Infrastructure.Utility.ADCalendar();
		}







		#endregion /FormLoad

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





		//-----
		#endregion /Founctions




	}
}
