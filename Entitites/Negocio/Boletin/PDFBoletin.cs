using Entitites;
using Entitites.Negocio.Personas;
using Entitites.Negocio.Salas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class PDFBoletin
    {
        public int asistencia { get; set; }
        public int inAsistencia { get; set; }
        public double promediogeneral { get; set; }
        public List<Asistencia> listaAsitencia { get; set; }
        public Curso curso { get; set; }
        public Boletin boletin { get; set; }
        public string path { get; set; }
        public List<Examen> listaExamen { get; set; }
        public List<MateriaExamen> listaPromedio { get; set; }
        public List< Maestro> maestro { get; set; }
       
        public PDFBoletin(Boletin _boletin, List<Asistencia> _listaAsitencia, List<Examen> _listaExamen, Curso _curso, List<Maestro> _maestro)

        {
            boletin = _boletin;
            listaAsitencia = _listaAsitencia;
            listaExamen = _listaExamen;
            curso = _curso;
            maestro = _maestro;
        
        }
        public PDFBoletin()
        {
            listaAsitencia = new List<Asistencia>();
            boletin = new Boletin();
            listaExamen = new List<Examen>();
            curso = new Curso();
            maestro = new List<Maestro>();
            listaPromedio = new List<MateriaExamen>();
        }
    }
}
