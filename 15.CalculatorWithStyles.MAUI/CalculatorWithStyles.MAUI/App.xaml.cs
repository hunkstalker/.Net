using CalculatorWithStyles.MAUI.MVVM.Views;

namespace CalculatorWithStyles.MAUI;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new CalcView();
	}
}
