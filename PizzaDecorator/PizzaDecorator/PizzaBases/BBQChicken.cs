using PizzaDecorator.Base;

namespace PizzaDecorator.PizzaBases
{
    internal class BBQChicken : Pizza
    {
        public BBQChicken()
        {
            description = "BBQChicken";
        }

        public override double GetCost()
        {
            return 200;
        }
    }
}
