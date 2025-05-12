// Model/IProducer.cs
using Game_Sim.Model;

namespace Game_Sim.Model
{
    public interface IProducer
    {
        string Name { get; }
        Position Position { get; }
        List<Product> GetProducedGoods();
        void DisplayProductionInfo();
    }
}
