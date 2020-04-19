namespace ComputerServices
{
	public partial class TestForm : Infrastructure.BaseForm
	{
		public TestForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			//Infrastructure.Utility.WindowsNotification
			//	(message: textBox1.Text, 
			//	caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);

			messageLabel.Text = textBox1.Text;
		}
	}
}
