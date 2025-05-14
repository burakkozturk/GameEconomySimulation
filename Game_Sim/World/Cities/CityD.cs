using Game_Sim.Model;

public class CityD : City
{
    public CityD() : base("CityD", 750, new Position(10, 11))
    {
    }

    public override void DisplayStatus()
    {
        base.DisplayStatus();
        Console.WriteLine("CityD ");
    }
}