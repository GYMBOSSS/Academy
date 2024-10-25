using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace LocalChat
{
    /// <summary>
    /// Логика взаимодействия для RegWindow.xaml
    /// </summary>
    public partial class RegWindow : Window
    {
        public MainWindow mw;
        List<User> users;
        public RegWindow(MainWindow wn)
        {
            InitializeComponent();
            mw = wn;
            users = mw.SendUsersList();
            
        }

        private void EnterB_Click(object sender, RoutedEventArgs e)
        {
            EnterB.Visibility = Visibility.Collapsed;
            SignInB.Visibility = Visibility.Collapsed;
            
            LogInB.Visibility = Visibility.Visible;
            NameLITB.Visibility = Visibility.Visible;
            PassLITB.Visibility = Visibility.Visible;
        }
        private void RegB_Click(object sender, RoutedEventArgs e)
        {
            EnterB.Visibility = Visibility.Collapsed;
            SignInB.Visibility = Visibility.Collapsed;

            SignInB.Visibility = Visibility.Visible;
            NameSITB.Visibility = Visibility.Visible;
            PassSITB.Visibility = Visibility.Visible;
        }
        private void LogInB_Click( object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].name == NameLITB.Text || users[i].password == PassLITB.Text)
                {
                    mw.ReturnUser(NameLITB.Text);
                }
            }
        }
        private void SignInB_Click(Object sender, RoutedEventArgs e)
        {
            mw.ReturnUserToReg(NameSITB.Text, PassSITB.Text);
        }
    }
}
