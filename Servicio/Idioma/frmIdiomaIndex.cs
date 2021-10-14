using Entitites;
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
    public partial class frmIdiomaIndex : MetroFramework.Forms.MetroForm
    {
        public frmIdiomaIndex()
        {
            InitializeComponent();
        }
        void listaIdiomas()

        {
            cbIdioma.DataSource = null;
            List<Entities.Idioma> idiomas = new List<Entities.Idioma>();
            IdiomaComponent idiomaComponent = new IdiomaComponent();

            idiomas = idiomaComponent.Read();
            cbIdioma.DataSource = idiomas;
            cbIdioma.DisplayMember = "idioma";
            cbIdioma.ValueMember = "Id";
            int index = 0;
            foreach (var item in idiomas)
            {
                if (SingletonIdioma.intance.getUsuario().idioma != item.idioma)
                {
                    index++;
                }
                else
                {
                    break;
                }

            }

            cbIdioma.SelectedIndex = index;




        }

        private void frmIdiomaIndex_Load(object sender, EventArgs e)
        {
            listaIdiomas();
            Obsever.AgregarForm(this);
        }

        private void Idioma_Click(object sender, EventArgs e)
        {
            frmIdioma frmIdioma = new frmIdioma();
            frmIdioma.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            frmPalabra frmIdioma = new frmPalabra();
            frmIdioma.ShowDialog();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            frmTraduccion frmIdioma = new frmTraduccion();
            frmIdioma.ShowDialog();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Entities.Idioma idioma = new Entities.Idioma();
            idioma = (Entities.Idioma)cbIdioma.SelectedItem;
            Obsever.update(idioma);
        }
    }
}
