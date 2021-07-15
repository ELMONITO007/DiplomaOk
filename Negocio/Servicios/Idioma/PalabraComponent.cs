using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entities;
namespace Negocio
{ 
    public class PalabraComponent : IRepository2<Palabra>
    {
        public List<Palabra> buscar(string palabra)
        {
            List<Palabra> entity = new List<Palabra>();
            PalabraComponent idiomaComponent = new PalabraComponent();
            entity = idiomaComponent.Read();
            List<Palabra> result = new List<Palabra>();
            foreach (Palabra item in entity)
            {
                if (item.palabra.Contains(palabra))
                {
                    result.Add(item);
                }
            }

            return result;
        }
        public Palabra Create(Palabra entity)
        {
            if (Verificar(entity))
            {
                PalabraDAC palabraDAC = new PalabraDAC();
                Palabra palabra = new Palabra();
                palabra = palabraDAC.Create(entity);
                Palabra unaPalabra = new Palabra();
                unaPalabra = ReadBy(entity.palabra);
                IdiomaComponent idiomaComponent = new IdiomaComponent();
                foreach (Idioma item in idiomaComponent.Read())
                {
                    TraduccionComponent traduccionComponent = new TraduccionComponent();
                    Traduccion traduccion = new Traduccion(item, unaPalabra);
                    traduccionComponent.Create(traduccion);
                }
                return palabra;
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

        public List<Palabra> ReadByListado(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Palabra entity)
        {
            PalabraDAC palabraDAC = new PalabraDAC();
            if (palabraDAC.ReadByListado(entity.palabra).Count ==0)
            {
                palabraDAC.Update(entity);
                return true;
            }
            else
            {
                return false;
            }

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

     
    }
}
