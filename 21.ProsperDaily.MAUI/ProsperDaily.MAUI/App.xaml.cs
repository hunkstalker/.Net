using ProsperDaily.MAUI.MVVM.Models;
using ProsperDaily.MAUI.MVVM.Views;
using ProsperDaily.MAUI.Repositories;
using System.Globalization;

namespace ProsperDaily.MAUI;

public partial class App : Application
{
	public static BaseRepository<Transaction> TransactionsRepo { get; private set; }

	public App(BaseRepository<Transaction> _transactionsRepo)
	{
		CultureInfo customCulture = (CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
		customCulture.NumberFormat.NumberDecimalSeparator = ".";

		Thread.CurrentThread.CurrentCulture = customCulture;

		//Register Syncfusion license
		Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("");
		InitializeComponent();

		TransactionsRepo = _transactionsRepo;

		MainPage = new StatisticsPage();
	}
}
