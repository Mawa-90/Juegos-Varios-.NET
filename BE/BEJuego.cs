using ABSTRAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEJuego : IEntidad
    {
        public int codigo { get ; set ; }

        public string nombre { get; set; }

        public int canitdadPartidas { get; set; }

    }
}
