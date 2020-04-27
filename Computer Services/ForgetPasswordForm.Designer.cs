namespace ComputerServices
{
	partial class ForgetPasswordForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPasswordForm));
			this.titlePanel = new Mbb.Windows.Forms.Panel();
			this.securityCodeLabel = new Mbb.Windows.Forms.Label();
			this.minimizeButton = new Mbb.Windows.Forms.Button();
			this.closeButton = new Mbb.Windows.Forms.Button();
			this.checkIntenetTimer = new System.Windows.Forms.Timer(this.components);
			this.sendEmailPanel = new Mbb.Windows.Forms.Panel();
			this.changePasswordButton = new Mbb.Windows.Forms.Button();
			this.groupBox00 = new Mbb.Windows.Forms.GroupBox();
			this.emailStatusPicturBox = new Mbb.Windows.Forms.PicturBox();
			this.codeTextBox = new Mbb.Windows.Forms.TextBox();
			this.codePanel = new Mbb.Windows.Forms.Panel();
			this.emailTextBox = new Mbb.Windows.Forms.TextBox();
			this.emailPanel = new Mbb.Windows.Forms.Panel();
			this.sendCodeButton = new Mbb.Windows.Forms.Button();
			this.groupBox01 = new Mbb.Windows.Forms.GroupBox();
			this.userStatusLabel = new Mbb.Windows.Forms.Label();
			this.userCheckLabel = new Mbb.Windows.Forms.Label();
			this.passwordConfirmPanel = new Mbb.Windows.Forms.Panel();
			this.passwordConfirmTextBox = new Mbb.Windows.Forms.TextBox();
			this.usernamePanel = new Mbb.Windows.Forms.Panel();
			this.passwordPanel = new Mbb.Windows.Forms.Panel();
			this.passwordTextBox = new Mbb.Windows.Forms.TextBox();
			this.usernameTextBox = new Mbb.Windows.Forms.TextBox();
			this.statusInternetLabel = new Mbb.Windows.Forms.Label();
			this.netConnectionStatusLabel = new Mbb.Windows.Forms.Label();
			this.selectSendGroupBox = new Mbb.Windows.Forms.GroupBox();
			this.emailRadioButton = new Mbb.Windows.Forms.RadioButton();
			this.smsRadioButton = new Mbb.Windows.Forms.RadioButton();
			this.sendSMSPanel = new Mbb.Windows.Forms.Panel();
			this.notificationLabel = new Mbb.Windows.Forms.Label();
			this.groupBox11 = new Mbb.Windows.Forms.GroupBox();
			this.numberStatusPicturBox = new Mbb.Windows.Forms.PicturBox();
			this.smsCodeTextBox = new Mbb.Windows.Forms.TextBox();
			this.panel3 = new Mbb.Windows.Forms.Panel();
			this.receptorNumberTextBox = new Mbb.Windows.Forms.TextBox();
			this.receptorNumberPanel = new Mbb.Windows.Forms.Panel();
			this.sendSMSCodeButton = new Mbb.Windows.Forms.Button();
			this.smsChangPasswordButton = new Mbb.Windows.Forms.Button();
			this.groupBox12 = new Mbb.Windows.Forms.GroupBox();
			this.label1 = new Mbb.Windows.Forms.Label();
			this.label2 = new Mbb.Windows.Forms.Label();
			this.panel5 = new Mbb.Windows.Forms.Panel();
			this.smsPasswordConfirmTextBox = new Mbb.Windows.Forms.TextBox();
			this.panel6 = new Mbb.Windows.Forms.Panel();
			this.panel7 = new Mbb.Windows.Forms.Panel();
			this.smsPasswordTextBox = new Mbb.Windows.Forms.TextBox();
			this.smsUsernameTextBox = new Mbb.Windows.Forms.TextBox();
			this.titlePanel.SuspendLayout();
			this.sendEmailPanel.SuspendLayout();
			this.groupBox00.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.emailStatusPicturBox)).BeginInit();
			this.groupBox01.SuspendLayout();
			this.selectSendGroupBox.SuspendLayout();
			this.sendSMSPanel.SuspendLayout();
			this.groupBox11.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numberStatusPicturBox)).BeginInit();
			this.groupBox12.SuspendLayout();
			this.SuspendLayout();
			// 
			// titlePanel
			// 
			this.titlePanel.Controls.Add(this.securityCodeLabel);
			this.titlePanel.Controls.Add(this.minimizeButton);
			this.titlePanel.Controls.Add(this.closeButton);
			this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.titlePanel.Location = new System.Drawing.Point(0, 0);
			this.titlePanel.Name = "titlePanel";
			this.titlePanel.Size = new System.Drawing.Size(452, 30);
			this.titlePanel.TabIndex = 0;
			this.titlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitlePanel_MouseDown);
			// 
			// securityCodeLabel
			// 
			this.securityCodeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.securityCodeLabel.ForeColor = System.Drawing.Color.White;
			this.securityCodeLabel.Location = new System.Drawing.Point(295, 0);
			this.securityCodeLabel.Name = "securityCodeLabel";
			this.securityCodeLabel.Size = new System.Drawing.Size(155, 30);
			this.securityCodeLabel.TabIndex = 4;
			this.securityCodeLabel.Text = "Security Code";
			this.securityCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.securityCodeLabel.Visible = false;
			// 
			// minimizeButton
			// 
			this.minimizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizeButton.BackgroundImage")));
			this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.minimizeButton.FlatAppearance.BorderSize = 0;
			this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.minimizeButton.Location = new System.Drawing.Point(33, 8);
			this.minimizeButton.Name = "minimizeButton";
			this.minimizeButton.Size = new System.Drawing.Size(13, 15);
			this.minimizeButton.TabIndex = 3;
			this.minimizeButton.UseVisualStyleBackColor = true;
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
			this.closeButton.Size = new System.Drawing.Size(13, 15);
			this.closeButton.TabIndex = 2;
			this.closeButton.UseVisualStyleBackColor = true;
			// 
			// checkIntenetTimer
			// 
			this.checkIntenetTimer.Interval = 500;
			this.checkIntenetTimer.Tick += new System.EventHandler(this.CheckIntenetTimer_Tick);
			// 
			// sendEmailPanel
			// 
			this.sendEmailPanel.Controls.Add(this.changePasswordButton);
			this.sendEmailPanel.Controls.Add(this.groupBox00);
			this.sendEmailPanel.Controls.Add(this.groupBox01);
			this.sendEmailPanel.Controls.Add(this.statusInternetLabel);
			this.sendEmailPanel.Controls.Add(this.netConnectionStatusLabel);
			this.sendEmailPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.sendEmailPanel.Location = new System.Drawing.Point(0, 119);
			this.sendEmailPanel.Name = "sendEmailPanel";
			this.sendEmailPanel.Size = new System.Drawing.Size(452, 395);
			this.sendEmailPanel.TabIndex = 1;
			this.sendEmailPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SendEmailPanel_MouseDown);
			// 
			// changePasswordButton
			// 
			this.changePasswordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.changePasswordButton.Enabled = false;
			this.changePasswordButton.FlatAppearance.BorderSize = 0;
			this.changePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.changePasswordButton.ForeColor = System.Drawing.Color.White;
			this.changePasswordButton.Location = new System.Drawing.Point(26, 338);
			this.changePasswordButton.Name = "changePasswordButton";
			this.changePasswordButton.Size = new System.Drawing.Size(162, 34);
			this.changePasswordButton.TabIndex = 20;
			this.changePasswordButton.Text = "تغییر رمز عبور";
			this.changePasswordButton.UseVisualStyleBackColor = false;
			this.changePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
			// 
			// groupBox00
			// 
			this.groupBox00.Controls.Add(this.emailStatusPicturBox);
			this.groupBox00.Controls.Add(this.codeTextBox);
			this.groupBox00.Controls.Add(this.codePanel);
			this.groupBox00.Controls.Add(this.emailTextBox);
			this.groupBox00.Controls.Add(this.emailPanel);
			this.groupBox00.Controls.Add(this.sendCodeButton);
			this.groupBox00.Location = new System.Drawing.Point(26, 22);
			this.groupBox00.Name = "groupBox00";
			this.groupBox00.Size = new System.Drawing.Size(400, 115);
			this.groupBox00.TabIndex = 19;
			this.groupBox00.TabStop = false;
			// 
			// emailStatusPicturBox
			// 
			this.emailStatusPicturBox.Image = global::ComputerServices.Properties.Resources.Tik_False;
			this.emailStatusPicturBox.Location = new System.Drawing.Point(6, 19);
			this.emailStatusPicturBox.Name = "emailStatusPicturBox";
			this.emailStatusPicturBox.Size = new System.Drawing.Size(25, 25);
			this.emailStatusPicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.emailStatusPicturBox.TabIndex = 6;
			this.emailStatusPicturBox.TabStop = false;
			this.emailStatusPicturBox.Visible = false;
			// 
			// codeTextBox
			// 
			this.codeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.codeTextBox.BackColor = System.Drawing.Color.SlateBlue;
			this.codeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.codeTextBox.Enabled = false;
			this.codeTextBox.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.codeTextBox.ForeColor = System.Drawing.Color.Black;
			this.codeTextBox.Location = new System.Drawing.Point(138, 70);
			this.codeTextBox.Name = "codeTextBox";
			this.codeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.codeTextBox.Size = new System.Drawing.Size(256, 23);
			this.codeTextBox.TabIndex = 4;
			this.codeTextBox.Text = "کد";
			this.codeTextBox.TextChanged += new System.EventHandler(this.CodeTextBox_TextChanged);
			this.codeTextBox.Enter += new System.EventHandler(this.CodeTextBox_Enter);
			this.codeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodeTextBox_KeyPress);
			this.codeTextBox.Leave += new System.EventHandler(this.CodeTextBox_Leave);
			// 
			// codePanel
			// 
			this.codePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.codePanel.BackColor = System.Drawing.Color.Black;
			this.codePanel.Location = new System.Drawing.Point(138, 99);
			this.codePanel.Name = "codePanel";
			this.codePanel.Size = new System.Drawing.Size(256, 1);
			this.codePanel.TabIndex = 5;
			// 
			// emailTextBox
			// 
			this.emailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.emailTextBox.BackColor = System.Drawing.Color.SlateBlue;
			this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.emailTextBox.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.emailTextBox.ForeColor = System.Drawing.Color.Black;
			this.emailTextBox.Location = new System.Drawing.Point(37, 20);
			this.emailTextBox.Name = "emailTextBox";
			this.emailTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.emailTextBox.Size = new System.Drawing.Size(357, 23);
			this.emailTextBox.TabIndex = 1;
			this.emailTextBox.Text = "پست الکترونیکی";
			this.emailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
			this.emailTextBox.Enter += new System.EventHandler(this.EmailTextBox_Enter);
			this.emailTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmailTextBox_KeyPress);
			this.emailTextBox.Leave += new System.EventHandler(this.EmailTextBox_Leave);
			// 
			// emailPanel
			// 
			this.emailPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.emailPanel.BackColor = System.Drawing.Color.Black;
			this.emailPanel.Location = new System.Drawing.Point(37, 49);
			this.emailPanel.Name = "emailPanel";
			this.emailPanel.Size = new System.Drawing.Size(357, 1);
			this.emailPanel.TabIndex = 2;
			// 
			// sendCodeButton
			// 
			this.sendCodeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.sendCodeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.sendCodeButton.Enabled = false;
			this.sendCodeButton.FlatAppearance.BorderSize = 0;
			this.sendCodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.sendCodeButton.ForeColor = System.Drawing.Color.White;
			this.sendCodeButton.Location = new System.Drawing.Point(6, 66);
			this.sendCodeButton.Name = "sendCodeButton";
			this.sendCodeButton.Size = new System.Drawing.Size(120, 34);
			this.sendCodeButton.TabIndex = 3;
			this.sendCodeButton.Text = "ارسال کد امنیتی";
			this.sendCodeButton.UseVisualStyleBackColor = false;
			this.sendCodeButton.Click += new System.EventHandler(this.SendCodeButton_Click);
			// 
			// groupBox01
			// 
			this.groupBox01.Controls.Add(this.userStatusLabel);
			this.groupBox01.Controls.Add(this.userCheckLabel);
			this.groupBox01.Controls.Add(this.passwordConfirmPanel);
			this.groupBox01.Controls.Add(this.passwordConfirmTextBox);
			this.groupBox01.Controls.Add(this.usernamePanel);
			this.groupBox01.Controls.Add(this.passwordPanel);
			this.groupBox01.Controls.Add(this.passwordTextBox);
			this.groupBox01.Controls.Add(this.usernameTextBox);
			this.groupBox01.Location = new System.Drawing.Point(26, 143);
			this.groupBox01.Name = "groupBox01";
			this.groupBox01.Size = new System.Drawing.Size(400, 189);
			this.groupBox01.TabIndex = 18;
			this.groupBox01.TabStop = false;
			// 
			// userStatusLabel
			// 
			this.userStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.userStatusLabel.ForeColor = System.Drawing.Color.White;
			this.userStatusLabel.Location = new System.Drawing.Point(40, 22);
			this.userStatusLabel.Name = "userStatusLabel";
			this.userStatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.userStatusLabel.Size = new System.Drawing.Size(291, 19);
			this.userStatusLabel.TabIndex = 19;
			this.userStatusLabel.Text = "وضعیت";
			// 
			// userCheckLabel
			// 
			this.userCheckLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.userCheckLabel.AutoSize = true;
			this.userCheckLabel.ForeColor = System.Drawing.Color.White;
			this.userCheckLabel.Location = new System.Drawing.Point(337, 22);
			this.userCheckLabel.Name = "userCheckLabel";
			this.userCheckLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.userCheckLabel.Size = new System.Drawing.Size(61, 19);
			this.userCheckLabel.TabIndex = 18;
			this.userCheckLabel.Text = "بررسی کاربر:";
			// 
			// passwordConfirmPanel
			// 
			this.passwordConfirmPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.passwordConfirmPanel.BackColor = System.Drawing.Color.Black;
			this.passwordConfirmPanel.Location = new System.Drawing.Point(6, 169);
			this.passwordConfirmPanel.Name = "passwordConfirmPanel";
			this.passwordConfirmPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.passwordConfirmPanel.Size = new System.Drawing.Size(388, 1);
			this.passwordConfirmPanel.TabIndex = 17;
			// 
			// passwordConfirmTextBox
			// 
			this.passwordConfirmTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.passwordConfirmTextBox.BackColor = System.Drawing.Color.SlateBlue;
			this.passwordConfirmTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.passwordConfirmTextBox.Enabled = false;
			this.passwordConfirmTextBox.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordConfirmTextBox.ForeColor = System.Drawing.Color.Black;
			this.passwordConfirmTextBox.Location = new System.Drawing.Point(6, 140);
			this.passwordConfirmTextBox.Name = "passwordConfirmTextBox";
			this.passwordConfirmTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.passwordConfirmTextBox.Size = new System.Drawing.Size(388, 23);
			this.passwordConfirmTextBox.TabIndex = 16;
			this.passwordConfirmTextBox.Text = "تایید رمز عبور";
			this.passwordConfirmTextBox.Enter += new System.EventHandler(this.PasswordConfirmTextBox_Enter);
			this.passwordConfirmTextBox.Leave += new System.EventHandler(this.PasswordConfirmTextBox_Leave);
			// 
			// usernamePanel
			// 
			this.usernamePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.usernamePanel.BackColor = System.Drawing.Color.Black;
			this.usernamePanel.Location = new System.Drawing.Point(6, 77);
			this.usernamePanel.Name = "usernamePanel";
			this.usernamePanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.usernamePanel.Size = new System.Drawing.Size(388, 1);
			this.usernamePanel.TabIndex = 13;
			// 
			// passwordPanel
			// 
			this.passwordPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.passwordPanel.BackColor = System.Drawing.Color.Black;
			this.passwordPanel.Location = new System.Drawing.Point(6, 123);
			this.passwordPanel.Name = "passwordPanel";
			this.passwordPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.passwordPanel.Size = new System.Drawing.Size(388, 1);
			this.passwordPanel.TabIndex = 15;
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.passwordTextBox.BackColor = System.Drawing.Color.SlateBlue;
			this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.passwordTextBox.Enabled = false;
			this.passwordTextBox.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordTextBox.ForeColor = System.Drawing.Color.Black;
			this.passwordTextBox.Location = new System.Drawing.Point(6, 94);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.passwordTextBox.Size = new System.Drawing.Size(388, 23);
			this.passwordTextBox.TabIndex = 14;
			this.passwordTextBox.Text = "رمز عبور";
			this.passwordTextBox.Enter += new System.EventHandler(this.PasswordTextBox_Enter);
			this.passwordTextBox.Leave += new System.EventHandler(this.PasswordTextBox_Leave);
			// 
			// usernameTextBox
			// 
			this.usernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.usernameTextBox.BackColor = System.Drawing.Color.SlateBlue;
			this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.usernameTextBox.Enabled = false;
			this.usernameTextBox.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usernameTextBox.ForeColor = System.Drawing.Color.Black;
			this.usernameTextBox.Location = new System.Drawing.Point(6, 48);
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.usernameTextBox.Size = new System.Drawing.Size(388, 23);
			this.usernameTextBox.TabIndex = 12;
			this.usernameTextBox.Text = "نام کاربری";
			this.usernameTextBox.TextChanged += new System.EventHandler(this.UsernameTextBox_TextChanged);
			this.usernameTextBox.Enter += new System.EventHandler(this.UsernameTextBox_Enter);
			this.usernameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsernameTextBox_KeyPress);
			this.usernameTextBox.Leave += new System.EventHandler(this.UsernameTextBox_Leave);
			// 
			// statusInternetLabel
			// 
			this.statusInternetLabel.AutoSize = true;
			this.statusInternetLabel.ForeColor = System.Drawing.Color.White;
			this.statusInternetLabel.Location = new System.Drawing.Point(343, 346);
			this.statusInternetLabel.Name = "statusInternetLabel";
			this.statusInternetLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.statusInternetLabel.Size = new System.Drawing.Size(81, 19);
			this.statusInternetLabel.TabIndex = 17;
			this.statusInternetLabel.Text = "وضعیت اینترنت:";
			// 
			// netConnectionStatusLabel
			// 
			this.netConnectionStatusLabel.ForeColor = System.Drawing.Color.White;
			this.netConnectionStatusLabel.Location = new System.Drawing.Point(194, 346);
			this.netConnectionStatusLabel.Name = "netConnectionStatusLabel";
			this.netConnectionStatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.netConnectionStatusLabel.Size = new System.Drawing.Size(143, 19);
			this.netConnectionStatusLabel.TabIndex = 16;
			this.netConnectionStatusLabel.Text = "اتصال شبکه";
			// 
			// selectSendGroupBox
			// 
			this.selectSendGroupBox.Controls.Add(this.emailRadioButton);
			this.selectSendGroupBox.Controls.Add(this.smsRadioButton);
			this.selectSendGroupBox.ForeColor = System.Drawing.Color.White;
			this.selectSendGroupBox.Location = new System.Drawing.Point(12, 36);
			this.selectSendGroupBox.Name = "selectSendGroupBox";
			this.selectSendGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.selectSendGroupBox.Size = new System.Drawing.Size(428, 77);
			this.selectSendGroupBox.TabIndex = 2;
			this.selectSendGroupBox.TabStop = false;
			this.selectSendGroupBox.Text = "روش ارسال را انتخاب کنید";
			// 
			// emailRadioButton
			// 
			this.emailRadioButton.AutoSize = true;
			this.emailRadioButton.ForeColor = System.Drawing.Color.White;
			this.emailRadioButton.Location = new System.Drawing.Point(49, 36);
			this.emailRadioButton.Name = "emailRadioButton";
			this.emailRadioButton.Size = new System.Drawing.Size(173, 23);
			this.emailRadioButton.TabIndex = 1;
			this.emailRadioButton.TabStop = true;
			this.emailRadioButton.Text = "ارسال کد با کمک پست الکترونیک";
			this.emailRadioButton.UseVisualStyleBackColor = true;
			this.emailRadioButton.CheckedChanged += new System.EventHandler(this.emailRadioButton_CheckedChanged);
			// 
			// smsRadioButton
			// 
			this.smsRadioButton.AutoSize = true;
			this.smsRadioButton.ForeColor = System.Drawing.Color.White;
			this.smsRadioButton.Location = new System.Drawing.Point(235, 36);
			this.smsRadioButton.Name = "smsRadioButton";
			this.smsRadioButton.Size = new System.Drawing.Size(145, 23);
			this.smsRadioButton.TabIndex = 0;
			this.smsRadioButton.TabStop = true;
			this.smsRadioButton.Text = "ارسال کد با کمک پیام کوتاه";
			this.smsRadioButton.UseVisualStyleBackColor = true;
			this.smsRadioButton.CheckedChanged += new System.EventHandler(this.smsRadioButton_CheckedChanged);
			// 
			// sendSMSPanel
			// 
			this.sendSMSPanel.Controls.Add(this.notificationLabel);
			this.sendSMSPanel.Controls.Add(this.groupBox11);
			this.sendSMSPanel.Controls.Add(this.smsChangPasswordButton);
			this.sendSMSPanel.Controls.Add(this.groupBox12);
			this.sendSMSPanel.Location = new System.Drawing.Point(0, 119);
			this.sendSMSPanel.Name = "sendSMSPanel";
			this.sendSMSPanel.Size = new System.Drawing.Size(452, 395);
			this.sendSMSPanel.TabIndex = 4;
			this.sendSMSPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SendSMSPanel_MouseDown);
			// 
			// notificationLabel
			// 
			this.notificationLabel.AutoSize = true;
			this.notificationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.notificationLabel.Location = new System.Drawing.Point(235, 7);
			this.notificationLabel.Name = "notificationLabel";
			this.notificationLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.notificationLabel.Size = new System.Drawing.Size(192, 19);
			this.notificationLabel.TabIndex = 26;
			this.notificationLabel.Text = "این قسمت در حال حاضر غیر فعال میباشد.";
			// 
			// groupBox11
			// 
			this.groupBox11.Controls.Add(this.numberStatusPicturBox);
			this.groupBox11.Controls.Add(this.smsCodeTextBox);
			this.groupBox11.Controls.Add(this.panel3);
			this.groupBox11.Controls.Add(this.receptorNumberTextBox);
			this.groupBox11.Controls.Add(this.receptorNumberPanel);
			this.groupBox11.Controls.Add(this.sendSMSCodeButton);
			this.groupBox11.Enabled = false;
			this.groupBox11.Location = new System.Drawing.Point(26, 22);
			this.groupBox11.Name = "groupBox11";
			this.groupBox11.Size = new System.Drawing.Size(400, 115);
			this.groupBox11.TabIndex = 24;
			this.groupBox11.TabStop = false;
			// 
			// numberStatusPicturBox
			// 
			this.numberStatusPicturBox.Image = global::ComputerServices.Properties.Resources.Tik_False;
			this.numberStatusPicturBox.Location = new System.Drawing.Point(6, 19);
			this.numberStatusPicturBox.Name = "numberStatusPicturBox";
			this.numberStatusPicturBox.Size = new System.Drawing.Size(25, 25);
			this.numberStatusPicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.numberStatusPicturBox.TabIndex = 6;
			this.numberStatusPicturBox.TabStop = false;
			this.numberStatusPicturBox.Visible = false;
			// 
			// smsCodeTextBox
			// 
			this.smsCodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.smsCodeTextBox.BackColor = System.Drawing.Color.SlateBlue;
			this.smsCodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.smsCodeTextBox.Enabled = false;
			this.smsCodeTextBox.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.smsCodeTextBox.ForeColor = System.Drawing.Color.Black;
			this.smsCodeTextBox.Location = new System.Drawing.Point(138, 70);
			this.smsCodeTextBox.Name = "smsCodeTextBox";
			this.smsCodeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.smsCodeTextBox.Size = new System.Drawing.Size(256, 23);
			this.smsCodeTextBox.TabIndex = 4;
			this.smsCodeTextBox.Text = "کد";
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.BackColor = System.Drawing.Color.Black;
			this.panel3.Location = new System.Drawing.Point(138, 99);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(256, 1);
			this.panel3.TabIndex = 5;
			// 
			// receptorNumberTextBox
			// 
			this.receptorNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.receptorNumberTextBox.BackColor = System.Drawing.Color.SlateBlue;
			this.receptorNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.receptorNumberTextBox.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.receptorNumberTextBox.ForeColor = System.Drawing.Color.Black;
			this.receptorNumberTextBox.Location = new System.Drawing.Point(37, 20);
			this.receptorNumberTextBox.Name = "receptorNumberTextBox";
			this.receptorNumberTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.receptorNumberTextBox.Size = new System.Drawing.Size(357, 23);
			this.receptorNumberTextBox.TabIndex = 1;
			this.receptorNumberTextBox.Text = "شماره تلفن همراه";
			// 
			// receptorNumberPanel
			// 
			this.receptorNumberPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.receptorNumberPanel.BackColor = System.Drawing.Color.Black;
			this.receptorNumberPanel.Location = new System.Drawing.Point(37, 49);
			this.receptorNumberPanel.Name = "receptorNumberPanel";
			this.receptorNumberPanel.Size = new System.Drawing.Size(357, 1);
			this.receptorNumberPanel.TabIndex = 2;
			// 
			// sendSMSCodeButton
			// 
			this.sendSMSCodeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.sendSMSCodeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.sendSMSCodeButton.FlatAppearance.BorderSize = 0;
			this.sendSMSCodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.sendSMSCodeButton.ForeColor = System.Drawing.Color.White;
			this.sendSMSCodeButton.Location = new System.Drawing.Point(6, 66);
			this.sendSMSCodeButton.Name = "sendSMSCodeButton";
			this.sendSMSCodeButton.Size = new System.Drawing.Size(120, 34);
			this.sendSMSCodeButton.TabIndex = 3;
			this.sendSMSCodeButton.Text = "ارسال کد امنیتی";
			this.sendSMSCodeButton.UseVisualStyleBackColor = false;
			// 
			// smsChangPasswordButton
			// 
			this.smsChangPasswordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.smsChangPasswordButton.Enabled = false;
			this.smsChangPasswordButton.FlatAppearance.BorderSize = 0;
			this.smsChangPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.smsChangPasswordButton.ForeColor = System.Drawing.Color.White;
			this.smsChangPasswordButton.Location = new System.Drawing.Point(26, 338);
			this.smsChangPasswordButton.Name = "smsChangPasswordButton";
			this.smsChangPasswordButton.Size = new System.Drawing.Size(400, 34);
			this.smsChangPasswordButton.TabIndex = 25;
			this.smsChangPasswordButton.Text = "تغییر رمز عبور";
			this.smsChangPasswordButton.UseVisualStyleBackColor = false;
			// 
			// groupBox12
			// 
			this.groupBox12.Controls.Add(this.label1);
			this.groupBox12.Controls.Add(this.label2);
			this.groupBox12.Controls.Add(this.panel5);
			this.groupBox12.Controls.Add(this.smsPasswordConfirmTextBox);
			this.groupBox12.Controls.Add(this.panel6);
			this.groupBox12.Controls.Add(this.panel7);
			this.groupBox12.Controls.Add(this.smsPasswordTextBox);
			this.groupBox12.Controls.Add(this.smsUsernameTextBox);
			this.groupBox12.Enabled = false;
			this.groupBox12.Location = new System.Drawing.Point(26, 143);
			this.groupBox12.Name = "groupBox12";
			this.groupBox12.Size = new System.Drawing.Size(400, 189);
			this.groupBox12.TabIndex = 23;
			this.groupBox12.TabStop = false;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(40, 22);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label1.Size = new System.Drawing.Size(291, 19);
			this.label1.TabIndex = 19;
			this.label1.Text = "وضعیت";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(337, 22);
			this.label2.Name = "label2";
			this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label2.Size = new System.Drawing.Size(61, 19);
			this.label2.TabIndex = 18;
			this.label2.Text = "بررسی کاربر:";
			// 
			// panel5
			// 
			this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel5.BackColor = System.Drawing.Color.Black;
			this.panel5.Location = new System.Drawing.Point(6, 169);
			this.panel5.Name = "panel5";
			this.panel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.panel5.Size = new System.Drawing.Size(388, 1);
			this.panel5.TabIndex = 17;
			// 
			// smsPasswordConfirmTextBox
			// 
			this.smsPasswordConfirmTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.smsPasswordConfirmTextBox.BackColor = System.Drawing.Color.SlateBlue;
			this.smsPasswordConfirmTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.smsPasswordConfirmTextBox.Enabled = false;
			this.smsPasswordConfirmTextBox.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.smsPasswordConfirmTextBox.ForeColor = System.Drawing.Color.Black;
			this.smsPasswordConfirmTextBox.Location = new System.Drawing.Point(6, 140);
			this.smsPasswordConfirmTextBox.Name = "smsPasswordConfirmTextBox";
			this.smsPasswordConfirmTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.smsPasswordConfirmTextBox.Size = new System.Drawing.Size(388, 23);
			this.smsPasswordConfirmTextBox.TabIndex = 16;
			this.smsPasswordConfirmTextBox.Text = "تایید رمز عبور";
			// 
			// panel6
			// 
			this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel6.BackColor = System.Drawing.Color.Black;
			this.panel6.Location = new System.Drawing.Point(6, 77);
			this.panel6.Name = "panel6";
			this.panel6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.panel6.Size = new System.Drawing.Size(388, 1);
			this.panel6.TabIndex = 13;
			// 
			// panel7
			// 
			this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel7.BackColor = System.Drawing.Color.Black;
			this.panel7.Location = new System.Drawing.Point(6, 123);
			this.panel7.Name = "panel7";
			this.panel7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.panel7.Size = new System.Drawing.Size(388, 1);
			this.panel7.TabIndex = 15;
			// 
			// smsPasswordTextBox
			// 
			this.smsPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.smsPasswordTextBox.BackColor = System.Drawing.Color.SlateBlue;
			this.smsPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.smsPasswordTextBox.Enabled = false;
			this.smsPasswordTextBox.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.smsPasswordTextBox.ForeColor = System.Drawing.Color.Black;
			this.smsPasswordTextBox.Location = new System.Drawing.Point(6, 94);
			this.smsPasswordTextBox.Name = "smsPasswordTextBox";
			this.smsPasswordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.smsPasswordTextBox.Size = new System.Drawing.Size(388, 23);
			this.smsPasswordTextBox.TabIndex = 14;
			this.smsPasswordTextBox.Text = "رمز عبور";
			// 
			// smsUsernameTextBox
			// 
			this.smsUsernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.smsUsernameTextBox.BackColor = System.Drawing.Color.SlateBlue;
			this.smsUsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.smsUsernameTextBox.Enabled = false;
			this.smsUsernameTextBox.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.smsUsernameTextBox.ForeColor = System.Drawing.Color.Black;
			this.smsUsernameTextBox.Location = new System.Drawing.Point(6, 48);
			this.smsUsernameTextBox.Name = "smsUsernameTextBox";
			this.smsUsernameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.smsUsernameTextBox.Size = new System.Drawing.Size(388, 23);
			this.smsUsernameTextBox.TabIndex = 12;
			this.smsUsernameTextBox.Text = "نام کاربری";
			// 
			// ForgetPasswordForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SlateBlue;
			this.ClientSize = new System.Drawing.Size(452, 514);
			this.Controls.Add(this.selectSendGroupBox);
			this.Controls.Add(this.titlePanel);
			this.Controls.Add(this.sendSMSPanel);
			this.Controls.Add(this.sendEmailPanel);
			this.Name = "ForgetPasswordForm";
			this.Opacity = 0.9D;
			this.Text = "ForgetPasswordForm";
			this.Load += new System.EventHandler(this.ForgetPasswordForm_Load);
			this.titlePanel.ResumeLayout(false);
			this.sendEmailPanel.ResumeLayout(false);
			this.sendEmailPanel.PerformLayout();
			this.groupBox00.ResumeLayout(false);
			this.groupBox00.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.emailStatusPicturBox)).EndInit();
			this.groupBox01.ResumeLayout(false);
			this.groupBox01.PerformLayout();
			this.selectSendGroupBox.ResumeLayout(false);
			this.selectSendGroupBox.PerformLayout();
			this.sendSMSPanel.ResumeLayout(false);
			this.sendSMSPanel.PerformLayout();
			this.groupBox11.ResumeLayout(false);
			this.groupBox11.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numberStatusPicturBox)).EndInit();
			this.groupBox12.ResumeLayout(false);
			this.groupBox12.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Mbb.Windows.Forms.Panel titlePanel;
		private Mbb.Windows.Forms.Button minimizeButton;
		private Mbb.Windows.Forms.Button closeButton;
		private Mbb.Windows.Forms.Label securityCodeLabel;
		private System.Windows.Forms.Timer checkIntenetTimer;
		private Mbb.Windows.Forms.Panel sendEmailPanel;
		private Mbb.Windows.Forms.Button changePasswordButton;
		private Mbb.Windows.Forms.GroupBox groupBox00;
		private Mbb.Windows.Forms.PicturBox emailStatusPicturBox;
		private Mbb.Windows.Forms.TextBox codeTextBox;
		private Mbb.Windows.Forms.Panel codePanel;
		private Mbb.Windows.Forms.TextBox emailTextBox;
		private Mbb.Windows.Forms.Panel emailPanel;
		private Mbb.Windows.Forms.Button sendCodeButton;
		private Mbb.Windows.Forms.GroupBox groupBox01;
		private Mbb.Windows.Forms.Label userStatusLabel;
		private Mbb.Windows.Forms.Label userCheckLabel;
		private Mbb.Windows.Forms.Panel passwordConfirmPanel;
		private Mbb.Windows.Forms.TextBox passwordConfirmTextBox;
		private Mbb.Windows.Forms.Panel usernamePanel;
		private Mbb.Windows.Forms.Panel passwordPanel;
		private Mbb.Windows.Forms.TextBox passwordTextBox;
		private Mbb.Windows.Forms.TextBox usernameTextBox;
		private Mbb.Windows.Forms.Label statusInternetLabel;
		private Mbb.Windows.Forms.Label netConnectionStatusLabel;
		private Mbb.Windows.Forms.GroupBox selectSendGroupBox;
		private Mbb.Windows.Forms.RadioButton emailRadioButton;
		private Mbb.Windows.Forms.RadioButton smsRadioButton;
		private Mbb.Windows.Forms.Panel sendSMSPanel;
		private Mbb.Windows.Forms.Label notificationLabel;
		private Mbb.Windows.Forms.GroupBox groupBox11;
		private Mbb.Windows.Forms.PicturBox numberStatusPicturBox;
		private Mbb.Windows.Forms.TextBox smsCodeTextBox;
		private Mbb.Windows.Forms.Panel panel3;
		private Mbb.Windows.Forms.TextBox receptorNumberTextBox;
		private Mbb.Windows.Forms.Panel receptorNumberPanel;
		private Mbb.Windows.Forms.Button sendSMSCodeButton;
		private Mbb.Windows.Forms.Button smsChangPasswordButton;
		private Mbb.Windows.Forms.GroupBox groupBox12;
		private Mbb.Windows.Forms.Label label1;
		private Mbb.Windows.Forms.Label label2;
		private Mbb.Windows.Forms.Panel panel5;
		private Mbb.Windows.Forms.TextBox smsPasswordConfirmTextBox;
		private Mbb.Windows.Forms.Panel panel6;
		private Mbb.Windows.Forms.Panel panel7;
		private Mbb.Windows.Forms.TextBox smsPasswordTextBox;
		private Mbb.Windows.Forms.TextBox smsUsernameTextBox;
	}
}