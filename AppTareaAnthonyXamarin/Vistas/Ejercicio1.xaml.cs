using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTareaAnthonyXamarin.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ejercicio1 : ContentPage
    {
        double total, ventaprecio;
        double cant; 

        public Ejercicio1()
        {
            InitializeComponent();
        }
        private void Calcular()
        {
            ventaprecio = Convert.ToDouble(Precio.Text);
            cant = Convert.ToDouble(cantidad.Text);
            double subtotal = ventaprecio * cant;
            total += subtotal;
            lbltotalpagar.Text = total.ToString(); 
        }
        private void validar()
        {
            if (!string.IsNullOrEmpty(Precio.Text))
            {
                Calcular();
            }
            else
            {
                DisplayAlert("Error", "ingrese una cantidad", "OK");
            }
        }

        private async void irPago_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pago(total));
        }

        private void calcularTotal_Clicked(object sender, EventArgs e)
        {
            validar(); 
        }
    }
}