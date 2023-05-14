using Bogus;
using PropertyChanged;
using SQLiteDemo.MAUI.MVVM.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace SQLiteDemo.MAUI.MVVM.ViewModels
{
	[AddINotifyPropertyChangedInterface]
	public class MainPageViewModel
	{
		public List<Customer> Customers { get; set; }
		public Customer CurrentCustomer { get; set; }

		public ICommand AddOrUpdateCommand { get; set; }
		public ICommand DeleteCommand { get; set; }

		public MainPageViewModel()
		{
			var orders = App.OrdersRepo.GetItems();

			Refresh();
			GenerateNewCustomer();

			AddOrUpdateCommand = new Command(() =>
			{
				App.CustomersRepo.SaveItemWithChildren(CurrentCustomer);
				Console.WriteLine(App.CustomersRepo.StatusMessage);
				GenerateNewCustomer();
				Refresh();
			});

			DeleteCommand = new Command(() =>
			{
				App.CustomersRepo.DeleteItemWithChildren(CurrentCustomer);
				GenerateNewCustomer();
				Refresh();
			});
		}

		private void GenerateNewCustomer()
		{
			CurrentCustomer = new Faker<Customer>()
				.RuleFor(x => x.Name, f => f.Person.FullName)
				.RuleFor(x => x.Address, f => f.Person.Address.Street)
				.Generate();

			CurrentCustomer.Passport = new List<Passport>
			{
				new Passport
				{
					ExpirationDate = DateTime.Now.AddDays(30)
				},
				new Passport
				{
					ExpirationDate = DateTime.Now.AddDays(30)
				}
			};
		}

		private void Refresh()
		{
			//Customers = App.CustomersRepo.GetItems();
			//Customers = App.CustomerRepo.GetAll();
			//Customers = App.CustomerRepo.GetWithLambda(x => x.Name.StartsWith("A"));
			Customers = App.CustomersRepo.GetItemsWithChildren();
			var passports = App.PassportsRepo.GetItems();
		}
	}
}
