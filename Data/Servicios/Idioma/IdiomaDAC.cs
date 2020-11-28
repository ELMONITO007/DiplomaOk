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
    public class IdiomaDAC : DataAccessComponent, IRepository2<Idioma>
    {
        public Idioma ALoad(IDataReader entity)
        {

            Idioma palabra = new Idioma();
            palabra.Id = GetDataValue<int>(entity, "Id_Idioma");
            palabra.idioma = GetDataValue<string>(entity, "Idioma");
            return palabra;
        }

        public Idioma Create(Idioma entity)
        {

            const string SQL_STATEMENT = "insert into Idioma(Idioma,activo)values(@Idioma,1)";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Idioma", DbType.String, entity.idioma);

                entity.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }
            return entity;
        }

        public void Delete(int id)
        {
            const string SQL_STATEMENT = "update Idioma set Activo=0 where id_Idioma=@Id";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                db.ExecuteNonQuery(cmd);
            }
        }

        public List<Idioma> Read()
        {
            const string SQL_STATEMENT = "select * from Idioma where  activo=1";

            List<Idioma> result = new List<Idioma>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Idioma roles = ALoad(dr);
                        result.Add(roles);
                    }
                }
            }
            return result;
        }

        public Idioma ReadBy(int id)
        {
            const string SQL_STATEMENT = "select * from Idioma where  activo=1 and id_Idioma=@Id";
            Idioma roles = null;

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

        public Idioma ReadBy(string id)
        {
            const string SQL_STATEMENT = "select * from Idioma where  activo=1 and Idioma=@Id";
            Idioma roles = null;

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

        public void Update(Idioma entity)
        {

            const string SQL_STATEMENT = "update Idioma set Idioma=@Idioma where id_Idioma=@id ";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Idioma", DbType.String, entity.idioma);
                db.AddInParameter(cmd, "@id", DbType.String, entity.Id);
                db.ExecuteNonQuery(cmd);
            }
        }
    }
}
