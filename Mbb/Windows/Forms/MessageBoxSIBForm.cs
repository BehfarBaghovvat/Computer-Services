﻿namespace Mbb.Windows.Forms
{
	public partial class MessageBoxSIBForm : Form
	{
		public MessageBoxSIBForm()
		{
			InitializeComponent();
		}

		#region Properties
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
		public string OKName
		{
			get
			{
				return okButton.Name;
			}
			set
			{
				okButton.Name = value;
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
		#endregion /Properties

		//-----Begining of the codes.

		#region MessageLabel_SizeChanged
		private void MessageLabel_SizeChanged(object sender, System.EventArgs e)
		{
			this.Size = new System.Drawing.Size(width: this.Width, height: this.Height + messageLabel.Height);
		}
		#endregion /MessageLabel_SizeChanged
	}
}
