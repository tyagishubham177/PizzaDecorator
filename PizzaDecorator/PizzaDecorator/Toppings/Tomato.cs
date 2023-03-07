using PizzaDecorator.Base;

namespace PizzaDecorator.Toppings
{
    internal class Tomato : ToppingDecorator
{
    public Tomato(Pizza pizza) : base(pizza)
    {
        description = " + Tomato";
    }

    public override double GetCost()
    {
        return pizza.GetCost() + 30;
    }
}
}
