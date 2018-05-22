using COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Interfeces
{
    public interface ITraductorManager :IGenericManager<Model>
    {
        List<Model> Model(String __id);
    }
}
