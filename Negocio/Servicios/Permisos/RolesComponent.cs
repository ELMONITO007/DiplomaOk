using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entities;


namespace Negocio
{
    public class RolesComponent : IRepository2<Roles>
    {
        public List<Roles> buscar(string palabra)
        {
            List<Roles> entity = new List<Roles>();

            entity = Read();
            List<Roles> result = new List<Roles>();
            foreach (Roles item in entity)
            {
                if (item.name.Contains(palabra))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public Roles Create(Roles objeto)
        {
            if (Verificar(objeto))
            {
                Roles result = default(Roles);
                var roles = new RolesDAC();
                Roles rolesBase = new Roles();
                result = roles.Create(objeto);
                rolesBase = roles.ReadBy(objeto.name);
                roles.CreateEtapa2(rolesBase);

                return result;
            }
            else
            {
                return null;
            }
        }

        public  void Delete(int id)
        {
            var roles = new RolesDAC();
            roles.Delete(id);
        }

        public  List<Roles> Read()
        {
            List<Roles> result = default(List<Roles>);
            var roles = new RolesDAC();
            result = roles.Read();
            return result;
        }

        public  Roles ReadBy(int id)
        {
            Roles result = default(Roles);
            var roles = new RolesDAC();

            result = roles.ReadBy(id);
            return result;
        }
        public Roles ReadBy(string id)
        {
            Roles result = default(Roles);
            var roles = new RolesDAC();

            result = roles.ReadBy(id);
            return result;
        }
        public Roles ReadByNombreRol(string name)
        {
            Roles result = default(Roles);
            var roles = new RolesDAC();

            result = roles.ReadByNombreRol(name);
            return result;
        }

  
        public bool Verificar(Roles entity)

        {
            RolesDAC rolesDAC = new RolesDAC();
            Roles roles = new Roles();
            roles = rolesDAC.ReadBy(entity.name);
            if (roles is null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        #region Composite
        public List<Arbol> ObtenerPermisosORolesDeUnRol(int id)
        {
            RolesDAC rolesDAC = new RolesDAC();
            List<Arbol> lista = new List<Arbol>();
            foreach (var item in rolesDAC.ObtenerPermisosORolesDeUnRol(id))
            {
                lista.Add(item);
            }
            return lista;


        }
        public Roles ObtenerComposite(Roles entity)
        {
            Roles roles = new Roles();
            RolesDAC rolesDAC = new RolesDAC();
            roles = entity;
       
            List<Arbol> listaRol = new List<Arbol>();
            foreach (Roles item in ObtenerPermisosORolesDeUnRol(entity.Id))
            {

                if (rolesDAC.VerificarSiEsUnPermiso(item.Id) != null)
                {

                    listaRol.Add(item);
                }
                else if (rolesDAC.VerificarSiEsUnRol(item.Id) != null)
                {
                    Roles roles1 = new Roles();
                    roles1 = ObtenerComposite(item);
                    listaRol.Add(roles1);
                }


            }

            roles.ListaPermiso = listaRol;

            return roles;


        }

        String arbol = "";
        int sumador = 1;
        public string ObetenerArbol(Roles entity)
        {

            if (entity.ListaPermiso.Count==0)
            {
                return "-" + entity.name;
            }
            Roles roles = new Roles();
            RolesDAC rolesDAC = new RolesDAC();
            roles = entity;
            foreach (var item in entity.ListaPermiso)
            {
                if (rolesDAC.VerificarSiEsUnPermiso(item.Id) != null)
                {

                    string a="";
                    char b = '-';
                    arbol = arbol + System.Environment.NewLine+a.PadLeft(sumador,b)+item.name;
               
                }
                else
                {
                    string a = "";
                    char b = '+';
                    arbol = arbol + System.Environment.NewLine + a.PadLeft(sumador, b) + item.name;
                    Roles unrROl = new Roles();
                    unrROl.id = item.id;
                    unrROl.ListaPermiso = ObtenerPermisosORolesDeUnRol(item.Id);
                    unrROl.name = item.name;
                    sumador++;
                    ObetenerArbol(unrROl);
                    
                }
            }
            sumador = 1;
            return arbol;
        }


        #endregion

        #region ABM Composite

        public Roles CreateComposite(Roles entity)
        {
            int a = 0;
            List<Arbol> roles = new List<Arbol>();
            roles = ObtenerPermisosORolesDeUnRol(entity.permiso.Id);
            foreach (var item in roles)
            {

                if (item.Id==entity.Id)
                {
                    a = 1;
                }
            }
            if (a==1)
            {
                return null;
            }
            else
            {
                RolesDAC rolesDAC = new RolesDAC();
                return rolesDAC.CreateComposite(entity);
            }

          

        }

        public void UpdateComposite(Roles entity, Roles update)
        {
            RolesDAC rolesDAC = new RolesDAC();
            rolesDAC.UpdateComposite(entity, update);
        }
        public void DeleteComposite(Roles entity)
        {
            RolesDAC rolesDAC = new RolesDAC();
            rolesDAC.DeleteComposite(entity);
        }


        public Roles RolesDiponibles(int id)
        {
            Roles roles = new Roles();
            RolesDAC rolesDAC = new RolesDAC();
            roles = rolesDAC.ReadBy(id);
           
            PermisoDAC permisoDAC = new PermisoDAC();
            List<Arbol> ListaPermiso = new List<Arbol>();
            foreach (var item in rolesDAC.Read())
            {
                ListaPermiso.Add(item);
            }

            foreach (var item in permisoDAC.Read())
            {
                ListaPermiso.Add(item);
            }


            Roles rolesBase = new Roles(null,ListaPermiso);

            Roles result = new Roles();
            result = rolesDAC.ReadBy(id);
            roles.ListaPermiso = ObtenerPermisosORolesDeUnRol(id);

            List<Arbol> listaroles = new List<Arbol>();

            foreach (var item in rolesBase.ListaPermiso)
            {
                int a = 0;

                foreach (var subItem in roles.ListaPermiso)
                {
                    if (subItem.Id == item.Id)
                    {
                        a = 1;
                    }

                }
                if (result.Id == item.Id)
                {
                    a = 1;
                }
                if (a == 0)
                {
                    Arbol unRol = new Arbol();
                    unRol = item;
                    listaroles.Add(unRol);
                }


            }

            result.ListaPermiso = listaroles;





            return result;

        }

        public bool Update(Roles entity)
        {
            var roles = new RolesDAC();
            if (roles.ReadByListado(entity.name).Count==0)
            {
                roles.Update(entity);
                return true;
            }
            else
            {
                return false;
            }


          
        }



        #endregion
    }
}
