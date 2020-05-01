namespace ComputerServices
{
	partial class WelComeUserForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelComeUserForm));
			this.righrSidePanel = new Mbb.Windows.Forms.Panel();
			this.titlePanel = new Mbb.Windows.Forms.Panel();
			this.titleLabel = new Mbb.Windows.Forms.Label();
			this.userImagePictureBox = new Mbb.Windows.Forms.CircularPictureBox();
			this.welcomeUserPanel = new Mbb.Windows.Forms.Panel();
			this.bunifuCircleProgressbar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
			this.usernameLabel = new Mbb.Windows.Forms.Label();
			this.welcomeLabel = new Mbb.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.titlePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.userImagePictureBox)).BeginInit();
			this.welcomeUserPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// righrSidePanel
			// 
			this.righrSidePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("righrSidePanel.BackgroundImage")));
			this.righrSidePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.righrSidePanel.Dock = System.Windows.Forms.DockStyle.Right;
			this.righrSidePanel.Location = new System.Drawing.Point(594, 137);
			this.righrSidePanel.Name = "righrSidePanel";
			this.righrSidePanel.Size = new System.Drawing.Size(210, 363);
			this.righrSidePanel.TabIndex = 1;
			// 
			// titlePanel
			// 
			this.titlePanel.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.titlePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.titlePanel.Controls.Add(this.titleLabel);
			this.titlePanel.Controls.Add(this.userImagePictureBox);
			this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.titlePanel.Location = new System.Drawing.Point(0, 0);
			this.titlePanel.Name = "titlePanel";
			this.titlePanel.Size = new System.Drawing.Size(804, 137);
			this.titlePanel.TabIndex = 0;
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.Font = new System.Drawing.Font("IRANSans", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.titleLabel.ForeColor = System.Drawing.Color.MediumPurple;
			this.titleLabel.Location = new System.Drawing.Point(237, 64);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.titleLabel.Size = new System.Drawing.Size(564, 67);
			this.titleLabel.TabIndex = 0;
			this.titleLabel.Text = "سامانه خدمات کامپیوتر هزاره سوم";
			// 
			// userImagePictureBox
			// 
			this.userImagePictureBox.BackColor = System.Drawing.Color.Transparent;
			this.userImagePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.userImagePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("userImagePictureBox.Image")));
			this.userImagePictureBox.Location = new System.Drawing.Point(12, 6);
			this.userImagePictureBox.Name = "userImagePictureBox";
			this.userImagePictureBox.Size = new System.Drawing.Size(125, 125);
			this.userImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.userImagePictureBox.TabIndex = 0;
			this.userImagePictureBox.TabStop = false;
			// 
			// welcomeUserPanel
			// 
			this.welcomeUserPanel.BackColor = System.Drawing.Color.Transparent;
			this.welcomeUserPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("welcomeUserPanel.BackgroundImage")));
			this.welcomeUserPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.welcomeUserPanel.Controls.Add(this.bunifuCircleProgressbar);
			this.welcomeUserPanel.Controls.Add(this.usernameLabel);
			this.welcomeUserPanel.Controls.Add(this.welcomeLabel);
			this.welcomeUserPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.welcomeUserPanel.Location = new System.Drawing.Point(0, 137);
			this.welcomeUserPanel.Name = "welcomeUserPanel";
			this.welcomeUserPanel.Size = new System.Drawing.Size(594, 363);
			this.welcomeUserPanel.TabIndex = 4;
			// 
			// bunifuCircleProgressbar
			// 
			this.bunifuCircleProgressbar.animated = false;
			this.bunifuCircleProgressbar.animationIterval = 5;
			this.bunifuCircleProgressbar.animationSpeed = 300;
			this.bunifuCircleProgressbar.BackColor = System.Drawing.Color.Transparent;
			this.bunifuCircleProgressbar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar.BackgroundImage")));
			this.bunifuCircleProgressbar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCircleProgressbar.ForeColor = System.Drawing.Color.SeaGreen;
			this.bunifuCircleProgressbar.LabelVisible = true;
			this.bunifuCircleProgressbar.LineProgressThickness = 8;
			this.bunifuCircleProgressbar.LineThickness = 5;
			this.bunifuCircleProgressbar.Location = new System.Drawing.Point(15, 281);
			this.bunifuCircleProgressbar.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.bunifuCircleProgressbar.MaxValue = 100;
			this.bunifuCircleProgressbar.Name = "bunifuCircleProgressbar";
			this.bunifuCircleProgressbar.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.bunifuCircleProgressbar.ProgressColor = System.Drawing.Color.SlateBlue;
			this.bunifuCircleProgressbar.Size = new System.Drawing.Size(75, 75);
			this.bunifuCircleProgressbar.TabIndex = 2;
			this.bunifuCircleProgressbar.Value = 0;
			// 
			// usernameLabel
			// 
			this.usernameLabel.Font = new System.Drawing.Font("IRANSans", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.usernameLabel.ForeColor = System.Drawing.Color.Gold;
			this.usernameLabel.Location = new System.Drawing.Point(12, 91);
			this.usernameLabel.Name = "usernameLabel";
			this.usernameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.usernameLabel.Size = new System.Drawing.Size(576, 127);
			this.usernameLabel.TabIndex = 1;
			this.usernameLabel.Text = "نام کاربر";
			this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// welcomeLabel
			// 
			this.welcomeLabel.AutoSize = true;
			this.welcomeLabel.Font = new System.Drawing.Font("B Yekan", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.welcomeLabel.ForeColor = System.Drawing.Color.Gray;
			this.welcomeLabel.Location = new System.Drawing.Point(417, 41);
			this.welcomeLabel.Name = "welcomeLabel";
			this.welcomeLabel.Size = new System.Drawing.Size(171, 50);
			this.welcomeLabel.TabIndex = 0;
			this.welcomeLabel.Text = "خوش آمدید";
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			// 
			// timer2
			// 
			this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
			// 
			// WelComeUserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkViolet;
			this.ClientSize = new System.Drawing.Size(804, 500);
			this.Controls.Add(this.welcomeUserPanel);
			this.Controls.Add(this.righrSidePanel);
			this.Controls.Add(this.titlePanel);
			this.Name = "WelComeUserForm";
			this.Opacity = 0.9D;
			this.Text = "WelComeUserForm";
			this.Load += new System.EventHandler(this.WelComeUserForm_Load);
			this.titlePanel.ResumeLayout(false);
			this.titlePanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.userImagePictureBox)).EndInit();
			this.welcomeUserPanel.ResumeLayout(false);
			this.welcomeUserPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Mbb.Windows.Forms.Panel titlePanel;
		private Mbb.Windows.Forms.Label titleLabel;
		private Mbb.Windows.Forms.Panel righrSidePanel;
		private Mbb.Windows.Forms.CircularPictureBox userImagePictureBox;
		private Mbb.Windows.Forms.Panel welcomeUserPanel;
		private Mbb.Windows.Forms.Label usernameLabel;
		private Mbb.Windows.Forms.Label welcomeLabel;
		private System.Windows.Forms.Timer timer1;
		private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar;
		private System.Windows.Forms.Timer timer2;
	}
}