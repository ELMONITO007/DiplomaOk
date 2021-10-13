using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using Entitites;
using MetroFramework;
using Negocio;

namespace DiplomaFinal.Gestion_de_Infraestructura
{
    public partial class InfraIndex : MetroFramework.Forms.MetroForm
    {
        public InfraIndex()
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
        private void InfraIndex_Load(object sender, EventArgs e)
        {
            listaIdiomas();
            Obsever.AgregarForm(this);
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            frmProveedores frmProveedores = new frmProveedores();
            frmProveedores.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            frmMantenimiento frmMantenimiento = new frmMantenimiento();
            frmMantenimiento.ShowDialog();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Idioma idioma = new Idioma();
            idioma = (Idioma)cbIdioma.SelectedItem;
            Obsever.update(idioma);
        }
        void InfraIndex_FormClosing(object sender, FormClosingEventArgs e)

        {
            Obsever.QuitarForm(this);


        }
    }
}
