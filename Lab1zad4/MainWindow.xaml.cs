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

namespace Lab1zad4
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

        private void chkButton_Click(object sender, RoutedEventArgs e)
        {
            int totalScore = 0;

            if (cbx1Question1.IsChecked == true && cbx1Question2.IsChecked == true && cbx1Question3.IsChecked == false)
            {
                totalScore += 2;
            } 
            else if (cbx1Question1.IsChecked == true || cbx1Question2.IsChecked == true) {
                totalScore += 1;
            }

            if (cbxQuestion2.SelectedIndex == 1)
            {
                totalScore += 1;
            }

            if (lstBoxQ3.SelectedIndex == 1)
            {
                totalScore += 1;
            }

            if (q4radioBtn3.IsChecked == true)
            {
                totalScore += 1;
            }

            if (txtBoxQ5.Text.ToLower() == "poniedziałek")
            {
                totalScore += 2;
            }

            MessageBox.Show($"Końcowy wynik: {totalScore}");
        }
    }
}
