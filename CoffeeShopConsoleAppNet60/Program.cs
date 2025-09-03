using CoffeeShopConsoleAppNet60;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Coffee> coffeeList = new List<Coffee>();

        coffeeList.Add(new Latte(0));
        coffeeList.Add(new Cortado(0));
        coffeeList.Add(new BlackCoffee(0.1f));

        foreach(Coffee coffee in coffeeList)
        {
            Console.WriteLine(coffee.GetType());
            Console.WriteLine(coffee.Price);
            Console.WriteLine(coffee.strength);

            if(coffee is IMilk milkCoffee)
            {
                Console.WriteLine(milkCoffee.mlMilk);
            }
        }
    }
}