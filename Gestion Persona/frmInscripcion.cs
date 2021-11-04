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
using MetroFramework;
using Negocio.Gestion_de_Alumnos;
using Entities;
using System.IO;
using Entitites.Negocio.Personas;
using Entities.Usuario;
using Negocio.Gestion_de_Personas.Creator;

namespace DiplomaFinal.Gestion_de_Personas
{
    public partial class frmInscripcion : MetroFramework.Forms.MetroForm
    {
        AlumnoCreator alumnoContructor = new AlumnoCreator();
        Alumno persona = new Alumno();
        Telefono telefono = new Telefono();
        Usuarios usuarios = new Usuarios();
        Familia familia = new Familia();
        Casa casa = new Casa();
        Alergias alergias = new Alergias();
        ObrasSocial obrasSocial = new ObrasSocial();
        List<Documento> listaDocumentacion = new List<Documento>();
        public frmInscripcion()
        {
            InitializeComponent();
        }

        private void frmInscripcion_Load(object sender, EventArgs e)
        {
            tabIncripcion.SelectedIndex = 0;
            RecorridoForm.CambiarIdioma(this);
            txtFechaNaciemiento.MaxDate = DateTime.Now.AddYears(-3);
            txtFechaNaciemiento.MinDate = DateTime.Now.AddYears(-6);
            txtMedicamentosCuales.Visible = false;
            txtAlimentoCuales.Visible = false;
            txtElementosCuales.Visible = false;
            txtCualOS.Visible = false;
            txtTelefonoOS.Visible = false;
            txtSocioOS.Visible = false;
            txtMedicamentosCuales.Text = "";
         
        }

        private bool verificarCampos()
        {

            string error = ValidadoresComponent.VerificarLetras(txtNombre.Text);
            error = error + " " + ValidadoresComponent.VerificarLetras(txtApellido.Text);
            error = error + " " + ValidadoresComponent.VerificarNumerosIntervalo(txtDNI.Text, 52610644, 99999999);
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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (verificarCampos())
            {

                persona.apellido = txtApellido.Text;
                persona.nombre = txtNombre.Text;
                persona.fechaNacimiento = txtFechaNaciemiento.Value.Date;
                persona.direccion = txtDireccion.Text;
                persona.DNI = txtDNI.Text;


                telefono.codigo_Area = int.Parse(txtTelefonoArea.Text);
                telefono.numero = int.Parse(txtTelefono.Text);

                usuarios.UserName= txtEmail.Text;
                usuarios.Email = txtEmail.Text;
                usuarios.Nombre = persona.nombre;
                usuarios.Apellido = persona.apellido;
                usuarios.Password = txtContraseña.Text;
                metroButton2.Visible = true;
                tabIncripcion.SelectedIndex = 1;

            }
        }

        private void metroCheckBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (chMedicamentos.Checked)
            {
                txtMedicamentosCuales.Visible = true;
                txtMedicamentosCuales.Text = "Cuales";
            }
            else
            {
                txtMedicamentosCuales.Visible = false;
                txtMedicamentosCuales.Text = "";
            }
        }

        private void chAlimento_CheckedChanged(object sender, EventArgs e)
        {
            if (chAlimento.Checked)
            {
                txtAlimentoCuales.Visible = true;
                txtAlimentoCuales.Text = "Cuales";

            }
            else
            {
                txtAlimentoCuales.Visible = false;
                txtAlimentoCuales.Text = "";
            }
        }

        private void chElementos_CheckedChanged(object sender, EventArgs e)
        {
            if (chElementos.Checked)
            {
                txtElementosCuales.Visible = true;
                txtElementosCuales.Text = "Cuales";
            }
            else
            {
                txtElementosCuales.Visible = false;
                txtElementosCuales.Text = "";
            }
        }

