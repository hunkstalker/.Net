using System.Text.Json;
using System.Windows.Input;

namespace RESTDemo.MAUI
{
	public class MainViewModel
	{
		readonly HttpClient client;
		readonly JsonSerializerOptions _serializerOptions;

		public string API_URL { get; set; }
		public string ID { get; set; } = "1";

		public MainViewModel()
		{
			client = new HttpClient();
			_serializerOptions = new JsonSerializerOptions
			{
				WriteIndented = true,
			};

			var apiUrlTask = GetApiUrlAsync();
			API_URL = apiUrlTask.GetAwaiter().GetResult();
		}

		public ICommand GetAllUsersCommand => new Command(async () =>
		{
			var url = $"{API_URL}/users";
			var response = await client.GetAsync(url);
			if (response.IsSuccessStatusCode)
			{
				using var responseStream = await response.Content.ReadAsStreamAsync();
				var data = await JsonSerializer.DeserializeAsync<List<User>>(responseStream, _serializerOptions);
			}
		});

		public ICommand GetSingleUserCommand => new Command(async () =>
		{
			var url = $"{API_URL}/users/{ID}";
			var response = await client.GetAsync(url);
			if (response.IsSuccessStatusCode)
			{
				using var responseStream = await response.Content.ReadAsStreamAsync();
				var data = await JsonSerializer.DeserializeAsync<User>(responseStream, _serializerOptions);
			}
		});

		private static async Task<string> GetApiUrlAsync()
		{
			var API_URL = await SecureStorage.GetAsync("API_URL");
			return API_URL;
		}
	}
}
