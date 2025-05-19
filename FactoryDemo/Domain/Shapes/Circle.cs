namespace FactoryDemo.Domain.Shapes
{
    public class Circle : IShape
    {
        public string? Color { get; set; }
        public void Draw()
        {
            Console.WriteLine($"This is a {Color ?? "default"} colored cirle");
        }

        public void Reset()
        {
            Color = null;
        }
    }
}
