using System.Text;

namespace Классная_работа_со_второй_формой
{
    public partial class Form1 : Form
    {
        public Form2 f2;
        public AdminForm f3;
        string[][] arr;
        string name;
        string password;
        public Form1()
        {
            InitializeComponent();
            arr = new string[2][] { new string[2] { "Admin", "Admin" }, new string[2] { "Alex", "Alex1234" } };
        }
        public void F()
        {
            if (name == arr[0][0] || password == arr[0][1])
            {
                EnterB.Visible = false;
                for (int i = 1; i < arr.Length; i++)
                {
                    AdminCB.Items.Add(arr[i][0]);
                }
                EnterB.Visible = false;
                AdminB.Visible = true;
                AdminCB.Visible = true;
            }
            else
            {
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i][0] == name || arr[i][1] == password)
                    {
                        MessageBox.Show("Поздравляю, вы вошли", "Ку-ку", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        public void RecieveData(string name, string password)
        {
            this.name = name;
            this.password = password;
            F();
            f2.Close();
        }
        public string[][] RetArr()
        {
            return arr;
        }
        private void EnterB_Click(object sender, EventArgs e)
        {
            f2 = new Form2(this);
            f2.Owner = this;
            f2.ShowDialog();
        }

        private void AdminB_Click(object sender, EventArgs e)
        {
            f3 = new AdminForm(this);
            f3.Owner = this;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i][0] == AdminCB.Text)
                {
                    f3.RecieveData(AdminCB.Text, arr[i][1]);
                }
            }

        }
    }
}
