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
            btnTraduce.Clicked += clic_Traductor;
           
        }

        private void clic_Traductor(object sender, EventArgs e)
        {
            var texto = EntryTraductor.Text;
            ResultTraductor.Text = texto;
        }
    }
}