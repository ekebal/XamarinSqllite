﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XamarinSqlLight.Database;

namespace XamarinSqlLight.Modele
{ 

    public partial class MedicamentsPage : ContentPage
	{
		public MedicamentsPage()
		{
			InitializeComponent();
			MedicamentView.ItemsSource = new string[]{
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
				Navigation.PushAsync(new MedicamentsFormPage());
			};
		}

	}
}
