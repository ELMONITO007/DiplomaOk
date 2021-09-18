using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Data;
using Negocio.Gestion_de_Personas;
using System.Globalization;
using Data.Gestion_de_Boletin;
using Negocio.Gestion_de_Alumnos;

namespace Negocio.Gestion_de_boletin
{
    public class MateriaComponent : IRepository2<Materia>
    {
        public List<Materia> buscar(string palabra)
        {
            List<Materia> entity = new List<Materia>();

            entity = Read();
            List<Materia> result = new List<Materia>();
            foreach (Materia item in entity)
            {
                if (item.materia.Contains(palabra))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public Materia Create(Materia entity)
        {
            if (Verificar(entity))
            {
                MateriaDAC materiaDAC = new MateriaDAC();



                return materiaDAC.Create(entity);
            }
            else
            {
                return null;
            }
        }

        public void Delete(int id)
        {
            MateriaDAC materiaDAC = new MateriaDAC();
            materiaDAC.Delete(id);
        }

        public List<Materia> Read()
        {
            MateriaDAC materiaDAC = new MateriaDAC();
            List<Materia> result = new List<Materia>();

            foreach (var item in materiaDAC.Read())
            {
                EspecialidadComponent especialidadComponent = new EspecialidadComponent();
                Especialidad especialidad = new Especialidad();
                especialidad = especialidadComponent.ReadBy(item.especialidad.Id);
                Materia materia = new Materia(especialidad);
                materia.Id = item.Id;
                materia.materia = item.materia;
          
                result.Add(materia);
            }
            return result;
        }
        public List<Materia> ReadByEspecialidad(int legajo)
        {
            MateriaDAC materiaDAC = new MateriaDAC();
            List<Materia> result = new List<Materia>();

            foreach (var item in materiaDAC.ReadByEspecialidad(legajo))
            {
                EspecialidadComponent especialidadComponent = new EspecialidadComponent();
                Especialidad especialidad = new Especialidad();
                especialidad = especialidadComponent.ReadBy(item.especialidad.Id);
                Materia materia = new Materia(especialidad);
                materia.Id = item.Id;
                materia.materia = item.materia;
                result.Add(materia);
            }
            return result;

        }

        public Materia ReadBy(int id)
        {
            MateriaDAC materiaDAC = new MateriaDAC();
            Materia materia = new Materia();
            materia = materiaDAC.ReadBy(id);

            EspecialidadComponent especialidadComponent = new EspecialidadComponent();
            Especialidad especialidad = new Especialidad();
            especialidad = especialidadComponent.ReadBy(materia.especialidad.Id);
            Materia result = new Materia(especialidad);
            result.Id = materia.Id;
            result.materia = materia.materia;
        
            return result;
        }

        public Materia ReadBy(string id)
        {
            MateriaDAC materiaDAC = new MateriaDAC();
            return materiaDAC.ReadBy(id);
        }

        public bool Update(Materia entity)
        {
            MateriaDAC materiaDAC = new MateriaDAC();
            materiaDAC.Update(entity);
            return true;
        }

        public bool Verificar(Materia entity)
        {

            if (ReadBy(entity.materia) == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

