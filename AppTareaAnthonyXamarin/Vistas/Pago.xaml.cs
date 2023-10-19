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
    public partial class Pago : ContentPage
    {
        double aCancelar;
        public Pago(double total)
        {
            InitializeComponent();
            aCancelar = total;
            lbltotal.Text = total.ToString();
        }
        private void Verificar()
        {
            double monto = Convert.ToDouble(montoPago.Text);
            double resto = monto - aCancelar;
            lblVuelto.Text = resto.ToString(); 
        }
        private void validar()
        {
            if (!string.IsNullOrEmpty(montoPago.Text))
            {
                Verificar();
            }
            else
            {
                DisplayAlert("Error", "ingrese un monto a cancelar", "OK");
            }
        }
        private void RestarMonto_Clicked(object sender, EventArgs e)
        {
            validar(); 
        }
    }
}