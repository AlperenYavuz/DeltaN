using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hotel.Models
{
    public class Hotelboeking
    {
        public int BoekingId { set; get; }
        public string Naam { set; get; }
        public int Telnummer { set; get; }
        public int Kamernummer { set; get; }
    }
}
