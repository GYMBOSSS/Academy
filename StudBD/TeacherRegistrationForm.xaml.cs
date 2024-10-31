using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace StudBD
{
    /// <summary>
    /// Логика взаимодействия для TeacherRegistrationForm.xaml
    /// </summary>
    public partial class TeacherRegistrationForm : Window
    {
        MainWindow wndw;
        public TeacherRegistrationForm(MainWindow mw)
        {
            InitializeComponent();
            wndw = mw;
            string[] subjects = mw.sendSubjects();
            for (int i = 0; i < subjects.Length; i++)
            {
                SubjTarLB.Items.Add(subjects[i]);
            }
        }


        private void ComB_Click(object sender, EventArgs e)
        {
            bool _gender;
            if (GenderCB.Text == "Men") { _gender = true; }
            else { _gender = false; }
            wndw.RecieveTeacherParam(NameTB.Text, SurNTB.Text, MiddleNTB.Text, int.Parse(AgeTB.Text), NumTB.Text, _gender, EduTB.Text, AcDegCB.Text,SubjTarLB.SelectedItems as string[]);
        }

    }
}
