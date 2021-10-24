using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Entitites.Negocio.Personas;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Data.Gestion_de_Boletin
{
    public class ExamenDAC : DataAccessComponent, IRepository2<Examen>
    {
        public Examen ALoad(IDataReader entity)
        {
            Materia materia = new Materia();
            materia.Id= GetDataValue<int>(entity, "ID_materia");
            Alumno alumno = new Alumno();
            alumno.Id = GetDataValue<int>(entity, "legajo");
            Examen examen = new Examen(alumno,materia);
            examen.Id = GetDataValue<int>(entity, "ID_examen");
       
            examen.fecha = GetDataValue<DateTime>(entity, "fecha");
            examen.nota = GetDataValue<int>(entity, "nota");
          


            return examen;
        }
        public Materia ALoadMateria(IDataReader entity)
        {
            Materia examen = new Materia();
            examen.materia = GetDataValue<string>(entity, "Materia");


            return examen;
        }
        public Examen Create(Examen entity)
        {
            const string SQL_STATEMENT = "insert into Examen(fecha,nota,ID_materia,legajo)values(@fecha,@nota,@materia,@legajo)";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@fecha", DbType.Date, entity.fecha);
                db.AddInParameter(cmd, "@nota", DbType.Int32, entity.nota);
                db.AddInParameter(cmd, "@materia", DbType.Int32, entity.materia.Id);
                db.AddInParameter(cmd, "@legajo", DbType.Int32, entity.persona.Id);



                entity.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }
            return entity;
        }

        public void Delete(int id)
        {
            const string SQL_STATEMENT = "delete from Examen where ID_Examen=@Id";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                db.ExecuteNonQuery(cmd);
            }
        }

        public List<Examen> Read()
        {
            const string SQL_STATEMENT = "select * from Examen ";

            List<Examen> result = new List<Examen>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Examen usuarios = ALoad(dr);
                        result.Add(usuarios);
                    }
                }
            }
            return result;
        }

        public Examen ReadBy(int id)
        {
            const string SQL_STATEMENT = "select * from Examen where  ID_Examen=@ID_Examen";

            Examen result = null;
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@ID_Examen", DbType.Int32, id);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        result = ALoad(dr);

                    }
                }
            }
            return result;
        }

        public List<Examen> ReadByAlumnoYAño(Examen entity, DateTime fi, DateTime ff)
        {
            const string SQL_STATEMENT = "select * from Examen where Legajo= @Legajo and Fecha>=@fi and Fecha<=@ff ";

            List<Examen> result = new List<Examen>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Legajo", DbType.Int32, entity.persona.Id);
                db.AddInParameter(cmd, "@fi", DbType.DateTime, fi);
                db.AddInParameter(cmd, "@ff", DbType.DateTime, ff);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Examen usuarios = ALoad(dr);
                        result.Add(usuarios);
                    }
                }
            }
            return result;
        }
        public List<Examen> ReadByAlumnoYAñoUnique(Examen entity, DateTime fi, DateTime ff)
        {
            const string SQL_STATEMENT = "select distinct Id_Materia,Id_Examen,Legajo,Fecha,Nota  from Examen where Legajo= @Legajo and Fecha>=@fi and Fecha<=@ff ";

            List<Examen> result = new List<Examen>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Legajo", DbType.Int32, entity.persona.Id);
                db.AddInParameter(cmd, "@fi", DbType.DateTime, fi);
                db.AddInParameter(cmd, "@ff", DbType.DateTime, ff);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Examen usuarios = ALoad(dr);
                        result.Add(usuarios);
                    }
                }
            }
            return result;
        }
        public List<Materia> ReadByAlumnoYMateria(int legajo, DateTime fi, DateTime ff)
        {
            const string SQL_STATEMENT = "select distinct materia from Examen as e join Materia as m on m.ID_Materia=e.Id_Materia where Legajo=@Legajo and Fecha>=@fi and Fecha<=@ff  ";

            List<Materia> result = new List<Materia>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Legajo", DbType.Int32, legajo);
                db.AddInParameter(cmd, "@fi", DbType.DateTime, fi);
                db.AddInParameter(cmd, "@ff", DbType.DateTime, ff);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Materia usuarios = ALoadMateria(dr);
                        result.Add(usuarios);
                    }
                }
            }
            return result;
        }

        public Examen ReadBy(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(Examen entity)
        {
            const string SQL_STATEMENT = "update Examen set nota=@asistio nota ID_Examen=@Id ";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@id", DbType.Int32, entity.Id);
                db.AddInParameter(cmd, "@asistio", DbType.String, entity.nota);
                db.ExecuteNonQuery(cmd);
            }
        }

        public List<Examen> ReadByListado(string id)
        {
            throw new NotImplementedException();
        }
    }
}
