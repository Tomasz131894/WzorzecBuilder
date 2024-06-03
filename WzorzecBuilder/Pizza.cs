using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorzecBuilder
{
    // Produkt - Pizza
    class Pizza
    {
        public string Dough { get; set; }
        public List<string> Toppings { get; set; }

        public Pizza()
        {
            Toppings = new List<string>();
        }

        public void Display()
        {
            Console.WriteLine("Pizza with " + Dough + " dough and the following toppings:");
            foreach (var topping in Toppings)
            {
                Console.WriteLine("- " + topping);
            }
        }
    }
}
