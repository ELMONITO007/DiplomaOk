using DiplomaFinal.Servicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomaFinal.Index
{
    public partial class frmAdministrador : MetroFramework.Forms.MetroForm
    {
        public frmAdministrador()
        {
            InitializeComponent();
        }

        private void frmAlumnoIndex_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            IUservicios uservicios = new IUservicios();
            uservicios.ShowDialog();
        }
    }
}
