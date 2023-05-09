using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RESTDemo.MAUI;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		using (JsonTextReader reader = new(File.OpenText(@"C:\secrets.json")))
		{
			JObject jsonAPIURL = (JObject)JToken.ReadFrom(reader);
			SecureStorage.SetAsync("API_URL", (string)jsonAPIURL.Property("API_URL"));
		}

		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
