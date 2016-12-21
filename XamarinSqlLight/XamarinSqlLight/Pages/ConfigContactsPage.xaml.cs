using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XamarinSqlLight.Database;

namespace XamarinSqlLight.Pages
{
	public partial class ConfigContactsPage : ContentPage
    {
		public ConfigContactsPage()
		{
			InitializeComponent();
			ContactsView.ItemsSource = new string[]{
			  "mono",
			  "monodroid",
			  "monotouch",
			  "monorail",
			  "monodevelop",
			  "monotone",
			  "monopoly",
			  "monomodal",
			  "mononucleosis"
			};
			btnAdd.Clicked += (sender, e) =>
			{
				Navigation.PushAsync(new ContactsFromPage());
			};
		}
	}
}
