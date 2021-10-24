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
using Entities.Usuario;
using Entitites;
using Entitites.Negocio.Personas;
using MetroFramework;
using Negocio.Gestion_de_Alumnos;

using Negocio.Gestion_de_Personas;
using Negocio.Servicios.REGEX;

namespace DiplomaFinal.Gestion_de_Personas
{
    public partial class frmPersonal : MetroFramework.Forms.MetroForm
    {
        public frmPersonal()
        {
            InitializeComponent();
        }

        #region Especialidades


        private void llenarEspecialidad()
        {
            EspecialidadComponent especialidadComponent = new EspecialidadComponent();
            List<Especialidad> especialidad = new List<Especialidad>();
            especialidad = especialidadComponent.Read();
           
            
                txtEspecialidadAlta.DisplayMember = "especialidad";
                txtEspecialidadAlta.ValueMember = "Id";
            txtEspecialidadAlta.DataSource = especialidad;

        }
        void llenarGrillaEspecialidades()
        {
            int n = 0;
            mgEspecialidades.Rows.Clear();
            EspecialidadComponent especialidadComponent = new EspecialidadComponent();
            foreach (var item in especialidadComponent.Read())
            {
                n = mgEspecialidades.Rows.Add();
                mgEspecialidades.Rows[n].Cells[0].Value = item.Id;
                mgEspecialidades.Rows[n].Cells[1].Value = item.especialidad;
            }

        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                MetroMessageBox.Show(this, "El campo buscar esta vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            int n = 0;
            mgEspecialidades.Rows.Clear();
            EspecialidadComponent especialidadComponent = new EspecialidadComponent();
            foreach (var item in especialidadComponent.buscar(txtBuscar.Text))
            {
                n = mgEspecialidades.Rows.Add();
                mgEspecialidades.Rows[n].Cells[0].Value = item.Id;
                mgEspecialidades.Rows[n].Cells[1].Value = item.especialidad;
            }
        }
        private void mgEspecialidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEspecialidad.Text = mgEspecialidades.CurrentRow.Cells[1].Value.ToString();
        }

        private bool verificarCamposEspecialidad()

