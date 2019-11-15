using StrategyPattern.Behavior;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Characters
{
    public class Knight : Character
    {
        public Knight()
        {
            Console.WriteLine("I'm a Knight!");
            SetWeapon(new SwordBehavior());
        }
    }
}