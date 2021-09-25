using Entities;
using Entitites.Negocio.Personas;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Gestion_de_Personas
{
 public   class AlumnoDAC : DataAccessComponent, IRepository2<Alumno>
    {

        public Alumno ALoad(IDataReader entity)
        {
            Alumno palabra = new Alumno();
            palabra.Id = GetDataValue<int>(entity, "legajo");
            palabra.nombre = GetDataValue<string>(entity, "nombre");
            palabra.apellido = GetDataValue<string>(entity, "apellido");
            palabra.DNI = GetDataValue<string>(entity, "DNI");
            palabra.direccion = GetDataValue<string>(entity, "direccion");
            palabra.fechaNacimiento = GetDataValue<DateTime>(entity, "fechaNacimiento");
            palabra.tipoPersona= GetDataValue<string>(entity, "Tipo_Persona");

            palabra.nombreCompleto = palabra.nombre + " " + palabra.apellido;
            return palabra;
        }

        public Alumno Create(Alumno entity)
        {
            const string SQL_STATEMENT = "insert into Persona(nombre,apellido,direccion,DNI,Tipo_Persona,fechaNacimiento,activo)values(@nombre,@apellido,@direccion,@DNI,@tipoPersona,@fechaNacimiento,1)";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@nombre", DbType.String, entity.nombre);
                db.AddInParameter(cmd, "@apellido", DbType.String, entity.apellido);
                db.AddInParameter(cmd, "@direccion", DbType.String, entity.direccion);
                db.AddInParameter(cmd, "@DNI", DbType.String, entity.DNI);
                db.AddInParameter(cmd, "@tipoPersona", DbType.String,"Alumno");
                db.AddInParameter(cmd, "@fechaNacimiento", DbType.DateTime, entity.fechaNacimiento);
                entity.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }
            return entity;
        }

        public void Delete(int id)
        {
            const string SQL_STATEMENT = "update Persona set Activo=0 where Legajo=@Id";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                db.ExecuteNonQuery(cmd);
            }
        }

        public List<Alumno> Read()
        {
            const string SQL_STATEMENT = "SELECT * from Persona where Tipo_Persona='Alumno'";

            List<Alumno> result = new List<Alumno>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Alumno roles = ALoad(dr);
                        result.Add(roles);
                    }
                }
            }
            return result;
        }

      
        public Alumno ReadBy(int id)
        {
            const string SQL_STATEMENT = "SELECT * from Persona where Tipo_Persona='Alumno' and  activo=1 and Legajo=@Id";
            Alumno roles = null;

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        roles = ALoad(dr);
                    }
                }
            }
            return roles;
        }



        public Alumno ReadBy(string id)
        {
            const string SQL_STATEMENT = "select * from Persona where  activo=1 and dni=@Id";
            Alumno roles = null;

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.String, id);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        roles = ALoad(dr);
                    }
                }
            }
            return roles;
        }
        public List<Alumno> ReadByFechaNacimiento(DateTime fechaInicio, DateTime fechaFinal)
        {
            const string SQL_STATEMENT = "select * from Persona where Tipo_Persona='alumno' and  fechaNacimiento BETWEEN @fechaInicio AND @fechaFinal and Activo=1";

            List<Alumno> result = new List<Alumno>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@fechaInicio", DbType.Date, fechaInicio);
                db.AddInParameter(cmd, "@fechaFinal", DbType.Date, fechaFinal);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Alumno roles = ALoad(dr);
                        result.Add(roles);
                    }
                }
            }
            return result;
        }
        public List<Alumno> ObtenerAlumnodeCunCurso(int id_curso)
        {
            const string SQL_STATEMENT = "select * from CursoAlumno as ca join Persona as p on p.Legajo =ca.Legajo where Tipo_Persona='Alumno' and ca.ID_Curso=@id_curso and p.Activo=1";

            List<Alumno> result = new List<Alumno>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@id_curso", DbType.Int32, id_curso);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Alumno roles = ALoad(dr);
                        result.Add(roles);
                    }
                }
            }
            return result;
        }
        public void Update(Alumno entity)
        {
            const string SQL_STATEMENT = "update Persona set nombre=@nombre, apellido=@apellido, direccion=@direccion, DNI=@DNI,  fechaNacimiento=@fechaNacimiento  where legajo=@id ";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@nombre", DbType.String, entity.nombre);
                db.AddInParameter(cmd, "@apellido", DbType.String, entity.apellido);
                db.AddInParameter(cmd, "@direccion", DbType.String, entity.direccion);
                db.AddInParameter(cmd, "@DNI", DbType.String, entity.DNI);
          
                db.AddInParameter(cmd, "@fechaNacimiento", DbType.DateTime, entity.fechaNacimiento);
                db.AddInParameter(cmd, "@id", DbType.String, entity.Id);
                db.ExecuteNonQuery(cmd);
            }
        }

        public List<Alumno> ReadByListado(string id)
        {
            throw new NotImplementedException();
        }

        public List<Alumno> ReadByAño(int año)
        {
            const string SQL_STATEMENT = "select * from CursoAlumno as ca join Persona as p on p.Legajo=ca.Legajo join Curso as c on c.ID_Curso=ca.ID_Curso join Sala_Horario as sh on sh.ID_SalaHorario=c.id_salaHorario where Año=@año and Tipo_Persona='Alumno'";

            List<Alumno> result = new List<Alumno>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {

                db.AddInParameter(cmd, "@año", DbType.Int32, año);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Alumno usuarios = ALoad(dr);
                        result.Add(usuarios);
                    }
                }
            }
            return result;
        }
    }
}
