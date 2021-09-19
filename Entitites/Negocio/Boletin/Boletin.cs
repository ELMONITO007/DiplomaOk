using Entitites.Negocio.Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Boletin : EntityBase
    {
        public override int Id { get; set; }
        public Alumno persona { get; set; }
        public int año { get; set; }
        public int cutrimeste { get; set; }
        public string notas { get; set; }

        public Boletin()
        {

            persona = new Alumno();
        }
        public Boletin(Alumno alumno)
        {

            persona = alumno;
        }
    }
}
}
