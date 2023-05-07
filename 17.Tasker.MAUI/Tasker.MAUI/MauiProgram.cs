using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;
using Microsoft.Extensions.Logging;

namespace Tasker.MAUI;

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
				fonts.AddFont("Roboto-Regular.ttf", "Roboto");
			}).ConfigureMauiHandlers(AppHostBuilderExtensions =>
			{
				// Personalización del control Entry
				Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("RemoveUnderline", (handler, view) =>
				{
#if ANDROID
					handler.PlatformView.Background = null;
#elif IOS || MACCATALYST
					handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
#elif WINDOWS
					handler.PlatformView.BorderThickness = new Microsoft.UI.Xaml.Thickness(0);
#endif
				});
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
