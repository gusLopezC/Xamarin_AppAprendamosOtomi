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
        /// <summary>
        /// Este metodo recibe la conexion  de la capa DAL recibe palabraOrgin de la view  analiza en la operacion landa
        /// y al encontrar coincidencia  returna el segundo valor del json del item otomi
        /// </summary>
        /// <param name="palabraOrigen"></param>
        /// <returns></returns>
        public string Traductor(string palabraOrigen)
        {
            /*
             * Se crea un objeto de conexion y se busca en la base de datos coincidencia con el parametro y el dato y
             * devuelve la palabra traducida
             */
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

