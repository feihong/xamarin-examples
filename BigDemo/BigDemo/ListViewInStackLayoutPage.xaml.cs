using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace BigDemo
{
	public partial class ListViewInStackLayoutPage : ContentPage
	{
		public ListViewInStackLayoutPage ()
		{
			InitializeComponent ();

			IEnumerable<string> items = Enumerable.Range(1, 40).Select(i => $"Item {i}");
			listView.ItemsSource = items;
		}
	}
}

