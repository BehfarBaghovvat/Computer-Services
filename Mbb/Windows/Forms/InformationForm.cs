namespace Mbb.Windows.Forms
{
	public partial class InformationForm : System.Windows.Forms.Form
	{
		public InformationForm()
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
	}
}
