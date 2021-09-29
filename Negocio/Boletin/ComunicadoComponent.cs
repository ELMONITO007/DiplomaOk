using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Data;
using Negocio.Gestion_de_Personas;
using System.Globalization;
using Negocio.Gestion_de_Salas;
using Data.Gestion_de_Boletin;

namespace Negocio.Gestion_de_boletin
{
    public class ComunicadoComponent : IRepository2<Comunicado>
    {
        public List<Comunicado> buscar(string palabra)
        {
            List<Comunicado> entity = new List<Comunicado>();

            entity = Read();
            List<Comunicado> result = new List<Comunicado>();
            foreach (Comunicado item in entity)
            {
                if (item.fecha.ToString().Contains(palabra) || item.persona.apellido.Contains(palabra) || item.comunicado.ToString().Contains(palabra) || item.persona.apellido.ToString().Contains(palabra) || item.persona.DNI.ToString().Contains(palabra))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public Comunicado Create(Comunicado entity)
        {
            entity.fecha = DateTime.Now;
            entity.visto = false;
            ComunicadoDAC comunicadoDAC = new ComunicadoDAC();
            return comunicadoDAC.Create(entity);


        }

        public void Delete(int id)
        {
            ComunicadoDAC comunicadoDAC = new ComunicadoDAC();
            comunicadoDAC.Delete(id);
        }

        public List<Comunicado> Read()
        {
            ComunicadoDAC comunicadoDAC = new ComunicadoDAC();
            List<Comunicado> result = new List<Comunicado>();
            foreach (var item in comunicadoDAC.Read())
            {
                Comunicado comunicado = new Comunicado();
                AlumnoComponent personaComponent = new AlumnoComponent();
                MaestroComponent maestroComponent = new MaestroComponent();
                comunicado = item;
                comunicado.persona = personaComponent.ReadBy(item.persona.Id);
                comunicado.maestro = maestroComponent.ReadBy(item.maestro.Id);
                result.Add(comunicado);

            }
            return result;
        }

        public Comunicado ReadBy(int id)
        {
            ComunicadoDAC comunicadoDAC = new ComunicadoDAC();
            Comunicado result = new Comunicado();
            result = comunicadoDAC.ReadBy(id);

            AlumnoComponent personaComponent = new AlumnoComponent();
            MaestroComponent maestroComponent = new MaestroComponent();

            result.persona = personaComponent.ReadBy(result.persona.Id);
            result.maestro = maestroComponent.ReadBy(result.maestro.Id);



            return result;
        }
        public List<Comunicado> ReadByAlumnoYaño(int legajo, int año)
        {

            ComunicadoDAC comunicadoDAC = new ComunicadoDAC();
            List<Comunicado> result = new List<Comunicado>();
            DateTime añoInicio = new DateTime(año, 1, 1);
            DateTime añofinal = new DateTime(año, 12, 31);

            foreach (var item in comunicadoDAC.ReadByAlumnoYaño(legajo, añoInicio, añofinal))
            {
                Comunicado comunicado = new Comunicado();
                AlumnoComponent personaComponent = new AlumnoComponent();
                MaestroComponent maestroComponent = new MaestroComponent();

                comunicado = item;
                comunicado.persona = personaComponent.ReadBy(item.persona.Id);
                comunicado.maestro = maestroComponent.ReadBy(item.maestro.Id);
                result.Add(comunicado);

            }
            return result;
        }
        public Comunicado ReadBy(string id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Comunicado entity)
        {

            ComunicadoDAC comunicadoDAC = new ComunicadoDAC();
            comunicadoDAC.Update(entity);
            return true;
        }
        public void Update(int id_comunicado)
        {
            ComunicadoDAC comunicadoDAC = new ComunicadoDAC();
            comunicadoDAC.Update(id_comunicado);
        }
        public bool Verificar(Comunicado entity)
        {
            throw new NotImplementedException();
        }
    }
}
