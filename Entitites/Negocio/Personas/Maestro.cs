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
        public List<Documento> documentos { get; set; }
        public Maestro() {
        
           
        }
        public void GenerarNombreCompleto()
        {
            this.nombreCompleto = this.nombre + " " + this.apellido; 
        
        }

       
        public Maestro(List<Especialidad> _especialidades, List<Documento> _documentos)

        {

            especialidades = _especialidades;

            documentos = _documentos;
        }
        public Maestro(List<Especialidad> _especialidades, List<Documento> _documentos, List<Telefono> _telefonos)

        {
            especialidades = _especialidades;

            documentos = _documentos;
            listaTelefono = _telefonos;
        }

            public Maestro(List<Especialidad> _especialidades, List<Documento> _documentos,Maestro maestro)

        {
            this.apellido = maestro.apellido;
            this.direccion = maestro.direccion;
            this.DNI = maestro.direccion;
            this.documentos = maestro.documentos;
            this.fechaNacimiento = maestro.fechaNacimiento;
            this.Id = maestro.Id;
            this.nombre = maestro.nombre;
            this.nombreCompleto = maestro.nombreCompleto;
            especialidades = _especialidades;

            documentos = _documentos;
          
        }
        public Maestro(List<Especialidad> _especialidades)

        {

            especialidades = _especialidades;

       
        }
    }
}
