using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using crud.Data;
using crud.Models;

namespace crud.Controllers
{
    public class CrudController : Controller
    {
        

        public IActionResult Index()
        {
            var studenten = _context.Student.ToList();
            return View(studenten);

        }

        private readonly StudentContext _context;

            public CrudController(StudentContext context)
            {
                _context = context;
            }



        public IActionResult Create()
        {
            
            return View();

        }

        //Action voor het aanmaken van een hotelboeking
        [HttpPost]
            public IActionResult IsCreate( string Naam, int Leeftijd, string Opleiding)
            {

                
                _context.Student.Add(new Student() { Naam = Naam, Leeftijd = Leeftijd, Opleiding = Opleiding });
            _context.SaveChanges();
                return View("Index", _context.Student.ToList());
            }

            //Action voor het bewerken van een hotelboeking
            public ActionResult Edit(int Id)
            {
                var studenten = _context.Student.ToList();
                var student = studenten.Where(h => h.Id == Id).FirstOrDefault();

                return View(student);
            }

            [HttpPost]
            public ActionResult IsEdit(int Id, string Naam, string Opleiding, int Leeftijd)
            {
               
                var student = _context.Student.Where(h => h.Id == Id).FirstOrDefault();
                student.Id = Id;
                student.Naam = Naam;
                student.Opleiding = Opleiding;
                student.Leeftijd = Leeftijd;
            _context.SaveChanges();
            return Redirect("Index");

            }

        public ActionResult Delete(int Id)
        {
            var student = _context.Student.Where(h => h.Id == Id).FirstOrDefault();
            return View(student);
           
        }

        public ActionResult IsDelete(int Id)
        {

            var student = _context.Student.Where(h => h.Id == Id).FirstOrDefault();
            _context.Student.Remove(student);
            _context.SaveChanges();

            return Redirect("Index");
        }

        public ActionResult Details(int Id)
        {
            var student = _context.Student.Where(h => h.Id == Id).FirstOrDefault();
            return View(student);

        }


    }
    }








