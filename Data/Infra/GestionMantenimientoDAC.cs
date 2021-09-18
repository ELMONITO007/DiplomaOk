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


namespace Data
{


    public class GestionMantenimientoDAC : DataAccessComponent, IRepository2<GestionMantenimiento>
    {
        public GestionMantenimiento ALoad(IDataReader entity)
        {
            Proveedor proveedor = new Proveedor();
            proveedor.Id= GetDataValue<int>(entity, "Id_TipoProveedor");
            GestionMantenimiento tipoMantenimiento = new GestionMantenimiento(proveedor);
            tipoMantenimiento.Id = GetDataValue<int>(entity, "Id_TipoMantenimiento");
       
            tipoMantenimiento.periocidad = GetDataValue<int>(entity, "periocidad");
            tipoMantenimiento.tipoMantenimiento = GetDataValue<string>(entity, "tipoMantenimiento");

            return tipoMantenimiento;
        }

        public GestionMantenimiento Create(GestionMantenimiento entity)
        {
            const string SQL_STATEMENT = "insert into TipoMantenimiento(id_tipoProveedor,periocidad,tipoMantenimiento,activo)values (@tipoProveedor,@periocidad,@tipoMantenimiento,1)";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {

                db.AddInParameter(cmd, "@tipoProveedor", DbType.Int32, entity.proveedor.Id);

                db.AddInParameter(cmd, "@periocidad", DbType.Int32, entity.periocidad);
                db.AddInParameter(cmd, "@tipoMantenimiento", DbType.String, entity.tipoMantenimiento);

                entity.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }
            return entity;
        }

        public void Delete(int id)
        {
            const string SQL_STATEMENT = "update TipoMantenimiento set Activo=0 where id_TipoMantenimiento=@Id";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                db.ExecuteNonQuery(cmd);
            }
        }

        public List<GestionMantenimiento> Read()
        {
            const string SQL_STATEMENT = "select * from TipoMantenimiento where activo=1";

            List<GestionMantenimiento> result = new List<GestionMantenimiento>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        GestionMantenimiento usuarios = ALoad(dr);
                        result.Add(usuarios);
                    }
                }
            }
            return result;
        }

        public GestionMantenimiento ReadBy(int id)
        {
            const string SQL_STATEMENT = "select * from TipoMantenimiento where activo=1 and ID_TipoMantenimiento=@ID_TipoSala";

            GestionMantenimiento result = null;
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

        public GestionMantenimiento ReadBy(string id)
        {
            const string SQL_STATEMENT = "select * from TipoMantenimiento where activo=1 and TipoMantenimiento=@ID_TipoSala";

            GestionMantenimiento result = null;
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@ID_TipoSala", DbType.String, id);
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

        public List<GestionMantenimiento> ReadByListado(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(GestionMantenimiento entity)
        {
            const string SQL_STATEMENT = "update TipoMantenimiento set TipoMantenimiento=@TipoMantenimiento, Periocidad=@Periocidad  where ID_TipoMantenimiento=@Id ";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@id", DbType.Int32, entity.Id);
                db.AddInParameter(cmd, "@Periocidad", DbType.String, entity.periocidad);
                db.AddInParameter(cmd, "@TipoMantenimiento", DbType.String, entity.tipoMantenimiento);
                db.ExecuteNonQuery(cmd);
            }
        }
    }
}

