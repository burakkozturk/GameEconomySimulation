﻿using Game_Sim.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Sim.Products.Materials
{
    public class Fish : Product
    {
        public override string Name => "Fish";

        public override ProductCategory Category => ProductCategory.AnimalProduct;

        public override double Weight => 0.8;
        public override bool IsPerishable => true;
        public override int ShelfLifeDays => 3;
    }
}
