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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudBD
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List <Student> studentList;
        List <Teacher> teacherList;
        string studentFilePath;
        string teacherFilePath;
        public MainWindow()
        {
            InitializeComponent();
            studentList = new List <Student>();
            teacherList = new List <Teacher>();
            studentFilePath = "studentFile.txt";
            teacherFilePath = "teacherFile.txt";
            // Заполение списка студентов из файла--------------------------------------------------
            FileInfo studentFile = new FileInfo(studentFilePath);
            if (!studentFile.Exists)
            {
                File.Create(studentFilePath);
            }
            string[] studentFileArr = File.ReadAllLines(studentFilePath);
            for (int i = 0; i < studentFileArr.Length; i += 7)
            {
                Student newstud = new Student(studentFileArr[i], studentFileArr[i+1], studentFileArr[i+2], int.Parse(studentFileArr[i+3]), studentFileArr[i+4], bool.Parse(studentFileArr[i+5]), studentFileArr[i+6]);
                studentList.Add(newstud);
            }
            //----------------------------------------------------------------------------------------------------
            // Заполнение списка преподавателей из файла--------------------------------------------
            FileInfo teacherFile = new FileInfo(studentFilePath);
            if (!studentFile.Exists)
            {
                File.Create(studentFilePath);
            }
            string[] teacherFileArr = File.ReadAllLines(studentFilePath);
            for (int i = 0; i < studentFileArr.Length; i += 9)
            {
                string[] subjects = teacherFileArr[i+8].Split(',');
                Teacher newteach = new Teacher(studentFileArr[i], studentFileArr[i + 1], studentFileArr[i + 2], int.Parse(studentFileArr[i + 3]), studentFileArr[i + 4], bool.Parse(studentFileArr[i + 5]), studentFileArr[i + 6], studentFileArr[i + 7], subjects);
                teacherList.Add(newteach);
            }
            //----------------------------------------------------------------------------------------------------

        }
        // Функции регистрации(преподавателей, студентов и групп)-----------------------------------
        private void teacherRegButton_Click(object sender, RoutedEventArgs e)
        {
            TeacherRegistrationForm form = new TeacherRegistrationForm();
            form.ShowDialog();
        }

        private void studentRegButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GroupCreateButton_Click(object sender, RoutedEventArgs e)
        {

        }
        //--------------------------------------------------------------------------------------------------------
    }
}
