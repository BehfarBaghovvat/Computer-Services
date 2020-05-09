namespace ComputerServices.Menu.Service
{
	partial class ServiceForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceForm));
			this.computerServicePanel = new Mbb.Windows.Forms.Panel();
			this.groupBox1 = new Mbb.Windows.Forms.GroupBox();
			this.groupBox2 = new Mbb.Windows.Forms.GroupBox();
			this.FollowUpRadioButton = new Mbb.Windows.Forms.RadioButton();
			this.radioButton2 = new Mbb.Windows.Forms.RadioButton();
			this.confirmStatusPicturBox = new Mbb.Windows.Forms.PicturBox();
			this.invoicePrintButton = new Mbb.Windows.Forms.Button();
			this.saveOrderButton = new Mbb.Windows.Forms.Button();
			this.panel2 = new Mbb.Windows.Forms.Panel();
			this.textBox1 = new Mbb.Windows.Forms.TextBox();
			this.serviceTypeComboBox = new Mbb.Windows.Forms.ComboBox();
			this.newCodeButton = new Mbb.Windows.Forms.Button();
			this.invoiceNumberLabel = new Mbb.Windows.Forms.Label();
			this.dateLabel = new Mbb.Windows.Forms.Label();
			this.panel3 = new Mbb.Windows.Forms.Panel();
			this.invoiceNumberPanel = new Mbb.Windows.Forms.Panel();
			this.clientNameTextBox = new Mbb.Windows.Forms.TextBox();
			this.panel1 = new Mbb.Windows.Forms.Panel();
			this.textBox2 = new Mbb.Windows.Forms.TextBox();
			this.panel4 = new Mbb.Windows.Forms.Panel();
			this.dataGridView1 = new Mbb.Windows.Forms.DataGridView();
			this.tltlepanel = new Mbb.Windows.Forms.Panel();
			this.button2 = new Mbb.Windows.Forms.Button();
			this.button1 = new Mbb.Windows.Forms.Button();
			this.computerServicePanel.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.confirmStatusPicturBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.tltlepanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// computerServicePanel
			// 
			this.computerServicePanel.BackColor = System.Drawing.Color.Maroon;
			this.computerServicePanel.Controls.Add(this.groupBox1);
			this.computerServicePanel.Controls.Add(this.textBox2);
			this.computerServicePanel.Controls.Add(this.panel4);
			this.computerServicePanel.Controls.Add(this.dataGridView1);
			this.computerServicePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.computerServicePanel.Location = new System.Drawing.Point(0, 45);
			this.computerServicePanel.Name = "computerServicePanel";
			this.computerServicePanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.computerServicePanel.Size = new System.Drawing.Size(934, 455);
			this.computerServicePanel.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.confirmStatusPicturBox);
			this.groupBox1.Controls.Add(this.invoicePrintButton);
			this.groupBox1.Controls.Add(this.saveOrderButton);
			this.groupBox1.Controls.Add(this.panel2);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.serviceTypeComboBox);
			this.groupBox1.Controls.Add(this.newCodeButton);
			this.groupBox1.Controls.Add(this.invoiceNumberLabel);
			this.groupBox1.Controls.Add(this.dateLabel);
			this.groupBox1.Controls.Add(this.panel3);
			this.groupBox1.Controls.Add(this.invoiceNumberPanel);
			this.groupBox1.Controls.Add(this.clientNameTextBox);
			this.groupBox1.Controls.Add(this.panel1);
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(531, 39);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(321, 377);
			this.groupBox1.TabIndex = 17;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "ثبت درخواست خدمات";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.FollowUpRadioButton);
			this.groupBox2.Controls.Add(this.radioButton2);
			this.groupBox2.ForeColor = System.Drawing.Color.White;
			this.groupBox2.Location = new System.Drawing.Point(28, 258);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(261, 60);
			this.groupBox2.TabIndex = 34;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "وضعیت سفارش";
			// 
			// FollowUpRadioButton
			// 
			this.FollowUpRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.FollowUpRadioButton.AutoSize = true;
			this.FollowUpRadioButton.Checked = true;
			this.FollowUpRadioButton.FlatAppearance.BorderSize = 0;
			this.FollowUpRadioButton.Location = new System.Drawing.Point(120, 24);
			this.FollowUpRadioButton.Name = "FollowUpRadioButton";
			this.FollowUpRadioButton.Size = new System.Drawing.Size(90, 21);
			this.FollowUpRadioButton.TabIndex = 18;
			this.FollowUpRadioButton.TabStop = true;
			this.FollowUpRadioButton.Text = "در حال پیگیری";
			this.FollowUpRadioButton.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.radioButton2.AutoSize = true;
			this.radioButton2.FlatAppearance.BorderSize = 0;
			this.radioButton2.Location = new System.Drawing.Point(42, 24);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(66, 21);
			this.radioButton2.TabIndex = 19;
			this.radioButton2.Text = "انجام شد";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// confirmStatusPicturBox
			// 
			this.confirmStatusPicturBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.confirmStatusPicturBox.Image = global::ComputerServices.Properties.Resources.Tik_True;
			this.confirmStatusPicturBox.Location = new System.Drawing.Point(294, 54);
			this.confirmStatusPicturBox.Name = "confirmStatusPicturBox";
			this.confirmStatusPicturBox.Size = new System.Drawing.Size(21, 22);
			this.confirmStatusPicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.confirmStatusPicturBox.TabIndex = 33;
			this.confirmStatusPicturBox.TabStop = false;
			this.confirmStatusPicturBox.Visible = false;
			// 
			// invoicePrintButton
			// 
			this.invoicePrintButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.invoicePrintButton.BackColor = System.Drawing.Color.SteelBlue;
			this.invoicePrintButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.invoicePrintButton.FlatAppearance.BorderSize = 0;
			this.invoicePrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.invoicePrintButton.Image = ((System.Drawing.Image)(resources.GetObject("invoicePrintButton.Image")));
			this.invoicePrintButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.invoicePrintButton.Location = new System.Drawing.Point(28, 323);
			this.invoicePrintButton.Name = "invoicePrintButton";
			this.invoicePrintButton.Size = new System.Drawing.Size(124, 30);
			this.invoicePrintButton.TabIndex = 32;
			this.invoicePrintButton.Text = "چاپ فاکتور";
			this.invoicePrintButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.invoicePrintButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.invoicePrintButton.UseVisualStyleBackColor = false;
			this.invoicePrintButton.Click += new System.EventHandler(this.invoicePrintButton_Click);
			// 
			// saveOrderButton
			// 
			this.saveOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.saveOrderButton.BackColor = System.Drawing.Color.SteelBlue;
			this.saveOrderButton.FlatAppearance.BorderSize = 0;
			this.saveOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.saveOrderButton.Image = ((System.Drawing.Image)(resources.GetObject("saveOrderButton.Image")));
			this.saveOrderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.saveOrderButton.Location = new System.Drawing.Point(165, 323);
			this.saveOrderButton.Name = "saveOrderButton";
			this.saveOrderButton.Size = new System.Drawing.Size(124, 31);
			this.saveOrderButton.TabIndex = 31;
			this.saveOrderButton.Text = "ثبت درخواست";
			this.saveOrderButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.saveOrderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.saveOrderButton.UseVisualStyleBackColor = false;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.panel2.Location = new System.Drawing.Point(28, 251);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(257, 1);
			this.panel2.TabIndex = 30;
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.BackColor = System.Drawing.Color.Maroon;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.ForeColor = System.Drawing.Color.White;
			this.textBox1.Location = new System.Drawing.Point(28, 157);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.Size = new System.Drawing.Size(257, 89);
			this.textBox1.TabIndex = 29;
			this.textBox1.Text = "توضیحات مشتری";
			// 
			// serviceTypeComboBox
			// 
			this.serviceTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.serviceTypeComboBox.BackColor = System.Drawing.Color.Maroon;
			this.serviceTypeComboBox.DropDownHeight = 250;
			this.serviceTypeComboBox.DropDownWidth = 310;
			this.serviceTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.serviceTypeComboBox.ForeColor = System.Drawing.Color.White;
			this.serviceTypeComboBox.FormattingEnabled = true;
			this.serviceTypeComboBox.IntegralHeight = false;
			this.serviceTypeComboBox.Items.AddRange(new object[] {
            "تعمیرات سخت افزار",
            "تعمیرات نرم افزار",
            "تهیه یک سیستم",
            "تهیه یک سیستم به همراه نصب ویندوز",
            "تهیه یک سیستم به همراه نصب ویندوز و سایر نرم افزارهای جانبی",
            "سرویس در خواستی...",
            "سرویس سیستم (تمیزکاری سیستم)",
            "نصب سخت افزار",
            "نصب نرم افزار",
            "نصب ویندوز",
            "نصب ویندوز و نرم افزار های جانبی"});
			this.serviceTypeComboBox.Location = new System.Drawing.Point(114, 121);
			this.serviceTypeComboBox.Name = "serviceTypeComboBox";
			this.serviceTypeComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.serviceTypeComboBox.Size = new System.Drawing.Size(172, 25);
			this.serviceTypeComboBox.Sorted = true;
			this.serviceTypeComboBox.TabIndex = 28;
			// 
			// newCodeButton
			// 
			this.newCodeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.newCodeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newCodeButton.BackgroundImage")));
			this.newCodeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.newCodeButton.FlatAppearance.BorderSize = 0;
			this.newCodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.newCodeButton.Location = new System.Drawing.Point(87, 54);
			this.newCodeButton.Name = "newCodeButton";
			this.newCodeButton.Size = new System.Drawing.Size(21, 22);
			this.newCodeButton.TabIndex = 27;
			this.newCodeButton.UseVisualStyleBackColor = true;
			this.newCodeButton.Click += new System.EventHandler(this.NewCodeButton_Click);
			// 
			// invoiceNumberLabel
			// 
			this.invoiceNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.invoiceNumberLabel.Location = new System.Drawing.Point(117, 54);
			this.invoiceNumberLabel.Name = "invoiceNumberLabel";
			this.invoiceNumberLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.invoiceNumberLabel.Size = new System.Drawing.Size(171, 22);
			this.invoiceNumberLabel.TabIndex = 26;
			this.invoiceNumberLabel.Text = "شماره فاکتور";
			this.invoiceNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dateLabel
			// 
			this.dateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dateLabel.Location = new System.Drawing.Point(161, 25);
			this.dateLabel.Name = "dateLabel";
			this.dateLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dateLabel.Size = new System.Drawing.Size(129, 17);
			this.dateLabel.TabIndex = 25;
			this.dateLabel.Text = "تاریخ ثبت";
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.panel3.Location = new System.Drawing.Point(114, 150);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(171, 1);
			this.panel3.TabIndex = 24;
			// 
			// invoiceNumberPanel
			// 
			this.invoiceNumberPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.invoiceNumberPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.invoiceNumberPanel.Location = new System.Drawing.Point(114, 79);
			this.invoiceNumberPanel.Name = "invoiceNumberPanel";
			this.invoiceNumberPanel.Size = new System.Drawing.Size(171, 1);
			this.invoiceNumberPanel.TabIndex = 23;
			// 
			// clientNameTextBox
			// 
			this.clientNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.clientNameTextBox.BackColor = System.Drawing.Color.Maroon;
			this.clientNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.clientNameTextBox.ForeColor = System.Drawing.Color.White;
			this.clientNameTextBox.Location = new System.Drawing.Point(114, 89);
			this.clientNameTextBox.Name = "clientNameTextBox";
			this.clientNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.clientNameTextBox.Size = new System.Drawing.Size(171, 17);
			this.clientNameTextBox.TabIndex = 22;
			this.clientNameTextBox.Text = "نام مشتری";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.panel1.Location = new System.Drawing.Point(114, 112);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(171, 1);
			this.panel1.TabIndex = 21;
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.Color.Maroon;
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox2.ForeColor = System.Drawing.Color.White;
			this.textBox2.Location = new System.Drawing.Point(100, 39);
			this.textBox2.Name = "textBox2";
			this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.textBox2.Size = new System.Drawing.Size(340, 17);
			this.textBox2.TabIndex = 16;
			this.textBox2.Text = "جستجوی شماره فاکتور";
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.panel4.Location = new System.Drawing.Point(100, 62);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(340, 1);
			this.panel4.TabIndex = 15;
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.Color.Maroon;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.GridColor = System.Drawing.Color.DarkRed;
			this.dataGridView1.Location = new System.Drawing.Point(100, 68);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(340, 348);
			this.dataGridView1.TabIndex = 14;
			// 
			// tltlepanel
			// 
			this.tltlepanel.Controls.Add(this.button2);
			this.tltlepanel.Controls.Add(this.button1);
			this.tltlepanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.tltlepanel.Location = new System.Drawing.Point(0, 0);
			this.tltlepanel.Name = "tltlepanel";
			this.tltlepanel.Size = new System.Drawing.Size(934, 45);
			this.tltlepanel.TabIndex = 0;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.RoyalBlue;
			this.button2.Dock = System.Windows.Forms.DockStyle.Right;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("B Yekan", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(150)));
			this.button2.Location = new System.Drawing.Point(467, 0);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(467, 45);
			this.button2.TabIndex = 1;
			this.button2.Text = "خدمات کامپیوتر";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.RoyalBlue;
			this.button1.Dock = System.Windows.Forms.DockStyle.Left;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("B Yekan", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(150)));
			this.button1.Location = new System.Drawing.Point(0, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(467, 45);
			this.button1.TabIndex = 0;
			this.button1.Text = "خدمات موبایل";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// ServiceForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Maroon;
			this.ClientSize = new System.Drawing.Size(934, 500);
			this.Controls.Add(this.computerServicePanel);
			this.Controls.Add(this.tltlepanel);
			this.ForeColor = System.Drawing.Color.White;
			this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.Name = "ServiceForm";
			this.Text = "ServiceForm";
			this.computerServicePanel.ResumeLayout(false);
			this.computerServicePanel.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.confirmStatusPicturBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.tltlepanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Mbb.Windows.Forms.Panel tltlepanel;
		private Mbb.Windows.Forms.Button button2;
		private Mbb.Windows.Forms.Button button1;
		private Mbb.Windows.Forms.Panel computerServicePanel;
		private Mbb.Windows.Forms.TextBox textBox2;
		private Mbb.Windows.Forms.Panel panel4;
		private Mbb.Windows.Forms.DataGridView dataGridView1;
		private Mbb.Windows.Forms.GroupBox groupBox1;
		private Mbb.Windows.Forms.GroupBox groupBox2;
		private Mbb.Windows.Forms.RadioButton FollowUpRadioButton;
		private Mbb.Windows.Forms.RadioButton radioButton2;
		private Mbb.Windows.Forms.PicturBox confirmStatusPicturBox;
		private Mbb.Windows.Forms.Button invoicePrintButton;
		private Mbb.Windows.Forms.Button saveOrderButton;
		private Mbb.Windows.Forms.Panel panel2;
		private Mbb.Windows.Forms.TextBox textBox1;
		private Mbb.Windows.Forms.ComboBox serviceTypeComboBox;
		private Mbb.Windows.Forms.Button newCodeButton;
		private Mbb.Windows.Forms.Label invoiceNumberLabel;
		private Mbb.Windows.Forms.Label dateLabel;
		private Mbb.Windows.Forms.Panel panel3;
		private Mbb.Windows.Forms.Panel invoiceNumberPanel;
		private Mbb.Windows.Forms.TextBox clientNameTextBox;
		private Mbb.Windows.Forms.Panel panel1;
	}
}