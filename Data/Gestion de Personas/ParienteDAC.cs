using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Data
{
    public class ParienteDAC : DataAccessComponent, IRepository2<Pariente>
    {
        public Pariente ALoad(IDataReader entity)
        {
            Pariente palabra = new Pariente();
            palabra.Id = GetDataValue<int>(entity, "Id_Parentesco");
            palabra.alumno.Id = GetDataValue<int>(entity, "Legajo_Alumno");
            palabra.adulto.Id = GetDataValue<int>(entity, "Legajo_Adulto");

            palabra.parentesco = GetDataValue<string>(entity, "Parentesco");

            palabra.autorizadoRetirar = GetDataValue<bool>(entity, "AutorizadoRetirar");




            return palabra;
        }

        public Parentesco Create(Parentesco entity)
        {
            const string SQL_STATEMENT = "insert into Parentesco(Legajo_Alumno,Legajo_Adulto,autorizadoRetirar,parentesco)values (@alumno,@adulto,@autorizadoRetirar,@parentesco)";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@alumno", DbType.Int32, entity.alumno.Id);
                db.AddInParameter(cmd, "@adulto", DbType.Int32, entity.adulto.Id);

                db.AddInParameter(cmd, "@autorizadoRetirar", DbType.Boolean, entity.autorizadoRetirar);
                db.AddInParameter(cmd, "@parentesco", DbType.String, entity.parentesco);



                entity.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }
            return entity;
        }

        public void Delete(int id)
        {
            const string SQL_STATEMENT = "Delete from Parentesco where Id_Parentesco=@Id";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                db.ExecuteNonQuery(cmd);
            }
        }


        public List<Parentesco> Read()
        {
            const string SQL_STATEMENT = "select * from Parentesco ";

            List<Parentesco> result = new List<Parentesco>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Parentesco roles = ALoad(dr);
                        result.Add(roles);
                    }
                }
            }
            return result;
        }

        public Parentesco ReadBy(int id)
        {
            const string SQL_STATEMENT = "select * from Parentesco where  Id_Parentesco=@Id";
            Parentesco roles = null;

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

        public Parentesco ReadBy(string id)
        {
            throw new NotImplementedException();
        }
        public Parentesco ReadBy(Parentesco entity)
        {
            const string SQL_STATEMENT = "select * from Parentesco where Legajo_Alumno=@Legajo_Alumno  and  Legajo_Adulto=@Legajo_Adulto";

            Parentesco result = null;
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Legajo_Alumno", DbType.Int32, entity.alumno.Id);
                db.AddInParameter(cmd, "@Legajo_Adulto", DbType.Int32, entity.adulto.Id);
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
        public List<Parentesco> ReadByAlumno(int id)
        {
            const string SQL_STATEMENT = "select * from Parentesco where Legajo_Alumno=@Legajo_Alumno ";

            List<Parentesco> result = new List<Parentesco>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Legajo_Alumno", DbType.Int32, id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Parentesco roles = ALoad(dr);
                        result.Add(roles);
                    }
                }
            }
            return result;
        }
        public List<Parentesco> ReadByAdulto(int id)
        {
            const string SQL_STATEMENT = "select * from Parentesco where Legajo_Adulto=@Legajo_Adulto ";

            List<Parentesco> result = new List<Parentesco>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Legajo_Adulto", DbType.Int32, id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Parentesco roles = ALoad(dr);
                        result.Add(roles);
                    }
                }
            }
            return result;
        }
        public void Update(Parentesco entity)
        {
            const string SQL_STATEMENT = "update Parentesco set AutorizadoRetirar=@AutorizadoRetirar, Parentesco=@Parentesco where Id_Parentesco=@id ";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@AutorizadoRetirar", DbType.Boolean, entity.autorizadoRetirar);
                db.AddInParameter(cmd, "@Parentesco", DbType.String, entity.parentesco);
                db.AddInParameter(cmd, "@id", DbType.String, entity.Id);
                db.ExecuteNonQuery(cmd);
            }
        }

    }
}
