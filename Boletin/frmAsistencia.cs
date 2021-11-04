using Entities;
using Negocio;
using Negocio.Gestion_de_Salas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using Entitites.Negocio.Salas;
using Entitites.Negocio.Personas;
using Negocio.Gestion_de_Personas;
using Negocio.Servicios.REGEX;

namespace DiplomaFinal.Gestion_Boletin
{
    public partial class frmAsistencia : MetroFramework.Forms.MetroForm
    {
        public int curso { get; set; }
        public frmAsistencia()
        {
            InitializeComponent();
        }

        void llenarCombos()

        {
            int mes = txtMes.SelectedIndex + 3;
            txtDia.Items.Clear();
            if (txtMes.Text=="Marzo" || txtMes.Text == "Mayo" || txtMes.Text == "Julio" || txtMes.Text == "Agosto" || txtMes.Text == "Octubre" || txtMes.Text == "Diciembre")
            {
                for (int i = 0; i < 30; i++)
                {
                    DateTime date = new DateTime(unCurso.salaHorario.año, mes, i + 1);
                    string dia = date.ToString("dddd", CultureInfo.CreateSpecificCulture("es-ES"));
                    if (dia== "sábado" || dia == "domingo")
                    {
                        
                    }
                    else
                    {
                        txtDia.Items.Add(i + 1);
                    }
                   

                    
                }

            }
            else
            {
                for (int i = 0; i < 30; i++)
                {
                    DateTime date = new DateTime(unCurso.salaHorario.año, mes, i + 1);
                    string dia = date.ToString("dddd", CultureInfo.CreateSpecificCulture("es-ES"));
                    if (dia == "sábado" || dia == "domingo")
                    {

                    }
                    else
                    {
                        txtDia.Items.Add(i + 1);
                    }
                }
            }
        
        
        
        
        }

        void llenarGrillaAsistencias()

        {
            mgVer.Rows.Clear();
            int n = 0;
            AsistenciaComponent asistenciaComponent = new AsistenciaComponent();
            List<Asistencia> asistencias = new List<Asistencia>();
            asistencias = asistenciaComponent.ReadByCurso(alumnos, unCurso.salaHorario.año);
            foreach (var item in asistencias)
            {

                n = mgVer.Rows.Add();

               mgVer.Rows[n].Cells[0].Value = item.persona.Id;
               mgVer.Rows[n].Cells[1].Value = item.persona.nombre;
               mgVer.Rows[n].Cells[2].Value = item.persona.apellido;
               mgVer.Rows[n].Cells[3].Value = item.dia;
                mgVer.Rows[n].Cells[4].Value = item.mes;
                mgVer.Rows[n].Cells[5].Value = item.asistio;
                n++;

            }
        
        }

        public Curso unCurso = new Curso();
        private void frmAsistencia_Load(object sender, EventArgs e)
        {
            RecorridoForm.CambiarIdioma(this);
            CursoComponent cursoComponent = new CursoComponent();
            unCurso = cursoComponent.ReadBy(curso);
            AlumnoComponent alumnocomponent = new AlumnoComponent();
          
            alumnos = alumnocomponent.ObtenerAlumnodeCunCurso(curso);
          

            txtAlumno.DataSource = alumnos;
            txtAlumno.ValueMember = "Id";
            txtAlumno.DisplayMember = "nombreCompleto" ;
            llenarGrillaAsistencias();
            llenarCOmboMesVer();
   

        }

        void llenarCOmboMesVer()
        {
            if (mgVer.RowCount!=0)
            {
                AsistenciaComponent asistenciaComponent = new AsistenciaComponent();
                Alumno alumno = new Alumno();
                alumno.Id= int.Parse(mgVer.Rows[0].Cells[0].Value.ToString());
                Asistencia asistencia = new Asistencia(alumno);

  
                asistencia.año = unCurso.salaHorario.año;
                txtMesVer.DataSource = asistenciaComponent.ObtenerMesesConAsistenciaPorCursoAño(asistencia);
            }
            
        
        
        }

        List<Alumno> alumnos = new List<Alumno>();

   
        void llenarGrilla()
        {
           
            mgReserva.Rows.Clear();
            int n = 0;
            foreach (var item in alumnos)
            {
               
                    n = mgReserva.Rows.Add();

                    mgReserva.Rows[n].Cells[0].Value = item.Id;
                    mgReserva.Rows[n].Cells[1].Value = item.nombre;
                    mgReserva.Rows[n].Cells[2].Value = item.apellido;
                    mgReserva.Rows[n].Cells[3].Value = item.DNI;
                   
                
               




            }

        }
        private void txtMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            mgReserva.Rows.Clear();
            if (txtMes.Text!="")
            {
                llenarCombos();
            }
        }

