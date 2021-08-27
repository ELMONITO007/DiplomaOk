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
    public class ObraSocialDAC : DataAccessComponent, IRepository2<ObrasSocial>
    {
        public ObrasSocial ALoad(IDataReader entity)
        {
            ObrasSocial palabra = new ObrasSocial();
            palabra.persona.Id = GetDataValue<int>(entity, "Legajo");
            palabra.tiene_Obra_Social = GetDataValue<bool>(entity, "Tiene_Obra_Social");

            palabra.obra_Social = GetDataValue<string>(entity, "Obra_Social");
            palabra.telefono_Emergencia = GetDataValue<string>(entity, "Telefono_Emergencia");

            palabra.numero_Socio = GetDataValue<string>(entity, "numero_Socio");



            return palabra;
        }

        public ObrasSocial Create(ObrasSocial entity)
        {
            const string SQL_STATEMENT = "insert into Obras_Social(legajo,Tiene_Obra_Social,Obra_Social,Telefono_Emergencia,numero_Socio)values (@legajo,@Tiene_Obra_Social,@Obra_Social,@Telefono_Emergencia,@numero_Socio)";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@legajo", DbType.Int32, entity.persona.Id);
                db.AddInParameter(cmd, "@Tiene_Obra_Social", DbType.Boolean, entity.tiene_Obra_Social);
                db.AddInParameter(cmd, "@Obra_Social", DbType.String, entity.obra_Social);
                db.AddInParameter(cmd, "@Telefono_Emergencia", DbType.String, entity.telefono_Emergencia);
                db.AddInParameter(cmd, "@numero_Socio", DbType.String, entity.numero_Socio);


                entity.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }
            return entity;
        }

        public void Delete(int id)
        {
            const string SQL_STATEMENT = "Delete from Obras_Social where legajo=@Id";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                db.ExecuteNonQuery(cmd);
            }
        }

        public List<ObrasSocial> Read()
        {
            throw new NotImplementedException();
        }

        public ObrasSocial ReadBy(int id)
        {
            const string SQL_STATEMENT = "select * from Obras_Social where  legajo=@Id";
            ObrasSocial roles = null;

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

        public ObrasSocial ReadBy(string id)
        {
            throw new NotImplementedException();
        }

        public List<ObrasSocial> ReadByListado(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(ObrasSocial entity)
        {
            const string SQL_STATEMENT = "update Obras_Social set Tiene_Obra_Social=@Tiene_Obra_Social, Obra_Social=@Obra_Social, Telefono_Emergencia=@Telefono_Emergencia, numero_Socio=@numero_Socio where legajo=@legajo ";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@legajo", DbType.Int32, entity.persona.Id);
                db.AddInParameter(cmd, "@Tiene_Obra_Social", DbType.Boolean, entity.tiene_Obra_Social);
                db.AddInParameter(cmd, "@Obra_Social", DbType.String, entity.obra_Social);
                db.AddInParameter(cmd, "@Telefono_Emergencia", DbType.String, entity.telefono_Emergencia);
                db.AddInParameter(cmd, "@numero_Socio", DbType.String, entity.numero_Socio);
                db.ExecuteNonQuery(cmd);
            }
        }
    }
}
