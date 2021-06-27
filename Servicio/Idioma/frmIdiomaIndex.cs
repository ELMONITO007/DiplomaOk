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

        private void frmIdiomaIndex_Load(object sender, EventArgs e)
        {
            
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
    }
}
