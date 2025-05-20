namespace FactoryDemo.Domain.Shapes
{
    public class Triangle : IShape
    {
        public string? Color { get; set; }
        public string Draw()
        {
            return $"This is a {Color ?? "default"} colored triangle";
        }

        public void Reset()
        {
            Color = null;
        }
    }
}