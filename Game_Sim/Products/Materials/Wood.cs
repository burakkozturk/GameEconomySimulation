using Game_Sim.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Sim.Products.Materials
{
    public class Wood : Product
    {

        public override string Name => "Wood";

        public override ProductCategory Category => ProductCategory.Wood;



        public override double Weight => 10.0;
        public override bool IsPerishable => false;
    }
}
