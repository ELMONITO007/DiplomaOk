using Entities;
using Entities.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Gestion_de_Personas.Creator
{
    public class FamiliarContructor : PersonaCreator<Familia>
    {
        public string error { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool AgregarTelefono(Familia persona)
        {
            throw new NotImplementedException();
        }

        public bool CrearPersona(Familia persona)
        {
            throw new NotImplementedException();
        }

        public string CrearPersonaContructor(Familia persona, Usuarios usuarios)
        {
            throw new NotImplementedException();
        }

        public bool CrearUsuario(Usuarios usuarios, Familia persona)
        {
            throw new NotImplementedException();
        }
    }
}
