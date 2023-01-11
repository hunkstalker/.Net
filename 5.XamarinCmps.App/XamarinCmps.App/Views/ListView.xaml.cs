using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinCmps.App.Models;

namespace XamarinCmps.App.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListView : ContentPage
	{
		public IList<MMenu> ListaMenu { get; private set; }
		public ListView()
		{
			InitializeComponent();
			ListaMenu = new List<MMenu>
			{
				new MMenu()
				{
					Nombre = "Usuario",
					Imagen = "https://lexica-serve-encoded-images2.sharif.workers.dev/full_jpg/3d72e032-26c8-4168-97af-a3bc52424ae0",
					IsRounded = true
				},
				new MMenu()
				{
					Nombre = "Alertas",
					Imagen = "alerta.png",
					IsRounded = false
				},
				new MMenu()
				{
					Nombre = "Cards",
					Imagen = "frame.png",
					IsRounded = false
				},
				new MMenu()
				{
					Nombre = "Fechas",
					Imagen = "calendario.png",
					IsRounded = false
				}
			};
			BindingContext = this;
		}

		private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
		{
			MMenu seleccion = e.Item as MMenu;
			if (seleccion.Nombre == "Usuario")
			{
				Navigation.PushAsync(new Usuario());
			}
			if (seleccion.Nombre == "Alertas")
			{
				Navigation.PushAsync(new Alertas());
			}
			if (seleccion.Nombre == "Cards")
			{
				Navigation.PushAsync(new Cards());
			}
			if (seleccion.Nombre == "Fechas")
			{
				Navigation.PushAsync(new Calendario());
			}
		}

		private void GridView_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new MainMenu());
		}
    }
}