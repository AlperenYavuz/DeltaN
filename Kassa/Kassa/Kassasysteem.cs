using System;
using System.Collections.Generic;
using System.Text;

namespace Kassa
{
    class Kassasysteem
    {
        private List<IProduct> producten = new List<IProduct>();

        public void AddProduct(IProduct product)
        {
            producten.Add(product);
        }

        public void ShowProduct()
        {
            foreach (IProduct product in producten)
            {
                Console.WriteLine(product);
            }
        }

        public List<IProduct> GetProducten()
        {
            return producten;
        }

        public double GetTotaalPrijs()
        {
            double totaalPrijs = 0;
            foreach (IProduct product in producten)
            {
                totaalPrijs += product.Prijs();
            }
            return totaalPrijs;
        }
    }
}
