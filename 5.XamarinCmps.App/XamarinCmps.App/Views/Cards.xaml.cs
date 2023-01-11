using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCmps.App.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Cards : ContentPage
	{
		public Cards()
		{
			InitializeComponent();
		}

		private void BtnVolver_Clicked(object sender, EventArgs e)
		{
			Navigation.PopAsync();
        }
    }
}