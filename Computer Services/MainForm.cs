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

		//private Menu.Service.ServiceForm serviceForm;

		//public Menu.Service.ServiceForm ServiceForm
		//{
		//	get 
		//	{
		//		if (serviceForm == null)
		//		{

		//		}
		//		return serviceForm;
		//	}
		//}



		#region Properties
		public int LX { get; set; }
		public int LY { get; set; }
		#endregion /Properties

		//-----The beginning of the coding line.

		#region MainForm_Load
		private void MainForm_Load(object sender, System.EventArgs e)
		{
			secondLabel.Text = System.DateTime.Now.Second.ToString().PadLeft(2, '0');
			minuteLabel.Text = System.DateTime.Now.Minute.ToString().PadLeft(2, '0');
			hourLabel.Text = System.DateTime.Now.Hour.ToString().PadLeft(2, '0');
			clockTimer.Start();

			solarDateLabel.Text = Infrastructure.Utility.PersianCalendar();
			adDateLabel.Text = Infrastructure.Utility.ADCalendar();
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

			LX = Location.X;
			LY = Location.Y;
			this.Size = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Size;
			this.Location = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Location;
			this.Location = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Location;

			maximizeButton.SendToBack();
			restoreButton.BringToFront();
		}
		#endregion /MaximizeButton_Click

		#region RestoreButton_Click
		private void RestoreButton_Click(object sender, System.EventArgs e)
		{
			this.Size = new System.Drawing.Size(1300, 700);
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
			logputButton.Location = new System.Drawing.Point(x: 144, y: 528);
			menuPanel.Size = new System.Drawing.Size(width: 40, height: 600);
			firstSizeButton.SendToBack();
			secondSizeButton.BringToFront();
		}
		#endregion /FirstSizeButton_Click

		#region SecondSizeButton_Click
		private void SecondSizeButton_Click(object sender, System.EventArgs e)
		{
			menuPanel.Size = new System.Drawing.Size(width: 180, height: 600);
			logputButton.Location = new System.Drawing.Point(x: 112, y: 561);
			firstSizeButton.BringToFront();
			secondSizeButton.SendToBack();
		}
		#endregion /SecondSizeButton_Click

		#region ServicesButton_Click
		private void ServicesButton_Click(object sender, System.EventArgs e)
		{
			focusPanel.Height = servicesButton.Height;
			focusPanel.Top = servicesButton.Top;

			Menu.Service.ServiceForm serviceForm =
				new Menu.Service.ServiceForm();

			serviceForm.Dock = System.Windows.Forms.DockStyle.Fill;
			serviceForm.TopLevel = false;
			serviceForm.TopMost = true;

			currentPageLabel.Text = servicesButton.Text;
			iconPagePicturBox.Image = Properties.Resources.computer_support_512;

			mainPanel.Controls.Clear();
			mainPanel.Controls.Add(serviceForm);
			serviceForm.Show();

		}
		#endregion /ServicesButton_Click

		#region ClientButton_Click
		private void ClientButton_Click(object sender, System.EventArgs e)
		{
			focusPanel.Height = clientButton.Height;
			focusPanel.Top = clientButton.Top;

			currentPageLabel.Text = clientButton.Text;
			iconPagePicturBox.Image = Properties.Resources.client_512;
		}
		#endregion /ClientButton_Click

		#region ReportButton_Click
		private void ReportButton_Click(object sender, System.EventArgs e)
		{
			focusPanel.Height = reportButton.Height;
			focusPanel.Top = reportButton.Top;
			currentPageLabel.Text = reportButton.Text;
			iconPagePicturBox.Image = Properties.Resources.order_document_512;
		}
		#endregion /ReportButton_Click

		#region ProductButton_Click
		private void ProductButton_Click(object sender, System.EventArgs e)
		{
			focusPanel.Height = productButton.Height;
			focusPanel.Top = productButton.Top;
			currentPageLabel.Text = productButton.Text;
			iconPagePicturBox.Image = Properties.Resources.box_512;
		}
		#endregion /ProductButton_Click

		#region DeliveryButton_Click
		private void DeliveryButton_Click(object sender, System.EventArgs e)
		{
			focusPanel.Height = deliveryButton.Height;
			focusPanel.Top = deliveryButton.Top;
			currentPageLabel.Text = deliveryButton.Text;
			iconPagePicturBox.Image = Properties.Resources.delivery_512;
		}
		#endregion /DeliveryButton_Click

		#region AdministratorToolsButton_Click
		private void AdministratorToolsButton_Click(object sender, System.EventArgs e)
		{
			focusPanel.Height = administratorToolsButton.Height;
			focusPanel.Top = administratorToolsButton.Top;
			currentPageLabel.Text = administratorToolsButton.Text;
			iconPagePicturBox.Image = Properties.Resources.administrative_tools_512;
		}
		#endregion /AdministratorToolsButton_Click

		#region CafeNetButton_Click
		private void CafeNetButton_Click(object sender, System.EventArgs e)
		{
			focusPanel.Height = cafeNetButton.Height;
			focusPanel.Top = cafeNetButton.Top;
			currentPageLabel.Text = cafeNetButton.Text;
			iconPagePicturBox.Image = Properties.Resources.cafe_net_512;
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
		#endregion /Function
	}
}
