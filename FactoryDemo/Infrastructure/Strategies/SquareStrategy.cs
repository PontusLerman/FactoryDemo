using FactoryDemo.Domain;

namespace FactoryDemo.Infrastructure.Strategies
{
    public class SquareStrategy : IShapeStrategy
    {
        public string Exceute(IShape shape)
        {
            return "that is using square strategy";
        }
    }
}