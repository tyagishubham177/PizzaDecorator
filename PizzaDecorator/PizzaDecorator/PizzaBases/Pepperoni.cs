using PizzaDecorator.Base;

namespace PizzaDecorator.PizzaBases
{
    internal class Pepperoni : Pizza
    {
        public Pepperoni()
        {
            description = "Pepperoni";
        }

        public override double GetCost()
        {
            return 180;
        }
    }
}
