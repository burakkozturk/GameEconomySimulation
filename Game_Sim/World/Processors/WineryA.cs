using Game_Sim.Model;
using Game_Sim.Products;
using Game_Sim.Products.Materials;

namespace Game_Sim.World.Processors
{
    public class WineryA : Processor
    {
        public WineryA() : base("WineryA", new Position(0, 0)) { } // Şehire yakın bir konumda

        public override bool CanProcess(List<Product> inputInventory)
        {
            int grapeCount = inputInventory.Count(p => p is Grape);
            return grapeCount >= 5;  // 5 üzüme 1 şarap üretiyoruz
        }

        public override List<Product> Process(ref List<Product> inputInventory)
        {
            if (!CanProcess(inputInventory))
                return new List<Product>();

            // Malzeme Tüket (5 üzüme karşılık 1 şarap)
            int grapeUsed = 0;
            inputInventory.RemoveAll(p =>
            {
                if (p is Grape && grapeUsed < 5)
                {
                    grapeUsed++;
                    return true;
                }
                return false;
            });

            return new List<Product> { new Wine() };
        }
    }
}
