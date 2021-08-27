using Entitites.Negocio.Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entities
{
    public class Alergias : Documentacion
    {
       
   

        public string Cuales_Alergias_Medicamentos { get; set; }
        public bool Alergia_Medicamentos { get; set; }
        public string Cuales_Alergias_Alimento { get; set; }
        public bool Alergia_Alimento { get; set; }
        public string Cuales_Alergias_Elementos { get; set; }
        public string Otras_Alergias { get; set; }

        public bool Alergia_Elementos { get; set; }
        public Alergias(Persona _persona)
        {
            persona = _persona;

        }
    
        public Alergias()
        {
        }
    }
}
