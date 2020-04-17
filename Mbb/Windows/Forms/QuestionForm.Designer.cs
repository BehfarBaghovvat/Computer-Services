namespace Mbb.Windows.Forms
{
	partial class QuestionForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionForm));
			this.headerPanel = new System.Windows.Forms.Panel();
			this.closeButton = new System.Windows.Forms.Button();
			this.captionPanel = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.captionLabel = new System.Windows.Forms.Label();
			this.messageLabel = new System.Windows.Forms.Label();
			this.yesButton = new System.Windows.Forms.Button();
			this.noButton = new System.Windows.Forms.Button();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.headerPanel.SuspendLayout();
			this.captionPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// headerPanel
			// 
			this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
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
			// captionPanel
			// 
			this.captionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.captionPanel.Controls.Add(this.pictureBox1);
			this.captionPanel.Controls.Add(this.captionLabel);
			this.captionPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.captionPanel.Location = new System.Drawing.Point(0, 30);
			this.captionPanel.Name = "captionPanel";
			this.captionPanel.Size = new System.Drawing.Size(500, 50);
			this.captionPanel.TabIndex = 3;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Mbb.Properties.Resources.question_512;
			this.pictureBox1.Location = new System.Drawing.Point(35, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(50, 50);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
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
			// yesButton
			// 
			this.yesButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.yesButton.BackColor = System.Drawing.Color.Blue;
			this.yesButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
			this.yesButton.FlatAppearance.BorderSize = 0;
			this.yesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.yesButton.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.yesButton.ForeColor = System.Drawing.Color.White;
			this.yesButton.Location = new System.Drawing.Point(127, 128);
			this.yesButton.Name = "yesButton";
			this.yesButton.Size = new System.Drawing.Size(120, 30);
			this.yesButton.TabIndex = 1;
			this.yesButton.Text = "بله";
			this.yesButton.UseVisualStyleBackColor = false;
			// 
			// noButton
			// 
			this.noButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.noButton.BackColor = System.Drawing.Color.Blue;
			this.noButton.DialogResult = System.Windows.Forms.DialogResult.No;
			this.noButton.FlatAppearance.BorderSize = 0;
			this.noButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.noButton.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.noButton.ForeColor = System.Drawing.Color.White;
			this.noButton.Location = new System.Drawing.Point(253, 128);
			this.noButton.Name = "noButton";
			this.noButton.Size = new System.Drawing.Size(120, 30);
			this.noButton.TabIndex = 0;
			this.noButton.Text = "خیر";
			this.noButton.UseVisualStyleBackColor = false;
			this.noButton.Click += new System.EventHandler(this.NoButton_Click);
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 25;
			this.bunifuElipse1.TargetControl = this;
			// 
			// QuestionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Navy;
			this.ClientSize = new System.Drawing.Size(500, 170);
			this.Controls.Add(this.noButton);
			this.Controls.Add(this.yesButton);
			this.Controls.Add(this.messageLabel);
			this.Controls.Add(this.captionPanel);
			this.Controls.Add(this.headerPanel);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "QuestionForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "QuestionForm";
			this.headerPanel.ResumeLayout(false);
			this.captionPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel headerPanel;
		private System.Windows.Forms.Panel captionPanel;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label captionLabel;
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.Label messageLabel;
		private System.Windows.Forms.Button yesButton;
		private System.Windows.Forms.Button noButton;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
	}
}