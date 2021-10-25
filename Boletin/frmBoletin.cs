using Entities;
using Negocio.Gestion_de_boletin;
using Negocio.Gestion_de_Personas;
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
using Negocio;
using Negocio.Gestion_de_Salas;
using Negocio.Servicios.REGEX;
using Entitites.Negocio.Salas;
using Entitites.Negocio.Personas;

namespace DiplomaFinal.Gestion_Boletin
{
    public partial class frmBoletin : MetroFramework.Forms.MetroForm
    {
        public frmBoletin()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Boletin boletin = new Boletin();
            AlumnoComponent persona = new AlumnoComponent();
            boletin.persona = (Alumno)txtAlumno.SelectedItem;
            Curso curso = new Curso();
            curso = (Curso)txtCurso.SelectedItem;
            boletin.año = curso.salaHorario.año;
            boletin.cutrimeste = int.Parse(txtCuatrimestre.Text);
            boletin.notas = txtNota.Text;
            BoletinComponent boletinComponent = new BoletinComponent();
            if (boletinComponent.Create(boletin)==null)
            {
                ValidadoresComponent.ErrorAltaModificacado("Boletin", this);
            }
            else
            {
                ValidadoresComponent.Alta("Boletin", this);
                llenarGrillaBoletin();
            }

        }

        void llenarGrillaCursos()
        {
            CursoComponent cursoComponent = new CursoComponent();
            txtCurso.DataSource = cursoComponent.ReadByAño(DateTime.Now.Year);
            txtCurso.DisplayMember = "nombre";
            txtCurso.ValueMember = "Id";


        }

        void llenarGrillaBoletin()
        {
            if (txtCurso.Text!="" && txtAlumno.Text!="")
            {
                mgVer.Rows.Clear();
                int n = 0;
                  BoletinComponent boletinComponent = new BoletinComponent();
                Curso curso = new Curso();
                curso = (Curso)txtCurso.SelectedItem;
                Boletin boletin = new Boletin();
                boletin.año = curso.salaHorario.año;
                boletin.persona = (Alumno)txtAlumno.SelectedItem;
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
        private void frmBoletin_Load(object sender, EventArgs e)
        {
            RecorridoForm.CambiarIdioma(this);
            llenarGrillaCursos();
        }

        private void txtCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAlumno.DataSource = null;
            AlumnoComponent cursoAlumno = new AlumnoComponent();
            Curso curso = new Curso();
            curso = (Curso)txtCurso.SelectedItem;
            List<Alumno> personas = new List<Alumno>();
            personas = cursoAlumno.ObtenerAlumnodeCunCurso(curso.Id);
            foreach (var item in personas)
            {
                item.GenerarNombreCompeto();
            }
            
            txtAlumno.DataSource = personas;
            txtAlumno.DisplayMember = "nombreCompleto";
            txtAlumno.ValueMember = "Id";

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

        private void btnBaja_Click(object sender, EventArgs e)
        {
            BoletinComponent boletinComponent = new BoletinComponent();
            boletinComponent.Delete(int.Parse(mgVer.CurrentRow.Cells[0].Value.ToString()));

            llenarGrillaBoletin();
        }
    }
}
