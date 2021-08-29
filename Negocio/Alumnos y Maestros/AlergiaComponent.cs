using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Data;
using Data.Gestion_de_Personas;


using Negocio.Gestion_de_Personas;

namespace Negocio.Gestion_de_Alumnos
{
    public class AlergiaComponent : IRepository2<Alergias>
    {
        public List<Alergias> buscar(string palabra)
        {
            throw new NotImplementedException();
        }

        public Alergias Create(Alergias entity)
        {
            if (Verificar(entity))
            {
                AlergiaDAC alergiaDAC = new AlergiaDAC();
                Alergias alergias = new Alergias();
                alergias = alergiaDAC.Create(entity);


                return alergias;
            }
            else
            {
                return null;
            }
        }

        public void Delete(int id)
        {
            AlergiaDAC alergiaDAC = new AlergiaDAC();
            alergiaDAC.Delete(id);
        }

        public List<Alergias> Read()
        {
            AlergiaDAC familiaComponent = new AlergiaDAC();

            List<Alergias> result = new List<Alergias>();
            foreach (var item in familiaComponent.Read())
            {
                Alergias familia = new Alergias();
                familia = item;
                AlumnoComponent personaComponent = new AlumnoComponent();
                familia.persona = personaComponent.ReadBy(item.persona.Id);
                result.Add(familia);

            }
            return result;
        }

        public Alergias ReadBy(int id)
        {
            Alergias familia = new Alergias();
            AlumnoComponent personaComponent = new AlumnoComponent();
            AlergiaDAC familiaComponent = new AlergiaDAC();

            familia = familiaComponent.ReadBy(id);
            if (familia == null)
            {
                return null;
            }
            else
            {
                familia.persona = personaComponent.ReadBy(familia.persona.Id);
                return familia;
            }

        }

        public Alergias ReadBy(string id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Alergias entity)
        {
            AlergiaDAC familiaDAC = new AlergiaDAC();
            familiaDAC.Update(entity);
            return true;
        }

        public bool Verificar(Alergias entity)
        {
            if (ReadBy(entity.persona.Id) == null)
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
