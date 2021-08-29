using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Data;
using Data.Gestion_de_Personas;
using Data.Gestion_de_Alumnos;
using Negocio.Gestion_de_Personas;

namespace Negocio
{
    public class FamiliaComponent : IRepository2<Familia>
    {
        public List<Familia> buscar(string palabra)
        {
            throw new NotImplementedException();
        }

        public Familia Create(Familia entity)
        {
            if (Verificar(entity))
            {
                FamiliaDAC familiaDAC = new FamiliaDAC();
                Familia familia = new Familia();
                familia = familiaDAC.Create(entity);


                return familia;
            }
            else
            {
                return null;
            }
        }

        public void Delete(int id)
        {
            FamiliaDAC familiaDAC = new FamiliaDAC();
            familiaDAC.Delete(id);
        }

        public List<Familia> Read()
        {
            FamiliaDAC familiaComponent = new FamiliaDAC();

            List<Familia> result = new List<Familia>();
            foreach (var item in familiaComponent.Read())
            {
                Familia familia = new Familia();
                familia = item;
                AlumnoComponent personaComponent = new AlumnoComponent();
                familia.persona = personaComponent.ReadBy(item.persona.Id);
                result.Add(familia);

            }
            return result;

        }

        public Familia ReadBy(int id)
        {
            Familia familia = new Familia();
            AlumnoComponent personaComponent = new AlumnoComponent();

            FamiliaDAC familiaComponent = new FamiliaDAC();
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

        public Familia ReadBy(string id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Familia entity)
        {
            FamiliaDAC familiaDAC = new FamiliaDAC();
            familiaDAC.Update(entity);
            return true;
        }

        public bool Verificar(Familia entity)
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
