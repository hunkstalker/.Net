using ProsperDaily.MAUI.MVVM.ViewModels;

namespace ProsperDaily.MAUI.MVVM.Views;

public partial class TransactionsPage : ContentPage
{
	public TransactionsPage()
	{
		InitializeComponent();
		BindingContext = new TransactionsViewModel();
	}

	private async void Save_Clicked(object sender, EventArgs e)
	{
		var currentVM = (TransactionsViewModel)BindingContext;
		if (currentVM != null)
		{
			// Error: Le quita el punto donde tiene que haber el decimal
			decimal num = currentVM.Transaction.Amount;
			Console.WriteLine(num);
			var message = currentVM.SaveTransaction();
			await DisplayAlert("Info", message, "Ok");
			await Navigation.PopToRootAsync();
		}
    }

	private async void Cancel_Clicked(object sender, EventArgs e)
	{
		await Navigation.PopToRootAsync();
	}
}