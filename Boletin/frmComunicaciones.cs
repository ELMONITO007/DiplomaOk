using Entities;
using Negocio.Gestion_de_boletin;
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
using Negocio.Gestion_de_Personas;
using Entitites.Servicios.Login;
using Negocio.Servicios.REGEX;
using Entitites.Negocio.Personas;
using Entities.Usuario;
using Entitites;

namespace DiplomaFinal.Gestion_Boletin
{
    public partial class frmComunicaciones : MetroFramework.Forms.MetroForm
    {
        public frmComunicaciones()
        {
            InitializeComponent();
        }
        void llenarGrillaListado()
        {
            mgListaComunicado.Rows.Clear();
            ComunicadoComponent comunicadoComponent = new ComunicadoComponent();

            List<Comunicado> listaPersona = new List<Comunicado>();
            listaPersona = comunicadoComponent.Read();
            int n = 0;
            foreach (var item in listaPersona)
            {
                n = mgListaComunicado.Rows.Add();
                mgListaComunicado.Rows[n].Cells[0].Value = item.Id;
                mgListaComunicado.Rows[n].Cells[1].Value = item.persona.nombre;
                mgListaComunicado.Rows[n].Cells[2].Value = item.persona.apellido;
                mgListaComunicado.Rows[n].Cells[3].Value = item.persona.DNI;
                mgListaComunicado.Rows[n].Cells[4].Value = item.visto;
                string dat = item.fecha.ToString("dd-MM-yyyy");
                mgListaComunicado.Rows[n].Cells[5].Value = dat;
                mgListaComunicado.Rows[n].Cells[6].Value = item.maestro.nombre + " " + item.maestro.apellido;
                n++;
            }

        }
        private void LlenarGrilla()
        {
            mgAlumno.Rows.Clear();
            AlumnoComponent personaComponent = new AlumnoComponent();
          
            List<Alumno> listaPersona = new List<Alumno>();
            listaPersona = personaComponent.Read();
            int n = 0;
            foreach (var item in listaPersona)
            {
                n = mgAlumno.Rows.Add();
                mgAlumno.Rows[n].Cells[0].Value = item.Id;
                mgAlumno.Rows[n].Cells[1].Value = item.nombre;
                mgAlumno.Rows[n].Cells[2].Value = item.apellido;
                mgAlumno.Rows[n].Cells[3].Value = item.direccion;
                mgAlumno.Rows[n].Cells[4].Value = item.DNI;
                mgAlumno.Rows[n].Cells[5].Value = item.fechaNacimiento;
                n++;
            }

        }
        private void frmComunicaciones_Load(object sender, EventArgs e)
        {
            RecorridoForm.CambiarIdioma(this);
            LlenarGrilla();
            llenarGrillaListado();
            
        }

        private void mgListaComunicado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Comunicado comunicado = new Comunicado();
            ComunicadoComponent comunicadoComponent = new ComunicadoComponent();
            comunicado = comunicadoComponent.ReadBy(int.Parse(mgListaComunicado.CurrentRow.Cells[0].Value.ToString()));
            txtColeccione.Text = comunicado.comunicado;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                MetroMessageBox.Show(this, "Campo buscar vacio", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                mgListaComunicado.Rows.Clear();
                ComunicadoComponent comunicadoComponent = new ComunicadoComponent();

                List<Comunicado> listaPersona = new List<Comunicado>();
                listaPersona = comunicadoComponent.buscar(txtBuscar.Text);
                int n = 0;
                foreach (var item in listaPersona)
                {
                    n = mgListaComunicado.Rows.Add();
                    mgListaComunicado.Rows[n].Cells[0].Value = item.Id;
                    mgListaComunicado.Rows[n].Cells[1].Value = item.persona.nombre;
                    mgListaComunicado.Rows[n].Cells[2].Value = item.persona.apellido;
                    mgListaComunicado.Rows[n].Cells[3].Value = item.persona.DNI;
                    mgListaComunicado.Rows[n].Cells[4].Value = item.visto;
                    string dat = item.fecha.ToString("dd-MM-yyyy");
                    mgListaComunicado.Rows[n].Cells[5].Value = dat;
                    mgListaComunicado.Rows[n].Cells[6].Value = item.maestro.nombre + " " + item.maestro.apellido;
                    n++;
                }
            }
        }


        private void btnTodo_Click(object sender, EventArgs e)
        {
            llenarGrillaListado();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (txtNuevaComunicacion.Text=="")
            {
                MetroMessageBox.Show(this, "Campo Comunicado esta vacio", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Alumno alumno = new Alumno();
                alumno.Id = int.Parse(mgAlumno.CurrentRow.Cells[0].Value.ToString());
                Maestro maestro = new Maestro();
                MaestroComponent maestroComponent = new MaestroComponent();
                maestro = maestroComponent.ReadByUsuario(SessionManager.instance.GetUSuario().Id);
                Comunicado comunicado = new Comunicado (maestro,alumno);
                   
                    
                comunicado.comunicado = txtNuevaComunicacion.Text;
                ComunicadoComponent comunicadoComponent = new ComunicadoComponent();
                comunicadoComponent.Create(comunicado);
                ValidadoresComponent.Alta("Comunicacion", this);
                llenarGrillaListado();
                RecorridoForm.LimpiarTXT(this);
            }
         

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            ComunicadoComponent comunicadoComponent = new ComunicadoComponent();
            comunicadoComponent.Delete(int.Parse(mgListaComunicado.CurrentRow.Cells[0].Value.ToString()));
            txtColeccione.Text = "";
            llenarGrillaListado();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (txtColeccione.Text=="")
            {
                MetroMessageBox.Show(this, "Campo Comunicado esta vacio", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ComunicadoComponent comunicadoComponent = new ComunicadoComponent();
                Comunicado comunicado = new Comunicado();
                comunicado.Id = int.Parse(mgListaComunicado.CurrentRow.Cells[0].Value.ToString());
                comunicado.comunicado = txtColeccione.Text;
                comunicadoComponent.Update(comunicado);
                txtColeccione.Text = "";
              
            }
        }

        private void mgAlumno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
