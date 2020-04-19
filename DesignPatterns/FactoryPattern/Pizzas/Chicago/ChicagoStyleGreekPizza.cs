using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class ChicagoStyleGreekPizza : Pizza
    {
        public ChicagoStyleGreekPizza()
        {
            name = "Chicago Style Greek Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Marinara Sauce";

            toppings.Add("Roasted red pepper");
        }
    }
}