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

        private void btnPiramida_Click(object sender, RoutedEventArgs e)
        {
            int rows = 8;
            double stepWidth = 20;
            double stepHeight = 20;

            double startX = (canvas.ActualWidth - rows * stepWidth) / 2;
            double startY = 50;

            for (int i = 0; i < rows; i++)
            {
                for (int j=0; j <= i; j++)
                {
                    double x = startX + j * stepWidth;
                    double y = startY + i * stepHeight;
                    Rectangle rect = new Rectangle();
                    rect.Width = stepWidth;
                    rect.Height = stepHeight;
                    rect.Fill = Brushes.Black;

                    Canvas.SetLeft(rect, x);
                    Canvas.SetTop(rect, y);
                    canvas.Children.Add(rect);
                }
            }
        }
    }
}