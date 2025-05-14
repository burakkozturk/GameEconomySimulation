using Game_Sim.Model;
using Game_Sim.Products.Materials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Game_Sim.World.Producers
{
    public class DairyC : Dairy
    {
        public DairyC() : base("DairyC", new Position(-5, 14)) { }

        public override List<Product> GetProducedGoods()
        {
            return new List<Product> {
                new Mutton(),
                new Wool() 
            };
        }

        public override void DisplayProductionInfo()
        {
            base.DisplayProductionInfo();
            Console.WriteLine("DairyC is a cattle farm that specializes in beef and dairy production.");
            Console.WriteLine("It also processes leather from cattle hides.");
        }
    }
}