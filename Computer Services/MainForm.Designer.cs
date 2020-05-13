namespace ComputerServices
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.clockTimer = new System.Windows.Forms.Timer(this.components);
			this.notificationPanel = new Mbb.Windows.Forms.Panel();
			this.captionPanel = new Mbb.Windows.Forms.Panel();
			this.iconPagePicturBox = new Mbb.Windows.Forms.PicturBox();
			this.currentPageLabel = new Mbb.Windows.Forms.Label();
			this.adDateLabel = new Mbb.Windows.Forms.Label();
			this.solarDateLabel = new Mbb.Windows.Forms.Label();
			this.timePanel = new Mbb.Windows.Forms.Panel();
			this.secondLabel = new Mbb.Windows.Forms.Label();
			this.hourLabel = new Mbb.Windows.Forms.Label();
			this.separatorLabel1 = new Mbb.Windows.Forms.Label();
			this.separatorLabel2 = new Mbb.Windows.Forms.Label();
			this.minuteLabel = new Mbb.Windows.Forms.Label();
			this.mainPanel = new Mbb.Windows.Forms.Panel();
			this.menuPanel = new Mbb.Windows.Forms.Panel();
			this.cafeNetButton = new Mbb.Windows.Forms.Button();
			this.administratorToolsButton = new Mbb.Windows.Forms.Button();
			this.usernameLoginLabel = new Mbb.Windows.Forms.Label();
			this.userImagePicturBox = new Mbb.Windows.Forms.PicturBox();
			this.logputButton = new Mbb.Windows.Forms.Button();
			this.shutDownButton = new Mbb.Windows.Forms.Button();
			this.deliveryButton = new Mbb.Windows.Forms.Button();
			this.productButton = new Mbb.Windows.Forms.Button();
			this.reportButton = new Mbb.Windows.Forms.Button();
			this.clientButton = new Mbb.Windows.Forms.Button();
			this.focusPanel = new Mbb.Windows.Forms.Panel();
			this.servicesButton = new Mbb.Windows.Forms.Button();
			this.firstSizeButton = new Mbb.Windows.Forms.Button();
			this.secondSizeButton = new Mbb.Windows.Forms.Button();
			this.titlePanel = new Mbb.Windows.Forms.Panel();
			this.loginPicturBox = new Mbb.Windows.Forms.PicturBox();
			this.mainPageLabel = new Mbb.Windows.Forms.Label();
			this.minimizeButton = new Mbb.Windows.Forms.Button();
			this.closeButton = new Mbb.Windows.Forms.Button();
			this.maximizeButton = new Mbb.Windows.Forms.Button();
			this.restoreButton = new Mbb.Windows.Forms.Button();
			this.notificationPanel.SuspendLayout();
			this.captionPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconPagePicturBox)).BeginInit();
			this.timePanel.SuspendLayout();
			this.menuPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.userImagePicturBox)).BeginInit();
			this.titlePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.loginPicturBox)).BeginInit();
			this.SuspendLayout();
			// 
			// clockTimer
			// 
			this.clockTimer.Tick += new System.EventHandler(this.ClockTimer_Tick);
			// 
			// notificationPanel
			// 
			this.notificationPanel.BackColor = System.Drawing.Color.SeaGreen;
			this.notificationPanel.Controls.Add(this.captionPanel);
			this.notificationPanel.Controls.Add(this.adDateLabel);
			this.notificationPanel.Controls.Add(this.solarDateLabel);
			this.notificationPanel.Controls.Add(this.timePanel);
			this.notificationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.notificationPanel.Location = new System.Drawing.Point(180, 27);
			this.notificationPanel.Name = "notificationPanel";
			this.notificationPanel.Size = new System.Drawing.Size(934, 100);
			this.notificationPanel.TabIndex = 4;
			this.notificationPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NotificationPanel_MouseDown);
			// 
			// captionPanel
			// 
			this.captionPanel.Controls.Add(this.iconPagePicturBox);
			this.captionPanel.Controls.Add(this.currentPageLabel);
			this.captionPanel.Location = new System.Drawing.Point(11, 4);
			this.captionPanel.Name = "captionPanel";
			this.captionPanel.Size = new System.Drawing.Size(288, 89);
			this.captionPanel.TabIndex = 27;
			// 
			// iconPagePicturBox
			// 
			this.iconPagePicturBox.Image = global::ComputerServices.Properties.Resources.computer_support_512;
			this.iconPagePicturBox.Location = new System.Drawing.Point(124, 3);
			this.iconPagePicturBox.Name = "iconPagePicturBox";
			this.iconPagePicturBox.Size = new System.Drawing.Size(40, 40);
			this.iconPagePicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.iconPagePicturBox.TabIndex = 27;
			this.iconPagePicturBox.TabStop = false;
			// 
			// currentPageLabel
			// 
			this.currentPageLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.currentPageLabel.Font = new System.Drawing.Font("B Yekan", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.currentPageLabel.ForeColor = System.Drawing.Color.Yellow;
			this.currentPageLabel.Location = new System.Drawing.Point(0, 34);
			this.currentPageLabel.Name = "currentPageLabel";
			this.currentPageLabel.Size = new System.Drawing.Size(288, 55);
			this.currentPageLabel.TabIndex = 26;
			this.currentPageLabel.Text = "خدمات";
			this.currentPageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// adDateLabel
			// 
			this.adDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.adDateLabel.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.adDateLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.adDateLabel.Location = new System.Drawing.Point(723, 72);
			this.adDateLabel.Name = "adDateLabel";
			this.adDateLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.adDateLabel.Size = new System.Drawing.Size(207, 25);
			this.adDateLabel.TabIndex = 25;
			this.adDateLabel.Text = "تقویم میلادی";
			this.adDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// solarDateLabel
			// 
			this.solarDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.solarDateLabel.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.solarDateLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.solarDateLabel.Location = new System.Drawing.Point(689, 49);
			this.solarDateLabel.Name = "solarDateLabel";
			this.solarDateLabel.Size = new System.Drawing.Size(206, 25);
			this.solarDateLabel.TabIndex = 24;
			this.solarDateLabel.Text = "تقویم شمسی";
			this.solarDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// timePanel
			// 
			this.timePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.timePanel.Controls.Add(this.secondLabel);
			this.timePanel.Controls.Add(this.hourLabel);
			this.timePanel.Controls.Add(this.separatorLabel1);
			this.timePanel.Controls.Add(this.separatorLabel2);
			this.timePanel.Controls.Add(this.minuteLabel);
			this.timePanel.Location = new System.Drawing.Point(689, 5);
			this.timePanel.Name = "timePanel";
			this.timePanel.Size = new System.Drawing.Size(241, 41);
			this.timePanel.TabIndex = 23;
			// 
			// secondLabel
			// 
			this.secondLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.secondLabel.AutoSize = true;
			this.secondLabel.Font = new System.Drawing.Font("Castellar", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.secondLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.secondLabel.Location = new System.Drawing.Point(166, 0);
			this.secondLabel.Name = "secondLabel";
			this.secondLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.secondLabel.Size = new System.Drawing.Size(65, 40);
			this.secondLabel.TabIndex = 13;
			this.secondLabel.Text = "00";
			this.secondLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// hourLabel
			// 
			this.hourLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.hourLabel.AutoSize = true;
			this.hourLabel.Font = new System.Drawing.Font("Castellar", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hourLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.hourLabel.Location = new System.Drawing.Point(9, 0);
			this.hourLabel.Name = "hourLabel";
			this.hourLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.hourLabel.Size = new System.Drawing.Size(65, 40);
			this.hourLabel.TabIndex = 9;
			this.hourLabel.Text = "00";
			this.hourLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// separatorLabel1
			// 
			this.separatorLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.separatorLabel1.AutoSize = true;
			this.separatorLabel1.Font = new System.Drawing.Font("Castellar", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.separatorLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.separatorLabel1.Location = new System.Drawing.Point(68, 0);
			this.separatorLabel1.Name = "separatorLabel1";
			this.separatorLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.separatorLabel1.Size = new System.Drawing.Size(25, 40);
			this.separatorLabel1.TabIndex = 10;
			this.separatorLabel1.Text = ":";
			this.separatorLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// separatorLabel2
			// 
			this.separatorLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.separatorLabel2.AutoSize = true;
			this.separatorLabel2.Font = new System.Drawing.Font("Castellar", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.separatorLabel2.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.separatorLabel2.Location = new System.Drawing.Point(147, 0);
			this.separatorLabel2.Name = "separatorLabel2";
			this.separatorLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.separatorLabel2.Size = new System.Drawing.Size(25, 40);
			this.separatorLabel2.TabIndex = 12;
			this.separatorLabel2.Text = ":";
			this.separatorLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// minuteLabel
			// 
			this.minuteLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.minuteLabel.AutoSize = true;
			this.minuteLabel.Font = new System.Drawing.Font("Castellar", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.minuteLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.minuteLabel.Location = new System.Drawing.Point(88, 0);
			this.minuteLabel.Name = "minuteLabel";
			this.minuteLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.minuteLabel.Size = new System.Drawing.Size(65, 40);
			this.minuteLabel.TabIndex = 11;
			this.minuteLabel.Text = "00";
			this.minuteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// mainPanel
			// 
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.mainPanel.Location = new System.Drawing.Point(180, 127);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(934, 500);
			this.mainPanel.TabIndex = 2;
			// 
			// menuPanel
			// 
			this.menuPanel.Controls.Add(this.cafeNetButton);
			this.menuPanel.Controls.Add(this.administratorToolsButton);
			this.menuPanel.Controls.Add(this.usernameLoginLabel);
			this.menuPanel.Controls.Add(this.userImagePicturBox);
			this.menuPanel.Controls.Add(this.logputButton);
			this.menuPanel.Controls.Add(this.shutDownButton);
			this.menuPanel.Controls.Add(this.deliveryButton);
			this.menuPanel.Controls.Add(this.productButton);
			this.menuPanel.Controls.Add(this.reportButton);
			this.menuPanel.Controls.Add(this.clientButton);
			this.menuPanel.Controls.Add(this.focusPanel);
			this.menuPanel.Controls.Add(this.servicesButton);
			this.menuPanel.Controls.Add(this.firstSizeButton);
			this.menuPanel.Controls.Add(this.secondSizeButton);
			this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.menuPanel.Location = new System.Drawing.Point(0, 27);
			this.menuPanel.Name = "menuPanel";
			this.menuPanel.Size = new System.Drawing.Size(180, 600);
			this.menuPanel.TabIndex = 1;
			this.menuPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuPanel_MouseDown);
			// 
			// cafeNetButton
			// 
			this.cafeNetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cafeNetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.cafeNetButton.FlatAppearance.BorderSize = 0;
			this.cafeNetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cafeNetButton.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.cafeNetButton.ForeColor = System.Drawing.Color.White;
			this.cafeNetButton.Image = ((System.Drawing.Image)(resources.GetObject("cafeNetButton.Image")));
			this.cafeNetButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cafeNetButton.Location = new System.Drawing.Point(-1, 405);
			this.cafeNetButton.Name = "cafeNetButton";
			this.cafeNetButton.Size = new System.Drawing.Size(171, 36);
			this.cafeNetButton.TabIndex = 12;
			this.cafeNetButton.Text = "کافی نت";
			this.cafeNetButton.UseVisualStyleBackColor = false;
			this.cafeNetButton.Click += new System.EventHandler(this.CafeNetButton_Click);
			// 
			// administratorToolsButton
			// 
			this.administratorToolsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.administratorToolsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.administratorToolsButton.FlatAppearance.BorderSize = 0;
			this.administratorToolsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.administratorToolsButton.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.administratorToolsButton.ForeColor = System.Drawing.Color.White;
			this.administratorToolsButton.Image = ((System.Drawing.Image)(resources.GetObject("administratorToolsButton.Image")));
			this.administratorToolsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.administratorToolsButton.Location = new System.Drawing.Point(-1, 364);
			this.administratorToolsButton.Name = "administratorToolsButton";
			this.administratorToolsButton.Size = new System.Drawing.Size(171, 36);
			this.administratorToolsButton.TabIndex = 11;
			this.administratorToolsButton.Text = "ابزار مدیریت";
			this.administratorToolsButton.UseVisualStyleBackColor = false;
			this.administratorToolsButton.Click += new System.EventHandler(this.AdministratorToolsButton_Click);
			// 
			// usernameLoginLabel
			// 
			this.usernameLoginLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.usernameLoginLabel.AutoSize = true;
			this.usernameLoginLabel.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.usernameLoginLabel.ForeColor = System.Drawing.Color.White;
			this.usernameLoginLabel.Location = new System.Drawing.Point(53, 132);
			this.usernameLoginLabel.Name = "usernameLoginLabel";
			this.usernameLoginLabel.Size = new System.Drawing.Size(90, 19);
			this.usernameLoginLabel.TabIndex = 10;
			this.usernameLoginLabel.Text = "نام کابر وارد شده";
			// 
			// userImagePicturBox
			// 
			this.userImagePicturBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.userImagePicturBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.userImagePicturBox.Image = ((System.Drawing.Image)(resources.GetObject("userImagePicturBox.Image")));
			this.userImagePicturBox.Location = new System.Drawing.Point(47, 38);
			this.userImagePicturBox.Name = "userImagePicturBox";
			this.userImagePicturBox.Size = new System.Drawing.Size(86, 89);
			this.userImagePicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.userImagePicturBox.TabIndex = 9;
			this.userImagePicturBox.TabStop = false;
			// 
			// logputButton
			// 
			this.logputButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.logputButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logputButton.BackgroundImage")));
			this.logputButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.logputButton.FlatAppearance.BorderSize = 0;
			this.logputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.logputButton.Location = new System.Drawing.Point(112, 561);
			this.logputButton.Name = "logputButton";
			this.logputButton.Size = new System.Drawing.Size(26, 27);
			this.logputButton.TabIndex = 8;
			this.logputButton.UseVisualStyleBackColor = true;
			this.logputButton.Click += new System.EventHandler(this.LogputButton_Click);
			// 
			// shutDownButton
			// 
			this.shutDownButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.shutDownButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("shutDownButton.BackgroundImage")));
			this.shutDownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.shutDownButton.FlatAppearance.BorderSize = 0;
			this.shutDownButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
			this.shutDownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.shutDownButton.Location = new System.Drawing.Point(144, 561);
			this.shutDownButton.Name = "shutDownButton";
			this.shutDownButton.Size = new System.Drawing.Size(26, 27);
			this.shutDownButton.TabIndex = 7;
			this.shutDownButton.UseVisualStyleBackColor = true;
			this.shutDownButton.Click += new System.EventHandler(this.ShutDownButton_Click);
			// 
			// deliveryButton
			// 
			this.deliveryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.deliveryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.deliveryButton.FlatAppearance.BorderSize = 0;
			this.deliveryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.deliveryButton.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.deliveryButton.ForeColor = System.Drawing.Color.White;
			this.deliveryButton.Image = ((System.Drawing.Image)(resources.GetObject("deliveryButton.Image")));
			this.deliveryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.deliveryButton.Location = new System.Drawing.Point(-1, 323);
			this.deliveryButton.Name = "deliveryButton";
			this.deliveryButton.Size = new System.Drawing.Size(171, 36);
			this.deliveryButton.TabIndex = 6;
			this.deliveryButton.Text = "ارسالی";
			this.deliveryButton.UseVisualStyleBackColor = false;
			this.deliveryButton.Click += new System.EventHandler(this.DeliveryButton_Click);
			// 
			// productButton
			// 
			this.productButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.productButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.productButton.FlatAppearance.BorderSize = 0;
			this.productButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.productButton.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.productButton.ForeColor = System.Drawing.Color.White;
			this.productButton.Image = ((System.Drawing.Image)(resources.GetObject("productButton.Image")));
			this.productButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.productButton.Location = new System.Drawing.Point(-1, 282);
			this.productButton.Name = "productButton";
			this.productButton.Size = new System.Drawing.Size(171, 36);
			this.productButton.TabIndex = 5;
			this.productButton.Text = "محصولات";
			this.productButton.UseVisualStyleBackColor = false;
			this.productButton.Click += new System.EventHandler(this.ProductButton_Click);
			// 
			// reportButton
			// 
			this.reportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.reportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.reportButton.FlatAppearance.BorderSize = 0;
			this.reportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.reportButton.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.reportButton.ForeColor = System.Drawing.Color.White;
			this.reportButton.Image = ((System.Drawing.Image)(resources.GetObject("reportButton.Image")));
			this.reportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.reportButton.Location = new System.Drawing.Point(-1, 241);
			this.reportButton.Name = "reportButton";
			this.reportButton.Size = new System.Drawing.Size(171, 36);
			this.reportButton.TabIndex = 4;
			this.reportButton.Text = "گزارش";
			this.reportButton.UseVisualStyleBackColor = false;
			this.reportButton.Click += new System.EventHandler(this.ReportButton_Click);
			// 
			// clientButton
			// 
			this.clientButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.clientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.clientButton.FlatAppearance.BorderSize = 0;
			this.clientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.clientButton.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.clientButton.ForeColor = System.Drawing.Color.White;
			this.clientButton.Image = ((System.Drawing.Image)(resources.GetObject("clientButton.Image")));
			this.clientButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.clientButton.Location = new System.Drawing.Point(-1, 200);
			this.clientButton.Name = "clientButton";
			this.clientButton.Size = new System.Drawing.Size(171, 36);
			this.clientButton.TabIndex = 3;
			this.clientButton.Text = "مشتری";
			this.clientButton.UseVisualStyleBackColor = false;
			this.clientButton.Click += new System.EventHandler(this.ClientButton_Click);
			// 
			// focusPanel
			// 
			this.focusPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.focusPanel.BackColor = System.Drawing.Color.Lime;
			this.focusPanel.Location = new System.Drawing.Point(171, 158);
			this.focusPanel.Name = "focusPanel";
			this.focusPanel.Size = new System.Drawing.Size(9, 36);
			this.focusPanel.TabIndex = 2;
			// 
			// servicesButton
			// 
			this.servicesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.servicesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.servicesButton.FlatAppearance.BorderSize = 0;
			this.servicesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.servicesButton.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.servicesButton.ForeColor = System.Drawing.Color.White;
			this.servicesButton.Image = ((System.Drawing.Image)(resources.GetObject("servicesButton.Image")));
			this.servicesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.servicesButton.Location = new System.Drawing.Point(-1, 158);
			this.servicesButton.Name = "servicesButton";
			this.servicesButton.Size = new System.Drawing.Size(171, 36);
			this.servicesButton.TabIndex = 1;
			this.servicesButton.Text = "خدمات";
			this.servicesButton.UseVisualStyleBackColor = false;
			this.servicesButton.Click += new System.EventHandler(this.ServicesButton_Click);
			// 
			// firstSizeButton
			// 
			this.firstSizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("firstSizeButton.BackgroundImage")));
			this.firstSizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.firstSizeButton.FlatAppearance.BorderSize = 0;
			this.firstSizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.firstSizeButton.Location = new System.Drawing.Point(0, 0);
			this.firstSizeButton.Name = "firstSizeButton";
			this.firstSizeButton.Size = new System.Drawing.Size(40, 18);
			this.firstSizeButton.TabIndex = 0;
			this.firstSizeButton.UseVisualStyleBackColor = true;
			this.firstSizeButton.Click += new System.EventHandler(this.FirstSizeButton_Click);
			// 
			// secondSizeButton
			// 
			this.secondSizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("secondSizeButton.BackgroundImage")));
			this.secondSizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.secondSizeButton.FlatAppearance.BorderSize = 0;
			this.secondSizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.secondSizeButton.Location = new System.Drawing.Point(0, 0);
			this.secondSizeButton.Name = "secondSizeButton";
			this.secondSizeButton.Size = new System.Drawing.Size(40, 18);
			this.secondSizeButton.TabIndex = 13;
			this.secondSizeButton.UseVisualStyleBackColor = true;
			this.secondSizeButton.Click += new System.EventHandler(this.SecondSizeButton_Click);
			// 
			// titlePanel
			// 
			this.titlePanel.Controls.Add(this.loginPicturBox);
			this.titlePanel.Controls.Add(this.mainPageLabel);
			this.titlePanel.Controls.Add(this.minimizeButton);
			this.titlePanel.Controls.Add(this.closeButton);
			this.titlePanel.Controls.Add(this.maximizeButton);
			this.titlePanel.Controls.Add(this.restoreButton);
			this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.titlePanel.Location = new System.Drawing.Point(0, 0);
			this.titlePanel.Name = "titlePanel";
			this.titlePanel.Size = new System.Drawing.Size(1114, 27);
			this.titlePanel.TabIndex = 0;
			this.titlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitlePanel_MouseDown);
			// 
			// loginPicturBox
			// 
			this.loginPicturBox.Dock = System.Windows.Forms.DockStyle.Right;
			this.loginPicturBox.Image = ((System.Drawing.Image)(resources.GetObject("loginPicturBox.Image")));
			this.loginPicturBox.Location = new System.Drawing.Point(1088, 0);
			this.loginPicturBox.Name = "loginPicturBox";
			this.loginPicturBox.Size = new System.Drawing.Size(26, 27);
			this.loginPicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.loginPicturBox.TabIndex = 7;
			this.loginPicturBox.TabStop = false;
			// 
			// mainPageLabel
			// 
			this.mainPageLabel.AutoSize = true;
			this.mainPageLabel.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.mainPageLabel.ForeColor = System.Drawing.Color.White;
			this.mainPageLabel.Location = new System.Drawing.Point(1005, 2);
			this.mainPageLabel.Name = "mainPageLabel";
			this.mainPageLabel.Size = new System.Drawing.Size(78, 22);
			this.mainPageLabel.TabIndex = 6;
			this.mainPageLabel.Text = "صفحه اصلی";
			// 
			// minimizeButton
			// 
			this.minimizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizeButton.BackgroundImage")));
			this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.minimizeButton.FlatAppearance.BorderSize = 0;
			this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.minimizeButton.Location = new System.Drawing.Point(54, 6);
			this.minimizeButton.Name = "minimizeButton";
			this.minimizeButton.Size = new System.Drawing.Size(15, 15);
			this.minimizeButton.TabIndex = 5;
			this.minimizeButton.UseVisualStyleBackColor = true;
			this.minimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
			// 
			// closeButton
			// 
			this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
			this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.closeButton.FlatAppearance.BorderSize = 0;
			this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
			this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeButton.Location = new System.Drawing.Point(12, 6);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(15, 15);
			this.closeButton.TabIndex = 4;
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// maximizeButton
			// 
			this.maximizeButton.BackgroundImage = global::ComputerServices.Properties.Resources.maximize_button_512;
			this.maximizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.maximizeButton.FlatAppearance.BorderSize = 0;
			this.maximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.maximizeButton.Location = new System.Drawing.Point(33, 6);
			this.maximizeButton.Name = "maximizeButton";
			this.maximizeButton.Size = new System.Drawing.Size(15, 15);
			this.maximizeButton.TabIndex = 8;
			this.maximizeButton.UseVisualStyleBackColor = true;
			this.maximizeButton.Click += new System.EventHandler(this.MaximizeButton_Click);
			// 
			// restoreButton
			// 
			this.restoreButton.BackgroundImage = global::ComputerServices.Properties.Resources.restore_down_512;
			this.restoreButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.restoreButton.FlatAppearance.BorderSize = 0;
			this.restoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.restoreButton.Location = new System.Drawing.Point(33, 6);
			this.restoreButton.Name = "restoreButton";
			this.restoreButton.Size = new System.Drawing.Size(15, 15);
			this.restoreButton.TabIndex = 9;
			this.restoreButton.UseVisualStyleBackColor = true;
			this.restoreButton.Click += new System.EventHandler(this.RestoreButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Maroon;
			this.ClientSize = new System.Drawing.Size(1114, 627);
			this.Controls.Add(this.notificationPanel);
			this.Controls.Add(this.mainPanel);
			this.Controls.Add(this.menuPanel);
			this.Controls.Add(this.titlePanel);
			this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.Name = "MainForm";
			this.Opacity = 0.95D;
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Text = "MainForm";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.notificationPanel.ResumeLayout(false);
			this.captionPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.iconPagePicturBox)).EndInit();
			this.timePanel.ResumeLayout(false);
			this.timePanel.PerformLayout();
			this.menuPanel.ResumeLayout(false);
			this.menuPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.userImagePicturBox)).EndInit();
			this.titlePanel.ResumeLayout(false);
			this.titlePanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.loginPicturBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Mbb.Windows.Forms.Panel titlePanel;
		private Mbb.Windows.Forms.Button minimizeButton;
		private Mbb.Windows.Forms.Button closeButton;
		private Mbb.Windows.Forms.Panel menuPanel;
		private Mbb.Windows.Forms.Button deliveryButton;
		private Mbb.Windows.Forms.Button productButton;
		private Mbb.Windows.Forms.Button reportButton;
		private Mbb.Windows.Forms.Button clientButton;
		private Mbb.Windows.Forms.Panel focusPanel;
		private Mbb.Windows.Forms.Button servicesButton;
		private Mbb.Windows.Forms.Button firstSizeButton;
		private Mbb.Windows.Forms.Panel mainPanel;
		private Mbb.Windows.Forms.Button logputButton;
		private Mbb.Windows.Forms.Button shutDownButton;
		private Mbb.Windows.Forms.Button administratorToolsButton;
		private Mbb.Windows.Forms.Label usernameLoginLabel;
		private Mbb.Windows.Forms.PicturBox userImagePicturBox;
		private Mbb.Windows.Forms.Panel notificationPanel;
		private Mbb.Windows.Forms.Panel timePanel;
		private Mbb.Windows.Forms.Label secondLabel;
		private Mbb.Windows.Forms.Label minuteLabel;
		private Mbb.Windows.Forms.Label hourLabel;
		private Mbb.Windows.Forms.Label separatorLabel1;
		private Mbb.Windows.Forms.Label separatorLabel2;
		private Mbb.Windows.Forms.PicturBox loginPicturBox;
		private Mbb.Windows.Forms.Label mainPageLabel;
		private Mbb.Windows.Forms.Label adDateLabel;
		private Mbb.Windows.Forms.Label solarDateLabel;
		private Mbb.Windows.Forms.Button cafeNetButton;
		private Mbb.Windows.Forms.Button maximizeButton;
		private Mbb.Windows.Forms.Button restoreButton;
		private System.Windows.Forms.Timer clockTimer;
		private Mbb.Windows.Forms.Button secondSizeButton;
		private Mbb.Windows.Forms.Panel captionPanel;
		private Mbb.Windows.Forms.PicturBox iconPagePicturBox;
		private Mbb.Windows.Forms.Label currentPageLabel;
	}
}