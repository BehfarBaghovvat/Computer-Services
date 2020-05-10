namespace ComputerServices.Menu.Service
{
	partial class OrderInformationForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderInformationForm));
			this.label1 = new Mbb.Windows.Forms.Label();
			this.titlePanel = new Mbb.Windows.Forms.Panel();
			this.label2 = new Mbb.Windows.Forms.Label();
			this.button1 = new Mbb.Windows.Forms.Button();
			this.titlePanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(437, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			// 
			// titlePanel
			// 
			this.titlePanel.Controls.Add(this.button1);
			this.titlePanel.Controls.Add(this.label2);
			this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.titlePanel.Location = new System.Drawing.Point(0, 0);
			this.titlePanel.Name = "titlePanel";
			this.titlePanel.Size = new System.Drawing.Size(546, 27);
			this.titlePanel.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Right;
			this.label2.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(462, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 27);
			this.label2.TabIndex = 1;
			this.label2.Text = "اطلاعات سفارش";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// button1
			// 
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(12, 7);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(13, 13);
			this.button1.TabIndex = 2;
			this.button1.UseVisualStyleBackColor = true;
			// 
			// OrderInformationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(123)))), ((int)(((byte)(225)))));
			this.ClientSize = new System.Drawing.Size(546, 377);
			this.Controls.Add(this.titlePanel);
			this.Controls.Add(this.label1);
			this.Name = "OrderInformationForm";
			this.Text = "OrderInformationForm";
			this.titlePanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Mbb.Windows.Forms.Label label1;
		private Mbb.Windows.Forms.Panel titlePanel;
		private Mbb.Windows.Forms.Button button1;
		private Mbb.Windows.Forms.Label label2;
	}
}