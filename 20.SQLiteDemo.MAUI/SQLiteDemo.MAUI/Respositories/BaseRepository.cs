using SQLite;
using SQLiteDemo.MAUI.Abstractions;
using SQLiteNetExtensions.Extensions;
using System.Linq.Expressions;

namespace SQLiteDemo.MAUI.Respositories
{
	public class BaseRepository<T> : IBaseRepository<T> where T : TableData, new()
	{
		readonly SQLiteConnection connection;

		public string StatusMessage { get; set; }

		public BaseRepository()
		{
			connection = new SQLiteConnection(Constants.DatabasePath, Constants.Flags);
			connection.CreateTable<T>();
		}

		public void Dispose()
		{
			connection.Close();
		}

		public void SaveItem(T item)
		{
			int result;
			if (item.Id != 0)
			{
				result = connection.Update(item);
				StatusMessage = $"{result} row(s) updated";
			}
			else
			{
				result = connection.Insert(item);
				StatusMessage = $"{result} row(s) added";
			}
		}

		public void SaveItemWithChildren(T item, bool recursive = false)
		{
			connection.InsertWithChildren(item, recursive);
		}

		public T GetItem(int id)
		{
			try
			{
				return connection.Table<T>().FirstOrDefault(x => x.Id == id);
			}
			catch (Exception ex)
			{

				StatusMessage = $"Error: {ex.Message}";
				return null;
			}
		}

		public T GetItem(Expression<Func<T, bool>> expression)
		{
			try
			{
				return connection.Table<T>().Where(expression).FirstOrDefault();
			}
			catch (Exception ex)
			{

				StatusMessage = $"Error: {ex.Message}";
				return null;
			}
		}

		public List<T> GetItems()
		{
			try
			{
				return connection.Table<T>().ToList();
			}
			catch (Exception ex)
			{

				StatusMessage = $"Error: {ex.Message}";
				return null;
			}
		}

		public List<T> GetItems(Expression<Func<T, bool>> expression)
		{
			try
			{
				return connection.Table<T>().Where(expression).ToList();
			}
			catch (Exception ex)
			{

				StatusMessage = $"Error: {ex.Message}";
				return null;
			}
		}

		public List<T> GetItemsWithChildren()
		{
			try
			{
				return connection.GetAllWithChildren<T>().ToList();
			}
			catch (Exception ex)
			{

				StatusMessage = $"Error: {ex.Message}";
				return null;
			}
		}

		public void DeleteItem(T item)
		{
			try
			{
				connection.Delete(item);
			}
			catch (Exception ex)
			{
				StatusMessage = $"Error: {ex.Message}";
			}
		}

		public void DeleteItemWithChildren(T item)
		{
			try
			{
				connection.Delete(item, true);
			}
			catch (Exception ex)
			{
				StatusMessage = $"Error: {ex.Message}";
			}
		}
	}
}
