using Game_Sim.Model;

public class CityC : City
{
    public CityC() : base("CityC", 750, new Position(-1, 8))
    {
    }

    public override void DisplayStatus()
    {
        base.DisplayStatus();
        Console.WriteLine("CityC ");
    }
}