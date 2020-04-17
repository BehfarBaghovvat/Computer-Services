
namespace Mbb.Windows.Forms
{
	public partial class QuestionForm : System.Windows.Forms.Form
	{
		public QuestionForm()
		{
			InitializeComponent();
		}

		public string Message
		{
			get { return messageLabel.Text; }
			set { messageLabel.Text = value; }
		}

		public string Caption
		{
			get { return captionLabel.Text; }
			set { captionLabel.Text = value; }
		}

		private void MessageLabel_SizeChanged(object sender, System.EventArgs e)
		{
			this.Size = new System.Drawing.Size(width: this.Width, height: this.Height + messageLabel.Height);
		}

		private void NoButton_Click(object sender, System.EventArgs e)
		{
			return;
		}
	}
}
