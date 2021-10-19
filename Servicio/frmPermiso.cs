using Entities;
using MetroFramework;
using Negocio;
using Negocio.Servicios.Permisos;
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

namespace DiplomaFinal.Servicio
{
    public partial class frmPermiso : MetroFramework.Forms.MetroForm
    {
        public frmPermiso()
        {
            InitializeComponent();
        }
        private void llenarGrillaAsignar()
        {
            RolesComponent rolesComponent = new RolesComponent();
            Roles roles = new Roles();
            mgDisponible.Rows.Clear();
            int id = int.Parse(mgAsignarLista.CurrentRow.Cells[0].Value.ToString());
            roles = rolesComponent.RolesDiponibles(id);
            int n = 0;
            foreach (var item in roles.listaRol)
            {
                n = mgDisponible.Rows.Add();
                mgDisponible.Rows[n].Cells[0].Value = item.Id;
                mgDisponible.Rows[n].Cells[1].Value = item.name;
                n++;
            }
        }
        int sumador;
        private void llenarArbol(Roles roles, int nodo)
        {



            List<Roles> lista = new List<Roles>();
            foreach (var list in roles.listaRol)
            {
                Roles elRol = new Roles();
                elRol = list;
                lista.Add(elRol);
            }


            Roles unrol = new Roles(lista);




            foreach (var item in unrol.listaRol)
            {
                if (item.listaRol!=null)
                {
                    List<Roles> Sublista = new List<Roles>();
                    Sublista = item.listaRol;
                    Roles roles1 = new Roles(Sublista);
                    roles1.name = item.name;
                    roles1.id = item.id;
                }
                
         


                if (item.listaRol == null)
                {
                    char a = '-';
                    string r = "";

                    lblComposite.Text = lblComposite.Text + r.PadLeft(nodo, a) + item.name + Environment.NewLine;
                }
                else
                {
                    sumador++;
                    char a = '+';
                    string r = "";
                    lblComposite.Text = lblComposite.Text + r.PadLeft(nodo, a) + item.name + Environment.NewLine;


                    llenarArbol(item, sumador);
                }


            }


        }

