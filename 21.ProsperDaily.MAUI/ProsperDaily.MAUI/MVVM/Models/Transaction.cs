using ProsperDaily.MAUI.Abstractions;

namespace ProsperDaily.MAUI.MVVM.Models
{
	public class Transaction : TableData
	{
		public string Name { get; set; }
		public decimal Amount { get; set; }
		public bool IsIncome { get; set; }
		public DateTime TransactionDate { get; set; }
	}
}
