using Game_Sim.Model;

namespace Game_Sim.Products.Materials
{
    public class Wheat : Product
    {
        public override string Name => "Wheat";
        public override ProductCategory Category => ProductCategory.Crop;
    }
}
