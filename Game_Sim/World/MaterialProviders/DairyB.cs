using Game_Sim.Model;
using Game_Sim.Products;

namespace Game_Sim.World.Producers
{
    public class DairyB : Dairy
    {
        public DairyB() : base("DairyB", new Position(6, 2.5)) { }

        public override List<Product> GetProducedGoods()
        {
            return new List<Product> { new Steak(), new Leather(), new Milk() };
        }

        public override void DisplayProductionInfo()
        {
            base.DisplayProductionInfo();
            Console.WriteLine("DairyB is a cattle farm that specializes in beef and dairy production.");
            Console.WriteLine("It also processes leather from cattle hides.");
        }
    }
}