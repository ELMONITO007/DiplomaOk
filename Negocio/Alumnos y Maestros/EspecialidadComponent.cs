using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Data;
using Data.Gestion_de_Personas;

namespace Negocio.Gestion_de_Alumnos
{
    public class EspecialidadComponent : IRepository2<Especialidad>
    {
        public List<Especialidad> buscar(string palabra)
        {
            List<Especialidad> entity = new List<Especialidad>();

            entity = Read();
            List<Especialidad> result = new List<Especialidad>();
            foreach (Especialidad item in entity)
            {
                if (item.especialidad.ToString().Contains(palabra))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public Especialidad Create(Especialidad entity)
        {
            if (Verificar(entity))
            {
                EspecialidadDAC especialidadDAC = new EspecialidadDAC();

                return especialidadDAC.Create(entity);
            }
            else
            {
                return null;
            }
        }

        public void Delete(int id)
        {
            EspecialidadDAC especialidadDAC = new EspecialidadDAC();
            especialidadDAC.Delete(id);
        }

        public List<Especialidad> Read()
        {
            EspecialidadDAC especialidadDAC = new EspecialidadDAC();
            return especialidadDAC.Read();
        }

        public Especialidad ReadBy(int id)
        {
            EspecialidadDAC especialidadDAC = new EspecialidadDAC();
            return especialidadDAC.ReadBy(id);
        }

        public Especialidad ReadBy(string id)
        {
            EspecialidadDAC especialidadDAC = new EspecialidadDAC();
            return especialidadDAC.ReadBy(id);
        }

        public bool Update(Especialidad entity)
        {
            EspecialidadDAC especialidadDAC = new EspecialidadDAC();
            especialidadDAC.Update(entity);
            return true;
        }

        public bool Verificar(Especialidad entity)
        {
            if (ReadBy(entity.especialidad) == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<Especialidad> ReadByPersona(int legajo)

        {

            EspecialidadDAC especialidadDAC = new EspecialidadDAC();
            return especialidadDAC.ReadByPersona(legajo);

        }
    }
}
