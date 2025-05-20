using FactoryDemo.Domain;

namespace FactoryDemo.Application
{
    public interface IShapeStrategyResolver
    {
        IShapeStrategy Resolve(IShape shape);
    }
}