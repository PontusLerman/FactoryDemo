using FactoryDemo.Domain;

namespace FactoryDemo.Application
{
    public class ShapeService
    {
        private readonly IShapeFactory _factory;
        private readonly IShapeStrategyResolver _shapeStrategyResolver;

        public ShapeService(IShapeFactory factory, IShapeStrategyResolver shapeStrategyResolver)
        {
            _factory = factory;
            _shapeStrategyResolver = shapeStrategyResolver;
        }

        public void DrawShape (string shapeType, string color)
        {
            var shape = _factory.GetShape(shapeType,color);
            var strategy = _shapeStrategyResolver.Resolve(shape);

            var drawnShape = shape.Draw();
            
            var strategyShape = strategy.Execute(shape);
         
            Console.WriteLine($"{drawnShape} {strategyShape}");

            //Simulates work
            Task.Delay(100).Wait();

            _factory.ReleaseShape(shape);
        }
    }
}