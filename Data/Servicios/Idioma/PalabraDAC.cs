using Entities;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
  public  class PalabraDAC :DataAccessComponent,IRepository2<Palabra>
    {
        public Palabra ALoad(IDataReader entity)
        {
            Palabra palabra = new Palabra();
            palabra.Id= GetDataValue<int>(entity, "Id_Palabra");
            palabra.palabra = GetDataValue<string>(entity, "palabra");
            return palabra;
        }

        public Palabra Create(Palabra entity)
        {

            const string SQL_STATEMENT = "insert into palabra(palabra,activo)values(@palabra,1)";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@palabra", DbType.String, entity.palabra);

                entity.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }
            return entity;

        }

        public void Delete(int id)
        {
            const string SQL_STATEMENT = "update palabra set Activo=0 where id_palabra=@Id";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                db.ExecuteNonQuery(cmd);
            }
        }

        public List<Palabra> Read()
        {
            const string SQL_STATEMENT = "select * from palabra where  activo=1";

            List<Palabra> result = new List<Palabra>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Palabra roles = ALoad(dr);
                        result.Add(roles);
                    }
                }
            }
            return result;
        }

        public Palabra ReadBy(int id)
        {

            const string SQL_STATEMENT = "select * from palabra where  activo=1 and id_palabra=@Id";
            Palabra roles = null;

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

        public Palabra ReadBy(string id)
        {
            const string SQL_STATEMENT = "select * from palabra where  activo=1 and palabra=@Id";
            Palabra roles = null;

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

        public List<Palabra> ReadByListado(string id)
        {
            const string SQL_STATEMENT = "select * from palabra where  activo=1 and palabra=@Id";

            List<Palabra> result = new List<Palabra>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.String, id);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Palabra roles = ALoad(dr);
                        result.Add(roles);
                    }
                }
            }
            return result;
        }

        public void Update(Palabra entity)
        {

            const string SQL_STATEMENT = "update Palabra set Palabra=@Palabra where id_Palabra=@id ";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Palabra", DbType.String, entity.palabra);
                db.AddInParameter(cmd, "@id", DbType.String, entity.Id);
                db.ExecuteNonQuery(cmd);
            }
        }
    }
    }

