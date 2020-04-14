
namespace Infrastracture
{
	public partial class PopupNotificationForm : BaseForm
	{
		public PopupNotificationForm()
		{
			InitializeComponent();
		}

		#region Properties
		public enum Action
		{
			wait,
			start,
			close,
		}
		public enum Caption
		{
			موفقیت,
			اخطار,
			خطا,
			اطلاع,
		}
		private PopupNotificationForm.Action action;
		private int x, y;
		#endregion /Properties
		//-----Biginning of the codes.
		#region CancelButton_Click
		private void CancelButton_Click(object sender, System.EventArgs e)
		{
			timer1.Interval = 1;
			this.action = Action.close;
		}
		#endregion /CancelButton_Click

		#region Timer1_Tick
		private void Timer1_Tick(object sender, System.EventArgs e)
		{
			switch (this.action)
			{
				case Action.wait:
				timer1.Interval = 5000;
				action = Action.close;
				break;

				case Action.start:
				timer1.Interval = 1;
				Opacity += 0.1;
				if (x < Location.X)
				{
					Left--;
				}
				else
				{
					if (Opacity == 1.0)
					{
						action = Action.wait;
					}
				}
				break;

				case Action.close:
				timer1.Interval = 1;
				Opacity -= 0.1;
				Left -= 3;

				if (Opacity == 0.0)
				{
					base.Close();
				}
				break;
			}
		}
		#endregion /Timer1_Tick
		//----- End of the codes.
		#region Method
		//-----
		#region ShowAlert
		/// <summary>
		/// A function that displays a notification with three message inputs, caption, and photos.
		/// </summary>
		/// <param name="message"></param>
		/// <param name="caption"></param>
		/// <param name="picture"></param>
		public void ShowAlert(string message, Caption caption, string picture)
		{
			this.Opacity = 0.0;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;

			string name;

			for (int i = 1; i < 10; i++)
			{
				name = "alert" + i.ToString();

				PopupNotificationForm popupNotification = (PopupNotificationForm)System.Windows.Forms.Application.OpenForms[name];

				if (popupNotification == null)
				{
					this.Name = name;
					this.x = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
					this.y = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
					this.Location = new System.Drawing.Point(this.x, this.y);
					break;
				}
			}

			this.x = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

			switch (caption)
			{
				case Caption.موفقیت:
				alertIconPicturBox.Image = ComputerServices.Properties.Resources.succes_512;
				BackColor = System.Drawing.Color.SeaGreen;
				captionLabel.Text = Caption.موفقیت.ToString();
				break;

				case Caption.اخطار:
				alertIconPicturBox.Image = ComputerServices.Properties.Resources.warning_512;
				BackColor = System.Drawing.Color.DarkOrange;
				captionLabel.Text = Caption.اخطار.ToString();
				break;

				case Caption.خطا:
				alertIconPicturBox.Image = ComputerServices.Properties.Resources.error_512;
				BackColor = System.Drawing.Color.DarkRed;
				captionLabel.Text = Caption.خطا.ToString();
				break;

				case Caption.اطلاع:
				alertIconPicturBox.Image = ComputerServices.Properties.Resources.info_512;
				BackColor = System.Drawing.Color.RoyalBlue;
				captionLabel.Text = Caption.اطلاع.ToString();
				break;
			}

			this.objectpicturBox.Image = System.Drawing.Image.FromFile(picture);
			this.alertMessageLabel.Text = message;

			this.Show();
			this.action = Action.start;
			this.timer1.Interval = 1;
			this.timer1.Start();
		}
		#endregion /ShowAlert

		#region ShowAlert
		/// <summary>
		/// A function that displays the message and caption of a notification with two descriptions.
		/// </summary>
		/// <param name="message"></param>
		/// <param name="caption"></param>
		public void ShowAlert(string message, Caption caption)
		{
			this.Opacity = 0.0;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;

			string name;

			for (int i = 1; i < 10; i++)
			{
				name = "alert" + i.ToString();

				PopupNotificationForm popupNotification = (PopupNotificationForm)System.Windows.Forms.Application.OpenForms[name];

				if (popupNotification == null)
				{
					this.Name = name;
					this.x = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
					this.y = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
					this.Location = new System.Drawing.Point(this.x, this.y);
					break;
				}
			}

			this.x = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

			switch (caption)
			{
				case Caption.موفقیت:
				alertIconPicturBox.Image = ComputerServices.Properties.Resources.succes_512;
				BackColor = System.Drawing.Color.SeaGreen;
				captionLabel.Text = Caption.موفقیت.ToString();
				break;

				case Caption.اخطار:
				alertIconPicturBox.Image = ComputerServices.Properties.Resources.warning_512;
				BackColor = System.Drawing.Color.DarkOrange;
				captionLabel.Text = Caption.اخطار.ToString();
				break;

				case Caption.خطا:
				alertIconPicturBox.Image = ComputerServices.Properties.Resources.error_512;
				BackColor = System.Drawing.Color.DarkRed;
				captionLabel.Text = Caption.خطا.ToString();
				break;

				case Caption.اطلاع:
				alertIconPicturBox.Image = ComputerServices.Properties.Resources.info_512;
				BackColor = System.Drawing.Color.RoyalBlue;
				captionLabel.Text = Caption.اطلاع.ToString();
				break;
			}
			this.alertMessageLabel.Text = message;

			this.Show();
			this.action = Action.start;
			this.timer1.Interval = 1;
			this.timer1.Start();
		}
		#endregion /ShowAlert
		//-----
		#endregion /Method
	}
}
