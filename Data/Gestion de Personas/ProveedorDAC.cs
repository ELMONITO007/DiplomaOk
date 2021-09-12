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


namespace Data.Gestion_de_Infraestructura
{
    public class ProveedorDAC : DataAccessComponent, IRepository2<Proveedor>
    {
        #region Proveedor
        public Proveedor ALoad(IDataReader entity)
        {
            List<Telefono> listaTelefono = new List<Telefono>();
            Telefono telefono = new Telefono();
            string t = GetDataValue<string>(entity, "telefono");
            telefono.numero = int.Parse(t);
            listaTelefono.Add(telefono);
            Proveedor proveedor = new Proveedor(listaTelefono);
            proveedor.Id = GetDataValue<int>(entity, "Id_proveedor");
            proveedor.tipoProveedor = GetDataValue<string>(entity, "TipoProveedor");
            proveedor.matricula = GetDataValue<string>(entity, "matricula");
            proveedor.nombre = GetDataValue<string>(entity, "nombre");
            proveedor.contacto = GetDataValue<string>(entity, "contacto");


            proveedor.cuit = GetDataValue<string>(entity, "cuit");

            return proveedor;
        }

        public Proveedor Create(Proveedor entity)
        {
            const string SQL_STATEMENT = "insert into Proveedor(Id_TipoProveedor,matricula,nombre,telefono,contacto,activo,cuit)values ((select Id_TipoProveedor from  TipoProveedor  where TipoProveedor=@TipoProveedor),@matricula,@nombre,@telefono,@contacto,1,@cuit)";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {

                db.AddInParameter(cmd, "@TipoProveedor", DbType.String, entity.tipoProveedor);

                db.AddInParameter(cmd, "@matricula", DbType.String, entity.matricula);
                db.AddInParameter(cmd, "@nombre", DbType.String, entity.nombre);
                db.AddInParameter(cmd, "@telefono", DbType.String, entity.listaTelefono[0].numero.ToString());
                db.AddInParameter(cmd, "@contacto", DbType.String, entity.contacto);
                db.AddInParameter(cmd, "@cuit", DbType.String, entity.cuit);

                entity.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }
            return entity;
        }

        public void Delete(int id)
        {
            const string SQL_STATEMENT = "update Proveedor set Activo=0 where id_Proveedor=@Id";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                db.ExecuteNonQuery(cmd);
            }
        }

        public List<Proveedor> Read()
        {
            const string SQL_STATEMENT = "select * from Proveedor as p join TipoProveedor as tp on tp.Id_TipoProveedor=p.Id_TipoProveedor where p.activo=1";

            List<Proveedor> result = new List<Proveedor>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Proveedor usuarios = ALoad(dr);
                        result.Add(usuarios);
                    }
                }
            }
            return result;
        }
        public List<Proveedor> ReadByTipo(int tipo)
        {
            const string SQL_STATEMENT = "select * from Proveedor as p join TipoProveedor as tp on tp.Id_TipoProveedor=p.Id_TipoProveedor where activo=1 and id_TipoProveedor=@id";

            List<Proveedor> result = new List<Proveedor>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@id", DbType.Int32, tipo);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Proveedor usuarios = ALoad(dr);
                        result.Add(usuarios);
                    }
                }
            }
            return result;
        }

        public Proveedor ReadBy(int id)
        {
            const string SQL_STATEMENT = "select * from Proveedor as p join TipoProveedor as tp on tp.Id_TipoProveedor=p.Id_TipoProveedor where activo=1 and ID_Proveedor=@ID_TipoSala";

            Proveedor result = null;
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

        public Proveedor ReadBy(string id)
        {
            const string SQL_STATEMENT = "select * from Proveedor as p join TipoProveedor as tp on tp.Id_TipoProveedor=p.Id_TipoProveedor where p.activo=1 and cuit=@ID_TipoSala";

            Proveedor result = null;
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

        public void Update(Proveedor entity)
        {
            const string SQL_STATEMENT = "update Proveedor set Id_TipoProveedor=(select Id_TipoProveedor from  TipoProveedor  where TipoProveedor=@TipoProveedor) ,matricula=@matricula,nombre=@nombre,telefono=@telefono, contacto=@contacto, cuit=@cuit  where ID_Proveedor=@Id ";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@id", DbType.Int32, entity.Id);

                db.AddInParameter(cmd, "@TipoProveedor", DbType.String, entity.tipoProveedor);

                db.AddInParameter(cmd, "@matricula", DbType.String, entity.matricula);
                db.AddInParameter(cmd, "@nombre", DbType.String, entity.nombre);
                db.AddInParameter(cmd, "@telefono", DbType.String, entity.listaTelefono[0].numero.ToString());
                db.AddInParameter(cmd, "@contacto", DbType.String, entity.contacto);
                db.AddInParameter(cmd, "@cuit", DbType.String, entity.cuit);
                db.ExecuteNonQuery(cmd);
            }
        }

        public List<Proveedor> ReadByListado(string id)
        {
            throw new NotImplementedException();
        }
        #endregion


        #region TipoProveedor

        public Proveedor ALoadTipoProveedor(IDataReader entity)
        {
            Proveedor tipoProveedor = new Proveedor();
          tipoProveedor.Id= GetDataValue<int>(entity, "Id_TipoProveedor");
            tipoProveedor.tipoProveedor = GetDataValue<string>(entity, "TipoProveedor");
            return tipoProveedor;
        }

        public Proveedor CreateTipoProveedor(Proveedor entity)
        {
            const string SQL_STATEMENT = "insert into TipoProveedor(tipoProveedor,activo)values (@tipoProveedor,1)";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {

                db.AddInParameter(cmd, "@TipoProveedor", DbType.String, entity.tipoProveedor);




                entity.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }
            return entity;
        }

        public void DeleteTipoProveedor(int id)
        {
            const string SQL_STATEMENT = "update TipoProveedor set Activo=0 where id_TipoProveedor=@Id";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                db.ExecuteNonQuery(cmd);
            }
        }

        public List<Proveedor> ReadTipoProveedor()
        {
            const string SQL_STATEMENT = "select * from TipoProveedor where activo=1";

            List<Proveedor> result = new List<Proveedor>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Proveedor usuarios = ALoadTipoProveedor(dr);
                        result.Add(usuarios);
                    }
                }
            }
            return result;
        }

        public Proveedor ReadByTipoProveedor(string id)
        {
            const string SQL_STATEMENT = "select * from TipoProveedor where activo=1 and TipoProveedor=@TipoProveedor";

            Proveedor result = null;
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@TipoProveedor", DbType.String, id);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        result = ALoadTipoProveedor(dr);

                    }
                }
            }
            return result;
        }
        public Proveedor ReadByTipoProveedor(int id)
        {
            const string SQL_STATEMENT = "select * from TipoProveedor where activo=1 and id_TipoProveedor=@id_TipoProveedor";

            Proveedor result = null;
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@id_TipoProveedor", DbType.Int32, id);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        result = ALoadTipoProveedor(dr);

                    }
                }
            }
            return result;
        }
        public void UpdateTipoProveedor(Proveedor entity)
        {
            const string SQL_STATEMENT = "update TipoProveedor set TipoProveedor=@TipoProveedor  where ID_TipoProveedor=@Id ";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@id", DbType.Int32, entity.Id);

                db.AddInParameter(cmd, "@TipoProveedor", DbType.String, entity.tipoProveedor);
                db.ExecuteNonQuery(cmd);
            }
        }
        #endregion
    }
}
