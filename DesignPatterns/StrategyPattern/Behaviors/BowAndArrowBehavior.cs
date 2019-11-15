using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Behavior
{
    public class BowAndArrowBehavior : WeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Using a Bow!  >·········->   swoooosh!");
        }
    }
}