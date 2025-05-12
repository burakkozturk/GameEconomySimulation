using Game_Sim.Model;

public abstract class Dairy : IProducer { 

    public string Name { get; protected set; }
    public Position Position { get; set; }

    public Dairy(string name, Position position)
    {
        Name = name;
        Position = position;
    }

    public abstract List<Product> GetProducedGoods();

    public virtual void DisplayProductionInfo()
    {
        Console.WriteLine($"--- {Name} ---");
        Console.WriteLine($"Location: {Position}");
        Console.WriteLine("Produces:");
        foreach (var good in GetProducedGoods())
        {
            Console.WriteLine($"- {good.Name}");
        }
    }
}
