using System.Collections.ObjectModel;
using Tasker.MAUI.MVVM.Models;

namespace Tasker.MAUI.MVVM.ViewModels
{
	public class NewTaskViewModel
	{
		public string Task { get; set; }
		public ObservableCollection<MyTask> Tasks { get; set; }
		public ObservableCollection<Category> Categories { get; set; }
	}
}
