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

namespace Data
{
    public class AsistenciaDAC : DataAccessComponent, IRepository2<Asistencia>
    {
        public Asistencia ALoad(IDataReader entity)
        {
            Alumno alumno = new Alumno();
            alumno.Id = GetDataValue<int>(entity, "legajo");
            Asistencia asistencia = new Asistencia(alumno);

            asistencia.Id = GetDataValue<int>(entity, "ID_Asistencia");
            asistencia.dia = GetDataValue<int>(entity, "dia");
            asistencia.mes = GetDataValue<int>(entity, "mes");
            asistencia.año = GetDataValue<int>(entity, "año");
    
            asistencia.asistio = GetDataValue<bool>(entity, "asistio");

            return asistencia;
        }
        public Asistencia ALoadMes(IDataReader entity)
        {
            Asistencia asistencia = new Asistencia();

            asistencia.mes = GetDataValue<int>(entity, "mes");


            return asistencia;
        }

        public Asistencia Create(Asistencia entity)
        {
            const string SQL_STATEMENT = "insert into Asistencia(dia,mes,año,legajo,asistio)values(@dia,@mes,@año,@legajo,@asistio)";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@dia", DbType.Int32, entity.dia);
                db.AddInParameter(cmd, "@mes", DbType.Int32, entity.mes);
                db.AddInParameter(cmd, "@año", DbType.Int32, entity.año);
                db.AddInParameter(cmd, "@legajo", DbType.Int32, entity.persona.Id);
                db.AddInParameter(cmd, "@asistio", DbType.Boolean, entity.asistio);


                entity.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }
            return entity;
        }

        public void Delete(int id)
        {
            const string SQL_STATEMENT = "delete from Asistencia where ID_Asistencia=@Id";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                db.ExecuteNonQuery(cmd);
            }
        }

        public List<Asistencia> Read()
        {
            const string SQL_STATEMENT = "select * from Asistencia ";

            List<Asistencia> result = new List<Asistencia>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Asistencia usuarios = ALoad(dr);
                        result.Add(usuarios);
                    }
                }
            }
            return result;

        }

        public Asistencia ReadBy(int id)
        {
            const string SQL_STATEMENT = "select * from Asistencia where  ID_Asistencia=@ID_Asistencia";

            Asistencia result = null;
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@ID_Asistencia", DbType.Int32, id);
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

        public List<Asistencia> ReadByAlumno(Asistencia entity)
        {
            const string SQL_STATEMENT = "select * from Asistencia where  legajo=@legajo and año=@año";

            List<Asistencia> result = new List<Asistencia>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@legajo", DbType.Int32, entity.persona.Id);
                db.AddInParameter(cmd, "@año", DbType.Int32, entity.año);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {

                        Asistencia usuarios = ALoad(dr);
                        result.Add(usuarios);

                    }
                }
            }
            return result;
        }
        public List<Asistencia> ObtenerMesesConAsistenciaPorCursoAño(Asistencia entity)
        {
            const string SQL_STATEMENT = "select distinct mes from Asistencia where  legajo=@legajo and año=@año";

            List<Asistencia> result = new List<Asistencia>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@legajo", DbType.Int32, entity.persona.Id);
                db.AddInParameter(cmd, "@año", DbType.Int32, entity.año);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {

                        Asistencia usuarios = ALoadMes(dr);
                        result.Add(usuarios);

                    }
                }
            }
            return result;
        }
        public Asistencia ReadBy(string id)
        {
            throw new NotImplementedException();
        }
        public Asistencia ReadBy(Asistencia entity)
        {
            const string SQL_STATEMENT = "select * from Asistencia where  legajo=@legajo and dia=@dia and mes=@mes and año=@año";

            Asistencia result = null;
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@legajo", DbType.Int32, entity.persona.Id);
                db.AddInParameter(cmd, "@dia", DbType.Int32, entity.dia);
                db.AddInParameter(cmd, "@mes", DbType.Int32, entity.mes);
                db.AddInParameter(cmd, "@año", DbType.Int32, entity.año);
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
        public void Update(Asistencia entity)
        {
            const string SQL_STATEMENT = "update Asistencia set asistio=@asistio where ID_asistio=@Id ";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@id", DbType.Int32, entity.Id);
                db.AddInParameter(cmd, "@asistio", DbType.String, entity.asistio);
                db.ExecuteNonQuery(cmd);
            }
        }

        public List<Asistencia> ReadByListado(string id)
        {
            throw new NotImplementedException();
        }
    }
}
