﻿using Game_Sim.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Sim.Products.Materials
{
    public class Salt : Product
    {
        public override string Name => "Salt";

        public override ProductCategory Category => ProductCategory.Mineral;

        public override double Weight => 5.0;
        public override bool IsPerishable => false;
    }
}
