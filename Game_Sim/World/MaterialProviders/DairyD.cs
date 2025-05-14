using Game_Sim.Model;
using Game_Sim.Products.Materials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Sim.World.Producers
{
    public class DairyD : Dairy
    {
        public DairyD() : base("DairyD", new Position(2, 18)) { }

        public override List<Product> GetProducedGoods()
        {
            return new List<Product> {
                new Steak(),
                new Leather(),
                new Milk() 
            };
        }

        public override void DisplayProductionInfo()
        {
            base.DisplayProductionInfo();
            Console.WriteLine("DairyD is a cattle farm that specializes in beef and dairy production.");
            Console.WriteLine("It also processes leather from cattle hides.");
        }
    }
}
