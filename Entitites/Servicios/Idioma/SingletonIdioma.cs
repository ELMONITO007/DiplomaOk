using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitites
{
  public sealed  class SingletonIdioma
    {
        private SingletonIdioma()
        {
        }

        private static SingletonIdioma _intance = null;
        public static SingletonIdioma intance
        {
            get
            {
                if (_intance == null)
                    _intance = new SingletonIdioma();
                return _intance;
            }
        }

        private Idioma unIdioma
        {
            get;
            set;
        }

        public void NuevoIdioma(Idioma lenguaje)
        {
            unIdioma = lenguaje;
        }

        public Idioma getUsuario()
        {
            return unIdioma;
        }

        public void CambiarIdioma(string NuevoIdioma)
        {
            unIdioma.CambiarIdioma(NuevoIdioma);
        }

        public void BorrarIdioma()
        {
            unIdioma = null;
        }
    }
}
