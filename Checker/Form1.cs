using System.Text.RegularExpressions;

namespace Checker
{
    public partial class Form1 : Form
    {
        string pattern = @"[^a-zA-Z0-9]";
        Binding binding1;
        public Form1()
        {
            InitializeComponent();
            Binding bd = new Binding("Text", textBox1, "Text");
            Binding bd2 = new Binding("Text", textBox2, "Text");
            bd.Format += (sender, e) => {
                    if (Regex.IsMatch(e.Value.ToString(),pattern))
                    {
                        label1.Text = "Логин содержит неизвестные символы!";
                    }
                    else
                    {
                        if (e.Value.ToString().Length < 6)
                        {
                            label1.Text = "Логин должен быть от 6 символов!";
                        }
                        else
                        {
                            label1.Text = "Все отлично!";
                        }
                    }
                

            };
            bd2.Format += (sender, e) => {
                    if (Regex.IsMatch(e.Value.ToString(), pattern))
                    {
                        label1.Text = "Пароль содержит неизвестные символы!";
                    }
                    else
                    {
                        if (e.Value.ToString().Length < 6)
                        {
                            label2.Text = "Пароль должен быть от 6 символов!";
                        }
                        else
                        {
                            label2.Text = "Все отлично!";
                        }
                    }

            };
            textBox1.DataBindings.Add(bd);
            textBox2.DataBindings.Add(bd2);
        }

    }

}
