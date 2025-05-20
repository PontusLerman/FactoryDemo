using FactoryDemo.Domain;

namespace FactoryDemo.Infrastructure.Strategies
{
    public class SquareStrategy : IShapeStrategy
    {
        public string Execute(IShape shape)
        {
            return "that is using square strategy";
        }
    }
}