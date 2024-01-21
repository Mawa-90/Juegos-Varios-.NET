using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSTRAC
{
    public interface IABM <T> where T : IEntidad
    {
        bool Guardar(T Objeto);
        bool Baja(T Objeto);
        List<T> TraerLista();


    }
}
