using System.Text;
using System.Text.Json;
using System.Windows.Input;

namespace RESTDemo.MAUI
{
	public class MainViewModel
	{
		readonly HttpClient client;
		readonly JsonSerializerOptions _serializerOptions;

		private List<User> Users;

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
				Users = data;
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

		public ICommand AddUserCommand => new Command(async () =>
		{
			var url = $"{API_URL}/users";
			var user = new User
			{
				createdAt = DateTime.Now,
				name = "Strelok",
				avatar = "https://fakeimg.pl/350x200/?text=MAUI"
			};
			string json = JsonSerializer.Serialize(user, _serializerOptions);
			StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
			var response = await client.PostAsync(url,content);
		});

		public ICommand UpdateUserCommand => new Command(async () =>
		{
			User user = new();
			string userNumberToUpdate = "1";

			if (Users.Count > 0)
			{
				user = Users.FirstOrDefault(x => x.id == userNumberToUpdate);
				var url = $"{API_URL}/users/${userNumberToUpdate}";

				user.name = "Max";

				string json = JsonSerializer.Serialize(user, _serializerOptions);
				StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
				var response = await client.PutAsync(url, content);
			}
		});

		private static async Task<string> GetApiUrlAsync()
		{
			var API_URL = await SecureStorage.GetAsync("API_URL");
			return API_URL;
		}
	}
}
