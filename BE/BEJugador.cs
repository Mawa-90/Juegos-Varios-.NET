using ABSTRAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BE
{
    public class BEJugador : IEntidad
    {

       public int codigo { set; get; }
       public string nombre { set; get; }
       public string apellido { set; get; }
       public int DNI { set; get; }
       public string mail { set; get; }    
       public DateTime fechaNacimiento { set; get; }
       public string localidad { set; get; }
       public int puntajeAcumulado { set; get; }
       public int edad { set; get ; } //ultimo check de jugadores


        public BEJugador()
        {
            puntajeAcumulado = 0;
        }

        public int CalculoEdad(BEJugador jugador)
        {
          int años =  (DateTime.Now.Year - jugador.fechaNacimiento.Year) - 1;

            if (jugador.fechaNacimiento.Month >= DateTime.Now.Month && jugador.fechaNacimiento.Day >= DateTime.Now.Day)
            {

                años = años + 1;
            }

            return años;
        }

        public override string ToString()
        {
            return  nombre +" "+ apellido ;
        }



    }
}
