using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Data;
using Data.Gestion_de_Personas;

using Negocio.Gestion_de_Personas;
using System.IO;
using System.Windows.Forms;

namespace Negocio.Gestion_de_Alumnos
{
    public class DocumentoComponent : IRepository2<Documento>
    {
        public DocumentoComponent() { }
        public List<Documento> buscar(string palabra)
        {
            List<Documento> entity = new List<Documento>();

            entity = Read();
            List<Documento> result = new List<Documento>();
            foreach (Documento item in entity)
            {
                if (item.NombreDocumento.Contains(palabra) || item.persona.apellido.Contains(palabra) || item.persona.DNI.Contains(palabra) || item.tipo_Documentancion.Contains(palabra))
                {
                    result.Add(item);
                }
            }

            return result;
        }
        private static void VerificarSiexistePath(string nombre)
        {
            string ruta = @"C:\Documentacion\" + nombre;
            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }

        }

        public Documento Create(Documento entity)
        {
            if (Verificar(entity))
            {
                string path = entity.persona.DNI + @"\" + DateTime.Now.Year;
                VerificarSiexistePath(path);
                Documento documentacion = new Documento();
                DocumentoDAC documentacionDAC = new DocumentoDAC();
                documentacion = entity;
                String documento = Path.GetFileName(entity.openFileDialog.FileName);
               

            
                documentacion.año = DateTime.Now.Year;
                File.Copy(entity.openFileDialog.FileName, @"C:\Documentacion\" + path + @"\" + documentacion.NombreDocumento + ".pdf", true);
                documentacion = documentacionDAC.Create(documentacion);

                return documentacion;
            }
            else
            {
                return null;
            }

        }
        private void EliminarArchivo(Documento entity)
        {
            string ruta = @"C:\Documentacion\" + entity.persona.DNI + @"\" + DateTime.Now.Year + @"\" + entity.NombreDocumento;
            if (File.Exists(ruta))
            {
                File.Delete(ruta);
            }
        }

        public void Delete(int id)
        {
            DocumentoDAC documentacionDAC = new DocumentoDAC();
            Documento documentacion = new Documento();
            documentacion = ReadBy(id);
            documentacionDAC.Delete(id);
            EliminarArchivo(documentacion);

        }

        private void VerificarSiExisteArchivos(int id)
        {
            List<Documento> documentacions = new List<Documento>();
            documentacions = ReadByAlumno(id);
            foreach (Documento item in documentacions)
            {
                string ruta = @"C:\Documentacion\" + item.persona.DNI + @"\" + DateTime.Now.Year + @"\" + item.NombreDocumento;
                if (!File.Exists(ruta))
                {
                    Delete(item.Id);
                }
            }



        }
        public DocumentoComponent(int legajoAlumno)
        {
            VerificarSiExisteArchivos(legajoAlumno);
        }

        public List<Documento> ReadByAlumno(int legajoAlumno)
        {
            DocumentoDAC documentacionDAC = new DocumentoDAC();
            List<Documento> result = new List<Documento>();

            foreach (Documento item in documentacionDAC.ReadByAlumno(legajoAlumno))
            {
                AlumnoComponent personaComponent = new AlumnoComponent();
                Documento documentacion = new Documento();
             

                documentacion = item;
             
                documentacion.persona = personaComponent.ReadBy(legajoAlumno);
                result.Add(documentacion);

            }
            return result;


        }
        public Documentacion ReadBy(Documentacion entity)
        {
            DocumentoDAC documentacionDAC = new DocumentoDAC();
            Documento result = new Documento();
            Documento documentacion = new Documento();
            documentacion = documentacionDAC.ReadBy(entity);
            if (documentacion == null)
            {
                return null;
            }
            else
            {
                AlumnoComponent personaComponent = new AlumnoComponent();
             
                result = documentacion;
              
                result.persona = personaComponent.ReadBy(documentacion.persona.Id);

                return result;
            }


        }
        public List<Documento> Read()
        {
            throw new NotImplementedException();
        }

        public Documento ReadBy(int id)
        {
            throw new NotImplementedException();
        }

        public Documento ReadBy(string id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Documento entity)
        {
            DocumentoDAC documentacionDAC = new DocumentoDAC();
            documentacionDAC.Update(entity);
            return true;
        }

        public bool Verificar(Documento entity)
        {
            if (ReadBy(entity) == null)
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
