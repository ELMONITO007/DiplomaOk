using Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class MaestroHorario : EntityBase
    {
        public override int Id { get; set; }
        public Maestro persona { get; set; }
        public int diaSemana { get; set; }
        public string turno { get; set; }
        public int hora { get; set; }
        public int año { get; set; }
        public bool disponible { get; set; }
        public MaestroHorario()
        {
           
        }
        public MaestroHorario(Maestro _persona)
        {
            persona = _persona;
        }
    }
}
