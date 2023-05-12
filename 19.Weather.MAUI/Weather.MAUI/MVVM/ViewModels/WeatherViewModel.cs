using PropertyChanged;
using System.Text.Json;
using System.Windows.Input;
using Weather.MAUI.MVVM.Models;

namespace Weather.MAUI.MVVM.ViewModels
{
	[AddINotifyPropertyChangedInterface]
	public class WeatherViewModel
	{
		public WeatherData WeatherData { get; set; }
		public string PlaceName { get; set; }
		public DateTime Date { get; set; } = DateTime.Now;

		private HttpClient client;

		public WeatherViewModel()
		{
			client = new HttpClient();
		}

		public ICommand SearchCommand => new Command(async (searchText) =>
		{
			PlaceName = searchText.ToString();
			var location = await GetCoordinatesAsync(searchText.ToString());
			await GetWeather(location);
		});

		private async Task GetWeather(Location location)
		{
			string latitude = location.Latitude.ToString().Replace(",", ".");
			string longitude = location.Longitude.ToString().Replace(",", ".");
			var url = $"https://api.open-meteo.com/v1/forecast?latitude={latitude}&longitude={longitude}&daily=weathercode,temperature_2m_max,temperature_2m_min&current_weather=true&timezone=America%2FChicago";
			var response = await client.GetAsync(url);
			if (response.IsSuccessStatusCode)
			{
				using var responseStream = await response.Content.ReadAsStreamAsync();
				var data = await JsonSerializer.DeserializeAsync<WeatherData>(responseStream);
				WeatherData = data;

				for (int i = 0; i < WeatherData.daily.time.Length; i++)
				{
					var dailyArray = new DailyArray
					{
						time = WeatherData.daily.time[i],
						temperature_2m_max = WeatherData.daily.temperature_2m_max[i],
						temperature_2m_min = WeatherData.daily.temperature_2m_min[i],
						weathercode = WeatherData.daily.weathercode[i]
					};
					WeatherData.dailyArray.Add(dailyArray);
				}
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
