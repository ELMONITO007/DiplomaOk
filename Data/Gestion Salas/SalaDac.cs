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
    public class SalaDac : DataAccessComponent, IRepository2<Sala>
    {
        public Sala ALoad(IDataReader entity)
        {
            Sala sala = new Sala();
            sala.Id = GetDataValue<int>(entity, "Id_Sala");
            sala.capacidad = GetDataValue<int>(entity, "capacidad");
            sala.tiempo = GetDataValue<bool>(entity, "tiempo");
            sala.tipoSala = GetDataValue<string>(entity, "TipoSala");
            sala.nombre = GetDataValue<string>(entity, "nombre");
            return sala;
        }
        public Sala ALoadTipoSala(IDataReader entity)
        {
            Sala sala = new Sala();
            sala.Id = GetDataValue<int>(entity, "Id_TipoSala");
         
            sala.tipoSala = GetDataValue<string>(entity, "TipoSala");
     
            return sala;
        }

        public Sala Create(Sala entity)
        {
            const string SQL_STATEMENT = "insert into sala(Id_TipoSala,capacidad,tiempo,nombre,activo)values ((select Id_TipoSala from TipoSala where TipoSala=@Id_TipoSala),@capacidad,@tiempo,@nombre,1)";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {

                db.AddInParameter(cmd, "@Id_TipoSala", DbType.String, entity.tipoSala);
                db.AddInParameter(cmd, "@capacidad", DbType.Int32, entity.capacidad);
                db.AddInParameter(cmd, "@tiempo", DbType.Int32, entity.tiempo);

                db.AddInParameter(cmd, "@nombre", DbType.String, entity.nombre);



                entity.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }
            return entity;
        }

        public void Delete(int id)
        {
            const string SQL_STATEMENT = "update sala set Activo=0 where id_sala=@Id";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                db.ExecuteNonQuery(cmd);
            }
        }

        public List<Sala> Read()
        {
            const string SQL_STATEMENT = "select  * from  sala as s join TipoSala as tp on tp.Id_TipoSala=s.ID_TipoSala   where activo=1";

            List<Sala> result = new List<Sala>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Sala usuarios = ALoad(dr);
                        result.Add(usuarios);
                    }
                }
            }
            return result;
        }

        public List<Sala> ReadTipoSala()
        {
            const string SQL_STATEMENT = "select  * from  TipoSala ";

            List<Sala> result = new List<Sala>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Sala usuarios = ALoadTipoSala(dr);
                        result.Add(usuarios);
                    }
                }
            }
            return result;
        }
        public List<Sala> ReadByTipo(string id)
        {
            const string SQL_STATEMENT = "select * from Sala where activo=1 and TipoSala=@ID_TipoSala";

            List<Sala> result = new List<Sala>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@TipoSala", DbType.Int32, id);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Sala usuarios = ALoad(dr);
                        result.Add(usuarios);
                    }
                }
            }
            return result;
        }
        public Sala ReadBy(int id)
        {
            const string SQL_STATEMENT = "select  * from  sala as s join TipoSala as tp on tp.Id_TipoSala=s.ID_TipoSala where activo=1 and id_sala=@Id";
            Sala usuarios = null;

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        usuarios = ALoad(dr);
                    }
                }
            }
            return usuarios;
        }

        public Sala ReadBy(string id)
        {
            const string SQL_STATEMENT = "select  * from  sala as s join TipoSala as tp on tp.Id_TipoSala=s.ID_TipoSala where activo=1 and nombre=@Id";
            Sala usuarios = null;

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.String, id);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        usuarios = ALoad(dr);
                    }
                }
            }
            return usuarios;
        }

        public void Update(Sala entity)
        {
            const string SQL_STATEMENT = "update Sala set Id_TipoSala=(select Id_TipoSala from TipoSala where TipoSala=@Id_TipoSala),capacidad=@capacidad,tiempo=@tiempo,nombre=@nombre  where ID_sala=@Id ";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@id", DbType.Int32, entity.Id);


                db.AddInParameter(cmd, "@Id_TipoSala", DbType.String, entity.tipoSala);
                db.AddInParameter(cmd, "@capacidad", DbType.Int32, entity.capacidad);
                db.AddInParameter(cmd, "@tiempo", DbType.Int32, entity.tiempo);

                db.AddInParameter(cmd, "@nombre", DbType.String, entity.nombre);
                db.ExecuteNonQuery(cmd);
            }
        }

        public List<Sala> ReadByListado(string id)
        {
            throw new NotImplementedException();
        }
    }
}
