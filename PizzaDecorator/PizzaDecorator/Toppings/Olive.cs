using PizzaDecorator.Base;

namespace PizzaDecorator.Toppings
{
    internal class Olive : ToppingDecorator
    {
        public Olive(Pizza pizza) : base(pizza)
        {
            description = " + Olive";
        }

        public override double GetCost()
        {
            return pizza.GetCost() + 20;
        }
    }
}
