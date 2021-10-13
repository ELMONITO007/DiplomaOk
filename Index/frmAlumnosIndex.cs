using DiplomaFinal.Gestion_Boletin;
using Entities;
using Entitites;
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

namespace DiplomaFinal.Gestion_de_Personas
{
    public partial class frmAlumnosIndex : MetroFramework.Forms.MetroForm
    {
        public frmAlumnosIndex()
        {
            InitializeComponent();
        }
        void listaIdiomas()

        {
            cbIdioma.DataSource = null;
            List<Idioma> idiomas = new List<Idioma>();
            IdiomaComponent idiomaComponent = new IdiomaComponent();

            idiomas = idiomaComponent.Read();
            cbIdioma.DataSource = idiomas;
            cbIdioma.DisplayMember = "idioma";
            cbIdioma.ValueMember = "Id";
            int index = 0;
            foreach (var item in idiomas)
            {
                if (SingletonIdioma.intance.getUsuario().idioma != item.idioma)
                {
                    index++;
                }
                else
                {
                    break;
                }

            }

            cbIdioma.SelectedIndex = index;




        }
        void frmAlumnosIndex_FormClosing(object sender, FormClosingEventArgs e)

        {
            Obsever.QuitarForm(this);


        }
        private void frmAlumnosIndex_Load(object sender, EventArgs e)
        {
            listaIdiomas();
            Obsever.AgregarForm(this);
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
        //    frmInscripcion frmInscripcion = new frmInscripcion();
        //    frmInscripcion.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            frmAlumno frmAlumno = new frmAlumno();
            frmAlumno.ShowDialog();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            //frmPersonal frmPersonal = new frmPersonal();
            //frmPersonal.ShowDialog();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            //frmComunicaciones frmComunicaciones = new frmComunicaciones();
            //frmComunicaciones.ShowDialog();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            //frmExamen frmExamen = new frmExamen();
            //frmExamen.ShowDialog();
        }
    }
}
