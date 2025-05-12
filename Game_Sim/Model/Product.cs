namespace Game_Sim.Model
{
    public abstract class Product
    {
        public abstract string Name { get; }
        public abstract ProductCategory Category { get; }

        public virtual double Weight => 1.0;             // kg cinsinden varsayılan
        public virtual double Volume => 1.0;             // m³ ya da "unit" olarak
        public virtual bool IsPerishable => false;       // Bozulabilir mi?
        public virtual int ShelfLifeDays => int.MaxValue; // Bozulma süresi
        public virtual double BasePrice => 10.0;         // Pazar sistemi için referans

        public override string ToString()
        {
            return $"{Name} (Category: {Category}, Weight: {Weight}kg, Volume: {Volume}u, Perishable: {IsPerishable}, Price: {BasePrice})";
        }
    }
}
