using Game_Sim.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Sim.Producer
{
    public abstract class FishingDock : IProducer
    {
        public String Name { get; protected set; }
        public Position Position { get; set; }

        public FishingDock(string name, Position position) {
            Name = name;
            Position = position;
        }

        public abstract List<Product> GetProducedGoods();
        

        public void DisplayProductionInfo()
        {
            Console.WriteLine($"--- {Name} ---");
            Console.WriteLine($"Location: {Position}");
            Console.WriteLine("Extracts:");
            foreach (var good in GetProducedGoods())
            {
                Console.WriteLine($"- {good.Name}");
            }
        }
    }
}
