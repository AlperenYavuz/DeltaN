using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Models;

namespace WebMVC.Controllers
{
    public class StudentAdministratieController : Controller
    {
        public IActionResult ZoekStudenten(char j)
        {

            List<Student> studenten = new List<Student>();
            Student s = new Student("Alperen", "Yavuz");
            Student s1 = new Student("Alperen", "Kavuz");
            Student s2 = new Student("Alperen", "Havuz");

            studenten.Add(s);
            studenten.Add(s1);
            studenten.Add(s2);

            var studList = from a in studenten
                       where a.naam.StartsWith(j)
                       select a;

            studList = studList.ToList();

            ViewData["ingevoerde"] = j;

            return View(studList);

        }
    }
}
