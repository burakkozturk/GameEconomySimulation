using Game_Sim.Model;

namespace Game_Sim.Products
{
    public class Steak : Product
    {
        public override string Name => "Steak";
        public override ProductCategory Category => ProductCategory.AnimalProduct;

        public override double Weight => 0.3;
        public override double Volume => 0.2;
        public override bool IsPerishable => true;
        public override int ShelfLifeDays => 4;
    }
}