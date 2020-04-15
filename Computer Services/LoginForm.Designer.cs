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
			this.panel0 = new Mbb.Windows.Forms.Panel();
			this.picturBox1 = new Mbb.Windows.Forms.PicturBox();
			this.loginLabel = new Mbb.Windows.Forms.Label();
			this.titlePanel = new Mbb.Windows.Forms.Panel();
			this.minimizeButton = new Mbb.Windows.Forms.Button();
			this.closeButton = new Mbb.Windows.Forms.Button();
			this.usernameTextBox = new Mbb.Windows.Forms.TextBox();
			this.panel1 = new Mbb.Windows.Forms.Panel();
			this.panel2 = new Mbb.Windows.Forms.Panel();
			this.passwordTextBox = new Mbb.Windows.Forms.TextBox();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.loginButton = new Mbb.Windows.Forms.Button();
			this.newAccountLinkLabel = new Mbb.Windows.Forms.LinkLabel();
			this.captionLabel1 = new Mbb.Windows.Forms.Label();
			this.label1 = new Mbb.Windows.Forms.Label();
			this.panel3 = new Mbb.Windows.Forms.Panel();
			this.forgetPasswordLinkLabel = new Mbb.Windows.Forms.LinkLabel();
			this.loginPicturBox = new Mbb.Windows.Forms.PicturBox();
			this.panel0.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picturBox1)).BeginInit();
			this.titlePanel.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.loginPicturBox)).BeginInit();
			this.SuspendLayout();
			// 
			// panel0
			// 
			this.panel0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.panel0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.panel0.Controls.Add(this.picturBox1);
			this.panel0.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel0.Location = new System.Drawing.Point(546, 0);
			this.panel0.Name = "panel0";
			this.panel0.Size = new System.Drawing.Size(204, 250);
			this.panel0.TabIndex = 0;
			// 
			// picturBox1
			// 
			this.picturBox1.Image = ((System.Drawing.Image)(resources.GetObject("picturBox1.Image")));
			this.picturBox1.Location = new System.Drawing.Point(27, 50);
			this.picturBox1.Name = "picturBox1";
			this.picturBox1.Size = new System.Drawing.Size(150, 150);
			this.picturBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picturBox1.TabIndex = 3;
			this.picturBox1.TabStop = false;
			// 
			// loginLabel
			// 
			this.loginLabel.AutoSize = true;
			this.loginLabel.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.loginLabel.ForeColor = System.Drawing.Color.White;
			this.loginLabel.Location = new System.Drawing.Point(423, 3);
			this.loginLabel.Name = "loginLabel";
			this.loginLabel.Size = new System.Drawing.Size(91, 24);
			this.loginLabel.TabIndex = 2;
			this.loginLabel.Text = "ورود به حساب";
			// 
			// titlePanel
			// 
			this.titlePanel.Controls.Add(this.loginPicturBox);
			this.titlePanel.Controls.Add(this.minimizeButton);
			this.titlePanel.Controls.Add(this.loginLabel);
			this.titlePanel.Controls.Add(this.closeButton);
			this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.titlePanel.Location = new System.Drawing.Point(0, 0);
			this.titlePanel.Name = "titlePanel";
			this.titlePanel.Size = new System.Drawing.Size(546, 30);
			this.titlePanel.TabIndex = 1;
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
			// usernameTextBox
			// 
			this.usernameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.usernameTextBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usernameTextBox.ForeColor = System.Drawing.Color.Gray;
			this.usernameTextBox.Location = new System.Drawing.Point(123, 42);
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.usernameTextBox.Size = new System.Drawing.Size(300, 17);
			this.usernameTextBox.TabIndex = 4;
			this.usernameTextBox.Text = "Username\\Email";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Location = new System.Drawing.Point(123, 68);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(300, 1);
			this.panel1.TabIndex = 6;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Location = new System.Drawing.Point(123, 115);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(300, 1);
			this.panel2.TabIndex = 7;
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.passwordTextBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordTextBox.ForeColor = System.Drawing.Color.Gray;
			this.passwordTextBox.Location = new System.Drawing.Point(123, 89);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.passwordTextBox.Size = new System.Drawing.Size(300, 17);
			this.passwordTextBox.TabIndex = 8;
			this.passwordTextBox.Text = "Password";
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 25;
			this.bunifuElipse1.TargetControl = this;
			// 
			// loginButton
			// 
			this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.loginButton.FlatAppearance.BorderSize = 0;
			this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.loginButton.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.loginButton.ForeColor = System.Drawing.Color.White;
			this.loginButton.Location = new System.Drawing.Point(123, 131);
			this.loginButton.Name = "loginButton";
			this.loginButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.loginButton.Size = new System.Drawing.Size(300, 35);
			this.loginButton.TabIndex = 9;
			this.loginButton.Text = "ورود";
			this.loginButton.UseVisualStyleBackColor = false;
			// 
			// newAccountLinkLabel
			// 
			this.newAccountLinkLabel.ActiveLinkColor = System.Drawing.Color.Gray;
			this.newAccountLinkLabel.AutoSize = true;
			this.newAccountLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.newAccountLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.newAccountLinkLabel.Location = new System.Drawing.Point(201, 16);
			this.newAccountLinkLabel.Name = "newAccountLinkLabel";
			this.newAccountLinkLabel.Size = new System.Drawing.Size(77, 19);
			this.newAccountLinkLabel.TabIndex = 10;
			this.newAccountLinkLabel.TabStop = true;
			this.newAccountLinkLabel.Text = "نام کاربری جدید";
			// 
			// captionLabel1
			// 
			this.captionLabel1.AutoSize = true;
			this.captionLabel1.ForeColor = System.Drawing.Color.Gray;
			this.captionLabel1.Location = new System.Drawing.Point(273, 16);
			this.captionLabel1.Name = "captionLabel1";
			this.captionLabel1.Size = new System.Drawing.Size(122, 19);
			this.captionLabel1.TabIndex = 11;
			this.captionLabel1.Text = "برای ایجاد حساب جدید از";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.Gray;
			this.label1.Location = new System.Drawing.Point(151, 16);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label1.Size = new System.Drawing.Size(55, 19);
			this.label1.TabIndex = 12;
			this.label1.Text = "وارد شوید.";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.label1);
			this.panel3.Controls.Add(this.captionLabel1);
			this.panel3.Controls.Add(this.newAccountLinkLabel);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 200);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(546, 50);
			this.panel3.TabIndex = 13;
			// 
			// forgetPasswordLinkLabel
			// 
			this.forgetPasswordLinkLabel.AutoSize = true;
			this.forgetPasswordLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.forgetPasswordLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.forgetPasswordLinkLabel.Location = new System.Drawing.Point(221, 172);
			this.forgetPasswordLinkLabel.Name = "forgetPasswordLinkLabel";
			this.forgetPasswordLinkLabel.Size = new System.Drawing.Size(104, 19);
			this.forgetPasswordLinkLabel.TabIndex = 14;
			this.forgetPasswordLinkLabel.TabStop = true;
			this.forgetPasswordLinkLabel.Text = "رمز را فراموش کردید؟";
			this.forgetPasswordLinkLabel.Visible = false;
			// 
			// loginPicturBox
			// 
			this.loginPicturBox.Dock = System.Windows.Forms.DockStyle.Right;
			this.loginPicturBox.Image = ((System.Drawing.Image)(resources.GetObject("loginPicturBox.Image")));
			this.loginPicturBox.Location = new System.Drawing.Point(516, 0);
			this.loginPicturBox.Name = "loginPicturBox";
			this.loginPicturBox.Size = new System.Drawing.Size(30, 30);
			this.loginPicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.loginPicturBox.TabIndex = 3;
			this.loginPicturBox.TabStop = false;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.ClientSize = new System.Drawing.Size(750, 250);
			this.Controls.Add(this.forgetPasswordLinkLabel);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.usernameTextBox);
			this.Controls.Add(this.titlePanel);
			this.Controls.Add(this.panel0);
			this.ForeColor = System.Drawing.Color.Black;
			this.Name = "LoginForm";
			this.Opacity = 0.9D;
			this.Text = "LoginForm";
			this.panel0.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picturBox1)).EndInit();
			this.titlePanel.ResumeLayout(false);
			this.titlePanel.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.loginPicturBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Mbb.Windows.Forms.Panel panel0;
		private Mbb.Windows.Forms.Panel titlePanel;
		private Mbb.Windows.Forms.Button minimizeButton;
		private Mbb.Windows.Forms.Button closeButton;
		private Mbb.Windows.Forms.Label loginLabel;
		private Mbb.Windows.Forms.TextBox usernameTextBox;
		private Mbb.Windows.Forms.Panel panel1;
		private Mbb.Windows.Forms.Panel panel2;
		private Mbb.Windows.Forms.TextBox passwordTextBox;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private Mbb.Windows.Forms.Button loginButton;
		private Mbb.Windows.Forms.LinkLabel newAccountLinkLabel;
		private Mbb.Windows.Forms.PicturBox picturBox1;
		private Mbb.Windows.Forms.Panel panel3;
		private Mbb.Windows.Forms.Label label1;
		private Mbb.Windows.Forms.Label captionLabel1;
		private Mbb.Windows.Forms.LinkLabel forgetPasswordLinkLabel;
		private Mbb.Windows.Forms.PicturBox loginPicturBox;
	}
}

