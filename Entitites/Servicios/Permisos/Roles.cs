using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Roles : Arbol
    {
       
        public Roles permiso { get; set; }
        public List<Roles> listaRol { get; set; }
        public List<Arbol> ListaPermiso { get; set; }
        public Roles(string _id, string _NombrePermiso)
        {
            id = id;
            name = _NombrePermiso;
        }

        public Roles(List<Roles>  _listaRol, List<Arbol> _ListaPermiso)
        {
            ListaPermiso = _ListaPermiso;
            listaRol = _listaRol;
         

        }
        public Roles() { }


        public Roles(List<Roles> _listaRol )
        {
          
            listaRol = _listaRol;


        }



    }
}

