using Game_Sim.Model;
using Game_Sim.Products;

namespace Game_Sim.MaterialProvider
{
    public abstract class Farm : IProducer
    {
    
        public string Name { get; protected set; }
        public Position Position { get; set; }

        public Farm(string name, Position position)
        {
            Name = name;
            Position = position;
        }

        public abstract List<Product> GetProducedGoods();

        public virtual void DisplayProductionInfo()
        {
            Console.WriteLine($"--- {Name} ---");
            Console.WriteLine($"Location: {Position}");
            Console.WriteLine("Produces:");
            foreach (var good in GetProducedGoods())
            {
                Console.WriteLine($"- {good.Name}");
            }
        }
    }
}
