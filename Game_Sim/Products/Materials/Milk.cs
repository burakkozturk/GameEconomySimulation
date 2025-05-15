using Game_Sim.Model;

namespace Game_Sim.Products.Materials
{
    public class Milk : Product
    {
        public override string Name => "Milk";
        public override ProductCategory Category => ProductCategory.AnimalProduct;

        public override double Weight => 1.0;
        public override bool IsPerishable => true;
        public override int ShelfLifeDays => 5;
    }
}