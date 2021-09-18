using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Materia : EntityBase
    {
        public override int Id { get; set; }
        public Especialidad especialidad { get; set; }
        public string materia { get; set; }

        public Materia()
        {
          

        }
        public Materia(Especialidad _especialidad)
        {
            especialidad =_especialidad;

        }
    }
}
