
using Negocio.Gestion_de_boletin;
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
using MetroFramework;
using Entities;
using Negocio.Gestion_de_Alumnos;

namespace DiplomaFinal.Gestion_Boletin
{
    public partial class frmMateria : MetroFramework.Forms.MetroForm
    {
        public frmMateria()
        {
            InitializeComponent();
        }

        void llenargrilla()
        {
            RecorridoForm.LimpiarTXT(this);
            mgEspecialidades.Rows.Clear();
            MateriaComponent personaComponent = new MateriaComponent();

            int n = 0;
            foreach (var item in personaComponent.Read())
            {
                n = mgEspecialidades.Rows.Add();
                mgEspecialidades.Rows[n].Cells[0].Value = item.Id;
                mgEspecialidades.Rows[n].Cells[1].Value = item.materia;
                mgEspecialidades.Rows[n].Cells[2].Value = item.especialidad.especialidad;

                n++;
            }



        }

        bool verificarcampos()

        {
            string error = "";
            error = ValidadoresComponent.VerificarLetras(txtMateria.Text);

            error = error + Environment.NewLine + ValidadoresComponent.VerificarLetras(txtEspecialidad.Text);
            if (error.Length < 5)
            {
                return true;
            }
            else
            {
                MetroMessageBox.Show(this, error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

        }
        private void frmMateria_Load(object sender, EventArgs e)
        {
            RecorridoForm.CambiarIdioma(this);
            EspecialidadComponent especialidadComponent = new EspecialidadComponent();
            txtEspecialidad.DataSource = especialidadComponent.Read();
            txtEspecialidad.DisplayMember = "especialidad";
            txtEspecialidad.ValueMember = "Id";
            llenargrilla();
        }

        private void btnAltaEsp_Click(object sender, EventArgs e)
        {
            if (verificarcampos())
            {
                Especialidad especialidad = new Especialidad();
                especialidad = (Especialidad)txtEspecialidad.SelectedItem;
                Materia materia = new Materia(especialidad);
                materia.materia = txtMateria.Text;

                MateriaComponent materiaComponent = new MateriaComponent();
                if (materiaComponent.Create(materia) == null)
                {
                    ValidadoresComponent.ErrorAltaModificacado("Materia", this);
                    RecorridoForm.LimpiarTXT(this);
                }
                else
                {
                    ValidadoresComponent.Alta("Materia", this);
                    RecorridoForm.LimpiarTXT(this);
                    llenargrilla();

                }
            }
        }

        private void btnModificarEsp_Click(object sender, EventArgs e)
        {
            if (verificarcampos())
            {
                Especialidad especialidad = new Especialidad();
                especialidad = (Especialidad)txtEspecialidad.SelectedItem;
                Materia materia = new Materia(especialidad);
                materia.materia = txtMateria.Text;
                materia.Id=int.Parse( mgEspecialidades.CurrentRow.Cells[0].Value.ToString());
                MateriaComponent materiaComponent = new MateriaComponent();
                materiaComponent.Update(materia);
                RecorridoForm.LimpiarTXT(this);
                llenargrilla();

            }
        }

        private void btnEliminarEsp_Click(object sender, EventArgs e)
        {
            MateriaComponent materiaComponent = new MateriaComponent();
            materiaComponent.Delete(int.Parse(mgEspecialidades.CurrentRow.Cells[0].Value.ToString()));
            ValidadoresComponent.Baja("Materia", this);
            llenargrilla();
        }

        private void mgEspecialidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMateria.Text = mgEspecialidades.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
