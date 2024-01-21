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
    public class MPPLocalidad : IABM<BELocalidad>
    {
        public bool Baja(BELocalidad Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BELocalidad Objeto)
        {
            throw new NotImplementedException();
        }

        public List<BELocalidad> TraerLista()
        {
           List<BELocalidad> listadoLocalidades = new List<BELocalidad>();

            var consulta = from loc in XElement.Load("localidades.xml").Elements("localidad")
                           select new BELocalidad
                           {
                               codigo = Convert.ToInt32(Convert.ToString(loc.Attribute("codigo").Value).Trim()),
                               nombreLocalidad = loc.Element("nombre").Value
                           };


            listadoLocalidades = consulta.ToList();
            return listadoLocalidades;
        }
    }
}
