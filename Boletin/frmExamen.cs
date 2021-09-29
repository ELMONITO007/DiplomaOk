using Negocio.Gestion_de_boletin;
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
using Entities;
using Negocio.Gestion_de_Personas;
using Negocio.Gestion_de_Salas;
using Negocio;
using Entitites.Negocio.Salas;
using Negocio.Gestion_de_Alumnos;
using Entitites;

namespace DiplomaFinal.Gestion_Boletin
{
    public partial class frmExamen : MetroFramework.Forms.MetroForm
    {
        public frmExamen()
        {
            InitializeComponent();
        }

        private void llenarGrillaMateria()

        {
            int n = 0;
            mgMateria.Rows.Clear();
            MateriaComponent materiaComponent = new MateriaComponent();
            foreach (var item in materiaComponent.Read())
            {
                n = mgMateria.Rows.Add();
                mgMateria.Rows[n].Cells[0].Value = item.Id;
                mgMateria.Rows[n].Cells[1].Value = item.materia;
                mgMateria.Rows[n].Cells[2].Value = item.especialidad.especialidad;
            }


        }

        void llenarComboMaestra()


        {
            if (txtCurso.Text != "")
            {
                //CursoAlumnoComponent cursoAlumnoComponent = new CursoAlumnoComponent();

                //CursoAlumno listaPersona = new CursoAlumno();


                //Curso persona = new Curso();
                //persona = (Curso)txtCurso.SelectedItem;

                //listaPersona = cursoAlumnoComponent.ObtenerALumnoYProfesDeUnCurso(persona.Id);
            //    txtMaestra.DataSource = listaPersona.Profesores;
            //    txtMaestra.DisplayMember = "nombreCompleto";
            //    txtMaestra.ValueMember = "Id";
            }



        }
        private void llenarGrillaAlumno()

        {
            if (txtCurso.Text != "")
            {
                mgReserva.Rows.Clear();
                //CursoAlumnoComponent cursoAlumnoComponent = new CursoAlumnoComponent();

                //CursoAlumno listaPersona = new CursoAlumno();

                Curso persona = new Curso();
                persona = (Curso)txtCurso.SelectedItem;
                //listaPersona = cursoAlumnoComponent.ObtenerALumnoYProfesDeUnCurso(persona.Id);
                //txtMaestra.DataSource = listaPersona.Profesores;
                //txtMaestra.DisplayMember = "nombreCompleto";
                //txtMaestra.ValueMember = "Id";
                //int n = 0;
                //foreach (var item in listaPersona.Alumnos)
                //{
                //    n = mgReserva.Rows.Add();
                //    mgReserva.Rows[n].Cells[0].Value = item.Id;
                //    mgReserva.Rows[n].Cells[1].Value = item.nombre;
                //    mgReserva.Rows[n].Cells[2].Value = item.apellido;

                //    mgReserva.Rows[n].Cells[3].Value = item.DNI;
                //    mgReserva.Rows[n].Cells[4].Value = item.fechaNacimiento;
                //    n++;
                //}
            }
        }


        private void frmExamen_Load(object sender, EventArgs e)
        {
            RecorridoForm.CambiarIdioma(this);


            llenarGrillaMateria();
            CursoComponent cursoComponent = new CursoComponent();
            txtCurso.DataSource = cursoComponent.ReadByAño(DateTime.Now.Year);
            txtCurso.DisplayMember = "nombre";
            txtCurso.ValueMember = "Id";
            EspecialidadComponent especialidadComponent = new EspecialidadComponent();
            txtEspecialidad.DataSource = especialidadComponent.Read();
            txtEspecialidad.ValueMember = "Id";
            txtEspecialidad.DisplayMember = "especialidad";
            int año = DateTime.Now.Year;

            DateTime min = new DateTime(año, 3, 1);
            txtFecha.MinDate = min;
            txtFecha.MaxDate = DateTime.Now;
            SalaHorarioComponent salaHorario = new SalaHorarioComponent();
            txtAño.DataSource = salaHorario.SoloAño();
            txtAño.DisplayMember = "Año";

        }

        bool verificarCampoMateria()

