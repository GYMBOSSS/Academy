using Microsoft.VisualBasic.ApplicationServices;
using System.Net.NetworkInformation;

namespace FuelCalculator
{
    public partial class Form1 : Form
    {
        private string data_path = "data.txt";
        private FileInfo data_file;
        private List<Car> carray;
        private string[] arr;
        private Form2 form2;
        string gr;
        double day_dis;
        double week_dis;
        double month_dis;
        public Form1()
        {
            InitializeComponent();
            gr = "";
            double day_dis = 0;
            double week_dis = 0;
            double month_dis = 0;
            data_file = new FileInfo(data_path);
            if (!data_file.Exists) { File.Create(data_path); }
            arr = File.ReadAllLines(data_file.FullName);
            carray = new List<Car>();
            for (int i = 0; i < arr.Length; i = i + 6)
            {
                Car neww = new Car(Int32.Parse(arr[i]), ToByte(arr[i + 1]), ToByte(arr[i + 2]), ToByte(arr[i + 3]), Double.Parse(arr[i + 4]), Double.Parse(arr[i + 5]));
                carray.Add(neww);
            }
        }

        public void retFromF2()
        {
            gr = form2.gr;
            day_dis = form2.day_dis;
            week_dis = form2.week_dis;
            month_dis = form2.month_dis;
        }

        byte[] ToByte(string str)
        {
            byte[] strBytes = System.Text.Encoding.Unicode.GetBytes(str);
            return strBytes;
        }
        private void ERROR(string message)
        {
            MessageBox.Show($"You ,bubilda ,didn't enter {message}, idi peredelay!", "ERRRRROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void RREGGED()
        {
            MessageBox.Show(" расава, зареган", "RRRRRREGGED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string T_fuel_type = GasCB.Text + PetCB.Text + DiesCB.Text;
            Car neww = new Car(carray.Count() + 1, ToByte(name_tb.Text), ToByte(CarTypeCB.Text), ToByte(T_fuel_type), Double.Parse(FuelConsTB.Text), Double.Parse(AvgSpdTB.Text));
            carray.Add(neww);
            name_tb.Clear(); FuelConsTB.Clear(); AvgSpdTB.Clear();
            if (arr.Length != 0)
            {
                File.AppendAllText(data_path, "\n" + neww.id);
            }
            else { File.AppendAllText(data_path, (neww.id).ToString()); }
            File.AppendAllText(data_path, "\n" + neww.name);
            File.AppendAllText(data_path, "\n" + neww.car_type);
            File.AppendAllText(data_path, "\n" + neww.fuel_type);
            File.AppendAllText(data_path, "\n" + neww.fuel_cons);
            File.AppendAllText(data_path, "\n" + neww.avg_speed);
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
        {
            string netu = "";
            List<string> netuarr = new List<string>();
            if (name_tb.Text == "") { netuarr.Add("name"); }
            if (GasCB.Text == "" ^ PetCB.Text == "" ^ DiesCB.Text == "") { netuarr.Add("fuel type"); }
            if (CarTypeCB.Text == "") { netuarr.Add("car type"); }
            if (FuelConsTB.Text == "") { netuarr.Add("fuel consumption"); }
            if (AvgSpdTB.Text == "") { netuarr.Add("average speed"); }
            netu = string.Join(',', netuarr);
            if (netu != "") { ERROR(netu); }
            else
            {
                RREGGED();
            }
        }

        private void BackB_Click(object sender, EventArgs e)
        {
            name_tb.Visible = false;
            GasRB.Visible = false;
            GasCB.Visible = false;
            PetRB.Visible = false;
            PetCB.Visible = false;
            DiesRB.Visible = false;
            DiesCB.Visible = false;
            label1.Visible = false;
            CarTypeCB.Visible = false;
            label2.Visible = false;
            FuelConsTB.Visible = false;
            label3.Visible = false;
            AvgSpdTB.Visible = false;

            RegFB.Visible = false;
            BackB.Visible = false;

            AutRegB.Visible = true;
            SchetB.Visible = true;
        }

        private void SchetB_Click(object sender, EventArgs e)
        {
            int k = 0;
            double[] arr = new double[7];
            List<Car> cars = new List<Car>();
            List<double> t = new List<double>();
            List<string> fuel_types = new List<string>();
            List<double> fuel_types_cons = new List<double>();
            for (int i = 0; i < carray.Count; i++)
            {
                if ((carray[i].car_type).ToString() == gr)
                {
                    cars.Add(carray[i]);
                    k++;
                }
            }
            double onday_percar = day_dis / k;
            for (int i = 0; i < cars.Count; i++)
            {
                if (fuel_types.Count == 0 || !fuel_types.Contains((cars[i].fuel_type).ToString()))
                {
                    fuel_types.Add((cars[i].fuel_type).ToString());
                    fuel_types_cons.Add(0);
                }
                for (int j = 0; j < fuel_types.Count; j++)
                {
                    if ((cars[i].fuel_type).ToString() == fuel_types[j])
                    {
                        fuel_types_cons[j] += onday_percar / cars[i].fuel_cons;
                    }
                }
            }
            for (int i = 0; i < fuel_types.Count; i++)
            {
                MessageBox.Show((fuel_types_cons[i]).ToString(), $"{fuel_types[i]} за сутки", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            fuel_types.Clear();
            fuel_types_cons.Clear();
            double onweek_percar = week_dis / k;
            for (int i = 0; i < cars.Count; i++)
            {
                if (fuel_types.Count == 0 || !fuel_types.Contains((cars[i].fuel_type).ToString()))
                {
                    fuel_types.Add((cars[i].fuel_type).ToString());
                    fuel_types_cons.Add(0);
                }
                for (int j = 0; j < fuel_types.Count; j++)
                {
                    if ((cars[i].fuel_type).ToString() == fuel_types[j])
                    {
                        fuel_types_cons[j] += onweek_percar / cars[i].fuel_cons;
                    }
                }
            }
            for (int i = 0; i < fuel_types.Count; i++)
            {
                MessageBox.Show((fuel_types_cons[i]).ToString(), $"{fuel_types[i]} за неделю", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            fuel_types.Clear();
            fuel_types_cons.Clear();
            double onmonth_percar = month_dis / k;
            for (int i = 0; i < cars.Count; i++)
            {
                if (fuel_types.Count == 0 || !fuel_types.Contains((cars[i].fuel_type).ToString()))
                {
                    fuel_types.Add((cars[i].fuel_type).ToString());
                    fuel_types_cons.Add(0);
                }
                for (int j = 0; j < fuel_types.Count; j++)
                {
                    if ((cars[i].fuel_type).ToString() == fuel_types[j])
                    {
                        fuel_types_cons[j] += onmonth_percar / cars[i].fuel_cons;
                    }
                }
            }
            for (int i = 0; i < fuel_types.Count; i++)
            {
                MessageBox.Show((fuel_types_cons[i]).ToString(), $"{fuel_types[i]} за мес€ц", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            fuel_types.Clear();
            fuel_types_cons.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2 = new Form2(this);
            form2.Owner = this;
            form2.ShowDialog();
        }
    }
}
