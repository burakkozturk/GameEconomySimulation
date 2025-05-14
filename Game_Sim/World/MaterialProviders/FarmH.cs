using Game_Sim.MaterialProvider;
using Game_Sim.Model;
using Game_Sim.Products.Materials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Sim.World.MaterialProviders
{
    public class FarmH : Farm
    {
        public FarmH() : base("FarmH", new Position(10 , 9))
        {
        }

        public override List<Product> GetProducedGoods()
        {
            return new List<Product>
            {
                new Wheat()
            };
        }
    }
}