        private void llenarGrillaABM()
        {
            if (mgABMComposite.CurrentRow.Cells[0].Value == null)
            {
                MetroMessageBox.Show(this, "No selecciono un rol", "error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else
            {
                mgABMQuitar.Rows.Clear();
                List<Roles> roles = new List<Roles>();
                int n = 0;
                RolesComponent rolesComponent = new RolesComponent();
                roles = rolesComponent.ObtenerPermisosORolesDeUnRol(int.Parse(mgABMComposite.CurrentRow.Cells[0].Value.ToString()));
                foreach (var item in roles)
                {

                    n = mgABMQuitar.Rows.Add();
                    mgABMQuitar.Rows[n].Cells[0].Value = item.Id;
                    mgABMQuitar.Rows[n].Cells[1].Value = item.name;
                    n++;
                }
            }
        }

        private void llenarGrillaPermiso()
        {
            mgListadoPermiso.Rows.Clear();
            PermisoComponent idiomaComponent = new PermisoComponent();
            List<Permiso> idiomas = new List<Permiso>();
            idiomas = idiomaComponent.Read();
            int n = 0;
            foreach (Permiso item in idiomas)
            {
                n = mgListadoPermiso.Rows.Add();
                mgListadoPermiso.Rows[n].Cells[0].Value = item.Id;
                mgListadoPermiso.Rows[n].Cells[1].Value = item.name;

                n++;
            }

        }
        private void llenarGrillaRoles()
        {
            mgListadoRol.Rows.Clear();
            RolesComponent idiomaComponent = new RolesComponent();
            List<Roles> idiomas = new List<Roles>();
            idiomas = idiomaComponent.Read();
            int n = 0;
            int m = 0;
            int t = 0;
            int x = 0;
            foreach (Roles item in idiomas)
            {
                n = mgListadoRol.Rows.Add();

                mgListadoRol.Rows[n].Cells[0].Value = item.Id;
                mgListadoRol.Rows[n].Cells[1].Value = item.name;
                m = mgVerRol.Rows.Add();
                mgVerRol.Rows[n].Cells[0].Value = item.Id;
                mgVerRol.Rows[n].Cells[1].Value = item.name;
                t = mgAsignarLista.Rows.Add();
                mgAsignarLista.Rows[n].Cells[0].Value = item.Id;
                mgAsignarLista.Rows[n].Cells[1].Value = item.name;
                x = mgABMComposite.Rows.Add();
                mgABMComposite.Rows[n].Cells[0].Value = item.Id;
                mgABMComposite.Rows[n].Cells[1].Value = item.name;

                m++;
                t++;
                n++;
                x++;
            }
        }

        private void llenarGrillaQuitarPermisoUSuario()
        {
            UsuarioRolesComponent usuariosComponent = new UsuarioRolesComponent();
            int n = 0;
            mgQuitarPermisoUsuarioListadoRoles.Rows.Clear();
            foreach (var item in usuariosComponent.ReadByUsuario(int.Parse(mgQuitarPermisoUsuario.CurrentRow.Cells[0].Value.ToString())))
            {

                n = mgQuitarPermisoUsuarioListadoRoles.Rows.Add();
                mgQuitarPermisoUsuarioListadoRoles.Rows[n].Cells[0].Value = item.roles.Id;
                mgQuitarPermisoUsuarioListadoRoles.Rows[n].Cells[1].Value = item.roles.name;


                n++;
            }

        }


        private void llenarGrillaPermisosUsuario()
        {
            UsuarioRolesComponent usuariosComponent = new UsuarioRolesComponent();
            int n = 0;
            mgPermisosDisponubleUsuario.Rows.Clear();
            foreach (var item in usuariosComponent.obtenerRolesDisponiblesDelUsuario(int.Parse(mgUsuario.CurrentRow.Cells[0].Value.ToString())))
            {

                n = mgPermisosDisponubleUsuario.Rows.Add();
                mgPermisosDisponubleUsuario.Rows[n].Cells[0].Value = item.roles.Id;
                mgPermisosDisponubleUsuario.Rows[n].Cells[1].Value = item.roles.name;


                n++;
            }

        }





        private void frmPermiso_Load(object sender, EventArgs e)
        {
            Obsever.AgregarForm(this);

            llenarGrillaPermiso();
            llenarGrillaRoles();
            UsuariosComponent usuariosComponent = new UsuariosComponent();
            int n = 0;
            int m = 0;
            foreach (var item in usuariosComponent.Read())
            {


                n = mgUsuario.Rows.Add();
                mgUsuario.Rows[n].Cells[0].Value = item.Id;
                mgUsuario.Rows[n].Cells[1].Value = item.UserName;
                mgUsuario.Rows[n].Cells[2].Value = item.Nombre;
                mgUsuario.Rows[n].Cells[3].Value = item.Apellido;

                n++;
                m = mgQuitarPermisoUsuario.Rows.Add();
                mgQuitarPermisoUsuario.Rows[m].Cells[0].Value = item.Id;
                mgQuitarPermisoUsuario.Rows[m].Cells[1].Value = item.UserName;
                mgQuitarPermisoUsuario.Rows[m].Cells[2].Value = item.Nombre;
                mgQuitarPermisoUsuario.Rows[m].Cells[3].Value = item.Apellido;

                m++;
            }
        }

        private void btnBuscarPermiso_Click(object sender, EventArgs e)
        {
            if (txtBuscarPermiso.Text == "")
            {
                MetroMessageBox.Show(this, "El campo buscar esta vacio", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                mgListadoPermiso.Rows.Clear();
                PermisoComponent idiomaComponent = new PermisoComponent();
                List<Permiso> idiomas = new List<Permiso>();
                idiomas = idiomaComponent.buscar(txtIPermiso.Text);
                int n = 0;
                foreach (Permiso item in idiomas)
                {
                    n = mgListadoPermiso.Rows.Add();
                    mgListadoPermiso.Rows[n].Cells[0].Value = item.Id;
                    mgListadoPermiso.Rows[n].Cells[1].Value = item.permiso;

                    n++;
                }
            }
        }

        private void btnTodoPermiso_Click(object sender, EventArgs e)
        {
            llenarGrillaPermiso();
        }

        private void mgListadoPermiso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIPermiso.Text = mgListadoPermiso.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnModificarPermiso_Click(object sender, EventArgs e)
        {
            if (txtIPermiso.Text == "")
            {
                MetroMessageBox.Show(this, "No selecciono un registro", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                PermisoComponent permisoComponent = new PermisoComponent();
                Permiso permiso = new Permiso();
                permiso.Id = int.Parse(mgListadoPermiso.CurrentRow.Cells[0].Value.ToString());
                permiso.name = txtIPermiso.Text;
                permisoComponent.Update(permiso);
                llenarGrillaPermiso();
            }
        }

        private void btnEliminarPermiso_Click(object sender, EventArgs e)
        {
            if (txtIPermiso.Text == "")
            {
                MetroMessageBox.Show(this, "No selecciono un registro", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                var confirmar = MetroMessageBox.Show(this, "¿Desea Borrar este registro?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (confirmar == DialogResult.Yes)
                {
                    PermisoComponent permisoComponent = new PermisoComponent();
                    permisoComponent.Delete(int.Parse(mgListadoPermiso.CurrentRow.Cells[0].Value.ToString()));
                    llenarGrillaPermiso();
                }

            }
        }

        private void btnAltaPermiso_Click(object sender, EventArgs e)
        {
            string resultado = ValidadoresComponent.VerificarLetras(txtIPermiso.Text);
            if (resultado == "")
            {
                Permiso permiso = new Permiso();
                permiso.name = txtIPermiso.Text;
                PermisoComponent permisoComponent = new PermisoComponent();
                if (permisoComponent.Create(permiso) != null)
                {
                    llenarGrillaPermiso();
                }
                else
                {
                    ValidadoresComponent.ErrorAltaModificacado("Permiso", this);
                }
            }
            else
            {
                MetroMessageBox.Show(this, resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscarRol_Click(object sender, EventArgs e)
        {
            if (txtBuscarPermiso.Text == "")
            {
                MetroMessageBox.Show(this, "El campo buscar esta vacio", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                mgListadoPermiso.Rows.Clear();
                RolesComponent idiomaComponent = new RolesComponent();
                List<Roles> idiomas = new List<Roles>();
                idiomas = idiomaComponent.buscar(txtIPermiso.Text);
                int n = 0;
                foreach (Roles item in idiomas)
                {
                    n = mgListadoPermiso.Rows.Add();
                    mgListadoRol.Rows[n].Cells[0].Value = item.Id;
                    mgListadoRol.Rows[n].Cells[1].Value = item.permiso;

                    n++;
                }
            }
        }

        private void btnTodoRol_Click(object sender, EventArgs e)
        {
            llenarGrillaRoles();
        }

        private void mgListadoRol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRol.Text = mgListadoRol.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnModificarRol_Click(object sender, EventArgs e)
        {
            if (txtRol.Text == "")
            {
                MetroMessageBox.Show(this, "No selecciono un registro", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                RolesComponent permisoComponent = new RolesComponent();
                Roles permiso = new Roles();
                permiso.Id = int.Parse(mgListadoRol.CurrentRow.Cells[0].Value.ToString());
                permiso.name = txtRol.Text;
                permisoComponent.Update(permiso);
                llenarGrillaRoles();
            }
        }

        private void btnEliminarRol_Click(object sender, EventArgs e)
        {
            if (txtRol.Text == "")
            {
                MetroMessageBox.Show(this, "No selecciono un registro", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                var confirmar = MetroMessageBox.Show(this, "¿Desea Borrar este registro?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (confirmar == DialogResult.Yes)
                {
                    RolesComponent permisoComponent = new RolesComponent();
                    permisoComponent.Delete(int.Parse(mgListadoRol.CurrentRow.Cells[0].Value.ToString()));
                    llenarGrillaRoles();
                }

            }
        }

        private void btnAltaRol_Click(object sender, EventArgs e)
        {
            string resultado = ValidadoresComponent.VerificarLetras(txtRol.Text);
            if (resultado == "")
            {
                Roles permiso = new Roles();
                permiso.name = txtRol.Text;
                RolesComponent permisoComponent = new RolesComponent();
                if (permisoComponent.Create(permiso) != null)
                {
                    llenarGrillaRoles();
                }
                else
                {
                    ValidadoresComponent.ErrorAltaModificacado("Roles", this);
                }
            }
            else
            {
                MetroMessageBox.Show(this, resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lblComposite_Click(object sender, EventArgs e)
        {

        }

        private void mgVerRol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblComposite.Text = "";
            Roles roles = new Roles();
            roles.Id = int.Parse(mgVerRol.CurrentRow.Cells[0].Value.ToString());
            RolesComponent rolesComponent = new RolesComponent();
            roles = rolesComponent.ObtenerComposite(roles);
            lblComposite.Text = "+" + mgVerRol.CurrentRow.Cells[1].Value.ToString() + Environment.NewLine;
            sumador = 2;

            llenarArbol(roles, sumador);
        }

        private void mgAsignarLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            llenarGrillaAsignar();
        }

        private void btnAsignarPermiso_Click(object sender, EventArgs e)
        {
            if (mgAsignarLista.CurrentRow.Cells[0].Value == null || mgDisponible.CurrentRow.Cells[0].Value == null)
            {
                MetroMessageBox.Show(this, "No selecciono el rol o el permiso a asignar", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else
            {
                Roles roles = new Roles();
                roles.Id = int.Parse(mgAsignarLista.CurrentRow.Cells[0].Value.ToString());
                Roles unRol = new Roles();
                unRol.Id = int.Parse(mgDisponible.CurrentRow.Cells[0].Value.ToString());
                roles.permiso = unRol;
                RolesComponent rolesComponent = new RolesComponent();
                if (rolesComponent.CreateComposite(roles)==null)
                {
                    MetroMessageBox.Show(this, "No se puede asiganr el rol o el permiso, el rol: "+mgDisponible.CurrentRow.Cells[1].Value.ToString()+" contiente el rol o permiso: "+ mgAsignarLista.CurrentRow.Cells[1].Value.ToString(), "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                }

                ;
                llenarGrillaAsignar();


            }
        }

        private void mgABMComposite_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            llenarGrillaABM();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (mgABMComposite.CurrentRow.Cells[0].Value == null || mgABMQuitar.CurrentRow.Cells[0].Value == null)
            {

                MetroMessageBox.Show(this, "No selecciono un rol o permiso", "error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else
            {
                Roles roles = new Roles();
                Roles unrol = new Roles();
                roles.Id = int.Parse(mgABMComposite.CurrentRow.Cells[0].Value.ToString());
                unrol.Id = int.Parse(mgABMQuitar.CurrentRow.Cells[0].Value.ToString());
                roles.permiso = unrol;
                RolesComponent rolesComponent = new RolesComponent();
                rolesComponent.DeleteComposite(roles);

                llenarGrillaABM();
            }
        }

        private void mgUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(mgUsuario.CurrentRow.Cells[0].Value == null)
            {
                MetroMessageBox.Show(this, "No selecciono un usuario", "error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else
            {
                llenarGrillaPermisosUsuario();
            }
        }

        private void btnAgregarPermisoUsuario_Click(object sender, EventArgs e)
        {
            if (mgUsuario.CurrentRow.Cells[0].Value == null || mgPermisosDisponubleUsuario.CurrentRow.Cells[0].Value == null)
            {

                MetroMessageBox.Show(this, "No selecciono un usuario o Rol", "error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }

            else
            {
                UsuarioRoles roles = new UsuarioRoles();
                roles.roles.id = mgPermisosDisponubleUsuario.CurrentRow.Cells[0].Value.ToString();
                roles.usuarios.Id = int.Parse(mgUsuario.CurrentRow.Cells[0].Value.ToString());
                UsuarioRolesComponent usuarioRolesComponent = new UsuarioRolesComponent();
                if (usuarioRolesComponent.Create(roles) == null)
                {
                    ValidadoresComponent.ErrorAltaModificacado("Agregar permiso", this);
                }
                else
                {
                    llenarGrillaPermisosUsuario();
                }



            }
        }

        private void mgQuitarPermisoUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (mgQuitarPermisoUsuario.CurrentRow.Cells[0].Value == null)
            {
                MetroMessageBox.Show(this, "No selecciono un usuario", "error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else
            {
                llenarGrillaQuitarPermisoUSuario();
            }
        }

        private void btnQuitarPermisoUsuario_Click(object sender, EventArgs e)
        {
            if (mgQuitarPermisoUsuario.CurrentRow.Cells[0].Value == null || mgQuitarPermisoUsuarioListadoRoles.CurrentRow.Cells[0].Value == null)
            {
                MetroMessageBox.Show(this, "No selecciono un usuario o rol", "error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else
            {
                UsuarioRoles usuarioRoles = new UsuarioRoles();
                usuarioRoles.roles.Id = int.Parse(mgQuitarPermisoUsuarioListadoRoles.CurrentRow.Cells[0].Value.ToString());
                usuarioRoles.usuarios.Id = int.Parse(mgQuitarPermisoUsuario.CurrentRow.Cells[0].Value.ToString());
                UsuarioRolesComponent usuarioRolesComponent = new UsuarioRolesComponent();
                usuarioRolesComponent.Delete(usuarioRoles);



                llenarGrillaQuitarPermisoUSuario();
            }
        }
    }
}
