using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitites.Negocio.Salas
{
  public  class SalaHorario : Entities.EntityBase
    {
        public override int Id { get; set; }
        public int diaSemana { get; set; }
        public string turno { get; set; }
        public int hora { get; set; }
        public int año { get; set; }
       

        public Sala sala
        {
            get => default;
            set
            {
            }
        }

        public SalaHorario(Sala _sala)
        {
            sala = _sala;
        }
    }
}
