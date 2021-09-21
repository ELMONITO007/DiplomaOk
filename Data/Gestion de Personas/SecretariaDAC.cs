using Entities;
using Entitites.Negocio.Personas;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace Data.Gestion_de_Personas
{
  public  class SecretariaDAC : DataAccessComponent, IRepository2<Secretaria>
    {
        public Secretaria ALoad(IDataReader entity)
        {
            Secretaria palabra = new Secretaria();
            palabra.Id = GetDataValue<int>(entity, "legajo");
            palabra.nombre = GetDataValue<string>(entity, "nombre");
            palabra.apellido = GetDataValue<string>(entity, "apellido");
            palabra.DNI = GetDataValue<string>(entity, "DNI");
            palabra.direccion = GetDataValue<string>(entity, "direccion");
            palabra.fechaNacimiento = GetDataValue<DateTime>(entity, "fechaNacimiento");
            palabra.tipoPersona = GetDataValue<string>(entity, "Tipo_Persona");

            palabra.nombreCompleto = palabra.nombre + " " + palabra.apellido;
            return palabra;
        }

        public Secretaria Create(Secretaria entity)
        {
            const string SQL_STATEMENT = "insert into Persona(nombre,apellido,direccion,DNI,ID_Tipo_Persona,fechaNacimiento,activo)values(@nombre,@apellido,@direccion,@DNI,@tipoPersona,@fechaNacimiento,1)";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@nombre", DbType.String, entity.nombre);
                db.AddInParameter(cmd, "@apellido", DbType.String, entity.apellido);
                db.AddInParameter(cmd, "@direccion", DbType.String, entity.direccion);
                db.AddInParameter(cmd, "@DNI", DbType.String, entity.DNI);
                db.AddInParameter(cmd, "@tipoPersona", DbType.String, "Secretaria");
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

        public List<Secretaria> Read()
        {
            const string SQL_STATEMENT = "select * from Persona where Tipo_Persona='Secretaria' and  activo=1";

            List<Secretaria> result = new List<Secretaria>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Secretaria roles = ALoad(dr);
                        result.Add(roles);
                    }
                }
            }
            return result;
        }


        public Secretaria ReadBy(int id)
        {
            const string SQL_STATEMENT = "select * from Persona where  activo=1 and Legajo=@Id";
            Secretaria roles = null;

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

        public Secretaria ReadByEmail(string email)
        {
            const string SQL_STATEMENT = "select * from UsuarioPersona as up join Persona as p on p.Legajo=up.Legajo  join Usuario as u on u.Id=up.Id where Email=@Id";
            Secretaria roles = null;

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.String, email);
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

        public Secretaria ReadBy(string id)
        {
            const string SQL_STATEMENT = "select * from Persona where  activo=1 and dni=@Id";
            Secretaria roles = null;

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

        public void Update(Secretaria entity)
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

        public List<Secretaria> ReadByListado(string id)
        {
            throw new NotImplementedException();
        }

    }
}
