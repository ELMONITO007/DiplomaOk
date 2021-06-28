
using Entities;
using Entities.Servicios.Digito_Verificador;
using Entities.Usuario;
using Entitites.Servicios.Login;
using Negocio;
using Negocio.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class LoginComponent
    {
        public bool VerificarBloqueado(int id)
        {
            UsuariosComponent usuariosComponent = new UsuariosComponent();
            Usuarios usuarioTabla = new Usuarios();
            usuarioTabla = usuariosComponent.ReadBy(id);
            if (usuarioTabla.Bloqueado)
            {
                return false;
            }
            else
            {

                return true;
            }
        }
        public void VerificarIntentos(int id)
        {
            UsuariosComponent usuariosComponent = new UsuariosComponent();
            Usuarios usuarioTabla = new Usuarios();
            usuarioTabla = usuariosComponent.ReadBy(id);
            if (usuarioTabla.CantidadIntentos >= 4)
            {
                usuariosComponent.Bloquear(id);
            }

        }


        public bool VerificarDVV()
        {
            UsuariosComponent usuariosComponent = new UsuariosComponent();
            DVVComponent dVVComponent = new DVVComponent();
            DVV dvvTabla = new DVV();
            dvvTabla = dVVComponent.ObtenerDVV("Usuario");
            string dvhTabla = usuariosComponent.ListaDVH();
            DVV dvvGenerado = new DVV();
            dvvGenerado = dVVComponent.GenerarDVV(dvhTabla, "Usuario");
            if (dvvTabla.dvv == dvvGenerado.dvv)
            {
                return true;
            }
            else
            {
                BackupComponent backupComponent = new BackupComponent();
                backupComponent.RestaurarBase();
                return false;
            }
        }

        public bool VerificarDVH(int id, Usuarios usuarios)
        {
            UsuarioParcial usuariosFormateado = new UsuarioParcial();
        
            usuariosFormateado.Email = usuarios.Email;
            usuariosFormateado.UserName = usuarios.Email;
            usuariosFormateado.Password = usuarios.Password;
            UsuariosComponent usuariosComponent = new UsuariosComponent();
            Usuarios usuarioTabla = new Usuarios();
            usuarioTabla = usuariosComponent.ReadBy(id);
            string dvhIngresado = DigitoVerificadorH.getDigitoEncriptado(usuariosFormateado);

            if (usuarioTabla.DVH.DVH == dvhIngresado)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool VeriricarUserName(Usuarios usuarios)
        {
            UsuariosComponent usuariosComponent = new UsuariosComponent();
            Usuarios usuarioTabla = new Usuarios();
            usuarioTabla = usuariosComponent.ReadByEmail(usuarios.Email);
            if (usuarioTabla is null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }



        public bool VerificarContraseña(int id, Usuarios usuarios)
        {
            UsuariosComponent usuariosComponent = new UsuariosComponent();
            Usuarios usuarioTabla = new Usuarios();
            usuarioTabla = usuariosComponent.ReadBy(id);
            EncriptarSHA256 encriptarSHA256 = new EncriptarSHA256(usuarios.Password);
            string pass = encriptarSHA256.Hashear();
            if (usuarioTabla.Password == pass)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        public LoginError VerificarLogin(Usuarios usuarios)

        {
            BitacoraComponent bitacoraComponent = new BitacoraComponent();
         
   
            EventoBitacora eventoBitacora = new EventoBitacora();
                

            bool userName = VeriricarUserName(usuarios);
            LoginError loginError = new LoginError();
            if (userName)
            {
                UsuariosComponent usuariosComponent = new UsuariosComponent();
                Usuarios usuarioTabla = new Usuarios();


                usuarioTabla = usuariosComponent.ReadByEmail(usuarios.Email);
                SessionManager.instance.login(usuarioTabla);
                bool password = VerificarContraseña(usuarioTabla.Id, usuarios);
                VerificarIntentos(usuarioTabla.Id);
                if (password)
                {
                    bool DVH = VerificarDVH(usuarioTabla.Id, usuarios);

                    if (DVH)
                    {
                        bool DVV = VerificarDVV();
                        if (DVV)
                        {

                            if (VerificarBloqueado(usuarioTabla.Id))
                            {

                                eventoBitacora.Id = 3;
                                Bitacora bitacora = new Bitacora(usuarioTabla,eventoBitacora);
                                bitacoraComponent.Create(bitacora);
                                loginError.error = "";

                            }
                            else
                            {
                                eventoBitacora.Id = 1;
                                Bitacora bitacora = new Bitacora(usuarioTabla, eventoBitacora);
                                loginError.error = "La cuenta esta Bloqueada. Envie un email con el error a dolores.conde@transener.com.ar ";
                            
                                bitacoraComponent.Create(bitacora);
                            }
                        }
                        else
                        {
                            loginError.error = "Error Interno, vualva a intentar";
                            eventoBitacora.Id = 2;
                            Bitacora bitacora = new Bitacora(usuarioTabla, eventoBitacora);
                            bitacoraComponent.Create(bitacora);

                            BackupComponent backupComponent = new BackupComponent();
                            backupComponent.RestaurarBase();
                        }
                    }
                    else
                    {
                        loginError.error = "Error Interno, vualva a intentar";
                        eventoBitacora.Id = 5;
                        Bitacora bitacora = new Bitacora(usuarioTabla, eventoBitacora);
                        bitacoraComponent.Create(bitacora);
                        BackupComponent backupComponent = new BackupComponent();
                        backupComponent.RestaurarBase();
                    }
                }
                else
                {
                    loginError.error = "Usuario o Contraseña Invalido";
                    eventoBitacora.Id = 4;
                    Bitacora bitacora = new Bitacora(usuarioTabla, eventoBitacora);
                    bitacoraComponent.Create(bitacora);
                }
            }

            else
            {
                loginError.error = "Usuario o Contraseña Invalido";

            }

            return loginError;

        }

    }
}
