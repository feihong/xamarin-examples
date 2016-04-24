using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using Xamarin.Forms;

namespace Tabs
{
	public partial class MyMainPage : TabbedPage
	{
		public MyMainPage ()
		{
			InitializeComponent ();

			luckyPage.Appearing += (sender, e) => {
				Random rand = new Random();
				IEnumerable<int> numbers = Enumerable.Range(0, 5).Select(x => rand.Next(100));
				luckyLabel.Text = string.Join(", ", numbers);
			};

			ipPage.Appearing += async (sender, e) => {
				ipLabel.Text = "(fetching IP address...)";
				await Task.Delay(1000);

				HttpClient client = new HttpClient();
				HttpResponseMessage response = await client.GetAsync("http://ipecho.net/plain");
				ipLabel.Text = await response.Content.ReadAsStringAsync();
			};
		}

		public void InitProperties() {
			dimensionsLabel.Text = $"{App.ScreenWidth} x {App.ScreenHeight}";
		}
	}
}

