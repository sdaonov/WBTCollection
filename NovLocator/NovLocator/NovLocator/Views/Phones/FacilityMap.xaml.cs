using NovLocator.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace NovLocator.Views.Phones
{
	public partial class FacilityMap : ContentPage
	{

		private Map _facilityMap;

		public FacilityMap()
		{

			InitializeComponent();

			BindingContext = App.Locator.FacilityMap;

			InitMap();
			
			RefreshMap();
									
		}

		private void RefreshMap()
		{

			var facility = ((FacilityMapViewModel)BindingContext).Current;

			//var position = new Position(36.9628066, -122.0194722); // Latitude, Longitude
			var position = new Position(facility.Pos[0], facility.Pos[1]); // Latitude, Longitude
			var pin = new Pin
			{
				Type = PinType.Place,
				Position = position,
				Label = facility.Name,
				Address = facility.StreesAddress1,
			};
			_facilityMap.Pins.Add(pin);

		}

		private void InitMap()
		{
			_facilityMap = new Map
			{
				IsShowingUser = true,
				HeightRequest = 100,
				WidthRequest = 960,
				VerticalOptions = LayoutOptions.FillAndExpand
			};
		}
		
		protected override async void OnAppearing()
		{
			
			var main = Content as StackLayout;
			var mapFrame = main.Children.First() as StackLayout;
			mapFrame.Children.Add(_facilityMap);

			await WaitAndExecute(3000);
			await WaitAndExecute(5000);
			await WaitAndExecute(7000);
			await WaitAndExecute(9000);

		}

		protected async Task WaitAndExecute(int milisec)
		{

			await Task.Delay(milisec);

			_facilityMap.MoveToRegion(MapSpan.FromCenterAndRadius(_facilityMap.Pins.First().Position, Distance.FromMiles(3)));

		}

		private async void btnBack_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Main());
		}

		private void btnReCenterLocation_Clicked(object sender, EventArgs e)
		{
			_facilityMap.MoveToRegion(MapSpan.FromCenterAndRadius(_facilityMap.Pins.First().Position, Distance.FromMiles(3)));
		}

	}
}
