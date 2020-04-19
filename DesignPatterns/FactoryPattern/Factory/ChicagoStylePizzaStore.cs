using System;

namespace FactoryPattern
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaType type)
        {
            Pizza pizza = type switch
            {
                PizzaType.Cheese => new ChicagoStyleCheesePizza(),
                PizzaType.Greek => new ChicagoStyleGreekPizza(),
                PizzaType.Pepperoni => new ChicagoStylePepperoniPizza(),
                _ => new ChicagoStyleMargheritaPizza(),
            };
            return pizza;
        }
    }
}