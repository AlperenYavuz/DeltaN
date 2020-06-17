using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Webmv.Models
{
    public class Student
    {
        public Student(String Naam, String Anaam)
        {
            naam = Naam;
            anaam = Anaam;
        }
        public string naam { get; set; }
        public string anaam { get; set; }
    }
}
