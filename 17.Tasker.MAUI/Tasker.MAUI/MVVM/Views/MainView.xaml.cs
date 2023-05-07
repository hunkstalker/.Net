using Tasker.MAUI.MVVM.ViewModels;

namespace Tasker.MAUI.MVVM.Views;

public partial class MainView : ContentPage
{
	private MainViewModel mainViewModel = new();

	public MainView()
	{
		InitializeComponent();
		BindingContext = mainViewModel;
	}

	private void checkBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
	{
		mainViewModel.UpdateData();
	}
}