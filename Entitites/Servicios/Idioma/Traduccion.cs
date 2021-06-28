using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
 public   class Traduccion : EntityBase
    {
        public override int Id { get; set; }

        public string traduccion { get; set; }
        public string referencia { get; set; }
        public Idioma idioma { get; set; }



        public Palabra palabra { get; set; }

        public Traduccion()
        {
            

        }

        public Traduccion(Idioma _idioma, Palabra _palabra)
        {
            idioma = _idioma;
            palabra = _palabra;

        }
    }
}
