using FactoryDemo.Domain;

namespace FactoryDemo.Infrastructure.Strategies
{
    public class CircleStrategy : IShapeStrategy
    {
        public string Exceute(IShape shape)
        {
            return "that is using circle strategy";
        }
    }
}