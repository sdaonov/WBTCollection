using Newtonsoft.Json;
using NovLocator.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using NovLocator.Utilities;

namespace NovLocator.Views.Phones
{




	public partial class Main : ContentPage
	{

		const int TIMEOUT = 100000;

		private ObservableCollection<Facility> _facilities = new ObservableCollection<Facility>();

		public Main()
		{

			InitializeComponent();

			BindingContext = App.Locator.Main;

			lstFacilities.ItemTapped += lstFacilities_ItemTapped;

			Refresh();

		}

		//private async void btnView_Clicked(object sender, EventArgs e)
		//{

		//}

		//private async void btnUncheckAll_Clicked(object sender, EventArgs e)
		//{

		//}

		private async void lstFacilities_ItemTapped(object sender, ItemTappedEventArgs e)
		{

			var facilityMap = App.Locator.FacilityMap;
			facilityMap.Current = (Facility)e.Item;

			await Navigation.PushAsync(new FacilityMap());

		}

		private async void btnFacilityView_Clicked(object sender, EventArgs e)
		{
			await DisplayAlert("Alert", "You have been alerted", "OK");
		}

		private async void Refresh()
		{

			var facilities = await FetchFacilities();
			foreach(var fac in facilities) _facilities.Add(fac);

			lstFacilities.ItemsSource = _facilities;

		}

		// Gets weather data from the passed URL.  
		private async Task<List<Facility>> FetchFacilities()
		{

			var result = new List<Facility>();
			var url = "https://go.nov.com/api/facility_locator/facility";

			var uriFacilities = new Uri(url);
			var request = HttpWebRequest.Create(uriFacilities);
			request.Method = "GET";

			using (var rsp = await request.GetResponseAsync(TIMEOUT))
			{
				using (var rst = rsp.GetResponseStream())
				{
					using (var sr = new StreamReader(rst))
					{

						var jresult = sr.ReadToEnd();
						result = JsonConvert.DeserializeObject<List<Facility>>(jresult);

					}
				}
			}

			return result;

		}


	}

}
