using Weather.MAUI.MVVM.ViewModels;

namespace Weather.MAUI.MVVM.Views;

public partial class WeatherView : ContentPage
{
	public WeatherView()
	{
		InitializeComponent();
		BindingContext = new WeatherViewModel();
	}
}