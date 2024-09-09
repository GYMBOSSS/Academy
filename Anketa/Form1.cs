namespace Anketa
{
    public partial class Form1 : Form
    {
        private string reposway = "C:\\Repos\\Academy\\Anketa\\UserData.txt";
        private FileInfo reposfile;
        List <User> userarr;
        string[] arr;
        public Form1()
        {
            InitializeComponent();
            reposfile = new FileInfo(reposway);
            userarr = new List <User> ();
            if (!reposfile.Exists)
            {
                File.Create(reposway);
            }
            arr = File.ReadAllLines(reposfile.FullName);
            for (int i = 0; i < arr.Length; i = i + 6)
            {
                userarr[i / 6] = new User(arr[i], arr[i+1], arr[i + 2], arr[i + 3], arr[i + 4], arr[i + 5]);
            }

        }
        private void ERROR(string message)
        {
            MessageBox.Show($"�� �� ��� {message}, ��� ���������", "ERRRRRROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            FIOTB.Clear(); MNTB.Clear(); HNTB.Clear(); WPTB.Clear();
        }
        private void REGGED()
        {
            MessageBox.Show("�������, �������", "RRRRRREGGED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string Gender;
            string MobNumber;
            string HomNumber;
            if (MGRB.Checked) { Gender = "Male"; }
            else { Gender = "Female"; }
            if(!MNCHB.Checked) { MobNumber = "�� �������"; }
            else { MobNumber = MNTB.Text; }
            if (!HNCHB.Checked) { HomNumber = "�� �������"; }
            else { HomNumber = HNTB.Text; }
            User neww = new User(FIOTB.Text,WPTB.Text, MobNumber, HomNumber, Gender, PWTB.Text);
            userarr.Add(neww);
            FIOTB.Clear(); MNTB.Clear(); HNTB.Clear(); WPTB.Clear();
            File.AppendAllText(reposway, neww.FIO);
            File.AppendAllText(reposway, neww.WorPl);
            File.AppendAllText(reposway, neww.MobNum);
            File.AppendAllText(reposway, neww.HomNum);
            File.AppendAllText(reposway, neww.Gen);
            File.AppendAllText(reposway, neww.PassWord);
        }

        private void REGB_Click(object sender, EventArgs e)
        {
            string netu = "";
            List<string> netuarr = new List<string>();
            if (FIOTB.Text == "") { netuarr.Add("�������"); }
            if (WPTB.Text == "") { netuarr.Add("����� ������"); }
            if (HNCHB.Checked) { if (HNTB.Text == "") { netuarr.Add("�������� �������"); } }
            if (MNCHB.Checked) { if (MNTB.Text == "") { netuarr.Add("��������� �������"); } }
            if (!MGRB.Checked & !FGRB.Checked) { netuarr.Add("���"); }
            netu = string.Join(',', netuarr);
            if (netu == "") { REGGED(); }
            else { ERROR(netu); }
        }

        private void MNCHB_CheckedChanged(object sender, EventArgs e)
        {
            MNTB.Visible = MNCHB.Checked;
            label6.Visible = !MNCHB.Checked;
        }

        private void HNCHB_CheckedChanged(object sender, EventArgs e)
        {
            HNTB.Visible = HNCHB.Checked;
            label7.Visible = !HNCHB.Checked;
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = !MNCHB.Checked;
            label7.Visible = !HNCHB.Checked;
            label8.Visible = true;
            FIOTB.Visible = true;
            WPTB.Visible = true;
            HNCHB.Visible = true;
            HNTB.Visible = (bool)HNCHB.Checked;
            MNCHB.Visible = true;
            MNTB.Visible = (bool)MNCHB.Checked;
            MGRB.Visible = true;
            FGRB.Visible = true;
            REGB.Visible = true;
            PWTB.Visible = true;
            
            Registration.Visible = false;
            Enter.Visible = false;
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < arr.Length; i = i + 6)
        }
    }
}
