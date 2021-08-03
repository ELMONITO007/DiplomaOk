using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitites.Negocio.Personas
{
    public class Telefono : EntityBase
    {
        public override int Id { get; set; }
        public int codigo_Area { get; set; }
        public double numero { get; set; }
        public string descripcion { get; set; }



       


    }
}
