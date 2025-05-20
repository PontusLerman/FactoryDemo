namespace FactoryDemo.Domain
{
    public interface IShapeStrategyResolver
    {
        IShapeStrategy Resolve(IShape shape);
    }
}