using DiplomaFinal.Servicio.Idioma;
using Negocio.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomaFinal.Servicio
{
    public partial class IUservicios : MetroFramework.Forms.MetroForm
    {
        public IUservicios()
        {
            InitializeComponent();
        }

        private void IUservicios_Load(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            frmBitacora frmBitacora = new frmBitacora();
            frmBitacora.ShowDialog();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            frmIdiomaIndex frmIdioma = new frmIdiomaIndex();
            frmIdioma.ShowDialog();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            frmPermiso frmPermiso = new frmPermiso();
            frmPermiso.ShowDialog();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            frmBackup frmBackup = new frmBackup();
            frmBackup.ShowDialog();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            frmUsuario frmUsuario = new frmUsuario();
            frmUsuario.ShowDialog();
        }
    }
}
