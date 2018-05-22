using COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Interfeces
{
    public interface IGenericManager<T> where T:Model
    {
        T Agregar(T entidad);
        T Modificar(T entidad);
        bool Eliminar(string _id);
        List<T> ListarElementos { get; set; }
        T ObtenerElementoPorId(string _id);
    }
}
