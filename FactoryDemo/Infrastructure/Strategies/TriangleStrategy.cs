using FactoryDemo.Domain;

namespace FactoryDemo.Infrastructure.Strategies
{
    public class TriangleStrategy : IShapeStrategy
    {
        public string Execute(IShape shape)
        {
            return "that is using triangle strategy";
        }
    }
}