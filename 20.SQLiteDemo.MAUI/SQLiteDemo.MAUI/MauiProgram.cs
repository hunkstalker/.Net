﻿using Microsoft.Extensions.Logging;
using SQLiteDemo.MAUI.MVVM.Models;
using SQLiteDemo.MAUI.Respositories;

namespace SQLiteDemo.MAUI;

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
		builder.Services.AddSingleton<BaseRepository<Customer>>();
		builder.Services.AddSingleton<BaseRepository<Order>>();
		builder.Services.AddSingleton<BaseRepository<Passport>>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
