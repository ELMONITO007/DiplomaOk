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
    public class ObraSocialComponent : IRepository2<ObrasSocial>
    {
        public List<ObrasSocial> buscar(string palabra)
        {
            throw new NotImplementedException();
        }

        public ObrasSocial Create(ObrasSocial entity)
        {
            if (Verificar(entity))
            {
                ObraSocialDAC obraSocialDAC = new ObraSocialDAC();
                ObrasSocial obrasSocial = new ObrasSocial();
                obrasSocial = obraSocialDAC.Create(entity);


                return obrasSocial;
            }
            else
            {
                return null;
            }
        }

        public void Delete(int id)
        {
            ObraSocialDAC obraSocialDAC = new ObraSocialDAC();
            obraSocialDAC.Delete(id);
        }

        public List<ObrasSocial> Read()
        {
            ObraSocialDAC familiaComponent = new ObraSocialDAC();

            List<ObrasSocial> result = new List<ObrasSocial>();
            foreach (var item in familiaComponent.Read())
            {
                ObrasSocial familia = new ObrasSocial();
                familia = item;
                AlumnoComponent personaComponent = new AlumnoComponent();
                familia.persona = personaComponent.ReadBy(item.persona.Id);
                result.Add(familia);

            }
            return result;
        }

        public ObrasSocial ReadBy(int id)
        {
            ObrasSocial familia = new ObrasSocial();
            AlumnoComponent personaComponent = new AlumnoComponent();

            ObraSocialDAC familiaComponent = new ObraSocialDAC();
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

        public ObrasSocial ReadBy(string id)
        {
            throw new NotImplementedException();
        }

        public bool Update(ObrasSocial entity)
        {
            ObraSocialDAC obraSocialDAC = new ObraSocialDAC();
            obraSocialDAC.Update(entity);
            return true;
        }

        public bool Verificar(ObrasSocial entity)
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
