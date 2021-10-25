using Entities;
using Negocio;
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
using Negocio.Servicios.REGEX;
using DiplomaFinal.Gestion_Boletin;
namespace DiplomaFinal.Gesion_de_Salas
{
    public partial class frmCursos : MetroFramework.Forms.MetroForm
    {
        void llenarGrillaPorAño()


        {
            if (txtAño.Text=="")
            {
                MetroMessageBox.Show(this, "No hay años que mostrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CursoComponent cursoComponent = new CursoComponent();

                mgReserva.Rows.Clear();
                int n = 0;
                foreach (var item in cursoComponent.ReadByAño(int.Parse(txtAño.Text)))
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
        
        
        }
        void llenarGrillaReservas()

        {
            CursoComponent cursoComponent = new CursoComponent();

            mgReserva.Rows.Clear();
            int n = 0;
            foreach (var item in cursoComponent.Read())
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
        public frmCursos()
        {
            InitializeComponent();
        }

        void llenarAños()
        { 
        
        
        
        }
        private void frmCursos_Load(object sender, EventArgs e)
        {
            RecorridoForm.CambiarIdioma(this);
            llenarAños();
            llenarGrillaReservas();
       
            SalaHorarioComponent salaHorario = new SalaHorarioComponent();
            txtAño.DataSource = salaHorario.SoloAño();
            txtAño.DisplayMember = "Año";
        }

        private void txtAño_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarGrillaPorAño();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            llenarGrillaReservas();
        }

        private void btnAlumno_Click(object sender, EventArgs e)
        {
            if (mgReserva.CurrentRow.Cells[0].Value == null)
            {
                MetroMessageBox.Show(this, "No hay años que mostrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CursoComponent curso = new CursoComponent();
                bool vacantes = curso.VerificarVacantes(int.Parse(mgReserva.CurrentRow.Cells[0].Value.ToString()));

                if (vacantes )
                {
                    MetroMessageBox.Show(this, "Hay vacantes disponibles", "Vacantes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmAlumnosCurso frmAlumnosCurso = new frmAlumnosCurso();
                    frmAlumnosCurso.curso = int.Parse(mgReserva.CurrentRow.Cells[0].Value.ToString());
                    frmAlumnosCurso.año = int.Parse(txtAño.Text);


                    frmAlumnosCurso.ShowDialog();
                }
                else
                {
                    MetroMessageBox.Show(this, "No hay vacantes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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

                frmAlumnosCurso.ShowDialog();
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (mgReserva.CurrentRow.Cells[0].Value == null)
            {
                MetroMessageBox.Show(this, "No selecciono un curso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
          

                frmAsignaMaestroGrado frmAsignaMaestroGrado = new frmAsignaMaestroGrado();
                frmAsignaMaestroGrado.curso = int.Parse(mgReserva.CurrentRow.Cells[0].Value.ToString());
                frmAsignaMaestroGrado.ShowDialog();




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
            frmAsistencia frmAsistencia = new frmAsistencia();
            frmAsistencia.curso = int.Parse(mgReserva.CurrentRow.Cells[0].Value.ToString());
            frmAsistencia.ShowDialog();
        }

        private void mgReserva_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
