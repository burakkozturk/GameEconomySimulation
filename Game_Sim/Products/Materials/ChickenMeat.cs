using Game_Sim.Model;

namespace Game_Sim.Products.Materials
{
    public class ChickenMeat : Product
    {
        public override string Name => "Chicken Meat";
        public override ProductCategory Category => ProductCategory.AnimalProduct;


        public override double Weight => 2.0;
        public override bool IsPerishable => true;
        public override int ShelfLifeDays => 3;
    }
}
