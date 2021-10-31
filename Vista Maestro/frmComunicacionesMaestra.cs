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

namespace DiplomaFinal.VistaMaestroGrado
{
    public partial class frmComunicacionesMaestra : MetroFramework.Forms.MetroForm
    {
    public   Maestro persona = new Maestro();
        public frmComunicacionesMaestra()
        {
            InitializeComponent();
        }
        void llenarGrillaCursos()
        {

            CursoComponent cursoAlumnoComponent = new CursoComponent();
            List<Curso> cursos = new List<Curso>();
            cursos = cursoAlumnoComponent.ReadByMaestro(persona.Id);
            txtCurso.DataSource = cursos;
            txtCurso.DisplayMember = "nombre";
            txtCurso.ValueMember = "Id";
            txtCursoListado.DataSource = cursos;
            txtCursoListado.DisplayMember = "nombre";
            txtCursoListado.ValueMember = "Id";

        }
        private void frmComunicacionesMaestra_Load(object sender, EventArgs e)
        {
            RecorridoForm.CambiarIdioma(this);
            llenarGrillaCursos();
        }

        private void txtCursoListado_SelectedIndexChanged(object sender, EventArgs e)
        {

      
            AlumnoComponent cursoAlumnoComponent = new AlumnoComponent();

            int año = DateTime.Now.Year;
         List<Alumno> result = new  List<Alumno>();
            Curso curso = new Curso();
            curso = (Curso)txtCursoListado.SelectedItem; 
            result = cursoAlumnoComponent.ObtenerAlumnodeCunCurso(curso.Id);

            mgAlumno.Rows.Clear();

            int n= 0;
            foreach (var item in result)
            {
                n = mgAlumno.Rows.Add();
                mgAlumno.Rows[n].Cells[0].Value = item.Id;
                mgAlumno.Rows[n].Cells[1].Value = item.nombre;
                mgAlumno.Rows[n].Cells[2].Value = item.apellido;

                mgAlumno.Rows[n].Cells[3].Value = item.DNI;
                mgAlumno.Rows[n].Cells[4].Value = item.fechaNacimiento;
                n++;
            }


        }
        void llenarListaComunicado()
        {

            ComunicadoComponent comunicadoComponent = new ComunicadoComponent();
           AlumnoComponent cursoAlumnoComponent = new AlumnoComponent();
    
            int año = DateTime.Now.Year;
            List<Comunicado> result = new List<Comunicado>();
            Curso curso = new Curso();
            curso = (Curso)txtCurso.SelectedItem;
            foreach (var item in comunicadoComponent.Read())
            {
                foreach (var alumno in cursoAlumnoComponent.ObtenerAlumnodeCunCurso(curso.Id))
                {
                    if (item.persona.Id == alumno.Id)
                    {
                        result.Add(item);
                    }
                }
            }
            int n = 0;

            foreach (var item in result)
            {
                mgListaComunicado.Rows.Clear();
                n = mgListaComunicado.Rows.Add();
                mgListaComunicado.Rows[n].Cells[0].Value = item.Id;
                mgListaComunicado.Rows[n].Cells[1].Value = item.persona.nombre;
                mgListaComunicado.Rows[n].Cells[2].Value = item.persona.apellido;
                mgListaComunicado.Rows[n].Cells[3].Value = item.persona.DNI;
                mgListaComunicado.Rows[n].Cells[4].Value = item.visto;
                string dat = item.fecha.ToString("dd-MM-yyyy");
                mgListaComunicado.Rows[n].Cells[5].Value = dat;
                mgListaComunicado.Rows[n].Cells[6].Value = item.maestro.nombre + " " + item.maestro.apellido;
                n++;
            }




        }
        private void txtCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtCurso.Text!="")
            {
                llenarListaComunicado();
            }
           
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (txtNuevaComunicacion.Text == "")
            {
                MetroMessageBox.Show(this, "Campo Comunicado esta vacio", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Alumno alumno = new Alumno();
                alumno.Id= int.Parse(mgAlumno.CurrentRow.Cells[0].Value.ToString());
                Comunicado comunicado = new Comunicado(persona, alumno);
          
              
               
                comunicado.comunicado = txtNuevaComunicacion.Text;
                ComunicadoComponent comunicadoComponent = new ComunicadoComponent();
                comunicadoComponent.Create(comunicado);
                ValidadoresComponent.Alta("Comunicacion", this);
                llenarListaComunicado();
                RecorridoForm.LimpiarTXT(this);
            }
        }

        private void mgAlumno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void mgListaComunicado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Comunicado comunicado = new Comunicado();
            ComunicadoComponent comunicadoComponent = new ComunicadoComponent();
            comunicado = comunicadoComponent.ReadBy(int.Parse(mgListaComunicado.CurrentRow.Cells[0].Value.ToString()));
            txtColeccione.Text = comunicado.comunicado;
        }
    }
}
