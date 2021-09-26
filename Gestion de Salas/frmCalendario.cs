using Entities;
using Entitites;
using Negocio;
using Negocio.Gestion_de_Alumnos;
using Negocio.Gestion_de_Personas;
using Negocio.Gestion_de_Salas;
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
    public partial class frmCalendario : MetroFramework.Forms.MetroForm
    {
        public int curso { get; set; }
        public frmCalendario()
        {
            InitializeComponent();
        }

        void llenargrilla()
        {
            CursoHorarioComponent cursoHorario = new CursoHorarioComponent();
            int n = 0;

            List<MaestroHorario> maestroHorarios = new List<MaestroHorario>();
            int legajo = 0;
            foreach (var item in cursoHorario.ReadByCurso(curso))
            {
                maestroHorarios.Add(item.maestroHorario);
            }

            for (int i = 0; i < 5; i++)
            {
                n = mgCalendario.Rows.Add();
                mgCalendario.Rows[n].Cells[0].Value = i + 1;
                string maestro = "";

                foreach (var item in maestroHorarios)
                {
                    if (item.hora == 0)
                    {
                        maestro = item.persona.nombre + " " + item.persona.apellido + Environment.NewLine + "Clase";

                    }
                    if (true)
                    {

                    }
                }

                mgCalendario.Rows[n].Cells[1].Value = maestro;
                mgCalendario.Rows[n].Cells[2].Value = maestro;
                mgCalendario.Rows[n].Cells[3].Value = maestro;
                mgCalendario.Rows[n].Cells[4].Value = maestro;
                mgCalendario.Rows[n].Cells[5].Value = maestro;
            }



            foreach (var item in maestroHorarios)
            {
                string maestro = "";
                if (item.hora != 0)
                {

                    EspecialidadComponent especialidadPersona = new EspecialidadComponent();
                    foreach (var ep in especialidadPersona.ReadByPersona(item.persona.Id))
                    {
                        maestro = item.persona.nombre + " " + item.persona.apellido + Environment.NewLine + ep.especialidad;
                        break;
                    }


                    mgCalendario.Rows[item.hora - 1].Cells[item.diaSemana].Value = maestro;
                }
            }

        }
        private void frmCalendario_Load(object sender, EventArgs e)
        {
            RecorridoForm.CambiarIdioma(this); llenargrilla();
        }
    }
}
