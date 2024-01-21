using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLJuegoPPT : BLLJuego
    {

        public override int CalcularPuntos(List<BEResumen> listaResultados, BEJugador jugador)
        {

            int puntaje = 0;
            int resulGanado = (from x in listaResultados where ( x.resultado == "ganado" && x.cadigoJugador  == jugador.codigo) select x).Count();
            int resulEmpatado = (from x in listaResultados where (x.resultado == "empatado" && x.cadigoJugador == jugador.codigo) select x).Count();
            puntaje = ((resulGanado*3)+(resulEmpatado*1));
           
            
            if(resulGanado > 3 && resulGanado < 6){
              
                puntaje += 5;

            }else if(resulGanado > 5)
            {

                puntaje += 10;

            }
            
            
            
            return puntaje;
        }



    }
}
