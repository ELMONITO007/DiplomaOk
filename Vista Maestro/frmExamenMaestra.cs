using Entities;
using Negocio.Gestion_de_boletin;
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
using Negocio.Gestion_de_Personas;
using Entitites.Servicios.Login;
using Negocio.Servicios.REGEX;
using Negocio.Gestion_de_Salas;
using Entitites;
using Entitites.Negocio.Salas;
using Negocio;
using Entitites.Negocio.Personas;
using DiplomaFinal.Gesion_de_Salas;
using DiplomaFinal.Gestion_Boletin;

namespace DiplomaFinal.VistaMaestroGrado
{
    public partial class frmExamenMaestra : MetroFramework.Forms.MetroForm
    {
        public Maestro persona =new Maestro();
        public frmExamenMaestra()
        {
            InitializeComponent();
        }
        private void llenarGrillaAlumno()

        {
            if (txtCurso.Text != "" && txtCursoListado.Text != "")
            {
                mgReserva.Rows.Clear();
                AlumnoComponent cursoAlumnoComponent = new AlumnoComponent();

                List<Alumno> listaPersona = new  List<Alumno>();

                Curso curso = new Curso();
                curso = (Curso)txtCurso.SelectedItem;
                listaPersona = cursoAlumnoComponent.ObtenerAlumnodeCunCurso(curso.Id);
               
             
                int n = 0;
                int m= 0;
                foreach (var item in listaPersona)
                {
                    mgAlumnoListado.Rows.Clear();
                    mgReserva.Rows.Clear();
                      n = mgReserva.Rows.Add();
                    mgReserva.Rows[n].Cells[0].Value = item.Id;
                    mgReserva.Rows[n].Cells[1].Value = item.nombre;
                    mgReserva.Rows[n].Cells[2].Value = item.apellido;

                    mgReserva.Rows[n].Cells[3].Value = item.DNI;
                    mgReserva.Rows[n].Cells[4].Value = item.fechaNacimiento;
                    n++;

                    m = mgAlumnoListado.Rows.Add();
                    mgAlumnoListado.Rows[m].Cells[0].Value = item.Id;
                    mgAlumnoListado.Rows[m].Cells[1].Value = item.nombre;
                    mgAlumnoListado.Rows[m].Cells[2].Value = item.apellido;
                                        
                    mgAlumnoListado.Rows[m].Cells[3].Value = item.DNI;
                    mgAlumnoListado.Rows[m].Cells[4].Value = item.fechaNacimiento;
                    m++;

                }
            }
          
        }

        private void frmExamenMaestra_Load(object sender, EventArgs e)
        {
            RecorridoForm.CambiarIdioma(this);
            RecorridoForm.CambiarIdioma(this);

            llenarGrillaCursos();
            MateriaComponent materiaComponent = new MateriaComponent();
            txtMateriaAlta.DataSource = materiaComponent.ReadByEspecialidad(persona.Id);
            txtMateriaAlta.ValueMember = "Id";
            txtMateriaAlta.DisplayMember = "materia";
      
                 

        }
        void llenarGrillaCursos()
        {

            CursoComponent cursoAlumnoComponent = new CursoComponent();
            List<Curso> cursos = new List<Curso>();
            int año = DateTime.Now.Year;
            foreach (var item in cursoAlumnoComponent.ReadByMaestro(persona.Id))
            {
                if (item.Id == persona.Id && item.salaHorario.año == año)
                {
                    cursos.Add(item);
                }
            }
            txtCurso.DataSource = cursos;
            txtCurso.DisplayMember = "nombre";
            txtCurso.ValueMember = "Id";
            txtCursoListado.DataSource = cursos;
            txtCursoListado.DisplayMember = "nombre";
            txtCursoListado.ValueMember = "Id";

        }

        private void txtCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarGrillaAlumno();
       

          


        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (txtNota.Text == "")
            {
                MetroMessageBox.Show(this, "Campo nota vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Materia materia = new Materia();
                materia = (Materia)txtMateriaAlta.SelectedItem;
                Alumno alumno = new Alumno();
                alumno.Id= int.Parse(mgReserva.CurrentRow.Cells[0].Value.ToString());
                Examen examen = new Examen(alumno,materia);
            
                examen.nota = int.Parse(txtNota.Text);
                              
          
                examen.fecha = txtFecha.Value;
                ExamenComponent examenComponent = new ExamenComponent();
                examenComponent.Create(examen);
                ValidadoresComponent.Alta("Examen de: " + txtMateriaAlta.Text, this);
                
            }
        }

        private void txtCursoListado_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarGrillaAlumno();
        }

        private void mgAlumnoListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Alumno alumno = new Alumno();
            alumno.Id = int.Parse(mgAlumnoListado.CurrentRow.Cells[0].Value.ToString());
            ExamenComponent examenComponent = new ExamenComponent();
            Examen examen = new Examen(alumno   ,null);
            DateTime fi = new DateTime(DateTime.Now.Year, 1, 31);
            DateTime ff = new DateTime(DateTime.Now.Year, 12, 1);
           
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

        private void metroButton3_Click(object sender, EventArgs e)
        {
            ExamenComponent examenComponent = new ExamenComponent();
            Examen examen = new Examen();
            Curso curso = new Curso();
            curso = (Curso)txtCursoListado.SelectedItem;
            int n = 0;
            mgExamenes.Rows.Clear();
            foreach (var item in examenComponent.ReadByCurso(curso.Id))
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
    }
}
