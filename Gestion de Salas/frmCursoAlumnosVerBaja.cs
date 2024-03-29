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

namespace DiplomaFinal.Gesion_de_Salas
{
    public partial class frmCursoAlumnosVerBaja : MetroFramework.Forms.MetroForm
    {
        Curso unCurso = new Curso();
        public int curso { get; set; }
        public frmCursoAlumnosVerBaja()
        {
            InitializeComponent();
        }
        void llenarGrillaAlumno()

        {
          
  
         
            mgReserva.Rows.Clear();
            int n = 0;
            foreach (var item in  unCurso.listaALumno)
            {
                n = mgReserva.Rows.Add();

                mgReserva.Rows[n].Cells[0].Value = item.Id;
                mgReserva.Rows[n].Cells[1].Value = item.nombre;
                mgReserva.Rows[n].Cells[2].Value = item.apellido;
                mgReserva.Rows[n].Cells[3].Value = item.DNI;
                string f = item.fechaNacimiento.ToString().Substring(0, 10);
                mgReserva.Rows[n].Cells[4].Value = f;
                mgReserva.Rows[n].Cells[5].Value = item.Id;


            }


        }
        void llenarGrillaMaestro()

        {



            mgMaestro.Rows.Clear();
            int n = 0;
            foreach (var item in unCurso.listaMaestro)
            {
                n = mgMaestro.Rows.Add();

                mgMaestro.Rows[n].Cells[0].Value = item.Id;
                mgMaestro.Rows[n].Cells[1].Value = item.nombre;
                mgMaestro.Rows[n].Cells[2].Value = item.apellido;
                mgMaestro.Rows[n].Cells[3].Value = item.DNI;
                string f = item.fechaNacimiento.ToString().Substring(0, 10);
                mgMaestro.Rows[n].Cells[4].Value = f;
                mgMaestro.Rows[n].Cells[4].Value = item.Id;


            }


        }
      public  int b = 0;
        private void frmCursoAlumnosVerBaja_Load(object sender, EventArgs e)
        {
            if (b==1)
            {
                metroButton1.Visible = false;
            }
            CursoComponent cursoComponent = new CursoComponent();
            unCurso = cursoComponent.ReadBy(curso);
            this.Text = " Alumnos y Maestros de la sala " + unCurso.nombre + " Del año " + unCurso.salaHorario.año + " Turno " + unCurso.salaHorario.turno;
            llenarGrillaAlumno();
            llenarGrillaMaestro();
            RecorridoForm.CambiarIdioma(this);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (mgReserva.CurrentRow.Cells[0].Value==null)
            {
                MetroMessageBox.Show(this, "seleccione un alumno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CursoComponent cursoComponent = new CursoComponent();
                cursoComponent.QuitarAlumnoSala(unCurso.Id, int.Parse(mgReserva.CurrentRow.Cells[0].Value.ToString()));

      
                unCurso = cursoComponent.ReadBy(curso);
                llenarGrillaAlumno();
            }
        }
    }
}
