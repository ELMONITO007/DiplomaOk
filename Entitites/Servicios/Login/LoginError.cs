using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class LoginError :EntityBase
    {
        public override int Id { get; set; }
        public string error { get; set; }


    }
}
