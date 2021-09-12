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
using Entitites.Negocio.Personas;
using MetroFramework;
using Negocio.Gestion_de_Infraestructura;
using Negocio.Servicios.REGEX;

namespace DiplomaFinal.Gestion_de_Infraestructura
{
    public partial class frmProveedores : MetroFramework.Forms.MetroForm
    {
        public frmProveedores()
        {
            InitializeComponent();
        }


        void llenarGrillaProveedor()

        {
            int n = 0;
            mgProveedores.Rows.Clear();
            ProveedorComponenent SalaComponent = new ProveedorComponenent();
            foreach (var item in SalaComponent.Read())
            {
                n = mgProveedores.Rows.Add();
                mgProveedores.Rows[n].Cells[0].Value = item.Id;
                mgProveedores.Rows[n].Cells[1].Value = item.matricula;
                mgProveedores.Rows[n].Cells[2].Value = item.nombre;
                mgProveedores.Rows[n].Cells[3].Value = item.listaTelefono[0].numero;
                mgProveedores.Rows[n].Cells[4].Value = item.contacto;
                mgProveedores.Rows[n].Cells[5].Value = item.tipoProveedor;

                mgProveedores.Rows[n].Cells[6].Value = item.cuit;


            }
        }


        void llenargrillaTipo()
        {

            int n = 0;
            mgTipoProveedor.Rows.Clear();
            ProveedorComponenent SalaComponent = new ProveedorComponenent();
            foreach (var item in SalaComponent.ReadTipoProveedor())
            {
                n = mgTipoProveedor.Rows.Add();
                mgTipoProveedor.Rows[n].Cells[0].Value = item.Id;
                mgTipoProveedor.Rows[n].Cells[1].Value = item.tipoProveedor;





            }

            txtTipo.DataSource = SalaComponent.Read();
            txtTipo.DisplayMember = "tipoProveedor";
            txtTipo.ValueMember = "Id";
        }



        private void frmProveedores_Load(object sender, EventArgs e)
        {
            RecorridoForm.CambiarIdioma(this);
            llenarGrillaProveedor();
            llenargrillaTipo();
        }

        bool VerificarCampos()

        {
            string error = "";
            error = ValidadoresComponent.VerificarAlfaNumerico(txtMatricula.Text);

            error = error + Environment.NewLine + ValidadoresComponent.VerificarLetras(txtNombreProveedor.Text);
            error = error + Environment.NewLine + ValidadoresComponent.VerificarTemañoTelefono(txtTelefono.Text);
            error = error + Environment.NewLine + ValidadoresComponent.VerificarLetras(txtContacto.Text);
            error = error + Environment.NewLine + ValidadoresComponent.VerificarTemañoNumero(txtCUIT.Text, 11, 11);



            if (error.Length >= 10)
            {

                MetroMessageBox.Show(this, error, "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {

                return true;
            }



        }
        private void btnAltaProveedor_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                Proveedor proveedor = new Proveedor();
           Proveedor tipoProveedor = new Proveedor();
                proveedor.matricula = txtMatricula.Text;
                proveedor.nombre = txtNombreProveedor.Text;
                tipoProveedor = (Proveedor)txtTipo.SelectedItem;
                //proveedor.tipoProveedor = proveedor;
                proveedor.listaTelefono[0].numero =double.Parse( txtTelefono.Text);
                proveedor.contacto = txtContacto.Text;
                proveedor.cuit = txtCUIT.Text;
                ProveedorComponenent proveedorComponenent = new ProveedorComponenent();
                if (proveedorComponenent.Create(proveedor) == null)
                {

                    ValidadoresComponent.ErrorAltaModificacado("Proveedor", this);
                }
                else
                {
                    ValidadoresComponent.Alta("Proveedor", this);
                    RecorridoForm.LimpiarTXT(this);
                    llenarGrillaProveedor();

                }

            }
        }

