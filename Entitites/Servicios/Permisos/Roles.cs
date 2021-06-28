using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Roles : EntityBase
    {
        public override int Id { get; set; }
        [Required]
        [DisplayName("Identificador")]
        public string id { get; set; }

        [Required]
        [DisplayName("Nombre del Permiso")]

        public string name { get; set; }
        public Roles permiso { get; set; }
        public List<Roles> listaRol { get; set; }
        public List<Permiso> ListaPermiso { get; set; }
        public Roles(string _id, string _NombrePermiso)
        {
            id = id;
            name = _NombrePermiso;
        }

        public Roles(List<Roles>  _listaRol, List<Permiso> _ListaPermiso)
        {
            ListaPermiso = _ListaPermiso;
            listaRol = _listaRol;
         

        }
        public Roles() { }



       


    }
}

