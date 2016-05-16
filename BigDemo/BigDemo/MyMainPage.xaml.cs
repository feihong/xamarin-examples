using System;
using System.Collections.Generic;
using System.Linq;

using Xamarin.Forms;

namespace BigDemo
{
	public class ListItem {
		public string Title { get; set; }
		public string Icon { get; set; }
		public Type TargetType { get; set; }
	};

	public partial class MyMainPage : MasterDetailPage
	{
		IEnumerable<ListItem> items = new List<ListItem> {
			new ListItem {
				Title="ListView in StackLayout",
				TargetType=typeof(ListViewInStackLayoutPage),
			},
			new ListItem {
				Title="Text to speech",
			},
		};

		public MyMainPage ()
		{
			InitializeComponent ();

			items = items.Select (item => {
				item.Icon = "lightbulb.png";
				return item;
			});			
			listView.ItemsSource = items;

			listView.ItemSelected += OnItemSelected;
		}

		void OnItemSelected(object sender, SelectedItemChangedEventArgs e) {
			var item = e.SelectedItem as ListItem;

			if (item != null && item.TargetType != null) {
				Detail = new NavigationPage ((Page)Activator.CreateInstance(item.TargetType));
				listView.SelectedItem = null;
				IsPresented = false;
			}
		}
	}
}

