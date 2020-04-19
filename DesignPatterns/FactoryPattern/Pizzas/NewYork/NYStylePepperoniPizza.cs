using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class NYStylePepperoniPizza : Pizza
    {
        public NYStylePepperoniPizza()
        {
            name = "NewYork Style Pepperoni Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Tomato Sauce";

            toppings.Add("White Cheddar");
            toppings.Add("Honey");
            toppings.Add("Pepperoni");
        }
    }
}