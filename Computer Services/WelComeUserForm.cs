namespace ComputerServices
{
	public partial class WelComeUserForm : Infrastructure.BaseForm
	{
		public WelComeUserForm()
		{
			InitializeComponent();
		}

		#region Properties
		int number;
		System.Random random =
			new System.Random(0);
		#endregion /Properties

		//-----The beginning of the coding line.

		#region WelComeUserForm_Load
		private void WelComeUserForm_Load(object sender, System.EventArgs e)
		{
			Initialize();
			bunifuCircleProgressbar.Value = 0;
			bunifuCircleProgressbar.MaxValue = 100;

			this.Opacity = 0.0;
			timer1.Start();
		}

		#endregion /WelComeUserForm_Load

		#region Timer1_Tick
		private void Timer1_Tick(object sender, System.EventArgs e)
		{
			if (this.Opacity < 0.90) this.Opacity += 0.1;

			bunifuCircleProgressbar.Value += NumberLoadRandom();

			if (bunifuCircleProgressbar.Value >= 100)
			{
				timer1.Stop();
				timer2.Start();
			}
		}
		#endregion /Timer1_Tick

		#region Timer2_Tick
		private void Timer2_Tick(object sender, System.EventArgs e)
		{
			this.Opacity -= 0.05;

			if (this.Opacity == 0)
			{
				timer2.Stop();
				this.Close();
				Program.MainShow();
			}
		}
		#endregion /Timer2_Tick

		//-----End of coding line

		#region Function
		//-----
		#region Initialize
		public void Initialize()
		{
			string name =
				$"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}" ;

			if (string.IsNullOrEmpty(Program.AuthenticatedUser.First_Name) || string.IsNullOrEmpty(Program.AuthenticatedUser.Last_Name) || Program.AuthenticatedUser.First_Name=="null" || Program.AuthenticatedUser.Last_Name == "null")
			{
				name =
					Program.AuthenticatedUser.Username;
			}
			usernameLabel.Text = name;

			var byteImage =
				Program.AuthenticatedUser.User_Image;

			using (System.IO.MemoryStream ms = new System.IO.MemoryStream(byteImage))
			{
				userImagePictureBox.BackgroundImage =
					System.Drawing.Image.FromStream(ms);
			}
		}
		#endregion /Initialize

		#region NumberLoadRandom
		public int NumberLoadRandom()
		{
			for (int i = 1; i <= 100; i++)
			{
				number = random.Next(6);
			}
			return number;
		}
		#endregion /NumberLoadRandom
		//-----
		#endregion /Function
	}
}
