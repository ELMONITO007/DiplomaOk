using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entities;
using Entities.Usuario;

namespace Negocio
{
    public class UsuariosComponent : IRepository2<Usuarios>
    {


        #region Crear

        public bool Verificar(string userName)
        {
            Usuarios usuarios = new Usuarios();
            UsuarioDac usuarioDac = new UsuarioDac();
            usuarios = usuarioDac.ReadByEmail(userName);
            if (usuarios is null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        public bool Crear(Usuarios objeto)
        {
          

            UsuarioParcial usuariosFormateado = new UsuarioParcial();
     
            usuariosFormateado.Email = objeto.Email;
            usuariosFormateado.UserName = objeto.UserName;
            usuariosFormateado.Password = objeto.Password;
            if (Verificar(objeto.UserName))
            {
         
                DigitoVerificadorH digitoVerificadorH = new DigitoVerificadorH();
                digitoVerificadorH.DVH = DigitoVerificadorH.getDigitoEncriptado(usuariosFormateado);
                EncriptarSHA256 encriptarSHA256 = new EncriptarSHA256(objeto.Password);
                Usuarios usuarios = new Usuarios(digitoVerificadorH);
                usuarios = objeto;
                usuarios.Password = encriptarSHA256.Hashear();
                UsuarioDac usuarioDac = new UsuarioDac();
                usuarioDac.Create(usuarios);


                DVVComponent dVVComponent = new DVVComponent();
                dVVComponent.CrearDVV(ListaDVH(), "Usuario");

                return true;
            }
            else
            {
                return false;
            }
        }


      
        #endregion

        public void Bloquear(int id)
        {
            var usuario = new UsuarioDac();

            usuario.Bloquear(id);
        }
        public void Desloquear(int id)
        {
            var usuario = new UsuarioDac();
            usuario.Desbloquear(id);
        }
        public  void Delete(int id)
        {
            var usuario = new UsuarioDac();
            usuario.Delete(id);
        }

        public  List<Usuarios> Read()
        {
            List<Usuarios> result = default(List<Usuarios>);
            var usuario = new UsuarioDac();
            result = usuario.Read();
            return result;
        }

        public  Usuarios ReadBy(int id)
        {
            Usuarios result = default(Usuarios);
            var usuario = new UsuarioDac();
            result = usuario.ReadBy(id);
            return result;
        }

        public  bool Update(Usuarios objeto)
        {
            Usuarios usuarioTabla = new Usuarios();
            usuarioTabla = ReadBy(objeto.Id);
            UsuarioDac usuarioDac = new UsuarioDac();

            if (objeto.UserName==usuarioTabla.UserName)
            {
                usuarioDac.Update(objeto);
                return true;
            }
            else
            {
                return false;
            }




   
        }
        public void UpdatePassword(Usuarios objeto)
        {
            EncriptarSHA256 encriptarSHA256 = new EncriptarSHA256(objeto.Password);
            UsuarioParcial usuariosFormateado = new UsuarioParcial();
         

        //Obtengo el DVH
            usuariosFormateado.Email = objeto.Email;
            usuariosFormateado.UserName = objeto.Email;
            usuariosFormateado.Password = objeto.Password;

            DigitoVerificadorH digitoVerificadorH = new DigitoVerificadorH();
            digitoVerificadorH.DVH = DigitoVerificadorH.getDigitoEncriptado(usuariosFormateado);

            //Formateo el usuario
            Usuarios usuarios = new Usuarios(digitoVerificadorH);
            usuarios=objeto;
          
          
            usuarios.Password = encriptarSHA256.Hashear();
            UsuarioDac usuarioDac = new UsuarioDac();
            usuarioDac.UpdatePassword(usuarios);
            DVVComponent dVVComponent = new DVVComponent();
            dVVComponent.CrearDVV(ListaDVH(), "Usuario");







        }
        public Usuarios ReadByEmail(string emailUsername)
        {
            UsuarioDac usuarioDac = new UsuarioDac();
            return usuarioDac.ReadByEmail(emailUsername);
        }

        public string ListaDVH()
        {
            string lista = "";
            UsuarioDac usuarioDac = new UsuarioDac();
            List<Usuarios> usuarios = new List<Usuarios>();
            usuarios = usuarioDac.ReadDVH();

            foreach (Usuarios item in usuarios)
            {
                lista = lista + item.DVH.DVH;
            }

            return lista;

        }

        public  Usuarios Create(Usuarios objeto)
        {
            throw new NotImplementedException();
        }

        public Usuarios ReadBy(string id)
        {
            throw new NotImplementedException();
        }

        public bool Verificar(Usuarios entity)
        {
            throw new NotImplementedException();
        }
    }
}
