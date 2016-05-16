using System;
using System.Collections.Generic;
using System.Linq;

using Xamarin.Forms;

namespace BigDemo
{
	public class ListItem {
		public string Title { get; set; }
		public string Icon { get; set; }
	};

	public partial class MyMainPage : MasterDetailPage
	{
		IEnumerable<ListItem> items = new List<ListItem> {
			new ListItem {
				Title="Apricot",
				Icon="lightbulb"
			},
			new ListItem {
				Title="Banana",
				Icon="lightbulb"
			},
			new ListItem {
				Title="Cornucopia",
				Icon="lightbulb"
			},
		};

		public MyMainPage ()
		{
			InitializeComponent ();

			items = items.Select (item => {
				item.Icon = item.Icon + ".png";
				return item;
			});			
			listView.ItemsSource = items;
		}
	}
}

