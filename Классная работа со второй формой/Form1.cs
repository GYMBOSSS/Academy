namespace Классная_работа_со_второй_формой
{
    public partial class Form1 : Form
    {
        public Form2 f2;
        string[][] arr;
        string name;
        string password;
        public Form1()
        {
            InitializeComponent();
            arr = new string[2][]  { new string[2]{ "Admin", "Admin" }, new string[2]{ "Alex", "Alex1234" } };
        }
<<<<<<< HEAD
        public void RecieveData(string name, string password)
        {
            this.name = name;
            this.password = password;
        }

=======
        public string[][] RetArr()
        {
            return arr;
        }
>>>>>>> 171cef1b1868d7aedc47b1da3092222d97442005
        private void EnterB_Click(object sender, EventArgs e)
        {
            f2 = new Form2(this);
            f2.Owner = this;
            f2.ShowDialog();
        }
    }
}
