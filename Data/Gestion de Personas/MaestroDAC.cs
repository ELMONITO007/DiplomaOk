using Entities;
using Entitites;
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
        #region Maestro
        public Maestro ALoad(IDataReader entity)
        {
            Maestro palabra = new Maestro();
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
        public List<Maestro> ObtenerMaestrodeCunCurso(int id_curso)
        {
            const string SQL_STATEMENT = "select * from CursoAlumno as ca join Persona as p on p.Legajo =ca.Legajo where Tipo_Persona='Maestro' and ca.ID_Curso=@id_curso and p.Activo=1";

            List<Maestro> result = new List<Maestro>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@id_curso", DbType.Int32, id_curso);

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
        public Maestro Create(Maestro entity)
        {
            const string SQL_STATEMENT = "insert into Persona(nombre,apellido,direccion,DNI,ID_Tipo_Persona,fechaNacimiento,activo)values(@nombre,@apellido,@direccion,@DNI,@tipoPersona,@fechaNacimiento,1)";
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
            const string SQL_STATEMENT = "select * from Persona where  activo=1 and Tipo_Persona='Maestro'";

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
        #endregion


        #region MaestroEspecialidad


        public Maestro ALoadEspecialidad(IDataReader entity)
        {
            List<Especialidad> especialidades = new List<Especialidad>();
            especialidades[0].especialidad = GetDataValue<string>(entity, "especialidad");
            especialidades[0].Id = GetDataValue<int>(entity, "ID_Especialidad");

            Maestro palabra = new Maestro(especialidades);
            palabra.Id = GetDataValue<int>(entity, "legajo");
            palabra.nombre = GetDataValue<string>(entity, "nombre");
            palabra.apellido = GetDataValue<string>(entity, "apellido");
            palabra.DNI = GetDataValue<string>(entity, "DNI");
            palabra.direccion = GetDataValue<string>(entity, "direccion");
            palabra.fechaNacimiento = GetDataValue<DateTime>(entity, "fechaNacimiento");

            palabra.nombreCompleto = palabra.nombre + " " + palabra.apellido;
            return palabra;
        }
        public void AgregarEspecialidad(Maestro entity)
        {
            const string SQL_STATEMENT = "insert into EspecialidadPersona(Legajo,ID_Especialidad)values(@Legajo,@ID_Especialidad)";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Legajo", DbType.Int32, entity.Id);
                db.AddInParameter(cmd, "@ID_Especialidad", DbType.Int32, entity.especialidades[0].Id);
                entity.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }
            
        }

        public void QuitarEspecialidad(Maestro entity)
        {
            const string SQL_STATEMENT = "Delete from EspecialidadPersona where legajo=@legajo and  ID_Especialidad=@ID_Especialidad";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@legajo", DbType.Int32, entity.Id);
                db.AddInParameter(cmd, "@ID_Especialidad", DbType.Int32, entity.especialidades[0].Id);
                db.ExecuteNonQuery(cmd);
            }


        }

        public Maestro ReadBy(Maestro legajo)
        {
            const string SQL_STATEMENT = "select * from EspecialidadPersona as ep join Persona as p on p.Legajo=ep.Legajo join Especialidad as e on ep.ID_Especialidad=e.ID_Especialidad where p.Activo=1 and ep.Legajo=@Id and ep.ID_Especialidad=@ID_Especialidad";
            Maestro result = null;

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, legajo.Id);
                db.AddInParameter(cmd, "@ID_Especialidad", DbType.Int32, legajo.especialidades[0].Id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        result = ALoadEspecialidad(dr);

                    }
                }
            }
            return result;
        }
        public List< Maestro> ReadByEspecialidad(Maestro legajo)
        {
            const string SQL_STATEMENT = "select * from EspecialidadPersona as ep join Persona as p on p.Legajo=ep.Legajo join Especialidad as e on ep.ID_Especialidad=e.ID_Especialidad where p.Activo=1  and ep.ID_Especialidad=@ID_Especialidad";
            List< Maestro> result = null;

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {

                db.AddInParameter(cmd, "@ID_Especialidad", DbType.Int32, legajo.especialidades[0].Id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Maestro roles = ALoadEspecialidad(dr);
                        result.Add(roles);
                      

                    }
                }
            }
            return result;
        }
        #endregion

    }
}
