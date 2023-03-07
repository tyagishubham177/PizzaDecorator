using PizzaDecorator.Base;
using PizzaDecorator.PizzaBases;
using PizzaDecorator.Toppings;
using System.Diagnostics;

namespace PizzaDecorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pizza p = new Paneer(new Cheese(new Tomato(new BBQChicken())));
            Console.WriteLine(p.GetCost());
            Console.WriteLine(p.GetDescription());
        }
    }
}