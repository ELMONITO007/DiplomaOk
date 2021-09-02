using Entities;
using Entities.Usuario;
using Entitites.Negocio.Personas;
using Negocio.Gestion_de_Alumnos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Gestion_de_Personas.Creator
{
    public class AlumnoCreator : PersonaCreator<Alumno>
    {
        public string error { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool AgregarTelefono(Alumno persona)
        {
            TelefonoComponent telefonoComponent = new TelefonoComponent();
            if (telefonoComponent.AgregarTelefonoAUnaPersona(persona.listaTelefono[0], persona)==null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool CrearPersona(Alumno persona)
        {
            AlumnoComponent alumnoComponent = new AlumnoComponent() ;
            if (alumnoComponent.Create(persona) ==null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void AgregarDocumentacion(List<Documento> listaDocumento, Alergias alergias, Casa casa, Familia familia, ObrasSocial obrasSocial,int legajo)
        {

            AlergiaComponent alergiaComponent = new AlergiaComponent();
            CasaComponent casaComponent = new CasaComponent();
            FamiliaComponent familiaComponent = new FamiliaComponent();
            ObraSocialComponent obraSocialComponent = new ObraSocialComponent();
            DocumentoComponent documentoComponent = new DocumentoComponent();

            alergias.persona.Id = legajo;
            casa.persona.Id = legajo;

            familia.persona.Id = legajo;

            obrasSocial.persona.Id = legajo;

            foreach (var item in listaDocumento)
            {
                item.persona.Id = legajo;
                documentoComponent.Create(item);
            }

            alergiaComponent.Create(alergias);
            casaComponent.Create(casa);
            familiaComponent.Create(familia);
            obraSocialComponent.Create(obrasSocial);


          
        }

        public string CrearPersonaContructor(Alumno persona, Usuarios usuarios)
        {
       
            if (CrearPersona(persona))
            {
                AlumnoComponent alumnoComponent = new AlumnoComponent();
                Alumno alumno = new Alumno();
                alumno = alumnoComponent.ReadBy(persona.DNI);
                usuarios.Apellido = alumno.apellido;
                usuarios.Nombre = alumno.nombre;
                if (CrearUsuario(usuarios,alumno))
                {
                    alumno.listaTelefono = persona.listaTelefono;
                    AgregarTelefono(alumno);
                    
            
                    return "";
                    
                }
                else
                {
                    alumnoComponent.Delete(alumno.Id);
                    return "No se creo la persona, el usuario existe";
                }

            }
            else
            {
                return "No se creo la persona, el alumno existe";
            }
        }

        public bool CrearUsuario(Usuarios usuarios, Alumno persona)
        {
            UsuariosComponent usuariosComponent = new UsuariosComponent();
            if (usuariosComponent.Crear(usuarios, persona))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
