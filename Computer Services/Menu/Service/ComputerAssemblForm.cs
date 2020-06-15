using System.Reflection.Emit;

namespace ComputerServices.Menu.Service
{
	public partial class ComputerAssemblForm : Infrastructure.BaseForm
	{
		public ComputerAssemblForm()
		{
			InitializeComponent();
		}

		[System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

		#region Properties

		public string SaveDate { get; set; }
		public string SaveTime { get; set; }

		public string Price { get; set; }

		public string MainBoard { get; set; }
		public int Number_MainBoard { get; set; }
		public int UnitPrice_MainBoard { get; set; }
		public int TotalPrice_MainBoard { get; set; }

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
		public int UnitPrice_Speaker { get; set; }
		public int TotalPrice_Speaker { get; set; }

		public string Monitor { get; set; }
		public int Number_Monitor { get; set; }
		public int UnitPrice_Monitor { get; set; }
		public int TotalPrice_Monitor { get; set; }

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
		public int UnitPrice_OtherDevice3 { get; set; }
		public int TotalPrice_OtherDevice3 { get; set; }

		public string OtherDevice4 { get; set; }
		public int Number_OtherDevice4 { get; set; }
		public int UnitPrice_OtherDevice4 { get; set; }
		public int TotalPrice_OtherDevice4 { get; set; }

		public string OtherDevice5 { get; set; }
		public int Number_OtherDevice5 { get; set; }
		public int UnitPrice_OtherDevice5 { get; set; }
		public int TotalPrice_OtherDevice5 { get; set; }

		#endregion /Properties

		//-----The beginning of the coding line.

		#region ComputerAssembelForm_Load
		private void ComputerAssembelForm_Load(object sender, System.EventArgs e)
		{
			dateLabel.Text = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)} - {Infrastructure.Utility.ShowTime()}";
			iInvoiceSerialText.Text = GeneratInvoiceNumber();
			ResetProperties();
			ButtonActivate();
		}
		#endregion /ComputerAssembelForm_Load

		#region ComputerAssembelForm_MouseDown
		private void ComputerAssembelForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		#endregion /ComputerAssembelForm_MouseDown

