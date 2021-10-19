using Entities;
using Negocio.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomaFinal.Index
{
    public partial class frmAlarmas : MetroFramework.Forms.MetroForm
    {
        public frmAlarmas()
        {
            InitializeComponent();
        }

        private void Alarmas_Load(object sender, EventArgs e)
        {
       
            frmmgListado.Rows.Clear();
            

            BitacoraComponent idiomaComponent = new BitacoraComponent();
            List<Bitacora> bitacoras = new List<Bitacora>();
            bitacoras = idiomaComponent.ReadbyCriticidad("Alta");
            int n = 0;
            foreach (Bitacora item in bitacoras)
            {
                n = frmmgListado.Rows.Add();
                frmmgListado.Rows[n].Cells[0].Value = item.Id;
                frmmgListado.Rows[n].Cells[1].Value = item.eventoBitacora.Id;
                frmmgListado.Rows[n].Cells[2].Value = item.usuarios.UserName;
                frmmgListado.Rows[n].Cells[3].Value = item.eventoBitacora.eventoBitacora;

                frmmgListado.Rows[n].Cells[4].Value = item.fecha;
                frmmgListado.Rows[n].Cells[5].Value = item.hora;
                n++;
            }
        }
    }
}
