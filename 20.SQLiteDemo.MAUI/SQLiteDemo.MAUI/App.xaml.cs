using SQLiteDemo.MAUI.MVVM.Models;
using SQLiteDemo.MAUI.Respositories;

namespace SQLiteDemo.MAUI;

public partial class App : Application
{
	//public static CustomerRepository CustomerRepo { get; private set; }
	public static BaseRepository<Customer> CustomersRepo { get; private set; }
	public static BaseRepository<Order> OrdersRepo { get; private set; }
	public static BaseRepository<Passport> PassportsRepo { get; private set; }

	public App(BaseRepository<Customer> customersRepo, BaseRepository<Order> ordersRepo, BaseRepository<Passport> passportsRepo)
	{
		InitializeComponent();

		CustomersRepo = customersRepo;
		OrdersRepo = ordersRepo;
		PassportsRepo = passportsRepo;

		MainPage = new AppShell();
	}
}
