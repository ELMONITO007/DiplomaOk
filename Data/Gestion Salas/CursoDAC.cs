using Entitites.Negocio.Salas;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Gestion_Salas
{
    public class CursoDAC : DataAccessComponent, IRepository2<Curso>
    {
        public Curso ALoad(IDataReader entity)
        {
            Sala sala = new Sala();
            sala.Id= GetDataValue<int>(entity, "Id_sala");

            Grado grado = new Grado();
            grado.Id = GetDataValue<int>(entity, "id_grado");

            SalaHorario salaHorario = new SalaHorario();
            salaHorario.Id= GetDataValue<int>(entity, "id_salaHorario");


            Curso curso = new Curso(sala,grado,salaHorario);

            curso.Id = GetDataValue<int>(entity, "Id_curso");
       

            curso.nombre = GetDataValue<string>(entity, "Nombre");
        
         
            return curso;
        }

        public Curso Create(Curso entity)
        {
            const string SQL_STATEMENT = "insert into Curso(ID_Sala,Nombre,id_Grado,id_salaHorario)values(@ID_Sala,@Nombre,@Grado,@id_salaHorario)";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@id_salaHorario", DbType.Int32, entity.salaHorario.Id);
                db.AddInParameter(cmd, "@ID_Sala", DbType.Int32, entity.sala.Id);
                db.AddInParameter(cmd, "@Nombre", DbType.String, entity.nombre);
                db.AddInParameter(cmd, "@Grado", DbType.Int64, entity.grado.Id);


                entity.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }
            return entity;
        }

        public void QuitarAlumnoSala(int id_curso,int legajo)
        {
            const string SQL_STATEMENT = "delete from CursoAlumno where ID_Curso=@ID_Curso and Legajo=@Legajo";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@id_curso", DbType.Int32, id_curso);
                db.AddInParameter(cmd, "@Legajo", DbType.Int32, legajo);

                db.ExecuteNonQuery(cmd);
            }
        }
        public void Delete(int id)
        {
            const string SQL_STATEMENT = "delete from Curso where ID_Curso=@Id";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                db.ExecuteNonQuery(cmd);
            }
        }
        public List<Curso> Read()
        {
            const string SQL_STATEMENT = "select * from Curso ";

            List<Curso> result = new List<Curso>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Curso usuarios = ALoad(dr);
                        result.Add(usuarios);
                    }
                }
            }
            return result;
        }

        public Curso ReadBy(int id)
        {
            const string SQL_STATEMENT = "select * from Curso where  ID_Curso=@ID_Curso";

            Curso result = null;
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@ID_Curso", DbType.Int32, id);
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
        public List<Curso> ReadByGrado(Curso entity)
        {
            const string SQL_STATEMENT = "select * from Curso where  ID_Grado=@ID_Grado and ID_Sala=@ID_Sala";

            List<Curso> result = new List<Curso>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@ID_Sala", DbType.Int32, entity.sala.Id);
                db.AddInParameter(cmd, "@ID_Grado", DbType.Int32, entity.Id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Curso usuarios = ALoad(dr);
                        result.Add(usuarios);
                    }
                }
            }
            return result;
        }

        public List<Curso> ReadByAño(int año)
        {
            const string SQL_STATEMENT = "select * from curso as c join Sala_Horario as sh on sh.ID_SalaHorario=c.id_salaHorario where año =@año";

            List<Curso> result = new List<Curso>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@año", DbType.Int32, año);


                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Curso usuarios = ALoad(dr);
                        result.Add(usuarios);
                    }
                }
            }
            return result;
        }
        public List<Curso> ReadByCurso(Curso entity)
        {
            const string SQL_STATEMENT = "select * from Curso where   ID_Curso=@ID_Curso";

            List<Curso> result = new List<Curso>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@ID_Sala", DbType.Int32, entity.sala.Id);
                db.AddInParameter(cmd, "@ID_Curso", DbType.Int32, entity.Id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Curso usuarios = ALoad(dr);
                        result.Add(usuarios);
                    }
                }
            }
            return result;
        }
        public List<Curso> ReadByMaestro(int legajo)
        {
            const string SQL_STATEMENT = "select * from CursoAlumno  as ca join Persona as p on p.Legajo=ca.Legajo where ca.Legajo=@legajo";

            List<Curso> result = new List<Curso>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@legajo", DbType.Int32, legajo);
            

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Curso usuarios = ALoad(dr);
                        result.Add(usuarios);
                    }
                }
            }
            return result;
        }
        public Curso ReadBy(string id)
        {
            const string SQL_STATEMENT = "select * from Curso where  nombre=@ID_Curso";

            Curso result = null;
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@ID_Curso", DbType.String, id);
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
        public Curso ReadByPersona(int id)
        {
            const string SQL_STATEMENT = "select * from CursoAlumno as sa join Persona as p on p.Legajo=sa.Legajo join curso as c on c.ID_Curso=sa.ID_Curso where sa.Legajo=@ID_Curso";

            Curso result = null;
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@ID_Curso", DbType.Int32, id);
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
        public void Update(Curso entity)
        {
            const string SQL_STATEMENT = "update Curso set ID_Sala=@ID_Sala,Nombre=@Nombre,id_Grado=@Grado  where ID_curso=@Id ";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@id", DbType.Int32, entity.Id);


                db.AddInParameter(cmd, "@ID_Sala", DbType.Int32, entity.sala.Id);
                db.AddInParameter(cmd, "@Nombre", DbType.String, entity.nombre);
                db.AddInParameter(cmd, "@Grado", DbType.Int64, entity.grado.Id);
                db.ExecuteNonQuery(cmd);
            }
        }

        public Curso AsignarAlumno(Curso entity)
        {
            const string SQL_STATEMENT = "insert into CursoAlumno(legajo,Id_Curso)values(@legajo,@curso)";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@legajo", DbType.Int32, entity.listaALumno[0].Id);
                db.AddInParameter(cmd, "@curso", DbType.Int32, entity.Id);

                entity.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }
            return entity;
        }




        public List<Curso> ReadByListado(string id)
        {
            throw new NotImplementedException();
        }
    }
}
