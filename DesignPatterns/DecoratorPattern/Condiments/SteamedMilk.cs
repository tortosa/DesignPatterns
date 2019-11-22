using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments
{
    public class SteamedMilk : CondimentDecorator
    {
        private readonly Beverage beverage;
        public override string Description => beverage.Description + ", Steamed Milk";

        public SteamedMilk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            return .10 + beverage.Cost();
        }
    }
}