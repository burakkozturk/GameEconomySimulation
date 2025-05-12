using Game_Sim.Model;

namespace Game_Sim.Model
{
    public abstract class Processor
    {
        public string Name { get; protected set; }
        public Position Position { get; set; }

        public Processor(string name, Position position)
        {
            Name = name;
            Position = position;
        }

        public abstract bool CanProcess(List<Product> inputInventory);
        public abstract List<Product> Process(ref List<Product> inputInventory);

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"--- {Name} ---");
            Console.WriteLine($"Location: {Position}");
        }
    }
}
