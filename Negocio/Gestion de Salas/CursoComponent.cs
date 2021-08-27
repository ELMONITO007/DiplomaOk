
using Data.Gestion_Salas;
using Entities;
using Entitites.Negocio.Salas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CursoComponent : IRepository2<Curso>
    {
        public List<Curso> buscar(string palabra)
        {
            List<Curso> entity = new List<Curso>();

            entity = Read();
            List<Curso> result = new List<Curso>();
            foreach (Curso item in entity)
            {
                if (item.nombre.ToString().Contains(palabra) || item.sala.nombre.Contains(palabra) || item.grado.nombre.Contains(palabra) )
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public Curso Create(Curso entity)
        {
            if (Verificar(entity))
            {
                CursoDAC cursoDAC = new CursoDAC();
                return cursoDAC.Create(entity);
            }
            else
            {
                return null;
            }
        }

        public void Delete(int id)
        {
            CursoDAC cursoDAC = new CursoDAC();
            cursoDAC.Delete(id);
        }

        public List<Curso> Read()
        {
            CursoDAC cursoDAC = new CursoDAC();
            List<Curso> result = new List<Curso>();

            foreach (var item in cursoDAC.Read())
            {
                Curso curso = new Curso();
                curso = item;
                SalaComponent salaComponent = new SalaComponent();
                GradoComponent gradoComponent = new GradoComponent();
                curso.grado = gradoComponent.ReadBy(item.grado.Id);
                curso.sala = salaComponent.ReadBy(item.sala.Id);
                //SalaHorarioComponent salaHorario = new SalaHorarioComponent();
                //curso.salaHorario = salaHorario.ReadBy(item.salaHorario.Id);
                result.Add(curso);
            }

            return result;
        }

        public List<Curso> ReadByAño(int año)
        {
            CursoDAC cursoDAC = new CursoDAC();
            List<Curso> result = new List<Curso>();

            foreach (var item in cursoDAC.ReadByAño(año))
            {
                Curso curso = new Curso();
                curso = item;
                SalaComponent salaComponent = new SalaComponent();
                GradoComponent gradoComponent = new GradoComponent();
                curso.grado = gradoComponent.ReadBy(item.grado.Id);
                curso.sala = salaComponent.ReadBy(item.sala.Id);
                //SalaHorarioComponent salaHorario = new SalaHorarioComponent();
                //curso.salaHorario = salaHorario.ReadBy(item.salaHorario.Id);
                result.Add(curso);
            }

            return result;
        }
            public List<Curso> ReadBysala(Curso entity)
        {
            CursoDAC cursoDAC = new CursoDAC();
            List<Curso> result = new List<Curso>();

            foreach (var item in cursoDAC.ReadByCurso(entity))
            {
                Curso curso = new Curso();
                curso = item;
                SalaComponent salaComponent = new SalaComponent();
                GradoComponent gradoComponent = new GradoComponent();
                curso.grado = gradoComponent.ReadBy(item.grado.Id);
                curso.sala = salaComponent.ReadBy(item.sala.Id);
                //SalaHorarioComponent salaHorario = new SalaHorarioComponent();
                //curso.salaHorario = salaHorario.ReadBy(item.salaHorario.Id);
                result.Add(curso);
            }

            return result;
        }
        public List<Curso> ReadByGrado(Curso entity)
        {
            CursoDAC cursoDAC = new CursoDAC();
            List<Curso> result = new List<Curso>();

            foreach (var item in cursoDAC.ReadByGrado(entity))
            {
                Curso curso = new Curso();
                curso = item;
                SalaComponent salaComponent = new SalaComponent();
                GradoComponent gradoComponent = new GradoComponent();
                curso.grado = gradoComponent.ReadBy(item.grado.Id);
                curso.sala = salaComponent.ReadBy(item.sala.Id);
                //SalaHorarioComponent salaHorario = new SalaHorarioComponent();
                //curso.salaHorario = salaHorario.ReadBy(item.salaHorario.Id);
                result.Add(curso);
            }

            return result;
        }
        public Curso ReadBy(int id)
        {
            CursoDAC salaDac = new CursoDAC();
            Curso result = new Curso();
            result = salaDac.ReadBy(id);
            if (result != null)
            {
              SalaComponent salaComponent = new SalaComponent();
                result.sala = salaComponent.ReadBy(result.sala.Id);
                GradoComponent gradoComponent = new GradoComponent();
                result.grado = gradoComponent.ReadBy(result.grado.Id);
                //SalaHorarioComponent salaHorario = new SalaHorarioComponent();
                //result.salaHorario = salaHorario.ReadBy(result.salaHorario.Id);
            }

            return result;
        }

        public Curso ReadBy(string id)
        {
            CursoDAC salaDac = new CursoDAC();
            Curso result = new Curso();
            result = salaDac.ReadBy(id);
            if (result != null)
            {
                SalaComponent salaComponent = new SalaComponent();
                result.sala = salaComponent.ReadBy(result.sala.Id);
                GradoComponent gradoComponent = new GradoComponent();
                result.grado = gradoComponent.ReadBy(result.grado.Id);
            }

            return result;
        }

        public bool Update(Curso entity)
        {
            CursoDAC cursoDAC = new CursoDAC();
            cursoDAC.Update(entity);
            return true;
        }

        public bool Verificar(Curso entity)
        {
            if (ReadBy(entity.nombre)==null)
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
