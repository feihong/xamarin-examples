using System;
using Xamarin.Forms;


namespace Tabs
{
	public class App : Application
	{
		public static int ScreenWidth; 
		public static int ScreenHeight; 

		public App ()
		{
			// The root page of your application
			MainPage = new MyMainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
			MyMainPage page = (MyMainPage)this.MainPage;
			page.InitProperties ();
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

