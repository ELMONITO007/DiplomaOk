using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;

using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using Microsoft.Data.SqlClient;
using System.Data.Common;

namespace Data.Servicios
{
    public class InstalacionDAC : DataAccessComponent
    {

        private string LoadDVV(IDataReader dr)
        {
            string result = GetDataValue<string>(dr, "name");

            return result;
        }

        public List<String> Read()
        {
            const string SQL_STATEMENT = "SELECT name FROM sys.databases;";

            List<String> result = new List<string>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_Restore);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                  while (dr.Read())
                    {

                        result.Add(LoadDVV(dr));
                    }
                }
            }
            return result;
        }


        public void EjecutarScriptAux( string datasource)
        {

            string sqlConnectionString = "Data Source=" + datasource + ";Initial Catalog=Master;Integrated Security=True";
            string script = File.ReadAllText(@"C:\Program Files (x86)\Crear y Ser\scriptaux.sql");

            SqlConnection conn = new SqlConnection(sqlConnectionString);

            Server server = new Server(new ServerConnection(conn));

            server.ConnectionContext.ExecuteNonQuery(script);

            server = null;
            conn.Close();


         

        }
        public void EjecutarScriptPrincipal(string datasource)
        {

            string sqlConnectionString = "Data Source=" + datasource + ";Initial Catalog=Master;Integrated Security=True";
            string script = File.ReadAllText(@"C:\Program Files (x86)\Crear y Ser\script1409.sql");

            SqlConnection conn = new SqlConnection(sqlConnectionString);

            Server server = new Server(new ServerConnection(conn));

            server.ConnectionContext.ExecuteNonQuery(script);

            server = null;
            conn.Close();




        }
    }
}
