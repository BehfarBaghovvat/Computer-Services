using System.Reflection.Emit;

namespace ComputerServices.Menu.Service
{
	public partial class ComputerAssembelForm : Infrastructure.BaseForm
	{
		public ComputerAssembelForm()
		{
			InitializeComponent();
		}

		#region Properties
		public string Price { get; set; }

		public string Process { get; set; }
		public int Number_Processor { get; set; }
		public int UnitPrice_Processor { get; set; }
		public int TotalPrice_Processor { get; set; }

		public string RAM { get; set; }
		public int Number_RAM { get; set; }
		public int UnitPrice_RAM { get; set; }
		public int TotalPrice_RAM { get; set; }

		public string HDD { get; set; }
		public int Number_HDD { get; set; }
		public int UnitPrice_HDD { get; set; }
		public int TotalPrice_HDD { get; set; }

		public string DVDROM { get; set; }
		public int Number_DVDROM { get; set; }
		public int UnitPrice_DVDROM { get; set; }
		public int TotalPrice_DVDROM { get; set; }

		public string GraphicCard { get; set; }
		public int Number_GraphicCard { get; set; }
		public int UnitPrice_GraphicCard { get; set; }
		public int TotalPrice_GraphicCard { get; set; }

		public string Keyboard { get; set; }
		public int Number_Keyboard { get; set; }
		public int UnitPrice_Keyboard { get; set; }
		public int TotalPrice_Keyboard { get; set; }

		public string Mouse { get; set; }
		public int Number_Mouse { get; set; }
		public int UnitPrice_Mouse { get; set; }
		public int TotalPrice_Mouse { get; set; }

		public string Speaker { get; set; }
		public int Number_Speaker { get; set; }
		public int UnitPrice_Speakerr { get; set; }
		public int TotalPrice_Speaker { get; set; }

		public string Monitor { get; set; }
		public int Number_Monitor { get; set; }
		public int UnitPrice_Monitor { get; set; }
		public int TotlaPrice_Monitor { get; set; }

		public string OtherDevice1 { get; set; }
		public int Number_OtherDevice1 { get; set; }
		public int UnitPrice_OtherDevice1 { get; set; }
		public int TotalPrice_OtherDevice1 { get; set; }

		public string OtherDevice2 { get; set; }
		public int Number_OtherDevice2 { get; set; }
		public int UnitPrice_OtherDevice2 { get; set; }
		public int TotalPrice_OtherDevice2 { get; set; }

		public string OtherDevice3 { get; set; }
		public int Number_OtherDevice3 { get; set; }
		public string UnitPrice_OtherDevice3 { get; set; }
		public string TotalPrice_OtherDevice3 { get; set; }

		public string OtherDevice4 { get; set; }
		public int Number_OtherDevice4 { get; set; }
		public string UnitPrice_OtherDevice4 { get; set; }
		public string TotalPrice_OtherDevice4 { get; set; }

		public string OtherDevice5 { get; set; }
		public int Number_OtherDevice5 { get; set; }
		public string UnitPrice_OtherDevice5 { get; set; }
		public string TotalPrice_OtherDevice5 { get; set; }

		#endregion /Properties

		//-----The beginning of the coding line.

		#region ComputerAssembelForm_Load
		private void ComputerAssembelForm_Load(object sender, System.EventArgs e)
		{
			RestProperties();
		}
		#endregion /ComputerAssembelForm_Load

		#region CloseButton_Click
		private void CloseButton_Click(object sender, System.EventArgs e)
		{

		}
		#endregion /CloseButton_Click

		#region MaximizeButton_Click
		private void MaximizeButton_Click(object sender, System.EventArgs e)
		{

		}
		#endregion /MaximizeButton_Click

		#region MinimizeButton_Click
		private void MinimizeButton_Click(object sender, System.EventArgs e)
		{

		}
		#endregion /MinimizeButton_Click

		#region Processor
		//-----
		#region ProcessorCheckBox_CheckedChanged
		private void ProcessorCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{
			if (processorCheckBox.Checked == true)
			{
				processorTextBox.Enabled = true;
				processorPanel.Enabled = true;
				minusProssecButton.Enabled = true;
				addProcessButton.Enabled = true;
				unitPriceProcessorTextBox.Enabled = true;
				unitPriceProcessorPanel.Enabled = true;
			}
			else
			{
				processorTextBox.Enabled = false;
				processorTextBox.Text = "Processor";
				processorTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				processorPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				Process = string.Empty;
				processorPanel.Enabled = false;

				minusProssecButton.Enabled = false;
				numberProssecLabel.Text = "0";
				Number_Processor = 0;
				addProcessButton.Enabled = false;

				unitPriceProcessorTextBox.Enabled = false;
				unitPriceProcessorTextBox.Text = "قیمت واحد پردازنده";
				unitPriceProcessorTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				unitPriceProcessorPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				UnitPrice_Processor = 0;
				unitPriceProcessorPanel.Enabled = false;

				totalPriceProcessorLabel.Text = "قیمت کل پردازنده";
				TotalPrice_Processor = 0;
			}
		}
		#endregion /ProcessorCheckBox_CheckedChanged

