using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using MVVM.App.ViewModel;

namespace MVVM.App.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1()
		{
			InitializeComponent();
			BindingContext = new VMPage1(Navigation);
		}
	}
}