using Entitites.Negocio.Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Familia : Documentacion
    {
       
        public bool Padres_Separados { get; set; }
        public bool Hermanos { get; set; }
        public bool Vive_Abuela { get; set; }
        public bool Tiene_Tios { get; set; }
        public bool Papa_Trabajo { get; set; }
        public bool Mama_Trabajo { get; set; }
        public Familia(Persona _persona)
        {
            persona = _persona;

        }

        public Familia()
        {
        }

    }
}
