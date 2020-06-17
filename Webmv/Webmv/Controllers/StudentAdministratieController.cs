using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Webmv.Models;

namespace Webmv.Controllers
{
    public class StudentAdministratieController : Controller
    {
        public IActionResult ZoekStudenten(char j)
        {

            List<Student> studenten = new List<Student>();
            Student s = new Student("alperen", "yavuz");
            Student s1 = new Student("alperen", "kavuz");
            Student s2 = new Student("alperen", "havuz");

            studenten.Add(s);
            studenten.Add(s1);
            studenten.Add(s2);

            var studList = from a in studenten
                           where a.anaam.StartsWith(j)
                           select a;

            studList = studList.ToList();

            ViewData["ingevoerde"] = j;

            return View(studList);

        }
    }
}


