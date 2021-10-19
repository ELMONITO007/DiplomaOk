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
using Entitites.Servicios;
using Entities;
using Negocio.Servicios.REGEX;
using MetroFramework;

namespace DiplomaFinal.Servicio.Idioma
{
    public partial class frmIdioma : MetroFramework.Forms.MetroForm
    {
        public frmIdioma()
        {
            InitializeComponent();
        }
        private void llenarGrilla()
        {

            mgListado.Rows.Clear();
            IdiomaComponent idiomaComponent = new IdiomaComponent();
            List<Entities.Idioma> idiomas = new List<Entities.Idioma>();
            idiomas = idiomaComponent.Read();
            int n = 0;
            foreach (Entities.Idioma item in idiomas)
            {
                n = mgListado.Rows.Add();
                mgListado.Rows[n].Cells[0].Value = item.Id;
                mgListado.Rows[n].Cells[1].Value = item.idioma;
                mgListado.Rows[n].Cells[2].Value = item.codigo;
                n++;
            }
        }

        private void frmIdioma_Load(object sender, EventArgs e)
        {
            //RecorridoForm.CambiarIdioma(this);
            Obsever.AgregarForm(this);
            llenarGrilla();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            mgListado.Rows.Clear();
             IdiomaComponent idiomaComponent = new IdiomaComponent();
            List<Entities.Idioma> idiomas = new List<Entities.Idioma>();

            string resultado = ValidadoresComponent.VerificarLetras(txtBuscar.Text);
            if (resultado == "")
            {
                mgListado.Rows.Clear();
                idiomas = idiomaComponent.buscar(txtBuscar.Text);
                int n = 0;
                foreach (Entities.Idioma item in idiomas)
                {
                    n = mgListado.Rows.Add();
                    mgListado.Rows[n].Cells[0].Value = item.Id;
                    mgListado.Rows[n].Cells[1].Value = item.idioma;
                    mgListado.Rows[n].Cells[2].Value = item.codigo;
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

        private void mgListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdioma.Text = mgListado.CurrentRow.Cells[1].Value.ToString();
            txtCodigo.Text = mgListado.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string resultadoCodigo = ValidadoresComponent.VerificarCodigoPais(txtCodigo.Text);
            string resultadoIdioma = ValidadoresComponent.VerificarLetras(txtIdioma.Text);
            if (resultadoCodigo == "" || resultadoIdioma == "")
            {
                IdiomaComponent idiomaComponent = new IdiomaComponent();
                Entities.Idioma idioma = new Entities.Idioma();
                idioma.Id = int.Parse(mgListado.CurrentRow.Cells[0].Value.ToString());
                idioma.idioma = txtIdioma.Text;
                idioma.codigo = txtCodigo.Text;
                if (idiomaComponent.Update(idioma))
                {
                    ValidadoresComponent.Modificado(idioma.idioma, this);
                    llenarGrilla();
                }
                else
                {
                    ValidadoresComponent.ErrorAltaModificacado(idioma.idioma, this);
                }
                
            }
            else
            {
                if (resultadoCodigo != "")
                {
                    MetroMessageBox.Show(this, resultadoCodigo, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (resultadoIdioma != "")
                {
                    MetroMessageBox.Show(this, resultadoIdioma, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            IdiomaComponent idiomaComponent = new IdiomaComponent();
            var confirmar = MetroMessageBox.Show(this, "¿Desea Borrar este registro?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (confirmar == DialogResult.Yes)
            {
                idiomaComponent.Delete(int.Parse(mgListado.CurrentRow.Cells[0].Value.ToString()));
                llenarGrilla();
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            string resultadoCodigo = ValidadoresComponent.VerificarCodigoPais(txtCodigo.Text);
            string resultadoIdioma = ValidadoresComponent.VerificarLetras(txtIdioma.Text);
            if (resultadoCodigo == "" && resultadoIdioma == "")
            {
                IdiomaComponent idiomaComponent = new IdiomaComponent();
                Entities.Idioma idioma = new Entities.Idioma();

                idioma.idioma = txtIdioma.Text;
                idioma.codigo = txtCodigo.Text;
                if (idiomaComponent.Create(idioma) == null)
                {
                    ValidadoresComponent.ErrorAltaModificacado("Idioma", this);

                }
                else
                {
                    ValidadoresComponent.Alta("Idioma", this);
                    llenarGrilla();
                }


            }
            else
            {
                if (resultadoCodigo != "")
                {
                    MetroMessageBox.Show(this, resultadoCodigo, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (resultadoIdioma != "")
                {
                    MetroMessageBox.Show(this, resultadoIdioma, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
    }
}
