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
using Negocio.Gestion_de_Salas;
using Entitites.Negocio.Personas;
using Negocio;
using Entitites.Negocio.Salas;

namespace DiplomaFinal.VistaAlumno
{
    public partial class frmComunicadoAlumno : MetroFramework.Forms.MetroForm
    {
        public Alumno persona = new Alumno();
        public frmComunicadoAlumno()
        {
            
            InitializeComponent();
        }
        Curso cursos = new Curso();
        private void frmComunicadoAlumno_Load(object sender, EventArgs e)
        {
            RecorridoForm.CambiarIdioma(this);
            CursoComponent cursoAlumnoComponent = new CursoComponent();


            cursos = cursoAlumnoComponent.ReadByPersona(persona.Id);
            llenarGrilla();
         
        }
        void llenarGrilla()
        {
            mgListaComunicado.Rows.Clear();
            ComunicadoComponent comunicadoComponent = new ComunicadoComponent();

            List<Comunicado> listaPersona = new List<Comunicado>();
            listaPersona = comunicadoComponent.ReadByAlumnoYaño(persona.Id, cursos.salaHorario.año);
            int n = 0;
            foreach (var item in listaPersona)
            {
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
            
        }

        private void mgListaComunicado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Comunicado comunicado = new Comunicado();
            ComunicadoComponent comunicadoComponent = new ComunicadoComponent();
            comunicado = comunicadoComponent.ReadBy(int.Parse(mgListaComunicado.CurrentRow.Cells[0].Value.ToString()));
            txtColeccione.Text = comunicado.comunicado;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (mgListaComunicado.Rows.Count!=0)
            {
                Comunicado comunicado = new Comunicado();
                ComunicadoComponent comunicadoComponent = new ComunicadoComponent();
                comunicado = comunicadoComponent.ReadBy(int.Parse(mgListaComunicado.CurrentRow.Cells[0].Value.ToString()));
                comunicadoComponent.Update(comunicado.Id);
                llenarGrilla();
            }
       
        }
    }
}
