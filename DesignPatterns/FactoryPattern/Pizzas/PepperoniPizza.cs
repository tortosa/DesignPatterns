using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class PepperoniPizza : Pizza
    {
        public void Bake()
        {
           Console.WriteLine("Bake " + this.GetType().Name);
        }

        public void Box()
        {
           Console.WriteLine("Box " + this.GetType().Name);
        }

        public void Cut()
        {
            Console.WriteLine("Cut " + this.GetType().Name);
        }

        public void Prepare()
        {
            Console.WriteLine("Prepare " + this.GetType().Name);
        }
    }
}