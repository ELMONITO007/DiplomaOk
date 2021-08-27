using Entitites.Negocio.Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entities
{
  public  class ObrasSocial : Documentacion
    {
 
        public bool tiene_Obra_Social { get; set; }
        public string obra_Social { get; set; }
        public string telefono_Emergencia { get; set; }
        public string numero_Socio { get; set; }

        public ObrasSocial(Persona _persona)
        {
            persona = _persona;

        }
   
        public ObrasSocial()
        {
        }
    }
}
