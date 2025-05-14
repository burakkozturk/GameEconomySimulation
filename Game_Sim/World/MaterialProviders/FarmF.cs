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
    internal class FarmF : Farm
    {
        public FarmF() : base("FarmG", new Position(15, 3)) { }

        public override List<Product> GetProducedGoods()
        {
            return new List<Product>
            {
                new Barley()
            };
        }
    }
}
