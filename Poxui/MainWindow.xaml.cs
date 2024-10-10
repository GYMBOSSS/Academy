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

namespace Poxui
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string s = TB.Text;
            string ss = new string(s.Reverse().ToArray());
            MessageBox.Show("ASALAMUALEIKUM","PRIVET",MessageBoxButton.OK, MessageBoxImage.Information);
            MessageBox.Show(ss, "PEREVERNEGR", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
