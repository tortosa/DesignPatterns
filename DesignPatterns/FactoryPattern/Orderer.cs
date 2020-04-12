using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Orderer
    {
        public static Pizza OrderPizza(string type)
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

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}