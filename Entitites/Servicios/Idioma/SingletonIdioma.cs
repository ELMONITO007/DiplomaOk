using Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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

        public void CambiarIdioma(Idioma NuevoIdioma)
        {
            unIdioma = NuevoIdioma;
            unIdioma.cultureinfo = new CultureInfo(NuevoIdioma.codigo);
        }

        public void BorrarIdioma()
        {
            unIdioma = null;
        }
    }
}
