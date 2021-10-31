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
    public class MateriaDAC : DataAccessComponent, IRepository2<Materia>
    {
        public Materia ALoad(IDataReader entity)
        {
            Especialidad especialidad = new Especialidad();
            especialidad.Id= GetDataValue<int>(entity, "ID_especialidad"); ;
            Materia materia = new Materia(especialidad);
            materia.Id = GetDataValue<int>(entity, "ID_materia");
            materia.materia = GetDataValue<string>(entity, "materia");


            return materia;
        }

        public Materia Create(Materia entity)
        {
            const string SQL_STATEMENT = "insert into Materia(materia,ID_especialidad,activo)values(@materia,@ID_especialidad,1)";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@materia", DbType.String, entity.materia);

                db.AddInParameter(cmd, "@ID_especialidad", DbType.String, entity.especialidad.Id);

                entity.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }
            return entity;
        }

        public void Delete(int id)
        {
            const string SQL_STATEMENT = "update Materia set activo=0  where ID_Materia=@Id";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                db.ExecuteNonQuery(cmd);
            }
        }

        public List<Materia> Read()
        {
            const string SQL_STATEMENT = "select * from Materia where activo=1 ";

            List<Materia> result = new List<Materia>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Materia usuarios = ALoad(dr);
                        result.Add(usuarios);
                    }
                }
            }
            return result;
        }
        public List<Materia> ReadByEspecialidad(int legajo)
        {
            const string SQL_STATEMENT = "select * from EspecialidadPersona as ep inner join Especialidad as e on ep.ID_Especialidad=e.ID_Especialidad inner join Materia as m on m.ID_Especialidad=e.ID_Especialidad where ep.Legajo=@id";

            List<Materia> result = new List<Materia>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@id", DbType.Int32, legajo);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Materia usuarios = ALoad(dr);
                        result.Add(usuarios);
                    }
                }
            }
            return result;
        }

        public Materia ReadBy(int id)
        {
            const string SQL_STATEMENT = "select * from Materia where  ID_Materia=@ID_Materia and activo=1";

            Materia result = null;
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@ID_Materia", DbType.Int32, id);
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

        public Materia ReadBy(string id)
        {
            const string SQL_STATEMENT = "select * from Materia where  Materia=@ID_Materia  and activo=1";

            Materia result = null;
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@ID_Materia", DbType.String, id);
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

        public void Update(Materia entity)
        {

            const string SQL_STATEMENT = "update Materia set Materia=@Materia where ID_Materia=@Id ";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@id", DbType.Int32, entity.Id);
                db.AddInParameter(cmd, "@Materia", DbType.String, entity.materia);
                db.ExecuteNonQuery(cmd);
            }
        }

        public List<Materia> ReadByListado(string id)
        {
            throw new NotImplementedException();
        }
    }
}
