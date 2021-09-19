
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiplomaFinal.Gesion_de_Salas;
using DiplomaFinal.Gestion_Boletin;

namespace DiplomaFinal.Index
{
    public partial class frmSalasIndex : MetroFramework.Forms.MetroForm
    {
        public frmSalasIndex()
        {
            InitializeComponent();
        }

        private void frmSalasIndex_Load(object sender, EventArgs e)
        {
            RecorridoForm.CambiarIdioma(this);
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            frmABMsalas frmABMsalas = new frmABMsalas();
            frmABMsalas.ShowDialog();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            frmReservaSalas frmReservaSalas = new frmReservaSalas();
            frmReservaSalas.ShowDialog();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            frmGrado frmGrado = new frmGrado();
            frmGrado.ShowDialog();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            frmCursos frmCursos = new frmCursos();
            frmCursos.ShowDialog();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            frmMateria frmCursos = new frmMateria();
            frmCursos.ShowDialog();
        }
    }
}