		#region ProcessorTextBox
		//-----
		#region ProcessorTextBox_Enter
		private void ProcessorTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.EnglishLanguage();
			processorTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			processorPanel.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(processorTextBox.Text, "Processor") == 0)
			{
				processorTextBox.Clear();
			}
		}
		#endregion /ProcessorTextBox_Enter

		#region ProcessorTextBox_KeyPress
		private void ProcessorTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.EnglishAndNumberTyping(e);
		}
		#endregion /ProcessorTextBox_KeyPress

		#region ProcessorTextBox_Leave
		private void ProcessorTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(processorTextBox.Text) || string.Compare(processorTextBox.Text, "Processor") == 0)
			{
				processorTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				processorPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();

				processorTextBox.Text = "Processor";
				Process = string.Empty;
			}
			else
			{
				processorTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				processorPanel.BackColor =
					Infrastructure.Utility.WhiteColor();

				Process = processorTextBox.Text;
			}
		}
		#endregion /ProcessorTextBox_Leave
		//-----
		#endregion /ProcessorTextBox

		#region MinusProssecButton_Click
		private void MinusProssecButton_Click(object sender, System.EventArgs e)
		{
			if (Number_Processor <= 0)
			{
				return;
			}
			else
			{
				Number_Processor--;
				numberProssecLabel.Text = Number_Processor.ToString();

				if (string.IsNullOrWhiteSpace(unitPriceProcessorTextBox.Text) || string.Compare(unitPriceProcessorTextBox.Text, "قیمت واحد پردازنده") == 0)
				{
					return;
				}
				else
				{

					TotalPrice_Processor = UnitPrice_Processor * Number_Processor;

					if (Number_Processor == 0)
					{
						totalPriceProcessorLabel.Text = $"0 تومان";
						return;
					}
					else
					{
						totalPriceProcessorLabel.Text = $"{TotalPrice_Processor.ToString("#,0")} تومان";
					}
				}
			}

		}
		#endregion /MinusProssecButton_Click

		#region AddProcessButton_Click
		private void AddProcessButton_Click(object sender, System.EventArgs e)
		{
			Number_Processor++;
			numberProssecLabel.Text = Number_Processor.ToString();

			if (string.IsNullOrWhiteSpace(unitPriceProcessorTextBox.Text) || string.Compare(unitPriceProcessorTextBox.Text, "قیمت واحد پردازنده") == 0)
			{
				return;
			}
			else
			{
				TotalPrice_Processor = UnitPrice_Processor * Number_Processor;

				if (Number_Processor == 0)
				{
					totalPriceProcessorLabel.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceProcessorLabel.Text = $"{TotalPrice_Processor.ToString("#,0")} تومان";
				}
			}
		}
		#endregion /AddProcessButton_Click

		#region UnitPriceProcessorTextBox
		//-----
		#region UnitPriceProcessorTextBox_Enter
		private void UnitPriceProcessorTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.EnglishLanguage();
			unitPriceProcessorTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			unitPriceProcessorPanel.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(unitPriceProcessorTextBox.Text, "قیمت واحد پردازنده") == 0)
			{
				unitPriceProcessorTextBox.Clear();
				unitPriceProcessorTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				unitPriceProcessorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				return;
			}
		}
		#endregion /UnitPriceProcessorTextBox_Enter

		#region UnitPriceProcessorTextBox_KeyPress
		private void UnitPriceProcessorTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /UnitPriceProcessorTextBox_KeyPress

		#region UnitPriceProcessorTextBox_Leave
		private void UnitPriceProcessorTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(unitPriceProcessorTextBox.Text) || string.Compare(unitPriceProcessorTextBox.Text, "قیمت واحد پردازنده") == 0)
			{
				unitPriceProcessorTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				unitPriceProcessorPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();

				unitPriceProcessorTextBox.Text = "قیمت واحد پردازنده";
				unitPriceProcessorTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				unitPriceProcessorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				totalPriceProcessorLabel.Text = "قیمت کل پردازنده";
				totalPriceProcessorLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				totalPriceProcessorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
				UnitPrice_Processor = 0;
			}
			else
			{
				unitPriceProcessorTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				unitPriceProcessorPanel.BackColor =
					Infrastructure.Utility.WhiteColor();

				Price = unitPriceProcessorTextBox.Text.Replace("تومان", string.Empty).Trim();
				UnitPrice_Processor = int.Parse(Price);

				unitPriceProcessorTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				unitPriceProcessorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				unitPriceProcessorTextBox.Text = $"{UnitPrice_Processor:#,0} تومان";
			}
		}

		#endregion /UnitPriceProcessorTextBox_Leave

		#region UnitPriceProcessorTextBox_TextChanged
		private void UnitPriceProcessorTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(unitPriceProcessorTextBox.Text) || string.Compare(unitPriceProcessorTextBox.Text, "قیمت واحد پردازنده") == 0)
			{
				totalPriceProcessorLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				totalPriceProcessorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
				TotalPrice_Processor = 0;
				totalPriceProcessorLabel.Text = "قیمت کل پردازنده";
				return;
			}
			else if (string.Compare(unitPriceProcessorTextBox.Text, "تومان") == 0 || string.Compare(unitPriceProcessorTextBox.Text, " تومان") == 0 || string.Compare(unitPriceProcessorTextBox.Text, "ومان") == 0 || string.Compare(unitPriceProcessorTextBox.Text, "مان") == 0 || string.Compare(unitPriceProcessorTextBox.Text, "ان") == 0 || string.Compare(unitPriceProcessorTextBox.Text, "ن") == 0)
			{
				UnitPrice_Processor = 0;

				TotalPrice_Processor = UnitPrice_Processor * Number_Processor;

				if (Number_Processor == 0)
				{
					totalPriceProcessorLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceProcessorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceProcessorLabel.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceProcessorLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceProcessorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceProcessorLabel.Text = $"{TotalPrice_Processor:#,0} تومان";
				}
				return;

			}
			else if (unitPriceProcessorTextBox.Text.Contains("تومان"))
			{
				Price = unitPriceProcessorTextBox.Text.Replace("تومان", string.Empty).Trim();
				UnitPrice_Processor = int.Parse(Price.Replace(",", string.Empty).Trim());
				TotalPrice_Processor = UnitPrice_Processor * Number_Processor;

				if (Number_Processor == 0)
				{
					totalPriceProcessorLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceProcessorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceProcessorLabel.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceProcessorLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceProcessorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceProcessorLabel.Text = $"{TotalPrice_Processor:#,0} تومان";
				}
				return;
			}
			else
			{
				Price = unitPriceProcessorTextBox.Text.Replace("تومان", string.Empty).Trim();
				UnitPrice_Processor = int.Parse(Price.Replace(",", string.Empty).Trim());
				TotalPrice_Processor = UnitPrice_Processor * Number_Processor;

				if (Number_Processor == 0)
				{
					totalPriceProcessorLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceProcessorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceProcessorLabel.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceProcessorLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceProcessorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceProcessorLabel.Text = $"{TotalPrice_Processor:#,0} تومان";
				}
			}
		}
		#endregion /UnitPriceProcessorTextBox_TextChanged
		//-----
		#endregion /UnitPriceProcessorTextBox
		//-----
		#endregion /Processor

		#region Ram
		//-----
		#region RamCheckBox_CheckedChanged
		private void RamCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{
			if (ramCheckBox.Checked == true)
			{
				ramTextBox.Enabled = true;
				ramPanel.Enabled = true;
				minusRAMButton.Enabled = true;
				addRAMButton.Enabled = true;
				unitPriceRAMTextBox.Enabled = true;
				unitPriceRAMPanel.Enabled = true;
			}
			else
			{
				ramTextBox.Enabled = false;
				ramTextBox.Text = "RAM";
				ramTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				ramPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				RAM = string.Empty;
				ramPanel.Enabled = false;

				minusRAMButton.Enabled = false;
				numberRAMLabel.Text = "0";
				Number_RAM = 0;
				addRAMButton.Enabled = false;

				unitPriceRAMTextBox.Enabled = false;
				unitPriceRAMTextBox.Text = "قیمت واحد رم";
				unitPriceRAMTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				unitPriceRAMPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				UnitPrice_RAM = 0;
				unitPriceRAMPanel.Enabled = false;

				totalPriceRAMLabel.Text = "قیمت کل رم";
				TotalPrice_RAM = 0;
			}
		}
		#endregion /RamCheckBox_CheckedChanged#region RamTextBox

		#region RamTextBox
		//-----
		#region RamTextBox_Enter
		private void RamTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.EnglishLanguage();
			ramTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			ramPanel.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(ramTextBox.Text, "RAM") == 0)
			{
				ramTextBox.Clear();
			}
		}
		#endregion /RamTextBox_Enter

		#region RamTextBox_KeyPress
		private void RamTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.EnglishAndNumberTyping(e);
		}
		#endregion /RamTextBox_KeyPress

		#region RamTextBox_Leave
		private void RamTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(ramTextBox.Text) || string.Compare(ramTextBox.Text, "RAM") == 0)
			{
				ramTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				ramPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();

				ramTextBox.Text = "RAM";
				RAM = string.Empty;
			}
			else
			{
				ramTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				ramPanel.BackColor =
					Infrastructure.Utility.WhiteColor();

				RAM = ramTextBox.Text;
			}
		}
		#endregion /RamTextBox_Leave 
		//-----
		#endregion /RamTextBox

		#region MinusRAMButton_Click
		private void MinusRAMButton_Click(object sender, System.EventArgs e)
		{
			if (Number_RAM <= 0)
			{
				return;
			}
			else
			{
				Number_RAM--;
				numberRAMLabel.Text = Number_RAM.ToString();

				if (string.IsNullOrWhiteSpace(unitPriceRAMTextBox.Text) || string.Compare(unitPriceRAMTextBox.Text, "قیمت واحد رم") == 0)
				{
					return;
				}
				else
				{

					TotalPrice_RAM = UnitPrice_RAM * Number_RAM;

					if (Number_RAM == 0)
					{
						totalPriceRAMLabel.Text = $"0 تومان";
						return;
					}
					else
					{
						totalPriceRAMLabel.Text = $"{TotalPrice_RAM.ToString("#,0")} تومان";
					}
				}
			}
		}
		#endregion /MinusRAMButton_Click

		#region AddRAMButton_Click
		private void AddRAMButton_Click(object sender, System.EventArgs e)
		{
			Number_RAM++;
			numberRAMLabel.Text = Number_RAM.ToString();

			if (string.IsNullOrWhiteSpace(unitPriceRAMTextBox.Text) || string.Compare(unitPriceRAMTextBox.Text, "قیمت واحد رم") == 0)
			{
				return;
			}
			else
			{
				TotalPrice_RAM = UnitPrice_RAM * Number_RAM;

				if (Number_RAM == 0)
				{
					totalPriceRAMLabel.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceRAMLabel.Text = $"{TotalPrice_RAM.ToString("#,0")} تومان";
				}
			}
		}
		#endregion AddRAMButton_Click

		#region  UnitPriceRAMTextBox
		//-----
		#region UnitPriceRAMTextBox_Enter
		private void UnitPriceRAMTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.EnglishLanguage();
			unitPriceRAMTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			unitPriceRAMPanel.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(unitPriceRAMTextBox.Text, "قیمت واحد رم") == 0)
			{
				unitPriceRAMTextBox.Clear();
				unitPriceRAMTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				unitPriceRAMTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				return;
			}
		}
		#endregion /UnitPriceRAMTextBox_Enter

		#region UnitPriceRAMTextBox_KeyPress
		private void UnitPriceRAMTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion UnitPriceRAMTextBox_KeyPress

		#region UnitPriceRAMTextBox_Leave
		private void UnitPriceRAMTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(unitPriceRAMTextBox.Text) || string.Compare(unitPriceRAMTextBox.Text, "قیمت واحد رم") == 0)
			{
				unitPriceRAMTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				unitPriceRAMPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();

				unitPriceRAMTextBox.Text = "قیمت واحد رم";
				unitPriceRAMTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				unitPriceRAMTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				totalPriceRAMLabel.Text = "قیمت کل رم";
				totalPriceRAMLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				totalPriceRAMLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
				UnitPrice_RAM = 0;
			}
			else
			{
				unitPriceRAMTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				unitPriceRAMPanel.BackColor =
					Infrastructure.Utility.WhiteColor();
				unitPriceRAMTextBox.Text = $"{UnitPrice_RAM:#,0} تومان";
				unitPriceRAMTextBox.Text = "قیمت واحد رم";
				unitPriceRAMTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				unitPriceRAMTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			}
		}
		#endregion /UnitPriceRAMTextBox_Leave

		#region UnitPriceRAMTextBox_TextChanged
		private void UnitPriceRAMTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(unitPriceRAMTextBox.Text) || string.Compare(unitPriceRAMTextBox.Text, "قیمت واحد رم") == 0)
			{
				totalPriceRAMLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				totalPriceRAMLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
				TotalPrice_RAM = 0;
				totalPriceRAMLabel.Text = "قیمت کل رم";
				return;
			}
			else if (string.Compare(unitPriceRAMTextBox.Text, "تومان") == 0 || string.Compare(unitPriceRAMTextBox.Text, " تومان") == 0 || string.Compare(unitPriceRAMTextBox.Text, "ومان") == 0 || string.Compare(unitPriceRAMTextBox.Text, "مان") == 0 || string.Compare(unitPriceRAMTextBox.Text, "ان") == 0 || string.Compare(unitPriceRAMTextBox.Text, "ن") == 0)
			{
				UnitPrice_RAM = 0;

				TotalPrice_RAM = UnitPrice_RAM * Number_RAM;

				if (Number_RAM == 0)
				{
					totalPriceRAMLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceRAMLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceRAMLabel.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceRAMLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceRAMLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceRAMLabel.Text = $"{TotalPrice_RAM:#,0} تومان";
				}
				return;
			}
			else if (unitPriceRAMTextBox.Text.Contains("تومان"))
			{
				Price = unitPriceRAMTextBox.Text.Replace("تومان", string.Empty).Trim();
				UnitPrice_RAM = int.Parse(Price.Replace(",", string.Empty).Trim());
				TotalPrice_RAM = UnitPrice_RAM * Number_RAM;

				if (Number_RAM == 0)
				{
					totalPriceRAMLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceRAMLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceRAMLabel.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceRAMLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceRAMLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceRAMLabel.Text = $"{TotalPrice_RAM:#,0} تومان";
				}
				return;
			}
			else
			{
				Price = unitPriceRAMTextBox.Text.Replace("تومان", string.Empty).Trim();
				UnitPrice_RAM = int.Parse(Price);
				TotalPrice_RAM = UnitPrice_RAM * Number_RAM;

				if (Number_RAM == 0)
				{
					totalPriceRAMLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceRAMLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceRAMLabel.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceRAMLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceRAMLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceRAMLabel.Text = $"{TotalPrice_RAM:#,0} تومان";
				}
			}
		}
		#endregion /UnitPriceRAMTextBox_TextChanged
		//-----
		#endregion / UnitPriceRAMTextBox
		//-----
		#endregion /Ram

		#region H.D.D
		//-----
		#region HddCheckBox_CheckedChanged
		private void HddCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{
			if (hddCheckBox.Checked == true)
			{
				hddTextBox.Enabled = true;
				hddPanel.Enabled = true;
				minusHDDButton.Enabled = true;
				addHDDButton.Enabled = true;
				unitPriceHDDTextBox.Enabled = true;
				unitPriceHDDPanel.Enabled = true;
			}
			else
			{
				hddTextBox.Enabled = false;
				hddTextBox.Text = "H.D.D";
				hddTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				hddPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				HDD = string.Empty;
				hddPanel.Enabled = false;

				minusHDDButton.Enabled = false;
				numberHDDLabel.Text = "0";
				Number_HDD = 0;
				addHDDButton.Enabled = false;

				unitPriceHDDTextBox.Enabled = false;
				unitPriceHDDTextBox.Text = "قیمت واحد هارد دیسک";
				unitPriceHDDTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				unitPriceHDDPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				UnitPrice_HDD = 0;
				unitPriceHDDPanel.Enabled = false;

				totalPriceHDDLabel.Text = "قیمت کل هارد دیسک";
				TotalPrice_HDD = 0;
			}
		}
		#endregion /HddCheckBox_CheckedChanged 

		#region HddTextBox
		//-----
		#region HddTextBox_Enter
		private void HddTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.EnglishLanguage();
			hddTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			hddPanel.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(hddTextBox.Text, "H.D.D") == 0)
			{
				hddTextBox.Clear();
			}
		}
		#endregion /HddTextBox_Enter

		#region HddTextBox_KeyPress
		private void HddTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.EnglishAndNumberTyping(e);
		}
		#endregion /HddTextBox_KeyPress

		#region HddTextBox_Leave
		private void HddTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(hddTextBox.Text) || string.Compare(hddTextBox.Text, "H.D.D") == 0)
			{
				hddTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				hddPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();

				hddTextBox.Text = "H.D.D";
				HDD = string.Empty;
			}
			else
			{
				hddTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				hddPanel.BackColor =
					Infrastructure.Utility.WhiteColor();

				HDD = hddTextBox.Text;
			}
		}
		#endregion /HddTextBox_Leave
		//------
		#endregion /HddTextBox

		#region MinusHDDButton_Click
		private void MinusHDDButton_Click(object sender, System.EventArgs e)
		{
			if (Number_HDD <= 0)
			{
				return;
			}
			else
			{
				Number_HDD--;
				numberHDDLabel.Text = Number_HDD.ToString();

				if (string.IsNullOrWhiteSpace(unitPriceHDDTextBox.Text) || string.Compare(unitPriceHDDTextBox.Text, "قیمت واحد رم") == 0)
				{
					return;
				}
				else
				{
					TotalPrice_HDD = UnitPrice_HDD * Number_HDD;

					if (Number_HDD == 0)
					{
						totalPriceHDDLabel.Text = $"0 تومان";
						return;
					}
					else
					{
						totalPriceHDDLabel.Text = $"{TotalPrice_HDD:#,0} تومان";
					}
				}
			}
		}
		#endregion /MinusHDDButton_Click

		#region AddHDDButton_Click
		private void AddHDDButton_Click(object sender, System.EventArgs e)
		{
			Number_HDD++;
			numberHDDLabel.Text = Number_HDD.ToString();

			if (string.IsNullOrWhiteSpace(unitPriceHDDTextBox.Text) || string.Compare(unitPriceHDDTextBox.Text, "قیمت واحد رم") == 0)
			{
				return;
			}
			else
			{
				TotalPrice_HDD = UnitPrice_HDD * Number_HDD;

				if (Number_HDD == 0)
				{
					totalPriceHDDLabel.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceHDDLabel.Text = $"{TotalPrice_HDD:#,0} تومان";
				}
			}
		}
		#endregion /AddHDDButton_Click

		#region UnitPriceHDDTextBox
		//-----
		#region UnitPriceHDDTextBox_Enter
		private void UnitPriceHDDTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.EnglishLanguage();
			unitPriceHDDTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			unitPriceHDDPanel.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(unitPriceHDDTextBox.Text, "قیمت واحد هارد دیسک") == 0)
			{
				unitPriceHDDTextBox.Clear();
				unitPriceHDDTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				unitPriceHDDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				return;
			}
		}
		#endregion /UnitPriceHDDTextBox_Enter

		#region UnitPriceHDDTextBox_KeyPress
		private void UnitPriceHDDTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /UnitPriceHDDTextBox_KeyPress

		#region UnitPriceHDDTextBox_Leave
		private void UnitPriceHDDTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(unitPriceHDDTextBox.Text) || string.Compare(unitPriceHDDTextBox.Text, "قیمت واحد هارد دیسک") == 0)
			{
				unitPriceHDDTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				unitPriceHDDPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();

				unitPriceHDDTextBox.Text = "قیمت واحد هارد دیسک";
				unitPriceHDDTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				unitPriceHDDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				totalPriceHDDLabel.Text = "قیمت کل هارد دیسک";
				totalPriceHDDLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				totalPriceHDDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
				UnitPrice_HDD = 0;
			}
			else
			{
				unitPriceHDDTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				unitPriceHDDPanel.BackColor =
					Infrastructure.Utility.WhiteColor();
				unitPriceHDDTextBox.Text = $"{UnitPrice_HDD:#,0} تومان";
				unitPriceHDDTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				unitPriceHDDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			}
		}
		#endregion /UnitPriceHDDTextBox_Leave

		#region UnitPriceHDDTextBox_TextChanged
		private void UnitPriceHDDTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(unitPriceHDDTextBox.Text) || string.Compare(unitPriceHDDTextBox.Text, "قیمت واحد هارد دیسک") == 0)
			{
				totalPriceHDDLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				totalPriceHDDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
				TotalPrice_HDD = 0;
				totalPriceHDDLabel.Text = "کل قیمت هارد دیسک";
				return;
			}
			else if (string.Compare(unitPriceHDDTextBox.Text, "تومان") == 0 || string.Compare(unitPriceHDDTextBox.Text, " تومان") == 0 || string.Compare(unitPriceHDDTextBox.Text, "ومان") == 0 || string.Compare(unitPriceHDDTextBox.Text, "مان") == 0 || string.Compare(unitPriceHDDTextBox.Text, "ان") == 0 || string.Compare(unitPriceHDDTextBox.Text, "ن") == 0)
			{
				UnitPrice_HDD = 0;

				TotalPrice_HDD = UnitPrice_HDD * Number_HDD;

				if (Number_HDD == 0)
				{
					totalPriceHDDLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceHDDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
					totalPriceHDDLabel.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceHDDLabel.Text = $"{TotalPrice_HDD:#,0} تومان";
				}
				return;

			}
			else if (unitPriceHDDTextBox.Text.Contains("تومان"))
			{
				Price = unitPriceHDDTextBox.Text.Replace("تومان", string.Empty).Trim();
				UnitPrice_HDD = int.Parse(Price.Replace(",", string.Empty).Trim());
				TotalPrice_HDD = UnitPrice_HDD * Number_HDD;

				if (Number_HDD == 0)
				{
					totalPriceHDDLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceHDDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
					totalPriceHDDLabel.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceHDDLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceHDDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
					totalPriceHDDLabel.Text = $"{TotalPrice_HDD:#,0} تومان";
				}
				return;
			}
			else
			{
				Price = unitPriceHDDTextBox.Text.Replace("تومان", string.Empty).Trim();
				UnitPrice_HDD = int.Parse(Price.Replace(",", string.Empty).Trim());
				TotalPrice_HDD = UnitPrice_HDD * Number_HDD;

				if (Number_HDD == 0)
				{
					totalPriceHDDLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceHDDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
					totalPriceHDDLabel.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceHDDLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceHDDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
					totalPriceHDDLabel.Text = $"{TotalPrice_HDD:#,0} تومان";
				}
			}
		}
		#endregion /UnitPriceHDDTextBox_TextChanged 
		//-----
		#endregion /UnitPriceHDDTextBox
		//-----
		#endregion /H.D.D

		#region DVD-ROM
		//-----
		#region DvdRomCheckBox_CheckedChanged
		private void DvdRomCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{
			if (dvdRomCheckBox.Checked == true)
			{
				dvdRomTextBox.Enabled = true;
				dvdRomPanel.Enabled = true;
				minusDVDRomButton.Enabled = true;
				addDVDRomButton.Enabled = true;
				unitPriceDVDRomTextBox.Enabled = true;
				unitPriceDVDRomPanel.Enabled = true;
			}
			else
			{
				dvdRomTextBox.Enabled = false;
				dvdRomTextBox.Text = "DVD-ROM";
				dvdRomTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				dvdRomPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				DVDROM = string.Empty;
				dvdRomPanel.Enabled = false;

				minusDVDRomButton.Enabled = false;
				numberDVDRomLabel.Text = "0";
				Number_DVDROM = 0;
				addDVDRomButton.Enabled = false;

				unitPriceDVDRomTextBox.Enabled = false;
				unitPriceDVDRomTextBox.Text = "قیمت واحد دی وی دی رام";
				unitPriceDVDRomTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				unitPriceDVDRomPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				UnitPrice_DVDROM = 0;
				unitPriceDVDRomPanel.Enabled = false;

				totalPriceDVDRomLabel.Text = "قیمت کل دی وی دی رام";
				TotalPrice_DVDROM = 0;
			}
		}
		#endregion /DvdRomCheckBox_CheckedChanged 

		#region DvdRomTextBox
		//-----
		#region DvdRomTextBox_Enter
		private void DvdRomTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.EnglishLanguage();
			dvdRomTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			dvdRomPanel.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(dvdRomTextBox.Text, "DVD-ROM") == 0)
			{
				dvdRomTextBox.Clear();
			}
		}
		#endregion /DvdRomTextBox_Enter

		#region DvdRomTextBox_KeyPress
		private void DvdRomTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.EnglishAndNumberTyping(e);
		}
		#endregion /DvdRomTextBox_KeyPress

		#region DvdRomTextBox_Leave
		private void DvdRomTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(dvdRomTextBox.Text) || string.Compare(dvdRomTextBox.Text, "DVD-ROM") == 0)
			{
				dvdRomTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				dvdRomPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();

				dvdRomTextBox.Text = "DVD-ROM";
				DVDROM = string.Empty;
			}
			else
			{
				dvdRomTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				dvdRomPanel.BackColor =
					Infrastructure.Utility.WhiteColor();

				DVDROM = dvdRomTextBox.Text;
			}
		}
		#endregion /DvdRomTextBox_Leave
		//-----
		#endregion /DvdRomTextBox

		#region MinusDVDRomButton_Click
		private void MinusDVDRomButton_Click(object sender, System.EventArgs e)
		{
			if (Number_DVDROM <= 0)
			{
				return;
			}
			else
			{
				Number_DVDROM--;
				numberDVDRomLabel.Text = Number_DVDROM.ToString();

				if (string.IsNullOrWhiteSpace(unitPriceDVDRomTextBox.Text) || string.Compare(unitPriceDVDRomTextBox.Text, "قیمت واحد دی وی دی رام") == 0)
				{
					return;
				}
				else
				{
					TotalPrice_DVDROM = UnitPrice_DVDROM * Number_DVDROM;

					if (Number_DVDROM == 0)
					{
						totalPriceDVDRomLabel.Text = $"0 تومان";
						return;
					}
					else
					{
						totalPriceDVDRomLabel.Text = $"{TotalPrice_DVDROM:#,0} تومان";
					}
				}
			}
		}
		#endregion /MinusDVDRomButton_Click

		#region AddDVDRomButton_Click
		private void AddDVDRomButton_Click(object sender, System.EventArgs e)
		{
			Number_DVDROM++;
			numberDVDRomLabel.Text = Number_DVDROM.ToString();

			if (string.IsNullOrWhiteSpace(unitPriceDVDRomTextBox.Text) || string.Compare(unitPriceDVDRomTextBox.Text, "قیمت واحد دی وی دی رام") == 0)
			{
				return;
			}
			else
			{
				TotalPrice_DVDROM = UnitPrice_DVDROM * Number_DVDROM;

				if (Number_DVDROM == 0)
				{
					totalPriceDVDRomLabel.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceDVDRomLabel.Text = $"{TotalPrice_DVDROM:#,0} تومان";
				}
			}
		}
		#endregion /AddDVDRomButton_Click

		#region UnitPriceDVDRomTextBox
		//-----
		#region UnitPriceDVDRomTextBox_Enter
		private void UnitPriceDVDRomTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.EnglishLanguage();
			unitPriceDVDRomTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			unitPriceDVDRomPanel.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(unitPriceDVDRomTextBox.Text, "قیمت واحد دی وی دی رام") == 0)
			{
				unitPriceDVDRomTextBox.Clear();
				unitPriceDVDRomTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				unitPriceDVDRomTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				return;
			}
		}
		#endregion /UnitPriceDVDRomTextBox_Enter

		#region UnitPriceDVDRomTextBox_KeyPress
		private void UnitPriceDVDRomTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /UnitPriceDVDRomTextBox_KeyPress

		#region UnitPriceDVDRomTextBox_Leave
		private void UnitPriceDVDRomTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(unitPriceDVDRomTextBox.Text) || string.Compare(unitPriceDVDRomTextBox.Text, "قیمت واحد دی وی دی رام") == 0)
			{
				unitPriceDVDRomTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				unitPriceDVDRomPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();

				unitPriceDVDRomTextBox.Text = "قیمت واحد دی وی دی رام";
				unitPriceDVDRomTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				unitPriceDVDRomTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				totalPriceDVDRomLabel.Text = "قیمت کل دی وی دی رام";
				totalPriceDVDRomLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				totalPriceDVDRomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
				UnitPrice_DVDROM = 0;
			}
			else
			{
				unitPriceDVDRomTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				unitPriceDVDRomPanel.BackColor =
					Infrastructure.Utility.WhiteColor();
				unitPriceDVDRomTextBox.Text = $"{UnitPrice_DVDROM:#,0} تومان";
				unitPriceDVDRomTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				unitPriceDVDRomTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			}
		}
		#endregion /UnitPriceDVDRomTextBox_Leave

		#region UnitPriceDVDRomTextBox_TextChanged
		private void UnitPriceDVDRomTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(unitPriceDVDRomTextBox.Text) || string.Compare(unitPriceDVDRomTextBox.Text, "قیمت واحد دی وی دی رام") == 0)
			{
				totalPriceDVDRomLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				totalPriceDVDRomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
				TotalPrice_DVDROM = 0;
				totalPriceDVDRomLabel.Text = "کل قیمت دی وی دی رام";
				return;
			}
			else if (string.Compare(unitPriceDVDRomTextBox.Text, "تومان") == 0 || string.Compare(unitPriceDVDRomTextBox.Text, " تومان") == 0)
			{
				UnitPrice_DVDROM = 0;

				TotalPrice_DVDROM = UnitPrice_DVDROM * Number_DVDROM;

				if (Number_DVDROM == 0)
				{
					totalPriceDVDRomLabel.Text = $"تومان 0";
					return;
				}
				else
				{
					totalPriceDVDRomLabel.Text = $"تومان {TotalPrice_DVDROM:#,0}";
				}
				return;

			}
			else if (unitPriceDVDRomTextBox.Text.Contains("تومان"))
			{
				Price = unitPriceDVDRomTextBox.Text.Replace("تومان", string.Empty).Trim();
				UnitPrice_DVDROM = int.Parse(Price.Replace(",", string.Empty).Trim());
				TotalPrice_DVDROM = UnitPrice_DVDROM * Number_DVDROM;

				if (Number_DVDROM == 0)
				{
					totalPriceDVDRomLabel.Text = $"تومان 0";
					return;
				}
				else
				{
					totalPriceDVDRomLabel.Text = $"تومان {TotalPrice_DVDROM:#,0}";
				}
				return;
			}
			else
			{
				Price = unitPriceDVDRomTextBox.Text.Replace("تومان", string.Empty).Trim();
				UnitPrice_DVDROM = int.Parse(Price.Replace(",", string.Empty).Trim());
				TotalPrice_DVDROM = UnitPrice_DVDROM * Number_DVDROM;

				if (Number_DVDROM == 0)
				{
					totalPriceDVDRomLabel.Text = $"تومان 0";
					return;
				}
				else
				{
					totalPriceDVDRomLabel.Text = $"تومان {TotalPrice_DVDROM:#,0}";
				}
			}
		}
		#endregion /UnitPriceDVDRomTextBox_TextChanged
		//-----
		#endregion /UnitPriceDVDRomTextBox
		//-----
		#endregion /DVD-ROM

		#region GraphicCard
		//-----
		#region GraphicCardCheckBox_CheckedChanged
		private void GraphicCardCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{
			if (graphicCardCheckBox.Checked == true)
			{
				graphicCardTextBox.Enabled = true;
				graphicCardPanel.Enabled = true;
				minusGraphicCardButton.Enabled = true;
				addGraphicCardButton.Enabled = true;
				unitPriceGraphicCardTextBox.Enabled = true;
				unitPriceGraphicCardPanel.Enabled = true;
			}
			else
			{
				graphicCardTextBox.Enabled = false;
				graphicCardTextBox.Text = "Graphic Card";
				graphicCardTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				graphicCardPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				GraphicCard = string.Empty;
				graphicCardPanel.Enabled = false;

				minusGraphicCardButton.Enabled = false;
				numberGraphicCardLabel.Text = "0";
				Number_GraphicCard = 0;
				addGraphicCardButton.Enabled = false;

				unitPriceGraphicCardTextBox.Enabled = false;
				unitPriceGraphicCardTextBox.Text = "قیمت واحد کارت گرافیک";
				unitPriceGraphicCardTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				unitPriceGraphicCardPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				UnitPrice_GraphicCard = 0;
				unitPriceGraphicCardPanel.Enabled = false;

				totalPriceGraphicCardLabel.Text = "قیمت کل کارت گرافیک";
				TotalPrice_GraphicCard = 0;
			}
		}
		#endregion /GraphicCardCheckBox_CheckedChanged

		#region GraphicCardTextBox
		//-----
		#region GraphicCardTextBox_Enter
		private void GraphicCardTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.EnglishLanguage();
			graphicCardTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			graphicCardPanel.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(graphicCardTextBox.Text, "Graphic Card") == 0)
			{
				graphicCardTextBox.Clear();
			}
		}

		#endregion /GraphicCardTextBox_Enter

		#region GraphicCardTextBox_KeyPress
		private void GraphicCardTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.EnglishAndNumberTyping(e);
		}

		#endregion /GraphicCardTextBox_KeyPress

		#region GraphicCardTextBox_Leave
		private void GraphicCardTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(graphicCardTextBox.Text) || string.Compare(graphicCardTextBox.Text, "Graphic Card") == 0)
			{
				graphicCardTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				graphicCardPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();

				graphicCardTextBox.Text = "Graphic Card";
				GraphicCard = string.Empty;
			}
			else
			{
				graphicCardTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				graphicCardPanel.BackColor =
					Infrastructure.Utility.WhiteColor();

				GraphicCard = graphicCardTextBox.Text;
			}
		}

		#endregion /GraphicCardTextBox_Leave 
		//-----
		#endregion /GraphicCardTextBox

		#region MinusGraphicCardButton_Click
		private void MinusGraphicCardButton_Click(object sender, System.EventArgs e)
		{
			if (Number_GraphicCard <= 0)
			{
				return;
			}
			else
			{
				Number_GraphicCard--;
				numberGraphicCardLabel.Text = Number_GraphicCard.ToString();

				if (string.IsNullOrWhiteSpace(unitPriceGraphicCardTextBox.Text) || string.Compare(unitPriceGraphicCardTextBox.Text, "قیمت واحد کارت گرافیک") == 0)
				{
					return;
				}
				else
				{
					TotalPrice_GraphicCard = UnitPrice_GraphicCard * Number_GraphicCard;

					if (Number_GraphicCard == 0)
					{
						totalPriceGraphicCardLabel.Text = $"0 تومان";
						return;
					}
					else
					{
						totalPriceGraphicCardLabel.Text = $"{TotalPrice_GraphicCard:#,0} تومان";
					}
				}
			}
		}

		#endregion /MinusGraphicCardButton_Click

		#region AddGraphicCardButton_Click
		private void AddGraphicCardButton_Click(object sender, System.EventArgs e)
		{
			Number_GraphicCard++;
			numberGraphicCardLabel.Text = Number_GraphicCard.ToString();

			if (string.IsNullOrWhiteSpace(unitPriceGraphicCardTextBox.Text) || string.Compare(unitPriceGraphicCardTextBox.Text, "قیمت واحد دی وی دی رام") == 0)
			{
				return;
			}
			else
			{
				TotalPrice_GraphicCard = UnitPrice_GraphicCard * Number_GraphicCard;

				if (Number_GraphicCard == 0)
				{
					totalPriceGraphicCardLabel.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceGraphicCardLabel.Text = $"{TotalPrice_GraphicCard:#,0} تومان";
				}
			}
		}

		#endregion /AddGraphicCardButton_Click

		#region UnitPriceGraphicCardTextBox
		//-----
		#region UnitPriceGraphicCardTextBox_Enter
		private void UnitPriceGraphicCardTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.EnglishLanguage();
			unitPriceGraphicCardTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			unitPriceGraphicCardPanel.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(unitPriceGraphicCardTextBox.Text, "قیمت واحد کارت گرافیک") == 0)
			{
				unitPriceGraphicCardTextBox.Clear();
				return;
			}
		}

		#endregion /UnitPriceGraphicCardTextBox_Enter

		#region UnitPriceGraphicCardTextBox_KeyPress
		private void UnitPriceGraphicCardTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}

		#endregion /UnitPriceGraphicCardTextBox_KeyPress

		#region UnitPriceGraphicCardTextBox_Leave
		private void UnitPriceGraphicCardTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(unitPriceGraphicCardTextBox.Text) || string.Compare(unitPriceGraphicCardTextBox.Text, "قیمت واحد کارت گرافیک") == 0)
			{
				unitPriceGraphicCardTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				unitPriceGraphicCardPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();

				unitPriceGraphicCardTextBox.Text = "قیمت واحد کارت گرافیک";
				totalPriceGraphicCardLabel.Text = "قیمت کل کارت گرافیک";
				UnitPrice_GraphicCard = 0;
			}
			else
			{
				unitPriceGraphicCardTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				unitPriceGraphicCardPanel.BackColor =
					Infrastructure.Utility.WhiteColor();
				unitPriceGraphicCardTextBox.Text = $"تومان {UnitPrice_GraphicCard:#,0}";
			}
		}

		#endregion /UnitPriceGraphicCardTextBox_Leave

		#region UnitPriceGraphicCardTextBox_TextChanged
		private void UnitPriceGraphicCardTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(unitPriceGraphicCardTextBox.Text) || string.Compare(unitPriceGraphicCardTextBox.Text, "قیمت واحد کارت گرافیک") == 0)
			{
				TotalPrice_GraphicCard = 0;
				totalPriceGraphicCardLabel.Text = "کل قیمت دی وی دی رام";
				return;
			}
			else if (string.Compare(unitPriceGraphicCardTextBox.Text, "تومان") == 0 || string.Compare(unitPriceGraphicCardTextBox.Text, " تومان") == 0)
			{
				UnitPrice_GraphicCard = 0;

				TotalPrice_GraphicCard = UnitPrice_GraphicCard * Number_GraphicCard;

				if (Number_GraphicCard == 0)
				{
					totalPriceGraphicCardLabel.Text = $"تومان 0";
					return;
				}
				else
				{
					totalPriceGraphicCardLabel.Text = $"تومان {TotalPrice_GraphicCard:#,0}";
				}
				return;

			}
			else if (unitPriceGraphicCardTextBox.Text.Contains("تومان"))
			{
				Price = unitPriceGraphicCardTextBox.Text.Replace("تومان", string.Empty).Trim();
				UnitPrice_GraphicCard = int.Parse(Price.Replace(",", string.Empty).Trim());
				TotalPrice_GraphicCard = UnitPrice_GraphicCard * Number_GraphicCard;

				if (Number_GraphicCard == 0)
				{
					totalPriceGraphicCardLabel.Text = $"تومان 0";
					return;
				}
				else
				{
					totalPriceGraphicCardLabel.Text = $"تومان {TotalPrice_GraphicCard:#,0}";
				}
				return;
			}
			else
			{
				Price = unitPriceGraphicCardTextBox.Text.Replace("تومان", string.Empty).Trim();
				UnitPrice_GraphicCard = int.Parse(Price.Replace(",", string.Empty).Trim());
				TotalPrice_GraphicCard = UnitPrice_GraphicCard * Number_GraphicCard;

				if (Number_GraphicCard == 0)
				{
					totalPriceGraphicCardLabel.Text = $"تومان 0";
					return;
				}
				else
				{
					totalPriceGraphicCardLabel.Text = $"تومان {TotalPrice_GraphicCard:#,0}";
				}
			}
		}

		#endregion /UnitPriceGraphicCardTextBox_TextChanged 
		//-----
		#endregion /UnitPriceGraphicCardTextBox
		//-----
		#endregion /GraphicCard

		#region Keyboard
		//-----
		#region KeyboardCheckBox_CheckedChanged
		private void KeyboardCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{
			if (keyboardCheckBox.Checked == true)
			{
				keyboardTextBox.Enabled = true;
				keyboardPanel.Enabled = true;
				minusKeyboardButton.Enabled = true;
				addKeyboardButton.Enabled = true;
				unitPriceKeyboardTextBox.Enabled = true;
				unitPriceKeyboardPanel.Enabled = true;
			}
			else
			{
				keyboardTextBox.Enabled = false;
				keyboardTextBox.Text = "Keyborad";
				keyboardTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				keyboardPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				Keyboard = string.Empty;
				keyboardPanel.Enabled = false;

				minusKeyboardButton.Enabled = false;
				numberKeyboardLabel.Text = "0";
				Number_Keyboard = 0;
				addKeyboardButton.Enabled = false;

				unitPriceKeyboardTextBox.Enabled = false;
				unitPriceKeyboardTextBox.Text = "قیمت واحد صفحه کلید";
				unitPriceKeyboardTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				unitPriceKeyboardPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				UnitPrice_Keyboard = 0;
				unitPriceKeyboardPanel.Enabled = false;

				totalPriceKeyboardLabel.Text = "قیمت کل صفحه کلید";
				TotalPrice_Keyboard = 0;
			}
		}
		#endregion /KeyboardCheckBox_CheckedChanged

		#region  KeyboardTextBox
		//-----
		#region KeyboardTextBox_Enter
		private void KeyboardTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.EnglishLanguage();
			keyboardTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			keyboardPanel.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(keyboardTextBox.Text, "Keboard") == 0)
			{
				keyboardTextBox.Clear();
			}
		}

		#endregion /KeyboardTextBox_Enter

		#region KeyboardTextBox_KeyPress
		private void KeyboardTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.EnglishAndNumberTyping(e);
		}

		#endregion /KeyboardTextBox_KeyPress

		#region KeyboardTextBox_Leave
		private void KeyboardTextBox_Leave(object sender, System.EventArgs e)
		{

			if (string.IsNullOrWhiteSpace(keyboardTextBox.Text) || string.Compare(keyboardTextBox.Text, "Keboard") == 0)
			{
				keyboardTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				keyboardPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();

				keyboardTextBox.Text = "Keboard";
				Keyboard = string.Empty;
			}
			else
			{
				keyboardTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				keyboardPanel.BackColor =
					Infrastructure.Utility.WhiteColor();

				Keyboard = keyboardTextBox.Text;
			}
		}

		#endregion /KeyboardTextBox_Leave
		//-----
		#endregion / KeyboardTextBox

		#region MinusKeyboardButton_Click
		private void MinusKeyboardButton_Click(object sender, System.EventArgs e)
		{
			if (Number_Keyboard <= 0)
			{
				return;
			}
			else
			{
				Number_Keyboard--;
				numberKeyboardLabel.Text = Number_Keyboard.ToString();

				if (string.IsNullOrWhiteSpace(keyboardTextBox.Text) || string.Compare(keyboardTextBox.Text, "قیمت واحد کارت گرافیک") == 0)
				{
					return;
				}
				else
				{
					TotalPrice_Keyboard = UnitPrice_Keyboard * Number_Keyboard;

					if (Number_Keyboard == 0)
					{
						totalPriceKeyboardLabel.Text = $"0 تومان";
						return;
					}
					else
					{
						totalPriceKeyboardLabel.Text = $"{TotalPrice_Keyboard:#,0} تومان";
					}
				}
			}
		}
		#endregion /MinusKeyboardButton_Click

		#region AddKeyboardButton_Click
		private void AddKeyboardButton_Click(object sender, System.EventArgs e)
		{
			Number_Keyboard++;
			numberKeyboardLabel.Text = Number_Keyboard.ToString();

			if (string.IsNullOrWhiteSpace(unitPriceKeyboardTextBox.Text) || string.Compare(unitPriceKeyboardTextBox.Text, "قیمت واحد دی وی دی رام") == 0)
			{
				return;
			}
			else
			{
				TotalPrice_Keyboard = UnitPrice_Keyboard * Number_Keyboard;

				if (Number_Keyboard == 0)
				{
					totalPriceKeyboardLabel.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceKeyboardLabel.Text = $"{TotalPrice_Keyboard:#,0} تومان";
				}
			}
		}
		#endregion /AddKeyboardButton_Click

		#region UnitPriceKeyboardTextBox
		//-----
		#region UnitPriceKeyboardTextBox_Enter
		private void UnitPriceKeyboardTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.EnglishLanguage();
			unitPriceKeyboardTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			unitPriceKeyboardPanel.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(unitPriceKeyboardTextBox.Text, "قیمت واحد صفحه کلید") == 0)
			{
				unitPriceKeyboardTextBox.Clear();
				return;
			}
		}
		#endregion /UnitPriceKeyboardTextBox_Enter

		#region UnitPriceKeyboardTextBox_KeyPress
		private void UnitPriceKeyboardTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /UnitPriceKeyboardTextBox_KeyPress

		#region UnitPriceKeyboardTextBox_Leave
		private void UnitPriceKeyboardTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(unitPriceKeyboardTextBox.Text) || string.Compare(unitPriceKeyboardTextBox.Text, "قیمت واحد صفحه کلید") == 0)
			{
				unitPriceKeyboardTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				unitPriceKeyboardPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();

				unitPriceKeyboardTextBox.Text = "قیمت واحد صفحه کلید";
				totalPriceKeyboardLabel.Text = "قیمت کل صفحه کلید";
				UnitPrice_Keyboard = 0;
			}
			else
			{
				unitPriceKeyboardTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				unitPriceKeyboardPanel.BackColor =
					Infrastructure.Utility.WhiteColor();
				unitPriceKeyboardTextBox.Text = $"تومان {UnitPrice_Keyboard:#,0}";
			}
		}
		#endregion /UnitPriceKeyboardTextBox_Leave

		#region UnitPriceKeyboardTextBox_TextChanged
		private void UnitPriceKeyboardTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(unitPriceKeyboardTextBox.Text) || string.Compare(unitPriceKeyboardTextBox.Text, "قیمت واحد صفحه کلید") == 0)
			{
				TotalPrice_Keyboard = 0;
				totalPriceKeyboardLabel.Text = "کل قیمت صفحه کلید";
				return;
			}
			else if (string.Compare(unitPriceKeyboardTextBox.Text, "تومان") == 0 || string.Compare(unitPriceKeyboardTextBox.Text, " تومان") == 0)
			{
				UnitPrice_Keyboard = 0;

				TotalPrice_Keyboard = UnitPrice_Keyboard * Number_Keyboard;

				if (Number_Keyboard == 0)
				{
					totalPriceKeyboardLabel.Text = $"تومان 0";
					return;
				}
				else
				{
					totalPriceKeyboardLabel.Text = $"تومان {TotalPrice_Keyboard:#,0}";
				}
				return;

			}
			else if (unitPriceGraphicCardTextBox.Text.Contains("تومان"))
			{
				Price = unitPriceKeyboardTextBox.Text.Replace("تومان", string.Empty).Trim();
				UnitPrice_Keyboard = int.Parse(Price.Replace(",", string.Empty).Trim());
				TotalPrice_Keyboard = UnitPrice_Keyboard * Number_Keyboard;

				if (Number_GraphicCard == 0)
				{
					totalPriceKeyboardLabel.Text = $"تومان 0";
					return;
				}
				else
				{
					totalPriceKeyboardLabel.Text = $"تومان {TotalPrice_Keyboard:#,0}";
				}
				return;
			}
			else
			{
				Price = unitPriceKeyboardTextBox.Text.Replace("تومان", string.Empty).Trim();
				UnitPrice_Keyboard = int.Parse(Price.Replace(",", string.Empty).Trim());
				TotalPrice_Keyboard = UnitPrice_Keyboard * Number_Keyboard;

				if (Number_Keyboard == 0)
				{
					totalPriceKeyboardLabel.Text = $"تومان 0";
					return;
				}
				else
				{
					totalPriceKeyboardLabel.Text = $"تومان {TotalPrice_Keyboard:#,0}";
				}
			}
		}
		#endregion /UnitPriceKeyboardTextBox_TextChanged 
		//-----
		#endregion /UnitPriceKeyboardTextBox
		//-----
		#endregion /Keyboard

		#region Mouse
		//-----
		#region MouseCheckBox_CheckedChanged
		private void MouseCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{
			if (graphicCardCheckBox.Checked == true)
			{
				graphicCardTextBox.Enabled = true;
				graphicCardPanel.Enabled = true;
				minusGraphicCardButton.Enabled = true;
				addGraphicCardButton.Enabled = true;
				unitPriceGraphicCardTextBox.Enabled = true;
				unitPriceGraphicCardPanel.Enabled = true;
			}
			else
			{
				graphicCardTextBox.Enabled = false;
				graphicCardTextBox.Text = "Graphic Card";
				graphicCardTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				graphicCardPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				GraphicCard = string.Empty;
				graphicCardPanel.Enabled = false;

				minusGraphicCardButton.Enabled = false;
				numberGraphicCardLabel.Text = "0";
				Number_GraphicCard = 0;
				addGraphicCardButton.Enabled = false;

				unitPriceGraphicCardTextBox.Enabled = false;
				unitPriceGraphicCardTextBox.Text = "قیمت واحد کارت گرافیک";
				unitPriceGraphicCardTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				unitPriceGraphicCardPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				UnitPrice_GraphicCard = 0;
				unitPriceGraphicCardPanel.Enabled = false;

				totalPriceGraphicCardLabel.Text = "قیمت کل کارت گرافیک";
				TotalPrice_GraphicCard = 0;
			}
		}
		#endregion /MouseCheckBox_CheckedChanged
		//-----
		#endregion /Mouse

		#region SpeakerCheckBox_CheckedChanged
		private void SpeakerCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{
			if (graphicCardCheckBox.Checked == true)
			{
				graphicCardTextBox.Enabled = true;
				graphicCardPanel.Enabled = true;
				minusGraphicCardButton.Enabled = true;
				addGraphicCardButton.Enabled = true;
				unitPriceGraphicCardTextBox.Enabled = true;
				unitPriceGraphicCardPanel.Enabled = true;
			}
			else
			{
				graphicCardTextBox.Enabled = false;
				graphicCardTextBox.Text = "Graphic Card";
				graphicCardTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				graphicCardPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				GraphicCard = string.Empty;
				graphicCardPanel.Enabled = false;

				minusGraphicCardButton.Enabled = false;
				numberGraphicCardLabel.Text = "0";
				Number_GraphicCard = 0;
				addGraphicCardButton.Enabled = false;

				unitPriceGraphicCardTextBox.Enabled = false;
				unitPriceGraphicCardTextBox.Text = "قیمت واحد کارت گرافیک";
				unitPriceGraphicCardTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				unitPriceGraphicCardPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				UnitPrice_GraphicCard = 0;
				unitPriceGraphicCardPanel.Enabled = false;

				totalPriceGraphicCardLabel.Text = "قیمت کل کارت گرافیک";
				TotalPrice_GraphicCard = 0;
			}
		}
		#endregion /SpeakerCheckBox_CheckedChanged

		#region MonitorCeckBox_CheckedChanged
		private void MonitorCeckBox_CheckedChanged(object sender, System.EventArgs e)
		{
			if (graphicCardCheckBox.Checked == true)
			{
				graphicCardTextBox.Enabled = true;
				graphicCardPanel.Enabled = true;
				minusGraphicCardButton.Enabled = true;
				addGraphicCardButton.Enabled = true;
				unitPriceGraphicCardTextBox.Enabled = true;
				unitPriceGraphicCardPanel.Enabled = true;
			}
			else
			{
				graphicCardTextBox.Enabled = false;
				graphicCardTextBox.Text = "Graphic Card";
				graphicCardTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				graphicCardPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				GraphicCard = string.Empty;
				graphicCardPanel.Enabled = false;

				minusGraphicCardButton.Enabled = false;
				numberGraphicCardLabel.Text = "0";
				Number_GraphicCard = 0;
				addGraphicCardButton.Enabled = false;

				unitPriceGraphicCardTextBox.Enabled = false;
				unitPriceGraphicCardTextBox.Text = "قیمت واحد کارت گرافیک";
				unitPriceGraphicCardTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				unitPriceGraphicCardPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				UnitPrice_GraphicCard = 0;
				unitPriceGraphicCardPanel.Enabled = false;

				totalPriceGraphicCardLabel.Text = "قیمت کل کارت گرافیک";
				TotalPrice_GraphicCard = 0;
			}
		}
		#endregion /MonitorCeckBox_CheckedChanged

		#region OtherDeviceCheckBox1_CheckedChanged
		private void OtherDeviceCheckBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			if (graphicCardCheckBox.Checked == true)
			{
				graphicCardTextBox.Enabled = true;
				graphicCardPanel.Enabled = true;
				minusGraphicCardButton.Enabled = true;
				addGraphicCardButton.Enabled = true;
				unitPriceGraphicCardTextBox.Enabled = true;
				unitPriceGraphicCardPanel.Enabled = true;
			}
			else
			{
				graphicCardTextBox.Enabled = false;
				graphicCardTextBox.Text = "Graphic Card";
				graphicCardTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				graphicCardPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				GraphicCard = string.Empty;
				graphicCardPanel.Enabled = false;

				minusGraphicCardButton.Enabled = false;
				numberGraphicCardLabel.Text = "0";
				Number_GraphicCard = 0;
				addGraphicCardButton.Enabled = false;

				unitPriceGraphicCardTextBox.Enabled = false;
				unitPriceGraphicCardTextBox.Text = "قیمت واحد کارت گرافیک";
				unitPriceGraphicCardTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				unitPriceGraphicCardPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				UnitPrice_GraphicCard = 0;
				unitPriceGraphicCardPanel.Enabled = false;

				totalPriceGraphicCardLabel.Text = "قیمت کل کارت گرافیک";
				TotalPrice_GraphicCard = 0;
			}
		}
		#endregion /OtherDeviceCheckBox1_CheckedChanged

		#region OtherDeviceCheckBox2_CheckedChanged
		private void OtherDeviceCheckBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			if (graphicCardCheckBox.Checked == true)
			{
				graphicCardTextBox.Enabled = true;
				graphicCardPanel.Enabled = true;
				minusGraphicCardButton.Enabled = true;
				addGraphicCardButton.Enabled = true;
				unitPriceGraphicCardTextBox.Enabled = true;
				unitPriceGraphicCardPanel.Enabled = true;
			}
			else
			{
				graphicCardTextBox.Enabled = false;
				graphicCardTextBox.Text = "Graphic Card";
				graphicCardTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				graphicCardPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				GraphicCard = string.Empty;
				graphicCardPanel.Enabled = false;

				minusGraphicCardButton.Enabled = false;
				numberGraphicCardLabel.Text = "0";
				Number_GraphicCard = 0;
				addGraphicCardButton.Enabled = false;

				unitPriceGraphicCardTextBox.Enabled = false;
				unitPriceGraphicCardTextBox.Text = "قیمت واحد کارت گرافیک";
				unitPriceGraphicCardTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				unitPriceGraphicCardPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				UnitPrice_GraphicCard = 0;
				unitPriceGraphicCardPanel.Enabled = false;

				totalPriceGraphicCardLabel.Text = "قیمت کل کارت گرافیک";
				TotalPrice_GraphicCard = 0;
			}
		}
		#endregion /OtherDeviceCheckBox2_CheckedChanged

		#region OtherDeviceCheckBox3_CheckedChanged
		private void OtherDeviceCheckBox3_CheckedChanged(object sender, System.EventArgs e)
		{
			if (processorCheckBox.Checked == true)
			{
				processorTextBox.Enabled = true;
				processorPanel.Enabled = true;
				minusProssecButton.Enabled = true;
				addProcessButton.Enabled = true;
				unitPriceProcessorTextBox.Enabled = true;
				unitPriceProcessorPanel.Enabled = true;
			}
			else
			{
				processorTextBox.Enabled = false;
				processorPanel.Enabled = false;
				minusProssecButton.Enabled = false;
				addProcessButton.Enabled = false;
				unitPriceProcessorTextBox.Enabled = false;
				unitPriceProcessorPanel.Enabled = false;
			}
		}

		#endregion /OtherDeviceCheckBox3_CheckedChanged

		#region OtherDeviceCheckBox4_CheckedChanged
		private void OtherDeviceCheckBox4_CheckedChanged(object sender, System.EventArgs e)
		{
			if (graphicCardCheckBox.Checked == true)
			{
				graphicCardTextBox.Enabled = true;
				graphicCardPanel.Enabled = true;
				minusGraphicCardButton.Enabled = true;
				addGraphicCardButton.Enabled = true;
				unitPriceGraphicCardTextBox.Enabled = true;
				unitPriceGraphicCardPanel.Enabled = true;
			}
			else
			{
				graphicCardTextBox.Enabled = false;
				graphicCardTextBox.Text = "Graphic Card";
				graphicCardTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				graphicCardPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				GraphicCard = string.Empty;
				graphicCardPanel.Enabled = false;

				minusGraphicCardButton.Enabled = false;
				numberGraphicCardLabel.Text = "0";
				Number_GraphicCard = 0;
				addGraphicCardButton.Enabled = false;

				unitPriceGraphicCardTextBox.Enabled = false;
				unitPriceGraphicCardTextBox.Text = "قیمت واحد کارت گرافیک";
				unitPriceGraphicCardTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				unitPriceGraphicCardPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				UnitPrice_GraphicCard = 0;
				unitPriceGraphicCardPanel.Enabled = false;

				totalPriceGraphicCardLabel.Text = "قیمت کل کارت گرافیک";
				TotalPrice_GraphicCard = 0;
			}
		}
		#endregion /OtherDeviceCheckBox4_CheckedChanged

		#region OtherDeviceCheckBox5_CheckedChanged
		private void OtherDeviceCheckBox5_CheckedChanged(object sender, System.EventArgs e)
		{
			if (graphicCardCheckBox.Checked == true)
			{
				graphicCardTextBox.Enabled = true;
				graphicCardPanel.Enabled = true;
				minusGraphicCardButton.Enabled = true;
				addGraphicCardButton.Enabled = true;
				unitPriceGraphicCardTextBox.Enabled = true;
				unitPriceGraphicCardPanel.Enabled = true;
			}
			else
			{
				graphicCardTextBox.Enabled = false;
				graphicCardTextBox.Text = "Graphic Card";
				graphicCardTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				graphicCardPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				GraphicCard = string.Empty;
				graphicCardPanel.Enabled = false;

				minusGraphicCardButton.Enabled = false;
				numberGraphicCardLabel.Text = "0";
				Number_GraphicCard = 0;
				addGraphicCardButton.Enabled = false;

				unitPriceGraphicCardTextBox.Enabled = false;
				unitPriceGraphicCardTextBox.Text = "قیمت واحد کارت گرافیک";
				unitPriceGraphicCardTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				unitPriceGraphicCardPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				UnitPrice_GraphicCard = 0;
				unitPriceGraphicCardPanel.Enabled = false;

				totalPriceGraphicCardLabel.Text = "قیمت کل کارت گرافیک";
				TotalPrice_GraphicCard = 0;
			}
		}
		#endregion /OtherDeviceCheckBox5_CheckedChanged

		//-----

		#region Founctions
		//-----
		#region RestProperties
		private void RestProperties()
		{
			Price = string.Empty;
			UnitPrice_Processor = 0;
			TotalPrice_Processor = 0;

			UnitPrice_Processor = 0;
			TotalPrice_Processor = 0;

			UnitPrice_Processor = 0;
			TotalPrice_Processor = 0;

			UnitPrice_Processor = 0;
			TotalPrice_Processor = 0;

			UnitPrice_Processor = 0;
			TotalPrice_Processor = 0;

			UnitPrice_Processor = 0;
			TotalPrice_Processor = 0;

			UnitPrice_Processor = 0;
			TotalPrice_Processor = 0;

			UnitPrice_Processor = 0;
			TotalPrice_Processor = 0;

			UnitPrice_Processor = 0;
			TotalPrice_Processor = 0;

			UnitPrice_Processor = 0;
			TotalPrice_Processor = 0;

			UnitPrice_Processor = 0;
			TotalPrice_Processor = 0;

			UnitPrice_Processor = 0;
			TotalPrice_Processor = 0;

			UnitPrice_Processor = 0;
			TotalPrice_Processor = 0;

			UnitPrice_Processor = 0;
			TotalPrice_Processor = 0;
		}
		#endregion /RestProperties

		//-----
		#endregion /Founctions









		private void MouseTextBox_Enter(object sender, System.EventArgs e)
		{

		}

		private void MouseTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{

		}

		private void MouseTextBox_Leave(object sender, System.EventArgs e)
		{

		}

		private void MinusMouseButton_Click(object sender, System.EventArgs e)
		{

		}

		private void AddMiuseButton_Click(object sender, System.EventArgs e)
		{

		}

		private void UnitPriceMouseTextBox_Enter(object sender, System.EventArgs e)
		{

		}

		private void UnitPriceMouseTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{

		}

		private void UnitPriceMouseTextBox_Leave(object sender, System.EventArgs e)
		{

		}

		private void UnitPriceMouseTextBox_TextChanged(object sender, System.EventArgs e)
		{

		}

		private void SpeakerTextBox_Enter(object sender, System.EventArgs e)
		{

		}

		private void SpeakerTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{

		}

		private void SpeakerTextBox_Leave(object sender, System.EventArgs e)
		{

		}

		private void MinusSpeakerButton_Click(object sender, System.EventArgs e)
		{

		}

		private void AddSpeakerButton_Click(object sender, System.EventArgs e)
		{

		}

		private void UnitPriceSpeakerTextBox_Enter(object sender, System.EventArgs e)
		{

		}

		private void UnitPriceSpeakerTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{

		}

		private void UnitPriceSpeakerTextBox_Leave(object sender, System.EventArgs e)
		{

		}

		private void UnitPriceSpeakerTextBox_TextChanged(object sender, System.EventArgs e)
		{

		}

		private void MonitorTextBox_Enter(object sender, System.EventArgs e)
		{

		}

		private void MonitorTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{

		}

		private void MonitorTextBox_Leave(object sender, System.EventArgs e)
		{

		}

		private void MinusMonitorButton_Click(object sender, System.EventArgs e)
		{

		}

		private void AddMonitorButton_Click(object sender, System.EventArgs e)
		{

		}

		private void UnitPriceMonitorTextBox_Enter(object sender, System.EventArgs e)
		{

		}

		private void UnitPriceMonitorTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{

		}

		private void UnitPriceMonitorTextBox_Leave(object sender, System.EventArgs e)
		{

		}

		private void UnitPriceMonitorTextBox_TextChanged(object sender, System.EventArgs e)
		{

		}
	}
}
