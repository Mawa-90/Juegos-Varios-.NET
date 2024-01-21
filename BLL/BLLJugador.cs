using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPP;
using BE;
using ABSTRAC;

namespace BLL
{
    public class BLLJugador : IABM<BEJugador>
    {
        MPPJugador oMPPJugador = new MPPJugador();
        public List<BEJugador> TraerLista()
        {
            return oMPPJugador.TraerLista();
        }
        public bool Baja(BEJugador jugador)
        {
            return oMPPJugador.Baja(jugador);
        }

        public bool Guardar(BEJugador jugador)
        {
            return oMPPJugador.Guardar(jugador);
        }

        bool CheckExistenciaJugador(BEJugador j)
        {
            List<BEJugador> listadoExistentes = oMPPJugador.TraerLista();
            return listadoExistentes.Exists(e => e.DNI == j.DNI);

        }

        public bool CargarPuntos(int puntaje, BEJugador jugador)
        {
            return oMPPJugador.CargarPuntos(puntaje, jugador);
        }
    }
}
