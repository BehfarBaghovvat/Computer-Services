namespace ComputerServices
{
	partial class StartUpProgramForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
			BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartUpProgramForm));
			BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.timer3 = new System.Windows.Forms.Timer(this.components);
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
			this.mainBackgroundPanel1 = new Mbb.Windows.Forms.Panel();
			this.sideBackgoundPanel2 = new Mbb.Windows.Forms.Panel();
			this.bunifuTransition2 = new BunifuAnimatorNS.BunifuTransition(this.components);
			this.mainBackgroundUC41 = new ComputerServices.UC_Project.MainBackgroundUC4();
			this.mainBackgroundUC11 = new ComputerServices.UC_Project.MainBackgroundUC1();
			this.mainBackgroundUC21 = new ComputerServices.UC_Project.MainBackgroundUC2();
			this.mainBackgroundUC31 = new ComputerServices.UC_Project.MainBackgroundUC3();
			this.bunifuTransition3 = new BunifuAnimatorNS.BunifuTransition(this.components);
			this.mainBackgroundPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// timer2
			// 
			this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// timer3
			// 
			this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 25;
			this.bunifuElipse1.TargetControl = this;
			// 
			// bunifuTransition1
			// 
			this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Scale;
			this.bunifuTransition1.Cursor = null;
			animation3.AnimateOnlyDifferences = true;
			animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
			animation3.LeafCoeff = 0F;
			animation3.MaxTime = 1F;
			animation3.MinTime = 0F;
			animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
			animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
			animation3.MosaicSize = 0;
			animation3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
			animation3.RotateCoeff = 0F;
			animation3.RotateLimit = 0F;
			animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
			animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
			animation3.TimeCoeff = 0F;
			animation3.TransparencyCoeff = 0F;
			this.bunifuTransition1.DefaultAnimation = animation3;
			this.bunifuTransition1.Interval = 5;
			this.bunifuTransition1.MaxAnimationTime = 10000;
			// 
			// mainBackgroundPanel1
			// 
			this.mainBackgroundPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.mainBackgroundPanel1.Controls.Add(this.mainBackgroundUC11);
			this.mainBackgroundPanel1.Controls.Add(this.mainBackgroundUC21);
			this.mainBackgroundPanel1.Controls.Add(this.mainBackgroundUC31);
			this.mainBackgroundPanel1.Controls.Add(this.mainBackgroundUC41);
			this.bunifuTransition1.SetDecoration(this.mainBackgroundPanel1, BunifuAnimatorNS.DecorationType.None);
			this.bunifuTransition2.SetDecoration(this.mainBackgroundPanel1, BunifuAnimatorNS.DecorationType.None);
			this.bunifuTransition3.SetDecoration(this.mainBackgroundPanel1, BunifuAnimatorNS.DecorationType.None);
			this.mainBackgroundPanel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.mainBackgroundPanel1.Location = new System.Drawing.Point(0, 0);
			this.mainBackgroundPanel1.Name = "mainBackgroundPanel1";
			this.mainBackgroundPanel1.Size = new System.Drawing.Size(750, 550);
			this.mainBackgroundPanel1.TabIndex = 1;
			// 
			// sideBackgoundPanel2
			// 
			this.sideBackgoundPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sideBackgoundPanel2.BackgroundImage")));
			this.sideBackgoundPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuTransition1.SetDecoration(this.sideBackgoundPanel2, BunifuAnimatorNS.DecorationType.None);
			this.bunifuTransition2.SetDecoration(this.sideBackgoundPanel2, BunifuAnimatorNS.DecorationType.None);
			this.bunifuTransition3.SetDecoration(this.sideBackgoundPanel2, BunifuAnimatorNS.DecorationType.None);
			this.sideBackgoundPanel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.sideBackgoundPanel2.Location = new System.Drawing.Point(750, 0);
			this.sideBackgoundPanel2.Name = "sideBackgoundPanel2";
			this.sideBackgoundPanel2.Size = new System.Drawing.Size(210, 550);
			this.sideBackgoundPanel2.TabIndex = 0;
			// 
			// bunifuTransition2
			// 
			this.bunifuTransition2.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
			this.bunifuTransition2.Cursor = null;
			animation2.AnimateOnlyDifferences = true;
			animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
			animation2.LeafCoeff = 0F;
			animation2.MaxTime = 1F;
			animation2.MinTime = 0F;
			animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
			animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
			animation2.MosaicSize = 20;
			animation2.Padding = new System.Windows.Forms.Padding(30);
			animation2.RotateCoeff = 0F;
			animation2.RotateLimit = 0F;
			animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
			animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
			animation2.TimeCoeff = 0F;
			animation2.TransparencyCoeff = 0F;
			this.bunifuTransition2.DefaultAnimation = animation2;
			this.bunifuTransition2.Interval = 5;
			this.bunifuTransition2.MaxAnimationTime = 10000;
			// 
			// mainBackgroundUC41
			// 
			this.mainBackgroundUC41.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainBackgroundUC41.BackgroundImage")));
			this.mainBackgroundUC41.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuTransition3.SetDecoration(this.mainBackgroundUC41, BunifuAnimatorNS.DecorationType.None);
			this.bunifuTransition2.SetDecoration(this.mainBackgroundUC41, BunifuAnimatorNS.DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.mainBackgroundUC41, BunifuAnimatorNS.DecorationType.None);
			this.mainBackgroundUC41.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainBackgroundUC41.Location = new System.Drawing.Point(0, 0);
			this.mainBackgroundUC41.Name = "mainBackgroundUC41";
			this.mainBackgroundUC41.Size = new System.Drawing.Size(750, 550);
			this.mainBackgroundUC41.TabIndex = 3;
			// 
			// mainBackgroundUC11
			// 
			this.mainBackgroundUC11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainBackgroundUC11.BackgroundImage")));
			this.mainBackgroundUC11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuTransition3.SetDecoration(this.mainBackgroundUC11, BunifuAnimatorNS.DecorationType.None);
			this.bunifuTransition2.SetDecoration(this.mainBackgroundUC11, BunifuAnimatorNS.DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.mainBackgroundUC11, BunifuAnimatorNS.DecorationType.None);
			this.mainBackgroundUC11.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainBackgroundUC11.Location = new System.Drawing.Point(0, 0);
			this.mainBackgroundUC11.Name = "mainBackgroundUC11";
			this.mainBackgroundUC11.Size = new System.Drawing.Size(750, 550);
			this.mainBackgroundUC11.TabIndex = 2;
			// 
			// mainBackgroundUC21
			// 
			this.mainBackgroundUC21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainBackgroundUC21.BackgroundImage")));
			this.mainBackgroundUC21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuTransition3.SetDecoration(this.mainBackgroundUC21, BunifuAnimatorNS.DecorationType.None);
			this.bunifuTransition2.SetDecoration(this.mainBackgroundUC21, BunifuAnimatorNS.DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.mainBackgroundUC21, BunifuAnimatorNS.DecorationType.None);
			this.mainBackgroundUC21.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainBackgroundUC21.Location = new System.Drawing.Point(0, 0);
			this.mainBackgroundUC21.Name = "mainBackgroundUC21";
			this.mainBackgroundUC21.Size = new System.Drawing.Size(750, 550);
			this.mainBackgroundUC21.TabIndex = 1;
			// 
			// mainBackgroundUC31
			// 
			this.mainBackgroundUC31.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainBackgroundUC31.BackgroundImage")));
			this.mainBackgroundUC31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuTransition3.SetDecoration(this.mainBackgroundUC31, BunifuAnimatorNS.DecorationType.None);
			this.bunifuTransition2.SetDecoration(this.mainBackgroundUC31, BunifuAnimatorNS.DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.mainBackgroundUC31, BunifuAnimatorNS.DecorationType.None);
			this.mainBackgroundUC31.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainBackgroundUC31.Location = new System.Drawing.Point(0, 0);
			this.mainBackgroundUC31.Name = "mainBackgroundUC31";
			this.mainBackgroundUC31.Size = new System.Drawing.Size(750, 550);
			this.mainBackgroundUC31.TabIndex = 0;
			// 
			// bunifuTransition3
			// 
			this.bunifuTransition3.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
			this.bunifuTransition3.Cursor = null;
			animation1.AnimateOnlyDifferences = true;
			animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
			animation1.LeafCoeff = 0F;
			animation1.MaxTime = 1F;
			animation1.MinTime = 0F;
			animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
			animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
			animation1.MosaicSize = 1;
			animation1.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
			animation1.RotateCoeff = 0F;
			animation1.RotateLimit = 0F;
			animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
			animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
			animation1.TimeCoeff = 2F;
			animation1.TransparencyCoeff = 0F;
			this.bunifuTransition3.DefaultAnimation = animation1;
			this.bunifuTransition3.Interval = 5;
			this.bunifuTransition3.MaxAnimationTime = 10000;
			// 
			// StartUpProgramForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(960, 550);
			this.Controls.Add(this.mainBackgroundPanel1);
			this.Controls.Add(this.sideBackgoundPanel2);
			this.bunifuTransition3.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
			this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
			this.bunifuTransition2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "StartUpProgramForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "StartUpProgramForm";
			this.Load += new System.EventHandler(this.StartUpProgramForm_Load);
			this.mainBackgroundPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Timer timer2;
		private Mbb.Windows.Forms.Panel sideBackgoundPanel2;
		private Mbb.Windows.Forms.Panel mainBackgroundPanel1;
		private System.Windows.Forms.Timer timer3;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private BunifuAnimatorNS.BunifuTransition bunifuTransition2;
		private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
		private UC_Project.MainBackgroundUC1 mainBackgroundUC11;
		private UC_Project.MainBackgroundUC2 mainBackgroundUC21;
		private UC_Project.MainBackgroundUC3 mainBackgroundUC31;
		private UC_Project.MainBackgroundUC4 mainBackgroundUC41;
		private BunifuAnimatorNS.BunifuTransition bunifuTransition3;
	}
}