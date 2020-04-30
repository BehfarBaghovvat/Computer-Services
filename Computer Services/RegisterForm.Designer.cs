namespace ComputerServices
{
	partial class RegisterForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
			this.titlePanel = new Mbb.Windows.Forms.Panel();
			this.RegisterLogoPicturBox = new Mbb.Windows.Forms.PicturBox();
			this.Registerlabel = new Mbb.Windows.Forms.Label();
			this.minimizeButton = new Mbb.Windows.Forms.Button();
			this.closeButton = new Mbb.Windows.Forms.Button();
			this.firstNamePanel = new Mbb.Windows.Forms.Panel();
			this.firstNameTextBox = new Mbb.Windows.Forms.TextBox();
			this.personalInformationGroupBox = new Mbb.Windows.Forms.GroupBox();
			this.maritalStatusGroupBox = new Mbb.Windows.Forms.GroupBox();
			this.singleRadioButton = new Mbb.Windows.Forms.RadioButton();
			this.marriedRadioButton = new Mbb.Windows.Forms.RadioButton();
			this.addressTextBox = new Mbb.Windows.Forms.TextBox();
			this.addressPanel = new Mbb.Windows.Forms.Panel();
			this.nationalCodeTextBox = new Mbb.Windows.Forms.TextBox();
			this.nationalCodePanel = new Mbb.Windows.Forms.Panel();
			this.lastNameTextBox = new Mbb.Windows.Forms.TextBox();
			this.lastNamePanel = new Mbb.Windows.Forms.Panel();
			this.telTextBox = new Mbb.Windows.Forms.TextBox();
			this.telPanel = new Mbb.Windows.Forms.Panel();
			this.userInformationGroupBox = new Mbb.Windows.Forms.GroupBox();
			this.emailTextBox = new Mbb.Windows.Forms.TextBox();
			this.userImagePicturBox = new Mbb.Windows.Forms.CircularPictureBox();
			this.deleteImageButton = new Mbb.Windows.Forms.Button();
			this.passwordShowPicturBox2 = new Mbb.Windows.Forms.PicturBox();
			this.addPictureLinkLabel = new Mbb.Windows.Forms.LinkLabel();
			this.passwordShowPicturBox1 = new Mbb.Windows.Forms.PicturBox();
			this.confirmEmailTickPicturBox = new Mbb.Windows.Forms.PicturBox();
			this.confirmUsernameTickPicturBox = new Mbb.Windows.Forms.PicturBox();
			this.descriptionTextBox = new Mbb.Windows.Forms.TextBox();
			this.descriptionPanel = new Mbb.Windows.Forms.Panel();
			this.passwordConfirmTextBox = new Mbb.Windows.Forms.TextBox();
			this.passwordConfirmPanel = new Mbb.Windows.Forms.Panel();
			this.passwordTextBox = new Mbb.Windows.Forms.TextBox();
			this.passwordPanel = new Mbb.Windows.Forms.Panel();
			this.emailPanel = new Mbb.Windows.Forms.Panel();
			this.usernameTextBox = new Mbb.Windows.Forms.TextBox();
			this.usernamePanel = new Mbb.Windows.Forms.Panel();
			this.loginButton = new Mbb.Windows.Forms.Button();
			this.saveButton = new Mbb.Windows.Forms.Button();
			this.resetButton = new Mbb.Windows.Forms.Button();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.titlePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.RegisterLogoPicturBox)).BeginInit();
			this.personalInformationGroupBox.SuspendLayout();
			this.maritalStatusGroupBox.SuspendLayout();
			this.userInformationGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.userImagePicturBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.passwordShowPicturBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.passwordShowPicturBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.confirmEmailTickPicturBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.confirmUsernameTickPicturBox)).BeginInit();
			this.SuspendLayout();
			// 
			// titlePanel
			// 
			this.titlePanel.Controls.Add(this.RegisterLogoPicturBox);
			this.titlePanel.Controls.Add(this.Registerlabel);
			this.titlePanel.Controls.Add(this.minimizeButton);
			this.titlePanel.Controls.Add(this.closeButton);
			this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.titlePanel.Location = new System.Drawing.Point(0, 0);
			this.titlePanel.Name = "titlePanel";
			this.titlePanel.Size = new System.Drawing.Size(800, 30);
			this.titlePanel.TabIndex = 0;
			this.titlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitlePanel_MouseDown);
			// 
			// RegisterLogoPicturBox
			// 
			this.RegisterLogoPicturBox.Dock = System.Windows.Forms.DockStyle.Right;
			this.RegisterLogoPicturBox.Image = ((System.Drawing.Image)(resources.GetObject("RegisterLogoPicturBox.Image")));
			this.RegisterLogoPicturBox.Location = new System.Drawing.Point(770, 0);
			this.RegisterLogoPicturBox.Name = "RegisterLogoPicturBox";
			this.RegisterLogoPicturBox.Size = new System.Drawing.Size(30, 30);
			this.RegisterLogoPicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.RegisterLogoPicturBox.TabIndex = 5;
			this.RegisterLogoPicturBox.TabStop = false;
			// 
			// Registerlabel
			// 
			this.Registerlabel.AutoSize = true;
			this.Registerlabel.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.Registerlabel.ForeColor = System.Drawing.Color.White;
			this.Registerlabel.Location = new System.Drawing.Point(655, 3);
			this.Registerlabel.Name = "Registerlabel";
			this.Registerlabel.Size = new System.Drawing.Size(113, 24);
			this.Registerlabel.TabIndex = 0;
			this.Registerlabel.Text = "ثبت حساب کاربری";
			// 
			// minimizeButton
			// 
			this.minimizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizeButton.BackgroundImage")));
			this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.minimizeButton.FlatAppearance.BorderSize = 0;
			this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.minimizeButton.Location = new System.Drawing.Point(33, 8);
			this.minimizeButton.Name = "minimizeButton";
			this.minimizeButton.Size = new System.Drawing.Size(15, 15);
			this.minimizeButton.TabIndex = 2;
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
			this.closeButton.Location = new System.Drawing.Point(12, 8);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(15, 15);
			this.closeButton.TabIndex = 1;
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// firstNamePanel
			// 
			this.firstNamePanel.BackColor = System.Drawing.Color.DimGray;
			this.firstNamePanel.ForeColor = System.Drawing.Color.Transparent;
			this.firstNamePanel.Location = new System.Drawing.Point(496, 60);
			this.firstNamePanel.Name = "firstNamePanel";
			this.firstNamePanel.Size = new System.Drawing.Size(250, 1);
			this.firstNamePanel.TabIndex = 6;
			// 
			// firstNameTextBox
			// 
			this.firstNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
			this.firstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.firstNameTextBox.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.firstNameTextBox.ForeColor = System.Drawing.Color.DimGray;
			this.firstNameTextBox.Location = new System.Drawing.Point(496, 26);
			this.firstNameTextBox.MaxLength = 25;
			this.firstNameTextBox.Name = "firstNameTextBox";
			this.firstNameTextBox.Size = new System.Drawing.Size(250, 28);
			this.firstNameTextBox.TabIndex = 0;
			this.firstNameTextBox.Text = "نام";
			this.firstNameTextBox.Enter += new System.EventHandler(this.FirstNameTextBox_Enter);
			this.firstNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FirstNameTextBox_KeyPress);
			this.firstNameTextBox.Leave += new System.EventHandler(this.FirstNameTextBox_Leave);
			// 
			// personalInformationGroupBox
			// 
			this.personalInformationGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.personalInformationGroupBox.Controls.Add(this.maritalStatusGroupBox);
			this.personalInformationGroupBox.Controls.Add(this.addressTextBox);
			this.personalInformationGroupBox.Controls.Add(this.addressPanel);
			this.personalInformationGroupBox.Controls.Add(this.nationalCodeTextBox);
			this.personalInformationGroupBox.Controls.Add(this.nationalCodePanel);
			this.personalInformationGroupBox.Controls.Add(this.lastNameTextBox);
			this.personalInformationGroupBox.Controls.Add(this.lastNamePanel);
			this.personalInformationGroupBox.Controls.Add(this.telTextBox);
			this.personalInformationGroupBox.Controls.Add(this.telPanel);
			this.personalInformationGroupBox.Controls.Add(this.firstNameTextBox);
			this.personalInformationGroupBox.Controls.Add(this.firstNamePanel);
			this.personalInformationGroupBox.ForeColor = System.Drawing.Color.White;
			this.personalInformationGroupBox.Location = new System.Drawing.Point(15, 286);
			this.personalInformationGroupBox.Name = "personalInformationGroupBox";
			this.personalInformationGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.personalInformationGroupBox.Size = new System.Drawing.Size(770, 168);
			this.personalInformationGroupBox.TabIndex = 2;
			this.personalInformationGroupBox.TabStop = false;
			this.personalInformationGroupBox.Text = "اطلاعات شخصی";
			// 
			// maritalStatusGroupBox
			// 
			this.maritalStatusGroupBox.Controls.Add(this.singleRadioButton);
			this.maritalStatusGroupBox.Controls.Add(this.marriedRadioButton);
			this.maritalStatusGroupBox.ForeColor = System.Drawing.Color.White;
			this.maritalStatusGroupBox.Location = new System.Drawing.Point(26, 42);
			this.maritalStatusGroupBox.Name = "maritalStatusGroupBox";
			this.maritalStatusGroupBox.Size = new System.Drawing.Size(167, 84);
			this.maritalStatusGroupBox.TabIndex = 5;
			this.maritalStatusGroupBox.TabStop = false;
			this.maritalStatusGroupBox.Text = "وضعیت تاهل";
			// 
			// singleRadioButton
			// 
			this.singleRadioButton.AutoSize = true;
			this.singleRadioButton.Location = new System.Drawing.Point(29, 52);
			this.singleRadioButton.Name = "singleRadioButton";
			this.singleRadioButton.Size = new System.Drawing.Size(112, 23);
			this.singleRadioButton.TabIndex = 1;
			this.singleRadioButton.TabStop = true;
			this.singleRadioButton.Text = "مجرد (بدون همسر)";
			this.singleRadioButton.UseVisualStyleBackColor = true;
			this.singleRadioButton.Click += new System.EventHandler(this.SingleRadioButton_Click);
			// 
			// marriedRadioButton
			// 
			this.marriedRadioButton.AutoSize = true;
			this.marriedRadioButton.Location = new System.Drawing.Point(25, 23);
			this.marriedRadioButton.Name = "marriedRadioButton";
			this.marriedRadioButton.Size = new System.Drawing.Size(116, 23);
			this.marriedRadioButton.TabIndex = 0;
			this.marriedRadioButton.TabStop = true;
			this.marriedRadioButton.Text = "متاهل (دارای همسر)";
			this.marriedRadioButton.UseVisualStyleBackColor = true;
			this.marriedRadioButton.Click += new System.EventHandler(this.MarriedRadioButton_Click);
			// 
			// addressTextBox
			// 
			this.addressTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
			this.addressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.addressTextBox.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.addressTextBox.ForeColor = System.Drawing.Color.DimGray;
			this.addressTextBox.Location = new System.Drawing.Point(224, 114);
			this.addressTextBox.MaxLength = 500;
			this.addressTextBox.Name = "addressTextBox";
			this.addressTextBox.Size = new System.Drawing.Size(522, 28);
			this.addressTextBox.TabIndex = 4;
			this.addressTextBox.Text = "آدرس";
			this.addressTextBox.Enter += new System.EventHandler(this.AddressTextBox_Enter);
			this.addressTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddressTextBox_KeyPress);
			this.addressTextBox.Leave += new System.EventHandler(this.AddressTextBox_Leave);
			// 
			// addressPanel
			// 
			this.addressPanel.BackColor = System.Drawing.Color.DimGray;
			this.addressPanel.ForeColor = System.Drawing.Color.Transparent;
			this.addressPanel.Location = new System.Drawing.Point(224, 148);
			this.addressPanel.Name = "addressPanel";
			this.addressPanel.Size = new System.Drawing.Size(522, 1);
			this.addressPanel.TabIndex = 10;
			// 
			// nationalCodeTextBox
			// 
			this.nationalCodeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
			this.nationalCodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.nationalCodeTextBox.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.nationalCodeTextBox.ForeColor = System.Drawing.Color.DimGray;
			this.nationalCodeTextBox.Location = new System.Drawing.Point(224, 70);
			this.nationalCodeTextBox.MaxLength = 10;
			this.nationalCodeTextBox.Name = "nationalCodeTextBox";
			this.nationalCodeTextBox.Size = new System.Drawing.Size(250, 28);
			this.nationalCodeTextBox.TabIndex = 3;
			this.nationalCodeTextBox.Text = "کد ملی";
			this.nationalCodeTextBox.Enter += new System.EventHandler(this.NationalCodeTextBox_Enter);
			this.nationalCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NationalCodeTextBox_KeyPress);
			this.nationalCodeTextBox.Leave += new System.EventHandler(this.NationalCodeTextBox_Leave);
			// 
			// nationalCodePanel
			// 
			this.nationalCodePanel.BackColor = System.Drawing.Color.DimGray;
			this.nationalCodePanel.ForeColor = System.Drawing.Color.Transparent;
			this.nationalCodePanel.Location = new System.Drawing.Point(224, 104);
			this.nationalCodePanel.Name = "nationalCodePanel";
			this.nationalCodePanel.Size = new System.Drawing.Size(250, 1);
			this.nationalCodePanel.TabIndex = 9;
			// 
			// lastNameTextBox
			// 
			this.lastNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
			this.lastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lastNameTextBox.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.lastNameTextBox.ForeColor = System.Drawing.Color.DimGray;
			this.lastNameTextBox.Location = new System.Drawing.Point(224, 26);
			this.lastNameTextBox.MaxLength = 30;
			this.lastNameTextBox.Name = "lastNameTextBox";
			this.lastNameTextBox.Size = new System.Drawing.Size(250, 28);
			this.lastNameTextBox.TabIndex = 1;
			this.lastNameTextBox.Text = "نام خانوادگی";
			this.lastNameTextBox.Enter += new System.EventHandler(this.LastNameTextBox_Enter);
			this.lastNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LastNameTextBox_KeyPress);
			this.lastNameTextBox.Leave += new System.EventHandler(this.LastNameTextBox_Leave);
			// 
			// lastNamePanel
			// 
			this.lastNamePanel.BackColor = System.Drawing.Color.DimGray;
			this.lastNamePanel.ForeColor = System.Drawing.Color.Transparent;
			this.lastNamePanel.Location = new System.Drawing.Point(224, 60);
			this.lastNamePanel.Name = "lastNamePanel";
			this.lastNamePanel.Size = new System.Drawing.Size(250, 1);
			this.lastNamePanel.TabIndex = 7;
			// 
			// telTextBox
			// 
			this.telTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
			this.telTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.telTextBox.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.telTextBox.ForeColor = System.Drawing.Color.DimGray;
			this.telTextBox.Location = new System.Drawing.Point(496, 70);
			this.telTextBox.MaxLength = 11;
			this.telTextBox.Name = "telTextBox";
			this.telTextBox.Size = new System.Drawing.Size(250, 28);
			this.telTextBox.TabIndex = 2;
			this.telTextBox.Text = "شماره تماس";
			this.toolTip1.SetToolTip(this.telTextBox, "شماره مبایل معتبر وارد نمایید!");
			this.telTextBox.Enter += new System.EventHandler(this.TelTextBox_Enter);
			this.telTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelTextBox_KeyPress);
			this.telTextBox.Leave += new System.EventHandler(this.TelTextBox_Leave);
			// 
			// telPanel
			// 
			this.telPanel.BackColor = System.Drawing.Color.DimGray;
			this.telPanel.ForeColor = System.Drawing.Color.Transparent;
			this.telPanel.Location = new System.Drawing.Point(496, 104);
			this.telPanel.Name = "telPanel";
			this.telPanel.Size = new System.Drawing.Size(250, 1);
			this.telPanel.TabIndex = 8;
			// 
			// userInformationGroupBox
			// 
			this.userInformationGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.userInformationGroupBox.Controls.Add(this.emailTextBox);
			this.userInformationGroupBox.Controls.Add(this.userImagePicturBox);
			this.userInformationGroupBox.Controls.Add(this.deleteImageButton);
			this.userInformationGroupBox.Controls.Add(this.passwordShowPicturBox2);
			this.userInformationGroupBox.Controls.Add(this.addPictureLinkLabel);
			this.userInformationGroupBox.Controls.Add(this.passwordShowPicturBox1);
			this.userInformationGroupBox.Controls.Add(this.confirmEmailTickPicturBox);
			this.userInformationGroupBox.Controls.Add(this.confirmUsernameTickPicturBox);
			this.userInformationGroupBox.Controls.Add(this.descriptionTextBox);
			this.userInformationGroupBox.Controls.Add(this.descriptionPanel);
			this.userInformationGroupBox.Controls.Add(this.passwordConfirmTextBox);
			this.userInformationGroupBox.Controls.Add(this.passwordConfirmPanel);
			this.userInformationGroupBox.Controls.Add(this.passwordTextBox);
			this.userInformationGroupBox.Controls.Add(this.passwordPanel);
			this.userInformationGroupBox.Controls.Add(this.emailPanel);
			this.userInformationGroupBox.Controls.Add(this.usernameTextBox);
			this.userInformationGroupBox.Controls.Add(this.usernamePanel);
			this.userInformationGroupBox.ForeColor = System.Drawing.Color.White;
			this.userInformationGroupBox.Location = new System.Drawing.Point(15, 35);
			this.userInformationGroupBox.Name = "userInformationGroupBox";
			this.userInformationGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.userInformationGroupBox.Size = new System.Drawing.Size(770, 245);
			this.userInformationGroupBox.TabIndex = 1;
			this.userInformationGroupBox.TabStop = false;
			this.userInformationGroupBox.Text = "اطلاعات کاربری";
			// 
			// emailTextBox
			// 
			this.emailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
			this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.emailTextBox.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.emailTextBox.ForeColor = System.Drawing.Color.DimGray;
			this.emailTextBox.Location = new System.Drawing.Point(254, 31);
			this.emailTextBox.MaxLength = 60;
			this.emailTextBox.Name = "emailTextBox";
			this.emailTextBox.Size = new System.Drawing.Size(220, 28);
			this.emailTextBox.TabIndex = 1;
			this.emailTextBox.Text = "پست الکترونیکی";
			this.toolTip1.SetToolTip(this.emailTextBox, "پست الکترونیک معتبر وارد نمایید!");
			this.emailTextBox.Enter += new System.EventHandler(this.EmailTextBox_Enter);
			this.emailTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmailTextBox_KeyPress);
			this.emailTextBox.Leave += new System.EventHandler(this.EmailTextBox_Leave);
			// 
			// userImagePicturBox
			// 
			this.userImagePicturBox.BackgroundImage = global::ComputerServices.Properties.Resources.user_1024;
			this.userImagePicturBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.userImagePicturBox.Image = ((System.Drawing.Image)(resources.GetObject("userImagePicturBox.Image")));
			this.userImagePicturBox.Location = new System.Drawing.Point(27, 32);
			this.userImagePicturBox.Name = "userImagePicturBox";
			this.userImagePicturBox.Size = new System.Drawing.Size(170, 170);
			this.userImagePicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.userImagePicturBox.TabIndex = 17;
			this.userImagePicturBox.TabStop = false;
			// 
			// deleteImageButton
			// 
			this.deleteImageButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteImageButton.BackgroundImage")));
			this.deleteImageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.deleteImageButton.FlatAppearance.BorderSize = 0;
			this.deleteImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.deleteImageButton.Location = new System.Drawing.Point(60, 216);
			this.deleteImageButton.Name = "deleteImageButton";
			this.deleteImageButton.Size = new System.Drawing.Size(15, 15);
			this.deleteImageButton.TabIndex = 6;
			this.deleteImageButton.UseVisualStyleBackColor = true;
			this.deleteImageButton.Visible = false;
			this.deleteImageButton.Click += new System.EventHandler(this.DeleteImageButton_Click);
			// 
			// passwordShowPicturBox2
			// 
			this.passwordShowPicturBox2.Image = global::ComputerServices.Properties.Resources.show_512;
			this.passwordShowPicturBox2.Location = new System.Drawing.Point(224, 90);
			this.passwordShowPicturBox2.Name = "passwordShowPicturBox2";
			this.passwordShowPicturBox2.Size = new System.Drawing.Size(25, 25);
			this.passwordShowPicturBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.passwordShowPicturBox2.TabIndex = 15;
			this.passwordShowPicturBox2.TabStop = false;
			this.passwordShowPicturBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShowPasswordPicturBox2_MouseDown);
			this.passwordShowPicturBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShowPasswordPicturBox2_MouseUp);
			// 
			// addPictureLinkLabel
			// 
			this.addPictureLinkLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.addPictureLinkLabel.AutoSize = true;
			this.addPictureLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.addPictureLinkLabel.LinkColor = System.Drawing.Color.White;
			this.addPictureLinkLabel.Location = new System.Drawing.Point(81, 214);
			this.addPictureLinkLabel.Name = "addPictureLinkLabel";
			this.addPictureLinkLabel.Size = new System.Drawing.Size(67, 19);
			this.addPictureLinkLabel.TabIndex = 5;
			this.addPictureLinkLabel.TabStop = true;
			this.addPictureLinkLabel.Text = "افزودن عکس";
			this.addPictureLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddPictureLinkLabel_LinkClicked);
			// 
			// passwordShowPicturBox1
			// 
			this.passwordShowPicturBox1.Image = global::ComputerServices.Properties.Resources.show_512;
			this.passwordShowPicturBox1.Location = new System.Drawing.Point(496, 90);
			this.passwordShowPicturBox1.Name = "passwordShowPicturBox1";
			this.passwordShowPicturBox1.Size = new System.Drawing.Size(25, 25);
			this.passwordShowPicturBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.passwordShowPicturBox1.TabIndex = 14;
			this.passwordShowPicturBox1.TabStop = false;
			this.passwordShowPicturBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShowPasswordPicturBox1_MouseDown);
			this.passwordShowPicturBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShowPasswordPicturBox1_MouseUp);
			// 
			// confirmEmailTickPicturBox
			// 
			this.confirmEmailTickPicturBox.Image = global::ComputerServices.Properties.Resources.Tik_True;
			this.confirmEmailTickPicturBox.Location = new System.Drawing.Point(223, 33);
			this.confirmEmailTickPicturBox.Name = "confirmEmailTickPicturBox";
			this.confirmEmailTickPicturBox.Size = new System.Drawing.Size(25, 25);
			this.confirmEmailTickPicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.confirmEmailTickPicturBox.TabIndex = 13;
			this.confirmEmailTickPicturBox.TabStop = false;
			this.confirmEmailTickPicturBox.Visible = false;
			// 
			// confirmUsernameTickPicturBox
			// 
			this.confirmUsernameTickPicturBox.Image = global::ComputerServices.Properties.Resources.Tik_True;
			this.confirmUsernameTickPicturBox.Location = new System.Drawing.Point(495, 34);
			this.confirmUsernameTickPicturBox.Name = "confirmUsernameTickPicturBox";
			this.confirmUsernameTickPicturBox.Size = new System.Drawing.Size(25, 25);
			this.confirmUsernameTickPicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.confirmUsernameTickPicturBox.TabIndex = 12;
			this.confirmUsernameTickPicturBox.TabStop = false;
			this.confirmUsernameTickPicturBox.Visible = false;
			// 
			// descriptionTextBox
			// 
			this.descriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
			this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.descriptionTextBox.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.descriptionTextBox.ForeColor = System.Drawing.Color.DimGray;
			this.descriptionTextBox.Location = new System.Drawing.Point(224, 144);
			this.descriptionTextBox.Multiline = true;
			this.descriptionTextBox.Name = "descriptionTextBox";
			this.descriptionTextBox.Size = new System.Drawing.Size(522, 80);
			this.descriptionTextBox.TabIndex = 4;
			this.descriptionTextBox.Text = "توضیحات";
			this.descriptionTextBox.Enter += new System.EventHandler(this.DescriptionTextBox_Enter);
			this.descriptionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DescriptionTextBox_KeyPress);
			this.descriptionTextBox.Leave += new System.EventHandler(this.DescriptionTextBox_Leave);
			// 
			// descriptionPanel
			// 
			this.descriptionPanel.BackColor = System.Drawing.Color.DimGray;
			this.descriptionPanel.ForeColor = System.Drawing.Color.Transparent;
			this.descriptionPanel.Location = new System.Drawing.Point(224, 232);
			this.descriptionPanel.Name = "descriptionPanel";
			this.descriptionPanel.Size = new System.Drawing.Size(522, 1);
			this.descriptionPanel.TabIndex = 11;
			// 
			// passwordConfirmTextBox
			// 
			this.passwordConfirmTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
			this.passwordConfirmTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.passwordConfirmTextBox.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.passwordConfirmTextBox.ForeColor = System.Drawing.Color.DimGray;
			this.passwordConfirmTextBox.Location = new System.Drawing.Point(255, 88);
			this.passwordConfirmTextBox.MaxLength = 40;
			this.passwordConfirmTextBox.Name = "passwordConfirmTextBox";
			this.passwordConfirmTextBox.Size = new System.Drawing.Size(219, 28);
			this.passwordConfirmTextBox.TabIndex = 3;
			this.passwordConfirmTextBox.Text = "تایید رمز عبور";
			this.passwordConfirmTextBox.Enter += new System.EventHandler(this.PasswordConfirmTextBox_Enter);
			this.passwordConfirmTextBox.Leave += new System.EventHandler(this.PasswordConfirmTextBox_Leave);
			// 
			// passwordConfirmPanel
			// 
			this.passwordConfirmPanel.BackColor = System.Drawing.Color.DimGray;
			this.passwordConfirmPanel.ForeColor = System.Drawing.Color.Transparent;
			this.passwordConfirmPanel.Location = new System.Drawing.Point(224, 122);
			this.passwordConfirmPanel.Name = "passwordConfirmPanel";
			this.passwordConfirmPanel.Size = new System.Drawing.Size(250, 1);
			this.passwordConfirmPanel.TabIndex = 10;
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
			this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.passwordTextBox.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.passwordTextBox.ForeColor = System.Drawing.Color.DimGray;
			this.passwordTextBox.Location = new System.Drawing.Point(527, 88);
			this.passwordTextBox.MaxLength = 40;
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(219, 28);
			this.passwordTextBox.TabIndex = 2;
			this.passwordTextBox.Text = "رمز عبور";
			this.passwordTextBox.Enter += new System.EventHandler(this.PasswordTextBox_Enter);
			this.passwordTextBox.Leave += new System.EventHandler(this.PasswordTextBox_Leave);
			// 
			// passwordPanel
			// 
			this.passwordPanel.BackColor = System.Drawing.Color.DimGray;
			this.passwordPanel.ForeColor = System.Drawing.Color.Transparent;
			this.passwordPanel.Location = new System.Drawing.Point(496, 122);
			this.passwordPanel.Name = "passwordPanel";
			this.passwordPanel.Size = new System.Drawing.Size(250, 1);
			this.passwordPanel.TabIndex = 9;
			// 
			// emailPanel
			// 
			this.emailPanel.BackColor = System.Drawing.Color.DimGray;
			this.emailPanel.ForeColor = System.Drawing.Color.Transparent;
			this.emailPanel.Location = new System.Drawing.Point(254, 65);
			this.emailPanel.Name = "emailPanel";
			this.emailPanel.Size = new System.Drawing.Size(220, 1);
			this.emailPanel.TabIndex = 8;
			// 
			// usernameTextBox
			// 
			this.usernameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
			this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.usernameTextBox.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.usernameTextBox.ForeColor = System.Drawing.Color.DimGray;
			this.usernameTextBox.Location = new System.Drawing.Point(526, 32);
			this.usernameTextBox.MaxLength = 15;
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.Size = new System.Drawing.Size(220, 28);
			this.usernameTextBox.TabIndex = 0;
			this.usernameTextBox.Text = "نام کاربری";
			this.usernameTextBox.Enter += new System.EventHandler(this.UsernameTextBox_Enter);
			this.usernameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsernameTextBox_KeyPress);
			this.usernameTextBox.Leave += new System.EventHandler(this.UsernameTextBox_Leave);
			// 
			// usernamePanel
			// 
			this.usernamePanel.BackColor = System.Drawing.Color.DimGray;
			this.usernamePanel.ForeColor = System.Drawing.Color.Transparent;
			this.usernamePanel.Location = new System.Drawing.Point(526, 66);
			this.usernamePanel.Name = "usernamePanel";
			this.usernamePanel.Size = new System.Drawing.Size(220, 1);
			this.usernamePanel.TabIndex = 7;
			// 
			// loginButton
			// 
			this.loginButton.BackColor = System.Drawing.Color.SeaGreen;
			this.loginButton.FlatAppearance.BorderSize = 0;
			this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.loginButton.ForeColor = System.Drawing.Color.White;
			this.loginButton.Image = ((System.Drawing.Image)(resources.GetObject("loginButton.Image")));
			this.loginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.loginButton.Location = new System.Drawing.Point(16, 461);
			this.loginButton.Name = "loginButton";
			this.loginButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.loginButton.Size = new System.Drawing.Size(250, 35);
			this.loginButton.TabIndex = 5;
			this.loginButton.Text = "&ورود";
			this.loginButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.loginButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.loginButton.UseVisualStyleBackColor = false;
			this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
			// 
			// saveButton
			// 
			this.saveButton.BackColor = System.Drawing.Color.SeaGreen;
			this.saveButton.FlatAppearance.BorderSize = 0;
			this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.saveButton.ForeColor = System.Drawing.Color.White;
			this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
			this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.saveButton.Location = new System.Drawing.Point(275, 461);
			this.saveButton.Name = "saveButton";
			this.saveButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.saveButton.Size = new System.Drawing.Size(250, 35);
			this.saveButton.TabIndex = 4;
			this.saveButton.Text = "&ذخیره";
			this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.saveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.saveButton.UseVisualStyleBackColor = false;
			this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// resetButton
			// 
			this.resetButton.BackColor = System.Drawing.Color.SeaGreen;
			this.resetButton.FlatAppearance.BorderSize = 0;
			this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.resetButton.ForeColor = System.Drawing.Color.White;
			this.resetButton.Image = ((System.Drawing.Image)(resources.GetObject("resetButton.Image")));
			this.resetButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.resetButton.Location = new System.Drawing.Point(535, 461);
			this.resetButton.Name = "resetButton";
			this.resetButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.resetButton.Size = new System.Drawing.Size(250, 35);
			this.resetButton.TabIndex = 3;
			this.resetButton.Text = "&پاک کردن اطلاعات";
			this.resetButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.resetButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.resetButton.UseVisualStyleBackColor = false;
			this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 25;
			this.bunifuElipse1.TargetControl = this;
			// 
			// toolTip1
			// 
			this.toolTip1.AutomaticDelay = 50;
			this.toolTip1.AutoPopDelay = 5000;
			this.toolTip1.InitialDelay = 50;
			this.toolTip1.ReshowDelay = 10;
			this.toolTip1.ShowAlways = true;
			this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.toolTip1.ToolTipTitle = "اطلاعات";
			// 
			// RegisterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
			this.ClientSize = new System.Drawing.Size(800, 509);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.resetButton);
			this.Controls.Add(this.userInformationGroupBox);
			this.Controls.Add(this.personalInformationGroupBox);
			this.Controls.Add(this.titlePanel);
			this.Name = "RegisterForm";
			this.Opacity = 0.9D;
			this.Text = "RegisterForm";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseDown);
			this.titlePanel.ResumeLayout(false);
			this.titlePanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.RegisterLogoPicturBox)).EndInit();
			this.personalInformationGroupBox.ResumeLayout(false);
			this.personalInformationGroupBox.PerformLayout();
			this.maritalStatusGroupBox.ResumeLayout(false);
			this.maritalStatusGroupBox.PerformLayout();
			this.userInformationGroupBox.ResumeLayout(false);
			this.userInformationGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.userImagePicturBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.passwordShowPicturBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.passwordShowPicturBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.confirmEmailTickPicturBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.confirmUsernameTickPicturBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Mbb.Windows.Forms.Panel titlePanel;
		private Mbb.Windows.Forms.Button minimizeButton;
		private Mbb.Windows.Forms.Button closeButton;
		private Mbb.Windows.Forms.Panel firstNamePanel;
		private Mbb.Windows.Forms.TextBox firstNameTextBox;
		private Mbb.Windows.Forms.GroupBox personalInformationGroupBox;
		private Mbb.Windows.Forms.TextBox addressTextBox;
		private Mbb.Windows.Forms.Panel addressPanel;
		private Mbb.Windows.Forms.TextBox nationalCodeTextBox;
		private Mbb.Windows.Forms.Panel nationalCodePanel;
		private Mbb.Windows.Forms.TextBox lastNameTextBox;
		private Mbb.Windows.Forms.Panel lastNamePanel;
		private Mbb.Windows.Forms.TextBox telTextBox;
		private Mbb.Windows.Forms.Panel telPanel;
		private Mbb.Windows.Forms.GroupBox userInformationGroupBox;
		private Mbb.Windows.Forms.TextBox descriptionTextBox;
		private Mbb.Windows.Forms.Panel descriptionPanel;
		private Mbb.Windows.Forms.TextBox passwordConfirmTextBox;
		private Mbb.Windows.Forms.Panel passwordConfirmPanel;
		private Mbb.Windows.Forms.TextBox passwordTextBox;
		private Mbb.Windows.Forms.Panel passwordPanel;
		private Mbb.Windows.Forms.Panel emailPanel;
		private Mbb.Windows.Forms.TextBox usernameTextBox;
		private Mbb.Windows.Forms.Panel usernamePanel;
		private Mbb.Windows.Forms.Label Registerlabel;
		private Mbb.Windows.Forms.LinkLabel addPictureLinkLabel;
		private Mbb.Windows.Forms.PicturBox confirmEmailTickPicturBox;
		private Mbb.Windows.Forms.PicturBox confirmUsernameTickPicturBox;
		private Mbb.Windows.Forms.Button deleteImageButton;
		private Mbb.Windows.Forms.PicturBox passwordShowPicturBox2;
		private Mbb.Windows.Forms.PicturBox passwordShowPicturBox1;
		private Mbb.Windows.Forms.Button loginButton;
		private Mbb.Windows.Forms.Button saveButton;
		private Mbb.Windows.Forms.Button resetButton;
		private Mbb.Windows.Forms.PicturBox RegisterLogoPicturBox;
		private Mbb.Windows.Forms.GroupBox maritalStatusGroupBox;
		private Mbb.Windows.Forms.RadioButton singleRadioButton;
		private Mbb.Windows.Forms.RadioButton marriedRadioButton;
		private Mbb.Windows.Forms.CircularPictureBox userImagePicturBox;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private Mbb.Windows.Forms.TextBox emailTextBox;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}