namespace ComputerServices.UC_Project
{
	partial class MainBackgroundUC1
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainBackgroundUC1));
			this.logoPicturBox = new Mbb.Windows.Forms.PicturBox();
			this.versionLabel = new Mbb.Windows.Forms.Label();
			this.captionLabel = new Mbb.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.logoPicturBox)).BeginInit();
			this.SuspendLayout();
			// 
			// logoPicturBox
			// 
			this.logoPicturBox.BackColor = System.Drawing.Color.Transparent;
			this.logoPicturBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPicturBox.Image")));
			this.logoPicturBox.Location = new System.Drawing.Point(593, 0);
			this.logoPicturBox.Name = "logoPicturBox";
			this.logoPicturBox.Size = new System.Drawing.Size(157, 155);
			this.logoPicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.logoPicturBox.TabIndex = 0;
			this.logoPicturBox.TabStop = false;
			// 
			// versionLabel
			// 
			this.versionLabel.AutoSize = true;
			this.versionLabel.BackColor = System.Drawing.Color.Transparent;
			this.versionLabel.ForeColor = System.Drawing.Color.White;
			this.versionLabel.Location = new System.Drawing.Point(538, 0);
			this.versionLabel.Name = "versionLabel";
			this.versionLabel.Size = new System.Drawing.Size(49, 13);
			this.versionLabel.TabIndex = 1;
			this.versionLabel.Text = "ver 1.0.0";
			// 
			// captionLabel
			// 
			this.captionLabel.BackColor = System.Drawing.Color.Transparent;
			this.captionLabel.Font = new System.Drawing.Font("IRANSans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.captionLabel.ForeColor = System.Drawing.Color.Gold;
			this.captionLabel.Location = new System.Drawing.Point(403, 161);
			this.captionLabel.Name = "captionLabel";
			this.captionLabel.Size = new System.Drawing.Size(344, 107);
			this.captionLabel.TabIndex = 2;
			this.captionLabel.Text = "شرکت خدمات سیستمی و فنی\r\nهزاره سوم";
			this.captionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainBackgroundUC1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Controls.Add(this.captionLabel);
			this.Controls.Add(this.versionLabel);
			this.Controls.Add(this.logoPicturBox);
			this.Name = "MainBackgroundUC1";
			this.Size = new System.Drawing.Size(750, 550);
			((System.ComponentModel.ISupportInitialize)(this.logoPicturBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Mbb.Windows.Forms.PicturBox logoPicturBox;
		private Mbb.Windows.Forms.Label versionLabel;
		private Mbb.Windows.Forms.Label captionLabel;
	}
}
