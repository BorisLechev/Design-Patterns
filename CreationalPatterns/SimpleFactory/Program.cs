using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var coffeeFactory = new CoffeeFactory();
            var cappuccino = coffeeFactory.GetCoffee(CoffeeType.Cappuccino);
            var regularCoffee = coffeeFactory.GetCoffee(CoffeeType.Regular);

            Console.WriteLine($"Cappuccino - Milk Content: {cappuccino.MilkContent} ml, Coffee Content: {cappuccino.CoffeeContent} ml.");
            Console.WriteLine($"Regular coffee - Milk Content: {regularCoffee.MilkContent} ml, Coffee Content: {regularCoffee.CoffeeContent} ml.");
        }
    }
}
