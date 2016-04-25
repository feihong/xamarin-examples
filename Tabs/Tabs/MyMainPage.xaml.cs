using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Diagnostics;
using Xamarin.Forms;

namespace Tabs
{
	

	public partial class MyMainPage : TabbedPage
	{
		List<string> greetings = new List<string>{
			"Hello World",
			"Hola Mundo",
			"ਸਤਿ ਸ੍ਰੀ ਅਕਾਲ ਦੁਨਿਆ",
			"こんにちは世界",
			"你好世界",
			"Përshendetje Botë",
			"Բարեւ, աշխարհ",
			"হ্যালো দুনিয়া",
			"Saluton mondo",
			"გამარჯობა მსოფლიო",
		};

		public MyMainPage ()
		{
			InitializeComponent ();

			Random rand = new Random();

			luckyPage.Appearing += (sender, e) => {				
				IEnumerable<int> numbers = Enumerable.Range(0, 5).Select(x => rand.Next(100));
				luckyLabel.Text = string.Join(", ", numbers);
			};

			ipPage.Appearing += async (sender, e) => {
				ipLabel.Text = "(fetching IP address...)";
				await Task.Delay(1000);

				HttpClient client = new HttpClient();
				try {
					HttpResponseMessage response = await client.GetAsync("http://ipecho.net/plain");
					ipLabel.Text = await response.Content.ReadAsStringAsync();
				} catch (WebException ex) {
					ipLabel.Text = $"({ex.Message})";
					Debug.WriteLine(ex);
				}
			};

			listView.ItemsSource = Enumerable.Range (0, 100).Select (x => {
				int index = rand.Next(0, greetings.Count);
				return $"{x+1}. {greetings[index]}";
			});

			listView.ItemTapped += (sender, e) => {
				DisplayAlert("Item tapped", e.Item.ToString(), "OK");
			};
		}

		public void InitProperties() {
			dimensionsLabel.Text = $"{App.ScreenWidth} x {App.ScreenHeight}";
		}
	}
}

