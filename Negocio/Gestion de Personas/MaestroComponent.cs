using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Data;
using Entitites.Negocio.Personas;
using Data.Gestion_de_Personas;
using Entitites;
using Negocio.Gestion_de_Alumnos;

namespace Negocio.Gestion_de_Personas
{
    public class MaestroComponent : IRepository2<Maestro>
    {
        #region Maestro
        public List<Maestro> buscar(string palabra)
        {

            List<Maestro> entity = new List<Maestro>();

            entity = Read();
            List<Maestro> result = new List<Maestro>();
            foreach (Maestro item in entity)
            {
                if (item.nombre.Contains(palabra) || item.apellido.Contains(palabra) || item.DNI.Contains(palabra) || item.direccion.Contains(palabra))
                {
                    result.Add(item);
                }
            }

            return result;
        }


        public List<Maestro> ObtenerAlumnodeCunCurso(int id_curso)
        {
            MaestroDAC maestroDAC = new MaestroDAC();
            return maestroDAC.ObtenerMaestrodeCunCurso(id_curso);
                    }
            public List<Maestro> buscar(string palabra, int tipo)
        {

            List<Maestro> entity = new List<Maestro>();

            entity = Read();
            List<Maestro> result = new List<Maestro>();
            foreach (Maestro item in entity)
            {
                if (item.nombre.Contains(palabra) || item.apellido.Contains(palabra) || item.DNI.Contains(palabra) || item.direccion.Contains(palabra))
                {
                    result.Add(item);
                }
            }

            return result;
        }
        public Maestro Create(Maestro entity)
        {
            if (Verificar(entity))
            {
                MaestroDAC idiomaDAC = new MaestroDAC();
                Maestro persona = new Maestro();
                persona = idiomaDAC.Create(entity);


                return persona;
            }
            else
            {
                return null;
            }
        }



        public void Delete(int id)
        {
            MaestroDAC idiomaDAC = new MaestroDAC();
            idiomaDAC.Delete(id);
        }


        public List<Maestro> Read()
        {
            MaestroDAC personaDAC = new MaestroDAC();


            return personaDAC.Read();

        }

        public Maestro ReadByUsuario(int id)

        {

            MaestroDAC personaDAC = new MaestroDAC();
            Maestro result = new Maestro();
            Maestro persona = new Maestro();
            persona = personaDAC.ReadByUsuario(id);


            return persona;
        }
        public Maestro ReadBy(int id)
        {

            MaestroDAC personaDAC = new MaestroDAC();
            Maestro result = new Maestro();
            Maestro persona = new Maestro();
            persona = personaDAC.ReadBy(id);


            return persona;
        }

        public Maestro ReadBy(string id)
        {
            MaestroDAC personaDAC = new MaestroDAC();
            Maestro result = new Maestro();
            Maestro persona = new Maestro();
            persona = personaDAC.ReadBy(id);


            return persona;
        }

        public bool Update(Maestro entity)
        {
            MaestroDAC personaDAC = new MaestroDAC();
            personaDAC.Update(entity);
            return true;
        }

        public bool Verificar(Maestro entity)
        {
            if (ReadBy(entity.DNI) == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Especialidad

        public void AgregarEspecialidad(Maestro entity)


        {
            MaestroDAC maestroDAC = new MaestroDAC();
            foreach (var item in entity.especialidades)
            {
                
               List< Especialidad> especialidad = new List<Especialidad>();
                EspecialidadComponent especialidadComponent = new EspecialidadComponent();
                item.Id = especialidadComponent.ReadBy(item.especialidad).Id;
                especialidad.Add(item);
                Maestro maestro = new Maestro(especialidad);
                maestro.Id = entity.Id;
                maestroDAC.AgregarEspecialidad  (maestro);
            }
        
        
        
        }
        public void QuitarEspecialidad(Maestro entity)
        {
            MaestroDAC maestroDAC = new MaestroDAC();
            
            EspecialidadComponent especialidadComponent = new EspecialidadComponent();
           List< Especialidad> especialidad = new List<Especialidad>();
            especialidad.Add(especialidadComponent.ReadBy(entity.especialidades[0].especialidad));
            List<Documento> documentos = new List<Documento>();
            documentos = entity.documentos;
            Maestro maestro = new Maestro(especialidad, documentos);
            maestro.Id = entity.Id;
            maestroDAC.QuitarEspecialidad(maestro);
        }
        public Maestro ReadByMaestroYespecialidad(Maestro legajo)
        {
            MaestroDAC maestroDAC = new MaestroDAC();
            return maestroDAC.ReadBy(legajo);

        }

        public List<Maestro> ReadByEspecialidad(Maestro legajo)
        {
            MaestroDAC maestroDAC = new MaestroDAC();
            return maestroDAC.ReadByEspecialidad(legajo);

        }


        #endregion
    }
}
