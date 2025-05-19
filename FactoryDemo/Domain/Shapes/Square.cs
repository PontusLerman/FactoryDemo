namespace FactoryDemo.Domain.Shapes
{
    public class Square : IShape
    {
        public string? Color { get; set; }
        public void Draw()
        {
            Console.WriteLine($"This is a {Color ?? "default"} colored square");
        }

        public void Reset()
        {
            Color = null;
        }
    }
}
