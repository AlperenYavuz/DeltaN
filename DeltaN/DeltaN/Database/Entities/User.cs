using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeltaN.Database.Entities
{
    public class User
    {
        public int UserId{ get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String Email { get; set; }
    }
}
