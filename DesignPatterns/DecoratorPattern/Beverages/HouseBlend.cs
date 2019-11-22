using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Beverages
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            base.Description += "House Blend Coffee";
        }

        public override double Cost()
        {
            return .89;
        }
    }
}