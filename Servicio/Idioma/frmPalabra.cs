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

namespace DiplomaFinal.Servicio.Idioma
{
    public partial class frmPalabra : MetroFramework.Forms.MetroForm
    {
        public frmPalabra()
        {
            InitializeComponent();
        }
        private void llenarGrilla()
        {
            mgListado.Rows.Clear();
            PalabraComponent idiomaComponent = new PalabraComponent();
            List<Palabra> idiomas = new List<Palabra>();
            idiomas = idiomaComponent.Read();
            int n = 0;
            foreach (Palabra item in idiomas)
            {
                n = mgListado.Rows.Add();
                mgListado.Rows[n].Cells[0].Value = item.Id;
                mgListado.Rows[n].Cells[1].Value = item.palabra;

                n++;
            }
        }
        private void frmPalabra_Load(object sender, EventArgs e)
        {
            llenarGrilla();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            mgListado.Rows.Clear();
            PalabraComponent idiomaComponent = new PalabraComponent();
            List<Palabra> idiomas = new List<Palabra>();

            string resultado = ValidadoresComponent.VerificarLetras(txtBuscar.Text);
            if (resultado == "")
            {
                mgListado.Rows.Clear();
                idiomas = idiomaComponent.buscar(txtBuscar.Text);
                int n = 0;
                foreach (Palabra item in idiomas)
                {
                    n = mgListado.Rows.Add();
                    mgListado.Rows[n].Cells[0].Value = item.Id;
                    mgListado.Rows[n].Cells[1].Value = item.palabra;

                    n++;
                }

            }
            else
            {
                MetroMessageBox.Show(this, resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
            mgListado.Rows.Clear();
            llenarGrilla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string resultadoIdioma = ValidadoresComponent.VerificarLetras(txtIdioma.Text);
            if (resultadoIdioma == "")
            {
                PalabraComponent idiomaComponent = new PalabraComponent();
                Palabra idioma = new Palabra();
                idioma.Id = int.Parse(mgListado.CurrentRow.Cells[0].Value.ToString());
                idioma.palabra = txtIdioma.Text;

                idiomaComponent.Update(idioma);
                llenarGrilla();
            }
            else
            {

                MetroMessageBox.Show(this, resultadoIdioma, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            PalabraComponent idiomaComponent = new PalabraComponent();
            var confirmar = MetroMessageBox.Show(this, "¿Desea Borrar este registro?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (confirmar == DialogResult.Yes)
            {
                idiomaComponent.Delete(int.Parse(mgListado.CurrentRow.Cells[0].Value.ToString()));
                llenarGrilla();
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            string resultadoIdioma = ValidadoresComponent.VerificarLetras(txtIdioma.Text);
            if (resultadoIdioma == "")
            {
                PalabraComponent idiomaComponent = new PalabraComponent();
                Palabra idioma = new Palabra();

                idioma.palabra = txtIdioma.Text;

                if (idiomaComponent.Create(idioma) == null)
                {
                    ValidadoresComponent.ErrorAltaModificacado("Idioma", this);

                }
                else
                {
                    llenarGrilla();
                }


            }
            else
            {

                MetroMessageBox.Show(this, resultadoIdioma, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
        }

        private void mgListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdioma.Text = mgListado.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
