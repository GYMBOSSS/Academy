﻿using System;
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

namespace WPF_PRACTICE_2._1
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

        private void REKLAMA1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Поздравляю, на тебя оформлен кредит размером в один миллион зелёных. Удачи выжить","Ку-ку", MessageBoxButton.OK,MessageBoxImage.Information);
        }

        private void SOGLB_Click(object sender, RoutedEventArgs e)
        {
            PANELKA.Visibility = Visibility.Visible;
            DOCKPANELKA.Visibility = Visibility.Visible;
            REKLAMA1.Visibility = Visibility.Visible;
            REKLAMA2.Visibility = Visibility.Visible;
            DOC.Visibility = Visibility.Collapsed;
            
        }
    }
}
