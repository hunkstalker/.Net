using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

using MVVM.App.Model;

namespace MVVM.App.ViewModel
{
    class VMPage2 : BaseViewModel
    {
		#region VARIABLES
		string _Text;
		public List<MUsuarios> ListaUsuarios { get; set; }
		#endregion

		#region CONSTRUCTOR
		public VMPage2(INavigation navigation)
		{
			Navigation = navigation;
			MostrarUsuarios();
		}
		#endregion

		#region OBJETOS
		public string Text
		{
			get { return _Text; }
			set { SetValue(ref _Text, value); }
		}
		#endregion

		#region PROCESOS
		public async Task AsyncNavBack()
		{
			await Navigation.PopAsync();
		}
		public void MostrarUsuarios()
		{
			ListaUsuarios = new List<MUsuarios>
			{
				new MUsuarios
				{
					Nombre = "Frank the Fish",
					Imagen = "https://i.ibb.co/gvpcDWw/pescado.png"
				},
				new MUsuarios
				{
					Nombre = "Cute topus",
					Imagen = "https://i.ibb.co/RSrm1rJ/pulpo.png"
				},
				new MUsuarios
				{
					Nombre = "Milk!",
					Imagen = "https://i.ibb.co/ZLCmpR7/caja-de-leche.png"
				},
			};
		}
		public async Task AsyncAlert(MUsuarios parametros)
		{
			await DisplayAlert("Frame", "Nombre: " + parametros.Nombre, "OK");
		}
		#endregion

		#region COMANDOS
		public ICommand AsyncNavBackCommand => new Command(async () => await AsyncNavBack());
		public ICommand SimpleProcessCommand => new Command(MostrarUsuarios);
		public ICommand AsyncAlertCommand => new Command<MUsuarios>(async (p) => await AsyncAlert(p));
		#endregion
	}
}
