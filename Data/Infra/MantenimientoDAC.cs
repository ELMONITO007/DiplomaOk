using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Microsoft.Practices.EnterpriseLibrary.Data;
namespace Data.Gestion_de_Infraestructura
{
    public class MantenimientoDAC : DataAccessComponent, IRepository2<Mantenimiento>
    {
        public Mantenimiento ALoad(IDataReader entity)
        {
            Mantenimiento mantenimiento = new Mantenimiento();
            mantenimiento.Id = GetDataValue<int>(entity, "Id_mantenimiento");
            mantenimiento.tipoMantenimiento.Id = GetDataValue<int>(entity, "Id_tipoMantenimiento");
      
            mantenimiento.fecha = GetDataValue<DateTime>(entity, "fecha");
            mantenimiento.fechaRealizado = GetDataValue<DateTime>(entity, "fechaRealizado");

            mantenimiento.Realizado = GetDataValue<bool>(entity, "Realizado");
            mantenimiento.proveedor.Id = GetDataValue<int>(entity, "ID_Proveedor");


            return mantenimiento;
        }

        public Mantenimiento Create(Mantenimiento entity)
        {
            const string SQL_STATEMENT = "insert into Mantenimiento(Id_tipoMantenimiento,legajo,fecha,Realizado,ID_Proveedor,activo)values (@Id_tipoMantenimiento,@legajo,@fecha,0,@ID_Proveedor,1)";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {

                db.AddInParameter(cmd, "@Id_tipoMantenimiento", DbType.Int32, entity.tipoMantenimiento.Id);

                db.AddInParameter(cmd, "@ID_Proveedor", DbType.String, entity.proveedor.Id);
                db.AddInParameter(cmd, "@fecha", DbType.DateTime, entity.fecha);


                entity.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }
            return entity;
        }

        public void Delete(int id)
        {
            const string SQL_STATEMENT = "update Mantenimiento set Activo=0 where id_Mantenimiento=@Id";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                db.ExecuteNonQuery(cmd);
            }
        }

        public List<Mantenimiento> Read()
        {
            const string SQL_STATEMENT = "select * from Mantenimiento where activo=1";

            List<Mantenimiento> result = new List<Mantenimiento>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Mantenimiento usuarios = ALoad(dr);
                        result.Add(usuarios);
                    }
                }
            }
            return result;
        }

        public List<Mantenimiento> ReadBySinRealizar()
        {
            const string SQL_STATEMENT = "select * from Mantenimiento where activo=1 and realizar=0";

            List<Mantenimiento> result = new List<Mantenimiento>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Mantenimiento usuarios = ALoad(dr);
                        result.Add(usuarios);
                    }
                }
            }
            return result;
        }


        public Mantenimiento ReadBy(int id)
        {
            const string SQL_STATEMENT = "select * from Mantenimiento where activo=1 and ID_Mantenimiento=@ID_TipoSala";

            Mantenimiento result = null;
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@ID_TipoSala", DbType.Int32, id);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        result = ALoad(dr);

                    }
                }
            }
            return result;
        }

        public Mantenimiento ReadBy(string id)
        {
            const string SQL_STATEMENT = "select * from Mantenimiento where activo=1 and ID_Mantenimiento=@ID_TipoSala";

            Mantenimiento result = null;
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@ID_TipoSala", DbType.Int32, id);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        result = ALoad(dr);

                    }
                }
            }
            return result;
        }

        public void Update(Mantenimiento entity)
        {
            const string SQL_STATEMENT = "update Mantenimiento set FechaRealizado=@FechaRelizado ,Realizado=1  where ID_Mantenimiento=@Id ";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@id", DbType.Int32, entity.Id);

                db.AddInParameter(cmd, "@FechaRelizado", DbType.Date, entity.fechaRealizado);


                db.ExecuteNonQuery(cmd);
            }
        }

        public List<Mantenimiento> ReadByListado(string id)
        {
            throw new NotImplementedException();
        }
    }
}
