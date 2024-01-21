using ABSTRAC;
using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPP;

namespace BLL
{
    public class BLLLocalidad : IABM<BELocalidad>
    {
        MPPLocalidad oMPPLoc = new MPPLocalidad();
        public bool Baja(BELocalidad Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BELocalidad Objeto)
        {
            throw new NotImplementedException();
        }

        public List<BELocalidad> TraerLista()
        {
            return oMPPLoc.TraerLista();
        }
    }
}
