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

namespace zadanie2
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
            int K = int.Parse(chislo.Text);
            if (K > 0)
            {
                K = K - 8;
                otvet.Text = ($"{K}");
            }
            else
            {
                K = K + 6;
                otvet.Text = ($"{K}");
            }

        }
    }
}
