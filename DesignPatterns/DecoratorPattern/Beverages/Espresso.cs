using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Beverages
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            base.Description += "Espresso";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}