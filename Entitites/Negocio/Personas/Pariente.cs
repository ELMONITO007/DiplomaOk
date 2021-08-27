using Entitites.Negocio.Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities 
{
    class Pariente : Persona
    {


        public List< Alumno> alumnos { get; set; }
     
        public string parentesco { get; set; }
        public bool autorizadoRetirar { get; set; }
        public Pariente()
        {

          

        }


        public Pariente(List<Alumno>  _alumnos )
        {
            alumnos = _alumnos;


        }
    }
}
