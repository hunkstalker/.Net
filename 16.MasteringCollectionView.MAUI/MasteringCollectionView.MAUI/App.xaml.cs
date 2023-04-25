using MasteringCollectionView.MAUI.MVVM.Views;

namespace MasteringCollectionView.MAUI;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new DataView();
	}

	protected override Window CreateWindow(IActivationState activationState)
	{
		Window window = base.CreateWindow(activationState);

		window.Height = 760;
		window.Width = 420;

		return window;
	}
}
