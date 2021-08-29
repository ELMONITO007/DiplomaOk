using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Data;
using Negocio.Gestion_de_Personas;

namespace Negocio
{
    public class MaestroHorarioComponent : IRepository2<MaestroHorario>
    {
        public List<MaestroHorario> buscar(string palabra)
        {
            List<MaestroHorario> entity = new List<MaestroHorario>();

            entity = Read();
            List<MaestroHorario> result = new List<MaestroHorario>();
            foreach (MaestroHorario item in entity)
            {
                if (item.año.ToString().Contains(palabra) || item.persona.nombre.Contains(palabra) || item.persona.apellido.Contains(palabra) || item.turno.Contains(palabra))
                {
                    result.Add(item);
                }
            }
            return result;

        }

        public MaestroHorario Create(MaestroHorario entity)
        {
            if (Verificar(entity))
            {
                MaestroHorarioDAC maestroHorarioDAC = new MaestroHorarioDAC();
                return maestroHorarioDAC.CreateHorarioGrado(entity);


            }
            else
            {
                return null;
            }
        }
        public MaestroHorario CreateNoGrado(MaestroHorario entity)
        {
            if (VerificarNoGrado(entity))
            {
                MaestroHorarioDAC maestroHorarioDAC = new MaestroHorarioDAC();
                return maestroHorarioDAC.CreateHorarioNoGrado(entity);


            }
            else
            {
                return null;
            }
        }
        public void Delete(int id)
        {
            MaestroHorarioDAC maestroHorarioDAC = new MaestroHorarioDAC();
            maestroHorarioDAC.Delete(id);
        }

        public List<MaestroHorario> Read()
        {
            MaestroHorarioDAC personaDAC = new MaestroHorarioDAC();
            List<MaestroHorario> result = new List<MaestroHorario>();
            foreach (MaestroHorario item in personaDAC.Read())
            {
                MaestroHorario maestroHorario = new MaestroHorario();
                MaestroComponent tipoPersonaComponent = new MaestroComponent();
                maestroHorario = item;
                maestroHorario.persona = tipoPersonaComponent.ReadBy(item.persona.Id);

                result.Add(maestroHorario);


            }
            return result;
        }
        public void CambiarDisponibilidad(MaestroHorario entity)
        {
            MaestroHorarioDAC maestroHorarioDAC = new MaestroHorarioDAC();
            maestroHorarioDAC.CambiarDisponibilidad(entity);
        }

        public List<MaestroHorario> DisponibilidadEspecialidad(int especialidad, int año, string turno)
        {
            MaestroHorarioDAC personaDAC = new MaestroHorarioDAC();
            List<MaestroHorario> result = new List<MaestroHorario>();
            foreach (MaestroHorario item in personaDAC.DisponibilidadEspecialidad(especialidad, año, turno))
            {
                MaestroHorario maestroHorario = new MaestroHorario();
                MaestroComponent tipoPersonaComponent = new MaestroComponent();

                maestroHorario = item;
                maestroHorario.persona = tipoPersonaComponent.ReadBy(item.persona.Id);

                result.Add(maestroHorario);


            }
            return result;

        }
        public List<MaestroHorario> ReadByMaestro(int legajo)
        {
            MaestroHorarioDAC personaDAC = new MaestroHorarioDAC();
            List<MaestroHorario> result = new List<MaestroHorario>();
            foreach (MaestroHorario item in personaDAC.ReadByMaestro(legajo))
            {
                MaestroHorario maestroHorario = new MaestroHorario();
                MaestroComponent tipoPersonaComponent = new MaestroComponent();

                maestroHorario = item;
                maestroHorario.persona = tipoPersonaComponent.ReadBy(item.persona.Id);

                result.Add(maestroHorario);


            }
            return result;

        }
        public List<MaestroHorario> ReadByGrado(MaestroHorario entity)
        {
            MaestroHorarioDAC personaDAC = new MaestroHorarioDAC();
            List<MaestroHorario> result = new List<MaestroHorario>();
            foreach (MaestroHorario item in personaDAC.ReadByGrado(entity))
            {
                MaestroHorario maestroHorario = new MaestroHorario();
                MaestroComponent tipoPersonaComponent = new MaestroComponent();

                maestroHorario = item;
                maestroHorario.persona = tipoPersonaComponent.ReadBy(item.persona.Id);

                result.Add(maestroHorario);


            }
            return result;

        }

        public MaestroHorario ReadBy(int id)
        {
            MaestroHorarioDAC maestroHorarioDAC = new MaestroHorarioDAC();
            MaestroComponent tipoPersonaComponent = new MaestroComponent();

            MaestroHorario maestroHorario = new MaestroHorario();
            maestroHorario = maestroHorarioDAC.ReadBy(id);
            maestroHorario.persona = tipoPersonaComponent.ReadBy(maestroHorario.persona.Id);

            return maestroHorario;


        }


        public MaestroHorario ReadBy(MaestroHorario entity)
        {
            MaestroHorarioDAC maestroHorarioDAC = new MaestroHorarioDAC();
            MaestroComponent tipoPersonaComponent = new MaestroComponent();

            MaestroHorario maestroHorario = new MaestroHorario();
            maestroHorario = maestroHorarioDAC.ReadBy(entity);


            return maestroHorario;

        }
        public MaestroHorario ReadBy(string id)
        {
            throw new NotImplementedException();
        }

        public bool Update(MaestroHorario entity)
        {
            throw new NotImplementedException();
        }

        public bool Verificar(MaestroHorario entity)
        {
            if (ReadBy(entity) == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool VerificarNoGrado(MaestroHorario entity)
        {
            MaestroHorarioDAC maestroHorarioDAC = new MaestroHorarioDAC();
            if (maestroHorarioDAC.ReadByNoGrado(entity) == null)
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
