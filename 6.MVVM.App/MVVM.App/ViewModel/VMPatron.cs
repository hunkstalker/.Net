using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM.App.ViewModel
{
	internal class VMPatron : BaseViewModel
	{
		#region VARIABLES
		string _Text;
		#endregion

		#region CONSTRUCTOR
		public VMPatron(INavigation navigation)
		{
			Navigation = navigation;
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
		public async Task AsyncProcess()
		{

		}
		public void SimpleProcess()
		{

		}
		#endregion

		#region COMANDOS
		public ICommand AsyncProcessCommand => new Command(async () => await AsyncProcess());
		public ICommand SimpleProcessCommand => new Command(SimpleProcess);
		#endregion
	}
}
