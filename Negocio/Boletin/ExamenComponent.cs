using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Data;
using Negocio.Gestion_de_Personas;
using System.Globalization;
using Data.Gestion_de_Boletin;
using Negocio.Gestion_de_Salas;
using Entitites.Negocio.Salas;

namespace Negocio.Gestion_de_boletin
{
    public class ExamenComponent : IRepository2<Examen>
    {
        public List<Examen> buscar(string palabra)
        {

            List<Examen> entity = new List<Examen>();

            entity = Read();
            List<Examen> result = new List<Examen>();
            foreach (Examen item in entity)
            {
                if (item.persona.DNI.ToString().Contains(palabra) || item.persona.apellido.Contains(palabra) || item.fecha.ToString().Contains(palabra) || item.materia.materia.ToString().Contains(palabra) || item.nota.ToString().Contains(palabra))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public Examen Create(Examen entity)
        {
            ExamenDAC examenDAC = new ExamenDAC();
            return examenDAC.Create(entity);
        }

        public void Delete(int id)
        {
            ExamenDAC examenDAC = new ExamenDAC();
            examenDAC.Delete(id);
        }
        public List<Materia> ReadByAlumnoYMateria(int legajo, DateTime fi, DateTime ff)
        {

            ExamenDAC personaDAC = new ExamenDAC();

            return personaDAC.ReadByAlumnoYMateria(legajo, fi, ff);




        }
        public List<Examen> Read()
        {
            ExamenDAC personaDAC = new ExamenDAC();
            List<Examen> result = new List<Examen>();
            foreach (Examen item in personaDAC.Read())
            {
                AlumnoComponent personaComponent = new AlumnoComponent();
                Examen examen = new Examen();
                MateriaComponent materiaComponent = new MateriaComponent();
                examen = item;
                examen.persona = personaComponent.ReadBy(item.persona.Id);
                examen.materia = materiaComponent.ReadBy(item.materia.Id);
                result.Add(examen);


            }
            return result;
        }

        public Examen ReadBy(int id)
        {
            ExamenDAC personaDAC = new ExamenDAC();
            Examen result = new Examen();

            result = personaDAC.ReadBy(id);
            AlumnoComponent personaComponent = new AlumnoComponent();

            MateriaComponent materiaComponent = new MateriaComponent();

            result.persona = personaComponent.ReadBy(result.persona.Id);
            result.materia = materiaComponent.ReadBy(result.materia.Id);




            return result;
        }

        public List<Examen> ReadByAlumnoYAño(Examen entity, DateTime fi, DateTime ff)


        {
            ExamenDAC personaDAC = new ExamenDAC();
            List<Examen> result = new List<Examen>();
            foreach (Examen item in personaDAC.ReadByAlumnoYAño(entity, fi, ff))
            {
                AlumnoComponent personaComponent = new AlumnoComponent();
                Examen examen = new Examen();
                MateriaComponent materiaComponent = new MateriaComponent();
                examen = item;
                examen.persona = personaComponent.ReadBy(item.persona.Id);
                examen.materia = materiaComponent.ReadBy(item.materia.Id);
                result.Add(examen);


            }
            return result;

        }
        public List<Examen> ReadByAlumnoYAñoUnique(Examen entity, DateTime fi, DateTime ff)


        {
            ExamenDAC personaDAC = new ExamenDAC();
            List<Examen> result = new List<Examen>();
            foreach (Examen item in personaDAC.ReadByAlumnoYAñoUnique(entity, fi, ff))
            {
                AlumnoComponent personaComponent = new AlumnoComponent();
                Examen examen = new Examen();
                MateriaComponent materiaComponent = new MateriaComponent();
                examen = item;
                examen.persona = personaComponent.ReadBy(item.persona.Id);
                examen.materia = materiaComponent.ReadBy(item.materia.Id);
                result.Add(examen);


            }
            return result;

        }
        public List<Examen> ReadByCurso(int curso)


        {
            //Curso cursoAlumno = new Curso();
            //CursoComponent cursoAlumnoComponent = new CursoComponent();
            //cursoAlumno = cursoAlumnoComponent.ObtenerALumnoYProfesDeUnCurso(curso);

            //CursoComponent cursoComponent = new CursoComponent();
            //DateTime fi = new DateTime(cursoComponent.ReadBy(curso).salaHorario.año, 1, 1);

            //DateTime ff = new DateTime(cursoComponent.ReadBy(curso).salaHorario.año, 12, 1);
            //Examen examen = new Examen();
            List<Examen> result = new List<Examen>();
            //foreach (Persona item in cursoAlumno.Alumnos)
            //{
            //    examen.persona.Id = item.Id;
            //    foreach (var subItem in ReadByAlumnoYAño(examen, fi, ff))
            //    {
            //        result.Add(subItem);
            //    }


            //}
            return result;

        }

        public Examen ReadBy(string id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Examen entity)
        {
            ExamenDAC personaDAC = new ExamenDAC();
            personaDAC.Update(entity);
            return true;
        }

        public bool Verificar(Examen entity)
        {
            throw new NotImplementedException();
        }
    }
}
