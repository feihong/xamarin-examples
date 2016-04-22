using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace HelloWorld
{
	public partial class MyXamlMainPage : ContentPage
	{
		public MyXamlMainPage ()
		{
			InitializeComponent();
		}

		void OnButtonClicked(object sender, EventArgs e) {
			helloLabel.Text = Greetings.GetGreeting ();
		}
	}
}

