using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class NYStyleGreekPizza : Pizza
    {
        public NYStyleGreekPizza()
        {
            name = "NewYork Style Greek Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Plum Tomato Sauce";

            toppings.Add("White Cheddar");
        }
    }
}