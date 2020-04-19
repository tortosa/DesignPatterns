using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            name = "NY Style Sauce and Cheese Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";

            toppings.Add("Grated Reggiano Cheese");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices ");
        }
    }
}