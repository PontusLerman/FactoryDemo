namespace FactoryDemo.Domain
{
    public interface IShapeFactory
    {
        IShape GetShape(string shapeType, string color);
        void ReleaseShape(IShape shape);
    }
}