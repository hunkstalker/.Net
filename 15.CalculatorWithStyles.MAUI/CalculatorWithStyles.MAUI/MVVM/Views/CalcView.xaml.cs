using CalculatorWithStyles.MAUI.MVVM.ViewModels;

namespace CalculatorWithStyles.MAUI.MVVM.Views;

public partial class CalcView : ContentPage
{
	public CalcView()
	{
		InitializeComponent();
		BindingContext = new CalcViewModel();
	}
}