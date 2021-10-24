using Entities;
using MetroFramework;
using Negocio;
using Negocio.Gestion_de_Alumnos;
using Negocio.Gestion_de_Personas;
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
   
    public partial class FrmHorarioMaestroGrado : MetroFramework.Forms.MetroForm
    {
        public int legajo { get; set; }
        public FrmHorarioMaestroGrado()
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
        private void FrmHorarioMaestroGrado_Load(object sender, EventArgs e)
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
            if (maestroHorarioComponent.Create(maestroHorario)==null)
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
            if (mgAlumno.CurrentRow.Cells[0].Value==null)
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
