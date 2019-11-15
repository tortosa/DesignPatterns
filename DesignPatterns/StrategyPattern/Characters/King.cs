using StrategyPattern.Behavior;
using System;

namespace StrategyPattern.Characters
{
    public class King : Character
    {
        public King()
        {
            Console.WriteLine("I'm da King!");
            SetWeapon(new SwordBehavior());
        }
    }
}