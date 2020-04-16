using System;
using System.Windows.Forms;

namespace Mbb.Windows.Forms
{
	public static class MessageBox
	{
		public enum Icon
		{
			Information,
			Question,
			None,
			Error,
			Warning,
			Stop,
		}

		#region Static Constructor Message
		static MessageBox()
		{

		}
		#endregion /Static Constructor Message

		#region MyRegion
		#region Message
		public static void Message(string message)
		{
			System.Windows.Forms.MessageBox.Show(text: message);
		}

		public static void Message(string message, string caption)
		{
			System.Windows.Forms.MessageBox.Show(
				text: message,
				caption: caption,
				buttons: System.Windows.Forms.MessageBoxButtons.OK);
		}
		#endregion /Message

		#region InformationMessage
		public static void InformationMessage(string text)
		{
			System.Windows.Forms.MessageBox.Show(
				text: text,
				caption: "توضیح",
				buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
				icon: System.Windows.Forms.MessageBoxIcon.Information,
				defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2,
				options: System.Windows.Forms.MessageBoxOptions.RightAlign |
				System.Windows.Forms.MessageBoxOptions.RtlReading);
		}

		public static void InformationMessage(string text, string captiopn)
		{
			System.Windows.Forms.MessageBox.Show(
				text: text,
				caption: captiopn,
				buttons: System.Windows.Forms.MessageBoxButtons.OK,
				icon: System.Windows.Forms.MessageBoxIcon.Information,
				defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1,
				options: System.Windows.Forms.MessageBoxOptions.RightAlign |
				System.Windows.Forms.MessageBoxOptions.RtlReading);
		}
		#endregion /InformationMessage

		#region QuestionMessage
		public static void QuestionMessage(string text)
		{
			System.Windows.Forms.MessageBox.Show(
				text: text,
				caption: "پرسش",
				buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
				icon: System.Windows.Forms.MessageBoxIcon.Question,
				defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2,
				options: System.Windows.Forms.MessageBoxOptions.RightAlign |
				System.Windows.Forms.MessageBoxOptions.RtlReading);
		}

		public static DialogResult QuestionMessage
			(string text,
			string captiopn,
			MessageBoxButtons buttons,
			MessageBoxIcon icon,
			MessageBoxDefaultButton defaultButton,
			MessageBoxOptions options)
		{
			System.Windows.Forms.DialogResult dialogResult = System.Windows.Forms.MessageBox.Show(
				text: text,
				caption: captiopn,
				buttons: buttons,
				defaultButton: defaultButton,
				icon: icon,
				options: options);

			return dialogResult;
		}
		#endregion /QuestionMessage

		#region ErrorMessage
		public static void ErrorMessage(string text)
		{
			System.Windows.Forms.MessageBox.Show(
				text: text,
				caption: "خطا",
				buttons: System.Windows.Forms.MessageBoxButtons.OK,
				icon: System.Windows.Forms.MessageBoxIcon.Error,
				defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1,
				options: System.Windows.Forms.MessageBoxOptions.RightAlign |
				System.Windows.Forms.MessageBoxOptions.RtlReading);
		}
		#endregion ErrorMessage 
		#endregion

		#region Message
		public static DialogResult Message(string message, string caption, Icon icon)
		{
			DialogResult dialogResult = DialogResult.None;
			
			switch (icon)
			{
				case Icon.Information:
				using (InformationForm information = new InformationForm())
				{
					information.Message = message;
					information.Caption = caption;
					dialogResult = information.ShowDialog();
				}
				break;

				case Icon.Question:
				using (QuestionForm question = new QuestionForm())
				{
					question.Message = message;
					question.Caption = caption;
					dialogResult = question.ShowDialog();
				}
				break;

				case Icon.None:
				using (NoneForm none = new NoneForm())
				{
					none.Message = message;
					none.Caption = caption;
					dialogResult = none.ShowDialog();
				}
				break;

				case Icon.Error:
				using (ErrorForm error = new ErrorForm())
				{
					error.Message = message;
					error.Caption = caption;
					dialogResult = error.ShowDialog();
				}
				break;

				case Icon.Warning:
				using (WarningForm warning = new WarningForm())
				{
					warning.Message = message;
					warning.Caption = caption;
					dialogResult = warning.ShowDialog();
				}
				break;

				case Icon.Stop:
				using (DangerousForm dangerous = new DangerousForm())
				{
					dangerous.Message = message;
					dangerous.Caption = caption;
					dialogResult = dangerous.ShowDialog();
				}
				break;
			}

			return dialogResult;
		}
		#endregion /Message

	}
}