        {
            string error = "";
            error = ValidadoresComponent.VerificarLetras(txtEspecialidad.Text);

            if (error == "")
            {
                return true;
            }
            else
            {
                MetroMessageBox.Show(this, error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

        }
        private void btnTodo_Click(object sender, EventArgs e)
        {
            llenarGrillaEspecialidades();
        }







        private void btnAltaEsp_Click(object sender, EventArgs e)
        {
            if (verificarCamposEspecialidad())
            {
                EspecialidadComponent especialidadComponent = new EspecialidadComponent();
                Especialidad especialidad = new Especialidad();
                especialidad.especialidad = txtEspecialidad.Text;
                if (especialidadComponent.Create(especialidad) == null)
                {
                    ValidadoresComponent.ErrorAltaModificacado("Especialidad", this);
                }
                else
                {
                    RecorridoForm.LimpiarTXT(this);

                    llenarEspecialidad();
                    llenarGrillaEspecialidades();
                    RecorridoForm.LimpiarTXT(this);
                }
            }
        }

        private void btnModificarEsp_Click(object sender, EventArgs e)
        {
            if (mgEspecialidades.CurrentRow.Cells[0].Value != null)
            {
                EspecialidadComponent especialidadComponent = new EspecialidadComponent();
                Especialidad especialidad = new Especialidad();
                especialidad.Id = int.Parse(mgEspecialidades.CurrentRow.Cells[0].Value.ToString());
                especialidad.especialidad = txtEspecialidad.Text;
                especialidadComponent.Update(especialidad);
                llenarGrillaEspecialidades();

                llenarEspecialidad();
                RecorridoForm.LimpiarTXT(this);
            }
            else
            {
                MetroMessageBox.Show(this, "Sellecione una especialidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnEliminarEsp_Click(object sender, EventArgs e)
        {
            if (mgEspecialidades.CurrentRow.Cells[0].Value != null)
            {
                if (verificarCamposEspecialidad())
                {
                    EspecialidadComponent especialidadComponent = new EspecialidadComponent();
                    Especialidad especialidad = new Especialidad();

                    especialidad.especialidad = txtEspecialidad.Text;
                    especialidadComponent.Delete(int.Parse(mgEspecialidades.CurrentRow.Cells[0].Value.ToString()));
                    llenarGrillaEspecialidades();

                    llenarEspecialidad();
                    RecorridoForm.LimpiarTXT(this);
                }


            }
            else
            {
                MetroMessageBox.Show(this, "Sellecione una especialidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion


        #region AltaMaestro
        private bool verificarCamposAltaMaestro()
        {
           
            string error = ValidadoresComponent.VerificarLetras(txtNombre.Text);
            error = error + " " + ValidadoresComponent.VerificarLetras(txtApellido.Text);
            error = error + " " + ValidadoresComponent.VerificarNumerosIntervalo(txtDNI.Text, 10000000, 45000000);
            error = error + " " + ValidadoresComponent.VerificarAlfaNumerico(txtDireccion.Text);
            error = error + " " + ValidadoresComponent.VerificarContraseña(txtContraseña.Text);
            error = error + " " + ValidadoresComponent.VerificarNumerosIntervalo(txtTelefonoArea.Text, 10, 9999);
            error = error + " " + ValidadoresComponent.VerificarNumerosIntervalo(txtTelefono.Text, 100000, 99999999);

            error = error + " " + ValidadoresComponent.VerificarTamaño(txtTelefono.Text + txtTelefonoArea.Text, 10, 10);
            error = error + " " + ValidadoresComponent.VerificarEmail(txtEmail.Text);

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

        private bool verificarCamposDocumentacionMaestro()
        {

            string error = "";
            if (txtDocumentacionCertificado.Text == "")
            {
                error = "Falta Dni . ";
            }
            if (txtDocumentacionDNIPadre.Text == "")
            {
                error = error + "Falta Titulo. ";
            }
            if (txtDocumentacionCertificado.Text == "")
            {
                error = error + "Falta el certificado. ";
            }

            if (error.Length < 15)
            {
                return true;
            }
            else
            {
                MetroMessageBox.Show(this, error, "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        Maestro persona = new Maestro();
         Telefono telefono =new  Telefono();
        Usuarios usuarios = new Usuarios();
        Especialidad especialidad = new Especialidad();
        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (verificarCamposAltaMaestro())
            {
                persona.apellido = txtApellido.Text;
                persona.nombre = txtNombre.Text;
                persona.fechaNacimiento = txtFechaNaciemiento.Value.Date;
                persona.direccion = txtDireccion.Text;
                persona.DNI = txtDNI.Text;


                telefono.codigo_Area = int.Parse(txtTelefonoArea.Text);
                telefono.numero = int.Parse(txtTelefono.Text);


                usuarios.Email = txtEmail.Text;
                usuarios.Nombre = persona.nombre;
                usuarios.Apellido = persona.apellido;
                usuarios.Password = txtContraseña.Text;

                especialidad.especialidad = txtEspecialidadAlta.Text;
                btnAltaMaestro.Visible = true;
                tabIncripcion.SelectedIndex = 1;
        

            }
        }


        private void btnAltaMaestro_Click(object sender, EventArgs e)
        {
            if (verificarCamposDocumentacionMaestro())
            {

                Documento documentacion1 = new Documento();
                documentacion1.openFileDialog = openFileDialogAlumno;
                documentacion1.tipo_Documentancion = "DNI";

                Documento documentacion2 = new Documento();
                documentacion2.openFileDialog = openFileDialogPadre;
                documentacion2.tipo_Documentancion = "";

                Documento documentacion3 = new Documento();
                documentacion3.openFileDialog = openFileDialogCertificado;
                documentacion3.tipo_Documentancion = "";
   

                List<Documentacion> listaDocumentacion = new List<Documentacion>();
                listaDocumentacion.Add(documentacion1);
                listaDocumentacion.Add(documentacion2);
             listaDocumentacion.Add(documentacion3);

              

                //if (error != "")
                //{
                //    MetroMessageBox.Show(this, error, "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    RecorridoForm.LimpiarTXT(this);
                //}
                //else
                //{
                //    llenarGrillaMaestro();
                //    RecorridoForm.LimpiarTXT(this);
                //}
            }
        }

        OpenFileDialog openFileDialogAlumno = new OpenFileDialog();
        OpenFileDialog openFileDialogPadre = new OpenFileDialog();
        OpenFileDialog openFileDialogCertificado = new OpenFileDialog();
        OpenFileDialog openFileDialogVacuna = new OpenFileDialog();

    

      
        #endregion
        private void frmPersonal_Load(object sender, EventArgs e)
        {
            RecorridoForm.CambiarIdioma(this);
            txtFechaNaciemiento.MaxDate = DateTime.Now.AddYears(-18);
            txtFechaNaciemiento.MinDate = DateTime.Now.AddYears(-65);
            txtFechaNacimiento.MaxDate = DateTime.Now.AddYears(-18);
            txtFechaNacimiento.MinDate = DateTime.Now.AddYears(-65);
              txtFechaNacimiento.MaxDate = DateTime.Now.AddYears(-18);
            txtFechaNacimiento.MinDate = DateTime.Now.AddYears(-65);
       
            llenarGrillaEspecialidades();
            llenarGrillaMaestro();

            llenarEspecialidad();
        }

        #region MaestrosUpdate
        private void llenarGrillaMaestro()
        {
            mgAlumno.Rows.Clear();
            MaestroComponent personaComponent = new MaestroComponent();
   
            List<Maestro> listaPersona = new List<Maestro>();
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
        private void metroButton3_Click(object sender, EventArgs e)
        {


            if (mgAlumno.CurrentRow.Cells[0].Value == null)
            {
                MetroMessageBox.Show(this, "Seleccione un maestro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (VerificarCamposMaestros())
                {
                    Maestro persona = new Maestro();
                    persona.nombre = txtNombre.Text;
                    persona.apellido = txtApellido.Text;
                    persona.direccion = txtDireccion.Text;
                    persona.DNI = txtDNI.Text;
                    persona.fechaNacimiento = txtFechaNacimiento.Value;
                    persona.Id = int.Parse(mgAlumno.CurrentRow.Cells[0].Value.ToString());
                    persona.tipoPersona = "Maestro";
                    MaestroComponent personaComponent = new MaestroComponent();
                    personaComponent.Update(persona);
                    llenarGrillaMaestro();
                }

            }
        }
        private bool VerificarCamposMaestros()
        {
            string error = "";

            error = ValidadoresComponent.VerificarLetras(txtNombre.Text);
            error = error + " " + ValidadoresComponent.VerificarLetras(txtApellido.Text);
            error = error + " " + ValidadoresComponent.VerificarNumerosIntervalo(txtDNI.Text, 52610644, 99999999);

            error = error + " " + ValidadoresComponent.VerificarNumeros(txtDNI.Text);
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
        private void mgAlumno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            metroTextBox5.Text = mgAlumno.CurrentRow.Cells[1].Value.ToString();
            metroTextBox4.Text = mgAlumno.CurrentRow.Cells[2].Value.ToString();
            metroTextBox3.Text = mgAlumno.CurrentRow.Cells[3].Value.ToString();
            metroTextBox2.Text = mgAlumno.CurrentRow.Cells[4].Value.ToString();

        }
        private void metroButton5_Click(object sender, EventArgs e)
        {
            mgAlumno.Rows.Clear();
            PersonaComponent personaComponent = new PersonaComponent();
            TipoPersonaComponent tipoPersonaComponent = new TipoPersonaComponent();
            List<Persona> listaPersona = new List<Persona>();
            listaPersona = personaComponent.buscar(txtBuscar.Text,3);
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
        private void metroButton4_Click(object sender, EventArgs e)
        {
            llenarGrillaMaestro();
        }


        #endregion

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (mgAlumno.CurrentRow.Cells[0].Value==null)
            {
                MetroMessageBox.Show(this, "Sellecione un maestro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                frmEspecialidad frmEspecialidad = new frmEspecialidad();
                frmEspecialidad.legajo = int.Parse(mgAlumno.CurrentRow.Cells[0].Value.ToString());
                frmEspecialidad.ShowDialog();
                llenarEspecialidad();
            }
        }

        private void btnAlumnoDNI_Click_1(object sender, EventArgs e)
        {
            openFileDialogAlumno.Filter = "PDF file(*.pdf)|*.pdf";
            if (openFileDialogAlumno.ShowDialog() == DialogResult.OK)
            {
                txtDocumentacionDNIAlumno.Text = openFileDialogAlumno.FileName;

            }
        }

        private void btnPadreDNI_Click_1(object sender, EventArgs e)
        {

            openFileDialogPadre.Filter = "PDF file(*.pdf)|*.pdf";
            if (openFileDialogPadre.ShowDialog() == DialogResult.OK)
            {
                txtDocumentacionDNIPadre.Text = openFileDialogPadre.FileName;

            }
        }

        private void btnCertificado_Click_1(object sender, EventArgs e)
        {
            openFileDialogCertificado.Filter = "PDF file(*.pdf)|*.pdf";
            if (openFileDialogCertificado.ShowDialog() == DialogResult.OK)
            {
                txtDocumentacionCertificado.Text = openFileDialogCertificado.FileName;

            }
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            if (mgAlumno.CurrentRow.Cells[0].Value == null)
            {
                MetroMessageBox.Show(this, "Sellecione un maestro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                EspecialidadPersonaComponent especialidadPersonaComponent = new EspecialidadPersonaComponent();
                foreach (var item in especialidadPersonaComponent.ReadByPersona(int.Parse(mgAlumno.CurrentRow.Cells[0].Value.ToString())))
                {
                    if (item.especialidad.especialidad=="Maestro")
                    {
                        FrmHorarioMaestroGrado frmEspecialidad = new FrmHorarioMaestroGrado();
                        frmEspecialidad.legajo = int.Parse(mgAlumno.CurrentRow.Cells[0].Value.ToString());
                        frmEspecialidad.ShowDialog();
                    }
                    else
                    {
                        FrmHorarioProfe frmEspecialidad = new FrmHorarioProfe();
                        frmEspecialidad.legajo = int.Parse(mgAlumno.CurrentRow.Cells[0].Value.ToString());
                        frmEspecialidad.ShowDialog();
                    }
                    break;
                }

               
              
            }
        }
    }
}
