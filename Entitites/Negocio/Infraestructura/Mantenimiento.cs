using Entitites.Negocio.Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Mantenimiento : EntityBase
    {

        public override int Id { get; set; }
        public DateTime fecha { get; set; }
         public bool Realizado { get; set; }
        public DateTime fechaRealizado { get; set; }
        public Proveedor proveedor { get; set; }
        public GestionMantenimiento tipoMantenimiento { get; set; }

        public Mantenimiento()
        {
            


        }


        public Mantenimiento(Proveedor _proveedor, GestionMantenimiento _tipoMantenimiento)
        {
            tipoMantenimiento = _tipoMantenimiento;
            proveedor = _proveedor;

        }
    }
}
