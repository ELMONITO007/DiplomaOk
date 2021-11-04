using Entities.Servicios;
using MetroFramework;
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

namespace DiplomaFinal.Servicio
{
    public partial class fmrRestauraciones : MetroFramework.Forms.MetroForm
    {
        public fmrRestauraciones()
        {
            InitializeComponent();
        }
        void llenarGrilla()


        {

            try
            {
                MGbackup.Rows.Clear();
                BackupComponent backupComponent = new BackupComponent();
                List<Backups> backups = new List<Backups>();
                backups = backupComponent.MostrarJson();
                int n = 0;
                foreach (Backups item in backups)
                {
                    n = MGbackup.Rows.Add();
                    MGbackup.Rows[n].Cells[0].Value = item.Nombre;
                    MGbackup.Rows[n].Cells[1].Value = item.FechaRestauracion;
                    MGbackup.Rows[n].Cells[2].Value = item.Nombre;
                    MGbackup.Rows[n].Cells[3].Value = item.Id;
                    MGbackup.Rows[n].Cells[4].Value = item.usuarios.Email;
                    MGbackup.Rows[n].Cells[5].Value = item.Fecha;
                    n++;
                }
            }
            catch (Exception error)
            {

                MetroMessageBox.Show(this, error.Message, "Error al cargar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            llenarGrilla();
        }
    }
}
