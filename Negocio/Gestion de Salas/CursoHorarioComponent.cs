using Data;
using Data.Gestion_de_Personas;
using Data.Gestion_salas;
using Entities;
using Negocio.Gestion_de_Alumnos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Gestion_de_Salas
{
    public class CursoHorarioComponent 
    {
      

        public CursoHorario Create(CursoHorario entity)
        {
            CursoHorarioDAC curso = new CursoHorarioDAC();
            return curso.Create(entity);
        }


       

        public List<CursoHorario> ReadByCurso(int id_Curso)
        {
            List<CursoHorario> result = new List<CursoHorario>();
            CursoHorarioDAC cursoHorarioDAC = new CursoHorarioDAC();
            foreach (var item in cursoHorarioDAC.ReadByCurso(id_Curso))
            {
                CursoComponent cursoComponent = new CursoComponent();
                MaestroHorarioComponent maestroHorarioComponent = new MaestroHorarioComponent();
                CursoHorario cursoHorario = new CursoHorario(cursoComponent.ReadBy(item.curso.Id), maestroHorarioComponent.ReadBy(item.maestroHorario.Id));



                result.Add(cursoHorario);


            }


            return result;
        }
       
    }
}
