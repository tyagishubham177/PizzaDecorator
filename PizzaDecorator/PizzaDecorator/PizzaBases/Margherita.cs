using PizzaDecorator.Base;

namespace PizzaDecorator.PizzaBases
{
    internal class Margherita : Pizza
    {
        public Margherita()
        {
            description = "Margherita";
        }

        public override double GetCost()
        {
            return 200;
        }
    }
}
