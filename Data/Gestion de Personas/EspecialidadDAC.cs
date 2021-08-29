using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Microsoft.Practices.EnterpriseLibrary.Data;
namespace Data.Gestion_de_Personas
{
  public  class EspecialidadDAC :DataAccessComponent,IRepository2<Especialidad>
    {
        #region Especialidad
        public Especialidad ALoad(IDataReader entity)
        {
            Especialidad especialidad = new Especialidad();
            especialidad.Id = GetDataValue<int>(entity, "ID_Especialidad");
            especialidad.especialidad = GetDataValue<string>(entity, "Especialidad");

            return especialidad;
        }

        public Especialidad Create(Especialidad entity)
        {
            const string SQL_STATEMENT = "insert into Especialidad(Especialidad,activo)values(@Especialidad,1)";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Especialidad", DbType.String, entity.especialidad);

                entity.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }
            return entity;
        }

        public void Delete(int id)
        {
            const string SQL_STATEMENT = "update Especialidad set Activo=0 where ID_Especialidad=@Id";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                db.ExecuteNonQuery(cmd);
            }
        }

        public List<Especialidad> Read()
        {
            const string SQL_STATEMENT = "select * from Especialidad where  activo=1";

            List<Especialidad> result = new List<Especialidad>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Especialidad roles = ALoad(dr);
                        result.Add(roles);
                    }
                }
            }
            return result;
        }
        public List<Especialidad> ListaEspecialidadSala(int id_Curso)
        {
            const string SQL_STATEMENT = "select e.ID_Especialidad,e.Especialidad from CursoHorario as ch join Maestro_Horario as mh on mh.ID_MaestroHorario=ch.ID_MaestroHorario join EspecialidadPersona as ep on ep.Legajo=mh.Legajo join Especialidad as e on e.ID_Especialidad=ep.ID_Especialidad where ch.ID_Curso=@curso";

            List<Especialidad> result = new List<Especialidad>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@curso", DbType.Int32, id_Curso);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {

                        Especialidad roles = ALoad(dr);
                        result.Add(roles);
                    }
                }
            }
            return result;
        }
        public Especialidad ReadBy(int id)
        {
            const string SQL_STATEMENT = "select * from Especialidad where  activo=1 and ID_Especialidad=@Id";
            Especialidad roles = null;

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

        public Especialidad ReadBy(string id)
        {
            const string SQL_STATEMENT = "select * from Especialidad where  activo=1 and Especialidad=@Id";
            Especialidad roles = null;

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.String, id);
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

        public void Update(Especialidad entity)
        {
            const string SQL_STATEMENT = "update Especialidad set Especialidad=@Especialidad where ID_Especialidad=@id ";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Especialidad", DbType.String, entity.especialidad);

                db.AddInParameter(cmd, "@id", DbType.String, entity.Id);
                db.ExecuteNonQuery(cmd);
            }
        }

        public List<Especialidad> ReadByListado(string id)
        {
            throw new NotImplementedException();
        }
        #endregion


        #region EspecialidadMaestro


        public List<Especialidad> ReadByPersona(int legajo)
        {
            const string SQL_STATEMENT = "select * from EspecialidadPersona as ep join Persona as p on p.Legajo=ep.Legajo join Especialidad as e on ep.ID_Especialidad=e.ID_Especialidad where p.Activo=1 and ep.Legajo=@Id";
            List<Especialidad> result = new List<Especialidad>();

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, legajo);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Especialidad roles = ALoad(dr);
                        result.Add(roles);
                    }
                }
            }
            return result;
        }

        #endregion
    }
}
