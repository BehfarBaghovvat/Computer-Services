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

		#region MyRegion
		public static void Message(string text, string caption,icon icon, button button)
		{
			
			if (icon == icon.Question && button == button.YesNo)
			{
				using (MessageBoxDOBForm messageBox = new MessageBoxDOBForm())
				{
					messageBox.Message = text;
					messageBox.Caption = caption;
					messageBox.Icon = Properties.Resources.question_512;
					messageBox.BackColor = System.Drawing.Color.DarkBlue;
					messageBox.YesOkBackColor = System.Drawing.Color.Blue;
					messageBox.YesOkName = "بله";
					messageBox.NoCancelBackColor = System.Drawing.Color.Blue;
					messageBox.NoCancelName = "خیر";
					messageBox.ShowDialog();
				}
				return;
			}

		}
		#endregion

	}
}
