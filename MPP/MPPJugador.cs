using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using ABSTRAC;
using BE;

namespace MPP
{
    public class MPPJugador : IABM<BEJugador>
    {
        public bool Baja(BEJugador jugador)
        {
            try
            {
                XDocument documento = XDocument.Load("jugadores.XML");

                var consulta = from jug in documento.Descendants("jugador")
                               where Convert.ToInt32(jug.Attribute("codigo").Value) == jugador.codigo
                               select jug;

                consulta.Remove();
                documento.Save("jugadores.XML");
                return true;

            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public bool Guardar(BEJugador jugador)
        {
            List<BEJugador> listadoJugadores = this.TraerLista();
            XDocument documento = XDocument.Load("jugadores.XML");
            bool existe = listadoJugadores.Exists(e => e.codigo == jugador.codigo);

            try
            {
                if(existe == true)
                {
                    var jug = from ju in documento.Descendants("jugador")
                                    where ju.Attribute("codigo").Value == (jugador.codigo).ToString()
                                    select ju;

                    foreach (XElement j in jug)
                    {
                        j.Element("nombre").Value = jugador.nombre;
                        j.Element("apellido").Value = jugador.apellido;
                        j.Element("dni").Value = jugador.DNI.ToString();
                        j.Element("mail").Value = jugador.mail;
                        j.Element("fechaNacimiento").Value = jugador.fechaNacimiento.ToShortDateString();
                        j.Element("puntaje").Value = jugador.puntajeAcumulado.ToString();

                    }

                    documento.Save("jugadores.XML");
                    return true;

                }else if(existe == false || jugador.codigo == 0)
                {
                    int cod = (listadoJugadores.Last()).codigo + 1;
                    jugador.codigo = cod;

                    documento.Element("jugadores").Add(new XElement("jugador",
                                                new XAttribute("codigo", Convert.ToString(jugador.codigo)),
                                                new XElement("nombre", jugador.nombre), 
                                                new XElement("apellido", jugador.apellido),
                                                new XElement("fechaNacimiento", Convert.ToString(jugador.fechaNacimiento.ToShortDateString())),
                                                new XElement("dni", jugador.DNI.ToString()),
                                                new XElement("localidad", jugador.localidad),
                                                new XElement("mail", jugador.mail),
                                                new XElement("puntaje", jugador.puntajeAcumulado.ToString())));


                    documento.Save("jugadores.XML");
                    return true;


                }
            }catch(XmlException ex)
            {
                throw new XmlException(ex.Message);

                return false;
            }

            return false;



        }

       

        public List<BEJugador> TraerLista()
        {
            List<BEJugador> jugadoresListado = new List<BEJugador>();




            var consulta = from jug in XElement.Load("jugadores.xml").Elements("jugador")
                           select new BEJugador
                           {
                               codigo = Convert.ToInt32(Convert.ToString(jug.Attribute("codigo").Value).Trim()),
                               fechaNacimiento = DateTime.Parse(Convert.ToString(jug.Element("fechaNacimiento").Value)), 
                               DNI = (Convert.ToInt32(jug.Element("dni").Value)),
                               nombre = Convert.ToString(jug.Element("nombre").Value.Trim()),
                               apellido = Convert.ToString(jug.Element("apellido").Value.Trim()),
                               localidad = Convert.ToString(jug.Element("localidad").Value.Trim()),
                               puntajeAcumulado = (Convert.ToInt32(jug.Element("puntaje").Value)),
                               mail = Convert.ToString(jug.Element("mail").Value.Trim())

                           };
            foreach (BEJugador ju in consulta)
            {
                ju.edad = ju.CalculoEdad(ju);

                jugadoresListado.Add(ju);
            }

           
            return jugadoresListado;

        }



        public bool CargarPuntos(int puntaje, BEJugador jugador)
        {
            List<BEJugador> listadoJugadores = this.TraerLista();
            XDocument documento = XDocument.Load("jugadores.XML");
            bool existe = listadoJugadores.Exists(e => e.DNI == jugador.DNI);


            try
            {
                if (existe == true)
                {
                    jugador.puntajeAcumulado += puntaje;

                    var jug = from ju in documento.Descendants("jugador")
                              where ju.Attribute("codigo").Value == (jugador.codigo).ToString()
                              select ju;

                    foreach (XElement j in jug)
                    {
                        j.Element("puntaje").Value = jugador.puntajeAcumulado.ToString();

                    }

                    documento.Save("jugadores.XML");
                    return true;
                }
                else return false;

            }
            catch (XmlException ex)
            {
                throw new XmlException(ex.Message);
                return false;
            }
        }   
    }
}
