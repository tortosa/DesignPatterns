using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyPizzaStore = new NYStylePizzaStore();
            PizzaStore chicagoPizzaStore = new ChicagoStylePizzaStore();

            PizzaType[] pizzaTypes = { PizzaType.Cheese, PizzaType.Greek, PizzaType.Pepperoni };

            foreach (var type in pizzaTypes)
            {
                nyPizzaStore.OrderPizza(type);
                Console.WriteLine("-----------------");
                chicagoPizzaStore.OrderPizza(type);
            }
        }
    }
}