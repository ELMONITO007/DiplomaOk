using DiplomaFinal.Gesion_de_Salas;
using DiplomaFinal.VistaAlumno;
using Entities;
using Entities.Usuario;
using Entitites.Negocio.Personas;
using Entitites.Negocio.Salas;
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
    public partial class frmAlumnoIndex : MetroFramework.Forms.MetroForm
    {
        public frmAlumnoIndex()
        {
            UsuariosComponent usuariosComponent = new UsuariosComponent();
            usurios = usuariosComponent.ReadByEmail(SessionManager.instance.GetUSuario().Email);
            AlumnoComponent alumnoComponent = new AlumnoComponent();
            alumno = alumnoComponent.ReadByUsuario(usurios.Id);
            CursoComponent cursoComponent = new CursoComponent();
            curso = cursoComponent.ReadByPersona(alumno.Id);
            InitializeComponent();
        }

        private void frmAlumnoIndex_Load(object sender, EventArgs e)
        {
            List<Idioma> idiomas = new List<Idioma>();
            IdiomaComponent idiomaComponent = new IdiomaComponent();

            idiomas = idiomaComponent.Read();
            cbIdioma.DataSource = idiomas;
            cbIdioma.DisplayMember = "idioma";
            cbIdioma.ValueMember = "Id";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            frmDatosPersonales frmDatosPersonales = new frmDatosPersonales();
            frmDatosPersonales.persona = alumno;
            frmDatosPersonales.ShowDialog();

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            frmExamenAlumno frmExamenAlumno = new frmExamenAlumno();
            frmExamenAlumno.persona = alumno;
            frmExamenAlumno.curso = curso;
            frmExamenAlumno.ShowDialog();
        }
        Curso curso = new Curso();
        Usuarios usurios = new Usuarios();
        Alumno alumno = new Alumno();


        private void metroTile4_Click(object sender, EventArgs e)
        {
            frmCalendario frmCalendario = new frmCalendario();
            frmCalendario.curso = curso.Id;
            frmCalendario.ShowDialog();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            frmBoletinAlumno frmBoletinAlumno = new frmBoletinAlumno();
            frmBoletinAlumno.alumno = alumno;
            frmBoletinAlumno.ShowDialog();

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            frmComunicadoAlumno frmComunicadoAlumno = new frmComunicadoAlumno();
            frmComunicadoAlumno.persona = alumno;
            frmComunicadoAlumno.ShowDialog();
        }

        private void cbIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Idioma idioma = new Idioma();
            idioma = (Idioma)cbIdioma.SelectedItem;
            Obsever.update(idioma);
        }

        
    }
}
