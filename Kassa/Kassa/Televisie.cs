using System;
using System.Collections.Generic;
using System.Text;

namespace Kassa
{

        class Televisie : IProduct
        {
            string naam { set; get; }
            double prijs { set; get; }

            public Televisie(string Naam, double Prijs)
            {
                this.naam = Naam;
                this.prijs = Prijs;
            }

            public string Naam()
            {
                return naam;
            }

            public double Prijs()
            {
                return prijs;
            }

            override
            public string ToString()
            {
                return naam + " - " + prijs;
            }


        }
    }

