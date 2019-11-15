using StrategyPattern.Behavior;
using StrategyPattern.Characters;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character = new Knight();
            character.Fight();
            character.SetWeapon(new BowAndArrowBehavior());
            character.Fight();

            character = new King();
            character.Fight();
            character.SetWeapon(new KnifeBehavior());
            character.Fight();
        }
    }
}