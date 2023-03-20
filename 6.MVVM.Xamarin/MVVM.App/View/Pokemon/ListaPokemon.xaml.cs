using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using MVVM.App.ViewModel.VMPokemon;

namespace MVVM.App.View.Pokemon
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListaPokemon : ContentPage
	{
		VMListaPokemon vm;
		public ListaPokemon ()
		{
			InitializeComponent ();
			vm = new VMListaPokemon(Navigation);
			BindingContext = vm;
			this.Appearing += ListaPokemon_Appearing;
		}

		private async void ListaPokemon_Appearing(object sender, EventArgs e)
		{
			await vm.ShowPokemon();
		}
	}
}