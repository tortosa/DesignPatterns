using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            new PizzaStore(new SimplePizzaFactory()).OrderPizza("Cheese");
        }
    }
}