
using Data.Gestion_Salas;
using Entities;
using Entitites;
using Entitites.Negocio.Personas;
using Entitites.Negocio.Salas;
using Negocio.Gestion_de_Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CursoComponent : IRepository2<Curso>
    {
        public List<Curso> buscar(string palabra)
        {
            List<Curso> entity = new List<Curso>();

            entity = Read();
            List<Curso> result = new List<Curso>();
            foreach (Curso item in entity)
            {
                if (item.nombre.ToString().Contains(palabra) || item.sala.nombre.Contains(palabra) || item.grado.nombre.Contains(palabra) )
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public Curso Create(Curso entity)
        {
            if (Verificar(entity))
            {
                CursoDAC cursoDAC = new CursoDAC();
                return cursoDAC.Create(entity);
            }
            else
            {
                return null;
            }
        }

        public void Delete(int id)
        {
            CursoDAC cursoDAC = new CursoDAC();
            cursoDAC.Delete(id);
        }

        public List<Curso> Read()
        {
            CursoDAC cursoDAC = new CursoDAC();
            List<Curso> result = new List<Curso>();

            foreach (var item in cursoDAC.Read())
            {
                SalaHorarioComponent salaHorarioComponent = new SalaHorarioComponent();
                SalaComponent salaComponent = new SalaComponent();
                GradoComponent gradoComponent = new GradoComponent();

                Grado grado = new Grado();
                grado = gradoComponent.ReadBy(item.grado.Id);

                Sala sala = new Sala();
                sala= salaComponent.ReadBy(item.sala.Id);
                SalaHorario salaHorario = new SalaHorario();
                salaHorario = salaHorarioComponent.ReadBy(item.salaHorario.Id);
                Curso curso = new Curso(sala,grado,salaHorario);
                curso.Id = item.Id;
                curso.nombre = item.nombre;
              

                result.Add(curso);
            }

            return result;
        }

        public List<Curso> ReadByAño(int año)
        {
            CursoDAC cursoDAC = new CursoDAC();
            List<Curso> result = new List<Curso>();

            foreach (var item in cursoDAC.ReadByAño(año))
            {

                SalaHorarioComponent salaHorarioComponent = new SalaHorarioComponent();
                SalaComponent salaComponent = new SalaComponent();
                GradoComponent gradoComponent = new GradoComponent();

                Grado grado = new Grado();
                grado = gradoComponent.ReadBy(item.grado.Id);

                Sala sala = new Sala();
                sala = salaComponent.ReadBy(item.sala.Id);
                SalaHorario salaHorario = new SalaHorario();
                salaHorario = salaHorarioComponent.ReadBy(item.salaHorario.Id);
                Curso curso = new Curso(sala, grado, salaHorario);
                curso.Id = item.Id;
                curso.nombre = item.nombre;


                result.Add(curso);
            }

            return result;
        }
            public List<Curso> ReadBysala(Curso entity)
        {
            CursoDAC cursoDAC = new CursoDAC();
            List<Curso> result = new List<Curso>();

            foreach (var item in cursoDAC.ReadByCurso(entity))
            {

                SalaHorarioComponent salaHorarioComponent = new SalaHorarioComponent();
                SalaComponent salaComponent = new SalaComponent();
                GradoComponent gradoComponent = new GradoComponent();

                Grado grado = new Grado();
                grado = gradoComponent.ReadBy(item.grado.Id);

                Sala sala = new Sala();
                sala = salaComponent.ReadBy(item.sala.Id);
                SalaHorario salaHorario = new SalaHorario();
                salaHorario = salaHorarioComponent.ReadBy(item.salaHorario.Id);
                Curso curso = new Curso(sala, grado, salaHorario);
                curso.Id = item.Id;
                curso.nombre = item.nombre;


                result.Add(curso);
            }

            return result;
        }
        public List<Curso> ReadByGrado(Curso entity)
        {
            CursoDAC cursoDAC = new CursoDAC();
            List<Curso> result = new List<Curso>();

            foreach (var item in cursoDAC.ReadByGrado(entity))
            {

                SalaHorarioComponent salaHorarioComponent = new SalaHorarioComponent();
                SalaComponent salaComponent = new SalaComponent();
                GradoComponent gradoComponent = new GradoComponent();

                Grado grado = new Grado();
                grado = gradoComponent.ReadBy(item.grado.Id);

                Sala sala = new Sala();
                sala = salaComponent.ReadBy(item.sala.Id);
                SalaHorario salaHorario = new SalaHorario();
                salaHorario = salaHorarioComponent.ReadBy(item.salaHorario.Id);
                MaestroComponent maestroComponent = new MaestroComponent();
                


                Curso curso = new Curso(sala, grado, salaHorario);
                curso.Id = item.Id;
                curso.nombre = item.nombre;

             

                result.Add(curso);
            }

            return result;
        }

        public void QuitarAlumnoSala(int id_curso, int legajo)

        {
            CursoDAC cursoDAC = new CursoDAC();
            cursoDAC.QuitarAlumnoSala(id_curso, legajo);
        
        }
        public Curso ReadBy(int id)
        {
            CursoDAC salaDac = new CursoDAC();
            Curso result = new Curso();
            result = salaDac.ReadBy(id);
            if (result != null)
            {
                



                SalaHorarioComponent salaHorarioComponent = new SalaHorarioComponent();
                SalaComponent salaComponent = new SalaComponent();
                GradoComponent gradoComponent = new GradoComponent();
                Grado grado = new Grado();
                grado = gradoComponent.ReadBy(result.grado.Id);

                Sala sala = new Sala();
                sala = salaComponent.ReadBy(result.sala.Id);
                SalaHorario salaHorario = new SalaHorario();
                salaHorario = salaHorarioComponent.ReadBy(result.salaHorario.Id);


                MaestroComponent maestroComponent = new MaestroComponent();
                List<Maestro> maestros = new List<Maestro>();
                maestros = maestroComponent.ObtenerAlumnodeCunCurso(id);

                AlumnoComponent alumnoComponent = new AlumnoComponent();
                List<Alumno> alumnos = new List<Alumno>();
                alumnos = alumnoComponent.ObtenerAlumnodeCunCurso(id);

                Curso curso = new Curso(sala, grado,null, alumnos,maestros,salaHorario);
                curso.Id = result.Id;
                curso.nombre = result.nombre;
                return curso;
            }
            else
            {
                return null;
            }

           
        }

        public Curso ReadBy(string id)
        {
            CursoDAC salaDac = new CursoDAC();
            Curso result = new Curso();
            result = salaDac.ReadBy(id);
            if (result != null)
            {


                SalaHorarioComponent salaHorarioComponent = new SalaHorarioComponent();
                SalaComponent salaComponent = new SalaComponent();
                GradoComponent gradoComponent = new GradoComponent();
                Grado grado = new Grado();
                grado = gradoComponent.ReadBy(result.grado.Id);

                Sala sala = new Sala();
                sala = salaComponent.ReadBy(result.sala.Id);
                SalaHorario salaHorario = new SalaHorario();
                salaHorario = salaHorarioComponent.ReadBy(result.salaHorario.Id);
                Curso curso = new Curso(sala, grado, salaHorario);
                curso.Id = result.Id;
                curso.nombre = result.nombre;
                return curso;
            }
            else
            {
                return null;
            }
        }

        public bool Update(Curso entity)
        {
            CursoDAC cursoDAC = new CursoDAC();
            cursoDAC.Update(entity);
            return true;
        }

        public bool Verificar(Curso entity)
        {
            if (ReadBy(entity.nombre)==null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool VerificarVacantes(int id_curso)


        {

            Curso curso = new Curso();
            CursoComponent cursoComponent = new CursoComponent();
            curso = cursoComponent.ReadBy(id_curso);
            AlumnoComponent alumnoComponent = new AlumnoComponent();
           int cantidadAlumno= alumnoComponent.ObtenerAlumnodeCunCurso(id_curso).Count;
            if ( curso.sala.capacidad >cantidadAlumno)
            {
                return true;

            }
            else
            {
                return true;
            }

        
        
        
        }

        public List<Persona> ObtenerAlumnosDisponibles(int id_curso, int año)
        {
            CursoDAC cursoAlumnoDAC = new CursoDAC();
            AlumnoComponent personaComponent = new AlumnoComponent();
            Curso curso = new Curso();
            CursoComponent cursoComponent = new CursoComponent();
            //obtengo el curso
            curso = cursoComponent.ReadBy(id_curso);
            //establezco segun el grado los años de inicio y fin
            int añoFecha = año - curso.grado.año - 1;
            int añoFechafin = año - curso.grado.año;
            string fechaInicio = añoFecha.ToString() + "-06-30 00:00:00";
            string fechaFin = añoFechafin.ToString() + "-06-30 00:00:00";
            DateTime fi = new DateTime(añoFecha, 06, 30);
            DateTime ff = new DateTime(añoFechafin, 06, 30);
            //obtengo alumnos 

            List<Alumno> personas = new List<Alumno>();
            personas = personaComponent.ReadByFechaNacimiento(fi, ff);

            //Obtengo alumnos ya incriptos

            List<Alumno> cursoAlumnos = new List<Alumno>();
            cursoAlumnos = personaComponent.ReadByAño(curso.salaHorario.año);

            //Asigno los alumnos que no tiene cursos
            List<Persona> result = new List<Persona>();
            foreach (var item in personas)
            {
                int a = 0;

                foreach (var itemCurso in cursoAlumnos)
                {

                    if (itemCurso.Id == item.Id)
                    {
                        a = 1;
                    }


                }
                if (a == 0)
                {
                    result.Add(item);
                }

            }
            return result;
        }

        public Curso AsignarAlumno(Curso entity)


        {
            CursoDAC cursoDAC = new CursoDAC();
           return cursoDAC.AsignarAlumno(entity);
        
        
        }

    }
}
