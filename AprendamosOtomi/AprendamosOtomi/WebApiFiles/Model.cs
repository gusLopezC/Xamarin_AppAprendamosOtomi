using System;
using System.Collections.Generic;
using System.Text;

namespace AprendamosOtomi.WebApiFiles
{
    public class  Model
    {
        public List<MostrandoTraducciones> mostrandoTraducciones { get; set; }

    }

    public class MostrandoTraducciones
    {
        public string _id { get; set; }
        public int __v { get; set; }
        public string espaniol { get; set; }
        public string otomi { get; set; }

        public override string ToString()
        {
            return string.Format("{0}  :  {1}", espaniol, otomi);
        }

    }


}
