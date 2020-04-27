using System;

namespace ComputerServices
{
	public partial class TestForm : Infrastructure.BaseForm
	{
		public TestForm()
		{
			InitializeComponent();
		}

		public int width;
		public string text;
		private void button1_Click(object sender, System.EventArgs e)
		{

			//Infrastructure.Utility.WindowsNotification
			//	(message: textBox1.Text, 
			//	caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);

			messageLabel.Text = textBox1.Text;









			//messageLabel.Text = textBox1.Text;
		}

		private void textBox1_TextChanged(object sender, System.EventArgs e)
		{
			
		}

		private void messageLabel_TextChanged(object sender, System.EventArgs e)
		{
			

		}
	}
}
