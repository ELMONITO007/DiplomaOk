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
    #region ParienteAlumno
    public class ParienteDAC : DataAccessComponent
    {
        public Pariente ALoad(IDataReader entity)
        {
            Alumno alumno = new Alumno();
            alumno.Id = GetDataValue<int>(entity, "Legajo_Alumno");
            Pariente palabra = new Pariente(alumno);
 
       
            palabra.Id = GetDataValue<int>(entity, "Legajo_Adulto");

            palabra.parentesco = GetDataValue<string>(entity, "Parentesco");

            palabra.autorizadoRetirar = GetDataValue<bool>(entity, "AutorizadoRetirar");
   
            palabra.nombre = GetDataValue<string>(entity, "nombre");
            palabra.apellido = GetDataValue<string>(entity, "apellido");
            palabra.DNI = GetDataValue<string>(entity, "DNI");
            palabra.direccion = GetDataValue<string>(entity, "direccion");
            palabra.fechaNacimiento = GetDataValue<DateTime>(entity, "fechaNacimiento");
            palabra.tipoPersona = GetDataValue<string>(entity, "Tipo_Persona");



            return palabra;
        }



        public Pariente CreateParienteAlumno(Pariente entity)
        {
            const string SQL_STATEMENT = "insert into Parentesco(Legajo_Alumno,Legajo_Adulto,autorizadoRetirar,parentesco)values (@alumno,@adulto,@autorizadoRetirar,@parentesco)";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@alumno", DbType.Int32, entity.alumno.Id);
                db.AddInParameter(cmd, "@adulto", DbType.Int32, entity.Id);

                db.AddInParameter(cmd, "@autorizadoRetirar", DbType.Boolean, entity.autorizadoRetirar);
                db.AddInParameter(cmd, "@parentesco", DbType.String, entity.parentesco);



                entity.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }
            return entity;
        }

        public void DeleteParienteAlumno(int id)
        {
            const string SQL_STATEMENT = "Delete from Parentesco where Id_Parentesco=@Id";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                db.ExecuteNonQuery(cmd);
            }
        }


        public List<Pariente> ReadParienteAlumno()
        {
            const string SQL_STATEMENT = "select * from Parentesco join Persona as p on p.Legajo=Parentesco.Legajo_Adulto ";

            List<Pariente> result = new List<Pariente>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Pariente roles = ALoad(dr);
                        result.Add(roles);
                    }
                }
            }
            return result;
        }

        public Pariente ReadByParienteAlumno(int id)
        {
            const string SQL_STATEMENT = "select * from Parentesco join Persona as p on p.Legajo=Parentesco.Legajo_Adulto where  Id_Parentesco=@Id";
            Pariente roles = null;

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

        public Pariente ReadByParienteAlumno(string id)
        {
            throw new NotImplementedException();
        }
        public Pariente ReadByParienteAlumno(Pariente entity)
        {
            const string SQL_STATEMENT = "select * from Parentesco join Persona as p on p.Legajo=Parentesco.Legajo_Adulto  where Legajo_Alumno=@Legajo_Alumno  and  Legajo_Adulto=@Legajo_Adulto";

            Pariente result = null;
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Legajo_Alumno", DbType.Int32, entity.alumno.Id);
                db.AddInParameter(cmd, "@Legajo_Adulto", DbType.Int32, entity.Id);
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
        public List<Pariente> ReadByAlumno(int id)
        {
            const string SQL_STATEMENT = "select * from Parentesco join Persona as p on p.Legajo=Parentesco.Legajo_Adulto  where Legajo_Alumno=@Legajo_Alumno ";

            List<Pariente> result = new List<Pariente>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Legajo_Alumno", DbType.Int32, id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Pariente roles = ALoad(dr);
                        result.Add(roles);
                    }
                }
            }
            return result;
        }
        public List<Pariente> ReadByAdulto(int id)
        {
            const string SQL_STATEMENT = "select * from Parentesco join Persona as p on p.Legajo=Parentesco.Legajo_Adulto where Legajo_Adulto=@Legajo_Adulto ";

            List<Pariente> result = new List<Pariente>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Legajo_Adulto", DbType.Int32, id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Pariente roles = ALoad(dr);
                        result.Add(roles);
                    }
                }
            }
            return result;
        }


        #endregion

        #region Pariente
        public Pariente ALoadPariente(IDataReader entity)
        {
            Pariente palabra = new Pariente();

            palabra.Id = GetDataValue<int>(entity, "legajo");
            palabra.nombre = GetDataValue<string>(entity, "nombre");
            palabra.apellido = GetDataValue<string>(entity, "apellido");
            palabra.DNI = GetDataValue<string>(entity, "DNI");
            palabra.direccion = GetDataValue<string>(entity, "direccion");
            palabra.fechaNacimiento = GetDataValue<DateTime>(entity, "fechaNacimiento");
            palabra.tipoPersona = GetDataValue<string>(entity, "Tipo_Persona");



            return palabra;
        }

        public Pariente Create(Pariente entity)
        {
            const string SQL_STATEMENT = "insert into Persona(nombre,apellido,direccion,DNI,ID_Tipo_Persona,fechaNacimiento,activo)values(@nombre,@apellido,@direccion,@DNI,@tipoPersona,@fechaNacimiento,1)";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@nombre", DbType.String, entity.nombre);
                db.AddInParameter(cmd, "@apellido", DbType.String, entity.apellido);
                db.AddInParameter(cmd, "@direccion", DbType.String, entity.direccion);
                db.AddInParameter(cmd, "@DNI", DbType.String, entity.DNI);
                db.AddInParameter(cmd, "@tipoPersona", DbType.String, "Pariente");
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

        public Pariente ReadBy(int id)
        {
            const string SQL_STATEMENT = "select * from Persona where  activo=1 and Legajo=@Id";
            Pariente roles = null;

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        roles = ALoadPariente(dr);
                    }
                }
            }
            return roles;
        }



        public Pariente ReadBy(string id)
        {
            const string SQL_STATEMENT = "select * from Persona where  activo=1 and dni=@Id";
            Pariente roles = null;

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.String, id);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        roles = ALoadPariente(dr);
                    }
                }
            }
            return roles;
        }
        public void Update(Pariente entity)
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

        #endregion


    }
}
