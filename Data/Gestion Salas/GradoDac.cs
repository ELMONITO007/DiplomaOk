using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Entitites.Negocio.Salas;
using Microsoft.Practices.EnterpriseLibrary.Data;
namespace Data
{
    public class GradoDAC : DataAccessComponent, IRepository2<Grado>
    {
        public Grado ALoad(IDataReader entity)
        {
            Grado grado = new Grado();
            grado.Id = GetDataValue<int>(entity, "ID_Grado");
            grado.año = GetDataValue<int>(entity, "año");
            grado.nombre = GetDataValue<string>(entity, "nombre");
            return grado;

        }

        public Grado Create(Grado entity)
        {
            const string SQL_STATEMENT = "insert into Grado(año,nombre,activo)values (@año,@nombre,1)";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {

                db.AddInParameter(cmd, "@año", DbType.Int32, entity.año);
                db.AddInParameter(cmd, "@nombre", DbType.String, entity.nombre);


                entity.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }
            return entity;
        }

        public void Delete(int id)
        {
            const string SQL_STATEMENT = "update Grado set Activo=0 where id_Grado=@Id";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                db.ExecuteNonQuery(cmd);
            }
        }

        public List<Grado> Read()
        {
            const string SQL_STATEMENT = "select * from Grado where activo=1 ";

            List<Grado> result = new List<Grado>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);

            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                ;
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Grado roles = ALoad(dr);
                        result.Add(roles);
                    }
                }
            }
            return result;
        }

        public Grado ReadBy(int id)
        {
            const string SQL_STATEMENT = "select * from Grado where activo=1 and  ID_Grado=@Id";
            Grado roles = null;

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

        public Grado ReadBy(string id)
        {
            const string SQL_STATEMENT = "select * from Grado where activo=1 and  nombre=@Id";
            Grado roles = null;

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

        public List<Grado> ReadByListado(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(Grado entity)
        {
            const string SQL_STATEMENT = "update Grado set nombre=@nombre, año=@año  where ID_Grado=@Id ";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@id", DbType.Int32, entity.Id);

                db.AddInParameter(cmd, "@año", DbType.Int32, entity.año);
                db.AddInParameter(cmd, "@nombre", DbType.String, entity.nombre);
                db.ExecuteNonQuery(cmd);
            }
        }
    }
}
