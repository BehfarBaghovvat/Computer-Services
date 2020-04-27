namespace ComputerServices
{
	partial class TestForm
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
			this.label4 = new Mbb.Windows.Forms.Label();
			this.messageLabel = new Mbb.Windows.Forms.Label();
			this.button1 = new Mbb.Windows.Forms.Button();
			this.label3 = new Mbb.Windows.Forms.Label();
			this.comboBox1 = new Mbb.Windows.Forms.ComboBox();
			this.label2 = new Mbb.Windows.Forms.Label();
			this.textBox2 = new Mbb.Windows.Forms.TextBox();
			this.label1 = new Mbb.Windows.Forms.Label();
			this.textBox1 = new Mbb.Windows.Forms.TextBox();
			this.label5 = new Mbb.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoEllipsis = true;
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(567, 347);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(16, 19);
			this.label4.TabIndex = 8;
			this.label4.Text = "0";
			// 
			// messageLabel
			// 
			this.messageLabel.AutoEllipsis = true;
			this.messageLabel.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.messageLabel.ForeColor = System.Drawing.Color.White;
			this.messageLabel.Location = new System.Drawing.Point(609, 38);
			this.messageLabel.Name = "messageLabel";
			this.messageLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.messageLabel.Size = new System.Drawing.Size(179, 253);
			this.messageLabel.TabIndex = 7;
			this.messageLabel.Text = "پیام";
			this.messageLabel.TextChanged += new System.EventHandler(this.messageLabel_TextChanged);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Orange;
			this.button1.Location = new System.Drawing.Point(334, 347);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(181, 46);
			this.button1.TabIndex = 6;
			this.button1.Text = "نمایش پیام";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(457, 242);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 19);
			this.label3.TabIndex = 5;
			this.label3.Text = "انتخاب فرم";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Information",
            "Question",
            "None",
            "Warning",
            "Stop"});
			this.comboBox1.Location = new System.Drawing.Point(348, 264);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(167, 27);
			this.comboBox1.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(461, 165);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 19);
			this.label2.TabIndex = 3;
			this.label2.Text = "متن عنوان";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(291, 187);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(224, 26);
			this.textBox2.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(468, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "متن پیام";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(64, 35);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(451, 127);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoEllipsis = true;
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(567, 391);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(16, 19);
			this.label5.TabIndex = 9;
			this.label5.Text = "0";
			// 
			// TestForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.messageLabel);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "TestForm";
			this.Text = "TestForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Mbb.Windows.Forms.TextBox textBox1;
		private Mbb.Windows.Forms.Label label1;
		private Mbb.Windows.Forms.Label label2;
		private Mbb.Windows.Forms.TextBox textBox2;
		private Mbb.Windows.Forms.ComboBox comboBox1;
		private Mbb.Windows.Forms.Label label3;
		private Mbb.Windows.Forms.Button button1;
		private Mbb.Windows.Forms.Label messageLabel;
		private Mbb.Windows.Forms.Label label4;
		private Mbb.Windows.Forms.Label label5;
	}
}