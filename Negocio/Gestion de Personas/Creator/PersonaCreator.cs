using Entities;
using Entities.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Gestion_de_Personas.Creator
{
    interface PersonaCreator<TEntity> where TEntity : EntityBase
    {
        bool AgregarTelefono(TEntity persona);
        bool CrearUsuario(Usuarios usuarios, TEntity persona);
        bool CrearPersona(TEntity persona);
        string error { get; set; }
        string CrearPersonaContructor(TEntity persona, Usuarios usuarios);


    }
}
