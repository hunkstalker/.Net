using SQLite;
using SQLiteDemo.MAUI.MVVM.Models;
using System.Linq.Expressions;

namespace SQLiteDemo.MAUI.Respositories
{
	public class CustomerRepository
	{
		readonly SQLiteConnection connection;

		public string StatusMessage { get; set; }

		public CustomerRepository()
		{
			connection = new SQLiteConnection(Constants.DatabasePath, Constants.Flags);
			connection.CreateTable<Customer>();
		}

		public void AddOrUpdate(Customer customer)
		{
			try
			{
				int result;
				if (customer.Id != 0)
				{
					result = connection.Update(customer);
					StatusMessage = $"{result} row(s) updated";
				}
				else
				{
					result = connection.Insert(customer);
					StatusMessage = $"{result} row(s) added";
				}
			}
			catch (Exception ex)
			{
				StatusMessage = $"Error: {ex.Message}";
			}
		}

		public List<Customer> GetAll()
		{
			try
			{
				return connection.Table<Customer>().ToList();
			}
			catch (Exception ex)
			{

				StatusMessage = $"Error: {ex.Message}";
				return null;
			}
		}

		public List<Customer> GetAll_SQL()
		{
			try
			{
				return connection.Query<Customer>("SELECT * FROM Customers").ToList();
			}
			catch (Exception ex)
			{

				StatusMessage = $"Error: {ex.Message}";
				return null;
			}
		}

		public List<Customer> GetWithLambda(Expression<Func<Customer, bool>> predicate)
		{
			if (predicate is null)
			{
				throw new ArgumentNullException(nameof(predicate));
			}
			else
			{
				try
				{
					return connection.Table<Customer>().Where(predicate).ToList();
				}
				catch (Exception ex)
				{

					StatusMessage = $"Error: {ex.Message}";
					return null;
				}
			}
		}

		public Customer Get(int id)
		{
			try
			{
				return connection.Table<Customer>().FirstOrDefault(x => x.Id == id);
			}
			catch (Exception ex)
			{

				StatusMessage = $"Error: {ex.Message}";
				return null;
			}
		}

		public void Delete(int customerId)
		{
			try
			{
				var customer = Get(customerId);
				connection.Delete(customer);
			}
			catch (Exception ex)
			{
				StatusMessage = $"Error: {ex.Message}";
			}
		}


	}
}
