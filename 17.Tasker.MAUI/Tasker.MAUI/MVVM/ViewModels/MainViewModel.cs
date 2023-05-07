using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasker.MAUI.MVVM.Models;

namespace Tasker.MAUI.MVVM.ViewModels
{
	public class MainViewModel
	{
		public ObservableCollection<Category> Categories { get; set; }

		public MainViewModel()
		{
			FillData();
		}

		private void FillData()
		{
			Categories = new()
			{
				new Category
				{
					Id = 1,
					CategoryName = ".Net MAUI Course",
					Color = "#CF14DF"
				},
				new Category
				{
					Id = 2,
					CategoryName = "Tutorials",
					Color = "#DF6F14"
				},
				new Category
				{
					Id = 3,
					CategoryName = "Shopping",
					Color = "#14DF80"
				}
			};
		}
	}
}
