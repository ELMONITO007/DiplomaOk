using Entities;
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
using MetroFramework;
using Negocio.Servicios.REGEX;
using Entitites.Negocio.Salas;

namespace DiplomaFinal.Gesion_de_Salas
{
    public partial class frmReservaSalas : MetroFramework.Forms.MetroForm
    {
        public frmReservaSalas()
        {
            InitializeComponent();
        }

        #region salas

        void llenarComboSala()

        {
            int año = DateTime.Now.Year;
            txtSalasAño.Items.Add(año);
            txtSalasAño.Items.Add(año + 1);
            txtturno.Items.Add("Mañana");
            txtturno.Items.Add("Tarde");
            txtturno.Items.Add("Noche");
           



        }

        void llenarGrillaGrado()


        {
            GradoComponent gradoComponent = new GradoComponent();
            List<Grado> grados = new List<Grado>();
            grados = gradoComponent.Read();
            txtGrado.DataSource = grados;
            txtGrado.ValueMember = "id";
            txtGrado.DisplayMember = "Nombre";


        }
        #endregion

        void llenarGrillaReservas()

        {
            CursoComponent cursoComponent = new CursoComponent();

            mgReserva.Rows.Clear();
            int n = 0;
            foreach (var item in cursoComponent.Read())
            {
                n = mgReserva.Rows.Add();

                mgReserva.Rows[n].Cells[0].Value = item.Id;
                mgReserva.Rows[n].Cells[1].Value = item.nombre;
                mgReserva.Rows[n].Cells[2].Value = item.sala.tipoSala;
                mgReserva.Rows[n].Cells[3].Value = item.sala.capacidad;
                mgReserva.Rows[n].Cells[4].Value = item.salaHorario.turno;
                mgReserva.Rows[n].Cells[5].Value = item.salaHorario.hora;
                mgReserva.Rows[n].Cells[6].Value = item.salaHorario.año;

                mgReserva.Rows[n].Cells[7].Value = item.sala.nombre;

                mgReserva.Rows[n].Cells[8].Value = item.grado.nombre;

            }


        }
        private void frmReservaSalas_Load(object sender, EventArgs e)
        {
            RecorridoForm.CambiarIdioma(this); llenarComboSala();
            llenarGrillaGrado();
            llenarGrillaReservas();
        }

        private void txtturno_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            int n = 0;
            mgSala.Rows.Clear();
            SalaHorarioComponent salaComponent = new SalaHorarioComponent();
           
            SalaHorario salaHorario = new SalaHorario();
            salaHorario.año = int.Parse(txtSalasAño.Text);
            salaHorario.turno = txtturno.Text;

            List<Sala> salas = new List<Sala>();
            salas = salaComponent.ObtenerSalasDisponibleGrado(salaHorario);
            if (salas.Count==0)
            {
                MetroMessageBox.Show(this, "No hay salas disponibles", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach (var item in salas)
                {
                    n = mgSala.Rows.Add();

                    mgSala.Rows[n].Cells[0].Value = item.Id;
                    mgSala.Rows[n].Cells[1].Value = item.nombre;
                    mgSala.Rows[n].Cells[2].Value = item.tipoSala;
                    mgSala.Rows[n].Cells[3].Value = item.capacidad;
                    mgSala.Rows[n].Cells[4].Value = item.tiempo;

                }
                btnModificarSala.Visible = true;
            }
            
        }
        SalaHorario salaHorario = new SalaHorario();
        private void btnModificarSala_Click(object sender, EventArgs e)
        {
            if (mgSala.CurrentRow.Cells[0].Value==null)
            {
                MetroMessageBox.Show(this, "Seleccione una sala", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Sala sala = new Sala();

                salaHorario.año = int.Parse(txtSalasAño.Text);
                salaHorario.turno = txtturno.Text;
                salaHorario.sala.Id = int.Parse(mgSala.CurrentRow.Cells[0].Value.ToString());
                salaHorario.sala.tipoSala = mgSala.CurrentRow.Cells[2].Value.ToString();
                txtGrado.Enabled = true;
                txtNombreCurso.Enabled = true;
                btnAlta.Enabled = true;
                tabIncripcion.SelectedIndex = 1;
            }

        }

        bool verificarCamposCurso()


        {
            string error = ValidadoresComponent.VerificarAlfaNumerico(txtGrado.Text);
            error = error + " " + ValidadoresComponent.VerificarLetras(txtNombreCurso.Text);

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

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (verificarCamposCurso())
            {


                Sala sala = new Sala();
                sala.Id= salaHorario.sala.Id;
                Grado grado = new Grado();
                grado.Id = int.Parse(txtGrado.SelectedValue.ToString());
                SalaHorarioComponent salaHorarioComponent = new SalaHorarioComponent();
            salaHorarioComponent.Create(salaHorario);
            Curso curso = new Curso(sala,grado, salaHorarioComponent.ReadBySalaYañoYTurnoGrado(salaHorario));
        
            curso.nombre = txtNombreCurso.Text;
     
      
            CursoComponent cursoComponent = new CursoComponent();
            if (cursoComponent.Create(curso)==null)
            {
                ValidadoresComponent.ErrorAltaModificacado("Curso", this);
               

            }
            else
            {
                ValidadoresComponent.Alta("Curso", this);
                    llenarGrillaReservas();
                    mgSala.Rows.Clear();
            }
            RecorridoForm.LimpiarTXT(this);
            }
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {

        }

        private void txtSalasAño_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
