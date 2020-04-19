using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class ChicagoStyleMargheritaPizza : Pizza
    {
        public ChicagoStyleMargheritaPizza()
        {
            name = "Chicago Style Deep Dish Cheese Pizza";
            dough = "Normal Dough";
            sauce = "Plum Tomato Sauce";
        }
    }
}