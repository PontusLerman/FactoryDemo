using FactoryDemo.Domain;

namespace FactoryDemo.Infrastructure
{
    public interface IShapePool<T> where T : IShape
    {
        T Get();
        
        void Release(T shape);
    }
}
