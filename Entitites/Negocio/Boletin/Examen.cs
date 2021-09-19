using Entitites.Negocio.Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Examen : EntityBase
    {
        public override int Id { get; set; }

        public Alumno persona { get; set; }
        public Materia materia { get; set; }
        public DateTime fecha { get; set; }
        public int nota { get; set; }
        public Examen()
        {
           
        }
        public Examen( Alumno _alumno, Materia _materia)
        {
            persona  = _alumno;
            materia = _materia;
        }
    }
}
