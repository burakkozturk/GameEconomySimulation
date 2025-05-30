﻿using Game_Sim.Model;
using Game_Sim.Products;
using Game_Sim.MaterialProvider;
using Game_Sim.Products.Materials;

namespace Game_Sim.World.MaterialProviders
{
    public class FarmB : Farm
    {
        public FarmB() : base("FarmB", new Position(-2, -4)) { }

        public override List<Product> GetProducedGoods()
        {
            return new List<Product>
            {
                new Grape()
            };
        }
    }
}
