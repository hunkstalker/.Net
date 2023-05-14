using SQLiteDemo.MAUI.MVVM.ViewModels;

namespace SQLiteDemo.MAUI.MVVM.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainPageViewModel();
	}
}