using ProsperDaily.MAUI.MVVM.Views;

namespace ProsperDaily.MAUI;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new DashboardPage();
	}
}
