using Game_Sim.Model;
using Game_Sim.Products;

public class DairyA : Dairy
{
    public DairyA() : base("DairyA", new Position(3, 1)) { }

    public override List<Product> GetProducedGoods()
    {
        return new List<Product> { new ChickenMeat(), new Egg() };
    }
}
