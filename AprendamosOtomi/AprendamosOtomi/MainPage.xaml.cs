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
        public List<string> ListaVestimenta = new List<string>(){"https://preview.ibb.co/koHxMT/Vcamisa.png","https://preview.ibb.co/eoZcMT/Vfalda.png","https://preview.ibb.co/fb5TT8/Vsapare.png","https://preview.ibb.co/djH8T8/Vsueter.png"};
        public List<string> ListaFamilia = new List<string>() { "https://preview.ibb.co/dAtOT8/Vabuela.png","https://preview.ibb.co/i0T7o8/Vabuelo.png","https://preview.ibb.co/iH4xo8/Vbebe.png","https://preview.ibb.co/dOEK1T/Vgemalas.png","https://preview.ibb.co/jz2Tvo/Vmadre.png","https://preview.ibb.co/ft3CMT/Vnieto.png","https://preview.ibb.co/jGiwgT/Vnina.png","https://preview.ibb.co/gWW5ao/Vnino.png","https://preview.ibb.co/cgndvo/Vpadre.png"};
        public List<string> ListaAnimales = new List<string>() { "https://preview.ibb.co/ej9SMT/Vardilla.png", "https://preview.ibb.co/fEuivo/Vconejo.png", "https://preview.ibb.co/ertho8/Vgallina.png", "https://preview.ibb.co/c106Fo/Vgato.png", "https://preview.ibb.co/mp6k88/Vmariposa.png", "https://preview.ibb.co/hzmJT8/Vobeja.png", "https://preview.ibb.co/jS4SMT/Vpajaro.png", "https://preview.ibb.co/g0fTT8/Vpato.png", "https://preview.ibb.co/fWR2o8/Vperro.png", "https://preview.ibb.co/gKtF88/Vpuerco.png", "https://preview.ibb.co/hM29ko/Vrana.png", "https://preview.ibb.co/hap0rT/Vraton.png", "https://preview.ibb.co/gDSaQo/Vserpiente.png", "https://preview.ibb.co/eRGVrT/Vvaca.png" };
        public List<string> ListaComida = new List<string>() { "https://preview.ibb.co/cONyd8/Vaguacate.png", "https://preview.ibb.co/bC9pko/Varbol.png", "https://preview.ibb.co/j5v1y8/Vchile.png", "https://preview.ibb.co/kBaqrT/Vjitomate.png", "https://preview.ibb.co/kmGVrT/Vlimon.png", "https://preview.ibb.co/gGsyd8/Vmaiz.png", "https://preview.ibb.co/hGCLrT/Vnopal.png" };
        public List<string> Lista = new List<string>();
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
            Navigation.PushAsync(new ViewCarousel(Lista));
        }

        public void clic_Saludos(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ViewCarousel(Lista));
        }

        private void clic_Colores(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ViewCarousel(Lista));
        }

        public void clic_Vestimenta(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ViewCarousel(ListaVestimenta));
        }

        public void clic_Animales(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ViewCarousel(ListaAnimales));
        }

        public void clic_Familia(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ViewCarousel(ListaFamilia));
        }

        public void clic_Comida(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ViewCarousel(ListaComida));
        }
        public void clic_Cuerpo(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ViewCarousel(Lista));
        }
    }
}
