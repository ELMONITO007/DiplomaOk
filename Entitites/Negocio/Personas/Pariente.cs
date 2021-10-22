using Entitites.Negocio.Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities 
{
  public  class Pariente : Persona
    {


        public List< Alumno> alumnos { get; set; }
        public Alumno alumno { get; set; }

        public string parentesco { get; set; }
        public bool autorizadoRetirar { get; set; }
        public Pariente()
        {

          

        }
        public Pariente(Alumno _alumno)
        {
            alumno = _alumno;


        }

        public Pariente(List<Alumno>  _alumnos )
        {
            alumnos = _alumnos;


        }
    }
}
