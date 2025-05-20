using FactoryDemo.Domain;
using FactoryDemo.Domain.Shapes;
using FactoryDemo.Infrastructure.Strategies;

namespace FactoryDemo.Application
{
    public class ShapeStrategyResolver : IShapeStrategyResolver
    {
        private readonly Dictionary<Type, IShapeStrategy> _strategies;
        public ShapeStrategyResolver()
        {
            _strategies = new Dictionary<Type, IShapeStrategy> 
            {
                {typeof(Circle), new CircleStrategy() },
                {typeof(Square), new SquareStrategy() },
                {typeof (Triangle), new TriangleStrategy() }
            };
        }

        public IShapeStrategy Resolve(IShape shape)
        {
            return _strategies[shape.GetType()];
        }
    }
}