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
using Negocio.Servicios;

namespace DiplomaFinal
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {

        void listarIdioma()

        {
          
            List<Idioma> idiomas = new List<Idioma>();
            IdiomaComponent idiomaComponent = new IdiomaComponent();

            idiomas = idiomaComponent.Read();
            cbIdioma.DataSource = idiomas;
            cbIdioma.DisplayMember = "idioma";
            cbIdioma.ValueMember = "Id";

        }
        public Login()
        {

            InitializeComponent();
            
        
        }


        public  void CambiarIdiomaSinLogueo()

        {
            TraduccionComponent traduccionComponent = new TraduccionComponent();
            List<Traduccion> traduccions = new List<Traduccion>();
            IdiomaComponent idiomaComponent = new IdiomaComponent();
            Idioma idioma = new Idioma();
            idioma = (Idioma)cbIdioma.SelectedItem;
    

            traduccions = traduccionComponent.ReadByIdioma(idioma.Id);





            foreach (var traduccion in traduccions)
            {
                foreach (Control item in this.Controls)
                {

                    if (item.ToString().Contains("Label") || item.ToString().Contains("Button") || item.ToString().Contains("Tile"))
                    {


                        if (traduccion.palabra.palabra == item.Tag.ToString())
                        {
                            item.Text = traduccion.traduccion;
                        }

                    }
                    if (item.ToString().Contains("TabControl"))
                    {


                        foreach (Control subItem in item.Controls)
                        {
                            if (traduccion.palabra.palabra == subItem.Tag.ToString())
                            {
                                subItem.Text = traduccion.traduccion;
                            }

                            foreach (Control tab in subItem.Controls)
                            {
                                if (tab.ToString().Contains("Label") || tab.ToString().Contains("Button") || tab.ToString().Contains("Tile"))
                                {
                                    if (tab.Tag != null)
                                    {
                                        if (traduccion.palabra.palabra == tab.Tag.ToString())
                                        {
                                            tab.Text = traduccion.traduccion;
                                        }
                                    }


                                }
                            }

                        }
                    }
                }
            }




            SingletonIdioma.intance.CambiarIdioma(idioma);



        }


        private void Login_Load(object sender, EventArgs e)
        {
            Instalacion instalacion = new Instalacion();
            instalacion.VerificarPrimeraVez();
            listarIdioma();
            CambiarIdiomaSinLogueo();
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
                            listarIdioma();
                        }
                        if (item.roles.name == "Alumno")
                        {
                            frmAlumnoIndex uservicios = new frmAlumnoIndex();
                            uservicios.ShowDialog();
                            listarIdioma();
                        }
                        if (item.roles.name == "Maestro")
                        {
                            frmMaestro uservicios = new frmMaestro();
                            uservicios.ShowDialog();
                            listarIdioma();
                        }

                    }


                }
                else
                {
                    lbError.Text = loginError.error;
                }
            }
            
        }

        private void cbIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            CambiarIdiomaSinLogueo();
        }
    }
}
