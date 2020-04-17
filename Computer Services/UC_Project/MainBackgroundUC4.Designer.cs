namespace ComputerServices.UC_Project
{
	partial class MainBackgroundUC4
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainBackgroundUC4));
			this.label1 = new Mbb.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("IRANSans", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label1.ForeColor = System.Drawing.Color.SlateBlue;
			this.label1.Location = new System.Drawing.Point(188, 218);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(375, 114);
			this.label1.TabIndex = 0;
			this.label1.Text = "خوش آمدید";
			// 
			// MainBackgroundUC4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Controls.Add(this.label1);
			this.DoubleBuffered = true;
			this.Name = "MainBackgroundUC4";
			this.Size = new System.Drawing.Size(750, 550);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Mbb.Windows.Forms.Label label1;
	}
}
