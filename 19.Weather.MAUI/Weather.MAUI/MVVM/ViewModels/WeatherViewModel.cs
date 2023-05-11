using System.Text.Json;
using System.Windows.Input;
using Weather.MAUI.MVVM.Models;

namespace Weather.MAUI.MVVM.ViewModels
{
	public class WeatherViewModel
	{
		public WeatherData WeatherData { get; set; }
		private HttpClient client;

		public WeatherViewModel()
		{
			client = new HttpClient();
		}

		public ICommand SearchCommand => new Command(async (searchText) =>
		{
			var location = await GetCoordinatesAsync(searchText.ToString());
			await GetWeather(location);
		});

		private async Task GetWeather(Location location)
		{
			var url = $"https://api.open-meteo.com/v1/forecast?latitude={location.Latitude}&longitude={location.Longitude}&hourly=temperature_2m&daily=weathercode,temperature_2m_max,temperature_2m_min&current_weather=true&timezone=auto";
			var response = await client.GetAsync(url);
			if (response.IsSuccessStatusCode)
			{
				using var responseStream = await response.Content.ReadAsStreamAsync();
				var data = await JsonSerializer.DeserializeAsync<WeatherData>(responseStream);
				WeatherData = data;
			}
		}

		static async Task<Location> GetCoordinatesAsync(string address)
		{
			IEnumerable<Location> locations = await Geocoding.Default.GetLocationsAsync(address);

			Location location = locations?.FirstOrDefault();

			if (location != null)
				Console.WriteLine($"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");
			return location;
		}
	}
}
