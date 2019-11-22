using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Beverages
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            base.Description += "Dark Roast Coffee";
        }

        public override double Cost()
        {
            return .99;
        }
    }
}