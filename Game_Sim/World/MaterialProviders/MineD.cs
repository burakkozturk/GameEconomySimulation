﻿using Game_Sim.Model;
using Game_Sim.Products.Materials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Sim.World.MaterialProviders
{
    public class MineD : Mine
    {
        public MineD() : base("MineC", new Position(10, 17)) { }

        public override List<Product> GetProducedGoods()
        {
            return new List<Product>
            {
                new Salt()
            };
        }
    }
}
