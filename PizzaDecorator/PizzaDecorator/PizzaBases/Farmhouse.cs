using PizzaDecorator.Base;

namespace PizzaDecorator.PizzaBases
{
    internal class Farmhouse : Pizza
    {
        public Farmhouse()
        {
            description = "Farmhouse";
        }

        public override double GetCost()
        {
            return 150;
        }
    }
}
