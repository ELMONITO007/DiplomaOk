using Entities;
using Entitites;
using Entitites.Negocio.Personas;
using Entitites.Negocio.Salas;
using Negocio;
using Negocio.Gestion_de_boletin;
using Negocio.Gestion_de_Personas;
using Negocio.Gestion_de_Salas;
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

namespace DiplomaFinal.VistaMaestroGrado
{
    public partial class frmBoletinMaestro : MetroFramework.Forms.MetroForm
    {
        public frmBoletinMaestro()
        {
            InitializeComponent();
        }
        public Maestro persona= new Maestro();
        private void frmBoletinMaestro_Load(object sender, EventArgs e)
        {
            Obsever.AgregarForm(this);
            llenarGrillaCursos();
        }

        void llenarGrillaBoletin()
        {
            if (txtCurso.Text != "" && txtAlumno.Text != "")
            {
                mgVer.Rows.Clear();
                int n = 0;
                BoletinComponent boletinComponent = new BoletinComponent();
                Curso curso = new Curso();
                curso = (Curso)txtCurso.SelectedItem;
                Alumno alumno = new Alumno();
                alumno= (Alumno)txtAlumno.SelectedItem;
                Boletin boletin = new Boletin(alumno);

                boletin.año = curso.salaHorario.año;
             
                foreach (var item in boletinComponent.ReadByAlumnoYAño(boletin))
                {
                    n = mgVer.Rows.Add();

                    mgVer.Rows[n].Cells[0].Value = item.Id;
                    mgVer.Rows[n].Cells[1].Value = item.persona.nombre;
                    mgVer.Rows[n].Cells[2].Value = item.persona.apellido;
                    mgVer.Rows[n].Cells[3].Value = item.año;
                    mgVer.Rows[n].Cells[4].Value = item.cutrimeste;
                    mgVer.Rows[n].Cells[5].Value = item.notas;
                    n++;
                }
            }


        }
        void llenarGrillaCursos()
        {

            CursoComponent cursoAlumnoComponent = new CursoComponent();
            List<Curso> cursos = new List<Curso>();
            cursos = cursoAlumnoComponent.ReadByMaestro(persona.Id);
            txtCurso.DataSource = cursos;
            txtCurso.DisplayMember = "nombre";
            txtCurso.ValueMember = "Id";


        }

        private void txtCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtCurso.Text!="")
            {
                txtAlumno.DataSource = null;
                AlumnoComponent cursoAlumno = new AlumnoComponent();
                Curso curso = new Curso();
                curso = (Curso)txtCurso.SelectedItem;
                List<Alumno> personas = new List<Alumno>();
                personas = cursoAlumno.ObtenerAlumnodeCunCurso(curso.Id);
                txtAlumno.DataSource = personas;
                txtAlumno.DisplayMember = "nombreCompleto";
                txtAlumno.ValueMember = "Id";
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();
            alumno= (Alumno)txtAlumno.SelectedItem;
            Boletin boletin = new Boletin(alumno);
           
            Curso curso = new Curso();
            curso = (Curso)txtCurso.SelectedItem;
            boletin.año = curso.salaHorario.año;
            boletin.cutrimeste = int.Parse(txtCuatrimestre.Text);
            boletin.notas = txtNota.Text;
            BoletinComponent boletinComponent = new BoletinComponent();
            if (boletinComponent.Create(boletin) == null)
            {
                ValidadoresComponent.ErrorAltaModificacado("Boletin", this);
            }
            else
            {
                ValidadoresComponent.Alta("Boletin", this);
                llenarGrillaBoletin();
            }
        }

        private void txtAlumno_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarGrillaBoletin();
        }

        private void btnVerBoletin_Click(object sender, EventArgs e)
        {
            PDFboletinComponent pDFboletinComponent = new PDFboletinComponent();
            Boletin boletin = new Boletin();
            BoletinComponent boletinComponent = new BoletinComponent();
            boletin = boletinComponent.ReadBy(int.Parse(mgVer.CurrentRow.Cells[0].Value.ToString()));
            pDFboletinComponent.AbrirPDF(boletin);
        }
    }
}
