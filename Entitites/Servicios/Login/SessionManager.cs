using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Entities.Usuario;
namespace Entitites.Servicios.Login
{
    public sealed class SessionManager
    {
        private SessionManager() { }
        private static SessionManager _intance = null;
        public static SessionManager instance
        {
            get
            {
                if (_intance == null)
                {
                    _intance = new SessionManager();
                }

                return _intance;
            }

        }

        private Usuarios usuario;
        public void login(Usuarios user)
        {
            usuario = user;

        }
        public Usuarios GetUSuario()
        {
            return usuario;
        }
        public void LogOut()
        {
            usuario = null;
        }
    }
}
