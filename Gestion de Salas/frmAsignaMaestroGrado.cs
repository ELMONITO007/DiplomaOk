using Entities;
using Entitites.Negocio.Personas;
using Entitites.Negocio.Salas;
using Negocio;
using Negocio.Gestion_de_Alumnos;
using Negocio.Gestion_de_Personas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomaFinal.Gesion_de_Salas
{
    public partial class frmAsignaMaestroGrado : MetroFramework.Forms.MetroForm
    {
        public int curso { get; set; }
        public frmAsignaMaestroGrado()
        {
            InitializeComponent();
        }

        void llenarGrilla()

        {
            MaestroHorarioComponent maestroHorarioComponent = new MaestroHorarioComponent();
            CursoComponent cursoComponent = new CursoComponent();
            Curso unCurso = new Curso();
            unCurso = cursoComponent.ReadBy(curso);
            MaestroHorario maestroHorario = new MaestroHorario();
            maestroHorario.año = unCurso.salaHorario.año;
            maestroHorario.turno = unCurso.salaHorario.turno;
            if (txtEspecialidad.ValueMember!="")
            {
                int especilidad = int.Parse(txtEspecialidad.SelectedValue.ToString());

                mgReserva.Rows.Clear();
                int n = 0;
                foreach (var item in maestroHorarioComponent.DisponibilidadEspecialidad(especilidad, maestroHorario.año, maestroHorario.turno))
                {
                    n = mgReserva.Rows.Add();

                    mgReserva.Rows[n].Cells[0].Value = item.persona.Id;
                    mgReserva.Rows[n].Cells[1].Value = item.persona.nombre;
                    mgReserva.Rows[n].Cells[2].Value = item.persona.apellido;
                    mgReserva.Rows[n].Cells[3].Value = item.persona.DNI;
                    string f = item.persona.fechaNacimiento.ToString().Substring(0, 10);
                    mgReserva.Rows[n].Cells[4].Value = f;
                    mgReserva.Rows[n].Cells[5].Value = item.Id;
                    mgReserva.Rows[n].Cells[6].Value = item.hora;
                    mgReserva.Rows[n].Cells[7].Value = item.diaSemana;
                    n++;
                }

           


            }
        }

        private void frmAsignaMaestroGrado_Load(object sender, EventArgs e)
        {
            RecorridoForm.CambiarIdioma(this);
            llenarCombo(); 
        }

        void llenarCombo()

        {

            EspecialidadComponent  cursoHorarioComponent = new EspecialidadComponent();
            txtEspecialidad.DataSource = cursoHorarioComponent.EspecialidadesDisponibles(curso);
            txtEspecialidad.DisplayMember = "Especialidad";
            txtEspecialidad.ValueMember = "Id";
            txtEspecialidad.SelectedIndex = 0;
        
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (mgReserva.CurrentRow.Cells[0].Value == null)
            {

            }
            else
            {
                CursoComponent  cursoAlumnoComponent = new CursoComponent();
                Alumno alumno = new Alumno();
                alumno.Id = int.Parse(mgReserva.CurrentRow.Cells[0].Value.ToString());
                List<Alumno> listaAlumno = new List<Alumno>();
                listaAlumno.Add(alumno);
                Curso cursoAlumno = new Curso(null,null,null,listaAlumno,null);
                cursoAlumno.Id = curso;

                cursoAlumnoComponent.AsignarAlumno(cursoAlumno);
                this.Close();
                llenarGrilla();
            }
        }

        private void txtEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarGrilla();
        }
    }
}
