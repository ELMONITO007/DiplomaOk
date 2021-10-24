using Entities;
using Entitites.Negocio.Personas;
using MetroFramework;
using Negocio;
using Negocio.Gestion_de_Alumnos;
using Negocio.Gestion_de_Personas;
using Negocio.Servicios.REGEX;
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
    public partial class frmFamilia : MetroFramework.Forms.MetroForm
    {
        public int id_Alumno { get; set; }
        public frmFamilia()
        {
            InitializeComponent();
        }

        private void llenarGrilla()
        {
            mgAlumno.Rows.Clear();
            int n = 0;
            ParienteComponent parentescoComponent = new ParienteComponent();
            foreach (var item in parentescoComponent.ReadByAlumno(id_Alumno))
            {

                n = mgAlumno.Rows.Add();
                mgAlumno.Rows[n].Cells[0].Value = item.Id;
                mgAlumno.Rows[n].Cells[1].Value = item.nombre;
                mgAlumno.Rows[n].Cells[2].Value = item.apellido;
                mgAlumno.Rows[n].Cells[3].Value = item.direccion;
                mgAlumno.Rows[n].Cells[4].Value = item.DNI;
           
                mgAlumno.Rows[n].Cells[5].Value = item.fechaNacimiento.ToString("dd-MM-yyyy");
                mgAlumno.Rows[n].Cells[6].Value = item.parentesco;
                mgAlumno.Rows[n].Cells[7].Value = item.autorizadoRetirar;
                mgAlumno.Rows[n].Cells[8].Value = item.Id;
                mgAlumno.Rows[n].Cells[9].Value = item.listaTelefono[0].codigo_Area;
                mgAlumno.Rows[n].Cells[10].Value = item.listaTelefono[0].numero;
                n++;
            }
        
        }
        private bool verificarCampos()
        {
            string error = "";

            error = ValidadoresComponent.VerificarLetras(txtNombre.Text);
            error = error + " " + ValidadoresComponent.VerificarLetras(txtApellido.Text);
            error = error + " " + ValidadoresComponent.VerificarNumerosIntervalo(txtDNI.Text, 1000000, 99999999);

            error = error + " " + ValidadoresComponent.VerificarNumeros(txtDNI.Text);
            error = error + " " + ValidadoresComponent.VerificarNumerosIntervalo(txtTelefonoArea.Text, 10, 9999);
            error = error + " " + ValidadoresComponent.VerificarNumerosIntervalo(txtTelefono.Text, 100000, 99999999);

            error = error + " " + ValidadoresComponent.VerificarTamaño(txtTelefono.Text + txtTelefonoArea.Text, 10, 10);
     
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
        private void frmFamilia_Load(object sender, EventArgs e)
        {
            RecorridoForm.CambiarIdioma(this);
            llenarGrilla();
            txtFechaNacimiento.MaxDate = DateTime.Now.AddYears(-18);
            txtFechaNacimiento.MinDate = DateTime.Now.AddYears(-75);
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_Click(object sender, EventArgs e)
        {

        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if ( verificarCampos())
            {

                Alumno alumno = new Alumno();
                alumno.Id = id_Alumno;
                Pariente parentesco = new Pariente(alumno);

        

                parentesco.autorizadoRetirar = chRetirar.Checked;
                parentesco.parentesco = txtParentesco.Text;
                parentesco.apellido = txtApellido.Text;
                parentesco.DNI = txtDNI.Text;

                parentesco.direccion = txtDireccion.Text;

                parentesco.fechaNacimiento = txtFechaNacimiento.Value;
                parentesco.nombre = txtNombre.Text;
                parentesco.tipoPersona = "Pariente";

              
                Telefono telefono = new Telefono();
                telefono.numero = int.Parse(txtTelefono.Text);
                telefono.codigo_Area= int.Parse(txtTelefonoArea.Text);

                ParienteComponent parienteComponent = new ParienteComponent();

                Pariente parienteCreado = new Pariente();
                parienteCreado = parienteComponent.Create(parentesco);
                TelefonoComponent unTelefono = new TelefonoComponent();
                Telefono telefonoCreado = new Telefono();

                telefonoCreado= unTelefono.Create(telefono);
                unTelefono.AgregarTelefonoAUnaPersona(telefonoCreado, parienteCreado);

                llenarGrilla();

                RecorridoForm.LimpiarTXT(this);


                
            }


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            mgAlumno.Rows.Clear();
            ParienteComponent personaComponent = new ParienteComponent();
           
            List<Pariente> listaPersona = new List<Pariente>();
            listaPersona = personaComponent.buscar(txtBuscar.Text);
            int n = 0;
            foreach (var item in listaPersona)
            {
                n = mgAlumno.Rows.Add();
                mgAlumno.Rows[n].Cells[0].Value = item.Id;
                mgAlumno.Rows[n].Cells[1].Value = item.nombre;
                mgAlumno.Rows[n].Cells[2].Value = item.apellido;
                mgAlumno.Rows[n].Cells[3].Value = item.direccion;
                mgAlumno.Rows[n].Cells[4].Value = item.DNI;
                string fecha = item.fechaNacimiento.ToString().Substring(1, 10);
                mgAlumno.Rows[n].Cells[5].Value = fecha;
                mgAlumno.Rows[n].Cells[6].Value = item.parentesco;
                mgAlumno.Rows[n].Cells[7].Value = item.autorizadoRetirar;
                mgAlumno.Rows[n].Cells[8].Value = item.Id;
                mgAlumno.Rows[n].Cells[9].Value = item.listaTelefono[0].codigo_Area;
                mgAlumno.Rows[n].Cells[10].Value = item.listaTelefono[0].numero;
                n++;
            }
        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
            llenarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (mgAlumno.CurrentRow.Cells[0].Value==null)
            {
                MetroMessageBox.Show(this, "Sellecione un alumno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ParienteComponent parentescoComponent = new ParienteComponent();
                parentescoComponent.Delete(int.Parse(mgAlumno.CurrentRow.Cells[8].Value.ToString()));
                llenarGrilla();
                RecorridoForm.LimpiarTXT(this);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void mgAlumno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       ;
            if (mgAlumno.CurrentRow.Cells[7].Value!=null)
            {

                chRetirar.Checked = Boolean.Parse(mgAlumno.CurrentRow.Cells[7].Value.ToString());
                txtParentesco.Text = mgAlumno.CurrentRow.Cells[6].Value.ToString();
                txtApellido.Text = mgAlumno.CurrentRow.Cells[2].Value.ToString();
                txtDNI.Text = mgAlumno.CurrentRow.Cells[4].Value.ToString();
                txtFechaNacimiento.Value=DateTime.Parse( mgAlumno.CurrentRow.Cells[5].Value.ToString());
                txtDireccion.Text = mgAlumno.CurrentRow.Cells[3].Value.ToString();
                txtTelefonoArea.Text = mgAlumno.CurrentRow.Cells[9].Value.ToString();
                txtTelefono.Text = mgAlumno.CurrentRow.Cells[10].Value.ToString();

                txtNombre.Text = mgAlumno.CurrentRow.Cells[1].Value.ToString();
            }

        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }
    }
}
