using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Entitites;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Data
{
    public class MaestroHorarioDAC : DataAccessComponent, IRepository2<MaestroHorario>
    {
        public MaestroHorario ALoad(IDataReader entity)
        {
            Maestro maestro = new Maestro();
            maestro.Id = GetDataValue<int>(entity, "legajo");
            MaestroHorario sala = new MaestroHorario(maestro);
            sala.Id = GetDataValue<int>(entity, "id_MaestroHorario");
        
            sala.diaSemana = GetDataValue<int>(entity, "diaSemana");
            sala.año = GetDataValue<int>(entity, "año");
            sala.hora = GetDataValue<int>(entity, "hora");
            sala.turno = GetDataValue<string>(entity, "turno");
            sala.disponible = GetDataValue<bool>(entity, "disponible");
            return sala;
        }
        public MaestroHorario CreateHorarioNoGrado(MaestroHorario entity)
        {

            const string SQL_STATEMENT = "insert into Maestro_Horario(legajo,diaSemana,hora,año,turno,disponible)values (@legajo,@diaSemana,@hora,@año,@turno,1)";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {

                db.AddInParameter(cmd, "@legajo", DbType.Int32, entity.persona.Id);
                db.AddInParameter(cmd, "@diaSemana", DbType.Int32, entity.diaSemana);
                db.AddInParameter(cmd, "@hora", DbType.Int32, entity.hora);
                db.AddInParameter(cmd, "@año", DbType.Int32, entity.año);
                db.AddInParameter(cmd, "@disponible", DbType.Boolean, entity.disponible);
                db.AddInParameter(cmd, "@turno", DbType.String, entity.turno);



                entity.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }
            return entity;
        }
        public MaestroHorario CreateHorarioGrado(MaestroHorario entity)
        {
            const string SQL_STATEMENT = "insert into Maestro_Horario(legajo,año,turno,diasemana,hora,disponible)values (@Id_Sala,@año,@turno,0,0,1)";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {

                db.AddInParameter(cmd, "@Id_Sala", DbType.Int32, entity.persona.Id);
                db.AddInParameter(cmd, "@disponible", DbType.Boolean, entity.disponible);
                db.AddInParameter(cmd, "@año", DbType.Int32, entity.año);

                db.AddInParameter(cmd, "@turno", DbType.String, entity.turno);



                entity.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }
            return entity;
        }




        public MaestroHorario Create(MaestroHorario entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            const string SQL_STATEMENT = "delete from Maestro_Horario  where ID_MaestroHorario=@id";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);


                db.ExecuteNonQuery(cmd);
            }
        }
        public void CambiarDisponibilidad(MaestroHorario entity)
        {
            const string SQL_STATEMENT = "update Maestro_Horario set Disponible=@disponibilidad where ID_MaestroHorario=@id";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, entity.Id);
                db.AddInParameter(cmd, "@disponibilidad", DbType.Boolean, entity.disponible);

                db.ExecuteNonQuery(cmd);
            }
        }
        public List<MaestroHorario> Read()
        {
            const string SQL_STATEMENT = "select * from Maestro_Horario ";

            List<MaestroHorario> result = new List<MaestroHorario>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        MaestroHorario roles = ALoad(dr);
                        result.Add(roles);
                    }
                }
            }
            return result;
        }
        public List<MaestroHorario> DisponibilidadEspecialidad(int especialidad, int año, string turno)
        {
            const string SQL_STATEMENT = "select * from Maestro_Horario as mh join Persona as p on p.Legajo=mh.Legajo join EspecialidadPersona as ep on ep.Legajo=p.Legajo where Disponible=1 and ep.ID_Especialidad=@id and Turno=@Turno and año=@año ";

            List<MaestroHorario> result = new List<MaestroHorario>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, especialidad);
                db.AddInParameter(cmd, "@año", DbType.Int32, año);
                db.AddInParameter(cmd, "@turno", DbType.String, turno);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {

                    while (dr.Read())
                    {
                        MaestroHorario roles = ALoad(dr);
                        result.Add(roles);
                    }
                }
            }
            return result;
        }
        public List<MaestroHorario> ReadByMaestro(int legajo)
        {
            const string SQL_STATEMENT = "select * from Maestro_Horario as mh join Persona as p on p.Legajo=mh.Legajo join EspecialidadPersona as ep on ep.Legajo=p.Legajo where mh.legajo=@Id ";

            List<MaestroHorario> result = new List<MaestroHorario>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, legajo);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {

                    while (dr.Read())
                    {
                        MaestroHorario roles = ALoad(dr);
                        result.Add(roles);
                    }
                }
            }
            return result;
        }
        public MaestroHorario ReadBy(int id)
        {
            const string SQL_STATEMENT = "select * from Maestro_Horario where ID_MaestroHorario=@Id  ";
            MaestroHorario roles = null;

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

        public MaestroHorario ReadBy(string id)
        {
            throw new NotImplementedException();
        }
        public MaestroHorario ReadBy(MaestroHorario entity)
        {
            const string SQL_STATEMENT = "select * from Maestro_Horario where  Turno=@Turno and año=@Año and disponible=1 and legajo=@Legajo ";
            MaestroHorario roles = null;

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {

                db.AddInParameter(cmd, "@Legajo", DbType.Int32, entity.persona.Id);


                db.AddInParameter(cmd, "@Turno", DbType.String, entity.turno);
                db.AddInParameter(cmd, "@año", DbType.Int32, entity.año);

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
        public List<MaestroHorario> ReadByGrado(MaestroHorario entity)
        {
            const string SQL_STATEMENT = "select * from Maestro_Horario as mh inner join EspecialidadPersona as ep on ep.Legajo=mh.Legajo where  Turno=@turno and año=@año and disponible=1  and ID_Especialidad=(select ID_Especialidad from Especialidad where Especialidad='Maestro' )  ";
            List<MaestroHorario> result = new List<MaestroHorario>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Turno", DbType.String, entity.turno);
                db.AddInParameter(cmd, "@Año", DbType.Int32, entity.año);


                using (IDataReader dr = db.ExecuteReader(cmd))
                {

                    while (dr.Read())
                    {
                        MaestroHorario roles = ALoad(dr);
                        result.Add(roles);
                    }
                }
            }
            return result;
        }
        public MaestroHorario ReadByNoGrado(MaestroHorario entity)
        {
            const string SQL_STATEMENT = "select * from Maestro_Horario where Legajo=@Legajo and DiaSemana=@DiaSemana and Turno=@Turno and hora=@hora and año=@Año and  disponible=1  ";
            MaestroHorario roles = null;

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Legajo", DbType.Int32, entity.persona.Id);

                db.AddInParameter(cmd, "@DiaSemana", DbType.Int32, entity.diaSemana);
                db.AddInParameter(cmd, "@Turno", DbType.String, entity.turno);
                db.AddInParameter(cmd, "@año", DbType.Int32, entity.año);
                db.AddInParameter(cmd, "@hora", DbType.Int32, entity.hora);
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
        public void Update(MaestroHorario entity)
        {
            throw new NotImplementedException();
        }

        public List<MaestroHorario> ReadByListado(string id)
        {
            throw new NotImplementedException();
        }
    }
}
