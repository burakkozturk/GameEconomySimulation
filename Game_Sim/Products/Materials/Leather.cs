using Game_Sim.Model;

namespace Game_Sim.Products.Materials
{
    public class Leather : Product
    {
        public override string Name => "Leather";
        public override ProductCategory Category => ProductCategory.Material;

        public override double Weight => 5;
        public override bool IsPerishable => false;
    }
}