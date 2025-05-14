using Game_Sim.Model;

public class CityE : City
{
    public CityE() : base("CityE", 750, new Position(-2, 18))
    {
    }

    public override void DisplayStatus()
    {
        base.DisplayStatus();
        Console.WriteLine("CityE ");
    }
}