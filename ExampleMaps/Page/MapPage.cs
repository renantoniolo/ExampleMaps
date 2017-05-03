using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace ExampleMaps
{
	public class MapPage : ContentPage
	{
		
		readonly Position DEFAULT_POSITION = new Position(-23.550520, -46.633309);


		public MapPage()
		{
			var myMap = new Map()
			{
				IsShowingUser = true,
				HeightRequest = 100,
				WidthRequest = 960,
				VerticalOptions = LayoutOptions.FillAndExpand
			};

			// type of map
			myMap.MapType = MapType.Street;


			// add Pin of View
			var pin = new Pin
			{
				Type = PinType.Generic,
				Position = new Position(-23.550820, -46.633209),
				Label = "ASSALTO",
				Address = "Rua teste, 123 - São Paulo"
			};


			// add pin on map
			myMap.Pins.Add(pin);

			// center the map
			myMap.MoveToRegion(MapSpan.FromCenterAndRadius(DEFAULT_POSITION,
				Distance.FromKilometers(1)));

			// instancie StackLayout
			var stack = new StackLayout { Spacing = 0 };

			// add no stacklayout
			stack.Children.Add(myMap);

			//add in content
			Content = stack;
		}




	}
}

