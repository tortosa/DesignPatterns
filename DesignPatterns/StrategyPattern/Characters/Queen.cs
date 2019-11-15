using StrategyPattern.Behavior;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Characters
{
    public class Queen : Character
    {
        public Queen()
        {
            Console.WriteLine("I'm a Queen!");
            SetWeapon(new KnifeBehavior());
        }
    }
}