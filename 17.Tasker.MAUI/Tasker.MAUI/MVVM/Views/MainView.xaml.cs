using Tasker.MAUI.MVVM.ViewModels;

namespace Tasker.MAUI.MVVM.Views;

public partial class MainView : ContentPage
{
	public MainView()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();
	}
}