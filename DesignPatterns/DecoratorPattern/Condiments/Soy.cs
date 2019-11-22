using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments
{
    public class Soy : CondimentDecorator
    {
        private readonly Beverage beverage;

        public override string Description => beverage.Description + ", Soy";

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            return .15 + beverage.Cost();
        }
    }
}