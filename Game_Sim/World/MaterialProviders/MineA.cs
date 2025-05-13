using Game_Sim.Model;
using Game_Sim.Products;

namespace Game_Sim.World.Producers
{
    public class MineA : Mine
    {
        public MineA() : base("MineA", new Position(4, 3)) { }

        public override List<Product> GetProducedGoods()
        {
            return new List<Product> { new Iron() };
        }

        public override void DisplayProductionInfo()
        {
            base.DisplayProductionInfo();
            Console.WriteLine("MineA is a rich iron deposit that supplies nearby cities.");
        }
    }
}