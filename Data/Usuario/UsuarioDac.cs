using Microsoft.Practices.EnterpriseLibrary.Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Usuario;
using Entitites.Negocio.Personas;

namespace Data
{
    public class UsuarioDac : DataAccessComponent, IRepository2<Usuarios>
    {
        #region Usuario
        private Usuarios LoadUsuarioa(IDataReader dr)
        {
            DigitoVerificadorH digitoVerificadorH = new DigitoVerificadorH();
            digitoVerificadorH.DVH= GetDataValue<string>(dr, "DVH");
            Usuarios usuarios = new Usuarios(digitoVerificadorH);
            usuarios.Id = GetDataValue<int>(dr, "Id");
            usuarios.UserName = GetDataValue<string>(dr, "UserName");
            usuarios.Nombre = GetDataValue<string>(dr, "Nombre");
            usuarios.Apellido = GetDataValue<string>(dr, "Apellido");
            usuarios.Email = GetDataValue<string>(dr, "Email");
      
            usuarios.Bloqueado = GetDataValue<bool>(dr, "Bloqueado");
            usuarios.CantidadIntentos = GetDataValue<int>(dr, "CantidadIntentos");
            usuarios.Password = GetDataValue<string>(dr, "Password");
            return usuarios;
        }
        public Usuarios Create(Usuarios entity)
        {
            const string SQL_STATEMENT = "insert into Usuario(UserName,Email,Password,Bloqueado,CantidadIntentos,Activo,DVH,Nombre,Apellido)values(@UserName,@Email,@Password,0,0,1,@DVH,@Nombre,@Apellido)";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@UserName", DbType.String, entity.UserName);
                db.AddInParameter(cmd, "@Email", DbType.String, entity.Email);
                db.AddInParameter(cmd, "@Password", DbType.String, entity.Password);
                db.AddInParameter(cmd, "@Nombre", DbType.String, entity.Nombre);
                db.AddInParameter(cmd, "@Apellido", DbType.String, entity.Apellido);
                db.AddInParameter(cmd, "@DVH", DbType.String, entity.DVH.DVH);
                db.ExecuteNonQuery(cmd);
            }
            return ReadByEmail(entity.Email);
        }

        public void Bloquear(int id)
        {
            const string SQL_STATEMENT = "update Usuario set Bloqueado=1 where id=@Id";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.String, id);
                db.ExecuteNonQuery(cmd);
            }
        }

        public void Desbloquear(int id)
        {
            const string SQL_STATEMENT = "update Usuario set Bloqueado=0 , CantidadIntentos=0 where id=@Id";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.String, id);
                db.ExecuteNonQuery(cmd);
            }
        }

        public void Delete(int id)
        {
            const string SQL_STATEMENT = "update Usuario set Activo=0 where id=@Id";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                db.ExecuteNonQuery(cmd);
            }
        }

        public List<Usuarios> Read()
        {
            const string SQL_STATEMENT = "select * from Usuario where activo=1";

            List<Usuarios> result = new List<Usuarios>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Usuarios usuarios = LoadUsuarioa(dr);
                        result.Add(usuarios);
                    }
                }
            }
            return result;
        }
        public List<Usuarios> ReadDVH()
        {
            const string SQL_STATEMENT = "select DVH from Usuario";

            List<Usuarios> result = new List<Usuarios>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        DigitoVerificadorH digitoVerificadorH = new DigitoVerificadorH();
                        digitoVerificadorH.DVH= GetDataValue<string>(dr, "DVH");
                        Usuarios usuarios = new Usuarios(digitoVerificadorH);
                     
                        result.Add(usuarios);
                    }
                }
            }
            return result;
        }

        public Usuarios ReadBy(int id)
        {
            const string SQL_STATEMENT = "select * from Usuario where activo=1 and id=@Id";
            Usuarios usuarios = null;

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        usuarios = LoadUsuarioa(dr);
                    }
                }
            }
            return usuarios;
        }

        public Usuarios ReadByEmail(string emailUsername)
        {
            const string SQL_STATEMENT = "select * from Usuario where activo=1 and UserName=@Id";
            Usuarios usuarios = null;

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.String, emailUsername);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        usuarios = LoadUsuarioa(dr);
                    }
                }
            }
            return usuarios;
        }

        public void Update(Usuarios entity)
        {
            const string SQL_STATEMENT = "update Usuario set Nombre=@Nombre, Apellido=@Apellido where id=@id ";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Nombre", DbType.String, entity.Nombre);
                db.AddInParameter(cmd, "@Apellido", DbType.String, entity.Apellido);
                db.AddInParameter(cmd, "@id", DbType.String, entity.Id);
                db.ExecuteNonQuery(cmd);
            }
        }
        public void UpdatePassword(Usuarios entity)
        {
         
            const string SQL_STATEMENT = "update Usuario set password=@password, DVH=@DVH where id=@id ";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@password", DbType.String, entity.Password);
                db.AddInParameter(cmd, "@DVH", DbType.String, entity.DVH.DVH);
                db.AddInParameter(cmd, "@id", DbType.String, entity.Id);
       
                db.ExecuteNonQuery(cmd);
            }
        }
        public int UpdateIntentos(int cantidad,int legajo)
        {

            const string SQL_STATEMENT = "update Usuario set CantidadIntentos=@CantidadIntentos where id=@id ";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@CantidadIntentos", DbType.Int32, cantidad);
                db.AddInParameter(cmd, "@id", DbType.Int32, legajo);


                db.ExecuteNonQuery(cmd);
            }
            return ReadBy(legajo).CantidadIntentos;
        }
        public Usuarios ReadBy(string id)
        {
            throw new NotImplementedException();
        }

        public Usuarios ALoad(IDataReader entity)
        {
            throw new NotImplementedException();
        }

        public List<Usuarios> ReadByListado(string id)
        {
            const string SQL_STATEMENT = "select * from Usuario where activo=1 and email=@Id";

            List<Usuarios> result = new List<Usuarios>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.String, id);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Usuarios usuarios = LoadUsuarioa(dr);
                        result.Add(usuarios);
                    }
                }
            }
            return result;
        }
        #endregion


        #region UsuarioPersona

        public Usuarios AgregarUsuarioAlaPersona(Usuarios entity,Persona  persona)
        {
            const string SQL_STATEMENT = "insert into UsuarioPersona(Legajo,Id)values(@Legajo,@Id)";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Legajo", DbType.Int32, persona.Id);
                db.AddInParameter(cmd, "@Id", DbType.Int32, entity.Id);
                entity.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }
            return entity;
        }

        #endregion
    }
}
