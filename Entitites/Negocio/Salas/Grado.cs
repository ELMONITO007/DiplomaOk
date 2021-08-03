using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitites.Negocio.Salas
{
  public  class Grado :Entities.EntityBase
    {
        public override int Id { get; set; }
        
        public string nombre { get; set; }
        public int año { get; set; }
    }
}