        public bool validarDatosAdicionales()
        {
            string error = "";
            if (chMedicamentos.Checked)
            {
                error = ValidadoresComponent.VerificarLetras(txtMedicamentosCuales.Text);

            }
            if (chAlimento.Checked)
            {
                error = error + " " + ValidadoresComponent.VerificarLetras(txtAlimentoCuales.Text);
            }
            if (chElementos.Checked)
            {
                error = error + " " + ValidadoresComponent.VerificarLetras(txtElementosCuales.Text);
            }

            if (chObraSocial.Checked)
            {
                error = error + " " + ValidadoresComponent.VerificarLetras(txtCualOS.Text);
                error = error + " " + ValidadoresComponent.VerificarTamaño(txtTelefonoOS.Text, 10, 10);
                error = error + " " + ValidadoresComponent.VerificarNumeros(txtSocioOS.Text);
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
        private void chObraSocial_CheckedChanged(object sender, EventArgs e)
        {
            if (chObraSocial.Checked)
            {
                txtCualOS.Visible = true;
                txtCualOS.Text = "Cual";
                txtTelefonoOS.Visible = true;
                txtTelefonoOS.Text = "Telefono";
                txtSocioOS.Visible = true;
                txtSocioOS.Text = "Numero de socio";

            }
            else
            {
                txtCualOS.Visible = false;
                txtCualOS.Text = "";
                txtTelefonoOS.Visible = false;
                txtTelefonoOS.Text = "";
                txtSocioOS.Visible = false;
                txtSocioOS.Text = "Numero  socio";
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (validarDatosAdicionales())
            {
                //familia
                familia.Padres_Separados = chSeparados.Checked;
                familia.Vive_Abuela = chAbuelo.Checked;
                familia.Tiene_Tios = chTio.Checked;
                familia.Papa_Trabajo = chPapa.Checked;
                familia.Mama_Trabajo = chMama.Checked;
                familia.Hermanos = chHermanos.Checked;

                //casa

                casa.Vive_Barrio_Cerrado = chBarrio.Checked;
                casa.Vive_Casa = chCasa.Checked;
                casa.Vive_Departamento = chDepto.Checked;
                casa.Tiene_Patio = chPatio.Checked;
                casa.Tiene_Habitacion_Propia = chHabitacion.Checked;


                //Alergias
                alergias.Alergia_Alimento = chAlimento.Checked;
                alergias.Cuales_Alergias_Alimento = txtAlimentoCuales.Text;
                alergias.Alergia_Medicamentos = chMedicamentos.Checked;
                alergias.Cuales_Alergias_Elementos = txtMedicamentosCuales.Text;
                alergias.Alergia_Elementos = chElementos.Checked;
                alergias.Cuales_Alergias_Elementos = txtElementosCuales.Text;
                alergias.Otras_Alergias = txtOtrasAlergias.Text;

                //obrasocial

                obrasSocial.tiene_Obra_Social = chObraSocial.Checked;
                obrasSocial.obra_Social = txtCualOS.Text;
                obrasSocial.numero_Socio = txtSocioOS.Text;
                obrasSocial.telefono_Emergencia = txtTelefonoOS.Text;
                metroButton3.Visible = true;
                tabIncripcion.SelectedIndex = 2;

            }
        }
        OpenFileDialog openFileDialogAlumno = new OpenFileDialog();
        OpenFileDialog openFileDialogPadre = new OpenFileDialog();
        OpenFileDialog openFileDialogCertificado = new OpenFileDialog();
        OpenFileDialog openFileDialogVacuna = new OpenFileDialog();

        private void btnAlumnoDNI_Click(object sender, EventArgs e)
        {
            
            openFileDialogAlumno.Filter = "PDF file(*.pdf)|*.pdf";
            if (openFileDialogAlumno.ShowDialog() == DialogResult.OK)
            {
                txtDocumentacionDNIAlumno.Text = openFileDialogAlumno.FileName;
           
            }
          
        }


        private void btnPadreDNI_Click(object sender, EventArgs e)
        {

            
            openFileDialogPadre.Filter = "PDF file(*.pdf)|*.pdf";
            if (openFileDialogPadre.ShowDialog() == DialogResult.OK)
            {
                txtDocumentacionDNIPadre.Text = openFileDialogPadre.FileName;

            }
        }

        private void btnCertificado_Click(object sender, EventArgs e)
        {


            openFileDialogCertificado.Filter = "PDF file(*.pdf)|*.pdf";
            if (openFileDialogCertificado.ShowDialog() == DialogResult.OK)
            {
                txtDocumentacionCertificado.Text = openFileDialogCertificado.FileName;

            }
        }

        private void btnVacunas_Click(object sender, EventArgs e)
        {

           
            openFileDialogVacuna.Filter = "PDF file(*.pdf)|*.pdf";
            if (openFileDialogVacuna.ShowDialog() == DialogResult.OK)
            {
                txtDocumentacionVacunas.Text = openFileDialogVacuna.FileName;

            }
        }

        private bool verificarArchivos()
        {
            string error = "";
            if (txtDocumentacionCertificado.Text == "")
            {
                error = "Falta Dni Alumno. ";
            }
            if (txtDocumentacionDNIPadre.Text=="")
            {
                error = error + "Falta dni de algun padre. ";
            }
            if (txtDocumentacionCertificado.Text=="")
            {
                error = error + "Falta el certifocado. ";
            }
            if (txtDocumentacionVacunas.Text=="")
            {
                error = error + "Falta las vacunas";
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
        
        private void metroButton3_Click(object sender, EventArgs e)
        {
            Documento documentacion1 = new Documento();
            documentacion1.openFileDialog =openFileDialogAlumno;
            documentacion1.NombreDocumento = "DNI Alumno";

            Documento documentacion2 = new Documento();
            documentacion2.openFileDialog = openFileDialogPadre;
            documentacion2.NombreDocumento = "DNI Padre";
            Documento documentacion3 = new Documento();
            documentacion3.openFileDialog = openFileDialogCertificado;
            documentacion3.NombreDocumento = "Certificado Nacimientos";
            Documento documentacion4 = new Documento();
            documentacion4.openFileDialog = openFileDialogVacuna;
            documentacion4.NombreDocumento = "Vacunas";

            listaDocumentacion.Add(documentacion1);
            listaDocumentacion.Add(documentacion2);

            listaDocumentacion.Add(documentacion3);

            listaDocumentacion.Add(documentacion4);
           

            persona.AgregarTelefono( telefono);

       string error=     alumnoContructor.CrearAlumno(persona,usuarios ,listaDocumentacion, alergias, casa,familia, obrasSocial);

            if (error!="")
            {
                MetroMessageBox.Show(this, error, "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RecorridoForm.LimpiarTXT(this);
            }
            else
            {
                ValidadoresComponent.Alta("Incripcion", this);
                RecorridoForm.LimpiarTXT(this);
            }
        }
    }
}

