using FactoryDemo.Domain;

namespace FactoryDemo.Application
{
    public class ShapeService
    {
        private readonly IShapeFactory _factory;

        public ShapeService(IShapeFactory factory)
        {
            _factory = factory;
        }

        public void DrawShape (string shapeTye, string color)
        {
            var shape = _factory.GetShape(shapeTye,color);
            shape.Draw();

            //Simulates work@
            Task.Delay(100).Wait();

            _factory.ReleaseShape(shape);
        }
    }
}