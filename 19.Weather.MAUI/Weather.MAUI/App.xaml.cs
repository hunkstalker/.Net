using Weather.MAUI.MVVM.Views;

namespace Weather.MAUI;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new WeatherView();
	}

	protected override Window CreateWindow(IActivationState activationState)
	{
		Window window = base.CreateWindow(activationState);

		window.Height = 760;
		window.Width = 480;

		return window;
	}
}
