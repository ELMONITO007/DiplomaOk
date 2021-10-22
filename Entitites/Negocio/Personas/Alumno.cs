using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitites.Negocio.Personas
{
  public  class Alumno :Persona
    {

        public List<Pariente> parientes { get; set; }
     
        public Alumno() { }
        public void AgregarTelefono(Telefono telefono) {
            this.listaTelefono = new List<Telefono>();
            this.listaTelefono.Add(telefono);
        
        }
        public Alumno(List<Pariente> _parientes) { parientes = _parientes; }

    }
}
