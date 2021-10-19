using Microsoft.Practices.EnterpriseLibrary.Data;

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Entities.Usuario;

namespace Data.Servicios
{
    public class BitacoraDAC : DataAccessComponent
    {
        private Bitacora LoadBitacora(IDataReader dr)
        {
            EventoBitacora eventoBitacora = new EventoBitacora();
            eventoBitacora.Id = GetDataValue<int>(dr, "ID_EventoBitacora");
            Usuarios usuarios = new Usuarios();
           usuarios.Id = GetDataValue<int>(dr, "Id");
            Bitacora bitacora = new Bitacora(usuarios, eventoBitacora);
            bitacora.Id = GetDataValue<int>(dr, "ID_Bitacora");
     
        
            bitacora.fecha = GetDataValue<string>(dr, "Fecha");
            bitacora.hora = GetDataValue<string>(dr, "Hora");

            return bitacora;
        }
        public Bitacora Create(Bitacora entity)
        {
            const string SQL_STATEMENT = "insert into Bitacora(Id,ID_EventoBitacora,Fecha,Hora)values(@id,@ID_EventoBitacora,@Fecha,@Hora) ";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_Aux);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@id", DbType.Int32, entity.usuarios.Id);
                db.AddInParameter(cmd, "@ID_EventoBitacora", DbType.Int32, entity.eventoBitacora.Id);

                db.AddInParameter(cmd, "@Fecha", DbType.String, entity.fecha);
                db.AddInParameter(cmd, "@Hora", DbType.String, entity.hora);
                entity.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }
            return entity;
        }

       

        public List<Bitacora> Read()
        {
            const string SQL_STATEMENT = "select * from Bitacora";

            List<Bitacora> result = new List<Bitacora>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_Aux);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Bitacora tipoPregunta = LoadBitacora(dr);
                        result.Add(tipoPregunta);
                    }

                }
            }
            return result;
        }


        public List<Bitacora> ReadbyFecha(string fechaInicio,string fechaFinal)
        {
            const string SQL_STATEMENT = "select * from Bitacora where Fecha>=@fechaInicio and Fecha <=@fechaFinal";

            List<Bitacora> result = new List<Bitacora>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_Aux);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@fechaInicio", DbType.String, fechaInicio);
                db.AddInParameter(cmd, "@fechaFinal", DbType.String, fechaFinal);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Bitacora tipoPregunta = LoadBitacora(dr);
                        result.Add(tipoPregunta);
                    }

                }
            }
            return result;
        }
        public List<Bitacora> ReadbyCriticidad(string criticidad)
        {
            const string SQL_STATEMENT = "select * from Bitacora as b join EventoBitacora as eb on eb.ID_EventoBitacora=b.ID_EventoBitacora where Criticidad=@criticidad";

            List<Bitacora> result = new List<Bitacora>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_Aux);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@criticidad", DbType.String, criticidad);
           

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Bitacora tipoPregunta = LoadBitacora(dr);
                        result.Add(tipoPregunta);
                    }

                }
            }
            return result;
        }
        public void Update(Bitacora entity)
        {
            throw new NotImplementedException();
        }

        public Bitacora ALoad(IDataReader entity)
        {
            throw new NotImplementedException();
        }

        public List<Bitacora> ReadByListado(string id)
        {
            throw new NotImplementedException();
        }

        public List<Bitacora> ReadByListado(int id)
        {
            throw new NotImplementedException();
        }
    }
}
