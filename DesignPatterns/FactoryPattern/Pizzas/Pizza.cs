using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public interface Pizza
    {
        void Prepare();
        void Bake();
        void Cut();
        void Box();
    }
}