using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Behavior
{
    public class SwordBehavior : WeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Using a Sword! Sphhhllash! Sphhhllash!");
        }
    }
}