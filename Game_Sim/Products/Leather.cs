using Game_Sim.Model;

namespace Game_Sim.Products
{
    public class Leather : Product
    {
        public override string Name => "Leather";
        public override ProductCategory Category => ProductCategory.Material;

        public override double Weight => 1.5;
        public override double Volume => 0.8;
        public override bool IsPerishable => false;
    }
}