﻿using Entitites.Negocio.Salas;
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
            Curso curso = new Curso();
            curso.Id = GetDataValue<int>(entity, "Id_curso");
            curso.sala.Id = GetDataValue<int>(entity, "Id_sala");

            curso.nombre = GetDataValue<string>(entity, "nombre");
            curso.grado.Id = GetDataValue<int>(entity, "id_grado");
            //curso.salaHorario.Id = GetDataValue<int>(entity, "id_salaHorario");
            return curso;
        }

        public Curso Create(Curso entity)
        {
            const string SQL_STATEMENT = "insert into Curso(ID_Sala,Nombre,id_Grado,id_salaHorario)values(@ID_Sala,@Nombre,@Grado,@id_salaHorario)";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                //db.AddInParameter(cmd, "@id_salaHorario", DbType.Int32, entity.salaHorario.Id);
                db.AddInParameter(cmd, "@ID_Sala", DbType.Int32, entity.sala.Id);
                db.AddInParameter(cmd, "@Nombre", DbType.String, entity.nombre);
                db.AddInParameter(cmd, "@Grado", DbType.Int64, entity.grado.Id);


                entity.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }
            return entity;
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

        public List<Curso> ReadByListado(string id)
        {
            throw new NotImplementedException();
        }
    }
}