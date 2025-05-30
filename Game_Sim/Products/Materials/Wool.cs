﻿using Game_Sim.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Sim.Products.Materials
{
    public class Wool:Product
    {
        public override string Name => "Wool";
        public override ProductCategory Category => ProductCategory.AnimalProduct;

        public override double Weight => 8.0;
        public override bool IsPerishable => true;

        public override int ShelfLifeDays => 365;


    }
}
