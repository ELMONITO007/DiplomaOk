using Entitites.Negocio.Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class MateriaExamen
    {
        public Materia materia { get; set; }
        public double promedio { get; set; }
        public double promedioGenral { get; set; }
        public Alumno persona { get; set; }
        public Examen examen { get; set; }
        public MateriaExamen()
        {
            materia = new Materia();
            persona = new Alumno();
            examen = new Examen();
        }


        public List<MateriaExamen> obtenerPromedio(List<Examen> examenes, List<Materia> materias)
        {

            List<MateriaExamen> result = new List<MateriaExamen>();
            foreach (var item in materias)
            {
                MateriaExamen materia = new MateriaExamen();
                materia.materia = item;
                double a = 0;
                double c = 0;
                foreach (var examen in examenes)
                {
                    promedioGenral = promedioGenral + examen.nota;
                    materia.examen = examen;
                    if (item.materia == examen.materia.materia)
                    {
                        a = a + examen.nota;
                        c++;
                    }



                }
                materia.promedio = Math.Round(a / c);

                result.Add(materia);

            }


            return result;

        }


        public MateriaExamen obtenerPromedioGeneral(List<Examen> examenes)
        {
            MateriaExamen materiaExamen = new MateriaExamen();
            materiaExamen.promedio = 0;

            foreach (var examen in examenes)
            {
                materiaExamen.promedio = materiaExamen.promedio + examen.nota;





            }


            if (examenes.Count != 0)
            {
                materiaExamen.promedio = materiaExamen.promedio / examenes.Count;
            }
            else
            {

                materiaExamen.promedio = 0;
            }
            return materiaExamen;

        }

    }
}

