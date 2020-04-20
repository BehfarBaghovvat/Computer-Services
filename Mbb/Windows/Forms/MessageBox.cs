using System;
using System.Windows.Forms;

namespace Mbb.Windows.Forms
{
	public static class MessageBox
	{
		#region icon
		public enum icon
		{
			Success,
			Warning,
			Alert,
			Question,
			Error,
			Information,
			None,
		}
		#endregion /icon

		#region button
		public enum button
		{
			YesNo,
			YesNoCancel,
			Ok,
			OkCancel,
			AbortRetryIgnor,
		}
		#endregion /button

		//-----Begining of the codes.
		#region Show
		public static void Show(string text, string caption,icon icon, button button)
		{
			//----Single Button
			if (icon == icon.Success && button == button.Ok)
			{
				using (MessageBoxSIBForm messageBox = new MessageBoxSIBForm())
				{
					messageBox.Message = text;
					messageBox.Caption = caption;
					messageBox.Icon = Properties.Resources.succes_512;
					messageBox.BackColor = System.Drawing.Color.SeaGreen;
					messageBox.OKBackColor = System.Drawing.Color.Green;
					messageBox.OKName = "باشه";
					messageBox.ShowDialog();
				}
				return;
			}
			if (icon == icon.Information && button == button.Ok)
			{
				using (MessageBoxSIBForm messageBox = new MessageBoxSIBForm())
				{
					messageBox.Message = text;
					messageBox.Caption = caption;
					messageBox.Icon = Properties.Resources.info_512;
					messageBox.BackColor = System.Drawing.Color.RoyalBlue;
					messageBox.OKBackColor = System.Drawing.Color.FromArgb(0, 85, 225);
					messageBox.OKName = "باشه";
					messageBox.ShowDialog();
				}
				return;
			}
			if (icon == icon.None && button == button.Ok)
			{
				using (MessageBoxSIBForm messageBox = new MessageBoxSIBForm())
				{
					messageBox.Message = text;
					messageBox.Caption = caption;
					messageBox.Icon = Properties.Resources.none_512;
					messageBox.BackColor = System.Drawing.Color.DarkGray;
					messageBox.OKBackColor = System.Drawing.Color.Gray;
					messageBox.OKName = "باشه";
					messageBox.ShowDialog();
				}
				return;
			}
			if (icon == icon.Error && button == button.Ok)
			{
				using (MessageBoxSIBForm messageBox = new MessageBoxSIBForm())
				{
					messageBox.Message = text;
					messageBox.Caption = caption;
					messageBox.Icon = Properties.Resources.error_512;
					messageBox.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
					messageBox.OKBackColor = System.Drawing.Color.Orange;
					messageBox.OKName = "باشه";
					messageBox.ShowDialog();
				}
				return;
			}
			if (icon == icon.Warning && button == button.Ok)
			{
				using (MessageBoxSIBForm messageBox = new MessageBoxSIBForm())
				{
					messageBox.Message = text;
					messageBox.Caption = caption;
					messageBox.Icon = Properties.Resources.warning_512;
					messageBox.BackColor = System.Drawing.Color.DarkRed;
					messageBox.OKBackColor = System.Drawing.Color.Red;
					messageBox.OKName = "باشه";
					messageBox.ShowDialog();
				}
				return;
			}

			//-----Double Buttons
			if (icon == icon.Question && button == button.YesNo)
			{
				using (MessageBoxDOBForm messageBox = new MessageBoxDOBForm())
				{
					messageBox.Message = text;
					messageBox.Caption = caption;
					messageBox.Icon = Properties.Resources.question_512;
					messageBox.BackColor = System.Drawing.Color.RoyalBlue;
					messageBox.YesOkBackColor = System.Drawing.Color.FromArgb(0, 85, 225);
					messageBox.YesOkName = "بله";
					messageBox.NoCancelBackColor = System.Drawing.Color.Blue;
					messageBox.NoCancelName = "خیر";
					messageBox.ShowDialog();
				}
				return;
			}
			if (icon == icon.Alert && button == button.YesNo)
			{
				using (MessageBoxDOBForm messageBox = new MessageBoxDOBForm())
				{
					messageBox.Message = text;
					messageBox.Caption = caption;
					messageBox.Icon = Properties.Resources.alert_512px;
					messageBox.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
					messageBox.YesOkBackColor = System.Drawing.Color.Orange;
					messageBox.YesOkName = "بله";
					messageBox.NoCancelBackColor = System.Drawing.Color.Orange;
					messageBox.NoCancelName = "خیر";
					messageBox.ShowDialog();
				}
				return;
			}
			if (icon == icon.Warning && button == button.YesNo)
			{
				using (MessageBoxDOBForm messageBox = new MessageBoxDOBForm())
				{
					messageBox.Message = text;
					messageBox.Caption = caption;
					messageBox.Icon = Properties.Resources.warning_512;
					messageBox.BackColor = System.Drawing.Color.DarkRed;
					messageBox.YesOkBackColor = System.Drawing.Color.Red;
					messageBox.YesOkName = "بله";
					messageBox.NoCancelBackColor = System.Drawing.Color.Red;
					messageBox.NoCancelName = "خیر";
					messageBox.ShowDialog();
				}
				return;
			}

			//-----Sobel Buttons
		}
		#endregion /Show

	}
}
