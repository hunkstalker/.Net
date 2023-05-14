using SQLite;

namespace SQLiteDemo.MAUI.Abstractions
{
	public class TableData
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
	}
}
