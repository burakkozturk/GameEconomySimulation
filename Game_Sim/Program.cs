using Game_Sim.Model;
using Game_Sim.Products;
using Game_Sim.World.Processors;
using Game_Sim.World.Producers;

class Program
{
    static void Main(string[] args)
    {
        // Create cities
        var cityA = new CityA();
        var cityB = new CityB();

        // Create producers
        var dairyA = new DairyA();
        var mineA = new MineA();
        var dairyB = new DairyB();

        // Add producers to cities
        cityA.AddProducer(dairyA);
        cityB.AddProducer(mineA);
        cityB.AddProducer(dairyB);

        // Display city information
        Console.WriteLine("==== Cities Status ====");
        cityA.DisplayStatus();
        Console.WriteLine();
        cityB.DisplayStatus();

        Console.WriteLine("\n==== Producers Information ====");
        dairyA.DisplayProductionInfo();
        Console.WriteLine();
        mineA.DisplayProductionInfo();
        Console.WriteLine();
        dairyB.DisplayProductionInfo();

        // Demonstrate processor functionality
        Console.WriteLine("\n==== Processing Example ====");
        var bakery = new BakeryA();

        // Inventory including all products
        var inventory = new List<Product>
        {
            new Wheat(), new Wheat(), new Wheat(), new Wheat(),
            new Egg(), new Egg(),
            new Iron(),
            new Steak(),
            new Leather(),
            new Milk()
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

        // Sample distance calculation
        Console.WriteLine("\n==== Distance Information ====");
        Console.WriteLine($"Distance between CityA and CityB: {cityA.Position.DistanceTo(cityB.Position)} km");
        Console.WriteLine($"Distance between DairyA and CityA: {dairyA.Position.DistanceTo(cityA.Position)} km");
        Console.WriteLine($"Distance between DairyB and CityB: {dairyB.Position.DistanceTo(cityB.Position)} km");
        Console.WriteLine($"Distance between MineA and CityB: {mineA.Position.DistanceTo(cityB.Position)} km");
    }
}