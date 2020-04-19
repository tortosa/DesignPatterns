using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class NYStyleMargheritaPizza : Pizza
    {
        public NYStyleMargheritaPizza()
        {
            name = "NewYork Style Deep Dish Cheese Pizza";
            dough = "Normal Dough";
            sauce = "Plum Tomato Sauce";

            toppings.Add("Extra Cheese");
        }
    }
}