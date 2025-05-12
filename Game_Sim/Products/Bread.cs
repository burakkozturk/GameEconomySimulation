using Game_Sim.Model;

public class Bread : Product
{
    public override string Name => "Bread";
    public override ProductCategory Category => ProductCategory.Crop;

    public override double Weight => 0.3;
    public override double Volume => 0.25;
    public override bool IsPerishable => true;
    public override int ShelfLifeDays => 3;
    public override double BasePrice => 4.0;
}
