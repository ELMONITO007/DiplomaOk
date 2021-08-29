using Entities;
using Entitites.Negocio.Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitites
{
    public class Maestro : Persona
    {
        public List<Especialidad> especialidades { get; set; }
        public Maestro() { }
        public Maestro(List<Especialidad> _especialidades)

        {

            especialidades = _especialidades;


        }
    }
}
