using Entitites.Negocio.Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entities
{
   public class Casa :Documentacion
    {
   

        public bool Vive_Casa { get; set; }
        public bool Vive_Departamento { get; set; }
        public bool Vive_Barrio_Cerrado { get; set; }
        public bool Tiene_Habitacion_Propia { get; set; }
        public bool Tiene_Patio { get; set; }

        public Casa(Persona _persona)
        {
            persona = _persona;

        }
    
        public Casa()
        {
        }

    }
}
