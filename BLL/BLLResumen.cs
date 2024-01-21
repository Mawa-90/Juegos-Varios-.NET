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
    public class BLLResumen : IABM<BEResumen>
    {
        MPPResumen oMPPResumen = new MPPResumen();

        public bool Baja(BEResumen Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BEResumen resumen)
        {
            resumen.codigo = CalcularUltimo();

            return oMPPResumen.Guardar(resumen);
        }

        public List<BEResumen> TraerLista()
        {
            return oMPPResumen.TraerLista();
        }


        public int CalcularUltimo()
        {
            List<BEResumen> list = oMPPResumen.TraerLista();
            BEResumen ultimo=list.Last();

            return ultimo.codigo + 1;

        }
    }
}
