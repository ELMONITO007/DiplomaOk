using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entities;
using Negocio.Servicios.Permisos;

namespace Negocio
{
    public class UsuarioRolesComponent : IRepository<UsuarioRoles>
    {
        UsuarioRoles listaUsuarioRoles = new UsuarioRoles();
        public  UsuarioRoles Create(UsuarioRoles objeto)
        {
            UsuarioRoles result = default(UsuarioRoles);
            var usuarioRolesDAC = new UsuarioRolesDAC();

            result = usuarioRolesDAC.Create(objeto);
            return result;
        }

        public  void Delete(int id)
        {
            throw new NotImplementedException();
        }
        public void Delete(UsuarioRoles objeto)
        {
            var usuarioRolesDAC = new UsuarioRolesDAC();
            usuarioRolesDAC.Delete(objeto);
        }

        public  List<UsuarioRoles> Read()
        {

            List<UsuarioRoles> result = default(List<UsuarioRoles>);
            var usuarioRolesDAC = new UsuarioRolesDAC();
            result = usuarioRolesDAC.Read();
            return result;
        }

        public  UsuarioRoles ReadBy(int id)
        {
            throw new NotImplementedException();
        }
        public UsuarioRoles ReadBy(int id_role, int id_Usuario)
        {
            UsuarioRoles result = default(UsuarioRoles);
            var usuarioRolesDAC = new UsuarioRolesDAC();
            result = usuarioRolesDAC.ReadBy(id_role);
            return result;
        }
        public List<UsuarioRoles> ReadByUsuario(int id_Usuario)
        {
            List<UsuarioRoles> result = default(List<UsuarioRoles>);
            var usuarioRolesDAC = new UsuarioRolesDAC();
            List<UsuarioRoles> roles = new List<UsuarioRoles>();

            result = usuarioRolesDAC.ReadByUsuario(id_Usuario);
            foreach (var item in result)
            {
                UsuarioRoles roles1 = new UsuarioRoles();
                UsuariosComponent usuarios = new UsuariosComponent();

                RolesDAC rolesDAC = new RolesDAC();

                if (rolesDAC.VerificarSiEsUnPermiso(item.roles.Id) != null)
                {
                    roles1.Id = 1;
                    PermisoComponent permisoComponent = new PermisoComponent();
                    Permiso permiso = new Permiso();
                    permiso= permisoComponent.ReadBy(item.roles.Id);
                    roles1.roles.id = permiso.id;
                    roles1.roles.name = permiso.name;
                }
                else
                {
                    RolesComponent rolesComponent = new RolesComponent();
                    roles1.roles = rolesComponent.ReadBy(item.roles.Id);
                    roles1.Id = 0;

                }
                roles1.usuarios = usuarios.ReadBy(item.usuarios.Id);




                roles.Add(roles1);
            }
            return roles;
        }
        public List<UsuarioRoles> ReadByRoles(int id_Roles)
        {
            List<UsuarioRoles> result = default(List<UsuarioRoles>);
            var usuarioRolesDAC = new UsuarioRolesDAC();
            result = usuarioRolesDAC.ReadByRol(id_Roles);
            return result;
        }
        public  void Update(UsuarioRoles objeto)
        {
            var usuarioRolesDAC = new UsuarioRolesDAC();


            usuarioRolesDAC.Update(objeto);
        }

        public List<UsuarioRoles> obtenerRolesDisponiblesDelUsuario(int id_Usuario)
        {

            RolesComponent rolesComponent = new RolesComponent();
            List<Arbol> roles = new List<Arbol>();
            foreach (var item in rolesComponent.Read())
            {
                roles.Add(item);
            }
        

            PermisoComponent permisoComponent = new PermisoComponent();
            List<Permiso> permisos = new List<Permiso>();
            permisos = permisoComponent.Read();

            roles.AddRange(permisos);

            List<UsuarioRoles> usuarioRoles = new List<UsuarioRoles>();
            usuarioRoles = ReadByUsuario(id_Usuario);
            List<UsuarioRoles> result = new List<UsuarioRoles>();


            foreach (var item in roles)
            {
                int aux = 0;

                foreach (UsuarioRoles itemRoles in usuarioRoles)
                {
                    if (item.Id == itemRoles.roles.Id)
                    {
                        aux = 1;
                        break;
                    }

                }
                if (aux == 0)
                {
                    UsuarioRoles usuario = new UsuarioRoles();
                    usuario.roles.id = item.id;
                    usuario.roles.name = item.name;
                    result.Add(usuario);
                }


            }


            return result;


        }







        public bool VerificarSiTieneElRol(UsuarioRoles entity, List<Roles> roles)


        {
            bool aux = false;
            if (entity.usuarios is null)
            {
                aux = false;
            }
            else
            {

                UsuarioRoles usuarioRoles = new UsuarioRoles();

                UsuarioRoles result = new UsuarioRoles();

                UsuarioDac usuarioDac = new UsuarioDac();
                Roles unRol = new Roles();
                RolesComponent rolesComponent = new RolesComponent();
                usuarioRoles.usuarios = entity.usuarios;

                usuarioRoles.listaRoles = ReadByUsuario(usuarioRoles.usuarios.Id);



                foreach (var item in usuarioRoles.listaRoles)
                {
                    result.roles.listaRol.Add(rolesComponent.ObtenerComposite(item.roles));
                }


                if (usuarioRoles.listaRoles.Count == 0)
                {
                    aux = false;
                }
                else
                {


                    foreach (Roles item in roles)
                    {

                        if (aux)
                        {
                            break;
                        }
                        foreach (String subItem in ObtenerlistaPermisos(result.roles))
                        {
                            if (subItem == item.name)
                            {
                                aux = true;
                                break;
                            }

                        }

                    }
                }
            }

            return aux;


        }
        List<string> result = new List<string>();
        public List<string> ObtenerlistaPermisos(Roles roles)
        {


            foreach (var item in roles.ListaPermiso)
            {

                //if (item.listaRol.Count == 0)
                //{
                //    result.Add(item.name);
                //}
                //else if (item.listaRol.Count != 0)
                //{
                //    result.Add(item.name);
                //    foreach (var subItem in item.listaRol)
                //    {
                //        result.Add(subItem.name);
                //    }
                //}


            }



            return result;


        }





    }
}
