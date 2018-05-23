using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ
{
    public class TraductorManager
    {

        public string Traductor(string palabraOrigen)
        {
            var repo = new DAL.GenericRepository();
            try
            {
                var palTrad = repo.LoadList().mostrandoTraducciones.Where(T => T.espaniol == palabraOrigen).SingleOrDefault();

                if (palTrad != null)
                {
                    return palTrad.otomi;
                }
                else
                {
                    return "No se encontro";
                }
            }
            catch(Exception e)
            {
               return  "IOException source: "+e;
            }
        }
    }


}

