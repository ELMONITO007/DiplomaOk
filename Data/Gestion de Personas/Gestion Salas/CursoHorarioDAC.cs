using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Entitites.Negocio.Salas;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Data.Gestion_salas
{
    public class CursoHorarioDAC : DataAccessComponent
    {
        public CursoHorario ALoad(IDataReader entity)
        {
            MaestroHorario maestroHorario = new MaestroHorario();
            maestroHorario.Id= GetDataValue<int>(entity, "id_MaestroHorario");
            Curso curso = new Curso();
            curso.Id = GetDataValue<int>(entity, "id_curso");
            CursoHorario cursoHorario = new CursoHorario(curso,maestroHorario);
       



            return cursoHorario;
        }

        public CursoHorario Create(CursoHorario entity)
        {
            const string SQL_STATEMENT = "insert into CursoHorario(id_Curso,id_MaestroHorario)values (@curso,@horario)";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {

                db.AddInParameter(cmd, "@curso", DbType.Int32, entity.curso.Id);
                db.AddInParameter(cmd, "@horario", DbType.Int32, entity.maestroHorario.Id);




                entity.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }
            return entity;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
        public void CursoHorario(CursoHorario entity)
        {
            const string SQL_STATEMENT = "delete from CursoHorario  where id_Curso=@curso and id_maestroHorario=@horario";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@curso", DbType.Int32, entity.curso.Id);
                db.AddInParameter(cmd, "@horario", DbType.Int32, entity.maestroHorario.Id);


                db.ExecuteNonQuery(cmd);
            }
        }
        public List<CursoHorario> Read()
        {
            const string SQL_STATEMENT = "select * from CursoHorario ";

            List<CursoHorario> result = new List<CursoHorario>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        CursoHorario roles = ALoad(dr);
                        result.Add(roles);
                    }
                }
            }
            return result;
        }
        public List<CursoHorario> ReadByCurso(int id_Curso)
        {
            const string SQL_STATEMENT = "select * from CursoHorario as ch join Maestro_Horario as mh on mh.ID_MaestroHorario=ch.ID_MaestroHorario where ch.ID_Curso=@curso";

            List<CursoHorario> result = new List<CursoHorario>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@curso", DbType.Int32, id_Curso);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        CursoHorario roles = ALoad(dr);
                        result.Add(roles);
                    }
                }
            }
            return result;
        }

     
    }
}
