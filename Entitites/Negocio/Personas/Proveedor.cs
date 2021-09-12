using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitites.Negocio.Personas
{
  public  class Proveedor :Persona
    {
        public string cuit { get; set; }
        public string matricula { get; set; }
        public string contacto { get; set; }

        public string tipoProveedor { get; set; }
        public Proveedor()
        {

        }
        public Proveedor(List<Telefono> _listaTelefono)
        {
            listaTelefono = _listaTelefono;
        }
    }
}
