using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitites.Negocio.Salas
{
    public  class Sala : Entities.EntityBase
    {
        public override int Id { get; set; }

        public int capacidad { get; set; }
        public bool tiempo { get; set; }
        public string nombre { get; set; }
        public string tipoSala  { get; set; }

        
 

    }
}
