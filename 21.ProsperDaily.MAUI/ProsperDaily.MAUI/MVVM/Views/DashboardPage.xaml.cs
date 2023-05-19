using ProsperDaily.MAUI.MVVM.ViewModels;

namespace ProsperDaily.MAUI.MVVM.Views;

public partial class DashboardPage : ContentPage
{
	public DashboardPage()
	{
		InitializeComponent();
		BindingContext = new DashboardViewModel();
	}

	private async void AddTransaction_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new TransactionsPage());
    }

	protected override void OnAppearing()
	{
		base.OnAppearing();
		var vm = (DashboardViewModel)BindingContext;
		vm.FillData();
	}
}