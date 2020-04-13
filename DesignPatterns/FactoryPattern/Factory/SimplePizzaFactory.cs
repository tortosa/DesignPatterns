using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string type)
        {
            Pizza pizza = new MargheritaPizza();

            if (type.Equals("cheese", StringComparison.InvariantCultureIgnoreCase))
            {
                pizza = new CheesePizza();
            }
            else if (type.Equals("greek", StringComparison.InvariantCultureIgnoreCase))
            {
                pizza = new GreekPizza();
            }
            else if (type.Equals("pepperoni", StringComparison.InvariantCultureIgnoreCase))
            {
                pizza = new PepperoniPizza();
            }

            return pizza;
        }
    }
}