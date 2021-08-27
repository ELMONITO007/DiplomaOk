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
using Entitites.Negocio.Salas;
using MetroFramework;
using Negocio;
using Negocio.Servicios.REGEX;

namespace DiplomaFinal.Gesion_de_Salas
{
    public partial class frmGrado : MetroFramework.Forms.MetroForm
    {
        public frmGrado()
        {
            InitializeComponent();
        }
        void llenarGrilla()

        {
            mgGrado.Rows.Clear();
            GradoComponent gradoComponent = new GradoComponent();
            int n = 0;
            foreach (var item in gradoComponent.Read())
            {
                n = mgGrado.Rows.Add();

                mgGrado.Rows[n].Cells[0].Value = item.Id;
                mgGrado.Rows[n].Cells[1].Value = item.nombre;
                mgGrado.Rows[n].Cells[2].Value = item.año;


            }
        }
        bool verificarCampos()

        {
            string error = ValidadoresComponent.VerificarNumerosIntervalo(txtGrado.Text, 3, 18);
            error = error + " " + ValidadoresComponent.VerificarLetras(txtNombre.Text);

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
        private void frmGrado_Load(object sender, EventArgs e)
        {
            RecorridoForm.CambiarIdioma(this);
            llenarGrilla();
        }

        private void txtNombre_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                MetroMessageBox.Show(this, "Campo buscar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                GradoComponent gradoComponent = new GradoComponent();
                mgGrado.Rows.Clear();
                int n = 0;
                foreach (var item in gradoComponent.buscar(txtBuscar.Text))
                {
                    n = mgGrado.Rows.Add();

                    mgGrado.Rows[n].Cells[0].Value = item.Id;
                    mgGrado.Rows[n].Cells[1].Value = item.nombre;
                    mgGrado.Rows[n].Cells[2].Value = item.año;


                }
            }
        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
            llenarGrilla();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (verificarCampos())
            {
                GradoComponent gradoComponent = new GradoComponent();
                Grado grado = new Grado();
                grado.nombre = txtNombre.Text;
                grado.año = int.Parse(txtGrado.Text);
                if (gradoComponent.Create(grado)==null)
                {
                    ValidadoresComponent.ErrorAltaModificacado("Grado", this);

                }
                else
                {
                    ValidadoresComponent.Alta("Grado", this);
                    llenarGrilla();
                }
                RecorridoForm.LimpiarTXT(this);
            }
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (mgGrado.CurrentRow.Cells[0].Value==null)
            {
                MetroMessageBox.Show(this, "Seleccione un grado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                GradoComponent gradoComponent = new GradoComponent();
                Grado grado = new Grado();
                grado.nombre = txtNombre.Text;
                grado.año = int.Parse(txtGrado.Text);
                grado.Id = int.Parse(mgGrado.CurrentRow.Cells[0].Value.ToString());
                gradoComponent.Update(grado);
                llenarGrilla();
            }
        }

        private void mgGrado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtGrado.Text = mgGrado.CurrentRow.Cells[2].Value.ToString();
            txtNombre.Text = mgGrado.CurrentRow.Cells[1].Value.ToString();

        }
    }
}
