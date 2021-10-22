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


            Alergias unaAlergia = new Alergias(alumno);
            unaAlergia.Alergia_Alimento = alergias.Alergia_Alimento;
            unaAlergia.Alergia_Elementos = alergias.Alergia_Elementos;
            unaAlergia.Alergia_Medicamentos = alergias.Alergia_Alimento;
            unaAlergia.Cuales_Alergias_Alimento = alergias.Cuales_Alergias_Alimento;
            unaAlergia.Cuales_Alergias_Elementos = alergias.Cuales_Alergias_Elementos;
            unaAlergia.Cuales_Alergias_Medicamentos = alergias.Cuales_Alergias_Medicamentos;
            unaAlergia.Otras_Alergias = alergias.Otras_Alergias;


            Casa unaCasa = new Casa(alumno);

            unaCasa.año = casa.año;
            unaCasa.Tiene_Habitacion_Propia = casa.Tiene_Habitacion_Propia;

            unaCasa.Tiene_Patio = casa.Tiene_Patio;
            unaCasa.Vive_Barrio_Cerrado = casa.Vive_Barrio_Cerrado;
            unaCasa.Vive_Casa = casa.Vive_Casa; 
            unaCasa.Vive_Departamento = casa.Vive_Departamento;

      


            Familia unaFamilia = new Familia(alumno);

            unaFamilia.Padres_Separados = familia.Padres_Separados;
            unaFamilia.año = familia.año;
            unaFamilia.Hermanos = familia.Hermanos;
            unaFamilia.Mama_Trabajo = familia.Mama_Trabajo;
            unaFamilia.Papa_Trabajo = familia.Papa_Trabajo;
            unaFamilia.Vive_Abuela = familia.Vive_Abuela;

            ObrasSocial unaObraSocial = new ObrasSocial(alumno);
            unaObraSocial.año = obrasSocial.año;

            unaObraSocial.numero_Socio = obrasSocial.numero_Socio;
            unaObraSocial.obra_Social = obrasSocial.obra_Social;
            unaObraSocial.telefono_Emergencia = obrasSocial.telefono_Emergencia;
            unaObraSocial.tiene_Obra_Social = obrasSocial.tiene_Obra_Social;



            foreach (var item in listaDocumento)
            {
                Documento documento = new Documento(alumno);
                documento.Id=item.Id;
                documento.año = item.año;
                documento.openFileDialog = item.openFileDialog;
                documento.NombreDocumento = item.NombreDocumento;
                documento.tipo_Documentancion = item.tipo_Documentancion;
                documentoComponent.Create(documento);
            }

            alergiaComponent.Create(unaAlergia);
            casaComponent.Create(unaCasa);
            familiaComponent.Create(unaFamilia);
            obraSocialComponent.Create(unaObraSocial);


          
        }
        public string CrearAlumno(Alumno persona, Usuarios usuarios,List<Documento> listaDocumento, Alergias alergias, Casa casa, Familia familia, ObrasSocial obrasSocial) {


        
            string result = CrearPersonaContructor(persona, usuarios);

            if (result=="")
            {
                AgregarDocumentacion(listaDocumento, alergias, casa, familia, obrasSocial, alumno.Id);
            }


            return result;

        }



          

      

        public bool CrearUsuario(Usuarios usuarios, Alumno persona)
        {
            UsuariosComponent usuariosComponent = new UsuariosComponent();
            if (usuariosComponent.Crear(usuarios, persona))
            {
                RolesComponent rolesComponent = new RolesComponent();
                Roles roles = new Roles();
                roles = rolesComponent.ReadBy("Alumno");
                Usuarios usuarioCreado = new Usuarios();
                usuarioCreado = usuariosComponent.ReadByEmail(usuarios.Email);
                UsuarioRoles usuarioRoles = new UsuarioRoles(roles, usuarioCreado);
                UsuarioRolesComponent usuarioRolesComponent = new UsuarioRolesComponent();
                usuarioRolesComponent.Create(usuarioRoles);
                return true;
            }
            else
            {
                return false;
            }
        }
        Alumno alumno = new Alumno();
        public string CrearPersonaContructor(Alumno persona, Usuarios usuarios)
        {
            if (CrearPersona(persona))
            {
                AlumnoComponent alumnoComponent = new AlumnoComponent();
                
                alumno = alumnoComponent.ReadBy(persona.DNI);
                usuarios.Apellido = alumno.apellido;
                usuarios.Nombre = alumno.nombre;
                if (CrearUsuario(usuarios, alumno))
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
    }
}
