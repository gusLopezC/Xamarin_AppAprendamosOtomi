using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace AprendamosOtomi
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            var navigationPage = new NavigationPage(new Bienvenida());
            navigationPage.BarBackgroundColor = Color.FromHex("#FF4081");
            MainPage = navigationPage;
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
