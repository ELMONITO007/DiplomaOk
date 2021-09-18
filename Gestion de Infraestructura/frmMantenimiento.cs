using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using Entities.Usuario;
using Entitites.Negocio.Personas;
using Entitites.Servicios.Login;
using MetroFramework;
using Negocio;
using Negocio.Gestion_de_Infraestructura;
using Negocio.Gestion_de_Personas;
using Negocio.Servicios.REGEX;

namespace DiplomaFinal.Gestion_de_Infraestructura
{
    public partial class frmMantenimiento : MetroFramework.Forms.MetroForm
    {
        public frmMantenimiento()
        {
            InitializeComponent();
        }

        private void frmMantenimiento_Load(object sender, EventArgs e)
        {
            RecorridoForm.CambiarIdioma(this);
            llenarGrillaMantenimiento();
            ProveedorComponenent    tipoProveedorComponent = new ProveedorComponenent();
            txtTipoProvv.DataSource = tipoProveedorComponent.Read();
            txtTipoProvv.ValueMember = "Id";
            txtTipoProvv.DisplayMember = "tipoProveedor";
            llenarGrillaTipoM();
        
            txtFecha.MinDate = DateTime.Now;
        }
        void llenarGrillaTipoM()
        {
            GestionMantenimientoComponent tipoProveedorComponent = new GestionMantenimientoComponent();
            int n = 0;
            mgTipoProveedor.Rows.Clear();
            foreach (var item in tipoProveedorComponent.Read())
            {
                n = mgTipoProveedor.Rows.Add();
                mgTipoProveedor.Rows[n].Cells[0].Value = item.Id;
                mgTipoProveedor.Rows[n].Cells[1].Value = item.tipoMantenimiento;
                mgTipoProveedor.Rows[n].Cells[2].Value = item.proveedor.tipoProveedor;
                mgTipoProveedor.Rows[n].Cells[3].Value = item.periocidad;
                n++;

            }
            txtTipo.DataSource = tipoProveedorComponent.Read();
            txtTipo.DisplayMember = "tipoMantenimiento";
            txtTipo.ValueMember = "Id";

        }
        bool verificarCamposTipo()

        {

            string error = "";


            error = error + Environment.NewLine + ValidadoresComponent.VerificarLetras(txtTipoProveedor.Text);




            if (error.Length >= 5)
            {

                MetroMessageBox.Show(this, error, "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {

                return true;
            }
        }
        private void metroButton4_Click(object sender, EventArgs e)
        {
            if (verificarCamposTipo())
            {
                Proveedor proveedor = new Proveedor();
                proveedor.tipoProveedor = txtTipoProvv.Text;
                GestionMantenimiento tipoMantenimiento = new GestionMantenimiento(proveedor);
                tipoMantenimiento.tipoMantenimiento = txtTipoProveedor.Text;
                tipoMantenimiento.periocidad = int.Parse(txtPeriocidad.Text);
                GestionMantenimientoComponent tipoMantenimientoComponenet = new GestionMantenimientoComponent();
                if (tipoMantenimientoComponenet.Create(tipoMantenimiento) == null)
                {
                    ValidadoresComponent.ErrorAltaModificacado("Tipo mantenimiento", this);
                }
                else
                {
                    ValidadoresComponent.Alta("Tipo mantenimiento", this);
                    llenarGrillaTipoM();
                }
            }
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            if (verificarCamposTipo())
            {
                Proveedor proveedor = new Proveedor();
                proveedor.tipoProveedor = txtTipoProvv.Text;
                GestionMantenimiento tipoMantenimiento = new GestionMantenimiento(proveedor);
                tipoMantenimiento.tipoMantenimiento = txtTipoProveedor.Text;
                tipoMantenimiento.periocidad = int.Parse(txtPeriocidad.Text);
                tipoMantenimiento.Id = int.Parse(mgTipoProveedor.CurrentRow.Cells[0].Value.ToString());
                GestionMantenimientoComponent tipoMantenimientoComponenet = new GestionMantenimientoComponent();
                tipoMantenimientoComponenet.Update(tipoMantenimiento);
                llenarGrillaTipoM();

            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            GestionMantenimientoComponent tipoMantenimientoComponenet = new GestionMantenimientoComponent();
            tipoMantenimientoComponenet.Delete(int.Parse(mgTipoProveedor.CurrentRow.Cells[0].Value.ToString()));
            llenarGrillaTipoM();
        }


        private void mgTipoProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTipoProvv.Text = mgTipoProveedor.CurrentRow.Cells[2].Value.ToString();
            txtTipoProveedor.Text = mgTipoProveedor.CurrentRow.Cells[1].Value.ToString();
            txtPeriocidad.Text = mgTipoProveedor.CurrentRow.Cells[3].Value.ToString();
        }

        private void txtTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Proveedor> proveedors = new List<Proveedor>();
            ProveedorComponenent proveedorComponenent = new ProveedorComponenent();

            GestionMantenimiento tipo = new GestionMantenimiento();
            tipo = (GestionMantenimiento)txtTipo.SelectedItem;
            foreach (var item in proveedorComponenent.Read())
            {
                if (item.tipoProveedor==tipo.proveedor.tipoProveedor)
                {
                    proveedors.Add(item);
                }
            }

            txtProveedor.DataSource = proveedors;
            txtProveedor.DisplayMember = "nombre";
            txtProveedor.ValueMember = "Id";



        }

