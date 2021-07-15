using Entities.Servicios;
using Entities.Usuario;
using Entitites.Servicios.Login;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio.Servicios
{
    public partial class frmBackup : MetroFramework.Forms.MetroForm
    {
        public frmBackup()
        {
            InitializeComponent();
        }

        private void frmBackup_Load(object sender, EventArgs e)
        {
            llenarGrilla();
        }
        void llenarGrilla()
        {
            try
            {
                MGbackup.Rows.Clear();
                BackupComponent backupComponent = new BackupComponent();
                List<Backups> backups = new List<Backups>();
                backups = backupComponent.Read();
                int n = 0;
                foreach (Backups item in backups)
                {
                    n = MGbackup.Rows.Add();
                    MGbackup.Rows[n].Cells[0].Value = item.Nombre;
                    MGbackup.Rows[n].Cells[1].Value = item.Fecha;
                    MGbackup.Rows[n].Cells[2].Value = item.Nombre;
                    MGbackup.Rows[n].Cells[3].Value = item.Id;

                    n++;
                }
            }
            catch (Exception error)
            {

                MetroMessageBox.Show(this, error.Message, "Error al cargar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnCrearBk_Click(object sender, EventArgs e)
        {
            try
            {
                BackupComponent backupComponent = new BackupComponent();
                backupComponent.VerificarSiexistePath();
                Usuarios usuarios = new Usuarios();
                usuarios = SessionManager.instance.GetUSuario();



                backupComponent.Create(usuarios.Id);
                MetroMessageBox.Show(this, "Se creo un nuevo Backup", "Nuevo Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                llenarGrilla();

            }
            catch (Exception error)
            {
                MetroMessageBox.Show(this, error.Message, "Error al crear Backup", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            try
            {
                // TODO: Add update logic here
               

               
                BackupComponent backupComponent = new BackupComponent();

                Usuarios user = new Usuarios();
                user = SessionManager.instance.GetUSuario();
                Backups backups = new Backups(user);
                backups.Id = int.Parse(MGbackup.CurrentRow.Cells[3].Value.ToString());
             
                backupComponent.RestoreDatabase(backups);
                MetroMessageBox.Show(this, "Se restauro el Backup " + MGbackup.CurrentRow.Cells[0].Value.ToString(), "Reaturar Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MetroMessageBox.Show(this, error.Message, "Error al restaurar Backup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MGbackup.CurrentRow.Cells[3].Value == null)
            {
                MetroMessageBox.Show(this, "No selecciono un Backup", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialogResult = MetroMessageBox.Show(this, "¿Desea eliminar el backup?", "Backup", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    BackupComponent backupComponent = new BackupComponent();
                    backupComponent.Delete(int.Parse(MGbackup.CurrentRow.Cells[3].Value.ToString()));
                    llenarGrilla();
                }
            }
        }

        private void btnCosistencia_Click(object sender, EventArgs e)
        {
            LoginComponent loginComponent = new LoginComponent();
            if (loginComponent.VerificarDVV())
            {
                MetroMessageBox.Show(this, "La consistencia de la base de datos es correcta", "Consistencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dialogResult = MetroMessageBox.Show(this, "La consistencia de la base de datos no es correcta, desea restaurar la base", "Consistencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    BackupComponent backupComponent = new BackupComponent();
                    backupComponent.RestaurarBase();
                }
            }
        }
    }
}
