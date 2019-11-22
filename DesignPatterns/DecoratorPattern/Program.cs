using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;
using System;
using System.Text;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Default;

            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.Description + " - Price: " + beverage.Cost() + " €");

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);

            Console.WriteLine(beverage2.Description + " - Price: " + beverage2.Cost() + " €");

            Beverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);

            Console.WriteLine(beverage3.Description + " - Price: " + beverage3.Cost() + " €");
        }
    }
}
