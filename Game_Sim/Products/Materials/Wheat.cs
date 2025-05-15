using Game_Sim.Model;

namespace Game_Sim.Products.Materials
{
    public class Wheat : Product
    {
        public override string Name => "Wheat";
        public override ProductCategory Category => ProductCategory.Crop;

        public override double Weight => 1.0;
        public override bool IsPerishable => true;
        public override int ShelfLifeDays => 365;
    }
}
