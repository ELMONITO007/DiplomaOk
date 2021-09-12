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
using DiplomaFinal.Servicio;
using DiplomaFinal.Gestion_de_Infraestructura;

namespace DiplomaFinal.Index
{
    public partial class frmAdministrador : MetroFramework.Forms.MetroForm
    {
        public frmAdministrador()
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
                if (SingletonIdioma.intance.getUsuario().idioma!=item.idioma)
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
        private void frmAlumnoIndex_Load(object sender, EventArgs e)
        {
          
            //CambiarIdioma();
           
            listaIdiomas();
            RecorridoForm.CambiarIdioma(this);

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            IUservicios uservicios = new IUservicios();
            uservicios.ShowDialog();
       listaIdiomas();
        }

    

        private void cbIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
        
          


        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Idioma idioma = new Idioma();
            idioma = (Idioma)cbIdioma.SelectedItem;
            SingletonIdioma.intance.CambiarIdioma(idioma);

            RecorridoForm.CambiarIdioma(this);
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Index.frmSalasIndex frmSalasIndex = new Index.frmSalasIndex();
            frmSalasIndex.ShowDialog();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            InfraIndex infraIndex = new InfraIndex();
            infraIndex.ShowDialog();
        }
    }
}
