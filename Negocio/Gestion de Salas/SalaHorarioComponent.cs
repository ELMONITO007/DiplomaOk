using Data;
using Entities;
using Entitites.Negocio.Salas;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Negocio
{
    public class SalaHorarioComponent : IRepository2<SalaHorario>
    {
        public List<SalaHorario> buscar(string palabra)
        {
            throw new NotImplementedException();
        }

        public SalaHorario Create(SalaHorario entity)
        {
            SalaHorarioDAC sala = new SalaHorarioDAC();

            if (entity.sala.tipoSala=="Grado")
            {
                sala.CreateSalaCompleta(entity);
            }
            else
            {
                sala.CreateSalaParcial(entity);
            }
            return entity;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<SalaHorario> ReadByTipoSala(SalaHorario sala)
        {
            List<SalaHorario> result = new List<SalaHorario>();
            SalaHorarioDAC salaHorarioDAC = new SalaHorarioDAC();
            foreach (var item in salaHorarioDAC.ReadByTipoSala(sala))
            {
                SalaHorario salaHorario = new SalaHorario();
                salaHorario = item;
                SalaComponent salaComponent = new SalaComponent();
                salaHorario.sala = salaComponent.ReadBy(item.sala.Id);
                result.Add(salaHorario);




            }

            return result;



        }

        public SalaHorario ReadBySalaYañoYTurnoGrado(SalaHorario sala)

        {
            List<SalaHorario> salaHorarios = new List<SalaHorario>();
            salaHorarios = ReadBySalaYañoYTurno(sala);

            if (salaHorarios.Count==0)
            {
                return null;
            }
            else
            {
                return salaHorarios[0];
            }





        }
        public List<string> SoloAño()

        {
            List<string> años = new List<string>();
            SalaHorarioDAC salaHorarioDAC = new SalaHorarioDAC();
            foreach (var item in salaHorarioDAC.SoloAño())
            {
                años.Add(item.año.ToString());
            }
            return años;

        }
            public List<SalaHorario> ReadBySalaYañoYTurno(SalaHorario sala)
        {
            List<SalaHorario> result = new List<SalaHorario>();
            SalaHorarioDAC salaHorarioDAC = new SalaHorarioDAC();
            foreach (var item in salaHorarioDAC.ReadBySalaYañoYTurno(sala))
            {
                SalaHorario salaHorario = new SalaHorario();
                salaHorario = item;
                SalaComponent salaComponent = new SalaComponent();
                salaHorario.sala = salaComponent.ReadBy(item.sala.Id);
                result.Add(salaHorario);




            }

            return result;


        }
            public bool VerificarDisponibilidadGrado(SalaHorario entity)


        {
       

            List<SalaHorario> reservaDeSala = new List<SalaHorario>();
            reservaDeSala = ReadBySalaYañoYTurno(entity);
            if (reservaDeSala.Count==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        
        
        
        }

        public List<Sala> ObtenerSalasDisponibleGrado(SalaHorario entity)

        {
     
            List<Sala> listaSalaPorTipo = new List<Sala>();
            List<Sala> result = new List<Sala>();
            SalaComponent salaComponent = new SalaComponent();
            SalaHorario unaSalaHorario = new SalaHorario();

            Sala sala = new Sala();
            sala = salaComponent.ReadByTipo("Grado")[0];


            listaSalaPorTipo = salaComponent.ReadByTipo(sala.tipoSala);
           
        
            foreach (var item in listaSalaPorTipo)
            {
                SalaHorario salaHorario = new SalaHorario(item);
          
                if (VerificarDisponibilidadGrado(salaHorario))
                {
                    result.Add(item);
                }
                
            }


            return result;
        
        
        
        }



            public List<SalaHorario> Read()
        {
            throw new NotImplementedException();
        }

        public SalaHorario ReadBy(int id)
        {
            SalaHorarioDAC salaHorario = new SalaHorarioDAC();
            return salaHorario.ReadBy(id);
        }

        public SalaHorario ReadBy(string id)
        {
            throw new NotImplementedException();
        }

        public bool Update(SalaHorario entity)
        {
            throw new NotImplementedException();
        }

        public bool Verificar(SalaHorario entity)
        {
            throw new NotImplementedException();
        }
    }
}