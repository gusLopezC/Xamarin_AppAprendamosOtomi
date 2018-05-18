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
	public partial class ViewCarousel : ContentPage
	{
		public ViewCarousel ()
		{
			InitializeComponent ();
            var imagenes = new List<string>
            {
                "ViewAve","ViewGato","ViewPerro","ViewRana"

            };

            MainCorouseView.ItemsSource = imagenes;
        }
	}
}