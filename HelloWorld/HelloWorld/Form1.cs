namespace HelloWorld
{
    public partial class Form1 : Form
    {
        private Toyota CT;
        private int meter;
        private int tmr_hit;
        public Form1()
        {
            InitializeComponent();
            CT = new Toyota("Corolla");
            CT.HitFromThePit += CT.HitHandler;
            meter = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DecrButtonClick(object sender, EventArgs e)
        {
            count -= 1;
            ShowText.Text = count.ToString();
        }
        private void IncrButtonClick(object sender, EventArgs e)
        {
            count += 1;
            ShowText.Text = count.ToString();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void _Timer_Tick(object sender, EventArgs e)
        {
            meter += CT.Speed;
            ShowMeter.Text = meter.ToString();
            ShowLife.Text = CT.Life.ToString();

            Random rand = new Random();
            if (rand.Next(1,5) == 3)
            {
                ShowHit.Visible = true;
                tmr_hit = 8;
                if (CT.HitHandler(1))
                {
                    _Timer.Stop();
                    ShowHit.Text = "Meters: " + meter.ToString();
                }
            }
            tmr_hit = tmr_hit > 0 ? tmr_hit - 1 : 0; 
        }

        private void Start_Click(object sender, EventArgs e)
        {
            _Timer.Enabled = true;
            _Timer.Start();
            ShowLife.Text = meter.ToString();
        }


    }
}
