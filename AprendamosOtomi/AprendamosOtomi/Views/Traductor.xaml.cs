using Plugin.Connectivity;
using AprendamosOtomi.WebApiFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AprendamosOtomi.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Traductor : ContentPage
	{
		public Traductor ()
		{
			InitializeComponent ();
            
            btnDiccionario.Clicked += clic_diccionario;
            btnTraduce.Clicked += clic_Traductor;
            btnCredits.Clicked += clic_Creditos;
        }
        public void clic_diccionario(object sender, EventArgs e)
        {
            /*
             *Verifica la conexion y se manda  a la vista en caso de excepcion
             */
            var isConnect = CrossConnectivity.Current.IsConnected;
            if (isConnect)
            {
                try
                {
                    Navigation.PushAsync(new WebApiList());
                }
                catch (Exception)
                {
                    Navigation.PushAsync(new MainPage());
                }

            }
            else
            {
                Navigation.PushAsync(new MainPage());
            }
        }
        public void clic_Traductor(object sender, EventArgs e)
        {
            /*
             *Verifica la conexion y se manda a la vista con el parametro de la entrada de la pabaraa traducir
             */
            var isConnect = CrossConnectivity.Current.IsConnected;
            if (isConnect)
            {
                try
                {
                    var restraducion = new BIZ.TraductorManager();
                    String palabra = EntryTraductor.Text.ToLower().Trim();
                    var texto = restraducion.Traductor(palabra);
                    ResultTraductor.Text = texto;
                }
                catch(Exception )
                {
                    Navigation.PushAsync(new MainPage());
                }
                
            }
            else
            {
                ResultTraductor.Text = "No hay conexion reintenta";
            }

        }  
        public void clic_Creditos(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Creditos());
        }
    }
}