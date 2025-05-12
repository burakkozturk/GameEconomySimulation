using Game_Sim.Model;

public class City
{
    public string Name { get; set; }
    public int Population { get; set; }
    public Position Position { get; set; }
    public List<IProducer> Producers { get; set; }

    public City(string name, int population, Position position)
    {
        Name = name;
        Population = population;
        Position = position;
        Producers = new List<IProducer>();
    }

    public void AddProducer(IProducer producer)
    {
        Producers.Add(producer);
    }

    public virtual void DisplayStatus()
    {
        Console.WriteLine($"--- {Name} ---");
        Console.WriteLine($"Population: {Population}");
        Console.WriteLine($"Position: {Position}");
        Console.WriteLine("Producers Nearby:");
        foreach (var producer in Producers)
        {
            Console.WriteLine($"- {producer.Name} at {producer.Position}");
        }
    }
}
