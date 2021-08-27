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
    public class SalaComponent : IRepository2<Sala>
    {
        public List<Sala> buscar(string palabra)
        {
            List<Sala> entity = new List<Sala>();
          
            entity = Read();
            List<Sala> result = new List<Sala>();
            foreach (Sala item in entity)
            {
                if (item.nombre.ToString().Contains(palabra))
                {
                    result.Add(item);
                }
            }

            return result;
        }
      public  List<Sala> ReadTipoSala()

        {
            SalaDac salaDac = new SalaDac();
           return salaDac.ReadTipoSala();
        
        
        }
        public Sala Create(Sala entity)
        {
            if (Verificar(entity))
            {
                SalaDac salaDac = new SalaDac();
             
             
             

                return salaDac.Create(entity);
            }
            else
            {
                return null;
            }
        }

        public void Delete(int id)
        {
            SalaDac salaDac = new SalaDac();
            salaDac.Delete(id);
        }

        public List<Sala> Read()
        {
            SalaDac salaDac = new SalaDac();
            List<Sala> result = new List<Sala>();

            foreach (var item in salaDac.Read())
            {
                Sala sala = new Sala();
                sala = item;

                result.Add(sala);
            }

            return result;
        }
        public List<Sala> ReadByTipo(string tipo)
        {
            SalaDac salaDac = new SalaDac();
            List<Sala> result = new List<Sala>();

            foreach (var item in salaDac.ReadByTipo(tipo))
            {
                Sala sala = new Sala();
                sala = item;
               
                result.Add(sala);
            }

            return result;
        }
        public Sala ReadBy(int id)
        {
            SalaDac salaDac = new SalaDac();
          Sala result = new Sala();
            result = salaDac.ReadBy(id);
           
            
            return result;
        }

        public Sala ReadBy(string id)
        {
            SalaDac salaDac = new SalaDac();
            Sala result = new Sala();
            result = salaDac.ReadBy(id);
           

            return result;
        }

        public bool Update(Sala entity)
        {
            SalaDac salaDac = new SalaDac();
            salaDac.Update(entity);
            return true;
        }

        public bool Verificar(Sala entity)
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
