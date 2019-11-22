using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Beverages
{
    public abstract class Beverage
    {
        public virtual string Description { get; protected set; }

        public abstract double Cost();
    }
}