using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;

namespace XamarinCmps.App.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AlertaPopupCustom : PopupPage
	{
		public AlertaPopupCustom()
		{
			InitializeComponent();
		}

		private void BtnAlertaCustom_Clicked(object sender, EventArgs e)
		{
			PopupNavigation.Instance.PopAsync();
        }
    }
}