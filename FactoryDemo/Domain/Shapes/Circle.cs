namespace FactoryDemo.Domain.Shapes
{
    public class Circle : IShape
    {
        public string? Color { get; set; }
        public string Draw()
        {
            return $"This is a {Color ?? "default"} colored cirle";
        }

        public void Reset()
        {
            Color = null;
        }
    }
}