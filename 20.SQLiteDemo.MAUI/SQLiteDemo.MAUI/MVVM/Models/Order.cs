using SQLiteDemo.MAUI.Abstractions;

namespace SQLiteDemo.MAUI.MVVM.Models
{
	public class Order : TableData
	{
		public int CustomerId { get; set; }
		public DateTime OrderDate { get; set; }
	}
}
