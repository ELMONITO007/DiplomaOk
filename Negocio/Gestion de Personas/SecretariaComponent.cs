using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Data;
using Entitites.Negocio.Personas;
using Data.Gestion_de_Personas;

namespace Negocio.Gestion_de_Personas
{
  public  class SecretariaComponent : IRepository2<Secretaria>
    {

        public List<Secretaria> buscar(string palabra)
        {

            List<Secretaria> entity = new List<Secretaria>();

            entity = Read();
            List<Secretaria> result = new List<Secretaria>();
            foreach (Secretaria item in entity)
            {
                if (item.nombre.Contains(palabra) || item.apellido.Contains(palabra) || item.DNI.Contains(palabra) || item.direccion.Contains(palabra))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public Secretaria Create(Secretaria entity)
        {
            if (Verificar(entity))
            {

                SecretariaDAC idiomaDAC = new SecretariaDAC();
                Secretaria persona = new Secretaria();
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
            SecretariaDAC idiomaDAC = new SecretariaDAC();
            idiomaDAC.Delete(id);
        }


        public List<Secretaria> Read()
        {
            SecretariaDAC personaDAC = new SecretariaDAC();


            return personaDAC.Read();

        }
        public Secretaria ReadByEmail(string email)
        {
            SecretariaDAC personaDAC = new SecretariaDAC();
            return personaDAC.ReadByEmail(email);
        }
        public Secretaria ReadBy(int id)
        {

            SecretariaDAC personaDAC = new SecretariaDAC();
            Secretaria result = new Secretaria();
            Secretaria persona = new Secretaria();
            persona = personaDAC.ReadBy(id);


            return persona;
        }

        public Secretaria ReadBy(string id)
        {

            SecretariaDAC personaDAC = new SecretariaDAC();
            Secretaria result = new Secretaria();
            Secretaria persona = new Secretaria();
            persona = personaDAC.ReadBy(id);


            return persona;
        }

        public bool Update(Secretaria entity)
        {
            SecretariaDAC personaDAC = new SecretariaDAC();
            personaDAC.Update(entity);
            return true;
        }

        public bool Verificar(Secretaria entity)
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
