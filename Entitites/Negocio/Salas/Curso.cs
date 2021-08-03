using Entities;
using Entitites.Negocio.Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitites.Negocio.Salas
{
    public class Curso : EntityBase
    {
        public override int Id { get; set; }
        public string nombre { get; set; }
        public Grado grado { get => default; set { } }
        public Sala sala { get => default; set { } }

   
        public List<Alumno> listaALumno{ get; set; }
        public List<Maestro> listaMaestro { get; set; }
        public Maestro maestroPrincipal { get => default; set { } }


        public Curso(Sala _sala, Grado _grado, Maestro _MaestroPrincipal, List<Alumno> _listaALumno, List<Maestro> _listaMaestro)
        {
            sala = _sala;
            grado = _grado;
            maestroPrincipal = _MaestroPrincipal;
            listaALumno = _listaALumno;
            listaMaestro = _listaMaestro;
        }
    }
}
