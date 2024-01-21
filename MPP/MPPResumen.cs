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
    public class MPPResumen : IABM<BEResumen>
    {
        public bool Baja(BEResumen resumen)
        {
            try
            {
                XDocument documento = XDocument.Load("partidasGPE.xml");

                var consulta = from resu in documento.Descendants("resumen")
                               where Convert.ToInt32(resu.Attribute("numero").Value) == resumen.codigo
                               select resu;

                consulta.Remove();
                documento.Save("partidasGPE.xml");
                return true;

            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public bool Guardar(BEResumen resumen)
        {
            try
            {
                XDocument documento = XDocument.Load("partidasGPE.XML");

                documento.Element("historial").Add(new XElement("resumen",
                                                    new XAttribute("numero", Convert.ToString(resumen.codigo)),
                                                    new XElement("juegoCodigo", resumen.codigoJuego),
                                                    new XElement("jugadorCodigo", resumen.cadigoJugador),
                                                    new XElement("resultado", resumen.resultado)));


                documento.Save("partidasGPE.XML");
                return true;

            }
            catch (XmlException ex)
            {
                throw new XmlException("Error de Carga");

                return false;
            }

        }

        public List<BEResumen> TraerLista()
        {
            List<BEResumen> listadoResumen;

            var consulta = from re in XElement.Load("partidasGPE.xml").Elements("resumen")
                           select new BEResumen
                           {
                               codigo = Convert.ToInt32(Convert.ToString(re.Attribute("numero").Value).Trim()),
                               cadigoJugador = Convert.ToInt32(re.Element("jugadorCodigo").Value.Trim().ToString()),
                               codigoJuego = Convert.ToInt32(re.Element("juegoCodigo").Value.Trim().ToString()),
                               resultado = (re.Element("resultado").Value.Trim()),
                             

                           };


            listadoResumen = consulta.ToList();
            return listadoResumen;
        }
    }
}
