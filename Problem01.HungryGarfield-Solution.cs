using System;

class HungryGarfield
{
    static void Main(string[] args)
    {
        decimal totalMoney = decimal.Parse(Console.ReadLine());
        decimal rate = decimal.Parse(Console.ReadLine());
        decimal pizzaPrize = decimal.Parse(Console.ReadLine()) / rate;
        decimal lasagnaPrize = decimal.Parse(Console.ReadLine()) / rate;
        decimal sandwichPrize = decimal.Parse(Console.ReadLine()) / rate;
        uint pizzaQuantity = uint.Parse(Console.ReadLine());
        uint lasagnaQuantity = uint.Parse(Console.ReadLine());
        uint sandwitchQuantity = uint.Parse(Console.ReadLine());

        decimal spentForPizza = pizzaPrize * pizzaQuantity;
        decimal spentForLasagna = lasagnaPrize * lasagnaQuantity;
        decimal spentForSandwiches = sandwichPrize * sandwitchQuantity;

        decimal totalNeeded = spentForPizza + spentForLasagna + spentForSandwiches;

        if (totalMoney - totalNeeded >= 0)
        {
            Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:f2}.", totalMoney - totalNeeded);

        }
        else
        {
            Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:f2}.",
                Math.Abs(totalMoney - totalNeeded));
        }
    }
}
}
