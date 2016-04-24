using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace Tabs
{
	public partial class MyMainPage : TabbedPage
	{
		public MyMainPage ()
		{
			InitializeComponent ();

			luckyPage.Appearing += (object sender, EventArgs e) => {
				Random rand = new Random();
				IEnumerable<int> numbers = Enumerable.Range(0, 5).Select(x => rand.Next(100));
				luckyLabel.Text = string.Join("  ", numbers);
			};

			ipPage.Appearing += (object sender, EventArgs e) => {
				ipLabel.Text = "...";
			};
		}

		public void InitProperties() {
			dimensionsLabel.Text = $"{App.ScreenWidth} x {App.ScreenHeight}";
		}
	}
}

