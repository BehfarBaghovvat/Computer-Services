namespace ComputerServices
{
	partial class WelComeForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelComeForm));
			this.titlePanel = new Mbb.Windows.Forms.Panel();
			this.nameProgramLabel = new Mbb.Windows.Forms.Label();
			this.picturBox1 = new Mbb.Windows.Forms.PicturBox();
			this.sidePanel = new Mbb.Windows.Forms.Panel();
			this.ImagePanel = new Mbb.Windows.Forms.Panel();
			this.welcomePanel = new Mbb.Windows.Forms.Panel();
			this.bunifuCircleProgressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
			this.usernameLabel = new Mbb.Windows.Forms.Label();
			this.welcomeLabel = new Mbb.Windows.Forms.Label();
			this.circularPictureBox1 = new Mbb.Windows.Forms.CircularPictureBox();
			this.titlePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picturBox1)).BeginInit();
			this.welcomePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// titlePanel
			// 
			this.titlePanel.BackColor = System.Drawing.Color.DarkGray;
			this.titlePanel.Controls.Add(this.nameProgramLabel);
			this.titlePanel.Controls.Add(this.picturBox1);
			this.titlePanel.Controls.Add(this.sidePanel);
			this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.titlePanel.Location = new System.Drawing.Point(0, 0);
			this.titlePanel.Name = "titlePanel";
			this.titlePanel.Size = new System.Drawing.Size(1004, 100);
			this.titlePanel.TabIndex = 0;
			// 
			// nameProgramLabel
			// 
			this.nameProgramLabel.BackColor = System.Drawing.Color.Transparent;
			this.nameProgramLabel.Font = new System.Drawing.Font("IRANSans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.nameProgramLabel.ForeColor = System.Drawing.Color.DimGray;
			this.nameProgramLabel.Location = new System.Drawing.Point(175, 12);
			this.nameProgramLabel.Name = "nameProgramLabel";
			this.nameProgramLabel.Size = new System.Drawing.Size(228, 76);
			this.nameProgramLabel.TabIndex = 3;
			this.nameProgramLabel.Text = "سامانه خدمات کامپیوتر\r\nهزاره سوم";
			this.nameProgramLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// picturBox1
			// 
			this.picturBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.picturBox1.Image = ((System.Drawing.Image)(resources.GetObject("picturBox1.Image")));
			this.picturBox1.Location = new System.Drawing.Point(50, 0);
			this.picturBox1.Name = "picturBox1";
			this.picturBox1.Size = new System.Drawing.Size(100, 100);
			this.picturBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picturBox1.TabIndex = 2;
			this.picturBox1.TabStop = false;
			// 
			// sidePanel
			// 
			this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.sidePanel.Location = new System.Drawing.Point(0, 0);
			this.sidePanel.Name = "sidePanel";
			this.sidePanel.Size = new System.Drawing.Size(50, 100);
			this.sidePanel.TabIndex = 1;
			// 
			// ImagePanel
			// 
			this.ImagePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImagePanel.BackgroundImage")));
			this.ImagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ImagePanel.Dock = System.Windows.Forms.DockStyle.Right;
			this.ImagePanel.Location = new System.Drawing.Point(759, 100);
			this.ImagePanel.Name = "ImagePanel";
			this.ImagePanel.Size = new System.Drawing.Size(245, 358);
			this.ImagePanel.TabIndex = 1;
			// 
			// welcomePanel
			// 
			this.welcomePanel.Controls.Add(this.bunifuCircleProgressbar1);
			this.welcomePanel.Controls.Add(this.usernameLabel);
			this.welcomePanel.Controls.Add(this.welcomeLabel);
			this.welcomePanel.Controls.Add(this.circularPictureBox1);
			this.welcomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.welcomePanel.Font = new System.Drawing.Font("IRANSans", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.welcomePanel.Location = new System.Drawing.Point(0, 100);
			this.welcomePanel.Name = "welcomePanel";
			this.welcomePanel.Size = new System.Drawing.Size(759, 358);
			this.welcomePanel.TabIndex = 2;
			// 
			// bunifuCircleProgressbar1
			// 
			this.bunifuCircleProgressbar1.animated = false;
			this.bunifuCircleProgressbar1.animationIterval = 5;
			this.bunifuCircleProgressbar1.animationSpeed = 300;
			this.bunifuCircleProgressbar1.BackColor = System.Drawing.Color.Transparent;
			this.bunifuCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar1.BackgroundImage")));
			this.bunifuCircleProgressbar1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCircleProgressbar1.ForeColor = System.Drawing.Color.SeaGreen;
			this.bunifuCircleProgressbar1.LabelVisible = true;
			this.bunifuCircleProgressbar1.LineProgressThickness = 8;
			this.bunifuCircleProgressbar1.LineThickness = 5;
			this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(646, 248);
			this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
			this.bunifuCircleProgressbar1.MaxValue = 100;
			this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
			this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.DimGray;
			this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.Lime;
			this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(100, 100);
			this.bunifuCircleProgressbar1.TabIndex = 3;
			this.bunifuCircleProgressbar1.Value = 0;
			// 
			// usernameLabel
			// 
			this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
			this.usernameLabel.Font = new System.Drawing.Font("IRANSans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.usernameLabel.ForeColor = System.Drawing.Color.DimGray;
			this.usernameLabel.Location = new System.Drawing.Point(279, 252);
			this.usernameLabel.Name = "usernameLabel";
			this.usernameLabel.Size = new System.Drawing.Size(200, 58);
			this.usernameLabel.TabIndex = 2;
			this.usernameLabel.Text = "نام کاربری";
			this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// welcomeLabel
			// 
			this.welcomeLabel.AutoSize = true;
			this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
			this.welcomeLabel.Font = new System.Drawing.Font("IRANSans", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.welcomeLabel.ForeColor = System.Drawing.Color.Gold;
			this.welcomeLabel.Location = new System.Drawing.Point(562, 19);
			this.welcomeLabel.Name = "welcomeLabel";
			this.welcomeLabel.Size = new System.Drawing.Size(191, 58);
			this.welcomeLabel.TabIndex = 1;
			this.welcomeLabel.Text = "خوش آمدید";
			// 
			// circularPictureBox1
			// 
			this.circularPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circularPictureBox1.BackgroundImage")));
			this.circularPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.circularPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("circularPictureBox1.Image")));
			this.circularPictureBox1.Location = new System.Drawing.Point(279, 49);
			this.circularPictureBox1.Name = "circularPictureBox1";
			this.circularPictureBox1.Size = new System.Drawing.Size(200, 200);
			this.circularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.circularPictureBox1.TabIndex = 0;
			this.circularPictureBox1.TabStop = false;
			// 
			// WelComeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(100)))), ((int)(((byte)(224)))));
			this.ClientSize = new System.Drawing.Size(1004, 458);
			this.Controls.Add(this.welcomePanel);
			this.Controls.Add(this.ImagePanel);
			this.Controls.Add(this.titlePanel);
			this.Name = "WelComeForm";
			this.Text = "WelComeForm";
			this.titlePanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picturBox1)).EndInit();
			this.welcomePanel.ResumeLayout(false);
			this.welcomePanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Mbb.Windows.Forms.Panel titlePanel;
		private Mbb.Windows.Forms.Panel ImagePanel;
		private Mbb.Windows.Forms.Panel welcomePanel;
		private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar1;
		private Mbb.Windows.Forms.Label usernameLabel;
		private Mbb.Windows.Forms.Label welcomeLabel;
		private Mbb.Windows.Forms.CircularPictureBox circularPictureBox1;
		private Mbb.Windows.Forms.Label nameProgramLabel;
		private Mbb.Windows.Forms.PicturBox picturBox1;
		private Mbb.Windows.Forms.Panel sidePanel;
	}
}