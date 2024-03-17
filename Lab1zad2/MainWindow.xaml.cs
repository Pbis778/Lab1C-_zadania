using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab1zad2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        void rysujKwadrat(double x, double y, double stepWidth, double stepHeight, SolidColorBrush color)
        {
            Rectangle rect = new Rectangle();
            rect.Width = stepWidth;
            rect.Height = stepHeight;
            rect.Fill = color;

            Canvas.SetLeft(rect, x);
            Canvas.SetTop(rect, y);
            canvas.Children.Add(rect);
        }

        private void btnPiramida_Click(object sender, RoutedEventArgs e)
        {
            int rows = 8;
            double stepWidth = 20;
            double stepHeight = 20;

            double startY = 50;

            for (int i = 0; i < rows; i++)
            {
                double startX = (canvas.ActualWidth - (2 * i + 1) * stepWidth) / 2;
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    double x = startX + j * stepWidth;
                    double y = startY + i * stepHeight;

                    rysujKwadrat(x, y, stepWidth, stepHeight, Brushes.Black);
                }
            }
        }
    }
}