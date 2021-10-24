using Entities;
using Entitites.Negocio.Personas;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data.Gestion_de_Personas
{
  public  class TelefonoDAC : DataAccessComponent, IRepository2<Telefono>
    {

        #region TelefonoPersona

        public Telefono AgregarTelefonoAUnaPersona(Telefono telefono, Persona persona)
        {
            const string SQL_STATEMENT = "insert into TelefonoPersona(Legajo,ID_Telefono)values(@Legajo,@ID_Telefono)";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Legajo", DbType.Int32, persona.Id);
                db.AddInParameter(cmd, "@ID_Telefono", DbType.Int32, telefono.Id);
                telefono.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }
            return telefono;
        }
        public void QuitarTelefonoAUnaPersona(Telefono telefono, Persona persona)
        {
            const string SQL_STATEMENT = "Delete from palabra where legajo=@legajo and  telefono=@telefono";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@legajo", DbType.Int32, persona.Id);
                db.AddInParameter(cmd, "@telefono", DbType.Int32, telefono.Id);
                db.ExecuteNonQuery(cmd);
            }


        }
        public List<Telefono> ReadByPersona(int legajo)
        {
            const string SQL_STATEMENT = "select * from TelefonoPersona as tp join Telefono as t on tp.ID_Telefono=t.ID_Telefono where Activo=1 and Legajo=@legajo";
            List<Telefono> result = new List<Telefono>();

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Legajo", DbType.Int32, legajo);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Telefono roles = ALoad(dr);
                        result.Add(roles);
                    }
                }
            }
            return result;
        }

        public Telefono ReadByPersonaYTelefono(Telefono telefono, Persona persona)
        {
            const string SQL_STATEMENT = "select tp.ID_Telefono,tp.Legajo from TelefonoPersona as tp join Telefono as t on tp.ID_Telefono=t.ID_Telefono where Activo=1 and Legajo=@legajo and tp.ID_Telefono=@telefono";
            Telefono roles = null;

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@legajo", DbType.String, persona.Id);
                db.AddInParameter(cmd, "@telefono", DbType.String, telefono.Id);
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

        #endregion

        #region Telefono

        public Telefono ALoad(IDataReader entity)
        {
            Telefono palabra = new Telefono();
            palabra.Id = GetDataValue<int>(entity, "ID_Telefono");
            palabra.codigo_Area = GetDataValue<int>(entity, "Codigo_Area");
            palabra.numero = GetDataValue<int>(entity, "Numero");
            palabra.descripcion = GetDataValue<string>(entity, "Descripcion");
            return palabra;
        }

        public Telefono Create(Telefono entity)
        {

            const string SQL_STATEMENT = "insert into Telefono(codigo_Area,Numero,Descripcion,activo)values(@codigo_Area,@Numero,@Descripcion,1)";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@codigo_Area", DbType.Int32, entity.codigo_Area);
                db.AddInParameter(cmd, "@Numero", DbType.Int32, entity.numero);
                db.AddInParameter(cmd, "@Descripcion", DbType.String, entity.descripcion);
                entity.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }
            return entity;
        }

        public void Delete(int id)
        {
            const string SQL_STATEMENT = "update Telefono set Activo=0 where id_Telefono=@Id";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                db.ExecuteNonQuery(cmd);
            }
        }

        public List<Telefono> Read()
        {
            const string SQL_STATEMENT = "select * from Telefono where  activo=1";

            List<Telefono> result = new List<Telefono>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Telefono roles = ALoad(dr);
                        result.Add(roles);
                    }
                }
            }
            return result;
        }

        public Telefono ReadBy(int id)
        {
            const string SQL_STATEMENT = "select * from Telefono where  activo=1 and id_Telefono=@Id";
            Telefono roles = null;

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

        public Telefono ReadBy(string id)
        {
            throw new NotImplementedException();
        }
        public Telefono ReadBy(Telefono telefono)
        {
            const string SQL_STATEMENT = "select * from Telefono where  activo=1 and codigo_area=@area and numero=@telefono";
            Telefono roles = null;

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@area", DbType.Int32, telefono.codigo_Area);
                db.AddInParameter(cmd, "@telefono", DbType.Int32, telefono.numero);
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

        public List<Telefono> ReadByListado(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(Telefono entity)
        {
            const string SQL_STATEMENT = "update Idioma set codigo_Area=@codigo_Area, Numero=@Numero, Descripcion=@Descripcion where id_Telefono=@id ";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@codigo_Area", DbType.Int32, entity.codigo_Area);
                db.AddInParameter(cmd, "@Numero", DbType.Int32, entity.numero);
                db.AddInParameter(cmd, "@Descripcion", DbType.String, entity.descripcion);
                db.AddInParameter(cmd, "@id", DbType.String, entity.Id);
                db.ExecuteNonQuery(cmd);
            }
        }
        #endregion
    }
}
