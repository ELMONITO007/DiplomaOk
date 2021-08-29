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

namespace Data.Gestion_de_Alumnos
{
    public class FamiliaDAC : DataAccessComponent, IRepository2<Familia>
    {
        public Familia ALoad(IDataReader entity)
        {
            Persona persona = new Persona();
            persona.Id = GetDataValue<int>(entity, "Legajo");
            Familia palabra = new Familia(persona);
           
            palabra.Padres_Separados = GetDataValue<bool>(entity, "Padres_Separados");
            palabra.Hermanos = GetDataValue<bool>(entity, "Hermanos");
            palabra.Vive_Abuela = GetDataValue<bool>(entity, "Vive_Abuela");
            palabra.Tiene_Tios = GetDataValue<bool>(entity, "Tiene_Tios");
            palabra.Papa_Trabajo = GetDataValue<bool>(entity, "Papa_Trabajo");
            palabra.Mama_Trabajo = GetDataValue<bool>(entity, "Mama_Trabajo");


            return palabra;
        }

        public Familia Create(Familia entity)
        {
            const string SQL_STATEMENT = "insert into Familia(legajo,Hermanos,Vive_Abuela,Tiene_Tios,Papa_Trabajo,Mama_Trabajo)values (@legajo,@Hermanos,@Vive_Abuela,@Tiene_Tios,@Papa_Trabajo,@Mama_Trabajo)";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@legajo", DbType.Int32, entity.persona.Id);
                db.AddInParameter(cmd, "@Hermanos", DbType.String, entity.Hermanos);
                db.AddInParameter(cmd, "@Vive_Abuela", DbType.String, entity.Vive_Abuela);
                db.AddInParameter(cmd, "@Tiene_Tios", DbType.String, entity.Tiene_Tios);
                db.AddInParameter(cmd, "@Papa_Trabajo", DbType.String, entity.Papa_Trabajo);
                db.AddInParameter(cmd, "@Mama_Trabajo", DbType.Boolean, entity.Mama_Trabajo);


                entity.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }
            return entity;
        }

        public void Delete(int id)
        {
            const string SQL_STATEMENT = "Delete from Familia where legajo=@Id";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                db.ExecuteNonQuery(cmd);
            }
        }

        public List<Familia> Read()
        {
            throw new NotImplementedException();
        }

        public Familia ReadBy(int id)
        {
            const string SQL_STATEMENT = "select * from Familia where  legajo=@Id";
            Familia roles = null;

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

        public Familia ReadBy(string id)
        {
            throw new NotImplementedException();
        }

        public List<Familia> ReadByListado(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(Familia entity)
        {
            const string SQL_STATEMENT = "update Familia set Hermanos=@Hermanos, Vive_Abuela=@Vive_Abuela, Tiene_Tios=@Tiene_Tios, Papa_Trabajo=@Papa_Trabajo, Mama_Trabajo=@Mama_Trabajo where legajo=@legajo ";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@legajo", DbType.Int32, entity.persona.Id);
                db.AddInParameter(cmd, "@Hermanos", DbType.String, entity.Hermanos);
                db.AddInParameter(cmd, "@Vive_Abuela", DbType.String, entity.Vive_Abuela);
                db.AddInParameter(cmd, "@Tiene_Tios", DbType.String, entity.Tiene_Tios);
                db.AddInParameter(cmd, "@Papa_Trabajo", DbType.String, entity.Papa_Trabajo);
                db.AddInParameter(cmd, "@Mama_Trabajo", DbType.Boolean, entity.Mama_Trabajo);
                db.ExecuteNonQuery(cmd);
            }
        }
    }
}
