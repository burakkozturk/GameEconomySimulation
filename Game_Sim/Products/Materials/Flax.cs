using Game_Sim.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Sim.Products.Materials
{
    public class Flax : Product
    {
        public override string Name => "Flax";

        public override ProductCategory Category => ProductCategory.Crop;

        public override double Weight => 0.05;
        public override double Volume => 0.02;
        public override bool IsPerishable => true;
        public override int ShelfLifeDays => 7;
    }
}