        {
            string error = ValidadoresComponent.VerificarLetras(txtMateria.Text);

            if (error.Length > 5)
            {
                MetroMessageBox.Show(this, error, "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }


        }

        private void btnAltaMateria_Click(object sender, EventArgs e)
        {
            if (verificarCampoMateria())
            {
                MateriaComponent materiaComponent = new MateriaComponent();
                Materia materia = new Materia();
                materia.materia = txtMateria.Text;
                Especialidad especialidad = new Especialidad();

                materia.especialidad.Id = (int)txtEspecialidad.SelectedValue;

                if (materiaComponent.Create(materia) == null)
                {
                    ValidadoresComponent.ErrorAltaModificacado("Materia", this);
                }
                else
                {
                    ValidadoresComponent.Alta("Materia", this);
                    txtMateria.Text = "";
                    llenarGrillaMateria();
                }

            }

        }

        private void btnEliminarMateria_Click(object sender, EventArgs e)
        {
            if (verificarCampoMateria())
            {
                MateriaComponent materiaComponent = new MateriaComponent();

                materiaComponent.Delete(int.Parse(mgMateria.CurrentRow.Cells[0].Value.ToString()));
                llenarGrillaMateria();
                txtMateria.Text = "";
            }
        }

        private void nbtnModificarMateria_Click(object sender, EventArgs e)
        {
            if (verificarCampoMateria())
            {
                MateriaComponent materiaComponent = new MateriaComponent();
                Materia materia = new Materia();
                materia.materia = txtMateria.Text;
                materia.Id = int.Parse(mgMateria.CurrentRow.Cells[0].Value.ToString());
                materiaComponent.Update(materia);
                llenarGrillaMateria();
                txtMateria.Text = "";

            }
        }

        private void mgMateria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMateria.Text = mgMateria.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnBuscarMateria_Click(object sender, EventArgs e)
        {
            if (txtBuscarMateria.Text == "")
            {
                MetroMessageBox.Show(this, "Campo buscar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int n = 0;
                mgMateria.Rows.Clear();
                MateriaComponent especialidadComponent = new MateriaComponent();
                foreach (var item in especialidadComponent.buscar(txtBuscarMateria.Text))
                {
                    n = mgMateria.Rows.Add();
                    mgMateria.Rows[n].Cells[0].Value = item.Id;
                    mgMateria.Rows[n].Cells[1].Value = item.materia;
                }
            }
        }

        private void txtCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarComboMaestra();
            llenarGrillaAlumno();

        }


        private void txtMaestra_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtMaestra.Items.Count != 0)
            {
                MateriaComponent materiaComponent = new MateriaComponent();
                string id = txtMaestra.Text;
                Maestro persona = new Maestro();
                persona = (Maestro)txtMaestra.SelectedItem;



                txtMateriaAlta.DataSource = materiaComponent.ReadByEspecialidad(persona.Id);
                txtMateriaAlta.ValueMember = "Id";
                txtMateriaAlta.DisplayMember = "materia";
            }

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (txtNota.Text == "")
            {
                MetroMessageBox.Show(this, "Campo nota vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Examen examen = new Examen();
                examen.persona.Id = int.Parse(mgReserva.CurrentRow.Cells[0].Value.ToString());
                examen.nota = int.Parse(txtNota.Text);

                Materia materia = new Materia();
                materia = (Materia)txtMateriaAlta.SelectedItem;
                examen.materia = materia;
                examen.fecha = txtFecha.Value;
                ExamenComponent examenComponent = new ExamenComponent();
                examenComponent.Create(examen);
               
            }
        }

        private void txtAño_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtAño.Text == "")
            {
                MetroMessageBox.Show(this, "No hay años que mostrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                mgExamenes.Rows.Clear();  
                txtCursoListado.DataSource=null;
                CursoComponent cursoComponent = new CursoComponent();
                txtCursoListado.DataSource = cursoComponent.ReadByAño(int.Parse(txtAño.Text));
                txtCursoListado.DisplayMember = "nombre";
                txtCursoListado.ValueMember = "Id";
                





            }



        }

        private void mgAlumnoListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ExamenComponent examenComponent = new ExamenComponent();
            Examen examen = new Examen();
            DateTime fi = new DateTime(int.Parse(txtAño.Text), 1, 31);
            DateTime ff = new DateTime(int.Parse(txtAño.Text), 12, 1);
            examen.persona.Id =int.Parse (mgAlumnoListado.CurrentRow.Cells[0].Value.ToString());
            int n = 0;
            mgExamenes.Rows.Clear();
            foreach (var item in examenComponent.ReadByAlumnoYAño(examen,fi,ff))
            {
                n = mgExamenes.Rows.Add();
                mgExamenes.Rows[n].Cells[0].Value = item.Id;
                string fecha = item.fecha.ToString("dd-MM-yyyy");
                mgExamenes.Rows[n].Cells[1].Value = fecha;
                mgExamenes.Rows[n].Cells[2].Value = item.nota;

                mgExamenes.Rows[n].Cells[3].Value = item.materia.materia;
               
                n++;
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            ExamenComponent examenComponent = new ExamenComponent();
            Examen examen = new Examen();
            Curso curso = new Curso();
            curso = (Curso)txtCursoListado.SelectedItem;
                      int n = 0;
            mgExamenes.Rows.Clear();
            foreach (var item in examenComponent.ReadByCurso(curso.Id))
            {
                n = mgExamenes.Rows.Add();
                mgExamenes.Rows[n].Cells[0].Value = item.Id;
                string fecha = item.fecha.ToString("dd-MM-yyyy");
                mgExamenes.Rows[n].Cells[1].Value = fecha;
                mgExamenes.Rows[n].Cells[2].Value = item.nota;

                mgExamenes.Rows[n].Cells[3].Value = item.materia.materia;

                n++;
            }
        }

        private void txtCursoListado_SelectedIndexChanged(object sender, EventArgs e)
        {
            mgExamenes.Rows.Clear();
            if (txtAño.Text != "")
            {
                mgAlumnoListado.Rows.Clear();
                //CursoAlumnoComponent cursoAlumnoComponent = new CursoAlumnoComponent();

                //CursoAlumno listaPersona = new CursoAlumno();
                //Curso curso = new Curso();
                //curso = (Curso)txtCursoListado.SelectedItem;
                //listaPersona = cursoAlumnoComponent.ObtenerALumnoYProfesDeUnCurso(curso.Id);
                //int n = 0;
                //foreach (var item in listaPersona.Alumnos)
                //{
                //    n = mgAlumnoListado.Rows.Add();
                //    mgAlumnoListado.Rows[n].Cells[0].Value = item.Id;
                //    mgAlumnoListado.Rows[n].Cells[1].Value = item.nombre;
                //    mgAlumnoListado.Rows[n].Cells[2].Value = item.apellido;

                //    mgAlumnoListado.Rows[n].Cells[3].Value = item.DNI;
                //    mgAlumnoListado.Rows[n].Cells[4].Value = item.fechaNacimiento;
                //    n++;
                //}

            }

        }

        private void txtMateriaAlta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
