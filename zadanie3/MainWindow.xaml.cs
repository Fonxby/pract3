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

namespace zadanie3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void knopka_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(chislo1.Text); //1
            int b = int.Parse(chislo2.Text); //2
            int c = int.Parse(chislo3.Text); //3
            if (a == b && a != c)
            {
                otvet.Text = ($"Порядковый номер у числа 3: {c} ");
            }
            else
                if (a == c && a != b)
            {
                otvet.Text = ($"Порядковый номер у числа 2: {b}");
            }
            else
                if (b == c && b != a)
            {
                otvet.Text = ($"Порядковый номер у числа 1: {a}");
            }
            else
                if (a != b && b != c && c != a)
            {
                otvet.Text = ($"Порядкового номера нет");
            }          
        }
    }
}
