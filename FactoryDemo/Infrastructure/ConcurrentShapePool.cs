using FactoryDemo.Domain;
using FactoryDemo.Domain.Shapes;
using System.Collections.Concurrent;

namespace FactoryDemo.Infrastructure
{
    public class ConcurrentShapePool<T> : IShapePool<T> where T : IShape, new()
    {
        private readonly ConcurrentBag<T> _pool = new();

        public T Get()
        {
            if (_pool.TryTake(out var shape))
            {
                Console.WriteLine($"{shape} REUSED from pool");
                return shape;
            }
            else
            {
                return new();
            }
        }

        public void Release(T shape)
        {
            shape.Reset();
            _pool.Add(shape);
        }
    }
}
