using Entities;
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

namespace DiplomaFinal.VistaMaestroGrado
{
    public partial class frmMaestro : MetroFramework.Forms.MetroForm
    {
        public frmMaestro()
        {
            InitializeComponent();
        }
        public Persona persona = new Persona();
        private void frmMaestro_Load(object sender, EventArgs e)
        {
            this.Text = "Bienvenido " + persona.nombreCompleto;
            UsuarioPersonaComponent usuarioPersonaComponent = new UsuarioPersonaComponent();
            persona = usuarioPersonaComponent.ReadByPersona(SessionManager.instance.GetUSuario().Id).persona;
            List<Idioma> idiomas = new List<Idioma>();
            IdiomaComponent idiomaComponent = new IdiomaComponent();

            idiomas = idiomaComponent.Read();
            cbIdioma.DataSource = idiomas;
            cbIdioma.DisplayMember = "idioma";
            cbIdioma.ValueMember = "Id";
     
            RecorridoForm.CambiarIdioma(this);

        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            frmCursoMaestra frmCursoMaestra = new frmCursoMaestra();
            frmCursoMaestra.persona = persona;
            frmCursoMaestra.ShowDialog();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
         
            frmBoletinMaestro frmCursoMaestra = new frmBoletinMaestro();
            frmCursoMaestra.persona = persona;
            frmCursoMaestra.ShowDialog();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            frmExamenMaestra frmCursoMaestra = new frmExamenMaestra();
            frmCursoMaestra.persona = persona;
            frmCursoMaestra.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            frmComunicacionesMaestra frmCursoMaestra = new frmComunicacionesMaestra();
            frmCursoMaestra.persona = persona;
            frmCursoMaestra.ShowDialog();
        }

        private void cbIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            SingletonIdioma.intance.CambiarIdioma((Idioma)cbIdioma.SelectedItem);
            RecorridoForm.CambiarIdioma(this);
        }
    }
}
