﻿using Game_Sim.Model;

namespace Game_Sim.Products.Materials
{
    public class Iron : Product
    {
        public override string Name => "Iron";
        public override ProductCategory Category => ProductCategory.Ore;

        public override double Weight => 5.0;
        public override bool IsPerishable => false;
    }
}