using ABSTRAC;
using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MPP
{
    public class MPPResumenReporte : IABM<BEResumenReporte>
    {
        public bool Baja(BEResumenReporte Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BEResumenReporte Objeto)
        {
            throw new NotImplementedException();
        }

        MPPJuego oMPPJuego = new MPPJuego();
        MPPJugador oMPPJugador = new MPPJugador();

        public List<BEResumenReporte> TraerLista()
        {
            List<BEResumenReporte> listadoResumenReporte = new List<BEResumenReporte>();
            List<BEJuego> listadoJuegos = oMPPJuego.TraerLista();
            List<BEJugador> listadoJugador = oMPPJugador.TraerLista();
            
            var consulta = from re in XElement.Load("partidasGPE.xml").Elements("resumen")
                           select new BEResumenReporte
                           {
                               codigo = Convert.ToInt32(Convert.ToString(re.Attribute("numero").Value).Trim()),
                               cadigoJugador = Convert.ToInt32(re.Element("jugadorCodigo").Value.Trim().ToString()),
                               codigoJuego = Convert.ToInt32(re.Element("juegoCodigo").Value.Trim().ToString()),
                               resultado = (re.Element("resultado").Value.Trim()),
                                                                                          
                              
                           };

            foreach(var cons in consulta)
            {
                BEJuego juego = ((from x in listadoJuegos where x.codigo == cons.codigoJuego select x).First());
                cons.nombreJuego = juego.nombre;
                BEJugador jugador = ((from x in listadoJugador where x.codigo == cons.cadigoJugador select x).First());
                cons.nombreJugador = jugador.nombre;

                listadoResumenReporte.Add(cons);
            }

            return listadoResumenReporte;


        }
    }
}
