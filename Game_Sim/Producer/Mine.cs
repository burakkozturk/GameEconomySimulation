using Game_Sim.Model;

namespace Game_Sim.Model
{
    public abstract class Mine : IProducer
    {
        public string Name { get; protected set; }
        public Position Position { get; set; }

        public Mine(string name, Position position)
        {
            Name = name;
            Position = position;
        }

        public abstract List<Product> GetProducedGoods();

        public virtual void DisplayProductionInfo()
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