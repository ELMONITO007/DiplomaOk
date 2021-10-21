using Entities.Usuario;
using Entitites.Servicios.Login;
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

namespace DiplomaFinal.Index
{
    public partial class frmVerMiUsuario : MetroFramework.Forms.MetroForm
    {


        public frmVerMiUsuario()
        {
            InitializeComponent();
        }
        private Usuarios usuarios = new Usuarios();
        private void frmVerMiUsuario_Load(object sender, EventArgs e)
        {
            usuarios = SessionManager.instance.GetUSuario();
            txtApellido.Text = usuarios.Apellido;
            txtNombre.Text = usuarios.Nombre;
            txtUsuario.Text = usuarios.Email;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {

        }
    }
}

