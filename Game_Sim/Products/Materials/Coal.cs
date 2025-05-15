using Game_Sim.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Sim.Products.Materials
{
    public class Coal : Product
    {
        public override string Name => "Coal";

        public override ProductCategory Category => ProductCategory.Ore;


        public override double Weight => 15.0;
        public override bool IsPerishable => false;
    }
}
