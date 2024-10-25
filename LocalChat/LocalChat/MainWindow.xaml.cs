using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
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

namespace LocalChat
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string userspath = "users.txt";
        public string dialindpath = "dialind.txt";
        int thisuserindex;

        FileInfo usersfile;
        FileInfo dialindfile;
        public List<User> users;
        public List<int> dialindexses;
        public MainWindow()
        {
            InitializeComponent();
            usersfile = new FileInfo(userspath);
            users = new List<User>();

            dialindfile = new FileInfo(dialindpath);
            dialindexses = new List<int>();

            RegWindow rw = new RegWindow(this);
            rw.ShowDialog();

            for (int i = 0; i < users[thisuserindex].friends.Count(); i++)
            {
                FriendsDisplay.Items.Add(users[thisuserindex].friends[i]);
            }
        }
        
        public void usersRead(FileInfo file)
        {
            string[] arr = File.ReadAllLines(file.FullName);
            for (int i = 0; i < arr.Length; i+=4)
            {
                string[] friends = arr[i+2].Split(',');
                string[] temp = arr[i + 3].Split(',');
                int[]dialogues = new int[] {};
                for (int j = 0; j < temp.Length; j++)
                {
                    dialogues.Append(int.Parse(temp[j]));
                }
                User nu = new User(arr[i], arr[i+1], friends, dialogues);
            }
        }
        public void dialindRead(FileInfo file)
        {
            string[] arr = File.ReadAllLines(file.FullName);
            for (int i = 0; i < arr.Length; i += 4)
            {
                dialindexses.Add(int.Parse(arr[i]));
            }
        }
        public void ReturnUser(string name)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].name == name)
                {
                    thisuserindex = i;
                }
            }
        }
        public void ReturnUserToReg(string name, string password)
        {
            User nu = new User(name, password);
            users.Add(nu);
            File.AppendAllText(nu.name, userspath);
            File.AppendAllText(nu.password, userspath);
            File.AppendAllText(nu.name, userspath);

        }
        public List<User> SendUsersList()
        {
            return users;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string uss = UsersDisplay.SelectedItem.ToString();
            MessageBoxResult res = MessageBox.Show("Вы хотите добавить этого пользователя в друзья?", "Кинуть инвайт?", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (res == MessageBoxResult.Yes)
            {
                users[thisuserindex].friends.Append(uss);
                dialindexses.Add(dialindexses.Count + 1);
                users[thisuserindex].dialogues.Append(dialindexses.Count + 1);
                FriendsDisplay.Items.Add(uss);
            }
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].name == uss)
                {
                    users[i].friends.Append(users[thisuserindex].name);
                    users[i].dialogues.Append(dialindexses.Count + 1);
                }
            }
        }
    }
    
}
