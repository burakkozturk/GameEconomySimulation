using Game_Sim.Model;

namespace Game_Sim.Products
{
    public class Wine : Product
    {
        public override string Name => "Wine";
        public override ProductCategory Category => ProductCategory.Luxury;

        public override double Weight => 1.2;  // Örnek olarak 1.2kg
        public override double Volume => 0.75; // Şarap şişesi hacmi (litre)
        public override bool IsPerishable => true;
        public override int ShelfLifeDays => 365; // 1 yıl
    }
}
