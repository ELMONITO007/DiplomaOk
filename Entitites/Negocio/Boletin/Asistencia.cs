using Entitites.Negocio.Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Asistencia : EntityBase
    {
        public override int Id { get; set; }
        public int dia { get; set; }
        public int mes { get; set; }
        public int año { get; set; }
        public bool asistio { get; set; }
        public Alumno persona { get; set; }
        public Asistencia()
        {
          

        }
        public Asistencia(Alumno _alumno)
        {
            persona = _alumno;

        }
    }
}
