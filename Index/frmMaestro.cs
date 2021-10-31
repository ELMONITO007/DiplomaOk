using DiplomaFinal.VistaMaestroGrado;
using Entities;
using Entities.Usuario;
using Entitites;
using Entitites.Servicios.Login;
using Negocio;
using Negocio.Gestion_de_Personas;
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
    public partial class frmMaestro : MetroFramework.Forms.MetroForm
    {
        Maestro maestro = new Maestro();
        Usuarios usuarios = new Usuarios();
        public frmMaestro()
        {
            InitializeComponent();
        }

        private void frmMaestro_Load(object sender, EventArgs e)
        {
            UsuariosComponent usuariosComponent = new UsuariosComponent();
            usuarios = usuariosComponent.ReadByEmail(SessionManager.instance.GetUSuario().Email);
            MaestroComponent maestroComponent = new MaestroComponent();
            maestro = maestroComponent.ReadByUsuario(maestro.Id);
            Obsever.AgregarForm(this);
            List<Idioma> idiomas = new List<Idioma>();
            IdiomaComponent idiomaComponent = new IdiomaComponent();

            idiomas = idiomaComponent.Read();
            cbIdioma.DataSource = idiomas;
            cbIdioma.DisplayMember = "idioma";
            cbIdioma.ValueMember = "Id";
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            frmCursoMaestra frmCursoMaestra = new frmCursoMaestra();
            frmCursoMaestra.persona = maestro;
            frmCursoMaestra.ShowDialog();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Idioma idioma = new Idioma();
            idioma = (Idioma)cbIdioma.SelectedItem;
            Obsever.update(idioma);
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            frmBoletinMaestro frmBoletinMaestro= new frmBoletinMaestro();
            frmBoletinMaestro.persona = maestro;
            frmBoletinMaestro.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            frmBoletinMaestro frmBoletinMaestro = new frmBoletinMaestro();
            frmBoletinMaestro.persona = maestro;
            frmBoletinMaestro.ShowDialog();
        }
    }
}
