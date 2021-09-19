using Entitites;
using Entitites.Negocio.Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Comunicado : EntityBase
    {
        public override int Id { get; set; }
        public Alumno persona { get; set; }
        public Maestro maestro { get; set; }
        public DateTime fecha { get; set; }
        public bool visto { get; set; }
        public string comunicado { get; set; }

        public Comunicado()
        {
         
        }

        public Comunicado(Maestro _maestro, Alumno _alumno)
        {
            maestro = _maestro;
            persona = _alumno;
        }
    }
}
