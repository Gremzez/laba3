using System.Windows;
using System.Windows.Controls;

namespace WpfApp3
{
    public partial class MainWindow : Window
    {
        private CircleCreator _circleCreator;
        private SquareCreator _squareCreator;
        private TriangleCreator _triangleCreator;

        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateCreators("Красный");
        }

        private void ColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = ColorComboBox.SelectedItem as ComboBoxItem;
            if (selectedItem != null)
            {
                UpdateCreators(selectedItem.Content.ToString());

                if (FiguresPanel != null)
                {
                    FiguresPanel.Children.Clear();
                }
            }
        }

        private void UpdateCreators(string color)
        {
            switch (color)
            {
                case "Красный":
                    _circleCreator = new RedCircleCreator();
                    _squareCreator = new RedSquareCreator();
                    _triangleCreator = new RedTriangleCreator();
                    break;
                case "Синий":
                    _circleCreator = new BlueCircleCreator();
                    _squareCreator = new BlueSquareCreator();
                    _triangleCreator = new BlueTriangleCreator();
                    break;
                case "Зелёный":
                    _circleCreator = new GreenCircleCreator();
                    _squareCreator = new GreenSquareCreator();
                    _triangleCreator = new GreenTriangleCreator();
                    break;
                default:
                    return;
            }
        }

        private void AddFiguresButton_Click(object sender, RoutedEventArgs e)
        {
            if (_circleCreator == null || _squareCreator == null || _triangleCreator == null)
            {
                MessageBox.Show("Выберите цвет фигур", "Предупреждение",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (FiguresPanel == null) return;

            FiguresPanel.Children.Clear();

            var circle = _circleCreator.CreateCircle();
            FiguresPanel.Children.Add(circle.CreateUIElement());

            var square = _squareCreator.CreateSquare();
            FiguresPanel.Children.Add(square.CreateUIElement());

            var triangle = _triangleCreator.CreateTriangle();
            FiguresPanel.Children.Add(triangle.CreateUIElement());
        }
    }
}