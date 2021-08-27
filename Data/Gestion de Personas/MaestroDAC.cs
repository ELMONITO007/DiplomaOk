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
  public  class MaestroDAC : DataAccessComponent, IRepository2<Maestro>
    {
        public Maestro ALoad(IDataReader entity)
        {
            Maestro palabra = new Maestro();
            palabra.Id = GetDataValue<int>(entity, "legajo");
            palabra.nombre = GetDataValue<string>(entity, "nombre");
            palabra.apellido = GetDataValue<string>(entity, "apellido");
            palabra.DNI = GetDataValue<string>(entity, "DNI");
            palabra.direccion = GetDataValue<string>(entity, "direccion");
            palabra.fechaNacimiento = GetDataValue<DateTime>(entity, "fechaNacimiento");

            palabra.nombreCompleto = palabra.nombre + " " + palabra.apellido;
            return palabra;
        }

        public Maestro Create(Maestro entity)
        {
            const string SQL_STATEMENT = "insert into Persona(nombre,apellido,direccion,DNI,ID_Tipo_Persona,fechaNacimiento,activo)values(@nombre,@apellido,@direccion,@DNI,(select ID_Tipo_Persona from TipoPersona  where Descripcion=@tipoPersona),@fechaNacimiento,1)";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@nombre", DbType.String, entity.nombre);
                db.AddInParameter(cmd, "@apellido", DbType.String, entity.apellido);
                db.AddInParameter(cmd, "@direccion", DbType.String, entity.direccion);
                db.AddInParameter(cmd, "@DNI", DbType.String, entity.DNI);
                db.AddInParameter(cmd, "@tipoPersona", DbType.String, "Maestro");
                db.AddInParameter(cmd, "@fechaNacimiento", DbType.DateTime, entity.fechaNacimiento);
                entity.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }
            return entity;
        }

        public void Delete(int id)
        {
            const string SQL_STATEMENT = "update Persona set Activo=0 where Legajo=@Id";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                db.ExecuteNonQuery(cmd);
            }
        }

        public List<Maestro> Read()
        {
            const string SQL_STATEMENT = "select * from Persona where  activo=1";

            List<Maestro> result = new List<Maestro>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Maestro roles = ALoad(dr);
                        result.Add(roles);
                    }
                }
            }
            return result;
        }

        //cambiar
        public List<Maestro> ReadByTipoPersona(int tipo)
        {
            const string SQL_STATEMENT = "select * from Persona where Activo=1 and ID_Tipo_Persona=@Id";

            List<Maestro> result = new List<Maestro>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, tipo);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Maestro roles = ALoad(dr);
                        result.Add(roles);
                    }
                }
            }
            return result;
        }
        public List<Maestro> ReadByMastro()
        {
            const string SQL_STATEMENT = "select * from Persona where  activo=1 and ID_Tipo_Persona=(select ID_Tipo_Persona from TipoPersona  where Descripcion=@Id) ";

            List<Maestro> result = new List<Maestro>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, "Maestro");
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Maestro roles = ALoad(dr);
                        result.Add(roles);
                    }
                }
            }
            return result;
        }
        public Maestro ReadBy(int id)
        {
            const string SQL_STATEMENT = "select * from Persona where  activo=1 and Legajo=@Id";
            Maestro roles = null;

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



        public Maestro ReadBy(string id)
        {
            const string SQL_STATEMENT = "select * from Persona where  activo=1 and dni=@Id";
            Maestro roles = null;

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
       
        public void Update(Maestro entity)
        {
            const string SQL_STATEMENT = "update Persona set nombre=@nombre, apellido=@apellido, direccion=@direccion, DNI=@DNI,  fechaNacimiento=@fechaNacimiento  where legajo=@id ";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@nombre", DbType.String, entity.nombre);
                db.AddInParameter(cmd, "@apellido", DbType.String, entity.apellido);
                db.AddInParameter(cmd, "@direccion", DbType.String, entity.direccion);
                db.AddInParameter(cmd, "@DNI", DbType.String, entity.DNI);

                db.AddInParameter(cmd, "@fechaNacimiento", DbType.DateTime, entity.fechaNacimiento);
                db.AddInParameter(cmd, "@id", DbType.String, entity.Id);
                db.ExecuteNonQuery(cmd);
            }
        }

        public List<Maestro> ReadByListado(string id)
        {
            throw new NotImplementedException();
        }
    }
}
