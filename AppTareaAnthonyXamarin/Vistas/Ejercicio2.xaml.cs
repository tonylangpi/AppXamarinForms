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
    public partial class Ejercicio2 : ContentPage
    {
        double sueldo;
        double prestamo;
        int tiempoTrabajo;
        public Ejercicio2()
        {
            InitializeComponent();
        }
        private void ValidarSalario()
        {
            sueldo = Convert.ToDouble(Salario.Text);
            tiempoTrabajo =  Convert.ToInt32(tiempo.Text);
            if (tiempoTrabajo == 1)
            {
                DisplayAlert("Respuesta", "Al empleado se le puede prestar Q. " + sueldo, "OK");
            }else if(tiempoTrabajo == 2 || tiempoTrabajo == 3)
            {
                prestamo = sueldo * 2; 
                DisplayAlert("Respuesta", "Al empleado se le puede prestar Q. " + prestamo, "OK");
            }else if(tiempoTrabajo >= 4 && tiempoTrabajo <= 8)
            {
                prestamo = sueldo * 4;
                DisplayAlert("Respuesta", "Al empleado se le puede prestar Q. " + prestamo, "OK");
            }else if(tiempoTrabajo >= 10)
            {
                prestamo = sueldo * 5;
                DisplayAlert("Respuesta", "Al empleado se le puede prestar Q. " + prestamo, "OK");
            }
            else
            {
                DisplayAlert("Respuesta", "NO APLICA", "OK");
            }
        }
        private void validar()
        {
            if (!string.IsNullOrEmpty(Salario.Text) || !string.IsNullOrEmpty(tiempo.Text))
            {
                ValidarSalario();
            }
            else
            {
                DisplayAlert("Error", "ingrese el salario y el tiempo para determinar el prestamo", "OK");
            }
        }
        private void verificarmonto_Clicked(object sender, EventArgs e)
        {
            validar();
        }
    }
}