using System.Resources;
using System.Runtime.Versioning;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Text;
using System.IO;

namespace Notes
{
    public partial class Form1 : Form
    {
        private string note_name_hint = "название заметки. не более 500 символов";
        private string note_text_hint = "напишите, что хотите запомнить";

        public Form1()
        {
            InitializeComponent();
            NoteImportance.Items.AddRange(new string[] {
            "¬ысокий", "—редний", "Ќизкий"
            });

            DirectoryInfo dir = new DirectoryInfo("data");
            if (!dir.Exists) dir.Create();

            foreach (var i in dir.GetFiles()) list_notes.Items.Add(i.Name);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            NoteName.ForeColor = Color.Black;
            if (NoteName.Text == note_name_hint)
                NoteName.Text = "";
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (NoteName.Text == ""
                || NoteName.Text == note_name_hint
                || NoteName.Text == null)
            {
                NoteName.ForeColor = Color.Gray;
                NoteName.Text = note_name_hint;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void note_text_Enter(object sender, EventArgs e)
        {
            NoteDescript.ForeColor = Color.Black;
            if (NoteDescript.Text == note_text_hint)
                NoteDescript.Text = "";
        }

        private void note_text_Leave(object sender, EventArgs e)
        {
            if (NoteDescript.Text == ""
                || NoteDescript.Text == note_text_hint
                || NoteDescript.Text == null)
            {
                NoteDescript.ForeColor = Color.Gray;
                NoteDescript.Text = note_text_hint;
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            bool flag = true;

            if (NoteDescript.Text == note_name_hint || NoteDescript.Text == "")
            {
                flag = false;
                MessageBox.Show("название не должно быть пустым");
            }
            if (NoteDescript.Text == note_text_hint || NoteDescript.Text == "")
            {
                flag = false;
                MessageBox.Show("текст заметки не должен быть пустым");
            }
            if (NoteImportance.Text == "")
            {
                flag = false;
                MessageBox.Show("приоритет заметки не должен быть пустым");
            }
            if (!NoteImportance.Items.Contains(NoteImportance.Text))
            {
                flag = false;
                MessageBox.Show("пожалуйста, выберите приоритет из списка");
            }

            if (flag)
            {
                string filePath = $"C:/Users/Student_12/Desktop/Repos/Academy/Notes/{NoteImportance.Text} # {NoteName.Text}.txt";
                if (File.Exists(filePath)) { File.Delete(filePath); }
                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                    {
                        sw.WriteLine(NoteImportance.Text);
                        sw.WriteLine(Date.Text);
                        foreach (var item in NoteDescript.Text)
                        {
                            sw.Write($"{item} ");
                        }
                    }
                }

                list_notes.Items.Add($"{NoteImportance.Text} # {NoteName.Text}");
                NoteDescript.Text = "";
                NoteName.Text = "";
                NoteImportance.Text = "";
                Date.Text = "";
            }
        }

        private void list_notes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_notes.SelectedItem != null)
            {
                string selectNote = list_notes.SelectedItem.ToString();

                string filePath = $"data/{selectNote}.txt";

                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
                    {
                        NoteName.Text = selectNote.Substring(selectNote.IndexOf('#') + 2);
                        NoteImportance.Text = sr.ReadLine();
                        Date.Text = sr.ReadLine();
                        NoteDescript.Text = sr.ReadToEnd();
                    }
                }
            }
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¬ы точно хотите удалить заметку?","—ообщение",MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            if (res == DialogResult.Yes)
            {
                string fp = $"C:/Users/Student_12/Desktop/Repos/Academy/Notes/{list_notes.SelectedItem.ToString()}";
                if(!fp.Contains(".txt"))
                {
                    fp += ".txt";
                }
                if (File.Exists(fp)) 
                {
                    File.Delete(fp);
                }
                list_notes.Items.Remove($"{NoteImportance.Text} # {NoteName.Text}");
                NoteName.Text = "";
                NoteDescript.Text = "";
                Date.Text = "";
            }
        }
    }
}