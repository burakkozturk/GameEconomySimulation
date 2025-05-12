using Game_Sim.Model;
using Game_Sim.Products;
using Game_Sim.MaterialProvider;

namespace Game_Sim.World.MaterialProviders
{
    public class FarmA : Farm
    {
        public FarmA() : base("FarmA", new Position(-2, -1)) { }

        public override List<Product> GetProducedGoods()
        {
            return new List<Product>
            {
                new Wheat(),
                new Barley(),
                new Corn()
            };
        }
    }
}
