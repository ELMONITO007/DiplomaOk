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

namespace Data
{
    public class SalaHorarioDAC : DataAccessComponent, IRepository2<SalaHorario>
    {
        public SalaHorario ALoadGrado(IDataReader entity)
        {
            Sala sala = new Sala();
            sala.Id= GetDataValue<int>(entity, "Id_Sala");
            SalaHorario salaHorario = new SalaHorario(sala);

            salaHorario.Id = GetDataValue<int>(entity, "ID_SalaHorario");
          
            salaHorario.diaSemana = GetDataValue<int>(entity, "diaSemana");
            salaHorario.año = GetDataValue<int>(entity, "año");
            salaHorario.hora = GetDataValue<int>(entity, "hora");
            salaHorario.turno = GetDataValue<string>(entity, "turno");

            return salaHorario;
        }
        public SalaHorario ALoad(IDataReader entity)
        {
            Sala sala = new Sala();
            sala.Id = GetDataValue<int>(entity, "Id_Sala");
            SalaHorario salaHorario = new SalaHorario(sala);
            salaHorario.Id = GetDataValue<int>(entity, "ID_SalaHorario");
        
            salaHorario.diaSemana = GetDataValue<int>(entity, "diaSemana");
            salaHorario.año = GetDataValue<int>(entity, "año");
            salaHorario.hora = GetDataValue<int>(entity, "hora");
            salaHorario.turno = GetDataValue<string>(entity, "turno");
            return salaHorario;
        }
        public SalaHorario ALoadAño(IDataReader entity)
        {
            SalaHorario sala = new SalaHorario();

            sala.año = GetDataValue<int>(entity, "año");

            return sala;
        }
        public SalaHorario Create(SalaHorario entity)
        {
            throw new NotImplementedException();
        }
        public SalaHorario CreateSalaParcial(SalaHorario entity)
        {

            const string SQL_STATEMENT = "insert into Sala_Horario(Id_Sala,diaSemana,hora,año,turno)values (@Id_Sala,@diaSemana,@hora,@año,@turno)";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {

                db.AddInParameter(cmd, "@Id_Sala", DbType.Int32, entity.sala.Id);
                db.AddInParameter(cmd, "@diaSemana", DbType.Int32, entity.diaSemana);
                db.AddInParameter(cmd, "@hora", DbType.Int32, entity.hora);
                db.AddInParameter(cmd, "@año", DbType.Int32, entity.año);

                db.AddInParameter(cmd, "@turno", DbType.String, entity.turno);



                entity.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }
            return entity;
        }
        public SalaHorario CreateSalaCompleta(SalaHorario entity)
        {
            const string SQL_STATEMENT = "insert into Sala_Horario(Id_Sala,año,turno,diasemana,hora)values (@Id_Sala,@año,@turno,0,0)";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {

                db.AddInParameter(cmd, "@Id_Sala", DbType.Int32, entity.sala.Id);

                db.AddInParameter(cmd, "@año", DbType.Int32, entity.año);

                db.AddInParameter(cmd, "@turno", DbType.String, entity.turno);



                entity.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }
            return entity;
        }




        public void Delete(int id)
        {
            const string SQL_STATEMENT = "Delete Sala_Horario  where Legajo=@Id";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                db.ExecuteNonQuery(cmd);
            }
        }

