namespace FuelCalculator
{
    public partial class Form1 : Form
    {
        private string data_path = "data.txt";
        private FileInfo data_file;
        private List<Car> carray;
        private string[] arr;
        public Form1()
        {
            InitializeComponent();
            data_file = new FileInfo(data_path);
            if (!data_file.Exists) { File.Create(data_path); }
            arr = File.ReadAllLines(data_file.FullName);
            carray = new List<Car>();
            for (int i = 0; i < arr.Length; i = i + 5)
            {
                Car neww = new Car(Int32.Parse(arr[i]), arr[i + 1], arr[i + 2], Double.Parse(arr[i + 3]), Double.Parse(arr[i + 4]));
                carray.Add(neww);
            }
        }
        private void ERRRRROR(string message)
        {/*
            MessageBox.Show($"Ты ,бубылда ,не ввёл {message}")*/
        }

        private void GasRB_CheckedChanged(object sender, EventArgs e)
        {
            GasCB.Visible = GasRB.Checked;
        }

        private void PetRB_CheckedChanged(object sender, EventArgs e)
        {
            PetCB.Visible = PetRB.Checked;
        }

        private void DiesRB_CheckedChanged(object sender, EventArgs e)
        {
            DiesCB.Visible = DiesRB.Checked;
        }

        private void AutRegB_Click(object sender, EventArgs e)
        {
            name_tb.Visible = true;
            GasRB.Visible = true;
            GasCB.Visible = GasRB.Checked;
            PetRB.Visible = true;
            PetCB.Visible = PetRB.Checked;
            DiesRB.Visible = true;
            DiesCB.Visible = DiesRB.Checked;
            label1.Visible = true;
            CarTypeCB.Visible = true;
            label2.Visible = true;
            FuelConsTB.Visible = true;
            label3.Visible = true;
            AvgSpdTB.Visible = true;

            RegFB.Visible = true;
            BackB.Visible = true;

            AutRegB.Visible = false;
            SchetB.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RegFB_Click(object sender, EventArgs e)
        {/*
            string er = "";
            if (name_tb.Text == "")*/

        }
    }
}
