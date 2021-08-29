using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Especialidad : EntityBase
    {
        public override int Id { get; set; }

        public string especialidad { get; set; }
    }
}
