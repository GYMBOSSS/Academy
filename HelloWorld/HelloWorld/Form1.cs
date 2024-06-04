namespace HelloWorld
{
    public partial class Form1 : Form
    {
        private Toyota CT;
        private double meter;
        private int tmr_hit;
        private bool ingame = false;
        private int tmr_meter;
        private Point spawn = new Point(36,186);
        public Form1()
        {
            InitializeComponent();
            CT = new Toyota("Corolla");
            CT.HitFromThePit += CT.HitHandler;
            meter = 0;
            tmr_meter = 0;
            CT.Y = Player.Left;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DecrButtonClick(object sender, EventArgs e)
        {
            CT.Speed -= 1;
            ShowText.Text = CT.Speed.ToString();
        }
        private void IncrButtonClick(object sender, EventArgs e)
        {
            CT.Speed += 1;
            ShowText.Text = CT.Speed.ToString();
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
            Player.Location = CT.update_Point(spawn);

            meter = Math.Round(meter + CT.Speed * 0.1, 1);

            tmr_meter++;
            if (tmr_meter % 100 == 0)
            {
                ShowMeter.Text = meter.ToString();
            }

            ShowMeter.Text = meter.ToString();
            ShowLife.Text = CT.Life.ToString();

            Random rand = new Random();
            if (rand.Next(1, 5) == 3)
            {
                ShowHit.Visible = true;
                tmr_hit = 8;
                if (CT.HitHandler(1))
                {
                    ShowHit.Text = "Meters: " + meter.ToString();
                }
                else
                {
                    _Timer.Stop();
                }
            }
            tmr_hit = tmr_hit > 0 ? tmr_hit - 1 : 0;
            BG1.Left -= CT.Speed * 5;
            BG2.Left -= CT.Speed * 5;
            if (BG1.Left < -616)
            {
                BG1.Left = 0;
                BG2.Left = BG1.Right;
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            _Timer.Enabled = true;
            _Timer.Start();
            ShowLife.Text = CT.Life.ToString();
            ShowMeter.Text = meter.ToString();

            CT.Life = 30;
            CT.Speed = 5;
            meter = 0;

            Restart.Visible = true;
            StopResume.Visible = true;
            Start.Visible = false;

            Restart.Enabled = true;
            StopResume.Enabled = true;
            Start.Enabled = false;

            ingame = true;
        }

        private void StopResume_Click(object sender, EventArgs e)
        {
            if (ingame)
            {
                _Timer.Stop();
                StopResume.Text = "Resume";
                ingame = false;
            }
            else
            {
                _Timer.Start();
                StopResume.Text = "Stop";
                ingame = true;
            }

        }

        private void Restart_Click(object sender, EventArgs e)
        {
            Start_Click(sender, e);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space) { }
        }
    }
}
