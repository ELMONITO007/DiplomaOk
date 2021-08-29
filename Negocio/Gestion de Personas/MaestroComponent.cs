using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Data;
using Entitites.Negocio.Personas;
using Data.Gestion_de_Personas;
using Entitites;

namespace Negocio.Gestion_de_Personas
{
    public class MaestroComponent : IRepository2<Maestro>
    {
        public List<Maestro> buscar(string palabra)
        {

            List<Maestro> entity = new List<Maestro>();

            entity = Read();
            List<Maestro> result = new List<Maestro>();
            foreach (Maestro item in entity)
            {
                if (item.nombre.Contains(palabra) || item.apellido.Contains(palabra) || item.DNI.Contains(palabra) || item.direccion.Contains(palabra))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public List<Maestro> buscar(string palabra, int tipo)
        {

            List<Maestro> entity = new List<Maestro>();

            entity = ReadByTipo(tipo);
            List<Maestro> result = new List<Maestro>();
            foreach (Maestro item in entity)
            {
                if (item.nombre.Contains(palabra) || item.apellido.Contains(palabra) || item.DNI.Contains(palabra) || item.direccion.Contains(palabra))
                {
                    result.Add(item);
                }
            }

            return result;
        }
        public Maestro Create(Maestro entity)
        {
            if (Verificar(entity))
            {
                MaestroDAC idiomaDAC = new MaestroDAC();
                Maestro persona = new Maestro();
                persona = idiomaDAC.Create(entity);


                return persona;
            }
            else
            {
                return null;
            }
        }



        public void Delete(int id)
        {
            MaestroDAC idiomaDAC = new MaestroDAC();
            idiomaDAC.Delete(id);
        }

        public List<Maestro> ReadByTipo(int tipo)
        {
            MaestroDAC personaDAC = new MaestroDAC();
            List<Maestro> result = new List<Maestro>();


            return personaDAC.ReadByTipoPersona(tipo);

        }

        public List<Maestro> Read()
        {
            MaestroDAC personaDAC = new MaestroDAC();


            return personaDAC.Read();

        }

      
        public Maestro ReadBy(int id)
        {

            MaestroDAC personaDAC = new MaestroDAC();
            Maestro result = new Maestro();
            Maestro persona = new Maestro();
            persona = personaDAC.ReadBy(id);


            return persona;
        }

        public Maestro ReadBy(string id)
        {
            MaestroDAC personaDAC = new MaestroDAC();
            Maestro result = new Maestro();
            Maestro persona = new Maestro();
            persona = personaDAC.ReadBy(id);


            return persona;
        }

        public bool Update(Maestro entity)
        {
            MaestroDAC personaDAC = new MaestroDAC();
            personaDAC.Update(entity);
            return true;
        }

        public bool Verificar(Maestro entity)
        {
            if (ReadBy(entity.DNI) == null)
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
