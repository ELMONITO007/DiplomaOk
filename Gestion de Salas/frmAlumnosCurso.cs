﻿using Entities;
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
using Entitites.Negocio.Personas;

namespace DiplomaFinal.Gesion_de_Salas
{
    public partial class frmAlumnosCurso : MetroFramework.Forms.MetroForm
    {

        public int curso { get; set; }
        public int año { get; set; }
        public frmAlumnosCurso()
        {
            InitializeComponent();
        }

        void llenarGrillaReservas()

        {
            CursoComponent cursoComponent = new CursoComponent();

            mgReserva.Rows.Clear();
            int n = 0;
            foreach (var item in cursoComponent.ObtenerAlumnosDisponibles(curso,año))
            {
                n = mgReserva.Rows.Add();

                mgReserva.Rows[n].Cells[0].Value = item.Id;
                mgReserva.Rows[n].Cells[1].Value = item.nombre;
                mgReserva.Rows[n].Cells[2].Value = item.apellido;
                mgReserva.Rows[n].Cells[3].Value = item.DNI;
                string f = item.fechaNacimiento.ToString("dd-MM-yyyy");
                mgReserva.Rows[n].Cells[4].Value = f;
              


            }


        }
        private void frmAlumnosCurso_Load(object sender, EventArgs e)
        {
            RecorridoForm.CambiarIdioma(this);
            llenarGrillaReservas();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (mgReserva.CurrentRow.Cells[0].Value==null)
            {

            }
            else
            {
                CursoComponent cursoComponent = new CursoComponent();
               List< Alumno> listaALumno = new List<Alumno>();
                Alumno alumno = new Alumno();

                alumno.Id = int.Parse(mgReserva.CurrentRow.Cells[0].Value.ToString());
                listaALumno.Add(alumno);
                Curso unCurso = new Curso(null,null,null,listaALumno,null);
                unCurso.Id = curso;
              
                
        
                cursoComponent.AsignarAlumno(unCurso);
                llenarGrillaReservas();
            }
        }

        private void mgReserva_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
