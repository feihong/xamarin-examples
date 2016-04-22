using System;
using Xamarin.Forms;

namespace HelloWorld
{
	public class MyMainPage : ContentPage
	{
		Label helloLabel = new Label { 
			Text = "Hello World",
			XAlign = TextAlignment.Center,
			FontSize = 40,
			FontFamily = "Helvetica",
		};

		Button button = new Button {
			Text = "Click me"
		};

		public MyMainPage ()
		{
			button.Clicked += OnButtonClicked;

			Content = new StackLayout { 
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				Children = {
					helloLabel,
					button,
					new Label {
						Text = "Please enjoy this app I made for you",
						FontFamily = "Monospace",
						XAlign = TextAlignment.Center,
					},
				}
			};
		}

		void OnButtonClicked(object sender, EventArgs e) {
			helloLabel.Text = Greetings.GetGreeting();
		}
	}
}


