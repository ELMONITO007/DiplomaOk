using DiplomaFinal.Gestion_de_Personas;
using Entitites.Negocio.Personas;
using System;

namespace DiplomaFinal.VistaAlumno
{
    public partial class frmDatosPersonales : MetroFramework.Forms.MetroForm
    {
        public Alumno persona = new Alumno();
        public frmDatosPersonales()
        {
            InitializeComponent();
        }

        private void frmDatosPersonales_Load(object sender, EventArgs e)
        {
            RecorridoForm.CambiarIdioma(this);

       
            txtApellido.Text = persona.apellido;
            txtDireccion.Text = persona.direccion;
            txtDNI.Text = persona.DNI;
            txtFechaNaciemiento.Text = persona.fechaNacimiento.ToString("dd-MM-yyyy");
            txtNombre.Text = persona.nombre;
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            frmFamilia frmFamilia = new frmFamilia();
            frmFamilia.id_Alumno = persona.Id;
           
            frmFamilia.ShowDialog();
        }
    }
}
