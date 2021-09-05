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

namespace DiplomaFinal.Gestion_de_Infraestructura
{
    public partial class InfraIndex : MetroFramework.Forms.MetroForm
    {
        public InfraIndex()
        {
            InitializeComponent();
        }

        private void InfraIndex_Load(object sender, EventArgs e)
        {
            RecorridoForm.CambiarIdioma(this);
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            frmProveedores frmProveedores = new frmProveedores();
            frmProveedores.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            frmMantenimiento frmMantenimiento = new frmMantenimiento();
            frmMantenimiento.ShowDialog();
        }
    }
}
