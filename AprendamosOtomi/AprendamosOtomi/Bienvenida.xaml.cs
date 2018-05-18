using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AprendamosOtomi
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Bienvenida : ContentPage
	{
		public Bienvenida ()
		{
			InitializeComponent ();
            btnEntrar.Clicked += BtnEntrar_Click;
        }
        void BtnEntrar_Click(object sender, EventArgs e)
        {
            Navigation.PopAsync();

            Navigation.PushAsync(new MainPage());
        }
    }
}