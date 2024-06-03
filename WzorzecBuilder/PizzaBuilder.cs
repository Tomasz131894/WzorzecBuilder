using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorzecBuilder
{
    class PizzaBuilder : IPizzaBuilder
    {
        private Pizza _pizza;

        public PizzaBuilder()
        {
            _pizza = new Pizza();
        }

        public void BuildDough()
        {
            _pizza.Dough = "thin";
        }

        public void AddToppings()
        {
            _pizza.Toppings.Add("cheese");
            _pizza.Toppings.Add("pepperoni");
            _pizza.Toppings.Add("mushrooms");
        }

        public Pizza GetPizza()
        {
            return _pizza;
        }
    }
}
