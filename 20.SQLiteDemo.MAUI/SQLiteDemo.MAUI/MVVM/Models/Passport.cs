using SQLiteDemo.MAUI.Abstractions;
using SQLiteNetExtensions.Attributes;

namespace SQLiteDemo.MAUI.MVVM.Models
{
	public class Passport : TableData
	{
		public DateTime ExpirationDate { get; set; }

		[ForeignKey(typeof(Customer))]
		public int CustomerId { get; set; }
	}
}
