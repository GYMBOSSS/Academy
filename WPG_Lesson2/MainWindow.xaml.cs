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

namespace WPG_Lesson2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int x; string y;
        public MainWindow()
        {
            InitializeComponent();
            x = 0;
            y = "";
            OUTPUT.Text = "0";
        }
        private void ZEROB_Click(object sender, RoutedEventArgs e)
        {
            if (OUTPUT.Text != "0")
            {
                OUTPUT.Text = OUTPUT.Text + '0';
            }
        }
        private void ONEB_Click(object sender, RoutedEventArgs e)
        {
            if (OUTPUT.Text == "0")
            {
                OUTPUT.Clear();
                OUTPUT.Text = OUTPUT.Text + '1';
            }
            else
            {
                OUTPUT.Text = OUTPUT.Text + '1';
            }
        }

        private void TWOB_Click(object sender, RoutedEventArgs e)
        {
            if (OUTPUT.Text == "0")
            {
                OUTPUT.Clear();
                OUTPUT.Text = OUTPUT.Text + '2';
            }
            else
            {
                OUTPUT.Text = OUTPUT.Text + '2';
            }
        }

        private void THREEB_Click(object sender, RoutedEventArgs e)
        {
            if (OUTPUT.Text == "0")
            {
                OUTPUT.Clear();
                OUTPUT.Text = OUTPUT.Text + '3';
            }
            else
            {
                OUTPUT.Text = OUTPUT.Text + '3';
            }
        }

        private void FOURB_Click(object sender, RoutedEventArgs e)
        {
            if (OUTPUT.Text == "0")
            {
                OUTPUT.Clear();
                OUTPUT.Text = OUTPUT.Text + '4';
            }
            else
            {
                OUTPUT.Text = OUTPUT.Text + '4';
            }
        }

        private void FIVEB_Click(object sender, RoutedEventArgs e)
        {
            if (OUTPUT.Text == "0")
            {
                OUTPUT.Clear();
                OUTPUT.Text = OUTPUT.Text + '5';
            }
            else
            {
                OUTPUT.Text = OUTPUT.Text + '5';
            }
        }

        private void SIXB_Click(object sender, RoutedEventArgs e)
        {
            if (OUTPUT.Text == "0")
            {
                OUTPUT.Clear();
                OUTPUT.Text = OUTPUT.Text + '6';
            }
            else
            {
                OUTPUT.Text = OUTPUT.Text + '6';
            }
        }

        private void SEVENB_Click(object sender, RoutedEventArgs e)
        {
            if (OUTPUT.Text == "0")
            {
                OUTPUT.Clear();
                OUTPUT.Text = OUTPUT.Text + '7';
            }
            else
            {
                OUTPUT.Text = OUTPUT.Text + '7';
            }
        }

        private void EIGHTB_Click(object sender, RoutedEventArgs e)
        {
            if (OUTPUT.Text == "0")
            {
                OUTPUT.Clear();
                OUTPUT.Text = OUTPUT.Text + '8';
            }
            else
            {
                OUTPUT.Text = OUTPUT.Text + '8';
            }
        }

        private void NINEB_Click(object sender, RoutedEventArgs e)
        {
            if (OUTPUT.Text == "0")
            {
                OUTPUT.Clear();
                OUTPUT.Text = OUTPUT.Text + '9';
            }
            else
            {
                OUTPUT.Text = OUTPUT.Text + '9';
            }
        }

        private void SUMB_Click(object sender, RoutedEventArgs e)
        {
            x = x + int.Parse(OUTPUT.Text);
            LABELING.Content = x.ToString();
            OUTPUT.Clear();
        }

        private void DIFB_Click(object sender, RoutedEventArgs e)
        {
            x = x - int.Parse(OUTPUT.Text);
            LABELING.Content = x.ToString();
            OUTPUT.Clear();
        }

    }
}
