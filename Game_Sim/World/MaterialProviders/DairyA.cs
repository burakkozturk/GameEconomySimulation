using Game_Sim.Model;
using Game_Sim.Products;
using Game_Sim.Products.Materials;

public class DairyA : Dairy
{
    public DairyA() : base("DairyA", new Position(-4, -5)) { }

    public override List<Product> GetProducedGoods()
    {
        return new List<Product> { new ChickenMeat(), new Egg() };
    }
}
