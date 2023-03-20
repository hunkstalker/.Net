using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

using MVVM.App.View;

namespace MVVM.App.ViewModel
{
	public class VMPage1 : BaseViewModel
	{
		#region VARIABLES
		string _Mensaje;
		string _Num1;
		string _Num2;
		string _TipoUsuario;
		string _ResultadoFecha;
		DateTime _Fecha;
		#endregion

		#region CONSTRUCTOR
		public VMPage1(INavigation navigation)
		{
			Navigation = navigation;
			Fecha = DateTime.Now;
		}
		#endregion

		#region OBJETOS
		public string Mensaje
		{
			get { return _Mensaje; }
			set { SetValue(ref _Mensaje, value);}
		}
		public string Num1
		{
			get { return _Num1; }
			set { SetValue(ref _Num1, value);}
		}
		public string Num2
		{
			get { return _Num2; }
			set { SetValue(ref _Num2, value);}
		}
		public string TipoUsuario
		{
			get { return _TipoUsuario; }
			set { SetValue(ref _TipoUsuario, value);}
		}
		public string SeleccionTipoUsuario
		{
			get { return _TipoUsuario; }
			set { SetProperty(ref _TipoUsuario, value);
				TipoUsuario = _TipoUsuario;
			}
		}
		public string ResultadoFecha
		{
			get { return _ResultadoFecha; }
			set { SetValue(ref _ResultadoFecha, value);}
		}
		public DateTime Fecha
		{
			get { return _Fecha; }
			set { SetValue(ref _Fecha, value);
				ResultadoFecha = _Fecha.ToString("dd/MM/yyyy");
			}
		}
		#endregion

		#region PROCESOS
		public async Task AsyncNavToPage2()
		{
			await Navigation.PushAsync(new Page2());
		}
		public async Task AsyncNavBack()
		{
			await Navigation.PopAsync();
		}
		public async Task AsyncAlert()
		{
			await DisplayAlert("Popup!", Mensaje, "OK");
		}
		public void Suma()
		{
			double n1 = Convert.ToDouble(Num1);
			double n2 = Convert.ToDouble(Num2);

			_ = DisplayAlert("¡Resultado!", (n1 + n2).ToString(), "OK");
		}
		public void Notificacion()
		{
			_ = DisplayAlert("¡Información!", "Pues eso", "OK");
		}
		#endregion

		#region COMANDOS
		public ICommand AsyncNavToPage2Command => new Command(async () => await AsyncNavToPage2());
		public ICommand AsyncNavBackCommand => new Command(async () => await AsyncNavBack());
		public ICommand AsyncAlertCommand => new Command(async () => await AsyncAlert());
		public ICommand SumaCommand => new Command(Suma);
		public ICommand NotificacionCommand => new Command(Notificacion);
		#endregion
	}
}
