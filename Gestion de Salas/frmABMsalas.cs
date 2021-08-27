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
using Entitites.Negocio.Salas;
using MetroFramework;
using Negocio;

using Negocio.Servicios.REGEX;
namespace DiplomaFinal.Gesion_de_Salas
{
    public partial class frmABMsalas : MetroFramework.Forms.MetroForm
    {
        public frmABMsalas()
        {
            InitializeComponent();
        }

        #region tipoSala
        void llenarGrillaTipoSala()
        {
          
     
            SalaComponent tipoSalaComponent = new SalaComponent();
            List<Sala> tipoSalas = new List<Sala>();
            tipoSalas = tipoSalaComponent.ReadTipoSala();
            

            txtTipo.DataSource = tipoSalas;
            txtTipo.DisplayMember = "tipoSala";
            txtTipo.ValueMember = "id";

        }
  
     

        private void btnAltaEsp_Click(object sender, EventArgs e)
        {
          
        }
        private void mgTipoSala_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }


        private void btnModificarEsp_Click(object sender, EventArgs e)
        {
           

        }
        #endregion


        #region sala

        void llenarGrillaSala()
        {
            int n = 0;
            mgSala.Rows.Clear();
            SalaComponent SalaComponent = new SalaComponent();
            foreach (var item in SalaComponent.Read())
            {
                n = mgSala.Rows.Add();
      
                mgSala.Rows[n].Cells[0].Value = item.Id;
                mgSala.Rows[n].Cells[1].Value = item.nombre;
                mgSala.Rows[n].Cells[2].Value = item.tipoSala;
                mgSala.Rows[n].Cells[3].Value = item.capacidad;
                mgSala.Rows[n].Cells[4].Value = item.tiempo;

            }
        }


        private void metroButton5_Click(object sender, EventArgs e)
        {
            if (txtBuscarSala.Text == "")
            {

            }
            else
            {
                int n = 0;
                mgSala.Rows.Clear();
                SalaComponent SalaComponent = new SalaComponent();
                foreach (var item in SalaComponent.buscar(txtBuscarSala.Text))
                {
                    n = mgSala.Rows.Add();
                    mgSala.Rows[n].Cells[0].Value = item.Id;
                    mgSala.Rows[n].Cells[1].Value = item.nombre;
                    mgSala.Rows[n].Cells[2].Value = item.tipoSala;
                    mgSala.Rows[n].Cells[3].Value = item.capacidad;
                    mgSala.Rows[n].Cells[4].Value = item.tiempo;

                }
            }

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            llenarGrillaSala();
        }
        private void mgSala_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = mgSala.CurrentRow.Cells[1].Value.ToString();
            txtTipo.Text = mgSala.CurrentRow.Cells[2].Value.ToString();
            txtCapacidad.Text = mgSala.CurrentRow.Cells[3].Value.ToString();
       
            chTiempo.Checked =bool.Parse(mgSala.CurrentRow.Cells[4].Value.ToString());
        }
        private void btnModificarSala_Click(object sender, EventArgs e)
        {
            if (mgSala.CurrentRow.Cells[0].Value == null)
            {
                MetroMessageBox.Show(this, "Seleccione una sala", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (verificarCampoSala())
                {
                    SalaComponent salaComponent = new SalaComponent();
                    Sala sala = new Sala();
                    sala.Id = int.Parse(mgSala.CurrentRow.Cells[0].Value.ToString());
                    sala.capacidad = int.Parse(txtCapacidad.Text);
                    sala.nombre = txtNombre.Text;
                    sala.tiempo = chTiempo.Checked;
                    sala.tipoSala = txtTipo.Text;
                    salaComponent.Update(sala);
                    
                     

                        llenarGrillaSala();
                    
                }

            }
        }
        private bool verificarCampoSala()
        {
            string error = ValidadoresComponent.VerificarLetras(txtNombre.Text);
            error = error + " " + ValidadoresComponent.VerificarNumerosIntervalo(txtCapacidad.Text, 1, 50);

            if (error.Length < 15)
            {

                return true;
            }
            else
            {
                MetroMessageBox.Show(this, error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

        }

        private void btnAltaSala_Click(object sender, EventArgs e)
        {

            if (verificarCampoSala())
            {
                SalaComponent salaComponent = new SalaComponent();
                Sala sala = new Sala();

                sala.capacidad = int.Parse(txtCapacidad.Text);
                sala.nombre = txtNombre.Text;
                sala.tiempo = chTiempo.Checked;
                sala.tipoSala = txtTipo.Text;
                if (salaComponent.Create(sala) == null)
                {
                    ValidadoresComponent.ErrorAltaModificacado("sala", this);

                }
                else
                {
                    llenarGrillaSala();
                }

            }
            #endregion




        }
        private void frmABMsalas_Load(object sender, EventArgs e)
        {
            RecorridoForm.CambiarIdioma(this);
            llenarGrillaTipoSala();
            llenarGrillaSala();
          
        }

     
    }
}
