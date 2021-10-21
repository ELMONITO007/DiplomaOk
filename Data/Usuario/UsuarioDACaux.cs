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
    }
}
