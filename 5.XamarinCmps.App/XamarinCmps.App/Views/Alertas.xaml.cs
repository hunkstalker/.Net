using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Rg.Plugins.Popup.Services;

namespace XamarinCmps.App.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Alertas : ContentPage
	{
		public Alertas()
		{
			InitializeComponent();
		}

		private void BtnAlerta_Clicked(object sender, EventArgs e)
		{
			//DisplayAlert("Título", "Mensaje de alerta", "OK");
			PopupNavigation.Instance.PushAsync(new AlertaPopupCustom());
		}
	}
}