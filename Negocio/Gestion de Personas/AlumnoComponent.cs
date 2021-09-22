using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Data;
using Entitites.Negocio.Personas;
using Data.Gestion_de_Personas;

namespace Negocio.Gestion_de_Personas
{
    public class AlumnoComponent : IRepository2<Alumno>
    {
        public List<Alumno> buscar(string palabra)
        {

            List<Alumno> entity = new List<Alumno>();

            entity = Read();
            List<Alumno> result = new List<Alumno>();
            foreach (Alumno item in entity)
            {
                if (item.nombre.Contains(palabra) || item.apellido.Contains(palabra) || item.DNI.Contains(palabra) || item.direccion.Contains(palabra))
                {
                    result.Add(item);
                }
            }

            return result;
        }
        public List<Alumno> ObtenerAlumnodeCunCurso(int id_curso)
        {
            AlumnoDAC alumnoDAC = new AlumnoDAC();
            return alumnoDAC.ObtenerAlumnodeCunCurso(id_curso);

        }

            public List<Alumno> buscar(string palabra, int tipo)
        {

            List<Alumno> entity = new List<Alumno>();

            entity = Read();
            List<Alumno> result = new List<Alumno>();
            foreach (Alumno item in entity)
            {
                if (item.nombre.Contains(palabra) || item.apellido.Contains(palabra) || item.DNI.Contains(palabra) || item.direccion.Contains(palabra))
                {
                    result.Add(item);
                }
            }

            return result;
        }
        public Alumno Create(Alumno entity)
        {
            if (Verificar(entity))
            {
                
                AlumnoDAC idiomaDAC = new AlumnoDAC();
                Alumno persona = new Alumno();
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
            AlumnoDAC idiomaDAC = new AlumnoDAC();
            idiomaDAC.Delete(id);
        }

        

        public List<Alumno> Read()
        {
            AlumnoDAC personaDAC = new AlumnoDAC();
        
          
            return personaDAC.Read();

        }

        public List<Alumno> ReadByFechaNacimiento(DateTime fechaInicio, DateTime fechaFinal)
        {

            AlumnoDAC personaDAC = new AlumnoDAC();
            List<Alumno> result = new List<Alumno>();
    
            
            return personaDAC.ReadByFechaNacimiento(fechaInicio, fechaFinal);
        }
        public Alumno ReadBy(int id)
        {

            AlumnoDAC personaDAC = new AlumnoDAC();
            Alumno result = new Alumno();
            Alumno persona = new Alumno();
            persona = personaDAC.ReadBy(id);
           

            return persona;
        }

        public Alumno ReadBy(string id)
        {
            AlumnoDAC personaDAC = new AlumnoDAC();
            Alumno result = new Alumno();
            Alumno persona = new Alumno();
            persona = personaDAC.ReadBy(id);


            return persona;
        }

        public bool Update(Alumno entity)
        {
            AlumnoDAC personaDAC = new AlumnoDAC();
            personaDAC.Update(entity);
            return true;
        }

        public bool Verificar(Alumno entity)
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
    }
}
