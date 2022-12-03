using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EjemploClase
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void BtnSuma_Clicked(object sender, EventArgs e)
        {
            var atributo = new Models.Atributos
            {
                N1 = Convert.ToInt32(TxtN1.Text),
                N2 = Convert.ToInt32(TxtN2.Text),
                Resultado = Convert.ToInt32(TxtN1.Text) + Convert.ToInt32(TxtN2.Text)
            };

            var resul = new Views.Resultado();
            resul.BindingContext = atributo;
            await Navigation.PushModalAsync(resul);
        }

        private async void BtnResta_Clicked(object sender, EventArgs e)
        {
            var atributo = new Models.Atributos
            {
                N1 = Convert.ToInt32(TxtN1.Text),
                N2 = Convert.ToInt32(TxtN2.Text),
                Resultado = Convert.ToInt32(TxtN1.Text) - Convert.ToInt32(TxtN2.Text)
            };

            var resul = new Views.Resultado();
            resul.BindingContext = atributo;
            await Navigation.PushModalAsync(resul);
        }

        private async void BtnMultiplicacion_Clicked(object sender, EventArgs e)
        {
            var atributo = new Models.Atributos
            {
                N1 = Convert.ToInt32(TxtN1.Text),
                N2 = Convert.ToInt32(TxtN2.Text),
                Resultado = Convert.ToInt32(TxtN1.Text) * Convert.ToInt32(TxtN2.Text)
            };

            var resul = new Views.Resultado();
            resul.BindingContext = atributo;
            await Navigation.PushModalAsync(resul);
        }

        private async void BtnDivision_Clicked(object sender, EventArgs e)
        {
            var atributo = new Models.Atributos
            {
                N1 = Convert.ToInt32(TxtN1.Text),
                N2 = Convert.ToInt32(TxtN2.Text),
                Resultado = Convert.ToInt32(TxtN1.Text) / Convert.ToInt32(TxtN2.Text)
            };

            var resul = new Views.Resultado();
            resul.BindingContext = atributo;
            await Navigation.PushModalAsync(resul);
        }
    }
}
