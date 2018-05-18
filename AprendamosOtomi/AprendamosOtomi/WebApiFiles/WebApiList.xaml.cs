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
        List<string> Lista = new List<string>();
        public WebApiList()
        {
            InitializeComponent();
            LoadList();
            WebApi.ItemsSource = Lista; 


        }
        public void LoadList()
        {
            var traduccion = new MetodoTraducir { TipoAccion = "Traductor" };
            var json = JsonConvert.SerializeObject(traduccion);
            HttpWebRequest request = WebRequest.Create(RestService.Servidor + RestService.Methods.TraductorMethod + "?id=0&data=" + json) as HttpWebRequest;
            request.Method = RestService.HTTPMethods.Get;
            request.ContentType = RestService.ContentType;
            string resp;
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            //-----------
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                resp = reader.ReadToEnd();
                var obj = JsonConvert.DeserializeObject<object>(resp);
                string data = (string)obj;
                JObject json2 = JObject.Parse(data);
                var respuesta_data = json2;
                string Response = respuesta_data.GetValue("Response").ToString();
                if (Response == "SUCCESS")
                {
                    var ListaFlujosJS = respuesta_data.GetValue("Objeto").ToString();
                    try
                    {
                        var objResponse1 = JsonConvert.DeserializeObject<Model>(ListaFlujosJS);

                        _id = objResponse1._id;
                        Lista.Add(_id.ToString());
                        espaniol = objResponse1.espaniol;
                        Lista.Add(espaniol.ToString());
                        otomi = objResponse1.otomi;
                        Lista.Add(otomi.ToString());
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }
                }
            }
        }
    }
}