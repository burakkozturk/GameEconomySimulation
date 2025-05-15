using Game_Sim.Model;
using Game_Sim.Producer;
using Game_Sim.Products.Materials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Sim.World.MaterialProviders
{
    public class FishingDockA : FishingDock
    {

        public FishingDockA() : base("HarborA", new Position(-6, 20)) { } 
        public override List<Product> GetProducedGoods()
        {
            return new List<Product> { new Fish() }; // will update
        }
    }
}
