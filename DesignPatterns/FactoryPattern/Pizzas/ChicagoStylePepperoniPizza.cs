using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class ChicagoStylePepperoniPizza : Pizza
    {
        public ChicagoStylePepperoniPizza()
        {
            name = "Chicago Style Pepperoni Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Plum Tomato Sauce";

            toppings.Add("Bacon");
        }
    }
}