using System;
using Xamarin.Forms;

namespace HelloWorld
{
	public class MyMainPage : ContentPage
	{
		Button button = new Button {
			Text = "Click me"
		};

		Label helloLabel = new Label { 
			Text = "Hello World",
			XAlign = TextAlignment.Center,
			FontSize = 40,
			FontFamily = "Helvetica",
		};

		public MyMainPage ()
		{
			button.Clicked += OnButtonClicked;

			Content = new StackLayout { 
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				Children = {
					helloLabel,
					new Label {
						Text = "Please enjoy this app I made for you",
						FontFamily = "Monospace",
						XAlign = TextAlignment.Center,
					},
					button,
				}
			};
		}

		void OnButtonClicked(object sender, EventArgs e) {
			helloLabel.Text = Greetings.GetGreeting();
		}
	}
}


