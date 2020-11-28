using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Data;
namespace Negocio
{
    public class IdiomaComponent : IRepository2<Entities.Idioma>
    {
        public Entities.Idioma Create(Entities.Idioma entity)
        {
            if (Verificar(entity))
            {
                IdiomaDAC idiomaDAC = new IdiomaDAC();
                return idiomaDAC.Create(entity);
            }
            else
            {
                return null;
            }
           

        }

        public void Delete(int id)
        {
            IdiomaDAC idiomaDAC = new IdiomaDAC();
             idiomaDAC.Delete(id);
        }

        public List<Entities.Idioma> Read()
        {
            IdiomaDAC idiomaDAC = new IdiomaDAC();
            return idiomaDAC.Read();
        }

        public Entities.Idioma ReadBy(int id)
        {
            IdiomaDAC idiomaDAC = new IdiomaDAC();
            return idiomaDAC.ReadBy(id);
        }

        public Entities.Idioma ReadBy(string id)
        {
            IdiomaDAC idiomaDAC = new IdiomaDAC();
            return idiomaDAC.ReadBy(id);
        }

        public bool Update(Entities.Idioma entity)
        {
            IdiomaDAC idiomaDAC = new IdiomaDAC();
            idiomaDAC.Update(entity);
            return true;
        }

        public bool Verificar(Entities.Idioma entity)
        {
            if (ReadBy(entity.idioma)==null)
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
