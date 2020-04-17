using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerServices
{
	public partial class StartUpProgramForm : Form
	{
		public StartUpProgramForm()
		{
			InitializeComponent();
		}

		private void StartUpProgramForm_Load(object sender, EventArgs e)
		{
			//bunifuFormFadeTransition1.ShowAsyc(this);
			this.Opacity = 0.0;
			timer1.Start();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			this.Opacity += 0.05;

			if (this.Opacity >= 0.90)
			{
				timer1.Stop();
				timer2.Start();
			}
		}

		private void timer2_Tick(object sender, EventArgs e)
		{
			timer2.Interval += 50;

			if (timer2.Interval == 150)
			{
				bunifuTransition1.HideSync(mainBackgroundUC11);
				bunifuTransition2.ShowSync(mainBackgroundUC21);
			}

			if (timer2.Interval == 350)
			{
				bunifuTransition2.HideSync(mainBackgroundUC21);
				bunifuTransition3.ShowSync(mainBackgroundUC31);
			}

			if (timer2.Interval ==550)
			{
				bunifuTransition3.HideSync(mainBackgroundUC31);
				bunifuTransition1.ShowSync(mainBackgroundUC41);
			}

			if (timer2.Interval == 750)
			{
				timer2.Stop();
				timer3.Start();
			}
		}

		private void timer3_Tick(object sender, EventArgs e)
		{
			this.Opacity -= 0.05;

			if (this.Opacity == 0)
			{
				timer3.Stop();
				this.Hide();
				Program.LoginShow();
			}
		}
	}
}
