using System;
using System.Collections.Generic;
using Entities;
using MetroFramework;
using Negocio.Gestion_de_Personas;
using Negocio.Servicios.REGEX;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Gestion_de_Alumnos;
using Entitites;

namespace DiplomaFinal.Gestion_de_Personas
{
    public partial class frmEspecialidad : MetroFramework.Forms.MetroForm
    {
        public int legajo { get; set; }
        public frmEspecialidad()
        {
            InitializeComponent();
        }



        private void llenarCombo()
        {
            EspecialidadComponent especialidadComponent = new EspecialidadComponent();
            List<Especialidad> especialidad = new List<Especialidad>();
            especialidad = especialidadComponent.EspecialidadesDisponibles(legajo);
            txtEspecialidadAlta.DisplayMember = "especialidad";
            txtEspecialidadAlta.ValueMember = "Id";
            txtEspecialidadAlta.DataSource = especialidad;
        }

        private void llenarGrilla()

        {
            int n = 0;
            mgEspecialidades.Rows.Clear();
            EspecialidadComponent especialidadComponent = new EspecialidadComponent();
            foreach (var item in especialidadComponent.ReadByPersona(legajo))
            {
                n = mgEspecialidades.Rows.Add();
                mgEspecialidades.Rows[n].Cells[0].Value = item.Id;
                mgEspecialidades.Rows[n].Cells[1].Value = item.especialidad;
            }
        }

        private bool verificarCamposEspecialidad()

        {
            string error = "";
            error = ValidadoresComponent.VerificarLetras(txtEspecialidadAlta.Text);

            if (error == "")
            {
                return true;
            }
            else
            {
                MetroMessageBox.Show(this, error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

        }

        private void frmEspecialidad_Load(object sender, EventArgs e)
        {
            RecorridoForm.CambiarIdioma(this);
            llenarCombo();
            llenarGrilla();
        }

        private void btnAltaEsp_Click(object sender, EventArgs e)
        {
            if (verificarCamposEspecialidad())
            {
                MaestroComponent especialidadPersona = new MaestroComponent();
              List<  Especialidad> especialidad = new List<Especialidad>();
                especialidad.Add((Especialidad)txtEspecialidadAlta.SelectedValue);
                Maestro maestro = new Maestro(especialidad);
                maestro.Id = legajo;

                //EspecialidadPersonaComponent especialidad = new EspecialidadPersonaComponent();
                especialidadPersona.AgregarEspecialidad(maestro);
                llenarCombo();
                llenarGrilla();

            }
        }

        private void btnEliminarEsp_Click(object sender, EventArgs e)
        {
            if (mgEspecialidades.CurrentRow.Cells[0].Value == null)
            {
                MetroMessageBox.Show(this, "Sellecione una especialidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MaestroComponent especialidadPersonaComponent = new MaestroComponent();
                List<Especialidad> especialidad = new List<Especialidad>();
                Especialidad especialidadPersona = new Especialidad();
              especialidadPersona.Id = int.Parse(mgEspecialidades.CurrentRow.Cells[0].Value.ToString());
                especialidad.Add(especialidadPersona);
                Maestro maestro = new Maestro(especialidad);
                maestro.Id = legajo;
             
             
           
                especialidadPersonaComponent.QuitarEspecialidad(maestro);
                llenarGrilla();
                llenarCombo();

            }
        }

        private void txtEspecialidadAlta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
