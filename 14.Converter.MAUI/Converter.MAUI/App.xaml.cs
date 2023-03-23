using Converter.MAUI.MVVM.Views;

namespace Converter.MAUI;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new MenuView());
	}

	protected override Window CreateWindow(IActivationState activationState)
	{
		Window window = base.CreateWindow(activationState);

		window.Height = 915;
		window.Width = 420;

		return window;
	}

}
