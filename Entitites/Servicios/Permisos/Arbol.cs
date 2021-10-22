using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
 public   class Arbol :EntityBase
    {
        public override int Id { get; set; }
        [Required]
        [DisplayName("Identificador")]
        public string id { get; set; }

        [Required]
        [DisplayName("Nombre del Permiso")]

        public string name { get; set; }

    }
}
