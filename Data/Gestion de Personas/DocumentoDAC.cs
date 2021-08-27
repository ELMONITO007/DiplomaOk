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
    public class DocumentacionDAC : DataAccessComponent, IRepository2<Documento>
    {
        public Documento ALoad(IDataReader entity)
        {
            Documento palabra = new Documento();
            palabra.persona.Id = GetDataValue<int>(entity, "Legajo");
            palabra.Id = GetDataValue<int>(entity, "ID_Documentacion");
            palabra.año = GetDataValue<int>(entity, "año");
            palabra.tipo_Documentancion = GetDataValue<string>(entity, "TipoDocumentacion");

            palabra.NombreDocumento = GetDataValue<string>(entity, "NombreDocumento");




            return palabra;
        }

        public Documento Create(Documento entity)
        {
            const string SQL_STATEMENT = "insert into Documentacion(legajo,ID_TipoDocumentacion,NombreDocumento,año)values (@legajo,(select ID_TipoDocumentacion from TipoDocumentacion where TipoDocumentacion=@TipoDocumentacion),@NombreDocumento,@año)";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@año", DbType.Int32, entity.año);
                db.AddInParameter(cmd, "@legajo", DbType.Int32, entity.persona.Id);
                db.AddInParameter(cmd, "@TipoDocumentacion", DbType.String, entity.tipo_Documentancion);
                db.AddInParameter(cmd, "@NombreDocumento", DbType.String, entity.NombreDocumento);



                entity.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }
            return entity;
        }

        public void Delete(int id)
        {
            const string SQL_STATEMENT = "update Documentacion set activo=0 where ID_Documentacion=@Id";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                db.ExecuteNonQuery(cmd);
            }
        }

        public List<Documento> Read()
        {
            throw new NotImplementedException();
        }
        public List<Documento> ReadByAlumno(int legajoAlumno)
        {

            const string SQL_STATEMENT = "select * from Documentacion where  activo=1 and legajo=@Id";

            List<Documento> result = new List<Documento>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);

            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, legajoAlumno);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Documento roles = ALoad(dr);
                        result.Add(roles);
                    }
                }
            }
            return result;
        }
        public Documento ReadBy(int id)
        {
            throw new NotImplementedException();
        }

        public Documento ReadBy(string id)
        {
            throw new NotImplementedException();
        }
        public Documento ReadBy(Documentacion entity)
        {
            const string SQL_STATEMENT = "select * from Documentacion where  legajo=@Id and ID_Documentacion=@Id";
            Documento roles = null;

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, entity.Id);
                db.AddInParameter(cmd, "@legajo", DbType.Int32, entity.persona.Id);
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
        public void Update(Documento entity)
        {
            const string SQL_STATEMENT = "update Documentacion set legajo=@legajo, NombreDocumento=@NombreDocumento  where ID_Documentacion=@Id ";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@id", DbType.Int32, entity.Id);
                db.AddInParameter(cmd, "@legajo", DbType.Int32, entity.persona.Id);
           
                db.AddInParameter(cmd, "@NombreDocumento", DbType.String, entity.NombreDocumento);
                db.ExecuteNonQuery(cmd);
            }
        }

        public List<Documento> ReadByListado(string id)
        {
            throw new NotImplementedException();
        }
    }
}