        private void txtDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            mgReserva.Rows.Clear();
            Alumno alumno = new Alumno();
            alumno.Id = alumnos[0].Id;
            Asistencia asistencia = new Asistencia(alumno);
      
            AsistenciaComponent asistenciaComponent = new AsistenciaComponent();
            asistencia.año = unCurso.salaHorario.año;
            asistencia.mes = txtMes.SelectedIndex + 3;
            asistencia.dia = int.Parse(txtDia.Text);
         
            if (asistenciaComponent.verificarSiSeTomoLista(asistencia))
            {
                DateTime date = new DateTime(unCurso.salaHorario.año, txtMes.SelectedIndex + 3, int.Parse(txtDia.Text));
                DateTime hoy = DateTime.Now;
                if (DateTime.Compare(date, DateTime.Now) <= 0)
                {
                    llenarGrilla();
                    btnGuardar.Visible = true;
                }
                else
                {
                    MetroMessageBox.Show(this, "Selecciono una fecha posterior al dia de hoy", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnGuardar.Visible = false;
                }
                

            }
            else
            {
                MetroMessageBox.Show(this, "Ya se tomo asistencia", "error", MessageBoxButtons.OK,MessageBoxIcon.Warning) ;
                btnGuardar.Visible = false;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            int a = 0;
            int n = 0;
            for (int i = 0; i < mgReserva.RowCount; i++)
            {

                Alumno alumno = new Alumno();
                alumno.Id = int.Parse(mgReserva.Rows[n].Cells[0].Value.ToString());
                Asistencia asistencia = new Asistencia(alumno);
                AsistenciaComponent asistenciaComponent = new AsistenciaComponent();
          
                asistencia.dia = int.Parse(txtDia.Text);
                asistencia.mes = txtMes.SelectedIndex + 4;
                asistencia.año = unCurso.salaHorario.año;

                DataGridViewCheckBoxCell ck = mgReserva.Rows[n].Cells[4] as DataGridViewCheckBoxCell;


                asistencia.asistio = Convert.ToBoolean(ck.Value);
                if (asistenciaComponent.Create(asistencia)==null)
                {
                    a = 1;
                    break;
                }
                
                n++;
            }



            btnGuardar.Visible = false;
            
            mgReserva.Rows.Clear();
            llenarGrillaAsistencias();
            llenarCOmboMesVer();

            if (a==1)
            {
                MetroMessageBox.Show(this, "Ya se tomo asistencia", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ValidadoresComponent.Alta("Asistencia", this);
            }
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
           
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            mgVer.Rows.Clear();
            int n = 0;
            AsistenciaComponent asistenciaComponent = new AsistenciaComponent();
            List<Asistencia> asistencias = new List<Asistencia>();
            Alumno alumno = new Alumno();
            alumno.Id= int.Parse(txtAlumno.SelectedValue.ToString());
            Asistencia asistencia = new Asistencia(alumno);
  
            asistencia.año = unCurso.salaHorario.año;
            asistencias = asistenciaComponent.ReadByAlumno(asistencia);
            foreach (var item in asistencias)
            {

                n = mgVer.Rows.Add();

                mgVer.Rows[n].Cells[0].Value = item.Id;
                mgVer.Rows[n].Cells[1].Value = item.persona.nombre;
                mgVer.Rows[n].Cells[2].Value = item.persona.apellido;
                mgVer.Rows[n].Cells[3].Value = item.dia;
                mgVer.Rows[n].Cells[4].Value = item.mes;
                mgVer.Rows[n].Cells[5].Value = item.asistio;
                n++;

            }
        }

        private void txtVerTodoSala_Click(object sender, EventArgs e)
        {
            llenarGrillaAsistencias();
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {

            mgVer.Rows.Clear();
            int n = 0;
            AsistenciaComponent asistenciaComponent = new AsistenciaComponent();
            List<Asistencia> asistencias = new List<Asistencia>();

            Alumno alumno = new Alumno();
            alumno.Id = int.Parse(txtAlumno.SelectedValue.ToString());
            Asistencia asistencia = new Asistencia(alumno);
           
            asistencia.año = unCurso.salaHorario.año;
            asistencias = asistenciaComponent.ReadByCursoMes(alumnos,unCurso.salaHorario.año,txtMesVer.Text);
            foreach (var item in asistencias)
            {

                n = mgVer.Rows.Add();

                mgVer.Rows[n].Cells[0].Value = item.Id;
                mgVer.Rows[n].Cells[1].Value = item.persona.nombre;
                mgVer.Rows[n].Cells[2].Value = item.persona.apellido;
                mgVer.Rows[n].Cells[3].Value = item.dia;
                mgVer.Rows[n].Cells[4].Value = item.mes;
                mgVer.Rows[n].Cells[5].Value = item.asistio;
                n++;

            }
        }
    }
}
