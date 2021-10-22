using Entities;
using Entitites.Negocio.Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entities
{
    public class Documento : Documentacion
    {

        public string tipo_Documentancion { get; set; }
        public string NombreDocumento { get; set; }
 

        public Documento(Persona _persona)
        {
            persona = _persona;

        }
        public Documento(Persona _persona, OpenFileDialog _openFileDialog)
        {
            persona = _persona;
            openFileDialog = _openFileDialog;
        }
        public Documento() { }

       

    }
}
