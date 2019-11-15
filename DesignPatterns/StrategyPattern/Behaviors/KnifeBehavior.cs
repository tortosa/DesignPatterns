using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Behavior
{
    public class KnifeBehavior : WeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Using a Knife! Sphhhlt! Sphhhlt!");
        }
    }
}