using MVVM.App.ViewModel.VMPokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM.App.View.Pokemon
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RegistroPokemon : ContentPage
	{
		public RegistroPokemon ()
		{
			InitializeComponent ();
			BindingContext = new VMResgistroPokemon(Navigation);
		}
	}
}