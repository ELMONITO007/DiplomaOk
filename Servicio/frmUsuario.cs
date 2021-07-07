using DiplomaFinal.Mensajes;
using Entities.Usuario;
using Negocio;
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
namespace DiplomaFinal.Servicio
{
    public partial class frmUsuario : MetroFramework.Forms.MetroForm
    {
    
        Negocio.UsuariosComponent usuariosComponent = new UsuariosComponent();
        List<Usuarios> listaUsuario = new List<Usuarios>();
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            llenarGrillas();
        }
        private void llenarGrillas()
        {
            int n = 0;
            listaUsuario = usuariosComponent.Read();
            foreach (var item in listaUsuario)
            {
                n = mgUsuario.Rows.Add();
                mgUsuario.Rows[n].Cells[0].Value = item.Id;
                mgUsuario.Rows[n].Cells[1].Value = item.Email;

                mgUsuario.Rows[n].Cells[2].Value = item.Nombre;
                mgUsuario.Rows[n].Cells[3].Value = item.Apellido;
                mgUsuario.Rows[n].Cells[4].Value = item.CantidadIntentos;
                mgUsuario.Rows[n].Cells[5].Value = item.Bloqueado;
                n++;
            }
        }
        private bool VerificarCamposAlta()
        {
            string errApellido = ValidadoresComponent.VerificarLetras(txtApellido.Text) + " " + Environment.NewLine + ValidadoresComponent.VerificarTamaño(txtApellido.Text, 30, 2);
            string errNombre = ValidadoresComponent.VerificarLetras(txtNombre.Text) + " " + Environment.NewLine + ValidadoresComponent.VerificarTamaño(txtNombre.Text, 30, 2);
            string errUsuario = ValidadoresComponent.VerificarEmail(txtUsuario.Text);

            string errPassword = ValidadoresComponent.VerificarContraseña(txtContraseña.Text);
            string result = errApellido + errNombre + errUsuario + errPassword;
            lblErrApellido.Text = errApellido;
            lblErrContraseña.Text = errPassword;
            lblErrNombre.Text = errNombre;
            lblErrUsuario.Text = errUsuario;
            if (result.Length <= 6)
            {
                return true;
            }
            else
            {
                return false;
            }



        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            UsuariosComponent usuarios = new UsuariosComponent();
            usuarios.Desloquear(int.Parse(mgUsuario.CurrentRow.Cells[0].Value.ToString()));
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            UsuariosComponent usuarios = new UsuariosComponent();
            usuarios.Delete(int.Parse(mgUsuario.CurrentRow.Cells[0].Value.ToString()));
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void mgUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = mgUsuario.CurrentRow.Cells[0].Value.ToString();
          
            txtusuarioModificar.Text = mgUsuario.CurrentRow.Cells[1].Value.ToString();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnAlta_Click_1(object sender, EventArgs e)
        {
            if (VerificarCamposAlta())
            {
                UsuariosComponent usuariosComponent = new UsuariosComponent();
                Usuarios usuarios = new Usuarios();
                usuarios.Email = txtUsuario.Text.ToLower();
                usuarios.Apellido = txtApellido.Text;
                usuarios.Nombre = txtNombre.Text;
                usuarios.Password = txtContraseña.Text;

                if (usuariosComponent.Crear(usuarios))
                {
                    ValidadoresComponent.Alta("Usuario", this);
                    llenarGrillas();

                }
                else
                {
                    ValidadoresComponent.ErrorAltaModificacado("Usuario", this);
                }

            }
        }

        private void btnContraseña_Click(object sender, EventArgs e)
        {
            if (txtId.Text=="" || txtId.Text==null  )
            {
                MetroMessageBox.Show(this, "Seleccione un Usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Usuarios usuarios = new Usuarios();
                usuarios.Id = int.Parse(txtId.Text);
                CambiarContraseñaDialog cambiarContraseñaDialog = new CambiarContraseñaDialog();
                cambiarContraseñaDialog.ShowDialog();
                string _contraseña = cambiarContraseñaDialog.pass;
                if (_contraseña != "")
                {
                    usuarios.Password = _contraseña;
                    usuarios.Email = txtusuarioModificar.Text;
                    usuariosComponent.UpdatePassword(usuarios);
                    MetroMessageBox.Show(this, "Se realizo el cambio de constraseña", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroMessageBox.Show(this, "El usuario cancelo el cambio de usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

          

        }
    }
}
