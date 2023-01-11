using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCmps.App.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Calendario : ContentPage
	{
		public Calendario()
		{
			InitializeComponent();
		}

		private void dtFecha_DateSelected(object sender, DateChangedEventArgs e)
		{
			lblResultadoFecha.Text = dtFecha.Date.ToString("dd/MM/yyyy");
		}

		private void tpHora_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			lblResultadoHora.Text = tpHora.Time.ToString();
		}
	}
}