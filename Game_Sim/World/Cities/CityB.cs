using Game_Sim.Model;

public class CityB : City
{
    public CityB() : base("CityB", 750, new Position(13, 1))
    {
    }

    public override void DisplayStatus()
    {
        base.DisplayStatus();
        Console.WriteLine("CityB is known for its mining operations.");
    }
}