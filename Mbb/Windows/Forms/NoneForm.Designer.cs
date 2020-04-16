namespace Mbb.Windows.Forms
{
	partial class NoneForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoneForm));
			this.captionPanel = new System.Windows.Forms.Panel();
			this.captionLabel = new System.Windows.Forms.Label();
			this.headerPanel = new System.Windows.Forms.Panel();
			this.closeButton = new System.Windows.Forms.Button();
			this.okButton = new System.Windows.Forms.Button();
			this.messageLabel = new System.Windows.Forms.Label();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.captionPanel.SuspendLayout();
			this.headerPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// captionPanel
			// 
			this.captionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.captionPanel.Controls.Add(this.captionLabel);
			this.captionPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.captionPanel.Location = new System.Drawing.Point(0, 30);
			this.captionPanel.Name = "captionPanel";
			this.captionPanel.Size = new System.Drawing.Size(500, 50);
			this.captionPanel.TabIndex = 3;
			// 
			// captionLabel
			// 
			this.captionLabel.Font = new System.Drawing.Font("IRANSans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.captionLabel.ForeColor = System.Drawing.Color.White;
			this.captionLabel.Location = new System.Drawing.Point(200, 0);
			this.captionLabel.Name = "captionLabel";
			this.captionLabel.Size = new System.Drawing.Size(300, 50);
			this.captionLabel.TabIndex = 0;
			this.captionLabel.Text = "عنوان";
			this.captionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// headerPanel
			// 
			this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.headerPanel.Controls.Add(this.closeButton);
			this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.headerPanel.Location = new System.Drawing.Point(0, 0);
			this.headerPanel.Name = "headerPanel";
			this.headerPanel.Size = new System.Drawing.Size(500, 30);
			this.headerPanel.TabIndex = 4;
			// 
			// closeButton
			// 
			this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
			this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.closeButton.DialogResult = System.Windows.Forms.DialogResult.No;
			this.closeButton.FlatAppearance.BorderSize = 0;
			this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeButton.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.closeButton.ForeColor = System.Drawing.Color.White;
			this.closeButton.Location = new System.Drawing.Point(12, 8);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(15, 15);
			this.closeButton.TabIndex = 0;
			this.closeButton.Text = "خیر";
			this.closeButton.UseVisualStyleBackColor = false;
			// 
			// okButton
			// 
			this.okButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.okButton.BackColor = System.Drawing.Color.Silver;
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.okButton.FlatAppearance.BorderSize = 0;
			this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.okButton.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.okButton.ForeColor = System.Drawing.Color.Black;
			this.okButton.Location = new System.Drawing.Point(190, 128);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(120, 30);
			this.okButton.TabIndex = 1;
			this.okButton.Text = "باشه";
			this.okButton.UseVisualStyleBackColor = false;
			// 
			// messageLabel
			// 
			this.messageLabel.AutoSize = true;
			this.messageLabel.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.messageLabel.ForeColor = System.Drawing.Color.White;
			this.messageLabel.Location = new System.Drawing.Point(13, 90);
			this.messageLabel.Name = "messageLabel";
			this.messageLabel.Size = new System.Drawing.Size(39, 24);
			this.messageLabel.TabIndex = 2;
			this.messageLabel.Text = "پیغام";
			this.messageLabel.SizeChanged += new System.EventHandler(this.MessageLabel_SizeChanged);
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 25;
			this.bunifuElipse1.TargetControl = this;
			// 
			// NoneForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.ClientSize = new System.Drawing.Size(500, 170);
			this.Controls.Add(this.captionPanel);
			this.Controls.Add(this.headerPanel);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.messageLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "NoneForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "NoneForm";
			this.captionPanel.ResumeLayout(false);
			this.headerPanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel captionPanel;
		private System.Windows.Forms.Label captionLabel;
		private System.Windows.Forms.Panel headerPanel;
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Label messageLabel;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
	}
}