using SQLite;
using SQLiteDemo.MAUI.Abstractions;
using SQLiteNetExtensions.Attributes;

namespace SQLiteDemo.MAUI.MVVM.Models
{
	[Table("Customers")]
	public class Customer : TableData
	{
		[Column("name"), Indexed, NotNull]
		public string Name { get; set; }
		[Unique]
		public string Phone { get; set; }
		public int Age { get; set; }
		[MaxLength(100)]
		public string Address { get; set; }
		[Ignore]
		public bool Adult => Age > 17;

		[ForeignKey(typeof(Passport))]
		public int PassportId { get; set; }
		[OneToMany(CascadeOperations = CascadeOperation.All)]
		public List<Passport> Passport { get; set; }
	}
}
