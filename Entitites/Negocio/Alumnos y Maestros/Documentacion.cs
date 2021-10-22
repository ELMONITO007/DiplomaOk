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
    public abstract class Documentacion : EntityBase
    {
        public override int Id { get; set; }
        public Persona persona { get; set; }
        public int año { get; set; }
        public OpenFileDialog openFileDialog = new OpenFileDialog();


        public Documentacion() { }

   
    }
}
