using ABSTRAC;
using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace MPP
{
    public class MPPJuego : IABM<BEJuego>
    {
        public bool Baja(BEJuego Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BEJuego juego)
        {
            List<BEJuego> listadoJuego = this.TraerLista();
            XDocument documento = XDocument.Load("juegos.XML");
            bool existe = listadoJuego.Exists(e => e.codigo == juego.codigo);

            try
            {
                if (existe == true)
                {
                    var jueg = from ju in documento.Descendants("juego")
                               where ju.Attribute("nombre").Value == (juego.nombre).ToString()
                               select ju;

                    foreach (XElement j in jueg)
                    {
                        j.Element("cantidadPartidas").Value = juego.canitdadPartidas.ToString();

                    }

                    documento.Save("juegos.XML");
                    return true;

                }else { return false; }
            }
            catch (XmlException ex)
            {
                throw new XmlException(ex.Message);
                return false;
            }
        }
        public List<BEJuego> TraerLista()
        {
            List<BEJuego> listadoJuegos;




            var consulta = from ju in XElement.Load("juegos.xml").Elements("juego")
                           select new BEJuego
                           {
                               nombre = Convert.ToString(ju.Attribute("nombre").Value).Trim(),
                               codigo = Convert.ToInt32(ju.Element("codigo").Value.Trim()),
                               canitdadPartidas = Convert.ToInt32(ju.Element("cantidadPartidas").Value.Trim().ToString())
                            


                           };


            listadoJuegos = consulta.ToList();
            return listadoJuegos;
        }
    }
}
