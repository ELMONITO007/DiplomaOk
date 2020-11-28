using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class Idioma : EntityBase
    {
        public override int Id { get; set; }
        [DisplayName("Palabra")]

        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "ingresar solo letras")]
        [StringLength(20, ErrorMessage = "El maximo de caracteres es de 20")]
        [MinLength(2, ErrorMessage = "El minimo de caracteres es de 2")]
        public string idioma { get; set; }
 
        public void CambiarIdioma(string _idioma)
        {
            idioma = _idioma;
        }
        public string GetIdioma() { return idioma; }
    }
}
