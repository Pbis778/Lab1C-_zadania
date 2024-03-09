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

namespace Lab1_zadania
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

        private void ObliczButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = double.Parse(txtBoxA.Text);
                double b = double.Parse(txtBoxB.Text);
                double c = double.Parse(txtBoxC.Text);

                double delta = b * b - 4 * a * c;

                if (delta < 0)
                {
                    txtWynik.Text = "Brak pierwiastków";
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    txtWynik.Text = $"Jeden pierwiastek: x = {x}";
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    txtWynik.Text = $"Dwa pierwiastki: x1 = {x1}, x2 = {x2}";
                }

                txtWynik.Visibility = Visibility.Visible;
            }
            catch (FormatException)
            {
                MessageBox.Show("Podano nieprawidłowe wartości!");
                return;
            }
        }
    }
}