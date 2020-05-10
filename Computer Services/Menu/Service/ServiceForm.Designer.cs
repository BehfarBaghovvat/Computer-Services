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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceForm));
			this.computerServicePanel = new Mbb.Windows.Forms.Panel();
			this.registerServiceGroupBox = new Mbb.Windows.Forms.GroupBox();
			this.descriptionPanel = new Mbb.Windows.Forms.Panel();
			this.descriptionTextBox = new Mbb.Windows.Forms.TextBox();
			this.serviceTypeComboBox = new Mbb.Windows.Forms.ComboBox();
			this.invoiceSerialLabel = new Mbb.Windows.Forms.Label();
			this.dateLabel = new Mbb.Windows.Forms.Label();
			this.serviceTypePanel = new Mbb.Windows.Forms.Panel();
			this.invoiceSerialPanel = new Mbb.Windows.Forms.Panel();
			this.clientNameTextBox = new Mbb.Windows.Forms.TextBox();
			this.clientNamePanel = new Mbb.Windows.Forms.Panel();
			this.searchInvoiceSerialTextBox = new Mbb.Windows.Forms.TextBox();
			this.searchInvoiceSerialPanel = new Mbb.Windows.Forms.Panel();
			this.tltlepanel = new Mbb.Windows.Forms.Panel();
			this.computerServiceButton = new Mbb.Windows.Forms.Button();
			this.cellphoneServiceButton = new Mbb.Windows.Forms.Button();
			this.computerServiceDataGridView = new Mbb.Windows.Forms.DataGridView();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.picturBox1 = new Mbb.Windows.Forms.PicturBox();
			this.invoiceNumberDeletedButton = new Mbb.Windows.Forms.Button();
			this.confirmStatusPicturBox = new Mbb.Windows.Forms.PicturBox();
			this.invoicePrintButton = new Mbb.Windows.Forms.Button();
			this.saveOrderButton = new Mbb.Windows.Forms.Button();
			this.newCodeButton = new Mbb.Windows.Forms.Button();
			this.serviceComputerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Invoice_Serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.registerDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.requestStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.computerServicePanel.SuspendLayout();
			this.registerServiceGroupBox.SuspendLayout();
			this.tltlepanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.computerServiceDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picturBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.confirmStatusPicturBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.serviceComputerBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// computerServicePanel
			// 
			this.computerServicePanel.BackColor = System.Drawing.Color.Maroon;
			this.computerServicePanel.Controls.Add(this.computerServiceDataGridView);
			this.computerServicePanel.Controls.Add(this.picturBox1);
			this.computerServicePanel.Controls.Add(this.registerServiceGroupBox);
			this.computerServicePanel.Controls.Add(this.searchInvoiceSerialTextBox);
			this.computerServicePanel.Controls.Add(this.searchInvoiceSerialPanel);
			this.computerServicePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.computerServicePanel.Location = new System.Drawing.Point(0, 45);
			this.computerServicePanel.Name = "computerServicePanel";
			this.computerServicePanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.computerServicePanel.Size = new System.Drawing.Size(934, 455);
			this.computerServicePanel.TabIndex = 1;
			// 
			// registerServiceGroupBox
			// 
			this.registerServiceGroupBox.Controls.Add(this.invoiceNumberDeletedButton);
			this.registerServiceGroupBox.Controls.Add(this.confirmStatusPicturBox);
			this.registerServiceGroupBox.Controls.Add(this.invoicePrintButton);
			this.registerServiceGroupBox.Controls.Add(this.saveOrderButton);
			this.registerServiceGroupBox.Controls.Add(this.descriptionPanel);
			this.registerServiceGroupBox.Controls.Add(this.descriptionTextBox);
			this.registerServiceGroupBox.Controls.Add(this.serviceTypeComboBox);
			this.registerServiceGroupBox.Controls.Add(this.newCodeButton);
			this.registerServiceGroupBox.Controls.Add(this.invoiceSerialLabel);
			this.registerServiceGroupBox.Controls.Add(this.dateLabel);
			this.registerServiceGroupBox.Controls.Add(this.serviceTypePanel);
			this.registerServiceGroupBox.Controls.Add(this.invoiceSerialPanel);
			this.registerServiceGroupBox.Controls.Add(this.clientNameTextBox);
			this.registerServiceGroupBox.Controls.Add(this.clientNamePanel);
			this.registerServiceGroupBox.ForeColor = System.Drawing.Color.White;
			this.registerServiceGroupBox.Location = new System.Drawing.Point(566, 39);
			this.registerServiceGroupBox.Name = "registerServiceGroupBox";
			this.registerServiceGroupBox.Size = new System.Drawing.Size(321, 377);
			this.registerServiceGroupBox.TabIndex = 17;
			this.registerServiceGroupBox.TabStop = false;
			this.registerServiceGroupBox.Text = "ثبت درخواست خدمات";
			// 
			// descriptionPanel
			// 
			this.descriptionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.descriptionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.descriptionPanel.Location = new System.Drawing.Point(30, 316);
			this.descriptionPanel.Name = "descriptionPanel";
			this.descriptionPanel.Size = new System.Drawing.Size(257, 1);
			this.descriptionPanel.TabIndex = 30;
			// 
			// descriptionTextBox
			// 
			this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.descriptionTextBox.BackColor = System.Drawing.Color.Maroon;
			this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.descriptionTextBox.ForeColor = System.Drawing.Color.White;
			this.descriptionTextBox.Location = new System.Drawing.Point(30, 157);
			this.descriptionTextBox.MaxLength = 1000;
			this.descriptionTextBox.Multiline = true;
			this.descriptionTextBox.Name = "descriptionTextBox";
			this.descriptionTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.descriptionTextBox.Size = new System.Drawing.Size(257, 154);
			this.descriptionTextBox.TabIndex = 29;
			this.descriptionTextBox.Text = "توضیحات مشتری";
			this.descriptionTextBox.Enter += new System.EventHandler(this.DescriptionTextBox_Enter);
			this.descriptionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DescriptionTextBox_KeyPress);
			this.descriptionTextBox.Leave += new System.EventHandler(this.DescriptionTextBox_Leave);
			// 
			// serviceTypeComboBox
			// 
			this.serviceTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.serviceTypeComboBox.BackColor = System.Drawing.Color.Maroon;
			this.serviceTypeComboBox.DropDownHeight = 250;
			this.serviceTypeComboBox.DropDownWidth = 310;
			this.serviceTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.serviceTypeComboBox.ForeColor = System.Drawing.Color.DimGray;
			this.serviceTypeComboBox.FormattingEnabled = true;
			this.serviceTypeComboBox.IntegralHeight = false;
			this.serviceTypeComboBox.Items.AddRange(new object[] {
            "تعمیرات سخت افزار",
            "تعمیرات نرم افزار",
            "تهیه یک سیستم",
            "تهیه یک سیستم به همراه نصب ویندوز",
            "تهیه یک سیستم به همراه نصب ویندوز و سایر نرم افزارهای جانبی",
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
			this.serviceTypeComboBox.Text = "نوع خدمات را تعیین کنید...";
			this.serviceTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.ServiceTypeComboBox_SelectedIndexChanged);
			// 
			// invoiceSerialLabel
			// 
			this.invoiceSerialLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.invoiceSerialLabel.Location = new System.Drawing.Point(114, 57);
			this.invoiceSerialLabel.Name = "invoiceSerialLabel";
			this.invoiceSerialLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.invoiceSerialLabel.Size = new System.Drawing.Size(171, 17);
			this.invoiceSerialLabel.TabIndex = 26;
			this.invoiceSerialLabel.Text = "سریال فاکتور";
			this.invoiceSerialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.invoiceSerialLabel.TextChanged += new System.EventHandler(this.InvoiceNumberLabel_TextChanged);
			// 
			// dateLabel
			// 
			this.dateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dateLabel.Location = new System.Drawing.Point(8, 17);
			this.dateLabel.Name = "dateLabel";
			this.dateLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dateLabel.Size = new System.Drawing.Size(129, 17);
			this.dateLabel.TabIndex = 25;
			this.dateLabel.Text = "تاریخ ثبت";
			this.dateLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// serviceTypePanel
			// 
			this.serviceTypePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.serviceTypePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.serviceTypePanel.Location = new System.Drawing.Point(114, 150);
			this.serviceTypePanel.Name = "serviceTypePanel";
			this.serviceTypePanel.Size = new System.Drawing.Size(171, 1);
			this.serviceTypePanel.TabIndex = 24;
			// 
			// invoiceSerialPanel
			// 
			this.invoiceSerialPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.invoiceSerialPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.invoiceSerialPanel.Location = new System.Drawing.Point(114, 79);
			this.invoiceSerialPanel.Name = "invoiceSerialPanel";
			this.invoiceSerialPanel.Size = new System.Drawing.Size(171, 1);
			this.invoiceSerialPanel.TabIndex = 23;
			// 
			// clientNameTextBox
			// 
			this.clientNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.clientNameTextBox.BackColor = System.Drawing.Color.Maroon;
			this.clientNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.clientNameTextBox.ForeColor = System.Drawing.Color.White;
			this.clientNameTextBox.Location = new System.Drawing.Point(114, 89);
			this.clientNameTextBox.MaxLength = 45;
			this.clientNameTextBox.Name = "clientNameTextBox";
			this.clientNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.clientNameTextBox.Size = new System.Drawing.Size(171, 17);
			this.clientNameTextBox.TabIndex = 22;
			this.clientNameTextBox.Text = "نام مشتری";
			this.clientNameTextBox.Enter += new System.EventHandler(this.ClientNameTextBox_Enter);
			this.clientNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClientNameTextBox_KeyPress);
			this.clientNameTextBox.Leave += new System.EventHandler(this.ClientNameTextBox_Leave);
			// 
			// clientNamePanel
			// 
			this.clientNamePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.clientNamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.clientNamePanel.Location = new System.Drawing.Point(114, 112);
			this.clientNamePanel.Name = "clientNamePanel";
			this.clientNamePanel.Size = new System.Drawing.Size(171, 1);
			this.clientNamePanel.TabIndex = 21;
			// 
			// searchInvoiceSerialTextBox
			// 
			this.searchInvoiceSerialTextBox.BackColor = System.Drawing.Color.Maroon;
			this.searchInvoiceSerialTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.searchInvoiceSerialTextBox.ForeColor = System.Drawing.Color.White;
			this.searchInvoiceSerialTextBox.Location = new System.Drawing.Point(31, 39);
			this.searchInvoiceSerialTextBox.MaxLength = 24;
			this.searchInvoiceSerialTextBox.Name = "searchInvoiceSerialTextBox";
			this.searchInvoiceSerialTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.searchInvoiceSerialTextBox.Size = new System.Drawing.Size(513, 17);
			this.searchInvoiceSerialTextBox.TabIndex = 16;
			this.searchInvoiceSerialTextBox.Text = "سریال فاکتور را وارد نمایید...";
			this.searchInvoiceSerialTextBox.TextChanged += new System.EventHandler(this.SearchInvoiceSerialTextBox_TextChanged);
			this.searchInvoiceSerialTextBox.Enter += new System.EventHandler(this.SearchInvoiceSerialTextBox_Enter);
			this.searchInvoiceSerialTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchInvoiceSerialTextBox_KeyPress);
			this.searchInvoiceSerialTextBox.Leave += new System.EventHandler(this.SearchInvoiceSerialTextBox_Leave);
			// 
			// searchInvoiceSerialPanel
			// 
			this.searchInvoiceSerialPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.searchInvoiceSerialPanel.Location = new System.Drawing.Point(31, 62);
			this.searchInvoiceSerialPanel.Name = "searchInvoiceSerialPanel";
			this.searchInvoiceSerialPanel.Size = new System.Drawing.Size(513, 1);
			this.searchInvoiceSerialPanel.TabIndex = 15;
			// 
			// tltlepanel
			// 
			this.tltlepanel.Controls.Add(this.computerServiceButton);
			this.tltlepanel.Controls.Add(this.cellphoneServiceButton);
			this.tltlepanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.tltlepanel.Location = new System.Drawing.Point(0, 0);
			this.tltlepanel.Name = "tltlepanel";
			this.tltlepanel.Size = new System.Drawing.Size(934, 45);
			this.tltlepanel.TabIndex = 0;
			// 
			// computerServiceButton
			// 
			this.computerServiceButton.BackColor = System.Drawing.Color.RoyalBlue;
			this.computerServiceButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.computerServiceButton.FlatAppearance.BorderSize = 0;
			this.computerServiceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.computerServiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.computerServiceButton.Font = new System.Drawing.Font("B Yekan", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(150)));
			this.computerServiceButton.Location = new System.Drawing.Point(467, 0);
			this.computerServiceButton.Name = "computerServiceButton";
			this.computerServiceButton.Size = new System.Drawing.Size(467, 45);
			this.computerServiceButton.TabIndex = 1;
			this.computerServiceButton.Text = "خدمات کامپیوتر";
			this.computerServiceButton.UseVisualStyleBackColor = true;
			// 
			// cellphoneServiceButton
			// 
			this.cellphoneServiceButton.BackColor = System.Drawing.Color.RoyalBlue;
			this.cellphoneServiceButton.Dock = System.Windows.Forms.DockStyle.Left;
			this.cellphoneServiceButton.FlatAppearance.BorderSize = 0;
			this.cellphoneServiceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.cellphoneServiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cellphoneServiceButton.Font = new System.Drawing.Font("B Yekan", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(150)));
			this.cellphoneServiceButton.Location = new System.Drawing.Point(0, 0);
			this.cellphoneServiceButton.Name = "cellphoneServiceButton";
			this.cellphoneServiceButton.Size = new System.Drawing.Size(467, 45);
			this.cellphoneServiceButton.TabIndex = 0;
			this.cellphoneServiceButton.Text = "خدمات موبایل";
			this.cellphoneServiceButton.UseVisualStyleBackColor = false;
			// 
			// computerServiceDataGridView
			// 
			this.computerServiceDataGridView.AllowUserToAddRows = false;
			this.computerServiceDataGridView.AllowUserToDeleteRows = false;
			this.computerServiceDataGridView.AllowUserToResizeColumns = false;
			this.computerServiceDataGridView.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lime;
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			this.computerServiceDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.computerServiceDataGridView.AutoGenerateColumns = false;
			this.computerServiceDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.computerServiceDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.computerServiceDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.computerServiceDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.computerServiceDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.computerServiceDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.computerServiceDataGridView.ColumnHeadersHeight = 35;
			this.computerServiceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientNameDataGridViewTextBoxColumn,
            this.Invoice_Serial,
            this.registerDateDataGridViewTextBoxColumn,
            this.requestStatusDataGridViewTextBoxColumn});
			this.computerServiceDataGridView.DataSource = this.serviceComputerBindingSource;
			this.computerServiceDataGridView.EnableHeadersVisualStyles = false;
			this.computerServiceDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.computerServiceDataGridView.Location = new System.Drawing.Point(31, 69);
			this.computerServiceDataGridView.Name = "computerServiceDataGridView";
			this.computerServiceDataGridView.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.computerServiceDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.computerServiceDataGridView.RowHeadersVisible = false;
			this.computerServiceDataGridView.RowHeadersWidth = 30;
			this.computerServiceDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.RoyalBlue;
			this.computerServiceDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.computerServiceDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.computerServiceDataGridView.Size = new System.Drawing.Size(513, 347);
			this.computerServiceDataGridView.TabIndex = 19;
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 25;
			this.bunifuElipse1.TargetControl = this.computerServiceDataGridView;
			// 
			// picturBox1
			// 
			this.picturBox1.BackColor = System.Drawing.Color.Transparent;
			this.picturBox1.Image = ((System.Drawing.Image)(resources.GetObject("picturBox1.Image")));
			this.picturBox1.Location = new System.Drawing.Point(31, 39);
			this.picturBox1.Name = "picturBox1";
			this.picturBox1.Size = new System.Drawing.Size(17, 17);
			this.picturBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picturBox1.TabIndex = 18;
			this.picturBox1.TabStop = false;
			// 
			// invoiceNumberDeletedButton
			// 
			this.invoiceNumberDeletedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.invoiceNumberDeletedButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.invoiceNumberDeletedButton.FlatAppearance.BorderSize = 0;
			this.invoiceNumberDeletedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.invoiceNumberDeletedButton.Image = ((System.Drawing.Image)(resources.GetObject("invoiceNumberDeletedButton.Image")));
			this.invoiceNumberDeletedButton.Location = new System.Drawing.Point(56, 53);
			this.invoiceNumberDeletedButton.Name = "invoiceNumberDeletedButton";
			this.invoiceNumberDeletedButton.Size = new System.Drawing.Size(25, 25);
			this.invoiceNumberDeletedButton.TabIndex = 34;
			this.invoiceNumberDeletedButton.UseVisualStyleBackColor = true;
			this.invoiceNumberDeletedButton.Visible = false;
			this.invoiceNumberDeletedButton.Click += new System.EventHandler(this.InvoiceNumberDeletedButton_Click);
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
			this.invoicePrintButton.Enabled = false;
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
			this.invoicePrintButton.Click += new System.EventHandler(this.InvoicePrintButton_Click);
			// 
			// saveOrderButton
			// 
			this.saveOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.saveOrderButton.BackColor = System.Drawing.Color.SteelBlue;
			this.saveOrderButton.Enabled = false;
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
			this.saveOrderButton.Click += new System.EventHandler(this.SaveOrderButton_Click);
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
			// serviceComputerBindingSource
			// 
			this.serviceComputerBindingSource.DataSource = typeof(Models.ServiceComputer);
			// 
			// clientNameDataGridViewTextBoxColumn
			// 
			this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "Client_Name";
			this.clientNameDataGridViewTextBoxColumn.HeaderText = "نام مشتری";
			this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
			this.clientNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// Invoice_Serial
			// 
			this.Invoice_Serial.DataPropertyName = "Invoice_Serial";
			this.Invoice_Serial.HeaderText = "سریال فاکتور";
			this.Invoice_Serial.Name = "Invoice_Serial";
			this.Invoice_Serial.ReadOnly = true;
			// 
			// registerDateDataGridViewTextBoxColumn
			// 
			this.registerDateDataGridViewTextBoxColumn.DataPropertyName = "Register_Date";
			this.registerDateDataGridViewTextBoxColumn.HeaderText = "تاریخ ثبت";
			this.registerDateDataGridViewTextBoxColumn.Name = "registerDateDataGridViewTextBoxColumn";
			this.registerDateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// requestStatusDataGridViewTextBoxColumn
			// 
			this.requestStatusDataGridViewTextBoxColumn.DataPropertyName = "Request_Status";
			this.requestStatusDataGridViewTextBoxColumn.HeaderText = "وضعیت سفارش";
			this.requestStatusDataGridViewTextBoxColumn.MaxInputLength = 15;
			this.requestStatusDataGridViewTextBoxColumn.Name = "requestStatusDataGridViewTextBoxColumn";
			this.requestStatusDataGridViewTextBoxColumn.ReadOnly = true;
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
			this.Load += new System.EventHandler(this.ServiceForm_Load);
			this.computerServicePanel.ResumeLayout(false);
			this.computerServicePanel.PerformLayout();
			this.registerServiceGroupBox.ResumeLayout(false);
			this.registerServiceGroupBox.PerformLayout();
			this.tltlepanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.computerServiceDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picturBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.confirmStatusPicturBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.serviceComputerBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Mbb.Windows.Forms.Panel tltlepanel;
		private Mbb.Windows.Forms.Button computerServiceButton;
		private Mbb.Windows.Forms.Button cellphoneServiceButton;
		private Mbb.Windows.Forms.Panel computerServicePanel;
		private Mbb.Windows.Forms.TextBox searchInvoiceSerialTextBox;
		private Mbb.Windows.Forms.Panel searchInvoiceSerialPanel;
		private Mbb.Windows.Forms.GroupBox registerServiceGroupBox;
		private Mbb.Windows.Forms.PicturBox confirmStatusPicturBox;
		private Mbb.Windows.Forms.Button invoicePrintButton;
		private Mbb.Windows.Forms.Button saveOrderButton;
		private Mbb.Windows.Forms.Panel descriptionPanel;
		private Mbb.Windows.Forms.TextBox descriptionTextBox;
		private Mbb.Windows.Forms.ComboBox serviceTypeComboBox;
		private Mbb.Windows.Forms.Button newCodeButton;
		private Mbb.Windows.Forms.Label invoiceSerialLabel;
		private Mbb.Windows.Forms.Label dateLabel;
		private Mbb.Windows.Forms.Panel serviceTypePanel;
		private Mbb.Windows.Forms.Panel invoiceSerialPanel;
		private Mbb.Windows.Forms.TextBox clientNameTextBox;
		private Mbb.Windows.Forms.Panel clientNamePanel;
		private Mbb.Windows.Forms.Button invoiceNumberDeletedButton;
		private System.Windows.Forms.BindingSource serviceComputerBindingSource;
		private Mbb.Windows.Forms.PicturBox picturBox1;
		private Mbb.Windows.Forms.DataGridView computerServiceDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNumberDataGridViewTextBoxColumn;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn Invoice_Serial;
		private System.Windows.Forms.DataGridViewTextBoxColumn registerDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn requestStatusDataGridViewTextBoxColumn;
	}
}