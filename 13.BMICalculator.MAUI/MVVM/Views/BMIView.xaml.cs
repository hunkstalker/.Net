using BMICalculator.MAUI.MVVM.ViewModels;

namespace BMICalculator.MAUI.MVVM.Views;

public partial class BMIView : ContentPage
{
	public BMIView()
	{
		InitializeComponent();
		BindingContext = new BMIViewModel();
	}
}