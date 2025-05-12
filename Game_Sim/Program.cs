using Game_Sim.Model;
using Game_Sim.Products;
using Game_Sim.World.Processors;

class Program
{
    static void Main(string[] args)
    {
        var bakery = new BakeryA();

        // Envanter: 4 Wheat, 2 Egg
        var inventory = new List<Product>
        {
            new Wheat(), new Wheat(), new Wheat(), new Wheat(),
            new Egg(), new Egg()
        };

        bakery.DisplayInfo();

        if (bakery.CanProcess(inventory))
        {
            var output = bakery.Process(ref inventory);
            Console.WriteLine("\nProduced:");
            foreach (var item in output)
                Console.WriteLine($"- {item.Name}");
        }
        else
        {
            Console.WriteLine("Not enough ingredients to produce Bread.");
        }

        Console.WriteLine("\nRemaining Inventory:");
        foreach (var item in inventory)
            Console.WriteLine($"- {item.Name}");
    }
}
