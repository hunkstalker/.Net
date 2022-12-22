using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestAppXamarin.View
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        double N1;
        double N2;
        double Resultado;
        private void BtnCasa_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrimeraPagina());
        }

        private void BtnHola_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Atención", "Hola", "OK");
        }

        private void BtnCalcular_Clicked(object sender, EventArgs e)
        {
            Calcular();
        }

        private void Calcular()
        {
            if(!string.IsNullOrEmpty(txtNumero1.Text))
            {
                if (!string.IsNullOrEmpty(txtNumero2.Text))
                {
                    N1 = Convert.ToDouble(txtNumero1.Text);
                    N2 = Convert.ToDouble(txtNumero2.Text);
                    Resultado = N1 * N2;
                    DisplayAlert("Resultado", Resultado.ToString(), "OK");
                }
                else
                {
                    DisplayAlert("Error", "Ingresa algún valor en el campo del Número 2", "OK");
                }
            }
            else
            {
                DisplayAlert("Error", "Ingresa algún valor en el campo del Número 1", "OK");
            }
        }
    }
}
