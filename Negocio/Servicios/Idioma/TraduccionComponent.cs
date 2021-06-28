using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entities;

namespace Negocio
{
    public class TraduccionComponent : IRepository2<Traduccion>
    {
        public List<Traduccion> buscar(string palabra)
        {
            List<Traduccion> lista = new List<Traduccion>();
            TraduccionComponent traduccionComponent = new TraduccionComponent();
            lista = traduccionComponent.Read();
            List<Traduccion> result = new List<Traduccion>();
            foreach (Traduccion item in lista)
            {
                if (item.traduccion != null)
                {
                    if (item.palabra.palabra.Contains(palabra) || item.traduccion.Contains(palabra))
                    {
                        result.Add(item);
                    }

                }
                else
                {
                    if (item.palabra.palabra.Contains(palabra))
                    {
                        result.Add(item);
                    }
                }

            }
            return result;

        }
        public Traduccion Create(Traduccion entity)
        {
            if (Verificar(entity))
            {
                TraduccionDAC traduccionDAC = new TraduccionDAC();
                return traduccionDAC.Create(entity);
            }
            else
            {
                return null;
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
        public void Delete(Traduccion entity)
        {
            TraduccionDAC traduccionDAC = new TraduccionDAC();
            traduccionDAC.Delete(entity);

        }
        
            public List<Traduccion> Read()
        {
            TraduccionDAC traduccionDAC = new TraduccionDAC();
            List<Traduccion> Result = new List<Traduccion>();
            List<Traduccion> traduccions = new List<Traduccion>();
            traduccions = traduccionDAC.Read();

            foreach (Traduccion item in traduccions)
            {
                Traduccion traduccion = new Traduccion();
                traduccion = item;
                IdiomaComponent idiomaComponent = new IdiomaComponent();
                PalabraComponent palabraComponent = new PalabraComponent();
                traduccion.idioma = idiomaComponent.ReadBy(item.idioma.Id);
                traduccion.palabra = palabraComponent.ReadBy(item.palabra.Id);
                Result.Add(traduccion);
            }
            return Result;
        }

        public Traduccion ReadBy(int id)
        {
            throw new NotImplementedException();
        }
        public List< Traduccion> ReadByIdioma(int id)
        {
            TraduccionDAC traduccionDAC = new TraduccionDAC();
            List<Traduccion> Result = new List<Traduccion>();
            List<Traduccion> traduccions = new List<Traduccion>();
            traduccions = traduccionDAC.ReadByIdioma(id);

            foreach (Traduccion item in traduccions)
            {
                Traduccion traduccion = new Traduccion();
                traduccion = item;
                IdiomaComponent idiomaComponent = new IdiomaComponent();
                PalabraComponent palabraComponent = new PalabraComponent();
                traduccion.idioma = idiomaComponent.ReadBy(item.idioma.Id);
                traduccion.palabra = palabraComponent.ReadBy(item.palabra.Id);
                Result.Add(traduccion);
            }
            return Result;

        }

        public Traduccion ReadBy(string id)
        {
            throw new NotImplementedException();
        }
        public Traduccion ReadBy(Traduccion entity)
        {
            TraduccionDAC traduccion = new TraduccionDAC();
            return traduccion.ReadBy(entity);
        }
        public bool Update(Traduccion entity)
        {
            TraduccionDAC traduccionDAC = new TraduccionDAC();
   
            traduccionDAC.Update(entity);
            return true;
        }

        public bool Verificar(Traduccion entity)
        {

            if (ReadBy(entity)==null)
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
