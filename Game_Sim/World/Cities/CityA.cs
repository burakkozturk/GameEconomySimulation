using Game_Sim.Model;

public class CityA : City
{
    public CityA() : base("CityA", 1000, new Position(0, 0))
    {
    }

    public override void DisplayStatus()
    {
        base.DisplayStatus();
        Console.WriteLine("CityA is the capital of trade.");
    }
}
