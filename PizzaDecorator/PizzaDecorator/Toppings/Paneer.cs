using PizzaDecorator.Base;

namespace PizzaDecorator.Toppings
{
    internal class Paneer : ToppingDecorator
    {
        public Paneer(Pizza pizza) : base(pizza)
        {
            description = " + Paneer";
        }

        public override double GetCost()
        {
            return pizza.GetCost() + 60;
        }
    }
}
