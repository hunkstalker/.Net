using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

using MVVM.App.Model;
using MVVM.App.Datos;
using System.ComponentModel;

namespace MVVM.App.ViewModel.VMPokemon
{
    public class VMResgistroPokemon : BaseViewModel
    {
		#region VARIABLES
		string _Numero;
		string _TxtNombre;
		string _Imagen;
		string _Tipo1;
		string _Tipo2;

		public Dictionary<string, string> _BackgroundColor = new Dictionary<string, string>()
		{
			{"Planta", "#D6F0EA" }
		};
		#endregion

		#region CONSTRUCTOR
		public VMResgistroPokemon(INavigation navigation)
		{
			Navigation = navigation;
		}
		#endregion

		#region OBJETOS
		public string Numero
		{
			get => _Numero;
			set { SetValue(ref _Numero, value); }
		}
		public string Nombre
		{
			get => _TxtNombre;
			set { SetValue(ref _TxtNombre, value); }
		}
		public string Imagen
		{
			get => _Imagen;
			set { SetValue(ref _Imagen, value); }
		}
		public string Tipo1
		{
			get => _Tipo1;
			set { SetValue(ref _Tipo1, value); }
		}
		public string Tipo2
		{
			get => _Tipo2;
			set { SetValue(ref _Tipo2, value); }
		}
		#endregion

		#region PROCESOS
		public async Task Insert()
		{
			var function = new DPokemon();
			var parametros = new MPokemon();

			parametros.Numero = _Numero;
			parametros.Nombre = _TxtNombre;
			parametros.Imagen = _Imagen;
			parametros.Tipo1 = _Tipo1;
			parametros.Tipo2 = _Tipo2;

			await function.PostPokemon(parametros);
			await NavBack();
		}
		public async Task NavBack()
		{
			await Navigation.PopAsync();
		}
		public void SimpleProcess()
		{

		}
		#endregion

		#region COMANDOS
		public ICommand InsertCommand => new Command(async () => await Insert());
		public ICommand NavBackCommand => new Command(async () => await NavBack());
		public ICommand SimpleProcessCommand => new Command(SimpleProcess);
		#endregion
	}
}
