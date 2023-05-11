﻿using System.Windows.Input;

namespace Weather.MAUI.MVVM.ViewModels
{
	public class WeatherViewModel
	{
		public ICommand SearchCommand => new Command(async (searchText) =>
		{
			var location = await GetCoordinatesAsync(searchText.ToString());
		});

		public static async Task<Location> GetCoordinatesAsync(string address)
		{
			IEnumerable<Location> locations = await Geocoding.Default.GetLocationsAsync(address);

			Location location = locations?.FirstOrDefault();

			if (location != null)
				Console.WriteLine($"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");
			return location;
		}
	}
}
