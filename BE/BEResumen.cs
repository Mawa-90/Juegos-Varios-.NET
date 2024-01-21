using ABSTRAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEResumen : IEntidad
    {
        public int codigo { get ; set ; }
        public int codigoJuego { get ; set ; }
        public int cadigoJugador { get ; set ; }
        public string resultado { get ; set ; }

    }
}
