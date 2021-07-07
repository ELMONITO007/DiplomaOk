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

namespace DiplomaFinal.Mensajes
{
    public partial class CambiarContraseñaDialog : MetroFramework.Forms.MetroForm
    {
        public string pass="";
        public CambiarContraseñaDialog()
        {
            InitializeComponent();
        }

        private void CambiarContraseñaDialog_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string errPassword = ValidadoresComponent.VerificarContraseña(txtPassword.Text);

            if (errPassword.Length <= 6)
            {
                pass = txtPassword.Text;
                this.Close();
            }

            else
            {
                pass = "";
                MetroMessageBox.Show(this, errPassword,"Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
       
    }
}
