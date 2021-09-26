using Entitites.Negocio.Salas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CursoHorario : EntityBase
    {
        public override int Id { get; set; }

        public Curso curso { get; set; }
        public MaestroHorario maestroHorario { get; set; }
        public List<MaestroHorario> maestroHorarioHorario { get; set; }

        public CursoHorario(Curso _curso,MaestroHorario _maestroHorario)
        {
            curso = _curso;
            maestroHorario = _maestroHorario;
          

        }
        public CursoHorario(Curso _curso, MaestroHorario _maestroHorario, List<MaestroHorario> _maestroHorarioHorario)
        {
            curso = _curso;
            maestroHorario = _maestroHorario;
            maestroHorarioHorario = _maestroHorarioHorario;

        }
        public CursoHorario()
        {

        }
    }
}
