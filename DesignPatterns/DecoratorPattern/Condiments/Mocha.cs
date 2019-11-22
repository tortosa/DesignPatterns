using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments
{
    public class Mocha : CondimentDecorator
    {
        private readonly Beverage beverage;

        public override string Description => beverage.Description + ", Mocha";

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            return .20 + beverage.Cost();
        }
    }
}