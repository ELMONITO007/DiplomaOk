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
   
    public partial class frmCursoMaestra : MetroFramework.Forms.MetroForm
    {
        public Maestro persona = new Maestro();
        public frmCursoMaestra()
        {
            InitializeComponent();
        }

        private void frmCursoMaestra_Load(object sender, EventArgs e)
        {
            RecorridoForm.CambiarIdioma(this);
            CursoComponent cursoAlumnoComponent = new CursoComponent();
            List<Curso> cursos = new List<Curso>();
            int año = DateTime.Now.Year;
            cursos = cursoAlumnoComponent.ReadByMaestro(persona.Id);

            mgReserva.Rows.Clear();
            int n = 0;
            foreach (var item in cursos)
            {
                n = mgReserva.Rows.Add();

                mgReserva.Rows[n].Cells[0].Value = item.Id;
                mgReserva.Rows[n].Cells[1].Value = item.nombre;
                mgReserva.Rows[n].Cells[2].Value = item.sala.tipoSala;
                mgReserva.Rows[n].Cells[3].Value = item.sala.capacidad;
                mgReserva.Rows[n].Cells[4].Value = item.salaHorario.turno;
                mgReserva.Rows[n].Cells[5].Value = item.salaHorario.hora;
                mgReserva.Rows[n].Cells[6].Value = item.salaHorario.año;

                mgReserva.Rows[n].Cells[7].Value = item.sala.nombre;

                mgReserva.Rows[n].Cells[8].Value = item.grado.nombre;

            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (mgReserva.CurrentRow.Cells[0].Value == null)
            {
                MetroMessageBox.Show(this, "No hay años que mostrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                frmCursoAlumnosVerBaja frmAlumnosCurso = new frmCursoAlumnosVerBaja();
                frmAlumnosCurso.curso = int.Parse(mgReserva.CurrentRow.Cells[0].Value.ToString());
                frmAlumnosCurso.b = 1;
                frmAlumnosCurso.ShowDialog();
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            frmCalendario frmCalendario = new frmCalendario();
            frmCalendario.curso = int.Parse(mgReserva.CurrentRow.Cells[0].Value.ToString());
            frmCalendario.ShowDialog();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            frmAsistencia FrmAsistencia = new frmAsistencia();
            FrmAsistencia.curso = int.Parse(mgReserva.CurrentRow.Cells[0].Value.ToString());
            FrmAsistencia.ShowDialog();
        }
    }
}
