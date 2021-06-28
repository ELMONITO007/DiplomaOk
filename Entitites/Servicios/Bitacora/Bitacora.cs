using Entities.Usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Bitacora : EntityBase
    {

        public override int Id { get; set; }

        public EventoBitacora eventoBitacora { get; set; }

        public string fecha { get; set; }
        public string hora { get; set; }
        public Usuarios usuarios { get; set; }


        public Bitacora()
        {
           
        }


        public Bitacora(Usuarios _usuarios, EventoBitacora _eventoBitacora)
        {

            usuarios = _usuarios;
            eventoBitacora = _eventoBitacora;
        }


    }
}
