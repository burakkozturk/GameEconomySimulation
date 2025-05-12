namespace Game_Sim.Model
{
    public class Position
    {
        public double X { get; set; } // East-West (Doğu-Batı)
        public double Y { get; set; } // North-South (Kuzey-Güney)

        public Position(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double DistanceTo(Position other)
        {
            double dx = X - other.X;
            double dy = Y - other.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        public override string ToString()
        {
            return $"({X} km, {Y} km)";
        }
    }
}
