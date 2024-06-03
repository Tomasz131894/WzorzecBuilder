using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorzecBuilder
{
    // Interfejs budowniczego
    interface IPizzaBuilder
    {
        void BuildDough();
        void AddToppings();
        Pizza GetPizza();
    }
}
