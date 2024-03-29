﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using Entitites;
using MetroFramework;
using Negocio;
using Negocio.Servicios;
using Negocio.Servicios.REGEX;

namespace DiplomaFinal.Servicio
{
    public partial class frmBitacora : MetroFramework.Forms.MetroForm
    {
        public frmBitacora()
        {
            InitializeComponent();
        }
        private void llenarGrilla()
        {
            mgListado.Rows.Clear();
            BitacoraComponent idiomaComponent = new BitacoraComponent();
            List<Bitacora> idiomas = new List<Bitacora>();
            idiomas = idiomaComponent.Read();
            int n = 0;
            foreach (Bitacora item in idiomas)
            {
                n = mgListado.Rows.Add();
                mgListado.Rows[n].Cells[0].Value = item.Id;
                mgListado.Rows[n].Cells[1].Value = item.eventoBitacora.Id;
                mgListado.Rows[n].Cells[2].Value = item.usuarios.UserName;
                mgListado.Rows[n].Cells[3].Value = item.eventoBitacora.eventoBitacora;


                DateTime dt = new DateTime();
                dt = DateTime.Parse(item.fecha);
       

                mgListado.Rows[n].Cells[4].Value = dt.ToString("d",new CultureInfo(SingletonIdioma.intance.getUsuario().codigo));
               
                mgListado.Rows[n].Cells[5].Value = item.hora;
                n++;
            }
        }

        private void frmBitacora_Load(object sender, EventArgs e)
        {
            string date = "01.05.2015 12:12:34";
            var dutchCulture = CultureInfo.CreateSpecificCulture("nl-NL");
            var date1 = DateTime.ParseExact(date, "dd.MM.yyyy HH:mm:ss", dutchCulture);
            dtDesde.MaxDate = DateTime.Now;
            dtDesde.MinDate = DateTime.Now.AddYears(-2) ;
            dtHasta.MaxDate = DateTime.Now;

            Obsever.AgregarForm(this);
            llenarGrilla();
        }

        private void mgListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
                mgListado.Rows.Clear();
            string desde = dtDesde.Value.ToString("dd-MMM-yyyy");
            string hasta = dtHasta.Value.ToString("dd-MMM-yyyy");

            BitacoraComponent idiomaComponent = new BitacoraComponent();
                List<Bitacora> bitacoras = new List<Bitacora>();
                bitacoras = idiomaComponent.ReadbyFecha(desde, hasta);
                int n = 0;
                foreach (Bitacora item in bitacoras)
                {
                    n = mgListado.Rows.Add();
                    mgListado.Rows[n].Cells[0].Value = item.Id;
                    mgListado.Rows[n].Cells[1].Value = item.eventoBitacora.Id;
                    mgListado.Rows[n].Cells[2].Value = item.usuarios.UserName;
                    mgListado.Rows[n].Cells[3].Value = item.eventoBitacora.eventoBitacora;

                    mgListado.Rows[n].Cells[4].Value = item.fecha;
                    mgListado.Rows[n].Cells[5].Value = item.hora;
                    n++;
                }
            
        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
            mgListado.Rows.Clear();
            llenarGrilla();
        }

     

        private void txtBuscar_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                mgListado.Rows.Clear();
                llenarGrilla();
            }
            else
            {
                mgListado.Rows.Clear();
                BitacoraComponent idiomaComponent = new BitacoraComponent();
                List<Bitacora> bitacoras = new List<Bitacora>();
                bitacoras = idiomaComponent.Buscar(txtBuscar.Text);
                int n = 0;
                foreach (Bitacora item in bitacoras)
                {
                    n = mgListado.Rows.Add();
                    mgListado.Rows[n].Cells[0].Value = item.Id;
                    mgListado.Rows[n].Cells[1].Value = item.eventoBitacora.Id;
                    mgListado.Rows[n].Cells[2].Value = item.usuarios.UserName;
                    mgListado.Rows[n].Cells[3].Value = item.eventoBitacora.eventoBitacora;

                    mgListado.Rows[n].Cells[4].Value = item.fecha;
                    mgListado.Rows[n].Cells[5].Value = item.hora;
                    n++;
                }
            }
        }

        private void dtDesde_ValueChanged(object sender, EventArgs e)
        {
            dtHasta.MinDate = dtDesde.Value;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            mgListado.Rows.Clear();
            string desde = dtDesde.Value.ToString("dd-MMM-yyyy");
            string hasta = dtHasta.Value.ToString("dd-MMM-yyyy");

            BitacoraComponent idiomaComponent = new BitacoraComponent();
            List<Bitacora> bitacoras = new List<Bitacora>();
            bitacoras = idiomaComponent.ReadbyCriticidad(txtCriticidad.Text);
            int n = 0;
            foreach (Bitacora item in bitacoras)
            {
                n = mgListado.Rows.Add();
                mgListado.Rows[n].Cells[0].Value = item.Id;
                mgListado.Rows[n].Cells[1].Value = item.eventoBitacora.Id;
                mgListado.Rows[n].Cells[2].Value = item.usuarios.UserName;
                mgListado.Rows[n].Cells[3].Value = item.eventoBitacora.eventoBitacora;

                mgListado.Rows[n].Cells[4].Value = item.fecha;
                mgListado.Rows[n].Cells[5].Value = item.hora;
                n++;
            }
        }
    }
}
