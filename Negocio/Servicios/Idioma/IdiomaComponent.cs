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
        public List<Idioma> buscar(string palabra)
        {
            List<Idioma> entity = new List<Idioma>();
            IdiomaComponent idiomaComponent = new IdiomaComponent();
            entity = idiomaComponent.Read();
            List<Idioma> result = new List<Idioma>();
            foreach (Idioma item in entity)
            {
                if (item.idioma.Contains(palabra) || item.codigo.Contains(palabra))
                {
                    result.Add(item);
                }
            }

            return result;
        }
        public Entities.Idioma Create(Entities.Idioma entity)
        {
            if (Verificar(entity))
            {
                IdiomaDAC idiomaDAC = new IdiomaDAC();
                Idioma idioma = new Idioma();
                idioma= idiomaDAC.Create(entity);
                Idioma idiomatabla = new Idioma();
                idiomatabla = ReadBy(entity.idioma);

                TraduccionComponent traduccionComponent = new TraduccionComponent();
                traduccionComponent.AsignarPalabras(idiomatabla.Id);
                return idioma;
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
            TraduccionComponent traduccionComponent = new TraduccionComponent();
            traduccionComponent.Delete(id);
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
            if (idiomaDAC.ReadByListado(entity.idioma).Count==0)
            {
                idiomaDAC.Update(entity);
                return true;
            }
            else
            {
                return false;
            }

            
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
