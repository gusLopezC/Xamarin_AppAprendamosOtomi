using Plugin.Connectivity;
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
        private int _position;
        public int Position { get { return _position; } set { _position = value; OnPropertyChanged(); } }
        public ViewCarousel(List<string> Lista)
        {
            InitializeComponent();
            var isConnect = CrossConnectivity.Current.IsConnected;

            if (isConnect)
            {
                MainCorouseView.ItemsSource = Lista;
            }
            else
            {
                var imagenerror = new List<string>{"nointernet"};
                MainCorouseView.ItemsSource = imagenerror;
            }
        }
    }
}