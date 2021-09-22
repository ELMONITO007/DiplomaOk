using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Data;
using Negocio.Gestion_de_Personas;
using System.Globalization;
using Entitites.Negocio.Personas;

namespace Negocio
{
    public class AsistenciaComponent : IRepository2<Asistencia>
    {
        public List<Asistencia> buscar(string palabra)
        {

            List<Asistencia> entity = new List<Asistencia>();

            entity = Read();
            List<Asistencia> result = new List<Asistencia>();
            foreach (Asistencia item in entity)
            {
                if (item.dia.ToString().Contains(palabra) || item.persona.apellido.Contains(palabra) || item.mes.ToString().Contains(palabra) || item.año.ToString().Contains(palabra))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public Asistencia Create(Asistencia entity)
        {
            if (Verificar(entity))
            {
                AsistenciaDAC asistenciaDAC = new AsistenciaDAC();
                Asistencia persona = new Asistencia();
                persona = asistenciaDAC.Create(entity);


                return persona;
            }
            else
            {
                return null;
            }
        }

        public void Delete(int id)
        {
            AsistenciaDAC asistenciaDAC = new AsistenciaDAC();

            asistenciaDAC.Delete(id);
        }

        public List<Asistencia> Read()
        {
            AsistenciaDAC personaDAC = new AsistenciaDAC();
            List<Asistencia> result = new List<Asistencia>();
            foreach (Asistencia item in personaDAC.Read())
            {
                AlumnoComponent personaComponent = new AlumnoComponent();
                Alumno alumno = new Alumno();
                alumno = personaComponent.ReadBy(item.persona.Id);
                Asistencia asistencia = new Asistencia(alumno);


                asistencia.Id = item.Id;
                asistencia.asistio = item.asistio;
                asistencia.año = item.año;
                asistencia.dia = item.dia;
                asistencia.mes = item.mes;
                result.Add(asistencia);


            }
            return result;
        }

        public Asistencia ReadBy(int id)
        {
            Asistencia asistencia = new Asistencia();
            AsistenciaDAC asistenciaDAC = new AsistenciaDAC();
            asistencia = asistenciaDAC.ReadBy(id);

            AlumnoComponent personaComponent = new AlumnoComponent();
            Alumno alumno = new Alumno();
            alumno= personaComponent.ReadBy(asistencia.persona.Id);
         
            Asistencia result = new Asistencia(alumno);



            result.Id = asistencia.Id;
            result.asistio = asistencia.asistio;
            result.año = asistencia.año;
            result.dia = asistencia.dia;
            result.mes = asistencia.mes;






            return result;
        }
        public Asistencia ReadBy(Asistencia entity)
        {
            Asistencia asistencia = new Asistencia();
            AsistenciaDAC asistenciaDAC = new AsistenciaDAC();
            asistencia = asistenciaDAC.ReadBy(entity);

            AlumnoComponent personaComponent = new AlumnoComponent();
            Alumno alumno = new Alumno();
            alumno= personaComponent.ReadBy(asistencia.persona.Id);
         
            Asistencia result = new Asistencia(alumno);



            result.Id = asistencia.Id;
            result.asistio = asistencia.asistio;
            result.año = asistencia.año;
            result.dia = asistencia.dia;
            result.mes = asistencia.mes;






            return result;
        }

        public List<Asistencia> ReadByCurso(List<Alumno> entity, int año)


        {
            AsistenciaDAC personaDAC = new AsistenciaDAC();
            List<Asistencia> result = new List<Asistencia>();

            foreach (var item in entity)
            {
                if (item.tipoPersona == "Alumno")
                {
                    Asistencia asistencia = new Asistencia();
                    asistencia.persona = item;
                    asistencia.año = año;

                    foreach (var asis in ReadByAlumno(asistencia))
                    {
                        result.Add(asis);
                    }
                }




            }
            return result;


        }

        public List<Asistencia> ReadByCursoMes(List<Alumno> entity, int año, string mes)


        {
            AsistenciaDAC personaDAC = new AsistenciaDAC();
            List<Asistencia> result = new List<Asistencia>();
            int numeromes = DateTime.ParseExact(mes, "MMMM", CultureInfo.CreateSpecificCulture("es-ES")).Month;

            foreach (var item in ReadByCurso(entity, año))
            {
                if (item.mes == numeromes)
                {
                    Asistencia asistencia = new Asistencia();
                    asistencia = item;
                    result.Add(asistencia);


                }




            }
            return result;


        }

        public List<string> ObtenerMesesConAsistenciaPorCursoAño(Asistencia entity)


        {

            AsistenciaDAC personaDAC = new AsistenciaDAC();

            List<string> result = new List<string>();
            foreach (var item in personaDAC.ObtenerMesesConAsistenciaPorCursoAño(entity))
            {
                DateTime date = new DateTime(2020, item.mes, 1);
                string unMes = date.ToString("MMMM", CultureInfo.CreateSpecificCulture("es-ES"));
                result.Add(unMes);

            }
            return result;

        }


        public List<Asistencia> ReadByAlumno(Asistencia entity)
        {
            AsistenciaDAC personaDAC = new AsistenciaDAC();
            List<Asistencia> result = new List<Asistencia>();
            foreach (Asistencia item in personaDAC.ReadByAlumno(entity))
            {
                AlumnoComponent personaComponent = new AlumnoComponent();
                Alumno alumno = new Alumno();
                alumno= personaComponent.ReadBy(item.persona.Id);
                Asistencia asistencia = new Asistencia(alumno);

                asistencia.Id = item.Id;
                asistencia.asistio = item.asistio;
                asistencia.año = item.año;
                asistencia.dia = item.dia;
                asistencia.mes = item.mes;


                result.Add(asistencia);


            }
            return result;

        }
        public Asistencia ReadBy(string id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Asistencia entity)
        {
            AsistenciaDAC personaDAC = new AsistenciaDAC();
            personaDAC.Update(entity);
            return true;
        }

        public bool Verificar(Asistencia entity)
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
