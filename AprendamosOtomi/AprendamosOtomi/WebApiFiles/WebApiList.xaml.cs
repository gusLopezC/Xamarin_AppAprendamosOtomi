
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AprendamosOtomi.WebApiFiles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WebApiList : ContentPage
    {
        public String _id = "";
        public String espaniol = "";
        public String otomi = "";
        public int __v = 0;
        public WebApiList()
        {
            InitializeComponent();
            LoadList();


        }
        public void LoadList()
        {
           
            HttpWebRequest request = WebRequest.Create(RestService.Servidor + RestService.Methods.TraductorMethod ) as HttpWebRequest;
            request.Method = RestService.HTTPMethods.Get;
            request.ContentType = RestService.ContentType;
            string resp;
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            //-----------
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                resp = reader.ReadToEnd();
                Model obj = JsonConvert.DeserializeObject<Model>(resp);
                WebApi.ItemsSource = obj.mostrandoTraducciones;    
            }
        }
    }
}