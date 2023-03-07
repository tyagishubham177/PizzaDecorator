using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDecorator.Base
{
    internal class ToppingDecorator : Pizza
    {
        protected Pizza pizza;

        public ToppingDecorator(Pizza pizza)
        {
            this.pizza = pizza;
        }

        public override double GetCost()
        {
            return pizza.GetCost();
        }

        public override string GetDescription()
        {
            return pizza.GetDescription() + description;
        }
    }
}
