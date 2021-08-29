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
    public class CasaComponent : IRepository2<Casa>
    {
        public List<Casa> buscar(string palabra)
        {
            throw new NotImplementedException();
        }

        public Casa Create(Casa entity)
        {
            if (Verificar(entity))
            {
                CasaDac familiaDAC = new CasaDac();
                Casa familia = new Casa();
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
            CasaDac familiaDAC = new CasaDac();
            familiaDAC.Delete(id);
        }

        public List<Casa> Read()
        {
            CasaDac familiaDAC = new CasaDac();

            List<Casa> result = new List<Casa>();
            foreach (var item in familiaDAC.Read())
            {
                Casa familia = new Casa();
                familia = item;
                AlumnoComponent personaComponent = new AlumnoComponent();
                familia.persona = personaComponent.ReadBy(item.persona.Id);
                result.Add(familia);

            }
            return result;
        }

        public Casa ReadBy(int id)
        {
            Casa familia = new Casa();
            AlumnoComponent personaComponent = new AlumnoComponent();
            CasaDac familiaComponent = new CasaDac();
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

        public Casa ReadBy(string id)
        {
            Casa familia = new Casa();
            AlumnoComponent personaComponent = new AlumnoComponent();
            CasaDac familiaComponent = new CasaDac();
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

        public bool Update(Casa entity)
        {
            CasaDac familiaComponent = new CasaDac();
            familiaComponent.Update(entity);
            return true;
        }

        public bool Verificar(Casa entity)
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
