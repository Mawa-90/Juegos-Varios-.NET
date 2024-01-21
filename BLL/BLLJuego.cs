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
    public class BLLJuego : IABM<BEJuego>
    {

        MPPJuego oMPPJuego = new MPPJuego();

        public bool Baja(BEJuego Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BEJuego juego)
        {
            return oMPPJuego.Guardar(juego);
        }

        public List<BEJuego> TraerLista()
        {
            return oMPPJuego.TraerLista();
        }


        public virtual int CalcularPuntos(List<BEResumen> listaResultados, BEJugador jugador)
        {
            return 0;
        }


    }
}
