﻿namespace Infrastructure
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
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.notificationStatusPicturBox = new Mbb.Windows.Forms.PicturBox();
			this.messageLabel = new Mbb.Windows.Forms.Label();
			this.objectPictureBox = new Mbb.Windows.Forms.PicturBox();
			this.cancelButton = new Mbb.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.captionLabel = new Mbb.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.notificationStatusPicturBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.objectPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 15;
			this.bunifuElipse1.TargetControl = this;
			// 
			// notificationStatusPicturBox
			// 
			this.notificationStatusPicturBox.BackColor = System.Drawing.Color.Transparent;
			this.notificationStatusPicturBox.Image = global::ComputerServices.Properties.Resources.succes_512;
			this.notificationStatusPicturBox.Location = new System.Drawing.Point(3, 20);
			this.notificationStatusPicturBox.Name = "notificationStatusPicturBox";
			this.notificationStatusPicturBox.Size = new System.Drawing.Size(43, 45);
			this.notificationStatusPicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.notificationStatusPicturBox.TabIndex = 1;
			this.notificationStatusPicturBox.TabStop = false;
			// 
			// messageLabel
			// 
			this.messageLabel.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.messageLabel.ForeColor = System.Drawing.Color.White;
			this.messageLabel.Location = new System.Drawing.Point(51, 14);
			this.messageLabel.Name = "messageLabel";
			this.messageLabel.Size = new System.Drawing.Size(290, 56);
			this.messageLabel.TabIndex = 2;
			this.messageLabel.Text = "پیغام";
			// 
			// objectPictureBox
			// 
			this.objectPictureBox.BackColor = System.Drawing.Color.Transparent;
			this.objectPictureBox.Location = new System.Drawing.Point(347, 20);
			this.objectPictureBox.Name = "objectPictureBox";
			this.objectPictureBox.Size = new System.Drawing.Size(43, 45);
			this.objectPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.objectPictureBox.TabIndex = 4;
			this.objectPictureBox.TabStop = false;
			// 
			// cancelButton
			// 
			this.cancelButton.BackColor = System.Drawing.Color.Transparent;
			this.cancelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelButton.BackgroundImage")));
			this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.cancelButton.FlatAppearance.BorderSize = 0;
			this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cancelButton.Location = new System.Drawing.Point(395, 29);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(43, 27);
			this.cancelButton.TabIndex = 5;
			this.cancelButton.UseVisualStyleBackColor = false;
			this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			// 
			// captionLabel
			// 
			this.captionLabel.Font = new System.Drawing.Font("IRANSans", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.captionLabel.ForeColor = System.Drawing.Color.White;
			this.captionLabel.Location = new System.Drawing.Point(10, -2);
			this.captionLabel.Name = "captionLabel";
			this.captionLabel.Size = new System.Drawing.Size(103, 18);
			this.captionLabel.TabIndex = 6;
			this.captionLabel.Text = "عنوان";
			this.captionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// PopupNotificationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.RoyalBlue;
			this.ClientSize = new System.Drawing.Size(450, 85);
			this.Controls.Add(this.captionLabel);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.objectPictureBox);
			this.Controls.Add(this.messageLabel);
			this.Controls.Add(this.notificationStatusPicturBox);
			this.Name = "PopupNotificationForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Text = "PopupNotificationForm";
			((System.ComponentModel.ISupportInitialize)(this.notificationStatusPicturBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.objectPictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private Mbb.Windows.Forms.Button cancelButton;
		private Mbb.Windows.Forms.PicturBox objectPictureBox;
		private Mbb.Windows.Forms.Label messageLabel;
		private Mbb.Windows.Forms.PicturBox notificationStatusPicturBox;
		private System.Windows.Forms.Timer timer1;
		private Mbb.Windows.Forms.Label captionLabel;
	}
}