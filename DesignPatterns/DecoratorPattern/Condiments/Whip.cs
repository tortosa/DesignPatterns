using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments
{
    public class Whip : CondimentDecorator
    {
        private readonly Beverage beverage;

        public override string Description => beverage.Description + ", Whip";

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            return .10 + beverage.Cost();
        }
    }
}