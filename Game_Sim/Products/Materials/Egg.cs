using Game_Sim.Model;

namespace Game_Sim.Products.Materials
{
    public class Egg : Product
    {
        public override string Name => "Egg";
        public override ProductCategory Category => ProductCategory.AnimalProduct;

        public override double Weight => 0.05;
        public override bool IsPerishable => true;
        public override int ShelfLifeDays => 60;
    }
}
