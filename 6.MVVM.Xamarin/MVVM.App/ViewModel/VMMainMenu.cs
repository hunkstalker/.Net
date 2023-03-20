using System;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

using MVVM.App.Model;
using MVVM.App.View;

namespace MVVM.App.ViewModel
{
	class VMMainMenu : BaseViewModel
	{
		#region VARIABLES
		string _Text;
		public List<MMainMenu> ListaMainMenu { get; set; }
		#endregion

		#region CONSTRUCTOR
		public VMMainMenu(INavigation navigation)
		{
			Navigation = navigation;
			ShowMainMenu();
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
		public void ShowMainMenu()
		{
			ListaMainMenu = new List<MMainMenu>
			{
				new MMainMenu
				{
					Page = "Entry, DatePicker, TimePicker, \nLabel y Navigation",
					Icon = "https://i.ibb.co/gvpcDWw/pescado.png"
				},
				new MMainMenu
				{
					Page= "CollectionView sin enlace a BBDD",
					Icon = "https://i.ibb.co/RSrm1rJ/pulpo.png"
				},
				new MMainMenu
				{
					Page = "CRUD Pokémon",
					Icon = "pikachu.png"
				},
			};
		}
		public async Task AsyncNavMainMenu(MMainMenu parametros)
		{
			string page = parametros.Page;

			if (page.Contains("Entry"))
			{
				await Navigation.PushAsync(new Page1());
			}
			if (page.Contains("CollectionView"))
			{
				await Navigation.PushAsync(new Page2());
			}
			if (page.Contains("CRUD"))
			{
				await Navigation.PushAsync(new Page3());
			}
		}
		#endregion

		#region COMANDOS
		public ICommand AsyncNavBackCommand => new Command(async () => await AsyncNavBack());
		public ICommand SimpleProcessCommand => new Command(ShowMainMenu);
		public ICommand AsyncNavMainMenuCommand => new Command<MMainMenu>(async (p) => await AsyncNavMainMenu(p));
		#endregion
	}
}
