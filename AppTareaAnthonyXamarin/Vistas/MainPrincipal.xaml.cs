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
    public partial class MainPrincipal : ContentPage
    {
        public MainPrincipal()
        {
            InitializeComponent();
        }

        private async void btniniciar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Ejercicio1());
        }

        private async void Ejercicio2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Ejercicio2());
        }
    }
}