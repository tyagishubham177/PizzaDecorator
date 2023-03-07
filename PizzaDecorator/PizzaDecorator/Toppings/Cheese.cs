using PizzaDecorator.Base;

namespace PizzaDecorator.Toppings
{
    internal class Cheese : ToppingDecorator
    {
        public Cheese(Pizza pizza) : base(pizza)
        {
            description = " + Cheese";
        }

        public override double GetCost()
        {
            return pizza.GetCost() + 80;
        }
    }
}
