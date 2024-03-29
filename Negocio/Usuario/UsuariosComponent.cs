﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.Usuario;
using Entities;
using Entities.Usuario;
using Entitites.Negocio.Personas;
using Negocio.Servicios;

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

        public void RestoreBDAUX()

        { UsuarioDACaux usuarioDACaux = new UsuarioDACaux();
            usuarioDACaux.DeleteAll();

            foreach (var item in Read())
            {
                usuarioDACaux.Create(item);

            }


        }
        public bool Crear(Usuarios objeto)
        {
          

            UsuarioParcial usuariosFormateado = new UsuarioParcial();
            EncriptarSHA256 encriptarSHA256 = new EncriptarSHA256(objeto.Password);
            usuariosFormateado.Email = objeto.Email;
            usuariosFormateado.UserName = objeto.UserName;
            usuariosFormateado.Password = encriptarSHA256.Hashear();

            if (Verificar(objeto.UserName))
            {
         
                DigitoVerificadorH digitoVerificadorH = new DigitoVerificadorH();
                digitoVerificadorH.DVH = DigitoVerificadorH.getDigitoEncriptado(usuariosFormateado);

          

                Usuarios usuarios = new Usuarios(digitoVerificadorH);
                usuarios.Apellido = objeto.Apellido;
                usuarios.Email = objeto.Email;

                usuarios.UserName = objeto.UserName;
                usuarios.Nombre = objeto.Nombre;


                usuarios.Password = encriptarSHA256.Hashear();
                UsuarioDac usuarioDac = new UsuarioDac();
                UsuarioDACaux usuarioDACaux = new UsuarioDACaux();

                usuarioDac.Create(usuarios);
                usuarioDACaux.Create(usuarios);

                DVVComponent dVVComponent = new DVVComponent();
                dVVComponent.CrearDVV(ListaDVH(), "Usuario");

                Usuarios usuariosCreado = new Usuarios();
                usuariosCreado = ReadByEmail(objeto.Email);
                BitacoraComponent bitacoraComponent = new BitacoraComponent();
                EventoBitacora eventoBitacora = new EventoBitacora();
                eventoBitacora.Id = 1;
                Bitacora bitacora = new Bitacora(usuarioDACaux.ReadByEmail(usuariosCreado.Email), eventoBitacora);
     
         
                bitacoraComponent.Create(bitacora);

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Crear(Usuarios objeto,Persona  persona)
        {


            UsuarioParcial usuariosFormateado = new UsuarioParcial();
            EncriptarSHA256 encriptarSHA256 = new EncriptarSHA256(objeto.Password);
            usuariosFormateado.Email = objeto.Email;
            usuariosFormateado.UserName = objeto.UserName;
            usuariosFormateado.Password = encriptarSHA256.Hashear();

            if (Verificar(objeto.UserName))
            {

                Crear(objeto);
                UsuarioDac usuarioDac = new UsuarioDac();
                Usuarios usuariosCreado = new Usuarios();
                usuariosCreado = ReadByEmail(objeto.Email);
                usuarioDac.AgregarUsuarioAlaPersona(usuariosCreado, persona);


                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
        public void UpdateIntentos(int cantidad, int legajo)

        {
            UsuarioDac usuarioDac = new UsuarioDac();

            if (usuarioDac.UpdateIntentos(cantidad, legajo)>=3)
            {
                Bloquear(legajo);
            } 
        
        }
        public void BorrarIntentos( int legajo)

        {
            UsuarioDac usuarioDac = new UsuarioDac();

            usuarioDac.UpdateIntentos(0, legajo);
            
              
            

        }
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
            usuarios.Email=objeto.Email;
            usuarios.UserName = objeto.UserName;
            usuarios.Id = objeto.Id;
          
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
        public Usuarios ReadByEmailAux(string emailUsername)
        {
            UsuarioDACaux usuarioDac = new UsuarioDACaux();
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
            if (ReadByEmail(entity.Email)==null)
            {
                return true;
            }
            else
            {
                return true;
            }
          
        }
    }
}
