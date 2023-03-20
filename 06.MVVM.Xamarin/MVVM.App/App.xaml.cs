using System;
using Xamarin.Forms;
using MVVM.App.View.Pokemon;

namespace MVVM.App
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();
			MainPage = new NavigationPage(new ListaPokemon());
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
