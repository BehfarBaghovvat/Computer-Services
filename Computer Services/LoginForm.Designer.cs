namespace ComputerServices
{
	partial class LoginForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.rightSidePanel = new Mbb.Windows.Forms.Panel();
			this.picturBox1 = new Mbb.Windows.Forms.PicturBox();
			this.loginLabel = new Mbb.Windows.Forms.Label();
			this.titlePanel = new Mbb.Windows.Forms.Panel();
			this.loginPicturBox = new Mbb.Windows.Forms.PicturBox();
			this.minimizeButton = new Mbb.Windows.Forms.Button();
			this.closeButton = new Mbb.Windows.Forms.Button();
			this.usernameEmailTextBox = new Mbb.Windows.Forms.TextBox();
			this.usernameEmailPanel = new Mbb.Windows.Forms.Panel();
			this.passwordPanel = new Mbb.Windows.Forms.Panel();
			this.passwordTextBox = new Mbb.Windows.Forms.TextBox();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.loginButton = new Mbb.Windows.Forms.Button();
			this.newAccountLinkLabel = new Mbb.Windows.Forms.LinkLabel();
			this.captionLabel1 = new Mbb.Windows.Forms.Label();
			this.label1 = new Mbb.Windows.Forms.Label();
			this.bottomPanel = new Mbb.Windows.Forms.Panel();
			this.forgetPasswordLinkLabel = new Mbb.Windows.Forms.LinkLabel();
			this.rightSidePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picturBox1)).BeginInit();
			this.titlePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.loginPicturBox)).BeginInit();
			this.bottomPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// rightSidePanel
			// 
			this.rightSidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.rightSidePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.rightSidePanel.Controls.Add(this.picturBox1);
			this.rightSidePanel.Dock = System.Windows.Forms.DockStyle.Right;
			this.rightSidePanel.Location = new System.Drawing.Point(525, 0);
			this.rightSidePanel.Name = "rightSidePanel";
			this.rightSidePanel.Size = new System.Drawing.Size(175, 225);
			this.rightSidePanel.TabIndex = 2;
			// 
			// picturBox1
			// 
			this.picturBox1.Image = ((System.Drawing.Image)(resources.GetObject("picturBox1.Image")));
			this.picturBox1.Location = new System.Drawing.Point(23, 45);
			this.picturBox1.Name = "picturBox1";
			this.picturBox1.Size = new System.Drawing.Size(129, 134);
			this.picturBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picturBox1.TabIndex = 3;
			this.picturBox1.TabStop = false;
			// 
			// loginLabel
			// 
			this.loginLabel.AutoSize = true;
			this.loginLabel.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.loginLabel.ForeColor = System.Drawing.Color.White;
			this.loginLabel.Location = new System.Drawing.Point(398, 4);
			this.loginLabel.Name = "loginLabel";
			this.loginLabel.Size = new System.Drawing.Size(91, 22);
			this.loginLabel.TabIndex = 2;
			this.loginLabel.Text = "ورود به حساب";
			// 
			// titlePanel
			// 
			this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.titlePanel.Controls.Add(this.loginPicturBox);
			this.titlePanel.Controls.Add(this.minimizeButton);
			this.titlePanel.Controls.Add(this.loginLabel);
			this.titlePanel.Controls.Add(this.closeButton);
			this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.titlePanel.Location = new System.Drawing.Point(0, 0);
			this.titlePanel.Name = "titlePanel";
			this.titlePanel.Size = new System.Drawing.Size(525, 30);
			this.titlePanel.TabIndex = 0;
			// 
			// loginPicturBox
			// 
			this.loginPicturBox.Dock = System.Windows.Forms.DockStyle.Right;
			this.loginPicturBox.Image = ((System.Drawing.Image)(resources.GetObject("loginPicturBox.Image")));
			this.loginPicturBox.Location = new System.Drawing.Point(495, 0);
			this.loginPicturBox.Name = "loginPicturBox";
			this.loginPicturBox.Size = new System.Drawing.Size(30, 30);
			this.loginPicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.loginPicturBox.TabIndex = 3;
			this.loginPicturBox.TabStop = false;
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
			this.minimizeButton.TabIndex = 1;
			this.minimizeButton.UseVisualStyleBackColor = true;
			this.minimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
			// 
			// closeButton
			// 
			this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
			this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.closeButton.FlatAppearance.BorderSize = 0;
			this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
			this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeButton.Location = new System.Drawing.Point(12, 8);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(15, 15);
			this.closeButton.TabIndex = 0;
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// usernameEmailTextBox
			// 
			this.usernameEmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.usernameEmailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.usernameEmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.usernameEmailTextBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usernameEmailTextBox.ForeColor = System.Drawing.Color.Gray;
			this.usernameEmailTextBox.Location = new System.Drawing.Point(105, 38);
			this.usernameEmailTextBox.Name = "usernameEmailTextBox";
			this.usernameEmailTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.usernameEmailTextBox.Size = new System.Drawing.Size(314, 17);
			this.usernameEmailTextBox.TabIndex = 3;
			this.usernameEmailTextBox.Text = "Username\\Email";
			this.usernameEmailTextBox.Enter += new System.EventHandler(this.UsernameEmailTextBox_Enter);
			this.usernameEmailTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsernameEmailTextBox_KeyPress);
			this.usernameEmailTextBox.Leave += new System.EventHandler(this.UsernameEmailTextBox_Leave);
			// 
			// usernameEmailPanel
			// 
			this.usernameEmailPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.usernameEmailPanel.BackColor = System.Drawing.Color.Gray;
			this.usernameEmailPanel.Location = new System.Drawing.Point(105, 61);
			this.usernameEmailPanel.Name = "usernameEmailPanel";
			this.usernameEmailPanel.Size = new System.Drawing.Size(314, 1);
			this.usernameEmailPanel.TabIndex = 7;
			// 
			// passwordPanel
			// 
			this.passwordPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.passwordPanel.BackColor = System.Drawing.Color.Gray;
			this.passwordPanel.Location = new System.Drawing.Point(105, 103);
			this.passwordPanel.Name = "passwordPanel";
			this.passwordPanel.Size = new System.Drawing.Size(314, 1);
			this.passwordPanel.TabIndex = 8;
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.passwordTextBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordTextBox.ForeColor = System.Drawing.Color.Gray;
			this.passwordTextBox.Location = new System.Drawing.Point(105, 80);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.passwordTextBox.Size = new System.Drawing.Size(314, 17);
			this.passwordTextBox.TabIndex = 4;
			this.passwordTextBox.Text = "Password";
			this.passwordTextBox.Enter += new System.EventHandler(this.PasswordTextBox_Enter);
			this.passwordTextBox.Leave += new System.EventHandler(this.PasswordTextBox_Leave);
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 25;
			this.bunifuElipse1.TargetControl = this;
			// 
			// loginButton
			// 
			this.loginButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.loginButton.FlatAppearance.BorderSize = 0;
			this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.loginButton.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.loginButton.ForeColor = System.Drawing.Color.White;
			this.loginButton.Location = new System.Drawing.Point(105, 117);
			this.loginButton.Name = "loginButton";
			this.loginButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.loginButton.Size = new System.Drawing.Size(314, 31);
			this.loginButton.TabIndex = 5;
			this.loginButton.Text = "ورود";
			this.loginButton.UseVisualStyleBackColor = false;
			this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
			// 
			// newAccountLinkLabel
			// 
			this.newAccountLinkLabel.ActiveLinkColor = System.Drawing.Color.Gray;
			this.newAccountLinkLabel.AutoSize = true;
			this.newAccountLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.newAccountLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.newAccountLinkLabel.Location = new System.Drawing.Point(191, 14);
			this.newAccountLinkLabel.Name = "newAccountLinkLabel";
			this.newAccountLinkLabel.Size = new System.Drawing.Size(78, 17);
			this.newAccountLinkLabel.TabIndex = 1;
			this.newAccountLinkLabel.TabStop = true;
			this.newAccountLinkLabel.Text = "نام کاربری جدید";
			this.newAccountLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NewAccountLinkLabel_LinkClicked);
			// 
			// captionLabel1
			// 
			this.captionLabel1.AutoSize = true;
			this.captionLabel1.ForeColor = System.Drawing.Color.Gray;
			this.captionLabel1.Location = new System.Drawing.Point(253, 14);
			this.captionLabel1.Name = "captionLabel1";
			this.captionLabel1.Size = new System.Drawing.Size(123, 17);
			this.captionLabel1.TabIndex = 0;
			this.captionLabel1.Text = "برای ایجاد حساب جدید از";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.Gray;
			this.label1.Location = new System.Drawing.Point(148, 14);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label1.Size = new System.Drawing.Size(54, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "وارد شوید.";
			// 
			// bottomPanel
			// 
			this.bottomPanel.Controls.Add(this.label1);
			this.bottomPanel.Controls.Add(this.captionLabel1);
			this.bottomPanel.Controls.Add(this.newAccountLinkLabel);
			this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.bottomPanel.Location = new System.Drawing.Point(0, 180);
			this.bottomPanel.Name = "bottomPanel";
			this.bottomPanel.Size = new System.Drawing.Size(525, 45);
			this.bottomPanel.TabIndex = 1;
			// 
			// forgetPasswordLinkLabel
			// 
			this.forgetPasswordLinkLabel.AutoSize = true;
			this.forgetPasswordLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.forgetPasswordLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.forgetPasswordLinkLabel.Location = new System.Drawing.Point(211, 154);
			this.forgetPasswordLinkLabel.Name = "forgetPasswordLinkLabel";
			this.forgetPasswordLinkLabel.Size = new System.Drawing.Size(102, 17);
			this.forgetPasswordLinkLabel.TabIndex = 6;
			this.forgetPasswordLinkLabel.TabStop = true;
			this.forgetPasswordLinkLabel.Text = "رمز را فراموش کردید؟";
			this.forgetPasswordLinkLabel.Visible = false;
			this.forgetPasswordLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForgetPasswordLinkLabel_LinkClicked);
			// 
			// LoginForm
			// 
			this.AcceptButton = this.loginButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.CancelButton = this.closeButton;
			this.ClientSize = new System.Drawing.Size(700, 225);
			this.Controls.Add(this.forgetPasswordLinkLabel);
			this.Controls.Add(this.bottomPanel);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.passwordPanel);
			this.Controls.Add(this.usernameEmailPanel);
			this.Controls.Add(this.usernameEmailTextBox);
			this.Controls.Add(this.titlePanel);
			this.Controls.Add(this.rightSidePanel);
			this.ForeColor = System.Drawing.Color.Black;
			this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.MaximumSize = new System.Drawing.Size(700, 225);
			this.MinimumSize = new System.Drawing.Size(700, 225);
			this.Name = "LoginForm";
			this.Opacity = 0.95D;
			this.Text = "LoginForm";
			this.Load += new System.EventHandler(this.LoginForm_Load);
			this.rightSidePanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picturBox1)).EndInit();
			this.titlePanel.ResumeLayout(false);
			this.titlePanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.loginPicturBox)).EndInit();
			this.bottomPanel.ResumeLayout(false);
			this.bottomPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Mbb.Windows.Forms.Panel rightSidePanel;
		private Mbb.Windows.Forms.Panel titlePanel;
		private Mbb.Windows.Forms.Button minimizeButton;
		private Mbb.Windows.Forms.Button closeButton;
		private Mbb.Windows.Forms.Label loginLabel;
		private Mbb.Windows.Forms.TextBox usernameEmailTextBox;
		private Mbb.Windows.Forms.Panel usernameEmailPanel;
		private Mbb.Windows.Forms.Panel passwordPanel;
		private Mbb.Windows.Forms.TextBox passwordTextBox;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private Mbb.Windows.Forms.Button loginButton;
		private Mbb.Windows.Forms.LinkLabel newAccountLinkLabel;
		private Mbb.Windows.Forms.PicturBox picturBox1;
		private Mbb.Windows.Forms.Panel bottomPanel;
		private Mbb.Windows.Forms.Label label1;
		private Mbb.Windows.Forms.Label captionLabel1;
		private Mbb.Windows.Forms.PicturBox loginPicturBox;
		public Mbb.Windows.Forms.LinkLabel forgetPasswordLinkLabel;
	}
}

