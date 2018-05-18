using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using AprendamosOtomi.Views;
using AprendamosOtomi.WebApiFiles;

namespace AprendamosOtomi
{
	public partial class MainPage : ContentPage
	{
        List<string> Lista = new List<string>();
        public MainPage()
		{
			InitializeComponent();
            btnComida.Clicked += clic_Comida;
            btnFamilia.Clicked += clic_Familia;
            btnCuerpo.Clicked += clic_Cuerpo;
            btnVestimenta.Clicked += clic_Vestimenta;
            btnAnimales.Clicked += clic_Animales;
            btnColores.Clicked += clic_Colores;
            btnSaludos.Clicked += clic_Saludos;
            btnTradicciones.Clicked += clic_Tradicciones;
            btnTraductor.Clicked += clic_Traductor;
        }

        public void clic_Traductor(object sender, EventArgs e)
        {
            Navigation.PushAsync(new WebApiList());
        }

        public void clic_Tradicciones(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ViewCarousel());
        }

        public void clic_Saludos(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ViewCarousel());
        }

        private void clic_Colores(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ViewCarousel());
        }

        public void clic_Vestimenta(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ViewCarousel());
        }

        public void clic_Animales(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ViewCarousel());
        }

        public void clic_Familia(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ViewCarousel());
        }

        public void clic_Comida(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ViewCarousel());
        }
        public void clic_Cuerpo(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ViewCarousel());
        }
    }
}
