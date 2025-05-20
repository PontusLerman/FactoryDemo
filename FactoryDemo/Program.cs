using FactoryDemo.Application;
using FactoryDemo.Domain;
using FactoryDemo.Domain.Shapes;
using FactoryDemo.Infrastructure;

namespace FactoryDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Setup the infrastructure
            var circlePool = new ConcurrentShapePool<Circle>();
            var squarePool = new ConcurrentShapePool<Square>();
            var trianglePool = new ConcurrentShapePool<Triangle>();

            //Setup the service and factory
            IShapeFactory factory = new ShapeFactory(circlePool, squarePool, trianglePool);
            IShapeStrategyResolver resolver = new ShapeStrategyResolver();
            var service = new ShapeService(factory, resolver);

            //Run parallel drawings of shapes
            string[] shapeTypes = { "circle", "square", "triangle" };
            string[] colors = { "Red", "Blue", "Green" };

            Parallel.For(0, 15, i =>
            {
                string type = shapeTypes[i % 3];
                string color = colors[i % 3];

                service.DrawShape(type, color);
            });
        }
    }
}