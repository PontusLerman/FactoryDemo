using FactoryDemo.Domain;
using System.Collections.Concurrent;

namespace FactoryDemo.Infrastructure
{
    public class ConcurrentShapePool<T> : IShapePool<T> where T : IShape, new()
    {
        private readonly ConcurrentBag<T> _pool = new();

        public T Get() => _pool.TryTake(out var item) ? item : new T();

        public void Release(T shape)
        {
            shape.Reset();
            _pool.Add(shape);
        }
    }
}
