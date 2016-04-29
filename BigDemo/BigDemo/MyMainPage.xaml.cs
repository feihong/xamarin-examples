using System;
using System.Collections.Generic;
using System.Linq;

using Xamarin.Forms;

namespace BigDemo
{
//	struct ListItem {
//		string Title;
//		string Icon;
//	};

	public partial class MyMainPage : MasterDetailPage
	{
		

		public MyMainPage ()
		{
			InitializeComponent ();

			listView.ItemsSource = Enumerable.Range (1, 10).Select (x => $"Option {x}");
		}
	}
}

