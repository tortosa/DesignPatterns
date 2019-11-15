using StrategyPattern.Behavior;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Characters
{
    public class Troll : Character
    {
        public Troll()
        {
            Console.WriteLine("I'm a Troll!");
            SetWeapon(new BowAndArrowBehavior());
        }
    }
}