using NovLocator.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace NovLocator
{
	public class App : Application
	{

		private static ViewModelLocator _locator;

		public App()
		{

			//var tabs = new TabbedPage();

			//tabs.Children.Add(new Views.Phones.Main());
			//tabs.Children.Add(new Views.Phones.FacilityMap());

			MainPage = new Views.Phones.Main();

		}

		public static ViewModelLocator Locator
		{
			get
			{
				return _locator ?? (_locator = new ViewModelLocator());
			}
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
