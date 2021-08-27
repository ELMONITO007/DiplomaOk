using Data;
using Entities;
using Entitites.Negocio.Salas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class GradoComponent : IRepository2<Grado>
    {
        public List<Grado> buscar(string palabra)
        {
            List<Grado> entity = new List<Grado>();

            entity = Read();
            List<Grado> result = new List<Grado>();
            foreach (Grado item in entity)
            {
                if (item.nombre.ToString().Contains(palabra) || item.año.ToString().Contains(palabra) )
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public Grado Create(Grado entity)
        {
            if (Verificar(entity))
            {
                GradoDAC gradoDAC = new GradoDAC();
                return gradoDAC.Create(entity);
            }
            else
            {
                return null;
            }
        }

        public void Delete(int id)
        {
            GradoDAC gradoDAC = new GradoDAC();
            gradoDAC.Delete(id);
        }

        public List<Grado> Read()
        {
            GradoDAC gradoDAC = new GradoDAC();
            return gradoDAC.Read();

        }

        public Grado ReadBy(int id)
        {
            GradoDAC gradoDAC = new GradoDAC();
            return gradoDAC.ReadBy(id);
        }

        public Grado ReadBy(string id)
        {
            GradoDAC gradoDAC = new GradoDAC();
            return gradoDAC.ReadBy(id);
        }

        public bool Update(Grado entity)
        {
            GradoDAC gradoDAC = new GradoDAC();
            gradoDAC.Update(entity);
            return true;
        }

        public bool Verificar(Grado entity)
        {
            if (ReadBy(entity.nombre) == null)
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
