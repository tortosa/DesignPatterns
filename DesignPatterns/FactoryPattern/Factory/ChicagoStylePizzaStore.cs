using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = new ChicagoStyleMargheritaPizza();

            if (type.Equals("cheese", StringComparison.InvariantCultureIgnoreCase))
            {
                pizza = new ChicagoStyleCheesePizza();
            }
            else if (type.Equals("greek", StringComparison.InvariantCultureIgnoreCase))
            {
                pizza = new ChicagoStyleGreekPizza();
            }
            else if (type.Equals("pepperoni", StringComparison.InvariantCultureIgnoreCase))
            {
                pizza = new ChicagoStylePepperoniPizza();
            }

            return pizza;
        }
    }
}