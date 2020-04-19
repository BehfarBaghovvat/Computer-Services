﻿namespace Mbb.Windows.Forms
{
	public partial class MessageBoxSIBForm : Form
	{
		public MessageBoxSIBForm()
		{
			InitializeComponent();
		}

		public string Message
		{
			get
			{
				return messageLabel.Text;
			}
			set
			{
				messageLabel.Text = value;
			}
		}
		public string Caption
		{
			get
			{
				return captionLabel.Text;
			}
			set
			{
				captionLabel.Text = value;
			}
		}
		public System.Drawing.Color OKBackColor
		{
			get
			{
				return yesButton.BackColor;
			}
			set
			{
				yesButton.BackColor = value;
			}
		}
		public System.Drawing.Image Icon
		{
			get
			{
				return iconPicturBox.Image;
			}
			set
			{
				iconPicturBox.Image = value;
			}
		}

		private void MessageLabel_SizeChanged(object sender, System.EventArgs e)
		{
			this.Size = new System.Drawing.Size(width: this.Width, height: this.Height + messageLabel.Height);
		}
	}
}