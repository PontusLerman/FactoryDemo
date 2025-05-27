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

            for (int i = 0; i < 2; i++)
            {
                DemoLoop(service, shapeTypes, colors);
            }            
        }

        private static void DemoLoop(ShapeService service, string[] shapeTypes, string[] colors)
        {
            var randomNumber = new Random();

            Parallel.For(0, 10, i =>
            {
                string type = shapeTypes[i % 3];
                string color = colors[randomNumber.Next(3)];

                service.DrawShape(type, color);
            });
        }
    }
}