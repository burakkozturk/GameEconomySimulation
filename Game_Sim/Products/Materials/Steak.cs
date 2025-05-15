using Game_Sim.Model;

namespace Game_Sim.Products.Materials
{
    public class Steak : Product
    {
        public override string Name => "Steak";
        public override ProductCategory Category => ProductCategory.AnimalProduct;

        public override double Weight => 1.0;

        public override bool IsPerishable => true;
        public override int ShelfLifeDays => 4;
    }
}