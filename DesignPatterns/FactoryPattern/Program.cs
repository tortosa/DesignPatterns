using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyPizzaStore = new NYStylePizzaStore();
            nyPizzaStore.OrderPizza("Cheese");
            Console.WriteLine("-----------------");
            PizzaStore chicagoPizzaStore = new ChicagoStylePizzaStore();
            chicagoPizzaStore.OrderPizza("Cheese");
        }
    }
}