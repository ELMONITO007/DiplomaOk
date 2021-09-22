using Entities;
using Entitites.Negocio.Personas;
using MetroFramework;
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
    public partial class frmAlumno : MetroFramework.Forms.MetroForm
    {
        public frmAlumno()
        {
            InitializeComponent();
        }

        private void LlenarGrilla()
        {
            mgAlumno.Rows.Clear();
            AlumnoComponent personaComponent = new AlumnoComponent();

            List<Alumno> listaPersona = new List<Alumno>();
            listaPersona = personaComponent.Read();
            int n = 0;
            foreach (var item in listaPersona)
            {
                n = mgAlumno.Rows.Add();
                mgAlumno.Rows[n].Cells[0].Value = item.Id;
                mgAlumno.Rows[n].Cells[1].Value = item.nombre;
                mgAlumno.Rows[n].Cells[2].Value = item.apellido;
                mgAlumno.Rows[n].Cells[3].Value = item.direccion;
                mgAlumno.Rows[n].Cells[4].Value = item.DNI;
                mgAlumno.Rows[n].Cells[5].Value = item.fechaNacimiento;
                n++;
            }

        }

        private void frmAlumno_Load(object sender, EventArgs e)
        {
            RecorridoForm.CambiarIdioma(this);
            LlenarGrilla();
            txtFechaNacimiento.MaxDate = DateTime.Now.AddYears(-3);
            txtFechaNacimiento.MinDate = DateTime.Now.AddYears(-18);

        }
        private bool VerificarCampos()
        {
            string error = "";

            error = ValidadoresComponent.VerificarLetras(txtNombre.Text);
            error = error + " " + ValidadoresComponent.VerificarLetras(txtApellido.Text);
            error = error + " " + ValidadoresComponent.VerificarNumerosIntervalo(txtDNI.Text, 52610644, 99999999);

            error = error + " " + ValidadoresComponent.VerificarNumeros(txtDNI.Text);
            if (error.Length < 15)
            {
                return true;
            }
            else
            {
                MetroMessageBox.Show(this, error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }



        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            mgAlumno.Rows.Clear();
            AlumnoComponent personaComponent = new AlumnoComponent();

            List<Alumno> listaPersona = new List<Alumno>();
            listaPersona = personaComponent.buscar(txtBuscar.Text, 1);
            int n = 0;
            foreach (var item in listaPersona)
            {
                n = mgAlumno.Rows.Add();
                mgAlumno.Rows[n].Cells[0].Value = item.Id;
                mgAlumno.Rows[n].Cells[1].Value = item.nombre;
                mgAlumno.Rows[n].Cells[2].Value = item.apellido;
                mgAlumno.Rows[n].Cells[3].Value = item.direccion;
                mgAlumno.Rows[n].Cells[4].Value = item.DNI;
                       mgAlumno.Rows[n].Cells[5].Value = item.fechaNacimiento;
                n++;
            }
        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
            LlenarGrilla();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (mgAlumno.CurrentRow.Cells[0].Value == null)
            {
                MetroMessageBox.Show(this, "Sellecione un alumno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (VerificarCampos())
                {
                    Alumno persona = new Alumno();
                    persona.nombre = txtNombre.Text;
                    persona.apellido = txtApellido.Text;
                    persona.direccion = txtDireccion.Text;
                    persona.DNI = txtDNI.Text;
                    persona.fechaNacimiento = txtFechaNacimiento.Value;
                    persona.Id = int.Parse(mgAlumno.CurrentRow.Cells[0].Value.ToString());
                    //persona.tipoPersona.Id = 1;
                    AlumnoComponent personaComponent = new AlumnoComponent();
                    personaComponent.Update(persona);
                    LlenarGrilla();
                }

            }
        }

        private void mgAlumno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtNombre.Text = mgAlumno.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = mgAlumno.CurrentRow.Cells[2].Value.ToString();
            txtDireccion.Text = mgAlumno.CurrentRow.Cells[3].Value.ToString();
            txtDNI.Text = mgAlumno.CurrentRow.Cells[4].Value.ToString();
            txtFechaNacimiento.Text = mgAlumno.CurrentRow.Cells[5].Value.ToString();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (mgAlumno.CurrentRow.Cells[0].Value == null)
            {
                MetroMessageBox.Show(this, "Sellecione un alumno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //frmFamilia frmFamilia = new frmFamilia();
                //frmFamilia.id_Alumno = int.Parse(mgAlumno.CurrentRow.Cells[0].Value.ToString());
                //frmFamilia.ShowDialog();
            }

        }
    }
}
