using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using Entitites.Negocio.Personas;
using Entitites.Negocio.Salas;
using MetroFramework;
using Negocio.Gestion_de_boletin;
using Negocio.Gestion_de_Salas;

namespace DiplomaFinal.VistaAlumno
{
   
    public partial class frmBoletinAlumno : MetroFramework.Forms.MetroForm
    {
        public Alumno alumno = new Alumno();

        public frmBoletinAlumno()
        {
            InitializeComponent();
        }

        private void frmBoletinAlumno_Load(object sender, EventArgs e)
        {
        }
        void llenarGrilla()
        {
            mgVer.Rows.Clear();
            int n = 0;
            BoletinComponent boletinComponent = new BoletinComponent();
            Curso curso = new Curso();
            curso = (Curso)txtCurso.SelectedItem;
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
        private void txtCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarGrilla();
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
