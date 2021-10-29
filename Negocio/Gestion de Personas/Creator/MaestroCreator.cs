using Entities;
using Entities.Usuario;
using Entitites;
using Negocio.Gestion_de_Alumnos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio.Gestion_de_Personas.Creator
{
    public class MaestroCreator : PersonaCreator<Maestro>
    {
        public string error { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool AgregarTelefono(Maestro persona)
        {
            TelefonoComponent telefonoComponent = new TelefonoComponent();
            if (telefonoComponent.AgregarTelefonoAUnaPersona(persona.listaTelefono[0], persona) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void AgregarEspecialidad(Maestro persona)
        {

            MaestroComponent maestroComponent = new MaestroComponent();
            maestroComponent.AgregarEspecialidad(persona);


        }
        public bool CrearPersona(Maestro persona)
        {
   MaestroComponent maestroComponent = new MaestroComponent();
         
            if (maestroComponent.Create(persona) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }



        public void AgregarDocumentacion(List<Documento> listaDocumento,int legajo)


        {
            DocumentoComponent documentoComponent = new DocumentoComponent();
            foreach (var item in listaDocumento)
            {
                Maestro maestro = new Maestro();
                maestro.Id = legajo;
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog = item.openFileDialog;
                Documento documento = new Documento(maestro,openFileDialog);


                documento.año = item.año;
                documento.NombreDocumento = item.NombreDocumento;
                documento.tipo_Documentancion = item.NombreDocumento;
            
            
           
                documentoComponent.Create(documento);
            }

        }

     
        
        public string CrearPersonaContructor(Maestro persona, Usuarios usuarios)
        {
            MaestroComponent maestroComponent = new MaestroComponent();
            if (CrearPersona(persona))
            {
                Maestro maestroCreado = new Maestro(persona.especialidades,persona.documentos, maestroComponent.ReadBy(persona.DNI));
                maestroComponent.AgregarEspecialidad(maestroCreado);
        

                if (CrearUsuario(usuarios,maestroCreado))
                {
                    AgregarDocumentacion(persona.documentos, maestroCreado.Id);

                    return "";
                }
                else
                {
                    maestroComponent.Delete(maestroCreado.Id);
                    return "No se creo la persona, el usuario existe";
                }

            }
            else
            {
                return "No se creo la persona, el Maestro existe";
            }
      
        }

        public bool CrearUsuario(Usuarios usuarios, Maestro persona)
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
