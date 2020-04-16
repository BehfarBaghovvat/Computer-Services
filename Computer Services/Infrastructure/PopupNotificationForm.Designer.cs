namespace Infrastructure
{
	partial class PopupNotificationForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopupNotificationForm));
			this.objectpicturBox = new Mbb.Windows.Forms.PicturBox();
			this.cancelButton = new Mbb.Windows.Forms.Button();
			this.alertIconPicturBox = new Mbb.Windows.Forms.PicturBox();
			this.alertMessageLabel = new Mbb.Windows.Forms.Label();
			this.captionLabel = new Mbb.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.objectpicturBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.alertIconPicturBox)).BeginInit();
			this.SuspendLayout();
			// 
			// objectpicturBox
			// 
			this.objectpicturBox.Location = new System.Drawing.Point(305, 20);
			this.objectpicturBox.Name = "objectpicturBox";
			this.objectpicturBox.Size = new System.Drawing.Size(50, 50);
			this.objectpicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.objectpicturBox.TabIndex = 12;
			this.objectpicturBox.TabStop = false;
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelButton.BackgroundImage")));
			this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.cancelButton.FlatAppearance.BorderSize = 0;
			this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cancelButton.Location = new System.Drawing.Point(361, 28);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(45, 34);
			this.cancelButton.TabIndex = 11;
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// alertIconPicturBox
			// 
			this.alertIconPicturBox.Location = new System.Drawing.Point(5, 23);
			this.alertIconPicturBox.Name = "alertIconPicturBox";
			this.alertIconPicturBox.Size = new System.Drawing.Size(47, 45);
			this.alertIconPicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.alertIconPicturBox.TabIndex = 9;
			this.alertIconPicturBox.TabStop = false;
			// 
			// alertMessageLabel
			// 
			this.alertMessageLabel.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.alertMessageLabel.Location = new System.Drawing.Point(58, 31);
			this.alertMessageLabel.Name = "alertMessageLabel";
			this.alertMessageLabel.Size = new System.Drawing.Size(241, 28);
			this.alertMessageLabel.TabIndex = 8;
			this.alertMessageLabel.Text = "پیغام خطا";
			this.alertMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// captionLabel
			// 
			this.captionLabel.Font = new System.Drawing.Font("IRANSans", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.captionLabel.Location = new System.Drawing.Point(2, 2);
			this.captionLabel.Name = "captionLabel";
			this.captionLabel.Size = new System.Drawing.Size(98, 15);
			this.captionLabel.TabIndex = 10;
			this.captionLabel.Text = "caption";
			this.captionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// PopupNotificationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.RoyalBlue;
			this.ClientSize = new System.Drawing.Size(410, 90);
			this.Controls.Add(this.objectpicturBox);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.alertIconPicturBox);
			this.Controls.Add(this.alertMessageLabel);
			this.Controls.Add(this.captionLabel);
			this.ForeColor = System.Drawing.Color.White;
			this.Name = "PopupNotificationForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Text = "PopupNotificationForm";
			((System.ComponentModel.ISupportInitialize)(this.objectpicturBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.alertIconPicturBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Mbb.Windows.Forms.PicturBox objectpicturBox;
		private Mbb.Windows.Forms.Button cancelButton;
		private Mbb.Windows.Forms.PicturBox alertIconPicturBox;
		public Mbb.Windows.Forms.Label alertMessageLabel;
		public Mbb.Windows.Forms.Label captionLabel;
		private System.Windows.Forms.Timer timer1;
	}
}