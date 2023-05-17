using ProsperDaily.MAUI.MVVM.Models;
using ProsperDaily.MAUI.MVVM.Views;
using ProsperDaily.MAUI.Repositories;

namespace ProsperDaily.MAUI;

public partial class App : Application
{
	public static BaseRepository<Transaction> TransactionsRepo { get; private set; }

	public App(BaseRepository<Transaction> _transactionsRepo)
	{
		//Register Syncfusion license
		Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("");
		InitializeComponent();

		TransactionsRepo = _transactionsRepo;

		MainPage = new TransactionsPage();
	}
}
