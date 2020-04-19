namespace FactoryPattern
{
    public class NYStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaType type)
        {
            Pizza pizza = type switch
            {
                PizzaType.Cheese => new NYStyleCheesePizza(),
                PizzaType.Greek => new NYStyleGreekPizza(),
                PizzaType.Pepperoni => new NYStylePepperoniPizza(),
                _ => new NYStyleMargheritaPizza(),
            };
            return pizza;
        }
    }
}