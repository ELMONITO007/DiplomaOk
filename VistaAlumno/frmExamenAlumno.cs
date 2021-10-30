using Negocio.Gestion_de_boletin;
using Negocio.Servicios.REGEX;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using Entities;
using Negocio.Gestion_de_Personas;
using Negocio.Gestion_de_Salas;
using Negocio;
using Entitites.Negocio.Personas;
using Entitites.Negocio.Salas;

namespace DiplomaFinal.VistaAlumno
{
    public partial class frmExamenAlumno : MetroFramework.Forms.MetroForm
    {
        public Alumno persona = new Alumno();
        public Curso curso = new Curso();
        public frmExamenAlumno()
        {

            InitializeComponent();
        }

        private void frmExamenAlumno_Load(object sender, EventArgs e)
        {
            Obsever.AgregarForm(this);

            ExamenComponent examenComponent = new ExamenComponent();
            Examen examen = new Examen(persona,null);


            DateTime fi = new DateTime(curso.salaHorario.año, 1, 31);
            DateTime ff = new DateTime(curso.salaHorario.año, 12, 1);

            int n = 0;
            mgExamenes.Rows.Clear();
            foreach (var item in examenComponent.ReadByAlumnoYAño(examen, fi, ff))
            {
                n = mgExamenes.Rows.Add();
                mgExamenes.Rows[n].Cells[0].Value = item.Id;
                string fecha = item.fecha.ToString("dd-MM-yyyy");
                mgExamenes.Rows[n].Cells[1].Value = fecha;
                mgExamenes.Rows[n].Cells[2].Value = item.nota;

                mgExamenes.Rows[n].Cells[3].Value = item.materia.materia;

                n++;
            }



        }

        private void txtCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