        private void btnModificarProveedor_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                //Proveedor proveedor = new Proveedor();
                //TipoProveedor tipoProveedor = new TipoProveedor();
                //proveedor.Id = int.Parse(mgProveedores.CurrentRow.Cells[0].Value.ToString());
                //proveedor.matricula = txtMatricula.Text;
                //proveedor.nombre = txtNombreProveedor.Text;
                //tipoProveedor = (TipoProveedor)txtTipo.SelectedItem;
                //proveedor.tipoProveedor = tipoProveedor;
                //proveedor.telefono = txtTelefono.Text;
                //proveedor.contacto = txtContacto.Text;
                //proveedor.cuit = txtCUIT.Text;
                //ProveedorComponenent proveedorComponenent = new ProveedorComponenent();
                //proveedorComponenent.Update(proveedor);

                //llenarGrillaProveedor();

            }
        }

        private void btBajaProveedor_Click(object sender, EventArgs e)
        {
            ProveedorComponenent proveedorComponenent = new ProveedorComponenent();
            Proveedor proveedor = new Proveedor();
            proveedor.Id = int.Parse(mgProveedores.CurrentRow.Cells[0].Value.ToString());
            proveedorComponenent.Delete(proveedor.Id);
            llenarGrillaProveedor();
        }

        private void txtVerTodoSala_Click(object sender, EventArgs e)
        {
            llenarGrillaProveedor();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            if (txtBuscarProveedor.Text == "")
            {
                MetroMessageBox.Show(this, "Campo Buscar Vacio", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                int n = 0;
                mgProveedores.Rows.Clear();
                ProveedorComponenent SalaComponent = new ProveedorComponenent();
                foreach (var item in SalaComponent.buscar(txtBuscarProveedor.Text))
                {
                    n = mgProveedores.Rows.Add();
                    mgProveedores.Rows[n].Cells[0].Value = item.Id;
                    mgProveedores.Rows[n].Cells[1].Value = item.matricula;
                    mgProveedores.Rows[n].Cells[2].Value = item.nombre;
                    mgProveedores.Rows[n].Cells[3].Value = item.listaTelefono[0].numero;
                    mgProveedores.Rows[n].Cells[4].Value = item.contacto;
                    mgProveedores.Rows[n].Cells[5].Value = item.tipoProveedor;

                    mgProveedores.Rows[n].Cells[6].Value = item.cuit;


                }
            }
        }

        private void mgProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtMatricula.Text = mgProveedores.CurrentRow.Cells[1].Value.ToString();
            txtNombreProveedor.Text = mgProveedores.CurrentRow.Cells[2].Value.ToString();


            txtTelefono.Text = mgProveedores.CurrentRow.Cells[3].Value.ToString();
            txtContacto.Text = mgProveedores.CurrentRow.Cells[4].Value.ToString();
            txtCUIT.Text = mgProveedores.CurrentRow.Cells[6].Value.ToString();
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
                Proveedor tipoProveedor = new Proveedor();
                tipoProveedor.tipoProveedor = txtTipoProveedor.Text;
                ProveedorComponenent tipoProveedorComponent = new ProveedorComponenent();
                if (tipoProveedorComponent.Create(tipoProveedor) == null)
                {



                    ValidadoresComponent.ErrorAltaModificacado("Tipo Proveedor", this);
                }
                else
                {
                    ValidadoresComponent.Alta("Tipo Proveedor", this);
                    RecorridoForm.LimpiarTXT(this);
                    llenargrillaTipo();

                }

            }
        }

        private void mgTipoProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTipoProveedor.Text = mgTipoProveedor.CurrentRow.Cells[1].Value.ToString();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            if (verificarCamposTipo())
            {
                Proveedor tipoProveedor = new Proveedor();
                tipoProveedor.tipoProveedor = txtTipoProveedor.Text;
                tipoProveedor.Id = int.Parse(mgTipoProveedor.CurrentRow.Cells[0].Value.ToString()) ;
                ProveedorComponenent tipoProveedorComponent = new ProveedorComponenent();
                tipoProveedorComponent.Update(tipoProveedor);
                    RecorridoForm.LimpiarTXT(this);
                    llenargrillaTipo();

                }

            }

        private void metroButton3_Click(object sender, EventArgs e)
        { 
            ProveedorComponenent tipoProveedorComponent = new ProveedorComponenent();
            tipoProveedorComponent.Delete(int.Parse(mgTipoProveedor.CurrentRow.Cells[0].Value.ToString()));
            llenargrillaTipo();
        }
    }
    }

