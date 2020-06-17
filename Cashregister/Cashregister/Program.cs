using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Cashregister
{
    public class Program
    {
        static void Main(string[] args)
        {

            Kassasysteem kassasysteem = new Kassasysteem();
            Redbull redbull = new Redbull("blauw", 61);
            Televisie televisie = new Televisie("sony", 40);

            kassasysteem.AddProduct(redbull);
            kassasysteem.AddProduct(televisie);

            kassasysteem.ShowProduct();
            Console.ReadLine();
        }


        [Fact]
        public void PassingTest()
        {
            Kassasysteem kassasysteem = new Kassasysteem();
            Redbull inst = new Redbull("Bosbessen", 60);
            Televisie inst2 = new Televisie("Panasonic", 200);

            kassasysteem.AddProduct(inst);
            kassasysteem.AddProduct(inst2);


            double expected = 260;
            Assert.Equal(expected, kassasysteem.GetTotaalPrijs());
        }

    }

}
