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
    public class AlergiaDAC : DataAccessComponent, IRepository2<Alergias>
    {
        public Alergias ALoad(IDataReader entity)
        {
            Alergias palabra = new Alergias();
            palabra.persona.Id = GetDataValue<int>(entity, "Legajo");
            palabra.Alergia_Medicamentos = GetDataValue<bool>(entity, "Cuales_Alergias_Medicamentos");
            palabra.Alergia_Alimento = GetDataValue<bool>(entity, "Cuales_Alergias_Medicamentos");
            palabra.Alergia_Elementos = GetDataValue<bool>(entity, "Cuales_Alergias_Medicamentos");
            palabra.Cuales_Alergias_Alimento = GetDataValue<string>(entity, "Cuales_Alergias_Alimento");
            palabra.Cuales_Alergias_Elementos = GetDataValue<string>(entity, "Cuales_Alergias_Elementos");

            palabra.Cuales_Alergias_Medicamentos = GetDataValue<string>(entity, "Cuales_Alergias_Medicamentos");
            palabra.Otras_Alergias = GetDataValue<string>(entity, "Otras_Alergias");


            return palabra;
        }

        public Alergias Create(Alergias entity)
        {
            const string SQL_STATEMENT = "insert into Alergias(legajo,Cuales_Alergias_Alimento,Cuales_Alergias_Elementos,Cuales_Alergias_Medicamentos,Alergia_Alimento,Alergia_Elementos,Alergia_Medicamentos,Otras_Alergias)values (@legajo,@Cuales_Alergias_Alimento,@Cuales_Alergias_Elementos,@Cuales_Alergias_Medicamentos,@Alergia_Alimento,@Alergia_Elementos,@Alergia_Medicamentos,@Otras_Alergias)";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@legajo", DbType.Int32, entity.persona.Id);
                db.AddInParameter(cmd, "@Cuales_Alergias_Alimento", DbType.String, entity.Cuales_Alergias_Alimento);
                db.AddInParameter(cmd, "@Cuales_Alergias_Elementos", DbType.String, entity.Cuales_Alergias_Elementos);
                db.AddInParameter(cmd, "@Cuales_Alergias_Medicamentos", DbType.String, entity.Cuales_Alergias_Medicamentos);
                db.AddInParameter(cmd, "@Otras_Alergias", DbType.String, entity.Otras_Alergias);
                db.AddInParameter(cmd, "@Alergia_Alimento", DbType.Boolean, entity.Alergia_Alimento);
                db.AddInParameter(cmd, "@Alergia_Elementos", DbType.Boolean, entity.Alergia_Elementos);
                db.AddInParameter(cmd, "@Alergia_Medicamentos", DbType.Boolean, entity.Alergia_Medicamentos);

                entity.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }
            return entity;
        }

        public void Delete(int id)
        {
            const string SQL_STATEMENT = "Delete from Alergia where legajo=@Id";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                db.ExecuteNonQuery(cmd);
            }
        }

        public List<Alergias> Read()
        {
            throw new NotImplementedException();
        }

        public Alergias ReadBy(int id)
        {
            const string SQL_STATEMENT = "select * from Alergias where  legajo=@Id";
            Alergias roles = null;

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

        public Alergias ReadBy(string id)
        {
            throw new NotImplementedException();
        }

        public List<Alergias> ReadByListado(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(Alergias entity)
        {
            const string SQL_STATEMENT = "update ObrasSocial set Cuales_Alergias_Alimento=@Cuales_Alergias_Alimento, Cuales_Alergias_Elementos=@Cuales_Alergias_Elementos, Cuales_Alergias_Medicamentos=@Cuales_Alergias_Medicamentos, Otras_Alergias=@Otras_Alergias, Alergia_Alimento=@Alergia_Alimento, Alergia_Elementos=@Alergia_Elementos, Alergia_Medicamentos=@Alergia_Medicamentos where legajo=@legajo ";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@legajo", DbType.Int32, entity.persona.Id);
                db.AddInParameter(cmd, "@Cuales_Alergias_Alimento", DbType.String, entity.Cuales_Alergias_Alimento);
                db.AddInParameter(cmd, "@Cuales_Alergias_Elementos", DbType.String, entity.Cuales_Alergias_Elementos);
                db.AddInParameter(cmd, "@Cuales_Alergias_Medicamentos", DbType.String, entity.Cuales_Alergias_Medicamentos);
                db.AddInParameter(cmd, "@Otras_Alergias", DbType.String, entity.Otras_Alergias);
                db.AddInParameter(cmd, "@Alergia_Alimento", DbType.Boolean, entity.Alergia_Alimento);
                db.AddInParameter(cmd, "@Alergia_Elementos", DbType.Boolean, entity.Alergia_Elementos);
                db.AddInParameter(cmd, "@Alergia_Medicamentos", DbType.Boolean, entity.Alergia_Medicamentos);
                db.ExecuteNonQuery(cmd);
            }
        }
    }
}
