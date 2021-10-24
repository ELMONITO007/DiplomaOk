using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Entitites;
using Entitites.Negocio.Personas;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Data.Gestion_de_Boletin
{
    public class ComunicadoDAC : DataAccessComponent, IRepository2<Comunicado>
    {
        public Comunicado ALoad(IDataReader entity)
        {
            Maestro maestro = new Maestro();
            maestro.Id = GetDataValue<int>(entity, "legajo_Maestro");

            Alumno alumno = new Alumno();
            alumno.Id = GetDataValue<int>(entity, "legajo");
            Comunicado comunicado = new Comunicado(maestro,alumno);

            comunicado.Id = GetDataValue<int>(entity, "ID_Cominicado");
          
            comunicado.comunicado = GetDataValue<string>(entity, "comunicado");
            comunicado.fecha = GetDataValue<DateTime>(entity, "fecha");
            comunicado.visto = GetDataValue<bool>(entity, "visto");
            


            return comunicado;
        }

        public Comunicado Create(Comunicado entity)
        {
            const string SQL_STATEMENT = "insert into Comunicado(comunicado,fecha,Visto,legajo,legajo_Maestro,activo)values(@comunicado,@fecha,@Visto,@legajo,@legajo_Maestro,1)";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@comunicado", DbType.String, entity.comunicado);
                db.AddInParameter(cmd, "@fecha", DbType.Date, entity.fecha);
                db.AddInParameter(cmd, "@Visto", DbType.Int32, entity.visto);
                db.AddInParameter(cmd, "@legajo", DbType.Int32, entity.persona.Id);

                db.AddInParameter(cmd, "@legajo_Maestro", DbType.Int32, entity.maestro.Id);


                entity.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }
            return entity;
        }

        public void Delete(int id)
        {
            const string SQL_STATEMENT = "update  comunicado set activo= 0 where ID_Cominicado=@Id";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                db.ExecuteNonQuery(cmd);
            }
        }

        public List<Comunicado> Read()
        {
            const string SQL_STATEMENT = "select * from Comunicado where activo=1 ";

            List<Comunicado> result = new List<Comunicado>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Comunicado usuarios = ALoad(dr);
                        result.Add(usuarios);
                    }
                }
            }
            return result;
        }

        public Comunicado ReadBy(int id)
        {
            const string SQL_STATEMENT = "select * from Comunicado where  ID_Cominicado=@ID_Comunicado and activo=1";

            Comunicado result = null;
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@ID_Comunicado", DbType.Int32, id);
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


        public List<Comunicado> ReadByAlumnoYaño(int legajo, DateTime año, DateTime añoFin)
        {
            const string SQL_STATEMENT = "select * from Comunicado where activo=1 and legajo=@legajo and fecha>=@año and fecha<=@añofin";

            List<Comunicado> result = new List<Comunicado>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@legajo", DbType.Int32, legajo);
                db.AddInParameter(cmd, "@año", DbType.Date, año);
                db.AddInParameter(cmd, "@añoFin", DbType.Date, añoFin);


                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Comunicado usuarios = ALoad(dr);
                        result.Add(usuarios);
                    }
                }
            }
            return result;
        }
        public Comunicado ReadBy(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(Comunicado entity)
        {
            const string SQL_STATEMENT = "update Comunicado set Comunicado=@Comunicado where ID_Cominicado=@Id ";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@id", DbType.Int32, entity.Id);
                db.AddInParameter(cmd, "@Comunicado", DbType.String, entity.comunicado);
                db.ExecuteNonQuery(cmd);
            }
        }
        public void Update(int id_comunicado)
        {
            const string SQL_STATEMENT = "update Comunicado set visto=1 where ID_Cominicado=@Id ";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@id", DbType.Int32, id_comunicado);

                db.ExecuteNonQuery(cmd);
            }
        }

        public List<Comunicado> ReadByListado(string id)
        {
            throw new NotImplementedException();
        }
    }
}
