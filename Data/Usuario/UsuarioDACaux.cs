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

namespace Data.Usuario
{
 public   class UsuarioDACaux :DataAccessComponent
    {
        public Usuarios ReadByEmail(string emailUsername)
        {
            const string SQL_STATEMENT = "select * from Usuario where activo=1 and UserName=@Id";
            Usuarios usuarios = null;

            var db = DatabaseFactory.CreateDatabase(CONNECTION_Aux);
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
        public void Create(Usuarios entity)
        {
            const string SQL_STATEMENT = "insert into Usuario(UserName,Email,Password,Bloqueado,CantidadIntentos,Activo,DVH,Nombre,Apellido)values(@UserName,@Email,@Password,0,0,1,@DVH,@Nombre,@Apellido)";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_Aux);
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
           
        }
        public List<Usuarios> Read()
        {
            const string SQL_STATEMENT = "select * from Usuario where activo=1";

            List<Usuarios> result = new List<Usuarios>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_Aux);
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
        public void DeleteAll()
        {
            const string SQL_STATEMENT = "Delete  from usuario ";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_Aux);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {

                db.ExecuteNonQuery(cmd);
            }
        }
        private Usuarios LoadUsuarioa(IDataReader dr)
        {
            DigitoVerificadorH digitoVerificadorH = new DigitoVerificadorH();
            digitoVerificadorH.DVH = GetDataValue<string>(dr, "DVH");
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
    }
}
