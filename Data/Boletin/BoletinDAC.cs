using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Data.Gestion_de_Boletin
{
    public class BoletinDAC : DataAccessComponent, IRepository2<Boletin>
    {
        public Boletin ALoad(IDataReader entity)
        {
            Boletin boletin = new Boletin();
            boletin.Id = GetDataValue<int>(entity, "ID_Boletin");
            boletin.año = GetDataValue<int>(entity, "año");
            boletin.cutrimeste = GetDataValue<int>(entity, "Cutrimestre");
            boletin.notas = GetDataValue<string>(entity, "notas");
            boletin.persona.Id = GetDataValue<int>(entity, "legajo");


            return boletin;
        }

        public Boletin Create(Boletin entity)
        {
            const string SQL_STATEMENT = "insert into Boletin(año,Cutrimestre,notas,legajo)values(@año,@cutrimeste,@notas,@legajo)";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@año", DbType.Int32, entity.año);
                db.AddInParameter(cmd, "@cutrimeste", DbType.Int32, entity.cutrimeste);
                db.AddInParameter(cmd, "@notas", DbType.String, entity.notas);
                db.AddInParameter(cmd, "@legajo", DbType.Int32, entity.persona.Id);



                entity.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }
            return entity;
        }

        public void Delete(int id)
        {
            const string SQL_STATEMENT = "delete from Boletin where ID_Boletin=@Id";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                db.ExecuteNonQuery(cmd);
            }
        }

        public List<Boletin> Read()
        {
            const string SQL_STATEMENT = "select * from Boletin ";

            List<Boletin> result = new List<Boletin>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Boletin usuarios = ALoad(dr);
                        result.Add(usuarios);
                    }
                }
            }
            return result;
        }

        public Boletin ReadBy(int id)
        {
            const string SQL_STATEMENT = "select * from Boletin where  ID_Boletin=@ID_Boletin";

            Boletin result = null;
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@ID_Boletin", DbType.Int32, id);
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
        public List<Boletin> ReadByAlumnoYAño(Boletin entity)
        {
            const string SQL_STATEMENT = "select * from Boletin where legajo=@legajo and año=@año ";

            List<Boletin> result = new List<Boletin>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "legajo", DbType.Int32, entity.persona.Id);
                db.AddInParameter(cmd, "@año", DbType.Int32, entity.año);


                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Boletin usuarios = ALoad(dr);
                        result.Add(usuarios);
                    }
                }
            }
            return result;
        }
        public Boletin ReadBy(string id)
        {
            throw new NotImplementedException();
        }
        public Boletin ReadBy(Boletin entity)
        {
            const string SQL_STATEMENT = "select * from Boletin where legajo=@legajo and año=@año and Cutrimestre=@Cutrimestre ";

            Boletin result = null;
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@legajo", DbType.Int32, entity.persona.Id);
                db.AddInParameter(cmd, "@año", DbType.Int32, entity.año);
                db.AddInParameter(cmd, "@Cutrimestre", DbType.Int32, entity.cutrimeste);

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
        public void Update(Boletin entity)
        {
            throw new NotImplementedException();
        }

        public List<Boletin> ReadByListado(string id)
        {
            throw new NotImplementedException();
        }
    }
}
