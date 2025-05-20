namespace FactoryDemo.Domain.Shapes
{
    public class Square : IShape
    {
        public string? Color { get; set; }
        public string Draw()
        {
            return $"This is a {Color ?? "default"} colored square";
        }

        public void Reset()
        {
            Color = null;
        }
    }
}