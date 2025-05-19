using FactoryDemo.Domain;
using FactoryDemo.Domain.Shapes;

namespace FactoryDemo.Infrastructure
{
    public class ShapeFactory : IShapeFactory
    {
        private readonly IShapePool<Circle> _circlePool;
        private readonly IShapePool<Square> _squarePool;
        private readonly IShapePool<Triangle> _trianglePool;

        public ShapeFactory(IShapePool<Circle> circlePool, IShapePool<Square> squarePool, IShapePool<Triangle> trianglePool)
        {
            _circlePool = circlePool;
            _squarePool = squarePool;
            _trianglePool = trianglePool;
        }

        public IShape GetShape(string shapeType, string color)
        {
            IShape shape;

            switch (shapeType.ToLower())
            {
                case "circle":
                    shape = _circlePool.Get();
                    break;
                case "square":
                    shape = _squarePool.Get();
                    break;
                case "triangle":
                    shape = _trianglePool.Get();
                    break;
                default:
                    throw new Exception("Unknow shape type");

            }

            switch(shape)
            {
                case Circle circle:
                    circle.Color = color; 
                    break;
                    case Square square:
                    square.Color = color; 
                    break;
                    case Triangle triangle:
                    triangle.Color = color;
                    break;
            }

            return shape;
        }

        public void ReleaseShape(IShape shape)
        {
            switch (shape)
            {
                case Circle circle:
                    _circlePool.Release(circle); 
                    break;
                    case Square square:
                    _squarePool.Release(square);
                    break;
                    case Triangle triangle:
                    _trianglePool.Release(triangle);
                    break;
            }
        }
    }
}
