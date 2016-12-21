using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XamarinSqlLight.Database;
using XamarinSqlLight.Pages;

namespace XamarinSqlLight
{
	public partial class App : Application
	{
        public App()
        {
            InitializeComponent();

            //MainPage = new SeniorAssistancePage();
            // je pense qu'il prend pas en consideration ca  car regard  tu lui ecris  quoi que se soit il donne pas  erreur !!
            MainPage = new NavigationPage(new gggggk());
        }

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
