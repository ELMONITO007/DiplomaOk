using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entities;
namespace Negocio.Servicios.Idioma
{
    public class PalabraComponent : IRepository2<Palabra>
    {
        public Palabra Create(Palabra entity)
        {
            if (Verificar(entity))
            {
                PalabraDAC palabraDAC = new PalabraDAC();
                return palabraDAC.Create(entity);
            }
            else
            {
                return null;
            }
        }

        public void Delete(int id)
        {
            PalabraDAC palabraDAC = new PalabraDAC();
            palabraDAC.Delete(id);
        }

        public List<Palabra> Read()
        {
            PalabraDAC palabraDAC = new PalabraDAC();
            return palabraDAC.Read();
        }

        public Palabra ReadBy(int id)
        {
            PalabraDAC palabraDAC = new PalabraDAC();
            return palabraDAC.ReadBy(id);
        }

        public Palabra ReadBy(string id)
        {
            PalabraDAC palabraDAC = new PalabraDAC();
            return palabraDAC.ReadBy(id);
        }

        public void Update(Palabra entity)
        {
            PalabraDAC palabraDAC = new PalabraDAC();
             palabraDAC.Update(entity);
        }

        public bool Verificar(Palabra entity)
        {
            if (ReadBy(entity.palabra)==null)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        bool IRepository2<Palabra>.Update(Palabra entity)
        {
            throw new NotImplementedException();
        }
    }
}