		#region CloseButton_Click
		private void CloseButton_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}
		#endregion /CloseButton_Click

		#region MinimizeButton_Click
		private void MinimizeButton_Click(object sender, System.EventArgs e)
		{
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
			this.SendToBack();
		}
		#endregion /MinimizeButton_Click

		#region MainBoard
		//-----
		#region MainBoardCheckBox_CheckedChanged
		private void MainBoardCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{
			if (mainBoardCheckBox.Checked == true)
			{
				mainBoardTextBox.Enabled = true;
				mainBoardPanel.Enabled = true;
				minusMainBoardButton.Enabled = true;
				addMainBoardButton.Enabled = true;
				unitPriceMainBoardTextBox.Enabled = true;
				unitPriceMainBoardPanel.Enabled = true;
			}
			else
			{
				mainBoardTextBox.Enabled = false;
				mainBoardTextBox.Text = "MainBoard";
				mainBoardTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				mainBoardPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				MainBoard = string.Empty;
				mainBoardPanel.Enabled = false;

				minusMainBoardButton.Enabled = false;
				numberMainBoardLabel.Text = "0";
				Number_MainBoard = 0;
				addMainBoardButton.Enabled = false;

				unitPriceMainBoardTextBox.Enabled = false;
				unitPriceMainBoardTextBox.Text = "قیمت واحد مادربرد";
				unitPriceMainBoardTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				unitPriceMainBoardPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				UnitPrice_MainBoard = 0;
				unitPriceMainBoardPanel.Enabled = false;

				totalPriceMainBoardLabel.Text = "قیمت کل مادربرد";
				TotalPrice_MainBoard = 0;
			}
		}
		#endregion /MainBoardCheckBox_CheckedChanged

		#region  MainBoardTextBox
		//-----
		#region MainBoardTextBox_Enter
		private void MainBoardTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.EnglishLanguage();
			mainBoardTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			mainBoardPanel.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(mainBoardTextBox.Text, "MainBoard") == 0)
			{
				mainBoardTextBox.Clear();
			}
		}
		#endregion /MainBoardTextBox_Enter

		#region MainBoardTextBox_KeyPress
		private void MainBoardTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.EnglishAndNumberTyping(e);
		}
		#endregion /MainBoardTextBox_KeyPress

		#region MainBoardTextBox_Leave
		private void MainBoardTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(mainBoardTextBox.Text) || string.Compare(mainBoardTextBox.Text, "MainBoard") == 0)
			{
				mainBoardTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				mainBoardPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();

				mainBoardTextBox.Text = "MainBoard";
				MainBoard = string.Empty;
			}
			else
			{
				mainBoardTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				mainBoardPanel.BackColor =
					Infrastructure.Utility.WhiteColor();

				MainBoard = mainBoardTextBox.Text;
			}
		}
		#endregion /MainBoardTextBox_Leave 
		//-----
		#endregion / MainBoardTextBox

		#region MinusMainBoardButton_Click
		private void MinusMainBoardButton_Click(object sender, System.EventArgs e)
		{
			if (Number_MainBoard <= 0)
			{
				return;
			}
			else
			{
				Number_MainBoard--;
				numberMainBoardLabel.Text = Number_MainBoard.ToString();

				if (string.IsNullOrWhiteSpace(unitPriceMainBoardTextBox.Text) || string.Compare(unitPriceMainBoardTextBox.Text, "قیمت واحد مادربرد") == 0)
				{
					return;
				}
				else
				{

					TotalPrice_MainBoard = UnitPrice_MainBoard * Number_MainBoard;

					if (Number_MainBoard == 0)
					{
						totalPriceMainBoardLabel.Text = $"0 تومان";
						return;
					}
					else
					{
						totalPriceMainBoardLabel.Text = $"{TotalPrice_MainBoard:#,0} تومان";
					}
				}
			}
		}
		#endregion /MinusMainBoardButton_Click

		#region AddMainBoardButton_Click
		private void AddMainBoardButton_Click(object sender, System.EventArgs e)
		{
			Number_MainBoard++;
			numberMainBoardLabel.Text = Number_MainBoard.ToString();

			if (string.IsNullOrWhiteSpace(unitPriceMainBoardTextBox.Text) || string.Compare(unitPriceMainBoardTextBox.Text, "قیمت واحد مادربرد") == 0)
			{
				return;
			}
			else
			{
				TotalPrice_MainBoard = UnitPrice_MainBoard * Number_MainBoard;

				if (Number_MainBoard == 0)
				{
					totalPriceMainBoardLabel.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceMainBoardLabel.Text = $"{TotalPrice_MainBoard:#,0} تومان";
				}
			}
		}
		#endregion /AddMainBoardButton_Click

		#region  UnitPriceMainBoard
		//-----
		#region UnitPriceMainBoardTextBox_Enter
		private void UnitPriceMainBoardTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.EnglishLanguage();
			unitPriceMainBoardTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			unitPriceMainBoardPanel.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(unitPriceMainBoardTextBox.Text, "قیمت واحد مادربرد") == 0)
			{
				unitPriceMainBoardTextBox.Clear();
				unitPriceMainBoardTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				unitPriceMainBoardTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				return;
			}
		}
		#endregion /UnitPriceMainBoardTextBox_Enter

		#region UnitPriceMainBoardTextBox_KeyPress
		private void UnitPriceMainBoardTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /UnitPriceMainBoardTextBox_KeyPress

		#region UnitPriceMainBoardTextBox_Leave
		private void UnitPriceMainBoardTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(unitPriceMainBoardTextBox.Text) || string.Compare(unitPriceMainBoardTextBox.Text, "قیمت واحد مادربرد") == 0)
			{
				unitPriceMainBoardTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				unitPriceMainBoardPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();

				unitPriceMainBoardTextBox.Text = "قیمت واحد مادربرد";
				unitPriceMainBoardTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				unitPriceMainBoardTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				totalPriceMainBoardLabel.Text = "قیمت کل مادربرد";
				totalPriceMainBoardLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				totalPriceMainBoardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
				UnitPrice_MainBoard = 0;
			}
			else
			{
				unitPriceMainBoardTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				unitPriceMainBoardPanel.BackColor =
					Infrastructure.Utility.WhiteColor();
				unitPriceMainBoardTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				unitPriceMainBoardTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				unitPriceMainBoardTextBox.Text = $"{UnitPrice_MainBoard:#,0} تومان";
			}
		}
		#endregion /UnitPriceMainBoardTextBox_Leave

		#region UnitPriceMainBoardTextBox_TextChanged
		private void UnitPriceMainBoardTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(unitPriceMainBoardTextBox.Text) || string.Compare(unitPriceMainBoardTextBox.Text, "قیمت واحد مادربرد") == 0)
			{
				totalPriceMainBoardLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				totalPriceMainBoardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
				totalPriceMainBoardLabel.Text = "قیمت کل مادربرد";
				return;
			}
			else if (string.Compare(unitPriceMainBoardTextBox.Text, "تومان") == 0 || string.Compare(unitPriceMainBoardTextBox.Text, " تومان") == 0 || string.Compare(unitPriceMainBoardTextBox.Text, "ومان") == 0 || string.Compare(unitPriceMainBoardTextBox.Text, "مان") == 0 || string.Compare(unitPriceMainBoardTextBox.Text, "ان") == 0 || string.Compare(unitPriceMainBoardTextBox.Text, "ن") == 0)
			{
				UnitPrice_MainBoard = 0;
				TotalPrice_MainBoard = UnitPrice_MainBoard * Number_MainBoard;

				if (Number_MainBoard == 0)
				{
					totalPriceMainBoardLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceMainBoardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceMainBoardLabel.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceMainBoardLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceMainBoardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceMainBoardLabel.Text = $"{TotalPrice_MainBoard:#,0} تومان";
				}
				return;

			}
			else if (unitPriceMainBoardTextBox.Text.Contains("تومان"))
			{
				Price = unitPriceMainBoardTextBox.Text.Replace("تومان", string.Empty).Trim();
				UnitPrice_MainBoard = int.Parse(Price.Replace(",", string.Empty).Trim());
				TotalPrice_MainBoard = UnitPrice_MainBoard * Number_MainBoard;

				if (Number_MainBoard == 0)
				{
					totalPriceMainBoardLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceMainBoardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceMainBoardLabel.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceMainBoardLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceMainBoardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceMainBoardLabel.Text = $"{TotalPrice_MainBoard:#,0} تومان";
				}
				return;
			}
			else
			{
				Price = unitPriceMainBoardTextBox.Text.Replace("تومان", string.Empty).Trim();
				UnitPrice_MainBoard = int.Parse(Price.Replace(",", string.Empty).Trim());
				TotalPrice_MainBoard = UnitPrice_MainBoard * Number_MainBoard;

				if (Number_MainBoard == 0)
				{
					totalPriceMainBoardLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceMainBoardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceMainBoardLabel.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceMainBoardLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceMainBoardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceMainBoardLabel.Text = $"{TotalPrice_MainBoard:#,0} تومان";
				}
			}
		}
		#endregion /UnitPriceMainBoardTextBox_TextChanged 
		//-----
		#endregion / UnitPriceMainBoard

		#region TotalPriceMainBoardLabel_TextChanged
		private void TotalPriceMainBoardLabel_TextChanged(object sender, System.EventArgs e)
		{
			if (string.Compare(totalPriceMainBoardLabel.Text, "قیمت کل مادربرد") == 0)
			{
				TotalPrice_MainBoard = 0;
				SumTotoalPrice(TotalPrice_MainBoard, TotalPrice_Processor, TotalPrice_RAM, TotalPrice_HDD, TotalPrice_DVDROM, TotalPrice_GraphicCard, TotalPrice_Keyboard, TotalPrice_Mouse, TotalPrice_Speaker, TotalPrice_Monitor, TotalPrice_OtherDevice1, TotalPrice_OtherDevice2, TotalPrice_OtherDevice3, TotalPrice_OtherDevice4, TotalPrice_OtherDevice5);

				return;
			}
			else
			{
				SumTotoalPrice(TotalPrice_MainBoard, TotalPrice_Processor, TotalPrice_RAM, TotalPrice_HDD, TotalPrice_DVDROM, TotalPrice_GraphicCard, TotalPrice_Keyboard, TotalPrice_Mouse, TotalPrice_Speaker, TotalPrice_Monitor, TotalPrice_OtherDevice1, TotalPrice_OtherDevice2, TotalPrice_OtherDevice3, TotalPrice_OtherDevice4, TotalPrice_OtherDevice5);
			}
		}
		#endregion /TotalPriceMainBoardLabel_TextChanged
		//-----
		#endregion

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
				numberProcessorLabel.Text = "0";
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
				numberProcessorLabel.Text = Number_Processor.ToString();

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
						totalPriceProcessorLabel.Text = $"{TotalPrice_Processor:#,0} تومان";
					}
				}
			}

		}
		#endregion /MinusProssecButton_Click

		#region AddProcessButton_Click
		private void AddProcessButton_Click(object sender, System.EventArgs e)
		{
			Number_Processor++;
			numberProcessorLabel.Text = Number_Processor.ToString();

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
					totalPriceProcessorLabel.Text = $"{TotalPrice_Processor:#,0} تومان";
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

		#region TotalPriceProcessorLabel_TextChanged
		private void TotalPriceProcessorLabel_TextChanged(object sender, System.EventArgs e)
		{
			if (string.Compare(totalPriceProcessorLabel.Text, "قیمت کل پردازنده") == 0)
			{
				TotalPrice_Processor = 0;
				SumTotoalPrice(TotalPrice_MainBoard, TotalPrice_Processor, TotalPrice_RAM, TotalPrice_HDD, TotalPrice_DVDROM, TotalPrice_GraphicCard, TotalPrice_Keyboard, TotalPrice_Mouse, TotalPrice_Speaker, TotalPrice_Monitor, TotalPrice_OtherDevice1, TotalPrice_OtherDevice2, TotalPrice_OtherDevice3, TotalPrice_OtherDevice4, TotalPrice_OtherDevice5);
				return;
			}
			else
			{
				SumTotoalPrice(TotalPrice_MainBoard, TotalPrice_Processor, TotalPrice_RAM, TotalPrice_HDD, TotalPrice_DVDROM, TotalPrice_GraphicCard, TotalPrice_Keyboard, TotalPrice_Mouse, TotalPrice_Speaker, TotalPrice_Monitor, TotalPrice_OtherDevice1, TotalPrice_OtherDevice2, TotalPrice_OtherDevice3, TotalPrice_OtherDevice4, TotalPrice_OtherDevice5);
			}
		}
		#endregion /TotalPriceProcessorLabel_TextChanged

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

		#region TotalPriceRAMLabel_TextChanged
		private void TotalPriceRAMLabel_TextChanged(object sender, System.EventArgs e)
		{
			if (string.Compare(totalPriceRAMLabel.Text, "قیمت کل رم") == 0)
			{
				TotalPrice_RAM = 0;
				SumTotoalPrice(TotalPrice_MainBoard, TotalPrice_Processor, TotalPrice_RAM, TotalPrice_HDD, TotalPrice_DVDROM, TotalPrice_GraphicCard, TotalPrice_Keyboard, TotalPrice_Mouse, TotalPrice_Speaker, TotalPrice_Monitor, TotalPrice_OtherDevice1, TotalPrice_OtherDevice2, TotalPrice_OtherDevice3, TotalPrice_OtherDevice4, TotalPrice_OtherDevice5);

				return;
			}
			else
			{
				SumTotoalPrice(TotalPrice_MainBoard, TotalPrice_Processor, TotalPrice_RAM, TotalPrice_HDD, TotalPrice_DVDROM, TotalPrice_GraphicCard, TotalPrice_Keyboard, TotalPrice_Mouse, TotalPrice_Speaker, TotalPrice_Monitor, TotalPrice_OtherDevice1, TotalPrice_OtherDevice2, TotalPrice_OtherDevice3, TotalPrice_OtherDevice4, TotalPrice_OtherDevice5);
			}
		}
		#endregion /TotalPriceRAMLabel_TextChanged
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

				if (string.IsNullOrWhiteSpace(unitPriceHDDTextBox.Text) || string.Compare(unitPriceHDDTextBox.Text, "قیمت واحد هارد دیسک") == 0)
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

			if (string.IsNullOrWhiteSpace(unitPriceHDDTextBox.Text) || string.Compare(unitPriceHDDTextBox.Text, "قیمت واحد هارد دیسک") == 0)
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
				totalPriceHDDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
				totalPriceHDDLabel.Text = "قیمت کل هارد دیسک";
				return;
			}
			else if (string.Compare(unitPriceHDDTextBox.Text, "تومان") == 0 || string.Compare(unitPriceHDDTextBox.Text, " تومان") == 0 || string.Compare(unitPriceHDDTextBox.Text, "ومان") == 0 || string.Compare(unitPriceHDDTextBox.Text, "مان") == 0 || string.Compare(unitPriceHDDTextBox.Text, "ان") == 0 || string.Compare(unitPriceHDDTextBox.Text, "ن") == 0)
			{
				UnitPrice_HDD = 0;

				TotalPrice_HDD = UnitPrice_HDD * Number_HDD;

				if (Number_HDD == 0)
				{
					totalPriceHDDLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceHDDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
					totalPriceHDDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceHDDLabel.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceHDDLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceHDDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
					totalPriceHDDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceHDDLabel.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceHDDLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceHDDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceHDDLabel.Text = $"{TotalPrice_HDD:#,0} تومان";
				}
			}
		}
		#endregion /UnitPriceHDDTextBox_TextChanged 
		//-----
		#endregion /UnitPriceHDDTextBox

		#region TotalPriceHDDLabel_TextChanged
		private void TotalPriceHDDLabel_TextChanged(object sender, System.EventArgs e)
		{
			if (string.Compare(totalPriceHDDLabel.Text, "قیمت کل هارد دیسک") == 0)
			{
				TotalPrice_HDD = 0;
				SumTotoalPrice(TotalPrice_MainBoard, TotalPrice_Processor, TotalPrice_RAM, TotalPrice_HDD, TotalPrice_DVDROM, TotalPrice_GraphicCard, TotalPrice_Keyboard, TotalPrice_Mouse, TotalPrice_Speaker, TotalPrice_Monitor, TotalPrice_OtherDevice1, TotalPrice_OtherDevice2, TotalPrice_OtherDevice3, TotalPrice_OtherDevice4, TotalPrice_OtherDevice5);
				return;
			}
			else
			{
				SumTotoalPrice(TotalPrice_MainBoard, TotalPrice_Processor, TotalPrice_RAM, TotalPrice_HDD, TotalPrice_DVDROM, TotalPrice_GraphicCard, TotalPrice_Keyboard, TotalPrice_Mouse, TotalPrice_Speaker, TotalPrice_Monitor, TotalPrice_OtherDevice1, TotalPrice_OtherDevice2, TotalPrice_OtherDevice3, TotalPrice_OtherDevice4, TotalPrice_OtherDevice5);
			}
		}
		#endregion /TotalPriceHDDLabel_TextChanged
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
				totalPriceDVDRomLabel.Text = "قیمت کل دی وی دی رام";
				return;
			}
			else if (string.Compare(unitPriceDVDRomTextBox.Text, "تومان") == 0 || string.Compare(unitPriceDVDRomTextBox.Text, " تومان") == 0 || string.Compare(unitPriceDVDRomTextBox.Text, "ومان") == 0 || string.Compare(unitPriceDVDRomTextBox.Text, "مان") == 0 || string.Compare(unitPriceDVDRomTextBox.Text, "ان") == 0 || string.Compare(unitPriceDVDRomTextBox.Text, "ن") == 0)
			{
				UnitPrice_DVDROM = 0;

				TotalPrice_DVDROM = UnitPrice_DVDROM * Number_DVDROM;

				if (Number_DVDROM == 0)
				{
					totalPriceDVDRomLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceDVDRomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceDVDRomLabel.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceDVDRomLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceDVDRomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceDVDRomLabel.Text = $"{TotalPrice_DVDROM:#,0} تومان";
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
					totalPriceDVDRomLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceDVDRomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceDVDRomLabel.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceDVDRomLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceDVDRomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceDVDRomLabel.Text = $"{TotalPrice_DVDROM:#,0} تومان";
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
					totalPriceDVDRomLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceDVDRomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceDVDRomLabel.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceDVDRomLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceDVDRomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceDVDRomLabel.Text = $"{TotalPrice_DVDROM:#,0} تومان";
				}
			}
		}
		#endregion /UnitPriceDVDRomTextBox_TextChanged
		//-----
		#endregion /UnitPriceDVDRomTextBox

		#region TotalPriceDVDRomLabel_TextChanged
		private void TotalPriceDVDRomLabel_TextChanged(object sender, System.EventArgs e)
		{
			if (string.Compare(totalPriceDVDRomLabel.Text, "قیمت کل دی وی دی رام") == 0)
			{
				TotalPrice_DVDROM = 0;
				SumTotoalPrice(TotalPrice_MainBoard, TotalPrice_Processor, TotalPrice_RAM, TotalPrice_HDD, TotalPrice_DVDROM, TotalPrice_GraphicCard, TotalPrice_Keyboard, TotalPrice_Mouse, TotalPrice_Speaker, TotalPrice_Monitor, TotalPrice_OtherDevice1, TotalPrice_OtherDevice2, TotalPrice_OtherDevice3, TotalPrice_OtherDevice4, TotalPrice_OtherDevice5);
				return;
			}
			else
			{
				SumTotoalPrice(TotalPrice_MainBoard, TotalPrice_Processor, TotalPrice_RAM, TotalPrice_HDD, TotalPrice_DVDROM, TotalPrice_GraphicCard, TotalPrice_Keyboard, TotalPrice_Mouse, TotalPrice_Speaker, TotalPrice_Monitor, TotalPrice_OtherDevice1, TotalPrice_OtherDevice2, TotalPrice_OtherDevice3, TotalPrice_OtherDevice4, TotalPrice_OtherDevice5);
			}
		}
		#endregion /TotalPriceDVDRomLabel_TextChanged
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
				unitPriceGraphicCardTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				unitPriceGraphicCardTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
				unitPriceGraphicCardTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				unitPriceGraphicCardTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				totalPriceGraphicCardLabel.Text = "قیمت کل کارت گرافیک";
				totalPriceGraphicCardLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				totalPriceGraphicCardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
				UnitPrice_GraphicCard = 0;
			}
			else
			{
				unitPriceGraphicCardTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				unitPriceGraphicCardPanel.BackColor =
					Infrastructure.Utility.WhiteColor();
				unitPriceGraphicCardTextBox.Text = $"{UnitPrice_GraphicCard:#,0} تومان";
				unitPriceGraphicCardTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				unitPriceGraphicCardTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			}
		}

		#endregion /UnitPriceGraphicCardTextBox_Leave

		#region UnitPriceGraphicCardTextBox_TextChanged
		private void UnitPriceGraphicCardTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(unitPriceGraphicCardTextBox.Text) || string.Compare(unitPriceGraphicCardTextBox.Text, "قیمت واحد کارت گرافیک") == 0)
			{
				totalPriceGraphicCardLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				totalPriceGraphicCardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
				totalPriceGraphicCardLabel.Text = "قیمت کل کارت گرافیک";
				return;
			}
			else if (string.Compare(unitPriceGraphicCardTextBox.Text, "تومان") == 0 || string.Compare(unitPriceGraphicCardTextBox.Text, " تومان") == 0 || string.Compare(unitPriceGraphicCardTextBox.Text, "ومان") == 0 || string.Compare(unitPriceGraphicCardTextBox.Text, "مان") == 0 || string.Compare(unitPriceGraphicCardTextBox.Text, "ان") == 0 || string.Compare(unitPriceGraphicCardTextBox.Text, "ن") == 0)
			{
				UnitPrice_GraphicCard = 0;

				TotalPrice_GraphicCard = UnitPrice_GraphicCard * Number_GraphicCard;

				if (Number_GraphicCard == 0)
				{
					totalPriceGraphicCardLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceGraphicCardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceGraphicCardLabel.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceGraphicCardLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceGraphicCardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceGraphicCardLabel.Text = $"{TotalPrice_GraphicCard:#,0} تومان ";
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
					totalPriceGraphicCardLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceGraphicCardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceGraphicCardLabel.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceGraphicCardLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceGraphicCardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceGraphicCardLabel.Text = $"{TotalPrice_GraphicCard:#,0} تومان";
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
					totalPriceGraphicCardLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceGraphicCardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceGraphicCardLabel.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceGraphicCardLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceGraphicCardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceGraphicCardLabel.Text = $"{TotalPrice_GraphicCard:#,0} تومان";
				}
			}
		}

		#endregion /UnitPriceGraphicCardTextBox_TextChanged 
		//-----
		#endregion /UnitPriceGraphicCardTextBox

		#region TotalPriceGraphicCardLabel_TextChanged
		private void TotalPriceGraphicCardLabel_TextChanged(object sender, System.EventArgs e)
		{
			if (string.Compare(totalPriceGraphicCardLabel.Text, "قیمت کل کارت گرافیک") == 0)
			{
				TotalPrice_GraphicCard = 0;
				SumTotoalPrice(TotalPrice_MainBoard, TotalPrice_Processor, TotalPrice_RAM, TotalPrice_HDD, TotalPrice_DVDROM, TotalPrice_GraphicCard, TotalPrice_Keyboard, TotalPrice_Mouse, TotalPrice_Speaker, TotalPrice_Monitor, TotalPrice_OtherDevice1, TotalPrice_OtherDevice2, TotalPrice_OtherDevice3, TotalPrice_OtherDevice4, TotalPrice_OtherDevice5);
				return;
			}
			else
			{
				SumTotoalPrice(TotalPrice_MainBoard, TotalPrice_Processor, TotalPrice_RAM, TotalPrice_HDD, TotalPrice_DVDROM, TotalPrice_GraphicCard, TotalPrice_Keyboard, TotalPrice_Mouse, TotalPrice_Speaker, TotalPrice_Monitor, TotalPrice_OtherDevice1, TotalPrice_OtherDevice2, TotalPrice_OtherDevice3, TotalPrice_OtherDevice4, TotalPrice_OtherDevice5);
			}
		}
		#endregion /TotalPriceGraphicCardLabel_TextChanged
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

				if (string.IsNullOrWhiteSpace(unitPriceKeyboardTextBox.Text) || string.Compare(unitPriceKeyboardTextBox.Text, "قیمت واحد صفحه کلید") == 0)
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

			if (string.IsNullOrWhiteSpace(unitPriceKeyboardTextBox.Text) || string.Compare(unitPriceKeyboardTextBox.Text, "قیمت واحد صفحه کلید") == 0)
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
				unitPriceKeyboardTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				unitPriceKeyboardTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
				unitPriceKeyboardTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				unitPriceKeyboardTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				totalPriceKeyboardLabel.Text = "قیمت کل صفحه کلید";
				totalPriceKeyboardLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				totalPriceKeyboardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
				UnitPrice_Keyboard = 0;
			}
			else
			{
				unitPriceKeyboardTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				unitPriceKeyboardPanel.BackColor =
					Infrastructure.Utility.WhiteColor();
				unitPriceKeyboardTextBox.Text = $"{UnitPrice_Keyboard:#,0} تومان";
				unitPriceKeyboardTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				unitPriceKeyboardTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			}
		}
		#endregion /UnitPriceKeyboardTextBox_Leave

		#region UnitPriceKeyboardTextBox_TextChanged
		private void UnitPriceKeyboardTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(unitPriceKeyboardTextBox.Text) || string.Compare(unitPriceKeyboardTextBox.Text, "قیمت واحد صفحه کلید") == 0)
			{
				totalPriceKeyboardLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				totalPriceKeyboardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
				totalPriceKeyboardLabel.Text = "قیمت کل صفحه کلید";
				return;
			}
			else if (string.Compare(unitPriceKeyboardTextBox.Text, "تومان") == 0 || string.Compare(unitPriceKeyboardTextBox.Text, " تومان") == 0 || string.Compare(unitPriceKeyboardTextBox.Text, "ومان") == 0 || string.Compare(unitPriceKeyboardTextBox.Text, "مان") == 0 || string.Compare(unitPriceKeyboardTextBox.Text, "ان") == 0 || string.Compare(unitPriceKeyboardTextBox.Text, "ن") == 0)
			{
				UnitPrice_Keyboard = 0;

				TotalPrice_Keyboard = UnitPrice_Keyboard * Number_Keyboard;

				if (Number_Keyboard == 0)
				{
					totalPriceKeyboardLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceKeyboardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceKeyboardLabel.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceKeyboardLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceKeyboardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceKeyboardLabel.Text = $"{TotalPrice_Keyboard:#,0} تومان";
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
					totalPriceKeyboardLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceKeyboardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceKeyboardLabel.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceKeyboardLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceKeyboardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceKeyboardLabel.Text = $"{TotalPrice_Keyboard:#,0} تومان";
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
					totalPriceKeyboardLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceKeyboardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceKeyboardLabel.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceKeyboardLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceKeyboardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceKeyboardLabel.Text = $"{TotalPrice_Keyboard:#,0} تومان";
				}
			}
		}
		#endregion /UnitPriceKeyboardTextBox_TextChanged 
		//-----
		#endregion /UnitPriceKeyboardTextBox

		#region TotalPriceKeyboardLabel_TextChanged
		private void TotalPriceKeyboardLabel_TextChanged(object sender, System.EventArgs e)
		{
			if (string.Compare(totalPriceKeyboardLabel.Text, "قیمت کل صفحه کلید") == 0)
			{
				TotalPrice_Keyboard = 0;
				SumTotoalPrice(TotalPrice_MainBoard, TotalPrice_Processor, TotalPrice_RAM, TotalPrice_HDD, TotalPrice_DVDROM, TotalPrice_GraphicCard, TotalPrice_Keyboard, TotalPrice_Mouse, TotalPrice_Speaker, TotalPrice_Monitor, TotalPrice_OtherDevice1, TotalPrice_OtherDevice2, TotalPrice_OtherDevice3, TotalPrice_OtherDevice4, TotalPrice_OtherDevice5);
				return;
			}
			else
			{
				SumTotoalPrice(TotalPrice_MainBoard, TotalPrice_Processor, TotalPrice_RAM, TotalPrice_HDD, TotalPrice_DVDROM, TotalPrice_GraphicCard, TotalPrice_Keyboard, TotalPrice_Mouse, TotalPrice_Speaker, TotalPrice_Monitor, TotalPrice_OtherDevice1, TotalPrice_OtherDevice2, TotalPrice_OtherDevice3, TotalPrice_OtherDevice4, TotalPrice_OtherDevice5);
			}
		}
		#endregion /TotalPriceKeyboardLabel_TextChanged
		//-----
		#endregion /Keyboard

		#region Mouse
		//-----
		#region MouseCheckBox_CheckedChanged
		private void MouseCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{
			if (mouseCheckBox.Checked == true)
			{
				mouseTextBox.Enabled = true;
				mousePanel.Enabled = true;
				minusMouseButton.Enabled = true;
				addMouseButton.Enabled = true;
				unitPriceMouseTextBox.Enabled = true;
				unitPriceMousePanel.Enabled = true;
			}
			else
			{
				mouseTextBox.Enabled = false;
				mouseTextBox.Text = "Mouse";
				mouseTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				mousePanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				Mouse = string.Empty;
				mousePanel.Enabled = false;

				minusMouseButton.Enabled = false;
				numberMouseLabel.Text = "0";
				Number_Mouse = 0;
				addMouseButton.Enabled = false;

				unitPriceMouseTextBox.Enabled = false;
				unitPriceMouseTextBox.Text = "قیمت واحد ماوس";
				unitPriceMouseTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				unitPriceMousePanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				UnitPrice_Mouse = 0;
				unitPriceMousePanel.Enabled = false;

				totalPriceMouseLabel.Text = "قیمت کل ماس";
				TotalPrice_Mouse = 0;
			}
		}
		#endregion /MouseCheckBox_CheckedChanged

		#region MouseTextBox
		//-----
		#region MouseTextBox_Enter
		private void MouseTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.EnglishLanguage();
			mouseTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			mousePanel.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(mouseTextBox.Text, "Mouse") == 0)
			{
				mouseTextBox.Clear();
			}
		}

		#endregion /MouseTextBox_Enter

		#region MouseTextBox_KeyPress
		private void MouseTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.EnglishAndNumberTyping(e);
		}
		#endregion /MouseTextBox_KeyPress

		#region MouseTextBox_Leave
		private void MouseTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(mouseTextBox.Text) || string.Compare(mouseTextBox.Text, "Mouse") == 0)
			{
				mouseTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				mousePanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();

				mouseTextBox.Text = "Mouse";
				Mouse = string.Empty;
			}
			else
			{
				mouseTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				mousePanel.BackColor =
					Infrastructure.Utility.WhiteColor();

				Mouse = mouseTextBox.Text;
			}
		}
		#endregion /MouseTextBox_Leave 
		//-----
		#endregion /MouseTextBox

		#region MinusMouseButton_Click
		private void MinusMouseButton_Click(object sender, System.EventArgs e)
		{
			if (Number_Mouse <= 0)
			{
				return;
			}
			else
			{
				Number_Mouse--;
				numberMouseLabel.Text = Number_Mouse.ToString();

				if (string.IsNullOrWhiteSpace(unitPriceMouseTextBox.Text) || string.Compare(unitPriceMouseTextBox.Text, "قیمت واحد ماوس") == 0)
				{
					return;
				}
				else
				{
					TotalPrice_Mouse = UnitPrice_Mouse * Number_Mouse;

					if (Number_Mouse == 0)
					{
						totalPriceMouseLabel.Text = $"0 تومان";
						return;
					}
					else
					{
						totalPriceMouseLabel.Text = $"{TotalPrice_Mouse:#,0} تومان";
					}
				}
			}
		}
		#endregion /MinusMouseButton_Click

		#region AddMiuseButton_Click
		private void AddMouseButton_Click(object sender, System.EventArgs e)
		{
			Number_Mouse++;
			numberMouseLabel.Text = Number_Mouse.ToString();

			if (string.IsNullOrWhiteSpace(unitPriceMouseTextBox.Text) || string.Compare(unitPriceMouseTextBox.Text, "قیمت واحد ماوس") == 0)
			{
				return;
			}
			else
			{
				TotalPrice_Mouse = UnitPrice_Mouse * Number_Mouse;

				if (Number_Mouse == 0)
				{
					totalPriceMouseLabel.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceMouseLabel.Text = $"{TotalPrice_Mouse:#,0} تومان";
				}
			}
		}
		#endregion /AddMiuseButton_Click

		#region UnitPriceMouseTextBox
		//-----
		#region UnitPriceMouseTextBox_Enter
		private void UnitPriceMouseTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.EnglishLanguage();
			unitPriceMouseTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			unitPriceMousePanel.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(unitPriceMouseTextBox.Text, "قیمت واحد ماوس") == 0)
			{
				unitPriceMouseTextBox.Clear();
				unitPriceMouseTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				unitPriceMouseTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				return;
			}
		}
		#endregion /UnitPriceMouseTextBox_Enter

		#region UnitPriceMouseTextBox_KeyPress
		private void UnitPriceMouseTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion UnitPriceMouseTextBox_KeyPress

		#region UnitPriceMouseTextBox_Leave
		private void UnitPriceMouseTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(unitPriceMouseTextBox.Text) || string.Compare(unitPriceMouseTextBox.Text, "قیمت واحد ماوس") == 0)
			{
				unitPriceMouseTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				unitPriceMousePanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();

				unitPriceMouseTextBox.Text = "قیمت واحد ماوس";
				unitPriceMouseTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				unitPriceMouseTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				totalPriceMouseLabel.Text = "قیمت کل ماوس";
				totalPriceMouseLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				totalPriceMouseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
				UnitPrice_Mouse = 0;
			}
			else
			{
				unitPriceMouseTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				unitPriceMousePanel.BackColor =
					Infrastructure.Utility.WhiteColor();
				unitPriceMouseTextBox.Text = $"{UnitPrice_Keyboard:#,0} تومان";
				unitPriceMouseTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				unitPriceMouseTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			}
		}
		#endregion /UnitPriceMouseTextBox_Leave

		#region UnitPriceMouseTextBox_TextChanged
		private void UnitPriceMouseTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(unitPriceMouseTextBox.Text) || string.Compare(unitPriceMouseTextBox.Text, "قیمت واحد ماوس") == 0)
			{
				totalPriceMouseLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				totalPriceMouseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
				TotalPrice_Mouse = 0;
				totalPriceMouseLabel.Text = "قیمت کل ماوس";
				return;
			}
			else if (string.Compare(unitPriceMouseTextBox.Text, "تومان") == 0 || string.Compare(unitPriceMouseTextBox.Text, " تومان") == 0 || string.Compare(unitPriceMouseTextBox.Text, "ومان") == 0 || string.Compare(unitPriceMouseTextBox.Text, "مان") == 0 || string.Compare(unitPriceMouseTextBox.Text, "ان") == 0 || string.Compare(unitPriceMouseTextBox.Text, "ن") == 0)
			{
				Number_Mouse = 0;

				TotalPrice_Mouse = UnitPrice_Mouse * Number_Mouse;

				if (Number_Mouse == 0)
				{
					totalPriceMouseLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceMouseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceMouseLabel.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceMouseLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceMouseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceMouseLabel.Text = $"{TotalPrice_Mouse:#,0} تومان";
				}
				return;

			}
			else if (unitPriceMouseTextBox.Text.Contains("تومان"))
			{
				Price = unitPriceMouseTextBox.Text.Replace("تومان", string.Empty).Trim();
				UnitPrice_Mouse = int.Parse(Price.Replace(",", string.Empty).Trim());
				TotalPrice_Mouse = UnitPrice_Mouse * Number_Mouse;

				if (Number_Mouse == 0)
				{
					totalPriceMouseLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceMouseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceMouseLabel.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceMouseLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceMouseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceMouseLabel.Text = $"{TotalPrice_Mouse:#,0} تومان";
				}
				return;
			}
			else
			{
				Price = unitPriceMouseTextBox.Text.Replace("تومان", string.Empty).Trim();
				UnitPrice_Mouse = int.Parse(Price.Replace(",", string.Empty).Trim());
				TotalPrice_Mouse = UnitPrice_Mouse * Number_Mouse;

				if (Number_Mouse == 0)
				{
					totalPriceMouseLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceMouseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceMouseLabel.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceMouseLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceMouseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceMouseLabel.Text = $"{TotalPrice_Mouse:#,0} تومان";
				}
			}
		}
		#endregion /UnitPriceMouseTextBox_TextChanged 
		//-----
		#endregion /UnitPriceMouseTextBox

		#region TotalPriceMouseLabel_TextChanged
		private void TotalPriceMouseLabel_TextChanged(object sender, System.EventArgs e)
		{
			if (string.Compare(totalPriceMouseLabel.Text, "قیمت کل ماوس") == 0)
			{
				TotalPrice_Mouse = 0;
				SumTotoalPrice(TotalPrice_MainBoard, TotalPrice_Processor, TotalPrice_RAM, TotalPrice_HDD, TotalPrice_DVDROM, TotalPrice_GraphicCard, TotalPrice_Keyboard, TotalPrice_Mouse, TotalPrice_Speaker, TotalPrice_Monitor, TotalPrice_OtherDevice1, TotalPrice_OtherDevice2, TotalPrice_OtherDevice3, TotalPrice_OtherDevice4, TotalPrice_OtherDevice5);
				return;
			}
			else
			{
				SumTotoalPrice(TotalPrice_MainBoard, TotalPrice_Processor, TotalPrice_RAM, TotalPrice_HDD, TotalPrice_DVDROM, TotalPrice_GraphicCard, TotalPrice_Keyboard, TotalPrice_Mouse, TotalPrice_Speaker, TotalPrice_Monitor, TotalPrice_OtherDevice1, TotalPrice_OtherDevice2, TotalPrice_OtherDevice3, TotalPrice_OtherDevice4, TotalPrice_OtherDevice5);
			}
		}
		#endregion /TotalPriceMouseLabel_TextChanged
		//-----
		#endregion /Mouse

		#region Speaker
		//-----
		#region SpeakerCheckBox_CheckedChanged
		private void SpeakerCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{
			if (speakerCheckBox.Checked == true)
			{
				speakerTextBox.Enabled = true;
				speakerPanel.Enabled = true;
				minusSpeakerButton.Enabled = true;
				addSpeakerButton.Enabled = true;
				unitPriceSpeakerTextBox.Enabled = true;
				unitPriceSpeakerPanel.Enabled = true;
			}
			else
			{
				speakerTextBox.Enabled = false;
				speakerTextBox.Text = "Speaker";
				speakerTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				speakerPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				Speaker = string.Empty;
				speakerPanel.Enabled = false;

				minusSpeakerButton.Enabled = false;
				numberSpeakerLabel.Text = "0";
				Number_Speaker = 0;
				addSpeakerButton.Enabled = false;

				unitPriceSpeakerTextBox.Enabled = false;
				unitPriceSpeakerTextBox.Text = "قیمت واحد بلندگو";
				unitPriceSpeakerTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				unitPriceSpeakerPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				UnitPrice_Speaker = 0;
				unitPriceSpeakerPanel.Enabled = false;

				totalPriceSpeakerLabel.Text = "قیمت کل بلندگو";
				TotalPrice_Speaker = 0;
			}
		}
		#endregion /SpeakerCheckBox_CheckedChanged

		#region SpeakerTextBox
		//-----
		#region SpeakerTextBox_Enter
		private void SpeakerTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.EnglishLanguage();
			speakerTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			speakerPanel.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(speakerTextBox.Text, "Speaker") == 0)
			{
				speakerTextBox.Clear();
			}
		}

		#endregion /SpeakerTextBox_Enter

		#region SpeakerTextBox_KeyPress
		private void SpeakerTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.EnglishAndNumberTyping(e);
		}

		#endregion /SpeakerTextBox_KeyPress

		#region SpeakerTextBox_Leave
		private void SpeakerTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(speakerTextBox.Text) || string.Compare(speakerTextBox.Text, "Speaker") == 0)
			{
				speakerTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				speakerPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();

				speakerTextBox.Text = "Speaker";
				Speaker = string.Empty;
			}
			else
			{
				speakerTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				speakerPanel.BackColor =
					Infrastructure.Utility.WhiteColor();

				Speaker = speakerTextBox.Text;
			}
		}

		#endregion /SpeakerTextBox_Leave
		//-----
		#endregion /SpeakerTextBox

		#region MinusSpeakerButton_Click
		private void MinusSpeakerButton_Click(object sender, System.EventArgs e)
		{
			if (Number_Speaker <= 0)
			{
				return;
			}
			else
			{
				Number_Speaker--;
				numberSpeakerLabel.Text = Number_Speaker.ToString();

				if (string.IsNullOrWhiteSpace(unitPriceSpeakerTextBox.Text) || string.Compare(unitPriceSpeakerTextBox.Text, "قیمت واحد بلندگو") == 0)
				{
					return;
				}
				else
				{
					TotalPrice_Speaker = UnitPrice_Speaker * Number_Speaker;

					if (Number_Speaker == 0)
					{
						totalPriceSpeakerLabel.Text = $"0 تومان";
						return;
					}
					else
					{
						totalPriceSpeakerLabel.Text = $"{TotalPrice_Speaker:#,0} تومان";
					}
				}
			}
		}

		#endregion /MinusSpeakerButton_Click

		#region AddSpeakerButton_Click
		private void AddSpeakerButton_Click(object sender, System.EventArgs e)
		{
			Number_Speaker++;
			numberSpeakerLabel.Text = Number_Speaker.ToString();

			if (string.IsNullOrWhiteSpace(unitPriceSpeakerTextBox.Text) || string.Compare(unitPriceSpeakerTextBox.Text, "قیمت واحد بلندگو") == 0)
			{
				return;
			}
			else
			{
				TotalPrice_Speaker = UnitPrice_Speaker * Number_Speaker;

				if (Number_Speaker == 0)
				{
					totalPriceSpeakerLabel.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceSpeakerLabel.Text = $"{TotalPrice_Speaker:#,0} تومان";
				}
			}
		}

		#endregion /AddSpeakerButton_Click

		#region UnitPriceSpeaker
		//-----
		#region UnitPriceSpeakerTextBox_Enter
		private void UnitPriceSpeakerTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.EnglishLanguage();
			unitPriceSpeakerTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			unitPriceSpeakerPanel.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(unitPriceSpeakerTextBox.Text, "قیمت واحد بلندگو") == 0)
			{
				unitPriceSpeakerTextBox.Clear();
				unitPriceSpeakerTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				unitPriceSpeakerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				return;
			}
		}

		#endregion /UnitPriceSpeakerTextBox_Enter

		#region UnitPriceSpeakerTextBox_KeyPress
		private void UnitPriceSpeakerTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}

		#endregion /UnitPriceSpeakerTextBox_KeyPress

		#region UnitPriceSpeakerTextBox_Leave
		private void UnitPriceSpeakerTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(unitPriceSpeakerTextBox.Text) || string.Compare(unitPriceSpeakerTextBox.Text, "قیمت واحد بلندگو") == 0)
			{
				unitPriceSpeakerTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				unitPriceSpeakerPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();

				unitPriceSpeakerTextBox.Text = "قیمت واحد بلندگو";
				unitPriceSpeakerTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				unitPriceSpeakerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				totalPriceSpeakerLabel.Text = "قیمت کل بلندگو";
				totalPriceSpeakerLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				totalPriceSpeakerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
				UnitPrice_Speaker = 0;
			}
			else
			{
				unitPriceSpeakerTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				unitPriceSpeakerPanel.BackColor =
					Infrastructure.Utility.WhiteColor();
				unitPriceSpeakerTextBox.Text = $"{UnitPrice_Keyboard:#,0} تومان";
				unitPriceSpeakerTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				unitPriceSpeakerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			}
		}

		#endregion /UnitPriceSpeakerTextBox_Leave

		#region UnitPriceSpeakerTextBox_TextChanged
		private void UnitPriceSpeakerTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(unitPriceSpeakerTextBox.Text) || string.Compare(unitPriceSpeakerTextBox.Text, "قیمت واحد بلندگو") == 0)
			{
				totalPriceSpeakerLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				totalPriceSpeakerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
				totalPriceSpeakerLabel.Text = "قیمت کل بلندگو";
				return;
			}
			else if (string.Compare(unitPriceSpeakerTextBox.Text, "تومان") == 0 || string.Compare(unitPriceSpeakerTextBox.Text, " تومان") == 0 || string.Compare(unitPriceSpeakerTextBox.Text, "ومان") == 0 || string.Compare(unitPriceSpeakerTextBox.Text, "مان") == 0 || string.Compare(unitPriceSpeakerTextBox.Text, "ان") == 0 || string.Compare(unitPriceSpeakerTextBox.Text, "ن") == 0)
			{
				Number_Speaker = 0;

				TotalPrice_Speaker = UnitPrice_Speaker * Number_Speaker;

				if (Number_Speaker == 0)
				{
					totalPriceSpeakerLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceSpeakerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceSpeakerLabel.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceSpeakerLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceSpeakerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceSpeakerLabel.Text = $"{TotalPrice_Speaker:#,0} تومان";
				}
				return;

			}
			else if (unitPriceSpeakerTextBox.Text.Contains("تومان"))
			{
				Price = unitPriceSpeakerTextBox.Text.Replace("تومان", string.Empty).Trim();
				UnitPrice_Speaker = int.Parse(Price.Replace(",", string.Empty).Trim());
				TotalPrice_Speaker = UnitPrice_Speaker * Number_Speaker;

				if (Number_Speaker == 0)
				{
					totalPriceSpeakerLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceSpeakerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceSpeakerLabel.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceSpeakerLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceSpeakerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceSpeakerLabel.Text = $"{TotalPrice_Speaker:#,0} تومان";
				}
				return;
			}
			else
			{
				Price = unitPriceSpeakerTextBox.Text.Replace("تومان", string.Empty).Trim();
				UnitPrice_Speaker = int.Parse(Price.Replace(",", string.Empty).Trim());
				TotalPrice_Speaker = UnitPrice_Speaker * Number_Speaker;

				if (Number_Speaker == 0)
				{
					totalPriceSpeakerLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceSpeakerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceSpeakerLabel.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceSpeakerLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceSpeakerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceSpeakerLabel.Text = $"{TotalPrice_Speaker:#,0} تومان";
				}
			}
		}

		#endregion /UnitPriceSpeakerTextBox_TextChanged
		//-----
		#endregion /UnitPriceSpeaker

		#region TotalPriceSpeakerLabel_TextChanged
		private void TotalPriceSpeakerLabel_TextChanged(object sender, System.EventArgs e)
		{
			if (string.Compare(totalPriceSpeakerLabel.Text, "قیمت کل بلندگو") == 0)
			{
				TotalPrice_Speaker = 0;
				SumTotoalPrice(TotalPrice_MainBoard, TotalPrice_Processor, TotalPrice_RAM, TotalPrice_HDD, TotalPrice_DVDROM, TotalPrice_GraphicCard, TotalPrice_Keyboard, TotalPrice_Mouse, TotalPrice_Speaker, TotalPrice_Monitor, TotalPrice_OtherDevice1, TotalPrice_OtherDevice2, TotalPrice_OtherDevice3, TotalPrice_OtherDevice4, TotalPrice_OtherDevice5);
				return;
			}
			else
			{
				SumTotoalPrice(TotalPrice_MainBoard, TotalPrice_Processor, TotalPrice_RAM, TotalPrice_HDD, TotalPrice_DVDROM, TotalPrice_GraphicCard, TotalPrice_Keyboard, TotalPrice_Mouse, TotalPrice_Speaker, TotalPrice_Monitor, TotalPrice_OtherDevice1, TotalPrice_OtherDevice2, TotalPrice_OtherDevice3, TotalPrice_OtherDevice4, TotalPrice_OtherDevice5);
			}
		}
		#endregion /TotalPriceSpeakerLabel_TextChanged
		//-----
		#endregion /Speaker

		#region Monitor
		//-----
		#region MonitorCeckBox_CheckedChanged
		private void MonitorCeckBox_CheckedChanged(object sender, System.EventArgs e)
		{
			if (monitorCheckBox.Checked == true)
			{
				monitorTextBox.Enabled = true;
				monitorPanel.Enabled = true;
				minusMonitorButton.Enabled = true;
				addMonitorButton.Enabled = true;
				unitPriceMonitorTextBox.Enabled = true;
				unitPriceMonitorPanel.Enabled = true;
			}
			else
			{
				monitorTextBox.Enabled = false;
				monitorTextBox.Text = "Monitor";
				monitorTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				monitorPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				Monitor = string.Empty;
				monitorPanel.Enabled = false;

				minusMonitorButton.Enabled = false;
				numberMonitorLabel.Text = "0";
				Number_Monitor = 0;
				addMonitorButton.Enabled = false;

				unitPriceMonitorTextBox.Enabled = false;
				unitPriceMonitorTextBox.Text = "قیمت واحد مانیتور";
				unitPriceMonitorTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				unitPriceMonitorPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				UnitPrice_Monitor = 0;
				unitPriceMonitorPanel.Enabled = false;

				totalPriceMonitorLabel.Text = "قیمت کل مانیتور";
				TotalPrice_Monitor = 0;
			}
		}
		#endregion /MonitorCeckBox_CheckedChanged

		#region MonitorTextBox
		//-----
		#region MonitorTextBox_Enter
		private void MonitorTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.EnglishLanguage();
			monitorTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			monitorPanel.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(monitorTextBox.Text, "Monitor") == 0)
			{
				monitorTextBox.Clear();
			}
		}
		#endregion /MonitorTextBox_Enter

		#region MonitorTextBox_KeyPress
		private void MonitorTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.EnglishAndNumberTyping(e);
		}
		#endregion /MonitorTextBox_KeyPress

		#region MonitorTextBox_Leave
		private void MonitorTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(monitorTextBox.Text) || string.Compare(monitorTextBox.Text, "Monitor") == 0)
			{
				monitorTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				monitorPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();

				monitorTextBox.Text = "Monitor";
				Monitor = string.Empty;
			}
			else
			{
				monitorTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				monitorPanel.BackColor =
					Infrastructure.Utility.WhiteColor();

				Monitor = monitorTextBox.Text;
			}
		}
		#endregion /MonitorTextBox_Leave
		//-----
		#endregion /MonitorTextBox

		#region MinusMonitorButton_Click
		private void MinusMonitorButton_Click(object sender, System.EventArgs e)
		{
			if (Number_Monitor <= 0)
			{
				return;
			}
			else
			{
				Number_Monitor--;
				numberMonitorLabel.Text = Number_Monitor.ToString();

				if (string.IsNullOrWhiteSpace(unitPriceMonitorTextBox.Text) || string.Compare(unitPriceMonitorTextBox.Text, "قیمت واحد مانیتور") == 0)
				{
					return;
				}
				else
				{
					TotalPrice_Monitor = UnitPrice_Monitor * Number_Monitor;

					if (Number_Monitor == 0)
					{
						totalPriceMonitorLabel.Text = $"0 تومان";
						return;
					}
					else
					{
						totalPriceMonitorLabel.Text = $"{TotalPrice_Monitor:#,0} تومان";
					}
				}
			}
		}
		#endregion /MinusMonitorButton_Click

		#region AddMonitorButton_Click
		private void AddMonitorButton_Click(object sender, System.EventArgs e)
		{
			Number_Monitor++;
			numberMonitorLabel.Text = Number_Monitor.ToString();

			if (string.IsNullOrWhiteSpace(unitPriceMonitorTextBox.Text) || string.Compare(unitPriceMonitorTextBox.Text, "قیمت واحد مانیتور") == 0)
			{
				return;
			}
			else
			{
				TotalPrice_Monitor = UnitPrice_Monitor * Number_Monitor;

				if (Number_Monitor == 0)
				{
					totalPriceMonitorLabel.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceMonitorLabel.Text = $"{TotalPrice_Monitor:#,0} تومان";
				}
			}
		}
		#endregion /AddMonitorButton_Click

		#region UnitPriceMonitorTextBox
		//-----
		#region UnitPriceMonitorTextBox_Enter
		private void UnitPriceMonitorTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.EnglishLanguage();
			unitPriceMonitorTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			unitPriceMonitorPanel.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(unitPriceMonitorTextBox.Text, "قیمت واحد مانیتور") == 0)
			{
				unitPriceMonitorTextBox.Clear();
				unitPriceMonitorTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				unitPriceMonitorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				return;
			}
		}
		#endregion /UnitPriceMonitorTextBox_Enter

		#region UnitPriceMonitorTextBox_KeyPress
		private void UnitPriceMonitorTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /UnitPriceMonitorTextBox_KeyPress

		#region UnitPriceMonitorTextBox_Leave
		private void UnitPriceMonitorTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(unitPriceMonitorTextBox.Text) || string.Compare(unitPriceMonitorTextBox.Text, "قیمت واحد مانیتور") == 0)
			{
				unitPriceMonitorTextBox.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				unitPriceMonitorPanel.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();

				unitPriceMonitorTextBox.Text = "قیمت واحد مانیتور";
				unitPriceMonitorTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				unitPriceMonitorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				totalPriceMonitorLabel.Text = "قیمت کل مانیتور";
				totalPriceMonitorLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				totalPriceMonitorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
				UnitPrice_Monitor = 0;
			}
			else
			{
				unitPriceMonitorTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				unitPriceMonitorPanel.BackColor =
					Infrastructure.Utility.WhiteColor();
				unitPriceMonitorTextBox.Text = $"{UnitPrice_Keyboard:#,0} تومان";
				unitPriceMonitorTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				unitPriceMonitorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			}
		}
		#endregion /UnitPriceMonitorTextBox_Leave

		#region UnitPriceMonitorTextBox_TextChanged
		private void UnitPriceMonitorTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(unitPriceMonitorTextBox.Text) || string.Compare(unitPriceMonitorTextBox.Text, "قیمت واحد مانیتور") == 0)
			{
				totalPriceMonitorLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				totalPriceMonitorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
				totalPriceMonitorLabel.Text = "قیمت کل مانیتور";
				return;
			}
			else if (string.Compare(unitPriceMonitorTextBox.Text, "تومان") == 0 || string.Compare(unitPriceMonitorTextBox.Text, " تومان") == 0 || string.Compare(unitPriceMonitorTextBox.Text, "ومان") == 0 || string.Compare(unitPriceMonitorTextBox.Text, "مان") == 0 || string.Compare(unitPriceMonitorTextBox.Text, "ان") == 0 || string.Compare(unitPriceMonitorTextBox.Text, "ن") == 0)
			{
				Number_Monitor = 0;

				TotalPrice_Monitor = UnitPrice_Monitor * Number_Monitor;

				if (Number_Monitor == 0)
				{
					totalPriceMonitorLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceMonitorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceMonitorLabel.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceMonitorLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceMonitorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceMonitorLabel.Text = $"{TotalPrice_Monitor:#,0} تومان";
				}
				return;

			}
			else if (unitPriceMonitorTextBox.Text.Contains("تومان"))
			{
				Price = unitPriceMonitorTextBox.Text.Replace("تومان", string.Empty).Trim();
				UnitPrice_Monitor = int.Parse(Price.Replace(",", string.Empty).Trim());
				TotalPrice_Monitor = UnitPrice_Monitor * Number_Monitor;

				if (Number_Monitor == 0)
				{
					totalPriceMonitorLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceMonitorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceMonitorLabel.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceMonitorLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceMonitorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceMonitorLabel.Text = $"{TotalPrice_Monitor:#,0} تومان";
				}
				return;
			}
			else
			{
				Price = unitPriceMonitorTextBox.Text.Replace("تومان", string.Empty).Trim();
				UnitPrice_Monitor = int.Parse(Price.Replace(",", string.Empty).Trim());
				TotalPrice_Monitor = UnitPrice_Monitor * Number_Monitor;

				if (Number_Monitor == 0)
				{
					totalPriceMonitorLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceMonitorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceMonitorLabel.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceMonitorLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceMonitorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceMonitorLabel.Text = $"{TotalPrice_Monitor:#,0} تومان";
				}
			}
		}
		#endregion /UnitPriceMonitorTextBox_TextChanged
		//-----
		#endregion /UnitPriceMonitorTextBox

		#region TotalPriceMonitorLabel_TextChanged
		private void TotalPriceMonitorLabel_TextChanged(object sender, System.EventArgs e)
		{
			if (string.Compare(totalPriceMonitorLabel.Text, "قیمت کل مانیتور") == 0)
			{
				TotalPrice_Monitor = 0;
				SumTotoalPrice(TotalPrice_MainBoard, TotalPrice_Processor, TotalPrice_RAM, TotalPrice_HDD, TotalPrice_DVDROM, TotalPrice_GraphicCard, TotalPrice_Keyboard, TotalPrice_Mouse, TotalPrice_Speaker, TotalPrice_Monitor, TotalPrice_OtherDevice1, TotalPrice_OtherDevice2, TotalPrice_OtherDevice3, TotalPrice_OtherDevice4, TotalPrice_OtherDevice5);
				return;
			}
			else
			{
				SumTotoalPrice(TotalPrice_MainBoard, TotalPrice_Processor, TotalPrice_RAM, TotalPrice_HDD, TotalPrice_DVDROM, TotalPrice_GraphicCard, TotalPrice_Keyboard, TotalPrice_Mouse, TotalPrice_Speaker, TotalPrice_Monitor, TotalPrice_OtherDevice1, TotalPrice_OtherDevice2, TotalPrice_OtherDevice3, TotalPrice_OtherDevice4, TotalPrice_OtherDevice5);
			}
		}
		#endregion /TotalPriceMonitorLabel_TextChanged
		//-----
		#endregion /Monitor

		#region OtherDevice1
		//-----
		#region OtherDeviceCheckBox1_CheckedChanged
		private void OtherDeviceCheckBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			if (otherDeviceCheckBox1.Checked == true)
			{
				otherDeviceTextBox1.Enabled = true;
				otherDevicePanel1.Enabled = true;
				minusOtherDeviceButton1.Enabled = true;
				addOtherDeviceButton1.Enabled = true;
				unitPriceOtherDeviceTextBox1.Enabled = true;
				unitPriceOtherDevicePanel1.Enabled = true;
			}
			else
			{
				otherDeviceTextBox1.Enabled = false;
				otherDeviceTextBox1.Text = "Other Device";
				otherDeviceTextBox1.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				otherDevicePanel1.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				OtherDevice1 = string.Empty;
				otherDevicePanel1.Enabled = false;

				minusOtherDeviceButton1.Enabled = false;
				numberOtherDeviceLabel1.Text = "0";
				Number_OtherDevice1 = 0;
				addOtherDeviceButton1.Enabled = false;

				unitPriceOtherDeviceTextBox1.Enabled = false;
				unitPriceOtherDeviceTextBox1.Text = "قیمت واحد قیمت سایر اقلام";
				unitPriceOtherDeviceTextBox1.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				unitPriceOtherDevicePanel1.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				UnitPrice_OtherDevice1 = 0;
				unitPriceOtherDevicePanel1.Enabled = false;

				totalPriceOtherDeviceLabel1.Text = "قیمت کل سایر اقلام";
				TotalPrice_OtherDevice1 = 0;
			}
		}
		#endregion /OtherDeviceCheckBox1_CheckedChanged

		#region OtherDeviceTextBox1
		//-----
		#region OtherDeviceTextBox1_Enter
		private void OtherDeviceTextBox1_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.EnglishLanguage();
			otherDeviceTextBox1.ForeColor =
				Infrastructure.Utility.LimeColor();
			otherDevicePanel1.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(otherDeviceTextBox1.Text, "Other Device") == 0)
			{
				otherDeviceTextBox1.Clear();
			}
		}
		#endregion /OtherDeviceTextBox1_Enter

		#region OtherDeviceTextBox1_KeyPress
		private void OtherDeviceTextBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.EnglishAndNumberTyping(e);
		}
		#endregion /OtherDeviceTextBox1_KeyPress

		#region OtherDeviceTextBox1_Leave
		private void OtherDeviceTextBox1_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(otherDeviceTextBox1.Text) || string.Compare(otherDeviceTextBox1.Text, "Other Device") == 0)
			{
				otherDeviceTextBox1.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				otherDevicePanel1.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();

				otherDeviceTextBox1.Text = "Other Device";
				OtherDevice1 = string.Empty;
			}
			else
			{
				otherDeviceTextBox1.ForeColor =
					Infrastructure.Utility.WhiteColor();
				otherDevicePanel1.BackColor =
					Infrastructure.Utility.WhiteColor();

				OtherDevice1 = otherDeviceTextBox1.Text;
			}
		}
		#endregion /OtherDeviceTextBox1_Leave
		//-----
		#endregion /OtherDeviceTextBox1

		#region MinusotherDeviceButton1_Click
		private void MinusotherDeviceButton1_Click(object sender, System.EventArgs e)
		{
			if (Number_OtherDevice1 <= 0)
			{
				return;
			}
			else
			{
				Number_OtherDevice1--;
				numberOtherDeviceLabel1.Text = Number_OtherDevice1.ToString();

				if (string.IsNullOrWhiteSpace(unitPriceOtherDeviceTextBox1.Text) || string.Compare(unitPriceOtherDeviceTextBox1.Text, "قیمت واحد سایر اقلام") == 0)
				{
					return;
				}
				else
				{
					TotalPrice_OtherDevice1 = UnitPrice_OtherDevice1 * Number_OtherDevice1;

					if (Number_OtherDevice1 == 0)
					{
						totalPriceOtherDeviceLabel1.Text = $"0 تومان";
						return;
					}
					else
					{
						totalPriceOtherDeviceLabel1.Text = $"{TotalPrice_OtherDevice1:#,0} تومان";
					}
				}
			}
		}

		#endregion /MinusotherDeviceButton1_Click

		#region AddotherDeviceButton1_Click
		private void AddotherDeviceButton1_Click(object sender, System.EventArgs e)
		{
			Number_OtherDevice1++;
			numberOtherDeviceLabel1.Text = Number_OtherDevice1.ToString();

			if (string.IsNullOrWhiteSpace(unitPriceOtherDeviceTextBox1.Text) || string.Compare(unitPriceOtherDeviceTextBox1.Text, "قیمت واحد سایر اقلام") == 0)
			{
				return;
			}
			else
			{
				TotalPrice_OtherDevice1 = UnitPrice_OtherDevice1 * Number_OtherDevice1;

				if (Number_OtherDevice1 == 0)
				{
					totalPriceOtherDeviceLabel1.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceOtherDeviceLabel1.Text = $"{TotalPrice_OtherDevice1:#,0} تومان";
				}
			}
		}

		#endregion /AddotherDeviceButton1_Click

		#region UnitPriceOtherDeviceTextBox1
		//-----
		#region UnitPriceOtherDeviceTextBox1_Enter
		private void UnitPriceOtherDeviceTextBox1_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.EnglishLanguage();
			unitPriceOtherDeviceTextBox1.ForeColor =
				Infrastructure.Utility.LimeColor();
			unitPriceOtherDevicePanel1.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(unitPriceOtherDeviceTextBox1.Text, "قیمت واحد سایر اقلام") == 0)
			{
				unitPriceOtherDeviceTextBox1.Clear();
				unitPriceOtherDeviceTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				unitPriceOtherDeviceTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				return;
			}
		}

		#endregion /UnitPriceOtherDeviceTextBox1_Enter

		#region UnitPriceOtherDeviceTextBox1_KeyPress
		private void UnitPriceOtherDeviceTextBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}

		#endregion /UnitPriceOtherDeviceTextBox1_KeyPress

		#region UnitPriceOtherDeviceTextBox1_Leave
		private void UnitPriceOtherDeviceTextBox1_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(unitPriceOtherDeviceTextBox1.Text) || string.Compare(unitPriceOtherDeviceTextBox1.Text, "قیمت واحد سایر اقلام") == 0)
			{
				unitPriceOtherDeviceTextBox1.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				unitPriceOtherDevicePanel1.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();

				unitPriceOtherDeviceTextBox1.Text = "قیمت واحد سایر اقلام";
				unitPriceOtherDeviceTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				unitPriceOtherDeviceTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				totalPriceOtherDeviceLabel1.Text = "قیمت کل سایر اقلام";
				totalPriceOtherDeviceLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				totalPriceOtherDeviceLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
				UnitPrice_OtherDevice1 = 0;
			}
			else
			{
				unitPriceOtherDeviceTextBox1.ForeColor =
					Infrastructure.Utility.WhiteColor();
				unitPriceOtherDevicePanel1.BackColor =
					Infrastructure.Utility.WhiteColor();
				unitPriceOtherDeviceTextBox1.Text = $"{UnitPrice_OtherDevice1:#,0} تومان";
				unitPriceOtherDeviceTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				unitPriceOtherDeviceTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			}
		}

		#endregion /UnitPriceOtherDeviceTextBox1_Leave

		#region UnitPriceOtherDeviceTextBox1_TextChanged
		private void UnitPriceOtherDeviceTextBox1_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(unitPriceOtherDeviceTextBox1.Text) || string.Compare(unitPriceOtherDeviceTextBox1.Text, "قیمت واحد سایر اقلام") == 0)
			{
				totalPriceOtherDeviceLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				totalPriceOtherDeviceLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
				totalPriceOtherDeviceLabel1.Text = "قیمت کل سایر اقلام";
				return;
			}
			else if (string.Compare(unitPriceOtherDeviceTextBox1.Text, "تومان") == 0 || string.Compare(unitPriceOtherDeviceTextBox1.Text, " تومان") == 0 || string.Compare(unitPriceOtherDeviceTextBox1.Text, "ومان") == 0 || string.Compare(unitPriceOtherDeviceTextBox1.Text, "مان") == 0 || string.Compare(unitPriceOtherDeviceTextBox1.Text, "ان") == 0 || string.Compare(unitPriceOtherDeviceTextBox1.Text, "ن") == 0)
			{
				Number_OtherDevice1 = 0;

				TotalPrice_OtherDevice1 = UnitPrice_OtherDevice1 * Number_OtherDevice1;

				if (Number_OtherDevice1 == 0)
				{
					totalPriceOtherDeviceLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceOtherDeviceLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceOtherDeviceLabel1.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceOtherDeviceLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceOtherDeviceLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceOtherDeviceLabel1.Text = $"{TotalPrice_OtherDevice1:#,0} تومان";
				}
				return;

			}
			else if (unitPriceOtherDeviceTextBox1.Text.Contains("تومان"))
			{
				Price = unitPriceOtherDeviceTextBox1.Text.Replace("تومان", string.Empty).Trim();
				UnitPrice_OtherDevice1 = int.Parse(Price.Replace(",", string.Empty).Trim());
				TotalPrice_OtherDevice1 = UnitPrice_OtherDevice1 * Number_OtherDevice1;

				if (Number_OtherDevice1 == 0)
				{
					totalPriceOtherDeviceLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceOtherDeviceLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceOtherDeviceLabel1.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceOtherDeviceLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceOtherDeviceLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceOtherDeviceLabel1.Text = $"{TotalPrice_OtherDevice1:#,0} تومان";
				}
				return;
			}
			else
			{
				Price = unitPriceOtherDeviceTextBox1.Text.Replace("تومان", string.Empty).Trim();
				UnitPrice_OtherDevice1 = int.Parse(Price.Replace(",", string.Empty).Trim());
				TotalPrice_OtherDevice1 = UnitPrice_OtherDevice1 * Number_OtherDevice1;

				if (Number_OtherDevice1 == 0)
				{
					totalPriceOtherDeviceLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceOtherDeviceLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceOtherDeviceLabel1.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceOtherDeviceLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceOtherDeviceLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceOtherDeviceLabel1.Text = $"{TotalPrice_OtherDevice1:#,0} تومان";
				}
			}
		}

		#endregion /UnitPriceOtherDeviceTextBox1_TextChanged 
		//-----
		#endregion /UnitPriceOtherDeviceTextBox1

		#region TotalPriceOtherDeviceLabel1_TextChanged
		private void TotalPriceOtherDeviceLabel1_TextChanged(object sender, System.EventArgs e)
		{
			if (string.Compare(totalPriceOtherDeviceLabel1.Text, "قیمت کل سایر اقلام") == 0)
			{
				TotalPrice_OtherDevice1 = 0;
				SumTotoalPrice(TotalPrice_MainBoard, TotalPrice_Processor, TotalPrice_RAM, TotalPrice_HDD, TotalPrice_DVDROM, TotalPrice_GraphicCard, TotalPrice_Keyboard, TotalPrice_Mouse, TotalPrice_Speaker, TotalPrice_Monitor, TotalPrice_OtherDevice1, TotalPrice_OtherDevice2, TotalPrice_OtherDevice3, TotalPrice_OtherDevice4, TotalPrice_OtherDevice5);
				return;
			}
			else
			{
				SumTotoalPrice(TotalPrice_MainBoard, TotalPrice_Processor, TotalPrice_RAM, TotalPrice_HDD, TotalPrice_DVDROM, TotalPrice_GraphicCard, TotalPrice_Keyboard, TotalPrice_Mouse, TotalPrice_Speaker, TotalPrice_Monitor, TotalPrice_OtherDevice1, TotalPrice_OtherDevice2, TotalPrice_OtherDevice3, TotalPrice_OtherDevice4, TotalPrice_OtherDevice5);
			}
		}
		#endregion /TotalPriceOtherDeviceLabel1_TextChanged
		//-----
		#endregion /OtherDevice1

		#region OtherDevice2
		//-----
		#region OtherDeviceCheckBox2_CheckedChanged
		private void OtherDeviceCheckBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			if (otherDeviceCheckBox2.Checked == true)
			{
				otherDeviceTextBox2.Enabled = true;
				otherDevicePanel2.Enabled = true;
				minusOtherDeviceButton2.Enabled = true;
				addOtherDeviceButton2.Enabled = true;
				unitPriceOtherDeviceTextBox2.Enabled = true;
				unitPriceOtherDevicePanel2.Enabled = true;
			}
			else
			{
				otherDeviceTextBox2.Enabled = false;
				otherDeviceTextBox2.Text = "Other Device";
				otherDeviceTextBox2.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				otherDevicePanel2.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				OtherDevice2 = string.Empty;
				otherDevicePanel2.Enabled = false;

				minusOtherDeviceButton2.Enabled = false;
				numberOtherDeviceLabel2.Text = "0";
				Number_OtherDevice2 = 0;
				addOtherDeviceButton2.Enabled = false;

				unitPriceOtherDeviceTextBox2.Enabled = false;
				unitPriceOtherDeviceTextBox2.Text = "قیمت واحد قیمت سایر اقلام";
				unitPriceOtherDeviceTextBox2.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				unitPriceOtherDevicePanel2.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				UnitPrice_OtherDevice2 = 0;
				unitPriceOtherDevicePanel2.Enabled = false;

				totalPriceOtherDeviceLabel2.Text = "قیمت کل سایر اقلام";
				TotalPrice_OtherDevice1 = 0;
			}
		}
		#endregion /OtherDeviceCheckBox2_CheckedChanged 

		#region  OtherDeviceTextBox2
		//-----
		#region OtherDeviceTextBox2_Enter
		private void OtherDeviceTextBox2_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.EnglishLanguage();
			otherDeviceTextBox2.ForeColor =
				Infrastructure.Utility.LimeColor();
			otherDevicePanel2.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(otherDeviceTextBox2.Text, "Other Device") == 0)
			{
				otherDeviceTextBox2.Clear();
			}
		}
		#endregion /OtherDeviceTextBox2_Enter

		#region OtherDeviceTextBox2_KeyPress
		private void OtherDeviceTextBox2_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.EnglishAndNumberTyping(e);
		}
		#endregion /OtherDeviceTextBox2_KeyPress

		#region OtherDeviceTextBox2_Leave
		private void OtherDeviceTextBox2_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(otherDeviceTextBox2.Text) || string.Compare(otherDeviceTextBox2.Text, "Other Device") == 0)
			{
				otherDeviceTextBox2.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				otherDevicePanel2.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();

				otherDeviceTextBox2.Text = "Other Device";
				OtherDevice2 = string.Empty;
			}
			else
			{
				otherDeviceTextBox2.ForeColor =
					Infrastructure.Utility.WhiteColor();
				otherDevicePanel2.BackColor =
					Infrastructure.Utility.WhiteColor();

				OtherDevice2 = otherDeviceTextBox2.Text;
			}
		}
		#endregion /OtherDeviceTextBox2_Leave 
		//-----
		#endregion / OtherDeviceTextBox2

		#region MinusotherDeviceButton2_Click
		private void MinusotherDeviceButton2_Click(object sender, System.EventArgs e)
		{
			if (Number_OtherDevice2 <= 0)
			{
				return;
			}
			else
			{
				Number_OtherDevice2--;
				numberOtherDeviceLabel2.Text = Number_OtherDevice2.ToString();

				if (string.IsNullOrWhiteSpace(unitPriceOtherDeviceTextBox2.Text) || string.Compare(unitPriceOtherDeviceTextBox2.Text, "قیمت واحد سایر اقلام") == 0)
				{
					return;
				}
				else
				{
					TotalPrice_OtherDevice2 = UnitPrice_OtherDevice2 * Number_OtherDevice2;

					if (Number_OtherDevice2 == 0)
					{
						totalPriceOtherDeviceLabel2.Text = $"0 تومان";
						return;
					}
					else
					{
						totalPriceOtherDeviceLabel2.Text = $"{TotalPrice_OtherDevice2:#,0} تومان";
					}
				}
			}
		}
		#endregion /MinusotherDeviceButton2_Click

		#region AddotherDeviceButton2_Click
		private void AddotherDeviceButton2_Click(object sender, System.EventArgs e)
		{
			Number_OtherDevice2++;
			numberOtherDeviceLabel2.Text = Number_OtherDevice2.ToString();

			if (string.IsNullOrWhiteSpace(unitPriceOtherDeviceTextBox2.Text) || string.Compare(unitPriceOtherDeviceTextBox2.Text, "قیمت واحد سایر اقلام") == 0)
			{
				return;
			}
			else
			{
				TotalPrice_OtherDevice2 = UnitPrice_OtherDevice2 * Number_OtherDevice2;

				if (Number_OtherDevice2 == 0)
				{
					totalPriceOtherDeviceLabel2.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceOtherDeviceLabel2.Text = $"{TotalPrice_OtherDevice2:#,0} تومان";
				}
			}
		}
		#endregion /AddotherDeviceButton2_Click

		#region UnitPriceOtherDeviceTextBox2
		//-----
		#region UnitPriceOtherDeviceTextBox2_Enter
		private void UnitPriceOtherDeviceTextBox2_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.EnglishLanguage();
			unitPriceOtherDeviceTextBox2.ForeColor =
				Infrastructure.Utility.LimeColor();
			unitPriceOtherDevicePanel2.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(unitPriceOtherDeviceTextBox2.Text, "قیمت واحد سایر اقلام") == 0)
			{
				unitPriceOtherDeviceTextBox2.Clear();
				unitPriceOtherDeviceTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				unitPriceOtherDeviceTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				return;
			}
		}
		#endregion /UnitPriceOtherDeviceTextBox2_Enter

		#region UnitPriceOtherDeviceTextBox2_KeyPress
		private void UnitPriceOtherDeviceTextBox2_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /UnitPriceOtherDeviceTextBox2_KeyPress

		#region UnitPriceOtherDeviceTextBox2_Leave
		private void UnitPriceOtherDeviceTextBox2_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(unitPriceOtherDeviceTextBox2.Text) || string.Compare(unitPriceOtherDeviceTextBox2.Text, "قیمت واحد سایر اقلام") == 0)
			{
				unitPriceOtherDeviceTextBox2.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				unitPriceOtherDevicePanel2.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();

				unitPriceOtherDeviceTextBox2.Text = "قیمت واحد سایر اقلام";
				unitPriceOtherDeviceTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				unitPriceOtherDeviceTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				totalPriceOtherDeviceLabel2.Text = "قیمت کل سایر اقلام";
				totalPriceOtherDeviceLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				totalPriceOtherDeviceLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
				UnitPrice_OtherDevice2 = 0;
			}
			else
			{
				unitPriceOtherDeviceTextBox2.ForeColor =
					Infrastructure.Utility.WhiteColor();
				unitPriceOtherDevicePanel2.BackColor =
					Infrastructure.Utility.WhiteColor();
				unitPriceOtherDeviceTextBox2.Text = $"{UnitPrice_OtherDevice2:#,0} تومان";
				unitPriceOtherDeviceTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				unitPriceOtherDeviceTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			}
		}
		#endregion /UnitPriceOtherDeviceTextBox2_Leave

		#region UnitPriceOtherDeviceTextBox2_TextChanged
		private void UnitPriceOtherDeviceTextBox2_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(unitPriceOtherDeviceTextBox2.Text) || string.Compare(unitPriceOtherDeviceTextBox2.Text, "قیمت واحد سایر اقلام") == 0)
			{
				totalPriceOtherDeviceLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				totalPriceOtherDeviceLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
				totalPriceOtherDeviceLabel2.Text = "قیمت کل سایر اقلام";
				return;
			}
			else if (string.Compare(unitPriceOtherDeviceTextBox2.Text, "تومان") == 0 || string.Compare(unitPriceOtherDeviceTextBox2.Text, " تومان") == 0 || string.Compare(unitPriceOtherDeviceTextBox2.Text, "ومان") == 0 || string.Compare(unitPriceOtherDeviceTextBox2.Text, "مان") == 0 || string.Compare(unitPriceOtherDeviceTextBox2.Text, "ان") == 0 || string.Compare(unitPriceOtherDeviceTextBox2.Text, "ن") == 0)
			{
				Number_OtherDevice2= 0;

				TotalPrice_OtherDevice2 = UnitPrice_OtherDevice2 * Number_OtherDevice2;

				if (Number_OtherDevice2 == 0)
				{
					totalPriceOtherDeviceLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceOtherDeviceLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceOtherDeviceLabel2.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceOtherDeviceLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceOtherDeviceLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceOtherDeviceLabel2.Text = $"{TotalPrice_OtherDevice2:#,0} تومان";
				}
				return;

			}
			else if (unitPriceOtherDeviceTextBox2.Text.Contains("تومان"))
			{
				Price = unitPriceOtherDeviceTextBox2.Text.Replace("تومان", string.Empty).Trim();
				UnitPrice_OtherDevice2 = int.Parse(Price.Replace(",", string.Empty).Trim());
				TotalPrice_OtherDevice2 = UnitPrice_OtherDevice2 * Number_OtherDevice2;

				if (Number_OtherDevice2 == 0)
				{
					totalPriceOtherDeviceLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceOtherDeviceLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceOtherDeviceLabel2.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceOtherDeviceLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceOtherDeviceLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceOtherDeviceLabel2.Text = $"{TotalPrice_OtherDevice2:#,0} تومان";
				}
				return;
			}
			else
			{
				Price = unitPriceOtherDeviceTextBox2.Text.Replace("تومان", string.Empty).Trim();
				UnitPrice_OtherDevice2 = int.Parse(Price.Replace(",", string.Empty).Trim());
				TotalPrice_OtherDevice2 = UnitPrice_OtherDevice2 * Number_OtherDevice2;

				if (Number_OtherDevice2 == 0)
				{
					totalPriceOtherDeviceLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceOtherDeviceLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceOtherDeviceLabel2.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceOtherDeviceLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceOtherDeviceLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceOtherDeviceLabel2.Text = $"{TotalPrice_OtherDevice2:#,0} تومان";
				}
			}
		}
		#endregion /UnitPriceOtherDeviceTextBox2_TextChanged
		//-----
		#endregion /UnitPriceOtherDeviceTextBox2

		#region TotalPriceOtherDeviceLabel2_TextChanged
		private void TotalPriceOtherDeviceLabel2_TextChanged(object sender, System.EventArgs e)
		{
			if (string.Compare(totalPriceOtherDeviceLabel2.Text, "قیمت کل سایر اقلام") == 0)
			{
				TotalPrice_OtherDevice2 = 0;
				SumTotoalPrice(TotalPrice_MainBoard, TotalPrice_Processor, TotalPrice_RAM, TotalPrice_HDD, TotalPrice_DVDROM, TotalPrice_GraphicCard, TotalPrice_Keyboard, TotalPrice_Mouse, TotalPrice_Speaker, TotalPrice_Monitor, TotalPrice_OtherDevice1, TotalPrice_OtherDevice2, TotalPrice_OtherDevice3, TotalPrice_OtherDevice4, TotalPrice_OtherDevice5);

				return;
			}
			else
			{
				SumTotoalPrice(TotalPrice_MainBoard, TotalPrice_Processor, TotalPrice_RAM, TotalPrice_HDD, TotalPrice_DVDROM, TotalPrice_GraphicCard, TotalPrice_Keyboard, TotalPrice_Mouse, TotalPrice_Speaker, TotalPrice_Monitor, TotalPrice_OtherDevice1, TotalPrice_OtherDevice2, TotalPrice_OtherDevice3, TotalPrice_OtherDevice4, TotalPrice_OtherDevice5);
			}
		}
		#endregion /TotalPriceOtherDeviceLabel2_TextChanged
		//-----
		#endregion /OtherDevice2

		#region OtherDevice3
		//-----
		#region OtherDeviceCheckBox3_CheckedChanged
		private void OtherDeviceCheckBox3_CheckedChanged(object sender, System.EventArgs e)
		{
			if (otherDeviceCheckBox3.Checked == true)
			{
				otherDeviceTextBox3.Enabled = true;
				otherDevicePanel3.Enabled = true;
				minusOtherDeviceButton3.Enabled = true;
				addOtherDeviceButton3.Enabled = true;
				unitPriceOtherDeviceTextBox3.Enabled = true;
				unitPriceOtherDevicePanel3.Enabled = true;
			}
			else
			{
				otherDeviceTextBox3.Enabled = false;
				otherDeviceTextBox3.Text = "Other Device";
				otherDeviceTextBox3.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				otherDevicePanel3.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				OtherDevice3 = string.Empty;
				otherDevicePanel3.Enabled = false;

				minusOtherDeviceButton3.Enabled = false;
				numberOtherDeviceLabel3.Text = "0";
				Number_OtherDevice3 = 0;
				addOtherDeviceButton3.Enabled = false;

				unitPriceOtherDeviceTextBox3.Enabled = false;
				unitPriceOtherDeviceTextBox3.Text = "قیمت واحد قیمت سایر اقلام";
				unitPriceOtherDeviceTextBox3.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				unitPriceOtherDevicePanel3.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				UnitPrice_OtherDevice3 = 0;
				unitPriceOtherDevicePanel3.Enabled = false;

				totalPriceOtherDeviceLabel3.Text = "قیمت کل سایر اقلام";
				TotalPrice_OtherDevice3 = 0;
			}
		}

		#endregion /OtherDeviceCheckBox3_CheckedChanged 

		#region OtherDeviceTextBox3
		//-----
		#region OtherDeviceTextBox3_Enter
		private void OtherDeviceTextBox3_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.EnglishLanguage();
			otherDeviceTextBox3.ForeColor =
				Infrastructure.Utility.LimeColor();
			otherDevicePanel3.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(otherDeviceTextBox3.Text, "Other Device") == 0)
			{
				otherDeviceTextBox3.Clear();
			}
		}
		#endregion /OtherDeviceTextBox3_Enter

		#region OtherDeviceTextBox3_KeyPress
		private void OtherDeviceTextBox3_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.EnglishAndNumberTyping(e);
		}
		#endregion /OtherDeviceTextBox3_KeyPress

		#region OtherDeviceTextBox3_Leave
		private void OtherDeviceTextBox3_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(otherDeviceTextBox3.Text) || string.Compare(otherDeviceTextBox3.Text, "Other Device") == 0)
			{
				otherDeviceTextBox3.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				otherDevicePanel3.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();

				otherDeviceTextBox3.Text = "Other Device";
				OtherDevice3 = string.Empty;
			}
			else
			{
				otherDeviceTextBox3.ForeColor =
					Infrastructure.Utility.WhiteColor();
				otherDevicePanel3.BackColor =
					Infrastructure.Utility.WhiteColor();

				OtherDevice3 = otherDeviceTextBox3.Text;
			}
		}
		#endregion /OtherDeviceTextBox3_Leave
		//-----
		#endregion /OtherDeviceTextBox3

		#region MinusotherDeviceButton3_Click
		private void MinusotherDeviceButton3_Click(object sender, System.EventArgs e)
		{
			if (Number_OtherDevice3 <= 0)
			{
				return;
			}
			else
			{
				Number_OtherDevice3--;
				numberOtherDeviceLabel3.Text = Number_OtherDevice3.ToString();

				if (string.IsNullOrWhiteSpace(unitPriceOtherDeviceTextBox3.Text) || string.Compare(unitPriceOtherDeviceTextBox3.Text, "قیمت واحد سایر اقلام") == 0)
				{
					return;
				}
				else
				{
					TotalPrice_OtherDevice3 = UnitPrice_OtherDevice3 * Number_OtherDevice3;

					if (Number_OtherDevice3 == 0)
					{
						totalPriceOtherDeviceLabel3.Text = $"0 تومان";
						return;
					}
					else
					{
						totalPriceOtherDeviceLabel3.Text = $"{TotalPrice_OtherDevice3:#,0} تومان";
					}
				}
			}
		}
		#endregion /MinusotherDeviceButton3_Click

		#region AddotherDeviceButton3_Click
		private void AddotherDeviceButton3_Click(object sender, System.EventArgs e)
		{
			Number_OtherDevice3++;
			numberOtherDeviceLabel3.Text = Number_OtherDevice3.ToString();

			if (string.IsNullOrWhiteSpace(unitPriceOtherDeviceTextBox3.Text) || string.Compare(unitPriceOtherDeviceTextBox3.Text, "قیمت واحد سایر اقلام") == 0)
			{
				return;
			}
			else
			{
				TotalPrice_OtherDevice3 = UnitPrice_OtherDevice3 * Number_OtherDevice3;

				if (Number_OtherDevice3 == 0)
				{
					totalPriceOtherDeviceLabel3.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceOtherDeviceLabel3.Text = $"{TotalPrice_OtherDevice3:#,0} تومان";
				}
			}
		}
		#endregion /AddotherDeviceButton3_Click

		#region UnitPriceOtherDeviceTextBox3
		//-----
		#region UnitPriceOtherDeviceTextBox3_Enter
		private void UnitPriceOtherDeviceTextBox3_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.EnglishLanguage();
			unitPriceOtherDeviceTextBox3.ForeColor =
				Infrastructure.Utility.LimeColor();
			unitPriceOtherDevicePanel3.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(unitPriceOtherDeviceTextBox3.Text, "قیمت واحد سایر اقلام") == 0)
			{
				unitPriceOtherDeviceTextBox3.Clear();
				unitPriceOtherDeviceTextBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				unitPriceOtherDeviceTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				return;
			}
		}
		#endregion /UnitPriceOtherDeviceTextBox3_Enter

		#region UnitPriceOtherDeviceTextBox3_KeyPress
		private void UnitPriceOtherDeviceTextBox3_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /UnitPriceOtherDeviceTextBox3_KeyPress

		#region UnitPriceOtherDeviceTextBox3_Leave
		private void UnitPriceOtherDeviceTextBox3_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(unitPriceOtherDeviceTextBox3.Text) || string.Compare(unitPriceOtherDeviceTextBox3.Text, "قیمت واحد سایر اقلام") == 0)
			{
				unitPriceOtherDeviceTextBox3.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				unitPriceOtherDeviceTextBox3.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();

				unitPriceOtherDeviceTextBox3.Text = "قیمت واحد سایر اقلام";
				unitPriceOtherDeviceTextBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				unitPriceOtherDeviceTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				totalPriceOtherDeviceLabel3.Text = "قیمت کل سایر اقلام";
				totalPriceOtherDeviceLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				totalPriceOtherDeviceLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
				UnitPrice_OtherDevice3 = 0;
			}
			else
			{
				unitPriceOtherDeviceTextBox3.ForeColor =
					Infrastructure.Utility.WhiteColor();
				unitPriceOtherDevicePanel3.BackColor =
					Infrastructure.Utility.WhiteColor();
				unitPriceOtherDeviceTextBox3.Text = $"{UnitPrice_OtherDevice3:#,0} تومان";
				unitPriceOtherDeviceTextBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				unitPriceOtherDeviceTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			}
		}
		#endregion /UnitPriceOtherDeviceTextBox3_Leave

		#region UnitPriceOtherDeviceTextBox3_TextChanged
		private void UnitPriceOtherDeviceTextBox3_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(unitPriceOtherDeviceTextBox3.Text) || string.Compare(unitPriceOtherDeviceTextBox3.Text, "قیمت واحد سایر اقلام") == 0)
			{
				totalPriceOtherDeviceLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				totalPriceOtherDeviceLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
				totalPriceOtherDeviceLabel3.Text = "قیمت کل سایر اقلام";
				return;
			}
			else if (string.Compare(unitPriceOtherDeviceTextBox3.Text, "تومان") == 0 || string.Compare(unitPriceOtherDeviceTextBox3.Text, " تومان") == 0 || string.Compare(unitPriceOtherDeviceTextBox3.Text, "ومان") == 0 || string.Compare(unitPriceOtherDeviceTextBox3.Text, "مان") == 0 || string.Compare(unitPriceOtherDeviceTextBox3.Text, "ان") == 0 || string.Compare(unitPriceOtherDeviceTextBox3.Text, "ن") == 0)
			{
				Number_OtherDevice3 = 0;

				TotalPrice_OtherDevice3 = UnitPrice_OtherDevice3 * Number_OtherDevice3;

				if (Number_OtherDevice3 == 0)
				{
					totalPriceOtherDeviceLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceOtherDeviceLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceOtherDeviceLabel3.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceOtherDeviceLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceOtherDeviceLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceOtherDeviceLabel3.Text = $"{TotalPrice_Keyboard:#,0} تومان";
				}
				return;
			}
			else if (unitPriceOtherDeviceTextBox3.Text.Contains("تومان"))
			{
				Price = unitPriceOtherDeviceTextBox3.Text.Replace("تومان", string.Empty).Trim();
				UnitPrice_OtherDevice3 = int.Parse(Price.Replace(",", string.Empty).Trim());
				TotalPrice_OtherDevice3 = UnitPrice_OtherDevice3 * Number_OtherDevice3;

				if (Number_OtherDevice3 == 0)
				{
					totalPriceOtherDeviceLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceOtherDeviceLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceOtherDeviceLabel3.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceOtherDeviceLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceOtherDeviceLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceOtherDeviceLabel3.Text = $"{TotalPrice_OtherDevice3:#,0} تومان";
				}
				return;
			}
			else
			{
				Price = unitPriceOtherDeviceTextBox3.Text.Replace("تومان", string.Empty).Trim();
				UnitPrice_OtherDevice3 = int.Parse(Price.Replace(",", string.Empty).Trim());
				TotalPrice_OtherDevice3 = UnitPrice_OtherDevice3 * Number_OtherDevice3;

				if (Number_OtherDevice3 == 0)
				{
					totalPriceOtherDeviceLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceOtherDeviceLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceOtherDeviceLabel3.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceOtherDeviceLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceOtherDeviceLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceOtherDeviceLabel3.Text = $"{TotalPrice_OtherDevice3:#,0} تومان";
				}
			}
		}
		#endregion /UnitPriceOtherDeviceTextBox3_TextChanged
		//-----
		#endregion /UnitPriceOtherDeviceTextBox3

		#region TotalPriceOtherDeviceLabel3_TextChanged
		private void TotalPriceOtherDeviceLabel3_TextChanged(object sender, System.EventArgs e)
		{
			if (string.Compare(totalPriceOtherDeviceLabel3.Text, "قیمت کل سایر اقلام") == 0)
			{
				TotalPrice_OtherDevice3 = 0;
				SumTotoalPrice(TotalPrice_MainBoard, TotalPrice_Processor, TotalPrice_RAM, TotalPrice_HDD, TotalPrice_DVDROM, TotalPrice_GraphicCard, TotalPrice_Keyboard, TotalPrice_Mouse, TotalPrice_Speaker, TotalPrice_Monitor, TotalPrice_OtherDevice1, TotalPrice_OtherDevice2, TotalPrice_OtherDevice3, TotalPrice_OtherDevice4, TotalPrice_OtherDevice5);

				return;
			}
			else
			{
				SumTotoalPrice(TotalPrice_MainBoard, TotalPrice_Processor, TotalPrice_RAM, TotalPrice_HDD, TotalPrice_DVDROM, TotalPrice_GraphicCard, TotalPrice_Keyboard, TotalPrice_Mouse, TotalPrice_Speaker, TotalPrice_Monitor, TotalPrice_OtherDevice1, TotalPrice_OtherDevice2, TotalPrice_OtherDevice3, TotalPrice_OtherDevice4, TotalPrice_OtherDevice5);
			}
		}
		#endregion /TotalPriceOtherDeviceLabel3_TextChanged
		//-----
		#endregion /OtherDevice3

		#region OtherDevice4
		//-----
		#region OtherDeviceCheckBox4_CheckedChanged
		private void OtherDeviceCheckBox4_CheckedChanged(object sender, System.EventArgs e)
		{
			if (otherDeviceCheckBox4.Checked == true)
			{
				otherDeviceTextBox4.Enabled = true;
				otherDevicePanel4.Enabled = true;
				minusOtherDeviceButton4.Enabled = true;
				addOtherDeviceButton4.Enabled = true;
				unitPriceOtherDeviceTextBox4.Enabled = true;
				unitPriceOtherDevicePanel4.Enabled = true;
			}
			else
			{
				otherDeviceTextBox4.Enabled = false;
				otherDeviceTextBox4.Text = "Other Device";
				otherDeviceTextBox4.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				otherDevicePanel4.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				OtherDevice1 = string.Empty;
				otherDevicePanel4.Enabled = false;

				minusOtherDeviceButton4.Enabled = false;
				numberOtherDeviceLabel4.Text = "0";
				Number_OtherDevice4 = 0;
				addOtherDeviceButton4.Enabled = false;

				unitPriceOtherDeviceTextBox4.Enabled = false;
				unitPriceOtherDeviceTextBox4.Text = "قیمت واحد قیمت سایر اقلام";
				unitPriceOtherDeviceTextBox4.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				unitPriceOtherDevicePanel4.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				UnitPrice_OtherDevice4= 0;
				unitPriceOtherDevicePanel4.Enabled = false;

				totalPriceOtherDeviceLabel4.Text = "قیمت کل سایر اقلام";
				TotalPrice_OtherDevice4 = 0;
			}
		}
		#endregion /OtherDeviceCheckBox4_CheckedChanged 

		#region OtherDeviceTextBox4
		//-----
		#region OtherDeviceTextBox4_Enter
		private void OtherDeviceTextBox4_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.EnglishLanguage();
			otherDeviceTextBox4.ForeColor =
				Infrastructure.Utility.LimeColor();
			otherDevicePanel4.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(otherDeviceTextBox4.Text, "Other Device") == 0)
			{
				otherDeviceTextBox4.Clear();
			}
		}
		#endregion /OtherDeviceTextBox4_Enter

		#region OtherDeviceTextBox4_KeyPress
		private void OtherDeviceTextBox4_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.EnglishAndNumberTyping(e);
		}
		#endregion /OtherDeviceTextBox4_KeyPress

		#region OtherDeviceTextBox4_Leave
		private void OtherDeviceTextBox4_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(otherDeviceTextBox4.Text) || string.Compare(otherDeviceTextBox4.Text, "Other Device") == 0)
			{
				otherDeviceTextBox4.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				otherDevicePanel4.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();

				otherDeviceTextBox4.Text = "Other Device";
				OtherDevice4 = string.Empty;
			}
			else
			{
				otherDeviceTextBox4.ForeColor =
					Infrastructure.Utility.WhiteColor();
				otherDevicePanel4.BackColor =
					Infrastructure.Utility.WhiteColor();

				OtherDevice4 = otherDeviceTextBox4.Text;
			}
		}
		#endregion /OtherDeviceTextBox4_Leave
		//-----
		#endregion /OtherDeviceTextBox4

		#region MinusotherDeviceButton4_Click
		private void MinusotherDeviceButton4_Click(object sender, System.EventArgs e)
		{
			if (Number_OtherDevice4 <= 0)
			{
				return;
			}
			else
			{
				Number_OtherDevice4--;
				numberOtherDeviceLabel4.Text = Number_OtherDevice4.ToString();

				if (string.IsNullOrWhiteSpace(unitPriceOtherDeviceTextBox4.Text) || string.Compare(unitPriceOtherDeviceTextBox4.Text, "قیمت واحد سایر اقلام") == 0)
				{
					return;
				}
				else
				{
					TotalPrice_OtherDevice4 = UnitPrice_OtherDevice4 * Number_OtherDevice4;

					if (Number_OtherDevice4 == 0)
					{
						totalPriceOtherDeviceLabel4.Text = $"0 تومان";
						return;
					}
					else
					{
						totalPriceOtherDeviceLabel4.Text = $"{TotalPrice_OtherDevice4:#,0} تومان";
					}
				}
			}
		}
		#endregion /MinusotherDeviceButton4_Click

		#region AddotherDeviceButton4_Click
		private void AddotherDeviceButton4_Click(object sender, System.EventArgs e)
		{
			Number_OtherDevice4++;
			numberOtherDeviceLabel4.Text = Number_OtherDevice4.ToString();

			if (string.IsNullOrWhiteSpace(unitPriceOtherDeviceTextBox4.Text) || string.Compare(unitPriceOtherDeviceTextBox4.Text, "قیمت واحد سایر اقلام") == 0)
			{
				return;
			}
			else
			{
				TotalPrice_OtherDevice4 = UnitPrice_OtherDevice4 * Number_OtherDevice4;

				if (Number_OtherDevice4 == 0)
				{
					totalPriceOtherDeviceLabel4.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceOtherDeviceLabel4.Text = $"{TotalPrice_OtherDevice4:#,0} تومان";
				}
			}
		}
		#endregion /AddotherDeviceButton4_Click

		#region  UnitPriceOtherDeviceTextBox4
		//-----
		#region UnitPriceOtherDeviceTextBox4_Enter
		private void UnitPriceOtherDeviceTextBox4_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.EnglishLanguage();
			unitPriceOtherDeviceTextBox4.ForeColor =
				Infrastructure.Utility.LimeColor();
			unitPriceOtherDevicePanel4.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(unitPriceOtherDeviceTextBox4.Text, "قیمت واحد سایر اقلام") == 0)
			{
				unitPriceOtherDeviceTextBox4.Clear();
				unitPriceOtherDeviceTextBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				unitPriceOtherDeviceTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				return;
			}
		}
		#endregion /UnitPriceOtherDeviceTextBox4_Enter

		#region UnitPriceOtherDeviceTextBox4_KeyPress
		private void UnitPriceOtherDeviceTextBox4_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.EnglishAndNumberTyping(e);
		}
		#endregion /UnitPriceOtherDeviceTextBox4_KeyPress

		#region UnitPriceOtherDeviceTextBox4_Leave
		private void UnitPriceOtherDeviceTextBox4_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(unitPriceOtherDeviceTextBox4.Text) || string.Compare(unitPriceOtherDeviceTextBox4.Text, "قیمت واحد سایر اقلام") == 0)
			{
				unitPriceOtherDeviceTextBox4.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				unitPriceOtherDeviceTextBox4.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();

				unitPriceOtherDeviceTextBox4.Text = "قیمت واحد سایر اقلام";
				unitPriceOtherDeviceTextBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				unitPriceOtherDeviceTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				totalPriceOtherDeviceLabel4.Text = "قیمت کل سایر اقلام";
				totalPriceOtherDeviceLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				totalPriceOtherDeviceLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
				UnitPrice_OtherDevice4 = 0;
			}
			else
			{
				unitPriceOtherDeviceTextBox4.ForeColor =
					Infrastructure.Utility.WhiteColor();
				unitPriceOtherDevicePanel4.BackColor =
					Infrastructure.Utility.WhiteColor();
				unitPriceOtherDeviceTextBox4.Text = $"{UnitPrice_OtherDevice4:#,0} تومان";
				unitPriceOtherDeviceTextBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				unitPriceOtherDeviceTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			}

		}
		#endregion /UnitPriceOtherDeviceTextBox4_Leave

		#region UnitPriceOtherDeviceTextBox4_TextChanged
		private void UnitPriceOtherDeviceTextBox4_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(unitPriceOtherDeviceTextBox4.Text) || string.Compare(unitPriceOtherDeviceTextBox4.Text, "قیمت واحد سایر اقلام") == 0)
			{
				totalPriceOtherDeviceLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				totalPriceOtherDeviceLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
				totalPriceOtherDeviceLabel4.Text = "قیمت کل سایر اقلام";
				return;
			}
			else if (string.Compare(unitPriceOtherDeviceTextBox4.Text, "تومان") == 0 || string.Compare(unitPriceOtherDeviceTextBox4.Text, " تومان") == 0 || string.Compare(unitPriceOtherDeviceTextBox4.Text, "ومان") == 0 || string.Compare(unitPriceOtherDeviceTextBox4.Text, "مان") == 0 || string.Compare(unitPriceOtherDeviceTextBox4.Text, "ان") == 0 || string.Compare(unitPriceOtherDeviceTextBox4.Text, "ن") == 0)
			{
				Number_OtherDevice4 = 0;

				TotalPrice_OtherDevice4 = UnitPrice_OtherDevice4 * Number_OtherDevice4;

				if (Number_OtherDevice4 == 0)
				{
					totalPriceOtherDeviceLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceOtherDeviceLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceOtherDeviceLabel4.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceOtherDeviceLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceOtherDeviceLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceOtherDeviceLabel4.Text = $"{TotalPrice_OtherDevice4:#,0} تومان";
				}
				return;
			}
			else if (unitPriceOtherDeviceTextBox4.Text.Contains("تومان"))
			{
				Price = unitPriceOtherDeviceTextBox4.Text.Replace("تومان", string.Empty).Trim();
				UnitPrice_OtherDevice4 = int.Parse(Price.Replace(",", string.Empty).Trim());
				TotalPrice_OtherDevice4 = UnitPrice_OtherDevice4 * Number_OtherDevice4;

				if (Number_OtherDevice4 == 0)
				{
					totalPriceOtherDeviceLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceOtherDeviceLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceOtherDeviceLabel4.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceOtherDeviceLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceOtherDeviceLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceOtherDeviceLabel4.Text = $"{TotalPrice_OtherDevice4:#,0} تومان";
				}
				return;
			}
			else
			{
				Price = unitPriceOtherDeviceTextBox4.Text.Replace("تومان", string.Empty).Trim();
				UnitPrice_OtherDevice4 = int.Parse(Price.Replace(",", string.Empty).Trim());
				TotalPrice_OtherDevice4 = UnitPrice_OtherDevice4 * Number_OtherDevice4;

				if (Number_OtherDevice4 == 0)
				{
					totalPriceOtherDeviceLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceOtherDeviceLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceOtherDeviceLabel4.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceOtherDeviceLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceOtherDeviceLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceOtherDeviceLabel4.Text = $"{TotalPrice_OtherDevice4:#,0} تومان";
				}
			}
		}
		#endregion /UnitPriceOtherDeviceTextBox4_TextChanged
		//-----
		#endregion /UnitPriceOtherDeviceTextBox4

		#region TotalPriceOtherDeviceLabel4_TextChanged
		private void TotalPriceOtherDeviceLabel4_TextChanged(object sender, System.EventArgs e)
		{
			if (string.Compare(totalPriceOtherDeviceLabel4.Text, "قیمت کل سایر اقلام") == 0)
			{
				TotalPrice_OtherDevice4 = 0;
				SumTotoalPrice(TotalPrice_MainBoard, TotalPrice_Processor, TotalPrice_RAM, TotalPrice_HDD, TotalPrice_DVDROM, TotalPrice_GraphicCard, TotalPrice_Keyboard, TotalPrice_Mouse, TotalPrice_Speaker, TotalPrice_Monitor, TotalPrice_OtherDevice1, TotalPrice_OtherDevice2, TotalPrice_OtherDevice3, TotalPrice_OtherDevice4, TotalPrice_OtherDevice5);

				return;
			}
			else
			{
				SumTotoalPrice(TotalPrice_MainBoard, TotalPrice_Processor, TotalPrice_RAM, TotalPrice_HDD, TotalPrice_DVDROM, TotalPrice_GraphicCard, TotalPrice_Keyboard, TotalPrice_Mouse, TotalPrice_Speaker, TotalPrice_Monitor, TotalPrice_OtherDevice1, TotalPrice_OtherDevice2, TotalPrice_OtherDevice3, TotalPrice_OtherDevice4, TotalPrice_OtherDevice5);
			}
		}
		#endregion /TotalPriceOtherDeviceLabel4_TextChanged
		//-----
		#endregion /OtherDevice4

		#region OtherDevice5
		//-----
		#region OtherDeviceCheckBox5_CheckedChanged
		private void OtherDeviceCheckBox5_CheckedChanged(object sender, System.EventArgs e)
		{
			if (otherDeviceCheckBox5.Checked == true)
			{
				otherDeviceTextBox5.Enabled = true;
				otherDevicePanel5.Enabled = true;
				minusOtherDeviceButton5.Enabled = true;
				addOtherDeviceButton5.Enabled = true;
				unitPriceOtherDeviceTextBox5.Enabled = true;
				unitPriceOtherDevicePanel5.Enabled = true;
			}
			else
			{
				otherDeviceTextBox5.Enabled = false;
				otherDeviceTextBox5.Text = "Other Device";
				otherDeviceTextBox5.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				otherDevicePanel5.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				OtherDevice5 = string.Empty;
				otherDevicePanel5.Enabled = false;

				minusOtherDeviceButton5.Enabled = false;
				numberOtherDeviceLabel5.Text = "0";
				Number_OtherDevice5 = 0;
				addOtherDeviceButton5.Enabled = false;

				unitPriceOtherDeviceTextBox5.Enabled = false;
				unitPriceOtherDeviceTextBox5.Text = "قیمت واحد قیمت سایر اقلام";
				unitPriceOtherDeviceTextBox5.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				unitPriceOtherDevicePanel5.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				UnitPrice_OtherDevice5 = 0;
				unitPriceOtherDevicePanel5.Enabled = false;

				totalPriceOtherDeviceLabel5.Text = "قیمت کل سایر اقلام";
				TotalPrice_OtherDevice5 = 0;
			}
		}
		#endregion /OtherDeviceCheckBox5_CheckedChanged 

		#region OtherDeviceTextBox5
		//-----
		#region OtherDeviceTextBox5_Enter
		private void OtherDeviceTextBox5_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.EnglishLanguage();
			otherDeviceTextBox5.ForeColor =
				Infrastructure.Utility.LimeColor();
			otherDevicePanel5.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(otherDeviceTextBox5.Text, "Other Device") == 0)
			{
				otherDeviceTextBox5.Clear();
			}
		}
		#endregion /OtherDeviceTextBox5_Enter

		#region OtherDeviceTextBox5_KeyPress
		private void OtherDeviceTextBox5_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.EnglishAndNumberTyping(e);
		}
		#endregion /OtherDeviceTextBox5_KeyPress

		#region OtherDeviceTextBox5_Leave
		private void OtherDeviceTextBox5_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(otherDeviceTextBox5.Text) || string.Compare(otherDeviceTextBox5.Text, "Other Device") == 0)
			{
				otherDeviceTextBox5.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				otherDevicePanel5.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();

				otherDeviceTextBox5.Text = "Other Device";
				OtherDevice5 = string.Empty;
			}
			else
			{
				otherDeviceTextBox5.ForeColor =
					Infrastructure.Utility.WhiteColor();
				otherDeviceTextBox5.BackColor =
					Infrastructure.Utility.WhiteColor();

				OtherDevice5 = otherDeviceTextBox5.Text;
			}
		}
		#endregion /OtherDeviceTextBox5_Leave 
		//-----
		#endregion /OtherDeviceTextBox5

		#region MinusotherDeviceButton5_Click
		private void MinusotherDeviceButton5_Click(object sender, System.EventArgs e)
		{
			if (Number_OtherDevice5 <= 0)
			{
				return;
			}
			else
			{
				Number_OtherDevice5--;
				numberOtherDeviceLabel5.Text = Number_OtherDevice5.ToString();

				if (string.IsNullOrWhiteSpace(unitPriceOtherDeviceTextBox5.Text) || string.Compare(unitPriceOtherDeviceTextBox5.Text, "قیمت واحد سایر اقلام") == 0)
				{
					return;
				}
				else
				{
					TotalPrice_OtherDevice5 = UnitPrice_OtherDevice5 * Number_OtherDevice5;

					if (Number_OtherDevice5 == 0)
					{
						totalPriceOtherDeviceLabel5.Text = $"0 تومان";
						return;
					}
					else
					{
						totalPriceOtherDeviceLabel5.Text = $"{TotalPrice_OtherDevice5:#,0} تومان";
					}
				}
			}
		}
		#endregion /MinusotherDeviceButton5_Click

		#region AddotherDeviceButton5_Click
		private void AddotherDeviceButton5_Click(object sender, System.EventArgs e)
		{
			Number_OtherDevice5++;
			numberOtherDeviceLabel5.Text = Number_OtherDevice5.ToString();

			if (string.IsNullOrWhiteSpace(unitPriceOtherDeviceTextBox5.Text) || string.Compare(unitPriceOtherDeviceTextBox5.Text, "قیمت واحد سایر اقلام") == 0)
			{
				return;
			}
			else
			{
				TotalPrice_OtherDevice5 = UnitPrice_OtherDevice5 * Number_OtherDevice5;

				if (Number_OtherDevice5 == 0)
				{
					totalPriceOtherDeviceLabel5.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceOtherDeviceLabel5.Text = $"{TotalPrice_OtherDevice5:#,0} تومان";
				}
			}
		}
		#endregion /AddotherDeviceButton5_Click

		#region UnitPriceOtherDeviceTextBox5
		//-----
		#region UnitPriceOtherDeviceTextBox5_Enter
		private void UnitPriceOtherDeviceTextBox5_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.EnglishLanguage();
			unitPriceOtherDeviceTextBox5.ForeColor =
				Infrastructure.Utility.LimeColor();
			unitPriceOtherDevicePanel5.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(unitPriceOtherDeviceTextBox5.Text, "قیمت واحد سایر اقلام") == 0)
			{
				unitPriceOtherDeviceTextBox5.Clear();
				unitPriceOtherDeviceTextBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				unitPriceOtherDeviceTextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				return;
			}
		}
		#endregion /UnitPriceOtherDeviceTextBox5_Enter

		#region UnitPriceOtherDeviceTextBox5_KeyPress
		private void UnitPriceOtherDeviceTextBox5_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.EnglishAndNumberTyping(e);
		}
		#endregion /UnitPriceOtherDeviceTextBox5_KeyPress

		#region UnitPriceOtherDeviceTextBox5_Leave
		private void UnitPriceOtherDeviceTextBox5_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(unitPriceOtherDeviceTextBox5.Text) || string.Compare(unitPriceOtherDeviceTextBox5.Text, "قیمت واحد سایر اقلام") == 0)
			{
				unitPriceOtherDeviceTextBox5.ForeColor =
					Infrastructure.Utility.MediumSlateBlueColor();
				unitPriceOtherDevicePanel5.BackColor =
					Infrastructure.Utility.MediumSlateBlueColor();

				unitPriceOtherDeviceTextBox5.Text = "قیمت واحد سایر اقلام";
				unitPriceOtherDeviceTextBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				unitPriceOtherDeviceTextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				totalPriceOtherDeviceLabel5.Text = "قیمت کل سایر اقلام";
				totalPriceOtherDeviceLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				totalPriceOtherDeviceLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
				UnitPrice_OtherDevice5 = 0;
			}
			else
			{
				unitPriceOtherDeviceTextBox5.ForeColor =
					Infrastructure.Utility.WhiteColor();
				unitPriceOtherDevicePanel5.BackColor =
					Infrastructure.Utility.WhiteColor();
				unitPriceOtherDeviceTextBox5.Text = $"{UnitPrice_OtherDevice5:#,0} تومان";
				unitPriceOtherDeviceTextBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				unitPriceOtherDeviceTextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			}
		}
		#endregion /UnitPriceOtherDeviceTextBox5_Leave

		#region UnitPriceOtherDeviceTextBox5_TextChanged
		private void UnitPriceOtherDeviceTextBox5_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(unitPriceOtherDeviceTextBox5.Text) || string.Compare(unitPriceOtherDeviceTextBox5.Text, "قیمت واحد سایر اقلام") == 0)
			{
				totalPriceOtherDeviceLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				totalPriceOtherDeviceLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
				totalPriceOtherDeviceLabel5.Text = "قیمت کل سایر اقلام";
				return;
			}
			else if (string.Compare(unitPriceOtherDeviceTextBox5.Text, "تومان") == 0 || string.Compare(unitPriceOtherDeviceTextBox5.Text, " تومان") == 0 || string.Compare(unitPriceOtherDeviceTextBox5.Text, "ومان") == 0 || string.Compare(unitPriceOtherDeviceTextBox5.Text, "مان") == 0 || string.Compare(unitPriceOtherDeviceTextBox5.Text, "ان") == 0 || string.Compare(unitPriceOtherDeviceTextBox5.Text, "ن") == 0)
			{
				Number_OtherDevice5 = 0;

				TotalPrice_OtherDevice5 = UnitPrice_OtherDevice5 * Number_OtherDevice5;

				if (Number_OtherDevice5 == 0)
				{
					totalPriceOtherDeviceLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceOtherDeviceLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceOtherDeviceLabel5.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceOtherDeviceLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceOtherDeviceLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceOtherDeviceLabel5.Text = $"{TotalPrice_OtherDevice5:#,0} تومان";
				}
				return;
			}
			else if (unitPriceOtherDeviceTextBox5.Text.Contains("تومان"))
			{
				Price = unitPriceOtherDeviceTextBox5.Text.Replace("تومان", string.Empty).Trim();
				UnitPrice_OtherDevice5 = int.Parse(Price.Replace(",", string.Empty).Trim());
				TotalPrice_OtherDevice5 = UnitPrice_OtherDevice5 * Number_OtherDevice5;

				if (Number_OtherDevice5 == 0)
				{
					totalPriceOtherDeviceLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceOtherDeviceLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceOtherDeviceLabel5.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceOtherDeviceLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceOtherDeviceLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceOtherDeviceLabel5.Text = $"{TotalPrice_OtherDevice5:#,0} تومان";
				}
				return;
			}
			else
			{
				Price = unitPriceOtherDeviceTextBox5.Text.Replace("تومان", string.Empty).Trim();
				UnitPrice_OtherDevice5 = int.Parse(Price.Replace(",", string.Empty).Trim());
				TotalPrice_OtherDevice5 = UnitPrice_OtherDevice5 * Number_OtherDevice5;

				if (Number_OtherDevice4 == 0)
				{
					totalPriceOtherDeviceLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceOtherDeviceLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceOtherDeviceLabel5.Text = $"0 تومان";
					return;
				}
				else
				{
					totalPriceOtherDeviceLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					totalPriceOtherDeviceLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					totalPriceOtherDeviceLabel5.Text = $"{TotalPrice_OtherDevice5:#,0} تومان";
				}
			}
		}
		#endregion /UnitPriceOtherDeviceTextBox5_TextChanged
		//-----
		#endregion /UnitPriceOtherDeviceTextBox5

		#region TotalPriceOtherDeviceLabel5_TextChanged
		private void TotalPriceOtherDeviceLabel5_TextChanged(object sender, System.EventArgs e)
		{
			if (string.Compare(totalPriceOtherDeviceLabel5.Text, "قیمت کل سایر اقلام") == 0)
			{
				TotalPrice_OtherDevice5 = 0;
				SumTotoalPrice(TotalPrice_MainBoard, TotalPrice_Processor, TotalPrice_RAM, TotalPrice_HDD, TotalPrice_DVDROM, TotalPrice_GraphicCard, TotalPrice_Keyboard, TotalPrice_Mouse, TotalPrice_Speaker, TotalPrice_Monitor, TotalPrice_OtherDevice1, TotalPrice_OtherDevice2, TotalPrice_OtherDevice3, TotalPrice_OtherDevice4, TotalPrice_OtherDevice5);

				return;
			}
			else
			{
				SumTotoalPrice(TotalPrice_MainBoard, TotalPrice_Processor, TotalPrice_RAM, TotalPrice_HDD, TotalPrice_DVDROM, TotalPrice_GraphicCard, TotalPrice_Keyboard, TotalPrice_Mouse, TotalPrice_Speaker, TotalPrice_Monitor, TotalPrice_OtherDevice1, TotalPrice_OtherDevice2, TotalPrice_OtherDevice3, TotalPrice_OtherDevice4, TotalPrice_OtherDevice5);
			}
		}
		#endregion /TotalPriceOtherDeviceLabel5_TextChanged
		//-----
		#endregion /OtherDevice5

		#region TotalInvoiceLabel_TextChanged
		private void TotalInvoiceLabel_TextChanged(object sender, System.EventArgs e)
		{
			ButtonActivate();
		}
		#endregion /TotalInvoiceLabel_TextChanged

		#region ResetButton_Click
		private void ResetButton_Click(object sender, System.EventArgs e)
		{
			ResetControls();
			ResetProperties();
		}
		#endregion /ResetButton_Click

		#region CancelButton_Click
		private void CancelButton_Click(object sender, System.EventArgs e)
		{
			Cancel();
		}
		#endregion /CancelButton_Click


		#region MyRePanel_MouseDown
		//-----
		#region TitelPanel_MouseDown
		private void TitelPanel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		#endregion /TitelPanel_MouseDown

		#region SideWallpaperPanel_MouseDown
		private void SideWallpaperPanel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		#endregion /SideWallpaperPanel_MouseDown 
		//-----
		#endregion /Panel_MouseDown

		//-----End of the Code Line.

		#region Founctions
		//-----
		#region ResetProperties
		private void ResetProperties()
		{
			Price = string.Empty;

			UnitPrice_MainBoard = 0;
			TotalPrice_MainBoard = 0;
			
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
		#endregion /ResetProperties

		#region SumTotoalPrice
		private void SumTotoalPrice(int priceMainBoard, int priceProcess, int priceRAM, int priceHDD, int priceDVDRom, int priceGraphic, int priceKeyboard, int priceMouse, int priceSpeaker, int priceMonitor, int priceDevice1, int priceDevice2, int priceDevice3, int priceDevice4, int priceDevice5)
		{
			string resualtSum;
			int sumPrice = priceMainBoard + priceProcess + priceRAM + priceHDD + priceDVDRom + priceGraphic + priceKeyboard + priceMouse + priceSpeaker + priceMonitor + priceDevice1 + priceDevice2 + priceDevice3 + priceDevice4 + priceDevice5;
			resualtSum = $"{sumPrice:#,0} تومان";
			totalInvoiceLabel.Text = resualtSum;
		}
		#endregion /SumTotoalPrice

		#region ResetControls
		private void ResetControls()
		{
			//----------------------------------------------------------------------------------------------------Mainboard
			mainBoardCheckBox.Checked = false;
			mainBoardTextBox.Text = "MainBoard";
			mainBoardTextBox.ForeColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			mainBoardPanel.BackColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			numberMainBoardLabel.Text = "0";
			unitPriceMainBoardTextBox.Text = "قیمت واحد مادربرد";
			unitPriceMainBoardTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			unitPriceMainBoardTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			unitPriceMainBoardTextBox.ForeColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			unitPriceMainBoardPanel.BackColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			totalPriceMainBoardLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			totalPriceMainBoardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			totalPriceMainBoardLabel.Text = "قیمت کل مادربرد";
			//----------------------------------------------------------------------------------------------------Processor
			processorCheckBox.Checked = false;
			processorTextBox.Text = "Processor";
			processorTextBox.ForeColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			processorPanel.BackColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			numberProcessorLabel.Text = "0";
			unitPriceProcessorTextBox.Text = "قیمت واحد پردازنده";
			unitPriceProcessorTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			unitPriceProcessorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			unitPriceProcessorTextBox.ForeColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			unitPriceProcessorPanel.BackColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			totalPriceProcessorLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			totalPriceProcessorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			totalPriceProcessorLabel.Text = "قیمت کل پردازنده";
			//----------------------------------------------------------------------------------------------------RAM
			ramCheckBox.Checked = false;
			ramTextBox.Text = "RAM";
			ramTextBox.ForeColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			ramPanel.BackColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			numberRAMLabel.Text = "0";
			unitPriceRAMTextBox.Text = "قیمت واحد رم";
			unitPriceRAMTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			unitPriceRAMTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			unitPriceRAMTextBox.ForeColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			unitPriceRAMPanel.BackColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			totalPriceRAMLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			totalPriceRAMLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			totalPriceRAMLabel.Text = "قیمت کل رم";
			//----------------------------------------------------------------------------------------------------H.D.D
			hddCheckBox.Checked = false;
			hddTextBox.Text = "H.D.D";
			hddTextBox.ForeColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			hddPanel.BackColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			numberHDDLabel.Text = "0";
			unitPriceHDDTextBox.Text = "قیمت واحد هارد دیسک";
			unitPriceHDDTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			unitPriceHDDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			unitPriceHDDTextBox.ForeColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			unitPriceHDDPanel.BackColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			totalPriceHDDLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			totalPriceHDDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			totalPriceHDDLabel.Text = "قیمت کل دیسک";
			//----------------------------------------------------------------------------------------------------DVD-ROM
			dvdRomCheckBox.Checked = false;
			dvdRomTextBox.Text = "DVD-ROM";
			dvdRomTextBox.ForeColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			dvdRomPanel.BackColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			numberDVDRomLabel.Text = "0";
			unitPriceDVDRomTextBox.Text = "قیمت واحد دی وی دی رام";
			unitPriceDVDRomTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			unitPriceDVDRomTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			unitPriceDVDRomTextBox.ForeColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			unitPriceDVDRomPanel.BackColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			totalPriceDVDRomLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			totalPriceDVDRomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			totalPriceDVDRomLabel.Text = "قیمت کل دی وی دی رام";
			//----------------------------------------------------------------------------------------------------Graphic Card
			graphicCardCheckBox.Checked = false;
			graphicCardTextBox.Text = "Graphic Card";
			graphicCardTextBox.ForeColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			graphicCardPanel.BackColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			numberGraphicCardLabel.Text = "0";
			unitPriceGraphicCardTextBox.Text = "قیمت واحد کارت گرافیک";
			unitPriceGraphicCardTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			unitPriceGraphicCardTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			unitPriceGraphicCardTextBox.ForeColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			unitPriceGraphicCardPanel.BackColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			totalPriceGraphicCardLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			totalPriceGraphicCardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			totalPriceGraphicCardLabel.Text = "قیمت کل کارت گرافیک";
			//----------------------------------------------------------------------------------------------------Keyboard
			keyboardCheckBox.Checked = false;
			keyboardTextBox.Text = "Keyboard";
			keyboardTextBox.ForeColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			keyboardPanel.BackColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			numberKeyboardLabel.Text = "0";
			unitPriceKeyboardTextBox.Text = "قیمت واحد صفحه کلید";
			unitPriceKeyboardTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			unitPriceKeyboardTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			unitPriceKeyboardTextBox.ForeColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			unitPriceKeyboardPanel.BackColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			totalPriceKeyboardLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			totalPriceKeyboardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			totalPriceKeyboardLabel.Text = "قیمت کل صفحه کلید";
			//----------------------------------------------------------------------------------------------------Mouse
			mouseCheckBox.Checked = false;
			mouseTextBox.Text = "Mouse";
			mouseTextBox.ForeColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			mousePanel.BackColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			numberMouseLabel.Text = "0";
			unitPriceMouseTextBox.Text = "قیمت واحد ماوس";
			unitPriceMouseTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			unitPriceMouseTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			unitPriceMouseTextBox.ForeColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			unitPriceMousePanel.BackColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			totalPriceMouseLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			totalPriceMouseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			totalPriceMouseLabel.Text = "قیمت کل ماوس";
			//----------------------------------------------------------------------------------------------------Speaker
			speakerCheckBox.Checked = false;
			speakerTextBox.Text = "Speaker";
			speakerTextBox.ForeColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			speakerPanel.BackColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			numberSpeakerLabel.Text = "0";
			unitPriceSpeakerTextBox.Text = "قیمت واحد بلندگو";
			unitPriceSpeakerTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			unitPriceSpeakerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			unitPriceSpeakerTextBox.ForeColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			unitPriceSpeakerPanel.BackColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			totalPriceSpeakerLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			totalPriceSpeakerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			totalPriceSpeakerLabel.Text = "قیمت کل بلندگو";
			//----------------------------------------------------------------------------------------------------Monitor
			monitorCheckBox.Checked = false;
			monitorTextBox.Text = "Monitor";
			monitorTextBox.ForeColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			monitorPanel.BackColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			numberMonitorLabel.Text = "0";
			unitPriceMonitorTextBox.Text = "قیمت واحد مانیتور";
			unitPriceMonitorTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			unitPriceMonitorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			unitPriceMonitorTextBox.ForeColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			unitPriceMonitorPanel.BackColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			totalPriceMonitorLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			totalPriceMonitorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			totalPriceMonitorLabel.Text = "قیمت کل مانیتور";
			//----------------------------------------------------------------------------------------------------Other Device1
			otherDeviceCheckBox1.Checked = false;
			otherDeviceTextBox1.Text = "Other Device";
			otherDeviceTextBox1.ForeColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			otherDevicePanel1.BackColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			numberOtherDeviceLabel1.Text = "0";
			unitPriceOtherDeviceTextBox1.Text = "قیمت واحد سایر اقلام";
			unitPriceOtherDeviceTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			unitPriceOtherDeviceTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			unitPriceOtherDeviceTextBox1.ForeColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			unitPriceOtherDevicePanel1.BackColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			totalPriceOtherDeviceLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			totalPriceOtherDeviceLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			totalPriceOtherDeviceLabel1.Text = "قیمت کل سایر اقلام";
			//----------------------------------------------------------------------------------------------------Other Device2
			otherDeviceCheckBox2.Checked = false;
			otherDeviceTextBox2.Text = "Other Device";
			otherDeviceTextBox2.ForeColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			otherDevicePanel2.BackColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			numberOtherDeviceLabel2.Text = "0";
			unitPriceOtherDeviceTextBox2.Text = "قیمت واحد سایر اقلام";
			unitPriceOtherDeviceTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			unitPriceOtherDeviceTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			unitPriceOtherDeviceTextBox2.ForeColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			unitPriceOtherDevicePanel2.BackColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			totalPriceOtherDeviceLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			totalPriceOtherDeviceLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			totalPriceOtherDeviceLabel2.Text = "قیمت کل سایر اقلام";
			//----------------------------------------------------------------------------------------------------Other Device3
			otherDeviceCheckBox3.Checked = false;
			otherDeviceTextBox3.Text = "Other Device";
			otherDeviceTextBox3.ForeColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			otherDevicePanel3.BackColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			numberOtherDeviceLabel3.Text = "0";
			unitPriceOtherDeviceTextBox3.Text = "قیمت واحد سایر اقلام";
			unitPriceOtherDeviceTextBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			unitPriceOtherDeviceTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			unitPriceOtherDeviceTextBox3.ForeColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			unitPriceOtherDevicePanel3.BackColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			totalPriceOtherDeviceLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			totalPriceOtherDeviceLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			totalPriceOtherDeviceLabel3.Text = "قیمت کل سایر اقلام";
			//----------------------------------------------------------------------------------------------------Other Device4
			otherDeviceCheckBox4.Checked = false;
			otherDeviceTextBox4.Text = "Other Device";
			otherDeviceTextBox4.ForeColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			otherDevicePanel4.BackColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			numberOtherDeviceLabel4.Text = "0";
			unitPriceOtherDeviceTextBox4.Text = "قیمت واحد سایر اقلام";
			unitPriceOtherDeviceTextBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			unitPriceOtherDeviceTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			unitPriceOtherDeviceTextBox4.ForeColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			unitPriceOtherDevicePanel4.BackColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			totalPriceOtherDeviceLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			totalPriceOtherDeviceLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			totalPriceOtherDeviceLabel4.Text = "قیمت کل سایر اقلام";
			//----------------------------------------------------------------------------------------------------Other Device5
			otherDeviceCheckBox5.Checked = false;
			otherDeviceTextBox5.Text = "Other Device";
			otherDeviceTextBox5.ForeColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			otherDevicePanel5.BackColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			numberOtherDeviceLabel5.Text = "0";
			unitPriceOtherDeviceTextBox5.Text = "قیمت واحد سایر اقلام";
			unitPriceOtherDeviceTextBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			unitPriceOtherDeviceTextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			unitPriceOtherDeviceTextBox5.ForeColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			unitPriceOtherDevicePanel5.BackColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			totalPriceOtherDeviceLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			totalPriceOtherDeviceLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			totalPriceOtherDeviceLabel5.Text = "قیمت کل سایر اقلام";
			//----------------------------------------------------------------------------------------------------
			totalInvoiceLabel.Text = "0 تومان";
		}
		#endregion /ResetControls

		#region Cancel
		private void Cancel()
		{
			if (mainBoardCheckBox.Checked == true ||
				processorCheckBox.Checked == true ||
				ramCheckBox.Checked == true ||
				hddCheckBox.Checked == true ||
				dvdRomCheckBox.Checked == true ||
				graphicCardCheckBox.Checked == true ||
				keyboardCheckBox.Checked == true ||
				mouseCheckBox.Checked == true ||
				speakerCheckBox.Checked == true ||
				monitorCheckBox.Checked == true ||
				otherDeviceCheckBox1.Checked == true ||
				otherDeviceCheckBox2.Checked == true ||
				otherDeviceCheckBox3.Checked == true ||
				otherDeviceCheckBox4.Checked == true ||
				otherDeviceCheckBox5.Checked == true)
			{
				System.Windows.Forms.DialogResult dialogResult =
				Mbb.Windows.Forms.MessageBox.Show(text: "آیا قصد انصراف از خرید دارید؟", caption: "انصراف از خرید", icon: Mbb.Windows.Forms.MessageBoxIcon.Question, button: Mbb.Windows.Forms.MessageBoxButtons.YesNo);

				if (dialogResult == System.Windows.Forms.DialogResult.Yes)
				{
					this.Close();
				}
			}
			else
			{
				this.Close();
			}
		}
		#endregion /Cancel

		#region ButtonActivate
		private void ButtonActivate() 
		{
			if (string.Compare(totalInvoiceLabel.Text, "0 تومان") == 0)
			{
				cancelButton.Enabled = false;
				resetButton.Enabled = false;
				printButton.Enabled = false;
				saveButton.Enabled = false;
			}
			else
			{
				cancelButton.Enabled = true;
				resetButton.Enabled = true;
				printButton.Enabled = true;
				saveButton.Enabled = true;
			}
		}

		#endregion /ButtonActivate

		#region InvoiceNumber
		/// <summary>
		/// تابعی که به تعداد 7 کاراکتر حروف و عدد به صورت تصادوفی
		///  و ترکیبی ایجاد کرده و به ما بر میگرداند.
		/// </summary>
		/// <returns>ممبر letter که حاصل دریافت ترکیبی عدد و حرف میباشد نتیجه این تابع میباشد. </returns>
		private string GeneratInvoiceNumber()
		{
			int count, number1, number2;

			string[] text = new string[3];
			string letter = string.Empty;

			System.Random randomCount = new System.Random();
			System.Random randomNumber = new System.Random();
			System.Random random = new System.Random();

			for (int i = 1; i <= 8; i++)
			{
				count = randomCount.Next(0, 2);

				if (count == 0)
				{
					number1 = randomNumber.Next(0, 10);
					letter += number1.ToString();
				}
				else if (count == 1)
				{
					for (int k = 0; k < 1; k++)
					{
						number2 = random.Next(65, 91);
						text[k] = System.Convert.ToChar(number2).ToString();
						letter += text[k];
					}
				}
			}

			for (int i = 1; i < 9; i++)
			{
				if (i % 5 == 0)
				{
					letter = letter.Insert(i - 1, "-");
				}
			}
			return letter;
		}
		#endregion /InvoiceNumber


		//-----
		#endregion /Founctions

		private void PrintButton_Click(object sender, System.EventArgs e)
		{
			Stimulsoft.Report.StiReport report = new Stimulsoft.Report.StiReport();

			report.Load("ComputertAssembl.mrt");
			report.Show();
			//report.RegBusinessObject("FoodOrder", lists);
		}

		private void SaveButton_Click(object sender, System.EventArgs e)
		{

		}
	}
}
