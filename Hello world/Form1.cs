using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;

namespace Hello_world
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private int accelG = 4;
        private int accelH = 2;
        private int speed = 6;

        private void timer1_Tick(object sender, EventArgs e)
        {
            speed += accelG - accelH;
            if (player.Top >= Floor.Top - player.Height)
            {
                player.Top = Floor.Top - player.Height;
                speed = 0;
            }
            speed += accelG - accelH;
            player.Top += speed;

            if (accelH > 0) accelH -= 1;
            else accelH = 0;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Start.Visible = false;
            Jump.Visible = true;
        }

        private void Jump_Click(object sender, EventArgs e)
        {

        }
    }
}
