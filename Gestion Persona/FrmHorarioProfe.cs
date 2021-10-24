using Entities;
using MetroFramework;
using Negocio;
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

namespace DiplomaFinal.Gestion_de_Personas
{
    public partial class FrmHorarioProfe : MetroFramework.Forms.MetroForm
    {
        public int legajo { get; set; }
        public FrmHorarioProfe()
        {
            InitializeComponent();
        }
        void llenarGrilla()


        {
            mgAlumno.Rows.Clear();
            int n = 0;
            MaestroHorarioComponent maestroHorarioComponent = new MaestroHorarioComponent();
            foreach (MaestroHorario item in maestroHorarioComponent.ReadByMaestro(legajo))
            {

                n = mgAlumno.Rows.Add();
                mgAlumno.Rows[n].Cells[0].Value = item.Id;
                mgAlumno.Rows[n].Cells[1].Value = item.persona.nombre;
                mgAlumno.Rows[n].Cells[2].Value = item.persona.apellido;
                mgAlumno.Rows[n].Cells[3].Value = item.año;
                mgAlumno.Rows[n].Cells[4].Value = item.turno;
                mgAlumno.Rows[n].Cells[5].Value = item.diaSemana;
                mgAlumno.Rows[n].Cells[6].Value = item.hora;
                n++;
            }

        }
        void llenarCombo()
        {
            int año = DateTime.Now.Year;
            txtAño.Items.Add(año);
            txtAño.Items.Add(año + 1);
            txtturno.Items.Add("Mañana");
            txtturno.Items.Add("Tarde");
            txtturno.Items.Add("Noche");

        }
        private void FrmHorarioProfe_Load(object sender, EventArgs e)
        {
            RecorridoForm.CambiarIdioma(this);
            llenarGrilla();
            llenarCombo();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {

            MaestroHorario maestroHorario = new MaestroHorario();
            MaestroHorarioComponent maestroHorarioComponent = new MaestroHorarioComponent();
            maestroHorario.persona.Id = legajo;
            maestroHorario.turno = txtturno.Text;
            maestroHorario.año = int.Parse(txtAño.Text);
            maestroHorario.diaSemana = txtDia.SelectedIndex+1;
            maestroHorario.hora = int.Parse(txtHora.Text);

            if (maestroHorarioComponent.CreateNoGrado(maestroHorario) == null)
            {
                ValidadoresComponent.ErrorAltaModificacado("Horario", this);

            }
            else
            {
                ValidadoresComponent.Alta("Horario", this);
                RecorridoForm.LimpiarTXT(this);
                llenarGrilla();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (mgAlumno.CurrentRow.Cells[0].Value == null)
            {
                MetroMessageBox.Show(this, "Seleccione un horario", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MaestroHorarioComponent maestroHorarioComponent = new MaestroHorarioComponent();
                maestroHorarioComponent.Delete(int.Parse(mgAlumno.CurrentRow.Cells[0].Value.ToString()));
                llenarGrilla();
            }
        }
    }
}
