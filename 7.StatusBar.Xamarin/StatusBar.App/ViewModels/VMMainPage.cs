using System;
using System.Collections.Generic;
using System.Text;

using Xamarin.Forms;
using StatusBar.App.ViewModels;
using System.Windows.Input;

namespace StatusBar.App.ViewModels
{
	public class VMMainPage
	{
		public VMMainPage()
		{

		}
		public void Ocultar()
		{
			DependencyService.Get<VMStatusBar>().OcultarStatusBar();
		}
		public void Mostrar()
		{
			DependencyService.Get<VMStatusBar>().MostrarStatusBar();
		}
		public void Translucido()
		{
			DependencyService.Get<VMStatusBar>().Translucido();
		}
		public void Transparente()
		{
			DependencyService.Get<VMStatusBar>().Transparente();
		}
		public void CambiarColor()
		{
			DependencyService.Get<VMStatusBar>().CambiarColor();
		}
		public ICommand OcultarCommand => new Command(Ocultar);
		public ICommand MostrarCommand => new Command(Mostrar);
		public ICommand TranslucidoCommand => new Command(Translucido);
		public ICommand TransparenteCommand => new Command(Transparente);
		public ICommand CambiarColorCommand => new Command(CambiarColor);
	}
}
