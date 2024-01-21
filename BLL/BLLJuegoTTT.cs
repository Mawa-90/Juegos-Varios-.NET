using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLJuegoTTT : BLLJuego
    {

        public override int CalcularPuntos(List<BEResumen> listaResultados, BEJugador jugador)
        {
            int puntaje = 0;
            int resulGanado = (from x in listaResultados where (x.resultado == "ganado" && x.cadigoJugador == jugador.codigo) select x).Count();
            int resulEmpatado = (from x in listaResultados where (x.resultado == "empatado" && x.cadigoJugador == jugador.codigo) select x).Count();
            puntaje = ((resulGanado * 5) + (resulEmpatado * 1));


            if (resulGanado > 2 && resulGanado <= 4)
            {

                puntaje += 10; 

            }
            else if (resulGanado >= 5)
            {

                puntaje += 20;

            }



            return puntaje;



            
        }

    }
}
