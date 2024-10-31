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

        public List<string> chatarr;

        public List<User> users;
        public List<int> dialindexses;
        public MainWindow()
        {
            InitializeComponent();
            usersfile = new FileInfo(userspath);
            users = new List<User>();

            dialindfile = new FileInfo(dialindpath);
            dialindexses = new List<int>();

            usersRead(usersfile);
            dialindRead(dialindfile);

            RegWindow rw = new RegWindow(this);
            rw.ShowDialog();

            for (int i = 0; i < users.Count(); i++)
            {
                if (i != thisuserindex)
                {
                    UsersDisplay.Items.Add(users[i].name);
                }
            }

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
                string[] friends = new string[0];
                if (arr[i + 2] != "")
                {
                    friends = arr[i + 2].Split(',');
                }
                string[] temp = null;
                if (arr[i + 3] != "")
                {
                    temp = arr[i + 3].Split(',');
                }
                int[]dialogues = new int[0] {};
                if (temp != null)
                {
                    for (int j = 0; j < temp.Length; j++)
                    {
                        dialogues.Append(int.Parse(temp[j]));
                    }

                }
                User nu = new User(arr[i], arr[i+1], friends, dialogues);
                users.Add(nu);
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
                users[thisuserindex].dialogues.Append(dialindexses.Count);
                FriendsDisplay.Items.Add(uss);
                File.Create($"{(dialindexses.Count).ToString()}.txt");
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

        private void CloseB_Click(object sender, RoutedEventArgs e)
        { 
            List <string> arr = new List<string>();
            for (int i = 0; i < users.Count; i++)
            {
                arr.Add(users[i].name);
                arr.Add(users[i].password);
                arr.Add(string.Join(",", users[i].friends));
                arr.Add(string.Join(",", users[i].dialogues));
            }
            File.WriteAllLines(userspath,arr);
            List <string> arr1 = new List<string>();
            foreach(int  i in dialindexses) 
            { 
                arr1.Add(i.ToString());
            }
            File.WriteAllLines(dialindpath, arr1);
            this.Close();
        }

        private void FriendsDisplay_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string name = FriendsDisplay.SelectedItem.ToString();
            int dialindex = 0;
            for (int i = 0; i < users[thisuserindex].friends.Length; i++)
            {
                if (name == users[thisuserindex].friends[i])
                {
                    dialindex = i + 1;
                }
            }
            chatarr = new List<string>(File.ReadAllLines(dialindex.ToString()));
            for (int i = 0; i < chatarr.Count; i+=2)
            {
                if (chatarr[i] == name)
                {
                    FriendMes.Items.Add(chatarr[i+1]);
                }
                else { MyMes.Items.Add(chatarr[i + 1]); }
            }
        }
    }
}
