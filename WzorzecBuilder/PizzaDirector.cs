using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorzecBuilder
{
    class PizzaDirector
    {
        private IPizzaBuilder _pizzaBuilder;

        public PizzaDirector(IPizzaBuilder pizzaBuilder)
        {
            _pizzaBuilder = pizzaBuilder;
        }

        public void MakePizza()
        {
            _pizzaBuilder.BuildDough();
            _pizzaBuilder.AddToppings();
        }
    }
}
