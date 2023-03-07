namespace PizzaDecorator.Base
{
    internal abstract class Pizza
    {
        protected string description;

        public virtual string GetDescription()
        {
            return description;
        }

        public abstract double GetCost();
    }
}
