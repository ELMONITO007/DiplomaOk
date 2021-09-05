using Entitites.Negocio.Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
  public  class GestionMantenimiento :EntityBase
    {
        public override int Id { get; set; }

        public Proveedor proveedor { get; set; }

        public string tipoMantenimiento { get; set; }
        public int periocidad { get; set; }

        public GestionMantenimiento()
        {
           
        }
        public GestionMantenimiento(Proveedor _proveedor)
        {
            proveedor = _proveedor;
        }
    }
}
