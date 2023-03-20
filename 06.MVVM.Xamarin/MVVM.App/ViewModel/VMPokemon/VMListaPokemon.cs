using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;

using MVVM.App.View.Pokemon;
using MVVM.App.Datos;
using MVVM.App.Model;
using System.Linq;

namespace MVVM.App.ViewModel.VMPokemon
{
    public class VMListaPokemon : BaseViewModel
    {
		#region VARIABLES
		string _Text;
		List<MPokemon> _ListaPokemon;
		#endregion

		#region CONSTRUCTOR
		public VMListaPokemon(INavigation navigation)
		{
			Navigation = navigation;
			_ = ShowPokemon();
		}
		#endregion

		#region OBJETOS
		public List<MPokemon> ListaPokemon
		{
			get { return _ListaPokemon; }
			set { SetValue(ref _ListaPokemon, value); }
		}
		public string Text
		{
			get { return _Text; }
			set { SetValue(ref _Text, value); }
		}
		#endregion

		#region PROCESOS
		public async Task ShowPokemon()
		{
			var function = new DPokemon();
			ListaPokemon = await function.GetPokemon();
			ListaPokemon = ListaPokemon.OrderBy(x => x.Numero).ToList();
		}
		public async Task NavToRegister()
		{
			await Navigation.PushAsync(new RegistroPokemon());
		}
		public void SimpleProcess()
		{

		}
		#endregion

		#region COMANDOS
		public ICommand NavToRegisterCommand => new Command(async () => await NavToRegister());
		public ICommand SimpleProcessCommand => new Command(SimpleProcess);
		#endregion
	}
}
