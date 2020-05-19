namespace ComputerServices.Menu.Service
{
	partial class ComputerAssembelForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComputerAssembelForm));
			this.panel1 = new Mbb.Windows.Forms.Panel();
			this.minimizeButton = new Mbb.Windows.Forms.Button();
			this.closeButton = new Mbb.Windows.Forms.Button();
			this.maximizeButton = new Mbb.Windows.Forms.Button();
			this.restoreButton = new Mbb.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.minimizeButton);
			this.panel1.Controls.Add(this.closeButton);
			this.panel1.Controls.Add(this.maximizeButton);
			this.panel1.Controls.Add(this.restoreButton);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 25);
			this.panel1.TabIndex = 0;
			// 
			// minimizeButton
			// 
			this.minimizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizeButton.BackgroundImage")));
			this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.minimizeButton.FlatAppearance.BorderSize = 0;
			this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.minimizeButton.Location = new System.Drawing.Point(54, 5);
			this.minimizeButton.Name = "minimizeButton";
			this.minimizeButton.Size = new System.Drawing.Size(15, 15);
			this.minimizeButton.TabIndex = 11;
			this.minimizeButton.UseVisualStyleBackColor = true;
			// 
			// closeButton
			// 
			this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
			this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.closeButton.FlatAppearance.BorderSize = 0;
			this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
			this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeButton.Location = new System.Drawing.Point(12, 5);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(15, 15);
			this.closeButton.TabIndex = 10;
			this.closeButton.UseVisualStyleBackColor = true;
			// 
			// maximizeButton
			// 
			this.maximizeButton.BackgroundImage = global::ComputerServices.Properties.Resources.maximize_button_512;
			this.maximizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.maximizeButton.FlatAppearance.BorderSize = 0;
			this.maximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.maximizeButton.Location = new System.Drawing.Point(33, 5);
			this.maximizeButton.Name = "maximizeButton";
			this.maximizeButton.Size = new System.Drawing.Size(15, 15);
			this.maximizeButton.TabIndex = 12;
			this.maximizeButton.UseVisualStyleBackColor = true;
			// 
			// restoreButton
			// 
			this.restoreButton.BackgroundImage = global::ComputerServices.Properties.Resources.restore_down_512;
			this.restoreButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.restoreButton.FlatAppearance.BorderSize = 0;
			this.restoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.restoreButton.Location = new System.Drawing.Point(33, 5);
			this.restoreButton.Name = "restoreButton";
			this.restoreButton.Size = new System.Drawing.Size(15, 15);
			this.restoreButton.TabIndex = 13;
			this.restoreButton.UseVisualStyleBackColor = true;
			// 
			// ComputerAssembelForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel1);
			this.Name = "ComputerAssembelForm";
			this.Text = "ComputerAssembelForm";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Mbb.Windows.Forms.Panel panel1;
		private Mbb.Windows.Forms.Button minimizeButton;
		private Mbb.Windows.Forms.Button closeButton;
		private Mbb.Windows.Forms.Button maximizeButton;
		private Mbb.Windows.Forms.Button restoreButton;
	}
}