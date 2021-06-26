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
using Entities;
using Negocio;
using Entitites;
using Entities.Usuario;
using Entitites.Servicios.Login;
using Negocio.Servicios.REGEX;
using DiplomaFinal.Index;

namespace DiplomaFinal
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {

            InitializeComponent();
            List<Idioma> idiomas = new List<Idioma>();
            IdiomaComponent idiomaComponent = new IdiomaComponent();

            idiomas = idiomaComponent.Read();
            cbIdioma.DataSource = idiomas;
            cbIdioma.DisplayMember = "idioma";
            cbIdioma.ValueMember = "Id";
        
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        bool VerificarCampos(Usuarios usuarios)


        {
            string error = ValidadoresComponent.VerificarEmail(usuarios.Email);
            error = ValidadoresComponent.VerificarContraseña(usuarios.Password);

            if (error.Length < 15)
            {

                return true;
            }
            else
            {
                lbError.Text=error;

                return false;
            }




        }
        private void txtIngresar_Click(object sender, EventArgs e)
        {
            SingletonIdioma.intance.CambiarIdioma((Idioma)cbIdioma.SelectedItem);
            LoginComponent loginComponent = new LoginComponent();
            Usuarios usuarios = new Usuarios();
            usuarios.UserName = txtUsuario.Text;
            usuarios.Email = txtUsuario.Text;
            usuarios.Password = txtContraseña.Text;

            if (VerificarCampos(usuarios))
            {
                LoginError loginError = new LoginError();
                loginError = loginComponent.VerificarLogin(usuarios);
                if (loginError.error == "")
                {

                    UsuarioRolesComponent usuarioRoles = new UsuarioRolesComponent();
            
                    foreach (var item in usuarioRoles.ReadByUsuario(SessionManager.instance.GetUSuario().Id))
                    {
                        if (item.roles.name == "Administrador")
                        {
                            frmAdministrador uservicios = new frmAdministrador();
                            uservicios.ShowDialog();
                        }
                        if (item.roles.name == "Alumno")
                        {
                            frmAlumnoIndex uservicios = new frmAlumnoIndex();
                            uservicios.ShowDialog();
                        }
                        if (item.roles.name == "Maestro")
                        {
                            frmMaestro uservicios = new frmMaestro();
                            uservicios.ShowDialog();
                        }

                    }


                }
                else
                {
                    lbError.Text = loginError.error;
                }
            }
            
        }
    }
}
