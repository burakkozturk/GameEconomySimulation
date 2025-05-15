using Game_Sim.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Sim.Products.Materials
{
    public class Log : Product
    {
        public override string Name => "Log";

        public override ProductCategory Category => ProductCategory.Wood;



        public override double Weight => 75.0;
        public override bool IsPerishable => false;
    }
}
