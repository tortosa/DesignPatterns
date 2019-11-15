using StrategyPattern.Behavior;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Characters
{
    public abstract class Character
    {
        WeaponBehavior weapon;

        public void Fight()
        {
            weapon.UseWeapon();
        }

        public void SetWeapon(WeaponBehavior weapon)
        {
            this.weapon = weapon;
        }
    }
}