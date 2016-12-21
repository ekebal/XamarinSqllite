using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using XamarinSqlLight.Database;

namespace XamarinSqlLight.Droid
{
	[Activity (Label = "XamarinSqlLight", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);
            ConctactDatabase.Root = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            LoadApplication (new XamarinSqlLight.App ());
		}
	}
}

