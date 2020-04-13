using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class NYStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = new NYStyleMargheritaPizza();

            if (type.Equals("cheese", StringComparison.InvariantCultureIgnoreCase))
            {
                pizza = new NYStyleCheesePizza();
            }
            else if (type.Equals("greek", StringComparison.InvariantCultureIgnoreCase))
            {
                pizza = new NYStyleGreekPizza();
            }
            else if (type.Equals("pepperoni", StringComparison.InvariantCultureIgnoreCase))
            {
                pizza = new NYStylePepperoniPizza();
            }

            return pizza;
        }
    }
}