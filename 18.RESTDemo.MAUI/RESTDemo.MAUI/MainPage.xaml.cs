using Microsoft.Extensions.Configuration;
using Microsoft.Maui.Controls;

namespace RESTDemo.MAUI;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();
	}
}

