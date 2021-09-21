using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitites.Negocio.Personas
{
    public class Persona : Entities.EntityBase
    {
        public override int Id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public string nombreCompleto { get; set; }
        public string DNI { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public List<Telefono> listaTelefono { get; set; }
        public string tipoPersona { get; set; }
        public List<Documentacion> listaDocumentacion { get; set; }
        public Persona() { }
        public Persona(List<Telefono> _listaTelefono, List<Documentacion> _listaDocumentacion) {
            listaTelefono = _listaTelefono;
            listaDocumentacion = _listaDocumentacion;
        }
    }
}
