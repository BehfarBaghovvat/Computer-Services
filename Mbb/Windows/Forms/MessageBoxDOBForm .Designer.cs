namespace Mbb.Windows.Forms
{
	partial class MessageBoxDOBForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBoxDOBForm));
			this.panel1 = new Mbb.Windows.Forms.Panel();
			this.captionLabel = new Mbb.Windows.Forms.Label();
			this.messageLabel = new Mbb.Windows.Forms.Label();
			this.noCancelButton = new Mbb.Windows.Forms.Button();
			this.yesOkButton = new Mbb.Windows.Forms.Button();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse();
			this.iconPicturBox = new Mbb.Windows.Forms.PicturBox();
			this.closeButton = new Mbb.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconPicturBox)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.closeButton);
			this.panel1.Controls.Add(this.captionLabel);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(450, 30);
			this.panel1.TabIndex = 0;
			// 
			// captionLabel
			// 
			this.captionLabel.AutoSize = true;
			this.captionLabel.ForeColor = System.Drawing.Color.White;
			this.captionLabel.Location = new System.Drawing.Point(397, 6);
			this.captionLabel.Name = "captionLabel";
			this.captionLabel.Size = new System.Drawing.Size(33, 19);
			this.captionLabel.TabIndex = 1;
			this.captionLabel.Text = "عنوان";
			// 
			// messageLabel
			// 
			this.messageLabel.AutoEllipsis = true;
			this.messageLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.messageLabel.ForeColor = System.Drawing.Color.White;
			this.messageLabel.Location = new System.Drawing.Point(62, 36);
			this.messageLabel.Name = "messageLabel";
			this.messageLabel.Size = new System.Drawing.Size(320, 35);
			this.messageLabel.TabIndex = 2;
			this.messageLabel.Text = "پیغام";
			this.messageLabel.SizeChanged += new System.EventHandler(this.MessageLabel_SizeChanged);
			// 
			// noCancelButton
			// 
			this.noCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.noCancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(225)))));
			this.noCancelButton.FlatAppearance.BorderSize = 0;
			this.noCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.noCancelButton.ForeColor = System.Drawing.Color.White;
			this.noCancelButton.Location = new System.Drawing.Point(228, 95);
			this.noCancelButton.Name = "noCancelButton";
			this.noCancelButton.Size = new System.Drawing.Size(95, 25);
			this.noCancelButton.TabIndex = 3;
			this.noCancelButton.Text = "خیر";
			this.noCancelButton.UseVisualStyleBackColor = false;
			// 
			// yesOkButton
			// 
			this.yesOkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.yesOkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(225)))));
			this.yesOkButton.FlatAppearance.BorderSize = 0;
			this.yesOkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.yesOkButton.ForeColor = System.Drawing.Color.White;
			this.yesOkButton.Location = new System.Drawing.Point(127, 95);
			this.yesOkButton.Name = "yesOkButton";
			this.yesOkButton.Size = new System.Drawing.Size(95, 25);
			this.yesOkButton.TabIndex = 4;
			this.yesOkButton.Text = "بله";
			this.yesOkButton.UseVisualStyleBackColor = false;
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 20;
			this.bunifuElipse1.TargetControl = this;
			// 
			// iconPicturBox
			// 
			this.iconPicturBox.Location = new System.Drawing.Point(388, 36);
			this.iconPicturBox.Name = "iconPicturBox";
			this.iconPicturBox.Size = new System.Drawing.Size(50, 50);
			this.iconPicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.iconPicturBox.TabIndex = 5;
			this.iconPicturBox.TabStop = false;
			// 
			// closeButton
			// 
			this.closeButton.BackColor = System.Drawing.Color.Transparent;
			this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
			this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.closeButton.FlatAppearance.BorderSize = 0;
			this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
			this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeButton.Location = new System.Drawing.Point(0, 8);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(30, 15);
			this.closeButton.TabIndex = 0;
			this.closeButton.UseVisualStyleBackColor = false;
			// 
			// MessageBoxDOBForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.RoyalBlue;
			this.ClientSize = new System.Drawing.Size(450, 135);
			this.Controls.Add(this.iconPicturBox);
			this.Controls.Add(this.yesOkButton);
			this.Controls.Add(this.noCancelButton);
			this.Controls.Add(this.messageLabel);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.Name = "MessageBoxDOBForm";
			this.Opacity = 0.9D;
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Text = "MessageBoxSIBForm";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconPicturBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Panel panel1;
		private Button closeButton;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private Label captionLabel;
		private Label messageLabel;
		private PicturBox iconPicturBox;
		private Button noCancelButton;
		private Button yesOkButton;
	}
}