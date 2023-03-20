using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using XamarinCmps.App.Views;

namespace XamarinCmps.App
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new Views.ListView());
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
