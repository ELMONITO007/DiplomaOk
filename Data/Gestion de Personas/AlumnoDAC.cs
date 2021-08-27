﻿using Entities;
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
 public   class AlumnoDAC : DataAccessComponent, IRepository2<Alumno>
    {

        public Alumno ALoad(IDataReader entity)
        {
            Alumno palabra = new Alumno();
            palabra.Id = GetDataValue<int>(entity, "legajo");
            palabra.nombre = GetDataValue<string>(entity, "nombre");
            palabra.apellido = GetDataValue<string>(entity, "apellido");
            palabra.DNI = GetDataValue<string>(entity, "DNI");
            palabra.direccion = GetDataValue<string>(entity, "direccion");
            palabra.fechaNacimiento = GetDataValue<DateTime>(entity, "fechaNacimiento");
            
            palabra.nombreCompleto = palabra.nombre + " " + palabra.apellido;
            return palabra;
        }

        public Alumno Create(Alumno entity)
        {
            const string SQL_STATEMENT = "insert into Persona(nombre,apellido,direccion,DNI,ID_Tipo_Persona,fechaNacimiento,activo)values(@nombre,@apellido,@direccion,@DNI,(select ID_Tipo_Persona from TipoPersona  where Descripcion=@tipoPersona),@fechaNacimiento,1)";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@nombre", DbType.String, entity.nombre);
                db.AddInParameter(cmd, "@apellido", DbType.String, entity.apellido);
                db.AddInParameter(cmd, "@direccion", DbType.String, entity.direccion);
                db.AddInParameter(cmd, "@DNI", DbType.String, entity.DNI);
                db.AddInParameter(cmd, "@tipoPersona", DbType.String,"Alumno");
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

        public List<Alumno> Read()
        {
            const string SQL_STATEMENT = "select * from Persona where  activo=1";

            List<Alumno> result = new List<Alumno>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Alumno roles = ALoad(dr);
                        result.Add(roles);
                    }
                }
            }
            return result;
        }

        //cambiar
        public List<Alumno> ReadByTipoPersona(int tipo)
        {
            const string SQL_STATEMENT = "select * from Persona where Activo=1 and ID_Tipo_Persona=@Id";

            List<Alumno> result = new List<Alumno>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, tipo);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Alumno roles = ALoad(dr);
                        result.Add(roles);
                    }
                }
            }
            return result;
        }
        public List<Alumno> ReadByAlumno()
        {
            const string SQL_STATEMENT = "select * from Persona where  activo=1 and ID_Tipo_Persona=(select ID_Tipo_Persona from TipoPersona  where Descripcion=@Id) ";

            List<Alumno> result = new List<Alumno>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, "Alumno");
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Alumno roles = ALoad(dr);
                        result.Add(roles);
                    }
                }
            }
            return result;
        }
        public Alumno ReadBy(int id)
        {
            const string SQL_STATEMENT = "select * from Persona where  activo=1 and Legajo=@Id";
            Alumno roles = null;

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



        public Alumno ReadBy(string id)
        {
            const string SQL_STATEMENT = "select * from Persona where  activo=1 and dni=@Id";
            Alumno roles = null;

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
        public List<Alumno> ReadByFechaNacimiento(DateTime fechaInicio, DateTime fechaFinal)
        {
            const string SQL_STATEMENT = "select * from Persona where ID_Tipo_Persona=(select ID_Tipo_Persona from TipoPersona where Descripcion='alumno')and  fechaNacimiento BETWEEN @fechaInicio AND @fechaFinal and Activo=1";

            List<Alumno> result = new List<Alumno>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@fechaInicio", DbType.Date, fechaInicio);
                db.AddInParameter(cmd, "@fechaFinal", DbType.Date, fechaFinal);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Alumno roles = ALoad(dr);
                        result.Add(roles);
                    }
                }
            }
            return result;
        }
        public void Update(Alumno entity)
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

        public List<Alumno> ReadByListado(string id)
        {
            throw new NotImplementedException();
        }
    }
}
