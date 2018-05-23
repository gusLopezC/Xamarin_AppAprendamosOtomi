using COMMON.Entidades;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public partial class GenericRepository
    {
        public String _id = "";
        public String espaniol = "";
        public String otomi = "";
        public int __v = 0;
      

        public GenericRepository()
        {
           LoadList();
        }

        public Model LoadList()
        {
            HttpWebRequest request = WebRequest.Create(RestService.Servidor + RestService.Methods.TraductorMethod) as HttpWebRequest;
            request.Method = RestService.HTTPMethods.Get;
            request.ContentType = RestService.ContentType;
            string resp;
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            //-----------
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                resp = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<Model>(resp);  
            }
        }
    }
}
