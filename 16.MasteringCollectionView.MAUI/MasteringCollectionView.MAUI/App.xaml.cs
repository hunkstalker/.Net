using MasteringCollectionView.MAUI.MVVM.Views;

namespace MasteringCollectionView.MAUI;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		//MainPage = new DataView();
		//MainPage = new LayoutsPage();
		//MainPage = new EmptyView();
		MainPage = new ProductsView();
	}

	protected override Window CreateWindow(IActivationState activationState)
	{
		Window window = base.CreateWindow(activationState);

		window.Height = 760;
		window.Width = 420;

		return window;
	}
}
