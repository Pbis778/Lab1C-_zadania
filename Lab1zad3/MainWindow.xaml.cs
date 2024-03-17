using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab1zad3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            drawChessboard();
        }

        private void drawChessboard()
        {
            int rows = 8;
            int cols = 12;
            double squareSize = 50;

            for (int i = 0; i < rows; i++)
            {
                var rowDefinition = new RowDefinition();
                rowDefinition.Height = new GridLength(squareSize);
                grid.RowDefinitions.Add(rowDefinition);
            }

            for (int i = 0; i < cols; i++)
            {
                var colDefinition = new ColumnDefinition();
                colDefinition.Width = new GridLength(squareSize);
                grid.ColumnDefinitions.Add(colDefinition);
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Rectangle rect = new Rectangle();
                    rect.Width = squareSize;
                    rect.Height = squareSize;
                    rect.Fill = (i + j) % 2 == 0 ? Brushes.White : Brushes.Black;

                    Grid.SetRow(rect, i);
                    Grid.SetColumn(rect, j);

                    grid.Children.Add(rect);
                }
            }
        }
    }
}