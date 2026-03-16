using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfApp3
{
    public abstract class Figure
    {
        public Color Color { get; set; }
        public abstract UIElement CreateUIElement(double size = 50);
    }

    public class Circle : Figure
    {
        public override UIElement CreateUIElement(double size = 50)
        {
            return new Ellipse
            {
                Width = size,
                Height = size,
                Fill = new SolidColorBrush(Color),
                Margin = new Thickness(5)
            };
        }
    }

    public class Square : Figure
    {
        public override UIElement CreateUIElement(double size = 50)
        {
            return new Rectangle
            {
                Width = size,
                Height = size,
                Fill = new SolidColorBrush(Color),
                Margin = new Thickness(5)
            };
        }
    }

    public class Triangle : Figure
    {
        public override UIElement CreateUIElement(double size = 50)
        {
            var polygon = new Polygon
            {
                Points = new PointCollection
                {
                    new Point(25, 0),
                    new Point(0, 50),
                    new Point(50, 50)
                },
                Fill = new SolidColorBrush(Color),
                Margin = new Thickness(5),
                Width = 50,
                Height = 50,
                Stretch = Stretch.Fill
            };
            return polygon;
        }
    }
}