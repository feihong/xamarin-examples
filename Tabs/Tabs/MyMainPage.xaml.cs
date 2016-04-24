using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Tabs
{
	public partial class MyMainPage : TabbedPage
	{
		public MyMainPage ()
		{
			InitializeComponent ();

			ipPage.Appearing += (object sender, EventArgs e) => {
				ipLabel.Text = "...";
			};

			luckyPage.Appearing += (object sender, EventArgs e) => {
				Random rand = new Random();
				luckyLabel.Text = $"{rand.Next(100)}";
			};
		}

		public void InitProperties() {
			dimensionsLabel.Text = $"{App.ScreenWidth} x {App.ScreenHeight}";
		}
	}
}

