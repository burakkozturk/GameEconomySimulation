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
    public class FarmD : Farm
    {
        public FarmD() : base("FarmD", new Position(3, 3)) { }

        public override List<Product> GetProducedGoods()
        {
            return new List<Product>
            {
                new Grape()
            };
        }
    }
}
