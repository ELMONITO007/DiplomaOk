using Entities;
using Entities.Usuario;
using Entitites.Negocio.Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Gestion_de_Personas
{
    interface PersonaCreator
    {
        string error { get; set; }
        bool AgregarTelefono(Telefono telefono, Persona persona);
        bool CrearUsuario(Usuarios usuarios, Persona persona);
        bool CrearPersona(Persona persona);
        string CrearAlumnoContructor(List<Documento> listaDocumentacion, Telefono telefono, Alergias alergias, Persona persona, Casa casa, Familia familia, ObrasSocial obrasSocial, Usuarios usuarios);

    }
}