        void llenarGrillaMantenimiento()

        {
            MantenimientoComponent tipoProveedorComponent = new MantenimientoComponent();
            int n = 0;
            mgProveedores.Rows.Clear();
            foreach (var item in tipoProveedorComponent.Read())
            {
                n = mgProveedores.Rows.Add();
                DateTime fecha = item.fecha;
                DateTime aux = new DateTime(2000, 10, 1);
                mgProveedores.Rows[n].Cells[0].Value = item.Id;


                mgProveedores.Rows[n].Cells[1].Value = item.fecha.ToString("dd-MM-yyyy");


                mgProveedores.Rows[n].Cells[2].Value = item.secretaria.DNI;
                mgProveedores.Rows[n].Cells[3].Value = item.tipoMantenimiento.tipoMantenimiento;

                mgProveedores.Rows[n].Cells[4].Value = item.Realizado;


                mgProveedores.Rows[n].Cells[5].Value = item.proveedor.nombre;
                if (fecha.Year > aux.Year)
                {

                    mgProveedores.Rows[n].Cells[6].Value = fecha.ToString("dd-MM-yyyy");
                }

                n++;

            }
        }
        private void btnAltaProveedor_Click(object sender, EventArgs e)
        {
            GestionMantenimiento gestionMantenimiento = new GestionMantenimiento();
            gestionMantenimiento = (GestionMantenimiento)txtTipo.SelectedItem;
            Proveedor proveedor = new Proveedor();
            proveedor = (Proveedor)txtProveedor.SelectedItem;
            
         
            Secretaria secretaria = new Secretaria();
            SecretariaComponent secretariaComponent = new SecretariaComponent();
            secretaria = secretariaComponent.ReadByEmail(SessionManager.instance.GetUSuario().UserName);
            Mantenimiento mantenimiento = new Mantenimiento(proveedor,gestionMantenimiento,secretaria);
            mantenimiento.fecha = txtFecha.Value;

               
            MantenimientoComponent mantenimientoComponent = new MantenimientoComponent();
            mantenimientoComponent.Create(mantenimiento);
            ValidadoresComponent.Alta("Mantenimiento", this);
            llenarGrillaMantenimiento();
        }

        private void btBajaProveedor_Click(object sender, EventArgs e)
        {
            MantenimientoComponent mantenimientoComponent = new MantenimientoComponent();
            mantenimientoComponent.Delete(int.Parse(mgProveedores.CurrentRow.Cells[0].Value.ToString()));
            llenarGrillaMantenimiento();
        }

        private void btnModificarProveedor_Click(object sender, EventArgs e)
        {
            MantenimientoComponent mantenimientoComponent = new MantenimientoComponent();
            Mantenimiento mantenimiento = new Mantenimiento();
            mantenimiento.Id = int.Parse(mgProveedores.CurrentRow.Cells[0].Value.ToString());
            mantenimientoComponent.Update(mantenimiento);
            llenarGrillaMantenimiento();
        }
    }
}
