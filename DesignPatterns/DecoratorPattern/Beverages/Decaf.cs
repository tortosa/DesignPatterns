﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Beverages
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            base.Description += "Decaf";
        }

        public override double Cost()
        {
            return 1.05;
        }
    }
}