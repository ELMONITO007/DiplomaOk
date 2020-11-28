using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{ 
    public abstract class Enciptador : EntityBase
    {
        public string valorInicial;

        public string valorEncriptado;

        public abstract string Hashear();
    }
}