        public List<SalaHorario> Read()
        {
            const string SQL_STATEMENT = "select * from Sala_Horario ";

            List<SalaHorario> result = new List<SalaHorario>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        SalaHorario roles = ALoad(dr);
                        result.Add(roles);
                    }
                }
            }
            return result;
        }
        public List<SalaHorario> SoloAño()
        {
            const string SQL_STATEMENT = "select distinct año from Sala_Horario ";

            List<SalaHorario> result = new List<SalaHorario>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        SalaHorario roles = ALoadAño(dr);
                        result.Add(roles);
                    }
                }
            }
            return result;
        }

        public SalaHorario ReadBy(int id)
        {
            const string SQL_STATEMENT = "select * from Sala_Horario where ID_SalaHorario=@Id";
            SalaHorario result = new SalaHorario();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        result = ALoad(dr);

                    }
                }
            }
            return result;
        }

        public List<SalaHorario> ReadByTipo(SalaHorario sala)
        {
            const string SQL_STATEMENT = "select * from Sala_Horario as sh join sala as s on s.ID_Sala=sh.ID_Sala join TipoSala as ts on ts.Id_TipoSala=s.ID_TipoSala where s.ID_TipoSala=(select Id_TipoSala from TipoSala where TipoSala=@ID_TipoSala) and s.ID_Sala=@ID_Sala";

            List<SalaHorario> result = new List<SalaHorario>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@ID_Sala", DbType.Int32, sala.sala.Id);
                db.AddInParameter(cmd, "@ID_TipoSala", DbType.String, sala.sala.tipoSala);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        SalaHorario roles = ALoad(dr);
                        result.Add(roles);
                    }
                }
            }
            return result;
        }
        public List<SalaHorario> ReadBySala(SalaHorario sala)
        {
            const string SQL_STATEMENT = "select * from Sala_Horario as sh join sala as s on s.ID_Sala=sh.ID_Sala join TipoSala as ts on ts.Id_TipoSala=s.ID_TipoSala where s.ID_Sala=@ID_Sala";

            List<SalaHorario> result = new List<SalaHorario>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@ID_Sala", DbType.Int32, sala.sala.Id);


                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        SalaHorario roles = ALoad(dr);
                        result.Add(roles);
                    }
                }
            }
            return result;
        }
        public List<SalaHorario> ReadByTipoSala(SalaHorario sala)
        {
            const string SQL_STATEMENT = "select * from Sala_Horario as sh join sala as s on s.ID_Sala=sh.ID_Sala join TipoSala as ts on ts.Id_TipoSala=s.ID_TipoSala where s.ID_Sala=@ID_Sala and s.ID_TipoSala=(select Id_TipoSala from TipoSala where TipoSala=@ID_TipoSala)";

            List<SalaHorario> result = new List<SalaHorario>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@ID_Sala", DbType.Int32, sala.sala.Id);
                db.AddInParameter(cmd, "@ID_TipoSala", DbType.Int32, sala.sala.tipoSala);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        SalaHorario roles = ALoad(dr);
                        result.Add(roles);
                    }
                }
            }
            return result;
        }

        public List<SalaHorario> ReadBySalaYañoYTurno(SalaHorario sala)
        {
            const string SQL_STATEMENT = "select * from Sala_Horario as sh join sala as s on s.ID_Sala=sh.ID_Sala join TipoSala as ts on ts.Id_TipoSala=s.ID_TipoSala where Año=@Año and s.ID_Sala=@ID_Sala and turno=@turno and ts.tiposala='Grado'";

            List<SalaHorario> result = new List<SalaHorario>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@ID_Sala", DbType.Int32, sala.sala.Id);
                db.AddInParameter(cmd, "@Año", DbType.Int32, sala.año);
                db.AddInParameter(cmd, "@turno", DbType.String, sala.turno);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        SalaHorario roles = ALoad(dr);
                        result.Add(roles);
                    }
                }
            }
            return result;
        }
        public SalaHorario ReadBySalaYañoYTurnoGrado(SalaHorario sala)
        {
            const string SQL_STATEMENT = "select * from Sala_Horario as sh join sala as s on s.ID_Sala=sh.ID_Sala join TipoSala as ts on ts.Id_TipoSala=s.ID_TipoSala where Año=@Año and s.ID_Sala=@ID_Sala and turno=@turno and ts.tiposala='Grado'";

            SalaHorario result = null;
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@ID_Sala", DbType.Int32, sala.sala.Id);
                db.AddInParameter(cmd, "@Año", DbType.Int32, sala.año);
                db.AddInParameter(cmd, "@turno", DbType.String, sala.turno);

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
        public SalaHorario ReadBy(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(SalaHorario entity)
        {
            throw new NotImplementedException();
        }

        public List<SalaHorario> ReadByListado(string id)
        {
            throw new NotImplementedException();
        }
    }
}
