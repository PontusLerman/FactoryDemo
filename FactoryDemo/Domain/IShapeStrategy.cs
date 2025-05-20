namespace FactoryDemo.Domain
{
    public interface IShapeStrategy
    {
        string Execute(IShape shape);
    }
}