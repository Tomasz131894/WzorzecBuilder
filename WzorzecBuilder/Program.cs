using System;
using System.Collections.Generic;



namespace WzorzecBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tworzenie budowniczego
            IPizzaBuilder pizzaBuilder = new PizzaBuilder();

            // Tworzenie dyrektora
            PizzaDirector pizzaDirector = new PizzaDirector(pizzaBuilder);

            // Wywołanie dyrektora, aby zbudować pizzę
            pizzaDirector.MakePizza();

            // Pobranie ukończonej pizzy od budowniczego
            Pizza pizza = pizzaBuilder.GetPizza();

            // Wyświetlenie zbudowanej pizzy
            pizza.Display();
        }
    }
}
