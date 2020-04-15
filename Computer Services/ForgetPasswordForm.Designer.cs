namespace ComputerServices
{
	partial class ForgetPasswordForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPasswordForm));
			this.titlePanel = new Mbb.Windows.Forms.Panel();
			this.minimizeButton = new Mbb.Windows.Forms.Button();
			this.closeButton = new Mbb.Windows.Forms.Button();
			this.textBox1 = new Mbb.Windows.Forms.TextBox();
			this.emailPanel = new Mbb.Windows.Forms.Panel();
			this.sendPasswordButton = new Mbb.Windows.Forms.Button();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.titlePanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// titlePanel
			// 
			this.titlePanel.Controls.Add(this.minimizeButton);
			this.titlePanel.Controls.Add(this.closeButton);
			this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.titlePanel.Location = new System.Drawing.Point(0, 0);
			this.titlePanel.Name = "titlePanel";
			this.titlePanel.Size = new System.Drawing.Size(450, 30);
			this.titlePanel.TabIndex = 0;
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
			this.minimizeButton.TabIndex = 3;
			this.minimizeButton.UseVisualStyleBackColor = true;
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
			this.closeButton.TabIndex = 2;
			this.closeButton.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.ForeColor = System.Drawing.Color.DimGray;
			this.textBox1.Location = new System.Drawing.Point(100, 55);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(250, 20);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "Enter Email";
			// 
			// emailPanel
			// 
			this.emailPanel.BackColor = System.Drawing.Color.DimGray;
			this.emailPanel.Location = new System.Drawing.Point(100, 81);
			this.emailPanel.Name = "emailPanel";
			this.emailPanel.Size = new System.Drawing.Size(250, 1);
			this.emailPanel.TabIndex = 2;
			// 
			// sendPasswordButton
			// 
			this.sendPasswordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.sendPasswordButton.FlatAppearance.BorderSize = 0;
			this.sendPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.sendPasswordButton.ForeColor = System.Drawing.Color.White;
			this.sendPasswordButton.Location = new System.Drawing.Point(100, 111);
			this.sendPasswordButton.Name = "sendPasswordButton";
			this.sendPasswordButton.Size = new System.Drawing.Size(250, 34);
			this.sendPasswordButton.TabIndex = 3;
			this.sendPasswordButton.Text = "ارسال رمز عبور";
			this.sendPasswordButton.UseVisualStyleBackColor = false;
			this.sendPasswordButton.Click += new System.EventHandler(this.SendPasswordButton_Click);
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 25;
			this.bunifuElipse1.TargetControl = this;
			// 
			// ForgetPasswordForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.ClientSize = new System.Drawing.Size(450, 200);
			this.Controls.Add(this.sendPasswordButton);
			this.Controls.Add(this.emailPanel);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.titlePanel);
			this.Name = "ForgetPasswordForm";
			this.Opacity = 0.9D;
			this.Text = "ForgetPasswordForm";
			this.titlePanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Mbb.Windows.Forms.Panel titlePanel;
		private Mbb.Windows.Forms.Button minimizeButton;
		private Mbb.Windows.Forms.Button closeButton;
		private Mbb.Windows.Forms.TextBox textBox1;
		private Mbb.Windows.Forms.Panel emailPanel;
		private Mbb.Windows.Forms.Button sendPasswordButton;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
	}
}