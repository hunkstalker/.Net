using Microsoft.Extensions.Configuration;
using Microsoft.Maui.Controls;

namespace RESTDemo.MAUI;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		MainPage = new AppShell();
	}
}
