using System.Windows.Media;

namespace WpfApp3
{
    public abstract class TriangleCreator
    {
        public abstract Triangle CreateTriangle();
    }

    public class RedTriangleCreator : TriangleCreator
    {
        public override Triangle CreateTriangle() => new Triangle { Color = Colors.Red };
    }

    public class BlueTriangleCreator : TriangleCreator
    {
        public override Triangle CreateTriangle() => new Triangle { Color = Colors.Blue };
    }

    public class GreenTriangleCreator : TriangleCreator
    {
        public override Triangle CreateTriangle() => new Triangle { Color = Colors.Green };
    }
}