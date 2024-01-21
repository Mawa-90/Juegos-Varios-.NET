using ABSTRAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BELocalidad : IEntidad
    {
        public int codigo { get ; set ; }
        public string nombreLocalidad { get; set; }


        public override string ToString()
        {
            return nombreLocalidad;
        }
    }
}
