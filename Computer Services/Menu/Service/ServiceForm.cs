using Stimulsoft.Report;
using System.Linq;

namespace ComputerServices.Menu.Service
{
	public partial class ServiceForm : Infrastructure.BaseForm
	{
		public ServiceForm()
		{
			InitializeComponent();
		}

		#region Properties

		#endregion /Properties


		//-----The beginning of the coding line.

		#region NewCodeButton_Click
		private void NewCodeButton_Click(object sender, System.EventArgs e)
		{
			invoiceNumberLabel.Text = InvoiceNumber();
			string invoiceNumber = InvoiceNumber();

			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();
				Models.ServiceComputer serviceComputer =
					dataBaseContext.ServiceComputers
					.Where(current => string.Compare(current.Invoice_Number, invoiceNumber) == 0)
					.FirstOrDefault();
				if (serviceComputer != null)
				{
					confirmStatusPicturBox.Visible = true;
					invoiceNumber = string.Empty;
					confirmStatusPicturBox.Image =
						Properties.Resources.Tik_False;
				}
				else
				{
					confirmStatusPicturBox.Visible = true;
					confirmStatusPicturBox.Image =
						Properties.Resources.Tik_True;
				}
			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
			}
		}
		#endregion /NewCodeButton_Click
		//-----End of coding line

		#region Functions
		//------
		#region InvoiceNumber
		/// <summary>
		/// تابعی که یه تعداد 7 کاراکتر حروف و عدد به صورت تصادوفی
		///  و ترکیبی ایجاد کرده و به ما بر میگرداند.
		/// </summary>
		/// <returns>ممبر letter که حاصل دریافت ترکیبی عدد و حرف میباشد نتیجه این تابع میباشد. </returns>
		private string InvoiceNumber()
		{
			int count, number1, number2;

			string[] text = new string[3];
			string letter = string.Empty;

			System.Random randomCount = new System.Random();
			System.Random randomNumber = new System.Random();
			System.Random random = new System.Random();

			for (int i= 1; i <= 20; i++)
			{
				count = randomCount.Next(0,2);

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

			for (int i = 1; i < 21; i++)
			{
				if (i % 6 == 0)
				{
					letter = letter.Insert(i-1, "-");
				}
			}

			return letter;
		}

		#endregion /InvoiceNumber

		//-----
		#endregion /Functions

		private void invoicePrintButton_Click(object sender, System.EventArgs e)
		{
			StiReport report = new StiReport();
			report.Show();
		}
	}
}
