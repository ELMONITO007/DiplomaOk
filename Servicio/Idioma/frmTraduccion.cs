using Entities;
using MetroFramework;
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

namespace DiplomaFinal.Servicio.Idioma
{
    public partial class frmTraduccion : MetroFramework.Forms.MetroForm
    {
        public frmTraduccion()
        {
            InitializeComponent();
        }
        private void llenarGrilla()
        {
            mgListado.Rows.Clear();
            TraduccionComponent idiomaComponent = new TraduccionComponent();
            List<Traduccion> idiomas = new List<Traduccion>();

            idiomas = idiomaComponent.ReadByIdioma(int.Parse(cbIdioma.SelectedValue.ToString()));
            int n = 0;
            foreach (Traduccion item in idiomas)
            {
                n = mgListado.Rows.Add();
                mgListado.Rows[n].Cells[0].Value = item.idioma.Id;
                mgListado.Rows[n].Cells[1].Value = item.palabra.Id;
                mgListado.Rows[n].Cells[2].Value = item.palabra.palabra;
                mgListado.Rows[n].Cells[3].Value = item.traduccion;
                n++;
            }
        }
        private void frmTraduccion_Load(object sender, EventArgs e)
        {
            Obsever.AgregarForm(this);
            IdiomaComponent idiomaComponent = new IdiomaComponent();
            List<Entities.Idioma> idiomas = new List<Entities.Idioma>();
            idiomas = idiomaComponent.Read();
            cbIdioma.DataSource = idiomas;
            cbIdioma.DisplayMember = "idioma";
            cbIdioma.ValueMember = "Id";
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            llenarGrilla();
        }

        private void mgListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtPalabra.Text = mgListado.CurrentRow.Cells[2].Value.ToString();
            if (mgListado.CurrentRow.Cells[3].Value != null)
            {
                txtIdioma.Text = mgListado.CurrentRow.Cells[3].Value.ToString();
              

            }
            else
            {
                txtIdioma.Text = "";
            }
        }
      
        private void btnModificar_Click(object sender, EventArgs e)
        {
      
            TraduccionComponent traduccionComponent = new TraduccionComponent();
            if (txtIdioma.Text == "")
            {
                MetroMessageBox.Show(this, "Campo Traduccion vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                Entities.Idioma idioma = new Entities.Idioma();
                idioma.Id = int.Parse(mgListado.CurrentRow.Cells[0].Value.ToString());
                Palabra palabra = new Palabra();
                palabra.Id = int.Parse(mgListado.CurrentRow.Cells[1].Value.ToString());
                Traduccion traduccion = new Traduccion(idioma,palabra);


                traduccion.traduccion = txtIdioma.Text;
                traduccionComponent.Update(traduccion);



            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
        
            TraduccionComponent traduccionComponent = new TraduccionComponent();
            if (txtIdioma.Text == "")
            {
                MetroMessageBox.Show(this, "Campo Traduccion vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                Entities.Idioma idioma = new Entities.Idioma();
                idioma.Id = int.Parse(mgListado.CurrentRow.Cells[0].Value.ToString());
                Palabra palabra = new Palabra();
                palabra.Id = int.Parse(mgListado.CurrentRow.Cells[1].Value.ToString());
                Traduccion traduccion = new Traduccion(idioma,palabra);
   

                traduccion.traduccion = txtIdioma.Text;
                traduccionComponent.Update(traduccion);

                llenarGrilla();

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "" || mgListado.RowCount == 0)
            {
                MetroMessageBox.Show(this, "Campo buscar vacio o no selecciono el idioma", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                List<Traduccion> traduccions = new List<Traduccion>();
                TraduccionComponent traduccionComponent = new TraduccionComponent();
                traduccions = traduccionComponent.buscar(txtBuscar.Text);
                mgListado.Rows.Clear();
                int n = 0;
                foreach (var item in traduccions)
                {
                    n = mgListado.Rows.Add();
                    mgListado.Rows[n].Cells[0].Value = item.idioma.Id;
                    mgListado.Rows[n].Cells[1].Value = item.palabra.Id;
                    mgListado.Rows[n].Cells[2].Value = item.palabra.palabra;
                    mgListado.Rows[n].Cells[3].Value = item.traduccion;
                    n++;
                }

            }
        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
            llenarGrilla();
        }
    }
}
