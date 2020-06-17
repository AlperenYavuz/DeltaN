using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using hotel.Models;

namespace hotel.Controllers
{
    public class AdministratieController : Controller
    {

        IList<Hotelboeking> reserveringen = new List<Hotelboeking>() {
                    new Hotelboeking(){ BoekingId = 1, Naam="Alperen", Telnummer=06123, Kamernummer = 61 },
                    new Hotelboeking(){ BoekingId = 2, Naam="Sema", Telnummer=06456, Kamernummer = 61 },
                    new Hotelboeking(){ BoekingId = 3, Naam="Elif", Telnummer=06678, Kamernummer = 61 },
                  
                };

        public ActionResult Index()
        {
            return View(reserveringen);
        }

        //Action voor het aanmaken van een hotelboeking
        [HttpPost]
        public IActionResult Create(int BoekingId, String Naam, int Kamernummer, int Telnummer)
        {

            reserveringen.Add(new Hotelboeking() { BoekingId = BoekingId, Naam = Naam, Telnummer = Telnummer, Kamernummer = Kamernummer });
    
            return View("Index", reserveringen);
        }

        //Action voor het bewerken van een hotelboeking
        public ActionResult Edit(int Id)
        {
            
            var boeking = reserveringen.Where(h => h.BoekingId == Id).FirstOrDefault();

            return View(boeking);
        }

        [HttpPost]
        public ActionResult isEdit(int BoekingId, String Naam, int Kamernummer, int Telnummer)
        {

            var boeking = reserveringen.Where(h => h.BoekingId == BoekingId).FirstOrDefault();
            boeking.BoekingId = BoekingId;
            boeking.Naam = Naam;
            boeking.Kamernummer= Kamernummer;
            boeking.Telnummer= Telnummer;

            return View("Index", reserveringen);
            
        }

        //Action om naar de reserveringspagina te gaan
        public ActionResult Reserveringspagina()
        {

            return View();

        }
    }
}