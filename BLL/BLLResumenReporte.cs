using ABSTRAC;
using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLResumenReporte : IABM<BEResumenReporte>
    {
        MPPResumenReporte oMPPResumenReporte = new MPPResumenReporte();
        public bool Baja(BEResumenReporte Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BEResumenReporte Objeto)
        {
            throw new NotImplementedException();
        }

        public List<BEResumenReporte> TraerLista()
        {
            return oMPPResumenReporte.TraerLista();
        }
    }



}
