using Game_Sim.Model;
using Game_Sim.Products;

namespace Game_Sim.World.Processors
{
    public class BakeryA : Processor
    {
        public BakeryA() : base("BakeryA", new Position(0, 0)) { }

        public override bool CanProcess(List<Product> inputInventory)
        {
            int wheat = inputInventory.Count(p => p is Wheat);
            int egg = inputInventory.Count(p => p is Egg);
            return wheat >= 3 && egg >= 1;
        }

        public override List<Product> Process(ref List<Product> inputInventory)
        {
            if (!CanProcess(inputInventory))
                return new List<Product>();

            int wheatUsed = 0, eggUsed = 0;

            inputInventory.RemoveAll(p =>
            {
                if (p is Wheat && wheatUsed < 3) { wheatUsed++; return true; }
                if (p is Egg && eggUsed < 1) { eggUsed++; return true; }
                return false;
            });

            return new List<Product> { new Bread() };
        }
    }
}
