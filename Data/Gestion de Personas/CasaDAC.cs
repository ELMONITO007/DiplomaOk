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
    public class CasaDac : DataAccessComponent, IRepository2<Casa>
    {
        public Casa ALoad(IDataReader entity)
        {
            Casa palabra = new Casa();
            palabra.persona.Id = GetDataValue<int>(entity, "Legajo");
            palabra.Vive_Casa = GetDataValue<bool>(entity, "Vive_Casa");
            palabra.Vive_Departamento = GetDataValue<bool>(entity, "Vive_Departamento");
            palabra.Vive_Barrio_Cerrado = GetDataValue<bool>(entity, "Vive_Barrio_Cerrado");
            palabra.Tiene_Habitacion_Propia = GetDataValue<bool>(entity, "Tiene_Habitacion_Propia");
            palabra.Tiene_Patio = GetDataValue<bool>(entity, "Tiene_Patio");



            return palabra;
        }

        public Casa Create(Casa entity)
        {
            const string SQL_STATEMENT = "insert into Casa(legajo,Vive_Casa,Vive_Departamento,Vive_Barrio_Cerrado,Tiene_Habitacion_Propia,Tiene_Patio)values (@legajo,@Vive_Casa,@Vive_Departamento,@Vive_Barrio_Cerrado,@Tiene_Habitacion_Propia,@Tiene_Patio)";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@legajo", DbType.Int32, entity.persona.Id);
                db.AddInParameter(cmd, "@Vive_Casa", DbType.Boolean, entity.Vive_Casa);
                db.AddInParameter(cmd, "@Vive_Departamento", DbType.Boolean, entity.Vive_Departamento);
                db.AddInParameter(cmd, "@Vive_Barrio_Cerrado", DbType.Boolean, entity.Vive_Barrio_Cerrado);

                db.AddInParameter(cmd, "@Tiene_Habitacion_Propia", DbType.Boolean, entity.Tiene_Habitacion_Propia);
                db.AddInParameter(cmd, "@Tiene_Patio", DbType.Boolean, entity.Tiene_Patio);


                entity.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }
            return entity;
        }

        public void Delete(int id)
        {
            const string SQL_STATEMENT = "Delete from casa where legajo=@Id";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                db.ExecuteNonQuery(cmd);
            }
        }

        public List<Casa> Read()
        {
            throw new NotImplementedException();
        }

        public Casa ReadBy(int id)
        {
            const string SQL_STATEMENT = "select * from casa where  legajo=@Id";
            Casa roles = null;

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

        public Casa ReadBy(string id)
        {
            throw new NotImplementedException();
        }

        public List<Casa> ReadByListado(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(Casa entity)
        {
            const string SQL_STATEMENT = "update casa set Vive_Casa=@Vive_Casa, Vive_Departamento=@Vive_Departamento, Vive_Barrio_Cerrado=@Vive_Barrio_Cerrado, Tiene_Habitacion_Propia=@Tiene_Habitacion_Propia, Tiene_Patio=@Tiene_Patio where legajo=@legajo ";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {

                db.AddInParameter(cmd, "@legajo", DbType.Int32, entity.persona.Id);
                db.AddInParameter(cmd, "@Vive_Casa", DbType.Boolean, entity.Vive_Casa);
                db.AddInParameter(cmd, "@Vive_Departamento", DbType.Boolean, entity.Vive_Departamento);
                db.AddInParameter(cmd, "@Vive_Barrio_Cerrado", DbType.Boolean, entity.Vive_Barrio_Cerrado);

                db.AddInParameter(cmd, "@Tiene_Habitacion_Propia", DbType.Boolean, entity.Tiene_Habitacion_Propia);
                db.AddInParameter(cmd, "@Tiene_Patio", DbType.Boolean, entity.Tiene_Patio);
                db.ExecuteNonQuery(cmd);
            }
        }
    }
}
